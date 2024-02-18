using Microsoft.AspNetCore.Mvc;

namespace RoutingWithoutMVC.Controllers
{
    [Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        [Route("")]
        [Route("~/")]
        [Route("~/Home")]

        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult About() 
        {
            return View();
        }
    }
}
