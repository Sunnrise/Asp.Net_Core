using Microsoft.AspNetCore.Mvc;

namespace Areas.Areas.Invoice_Panel.Controllers
{
    [Area("Invoice_Panel")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
