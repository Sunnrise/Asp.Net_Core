using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Validation.Models;

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

        [HttpPost]  
        public IActionResult CreateProduct(Product model)
        {
            //ModelState is a property of the Controller which can check a types data annotations and return a boolean value
            if (!ModelState.IsValid)
            {
                //Loggin the error
                ViewBag.Errmsg = ModelState.Values.FirstOrDefault(x => x.ValidationState== Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid).Errors[2].ErrorMessage;

                return null;
              

            }
            //If the model is valid, the user will be redirected to the GetProducts view

            //return View("GetProducts", model);


            return View();
        }
    } 
}
        

