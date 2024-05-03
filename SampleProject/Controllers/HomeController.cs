using Microsoft.AspNetCore.Mvc;

namespace SampleProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
