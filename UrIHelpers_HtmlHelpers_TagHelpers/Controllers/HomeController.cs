using Microsoft.AspNetCore.Mvc;

namespace UrIHelpers_HtmlHelpers_TagHelpers.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
