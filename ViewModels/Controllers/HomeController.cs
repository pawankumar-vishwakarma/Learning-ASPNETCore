using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ViewModels.Models;

namespace ViewModels.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            List<Student> students = new List<Student>
            {
                new Student {Id = 1, Name ="Pawal",Gender="Male",Standard=10},
                new Student {Id = 2, Name ="Pradeep",Gender="Male",Standard=11},
                new Student {Id = 3, Name ="Saumya",Gender="Female",Standard=9}
            };

            List<Teacher> teachers = new List<Teacher>
            {
                new Teacher {Id = 1, Name ="Dinesh", Qualification = "MSC",Salary=20000},
                new Teacher {Id = 1, Name ="Dinesh", Qualification = "MCA",Salary=25000},
                new Teacher {Id = 1, Name ="Dinesh", Qualification = "BE",Salary=26000},
            };
            CollegeViewModel cvm = new CollegeViewModel()
            {
                MyStudents = students,
                MyTearchers = teachers
            };
            return View(cvm);
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