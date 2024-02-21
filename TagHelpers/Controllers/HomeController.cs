using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TagHelpers.Models;

namespace TagHelpers.Controllers
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
        [HttpPost]
        public string Index(Employee emp)
        {
            return "Name: "+ emp.Name+" Gender: "+emp.Gender+" Age: "+emp.Age+" Designation: "+emp.Designation+" Salary: "+emp.Salary+" Married: "+emp.Married+" Description: "+emp.Description;
        }

        //public IActionResult Contact()
        //{
        //    return View();
        //}

        public int Edit(int id)
        {
            return id;
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