using Microsoft.AspNetCore.Mvc;
using FinalProject.Data;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var products = _context.Products.Include(p => p.Category).ToList();
            return View(products);
        }

        // other actions...
    }
}
