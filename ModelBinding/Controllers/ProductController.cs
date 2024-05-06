using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Http;
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
        //public IActionResult CreateProduct()
        //{
        //    var product = new Product()
        //    {
        //        ProductName = "Z Product",
        //        Quantity = 22 
        //    };
        //    return View(product);
        //}
        //[HttpPost]
        ////public IActionResult CreateProduct(string txtProductName,string txtQuantity)
        //public IActionResult CreateProduct(Product product)
        //{
        //    return View();
        //}
        public IActionResult CreateProduct()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult CatchData(IFormCollection  datas)
        //{
        //    var value1 = datas["txtValue1"].ToString();
        //    var value2 = datas["txtValue2"];
        //    var value3 = datas["txtValue3"];

        //    return View();
        //}
        [HttpPost]
        public IActionResult CatchData(string txtValue1,string txtValue2,string txtValue3)
        {
          

            return View();
        }

    }
}
