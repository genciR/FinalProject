using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Smartphone_Shop.Models;
using Smartphone_Shop.Models.Repositories;
using Smartphone_Shop.Models.ViewModels;
using System;
using System.Diagnostics;

namespace Smartphone_Shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _db;
        private readonly IMapper _mapper;
        private readonly IPhoneRepository _phoneRepository;

        public HomeController(ILogger<HomeController> logger, AppDbContext db, IPhoneRepository phoneRepository, IMapper mapper)
        {
            this._logger = logger;
            this._db = db;
            this._phoneRepository = phoneRepository;
            this._mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var phoneList = _phoneRepository.getHotOfferPhones();
            var result = _mapper.Map<PhoneListViewModel>(phoneList);

            return View(result);
        }

        [HttpGet]
        public IActionResult Location()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
