﻿using Microsoft.AspNetCore.Antiforgery;
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
            return View();
        }
        [HttpPost]
        //public IActionResult CreateProduct(string txtProductName,string txtQuantity)
        public IActionResult CreateProduct(Product product)
        {
            return View();
        }

    }
}
