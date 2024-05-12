using Microsoft.AspNetCore.Mvc;

namespace Areas.Areas.Admin_Panel.Controllers
{
    [Area("Admin_Panel")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            TempData["Message"] = "Hello from Admin Panel";

            return RedirectToAction("Index", "Home", new {area= "Invoice_Panel" });
        }
    }
}
