﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using View_and_Razor.Models;

namespace View_and_Razor.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product{ Id=1, ProductName= "A product", Quantity=10},
                new Product{ Id=2, ProductName= "B product", Quantity=20},
                new Product{ Id=3, ProductName= "C product", Quantity=30}
            };
            #region Model Based Sending Data
            return View(products);
            #endregion
            #region Data Transfer Controls
            #region ViewBag

            #endregion
            #region ViewData
            #endregion
            #region TempData
            #endregion

            #endregion

           // return View();
        }
    }
}
