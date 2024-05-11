using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Layout.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
           

            return View();
        }
        public IActionResult Page1()
        {
            return View();
        }
        public IActionResult Page2()
        {
            return View();
        }

    }

}
