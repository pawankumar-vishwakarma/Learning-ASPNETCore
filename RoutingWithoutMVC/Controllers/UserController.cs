using Microsoft.AspNetCore.Mvc;

namespace RoutingWithoutMVC.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            //ViewData["Data"] = "PawanKumar";
            //ViewData["Data2"] = DateTime.Now.ToLongDateString();
            string[] arr = { "Mango", "Apple", "Banana" };
            ViewData["Array1"] = arr;
            //ViewData["Data3"] = new List<string>()
            //{
            //    "Flute","Guitar","Piano"
            //};


            //ViewBag.Data1 = "PawanKumar";
            //ViewBag.Data2 = 23;
            //string[] arr = new string[] { "Guitar", "Flute", "Piano" };
            //ViewBag.arr1 = arr;


            TempData["Data1"] = "TempData";
            TempData.Keep("Data1");
            return View();
        }
        public IActionResult About()
        {
            ViewData["Data1"] = "PawanKumar";
            TempData.Keep("Data1");
            return View();
        }
        public IActionResult Contact()
        {
            TempData.Keep("Data1");
            return View();
        }
    }
}
