using Microsoft.AspNetCore.Mvc;

namespace UrIHelpers_HtmlHelpers_TagHelpers.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult GetProducts()
        {
            ViewBag.Message = "Hello World";
            return View();
        }
    }
}
