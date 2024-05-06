using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Mvc;
using ModelBinding.Models;

namespace ModelBinding.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult GetProducts()
        {
            return View();
        }
        public IActionResult CreateProduct()
        {
            var product = new Product()
            {
                ProductName = "Z Product",
                Quantity = 22 
            };
            return View(product);
        }
        [HttpPost]
        //public IActionResult CreateProduct(string txtProductName,string txtQuantity)
        public IActionResult CreateProduct(Product product)
        {
            return View();
        }

    }
}
