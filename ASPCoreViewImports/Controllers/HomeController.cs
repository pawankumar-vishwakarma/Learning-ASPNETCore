using Microsoft.AspNetCore.Mvc;
using ASPCoreViewImports.Models;

namespace ASPCoreViewImports.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new List<Student>
            {
                new Student {Id= 1, Name="Pawan",Standard=12},
                new Student {Id=2, Name="Dinesh",Standard=11}
            };
            return View(students);
        }
        public IActionResult About()
        {
            List<Student> students = new List<Student>
            {
                new Student {Id= 1, Name="Pawan",Standard=12},
                new Student {Id=2, Name="Dinesh",Standard=11}
            };
            return View(students);
        }
        public IActionResult Contact()
        {
            List<Student> students = new List<Student>
            {
                new Student {Id= 1, Name="Pawan",Standard=12},
                new Student {Id=2, Name="Dinesh",Standard=11}
            };
            return View(students);
        }

    }
}
