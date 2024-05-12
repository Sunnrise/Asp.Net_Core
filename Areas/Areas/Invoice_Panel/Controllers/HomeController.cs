using Microsoft.AspNetCore.Mvc;

namespace Areas.Areas.Invoice_Panel.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
