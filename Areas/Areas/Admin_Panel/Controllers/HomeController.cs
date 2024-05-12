using Microsoft.AspNetCore.Mvc;

namespace Areas.Areas.Admin_Panel.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
