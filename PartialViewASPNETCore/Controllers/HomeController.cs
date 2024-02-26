using Microsoft.AspNetCore.Mvc;
using PartialViewASPNETCore.Models;
using System.Diagnostics;

namespace PartialViewASPNETCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Products()
        {
            List<Product> products = new List<Product>()
            {
                new Product { Id = 1,Name= "Shoes", Description="Casual Men's Shoes",Price=2000.00,Image="~/Images/Shoes.png"},
                new Product { Id = 2,Name= "Sun Glass", Description="Premium Sun Glass",Price=1700.00,Image="~/Images/glasses.png"},
                new Product { Id = 3,Name= "Wrist Watch", Description="Casual Men's watch",Price=1100.00,Image="~/Images/watch.png"}
            };
            return View(products);
        }

        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Privacy()
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