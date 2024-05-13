using Environment.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Environment.Controllers
{
    public class HomeController : Controller
    {
        readonly IWebHostEnvironment _webHostEnvironment;
        IConfiguration _configuration;

        public HomeController(IWebHostEnvironment webHostEnvironment, IConfiguration configuration)
        {
            _webHostEnvironment = webHostEnvironment;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            var value_a = _configuration["a"];// Environment variables crush the appsettings.json and appsettings.Development.json and secrets.json

            if (_webHostEnvironment.IsDevelopment())
                ViewBag.Environment = "Development";
            else if (_webHostEnvironment.IsProduction())
                ViewBag.Environment = "Production";
            else if (_webHostEnvironment.IsStaging())
                ViewBag.Environment = "Staging";
            else
                ViewBag.Environment = "Custom environment";
            
            

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
