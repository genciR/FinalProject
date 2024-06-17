using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Smartphone_Shop.Models;
using Smartphone_Shop.Models.BusinessModel;
using Smartphone_Shop.Models.Repositories;
using Smartphone_Shop.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Smartphone_Shop.Controllers
{
    public class PhoneController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IMapper _mapper;
        private readonly IPhoneRepository _phoneRepository;
        private readonly ILogger<PhoneController> _logger;
        public PhoneController(AppDbContext db, IMapper mapper, IPhoneRepository phoneRepository, ILogger<PhoneController> logger)
        {
            _logger = logger;
            _db = db;
            _mapper = mapper;
            _phoneRepository = phoneRepository;
        }

        [HttpGet]
        public IActionResult List(string price, int? id)
        {
            var phoneList = _phoneRepository.getAllPhones(id);

            if(price == "asc")
            {
                phoneList = phoneList.OrderBy(p => p.Price).ToList();
            }
            else if(price == "desc")
            {
                phoneList = phoneList.OrderByDescending(p => p.Price).ToList();
            }
            
            var allBrands = _phoneRepository.allBrands;
            var result = _mapper.Map<PhoneListViewModel>(phoneList);
            result = _mapper.Map(allBrands, result);
            if (id != null)
            {
                ViewData["currentBrand"] = _db.Brand.Find(id).Name;
            }

            return View(result);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var phoneDM = _phoneRepository.getPhoneById(id);
            if (phoneDM == null)
            {
                return NotFound();
            }

            var result = _mapper.Map<PhoneBM>(phoneDM);

            return View(result);
        }

        [HttpGet]
        public IActionResult CreatePhone()
        {
            if (User.IsInRole("Admin"))
            {
                ViewData["Brands"] = _db.Brand.ToList();
                ViewData["Cpus"] = _db.Cpu.ToList();
                ViewData["SimTypes"] = _db.SimType.ToList();
                ViewData["UsbTypes"] = _db.UsbType.ToList();
                ViewData["DisplayTypes"] = _db.DisplayType.ToList();
                ViewData["OpSystems"] = _db.OpSystem.ToList();
                ViewData["Colors"] = _db.Color.ToList();
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home", ViewBag.AccessErrorMsg = "Access denied");
            }
        }

        [HttpPost]
        public IActionResult CreatePhone(Phone obj)
        {
            if (!ModelState.IsValid)
            {
                ViewData["Brands"] = _db.Brand.ToList();
                ViewData["Cpus"] = _db.Cpu.ToList();
                ViewData["SimTypes"] = _db.SimType.ToList();
                ViewData["UsbTypes"] = _db.UsbType.ToList();
                ViewData["DisplayTypes"] = _db.DisplayType.ToList();
                ViewData["OpSystems"] = _db.OpSystem.ToList();
                ViewData["Colors"] = _db.Color.ToList();
                return View(obj);
            }
            else
            {
                _phoneRepository.AddNewPhone(obj);
                return RedirectToAction("List");
            }
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                _logger.LogWarning("Edit operation halted. No ID provided.");
                return NotFound();
            }

            var phone = await _db.Phone
                .Include(p => p.Brand)
                .Include(p => p.Cpu)
                .Include(p => p.Color)
                .Include(p => p.DisplayType)
                .Include(p => p.OpSystem)
                .Include(p => p.SimType)
                .Include(p => p.UsbType)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (phone == null)
            {
                _logger.LogWarning($"Edit operation halted. No phone found with ID {id}.");
                return NotFound();
            }

            PrepareDropdowns(phone);
            return View(phone);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int id, Phone model)
        {
            if (id != model.Id)
            {
                _logger.LogWarning("Mismatch between route ID and phone ID during edit operation.");
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                _logger.LogWarning("Model state is invalid for editing phone ID {id}.");
                foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
                {
                    _logger.LogError($"Error in ModelState: {error.ErrorMessage}");
                }
                PrepareDropdowns(model);
                return View(model);
            }

            var phone = await _db.Phone.FirstOrDefaultAsync(p => p.Id == id);
            if (phone == null)
            {
                return NotFound();
            }

            try
            {
                _db.Entry(phone).CurrentValues.SetValues(model);
                await _db.SaveChangesAsync();
                _logger.LogInformation($"Phone ID {id} updated successfully.");
                return RedirectToAction("Details", new { id = phone.Id });
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError(ex, "An error occurred while updating the phone.");
                PrepareDropdowns(model);
                ModelState.AddModelError("", "An error occurred while updating the phone.");
                return View(model);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An unexpected error occurred while updating the phone.");
                PrepareDropdowns(model);
                ModelState.AddModelError("", "An unexpected error occurred while updating the phone.");
                return View(model);
            }
        }

        private void PrepareDropdowns(Phone phone = null)
        {
            ViewBag.Brands = new SelectList(_db.Brand.ToList(), "Id", "Name", phone?.BrandId);
            ViewBag.Cpus = new SelectList(_db.Cpu.ToList(), "Id", "ModelName", phone?.CpuId);
            ViewBag.Colors = new SelectList(_db.Color.ToList(), "Id", "Name", phone?.ColorId);
            ViewBag.DisplayTypes = new SelectList(_db.DisplayType.ToList(), "Id", "Name", phone?.DisplayTypeId);
            ViewBag.OpSystems = new SelectList(_db.OpSystem.ToList(), "Id", "Name", phone?.OpSystemId);
            ViewBag.SimTypes = new SelectList(_db.SimType.ToList(), "Id", "Name", phone?.SimTypeId);
            ViewBag.UsbTypes = new SelectList(_db.UsbType.ToList(), "Id", "Name", phone?.UsbTypeId);
        }

        /*private async Task PopulateDropdownsAsync(Phone phone)
        {
            ViewBag.Brands = new SelectList(await _db.Brand.ToListAsync(), "Id", "Name", phone.BrandId);
            ViewBag.Cpus = new SelectList(await _db.Cpu.ToListAsync(), "Id", "ModelName", phone.CpuId);

            // Populate other dropdowns similarly if needed
        }*/
        private bool PhoneExists(int id)
        {
            return _db.Phone.Any(e => e.Id == id);
        }


       

        /*
                private async Task PopulateDropdownsAsync(Phone phone)
                {
                    var brands = await _db.Brand.ToListAsync();
                    ViewBag.Brands = new SelectList(brands, "Id", "Name", phone.BrandId);

                    var cpus = await _db.Cpu.ToListAsync();
                    ViewBag.Cpus = new SelectList(cpus, "Id", "ModelName", phone.CpuId);

                    // Populate other dropdowns similarly if needed
        private void PopulateDropdowns(Phone phone)
        {
            ViewBag.Cpus = new SelectList(_db.Cpu.ToList(), "Id", "ModelName", phone.CpuId);
            ViewBag.Brands = new SelectList(_db.Brand.ToList(), "Id", "Name", phone.BrandId);
            // Populate other necessary ViewBag data here
        }

                }*/




        [HttpGet]
        public IActionResult CreateCpu()
        {
            if (User.IsInRole("Admin"))
            {
                Cpu cpu = new Cpu();
                return View(cpu);
            }
            else
            {
                return RedirectToAction("Index", "Home", ViewBag.AccessErrorMsg = "Access to admin options denied!");
            }
        }

        [HttpPost]
        public IActionResult CreateCpu(Cpu cpu)
        {
            if (!ModelState.IsValid)
            {
                return View(cpu);
            }
            else
            {
                _db.Cpu.Add(cpu);
                _db.SaveChanges();
                return RedirectToAction("CreatePhone");
            }
        }

        [HttpGet]
        public IActionResult CreateBrand()
        {
            if (User.IsInRole("Admin"))
            {
                Brand brand = new Brand();
                return View(brand);
            }
            else
            {
                return RedirectToAction("Index", "Home", ViewBag.AccessErrorMsg = "Access to admin options denied!");
            }
        }


        [HttpPost]
        public IActionResult CreateBrand(Brand brand)
        {
            if (!ModelState.IsValid)
            {
                return View(brand);
            }
            else
            {
                _db.Brand.Add(brand);
                _db.SaveChanges();
                return RedirectToAction("CreatePhone");
            }
        }


        public IActionResult DeletePhone(int id)
        {
            _phoneRepository.DeletePhone(id);
            return RedirectToAction("List");
        }
    }
}
