using Microsoft.AspNetCore.Mvc;
using SerilogDemo.Models;
using System.Diagnostics;

namespace SerilogDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
    

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _logger.LogInformation("HomeController controller called ");
            NLog.Logger nlogger = NLog.LogManager.GetCurrentClassLogger();
            nlogger.Log(NLog.LogLevel.Info, "HomeController controller called ");
        }

        public IActionResult Index()
        {
            _logger.LogInformation("HomeController Index controller called ");
            NLog.Logger nlogger = NLog.LogManager.GetCurrentClassLogger();
            nlogger.Log(NLog.LogLevel.Info, "HomeController Index controller called ");
            return View();
        }
         

        public IActionResult Privacy()
        {
            _logger.LogInformation("HomeController Privacy controller called ");
            NLog.Logger nlogger = NLog.LogManager.GetCurrentClassLogger();
            nlogger.Log(NLog.LogLevel.Info, "HomeController Privacy controller called ");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            _logger.LogInformation("HomeController Error controller called ");
            NLog.Logger nlogger = NLog.LogManager.GetCurrentClassLogger();
            nlogger.Log(NLog.LogLevel.Info, "HomeController Error controller called ");
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
       // write a public method that returns a string in reverse order
       public string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}