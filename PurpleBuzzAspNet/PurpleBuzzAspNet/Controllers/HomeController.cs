using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PurpleBuzzAspNet.DAL;
using PurpleBuzzAspNet.Models;
using PurpleBuzzAspNet.ViewModels;

namespace PurpleBuzzAspNet.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context) { _context = context; }

        public async Task<IActionResult> Index()
        {
            HomeVM homeVM = new HomeVM()
            {
                Sliders = await _context.Sliders.ToListAsync(),
                Categories = await _context.Categories.ToListAsync(),
                Products = await _context.Products
                .Include(s => s.Category)
                .Include(s => s.ProductImages)
                .OrderByDescending(s => s.Id)
                .Take(10)
                .ToListAsync(),
            };
            return View(homeVM);
        }
    }
}