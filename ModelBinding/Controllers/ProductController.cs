using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelBinding.Models;

namespace ModelBinding.Controllers
{
    public class AjaxData
    {
        public string A { get; set; }
        public string B { get; set; }

    }
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

        //[HttpPost]
        //public IActionResult CatchData(string txtValue1,string txtValue2,string txtValue3)
        //{


        //    return View();
        //}
        //[HttpPost]
        //public IActionResult CatchData(Product product)// We can use IFormCollection, Product, or any other class as with all the properties that we want to bind
        //{


        //    return View();
        //}
        //public IActionResult CatchData(string a, string b)
        ////https://localhost:44317/product/catchdata?a=5&b=a
        //{
        //    return View();
        //}

        //public IActionResult CatchData(string id)
        //{
        //    var values = Request.RouteValues;


        //    //var queryString = Request.QueryString; // We can check the Endpoint which has been sent request for additional parameter from QueryString
        //    //var a =Request.Query["a"].ToString(); // We can get the value of the parameter from QueryString
        //    //var b = Request.Query["b"].ToString();
        //    return View();

        [HttpPost]
        public IActionResult CatchData(AjaxData ajaxData)
        {

            //var headers = Request.Headers;// We can check the headers of the request that has been sent to the endpoint.




            return View();
          
        }
        
        }
        //public class QueryData
        //{
        //    public string a { get; set; }
        //    public string b { get; set; }
        //}

    }
//public class CatchData
//{
//    public string txtValue1 { get; set; }
//    public string txtValue2 { get; set; }
//    public string txtValue3 { get; set; }
//}

