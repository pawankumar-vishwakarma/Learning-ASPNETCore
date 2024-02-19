using Microsoft.AspNetCore.Mvc;
using ModelDataUsingViewData.Models;
using System.Diagnostics;

namespace ModelDataUsingViewData.Controllers
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
            //Employee emp = new Employee()
            //{
            //    EmpId = 1,
            //    EmpName = "Shubham",
            //    Designation = "Developer",
            //    Salary = 25000

            //};
            //ViewData["Employee"] = emp;
            //ViewBag.Employee = emp;
            //TempData["Employee"] = emp;

            List<Employee> employees = new List<Employee>()
            { 
                new Employee {EmpId = 101,EmpName = "Pawan",Designation = "Devloper",Salary = 25000},
                new Employee {EmpId = 102,EmpName = "Raj",Designation = "SDE II",Salary = 30000},
                new Employee {EmpId = 103,EmpName = "Shubham",Designation = "Tester",Salary = 20000},
                new Employee {EmpId = 104,EmpName = "Rajesh",Designation = "DBA",Salary = 25000},
                new Employee {EmpId = 105,EmpName = "Nikhil",Designation = "Data Analyst",Salary = 21000}

            };
            ViewData["Employees"] = employees;

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