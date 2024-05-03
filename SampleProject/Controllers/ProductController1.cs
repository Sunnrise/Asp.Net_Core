using Microsoft.AspNetCore.Mvc;
using SampleProject.Models;

namespace SampleProject.Controllers
{
    public class ProductController : Controller
    {
        #region ViewResult
        //public ViewResult GetProducts()
        //{
        //    ViewResult result = View();
        //    return result;

        //}
        #endregion
        #region PartialViewResult
        //public PartialViewResult GetProducts()
        //{
        //    PartialViewResult result = PartialView();

        //    return result;

        //}
        #endregion
        #region JsonResult
        //public JsonResult GetProducts()
        //{
        //    JsonResult result = Json(new Product 
        //    { Id = 1,
        //      ProductName = "Laptop",
        //      Quantity=15
        //    });
        //    return result;
        //}
        #endregion
        #region EmptyResult
        public EmptyResult GetProducts()
        {
            return new EmptyResult();
        }
        //or
        public void GetProducts1()
        {
            //return new EmptyResult();
        }
        #endregion
        #region ContentResult
        #endregion
        #region ActionResult
        #endregion
        #region IActionResult

        #endregion
    }
}
