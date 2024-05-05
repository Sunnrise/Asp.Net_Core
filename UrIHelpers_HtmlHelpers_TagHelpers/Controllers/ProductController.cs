using Microsoft.AspNetCore.Mvc;
using UrIHelpers_HtmlHelpers_TagHelpers.Models;

namespace UrIHelpers_HtmlHelpers_TagHelpers.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult GetProducts()
        {
            //ViewBag.Message = "Hello World";
            //User u = new User
            //{
            // LastName="Sun"

            //};
            //return View(u);
            return View();
        }
    }
}
