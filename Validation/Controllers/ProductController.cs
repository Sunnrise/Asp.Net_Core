using Microsoft.AspNetCore.Mvc;

namespace Validation.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult GetProducts()
        {
            return View();
        }

        public IActionResult CreateProduct()
        {
            return View();
        }
    } 
}
        

