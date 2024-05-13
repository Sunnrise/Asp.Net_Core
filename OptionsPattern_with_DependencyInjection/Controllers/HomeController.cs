using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using OptionsPattern_with_DependencyInjection.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace OptionsPattern_with_DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        #region IConfiguration
        //private readonly IConfiguration _configuration;
        //public HomeController(IConfiguration configuration)
        //{
        //    _configuration = configuration;
        //}
        //public IActionResult Index()
        //{
        //    string host = _configuration["MailInfo:MailHost"];
        //    string port = _configuration["MailInfo:MailPort"];

        //    MailInfo mailInfo = _configuration.GetSection("MailInfo").Get<MailInfo>();


        //    return View();
        //}
        #endregion

        #region IOption
        MailInfo _mailInfo;
        public HomeController(IOptions<MailInfo>mailInfo)
        {
            _mailInfo = mailInfo.Value;
        }
        public IActionResult Index()
        {

            

            return View();
        }
        #endregion




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
