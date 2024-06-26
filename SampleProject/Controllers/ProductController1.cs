﻿using Microsoft.AspNetCore.Mvc;
using SampleProject.Models;

namespace SampleProject.Controllers
{
    [NonController]//This attribute is used to exclude a public class from the controller.
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
        //public EmptyResult GetProducts()
        //{
        //    return new EmptyResult();
        //}
        ////or
        //public void GetProducts1()
        //{
        //    //return new EmptyResult();
        //}
        #endregion
        #region ContentResult
        //public ContentResult GetProducts()
        //{
        //    ContentResult result = Content("This is a content result");
        //    return result;
        //}
        #endregion
        #region ActionResult
        //public ActionResult GetProducts()
        //{
        //   if (true)
        //    {
        //        return Json(new object());
        //    }
        //    else if (true)
        //    {
        //        return Content("This is a content result");
        //    }
        //    else
        //    {
        //        return View();
        //    }
        // ActionResult is the base class for all the result types in ASP.NET Core MVC.
        //}
        #endregion
        #region IActionResult
        public IActionResult Index()
        {
            X();
            return View();
        }
        [NonAction]//This attribute is used to exclude a public method from the controller.
        public void X()
        {

        }
        // IActionResult is the base interface for all the result types in ASP.NET Core MVC.
        #endregion
    }
}   

