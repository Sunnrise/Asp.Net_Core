using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text.Json;
using View_and_Razor.Models;
using View_and_Razor.Models.ViewModels;

namespace View_and_Razor.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            //var products = new List<Product>
            //{
            //    new Product{ Id=1, ProductName= "A product", Quantity=10},
            //    new Product{ Id=2, ProductName= "B product", Quantity=20},
            //    new Product{ Id=3, ProductName= "C product", Quantity=30}
            //};
            #region Model Based Sending Data
            //return View(products);
            #endregion
            #region Data Transfer Controls
            #region ViewBag
            //The data which is sent to the view is stored in the ViewBag property of the Controller class. ViewBag is a dynamic property, so you can store any type of data in it.
            //ViewBag.Products = products;
            #endregion
            #region ViewData
            //ViewData transfers data which is kept in action methods to the view. ViewData is boxing the data(object) and we will unboxing it in the view.
            //ViewData["Products"] = products;
            #endregion
            #region TempData
            //TempData is used to pass data from the current request to the subsequent request (means redirecting from one page to another).
           //string data= JsonSerializer.Serialize(products);

            //TempData["Products"] = products;
            //TempData["X"] = 5;
            //ViewBag.X = 10;
            //ViewData["X"] = 15;
            #endregion

            #endregion
            return View();
            //return RedirectToAction("Index2");
        }
        public IActionResult Index2()
        {
            //var v1 =ViewBag.X;
            //var v2 = ViewData["X"];
            //var v3 = TempData["X"];
            //var data = TempData["Products"].ToString();
            //JsonSerializer.Deserialize<List<Product>>(data);
            return View();
        }
        public IActionResult GetProducts()
        {
            Product product = new Product
            {
                Id=1,
                ProductName="A product",
                Quantity=10
            };
            User user = new User
            {
                Id = 1,
                Name = "Alperen",
                LastName="Güneş"
            };
            UserProduct userProduct = new UserProduct
            {
                User = user,
                Product = product
            };

            return View(userProduct);
        }
    }
}
