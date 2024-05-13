using Configuration_appsettings_files.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Configuration_appsettings_files.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;
        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            var v1= _configuration["SampleText"]; 
            var v2 = _configuration["Person"];
            var v3 = _configuration["Person:Name"];
            var v4 = _configuration["Person:Surname"];
            var v5 = _configuration["Logging:LogLevel:Microsoft.Hosting.Lifetime"];

            var v6 =_configuration.GetSection("Person");
            var v7 = _configuration.GetSection("Person:Name");
          

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
