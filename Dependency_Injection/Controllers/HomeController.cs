using Dependency_Injection.Models;
using Dependency_Injection.Services;
using Dependency_Injection.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Dependency_Injection.Controllers
{
    public class HomeController : Controller
    {

        //readonly ILog _log;

        //public HomeController(ILog log)
        //{
        //    _log = log;
        //}

        public IActionResult Index([FromServices]ILog log)
        {
            //_log.Log();
            log.Log();
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
