using Microsoft.AspNetCore.Mvc;
using ModelsInAspNetCore.Models;
using ModelsInAspNetCore.Repository;
using System.Diagnostics;

namespace ModelsInAspNetCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StudentRepository _studentRepository = null;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _studentRepository = new StudentRepository();
        }

        public List<StudentModel> GetStudents()
        {
            return _studentRepository.getAllStudents();
        }

        public StudentModel GetStudent(int id)
        {
            return _studentRepository.getStudentById(id);
        }
        public IActionResult Index()
        {
            var students = new List<StudentModel>
            {
                new StudentModel{id= 0,name="Pawan",age=23, gender="Male"},
                new StudentModel{id= 1,name="Manish",age=25, gender="Male"},
                new StudentModel{id= 2,name="Shital",age=21, gender="Female"}
            };
            ViewData["student"] = students;
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