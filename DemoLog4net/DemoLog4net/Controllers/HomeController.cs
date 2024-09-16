using DemoLog4net.Helper;
using DemoLog4net.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoLog4net.Controllers
{
    public class HomeController(LogHelper logHelper) : Controller
    {


        public IActionResult Index()
        {
            logHelper.Info($"Access Home/Index {DateTime.Now.ToString()}");
            logHelper.Error($"Access Home/Index {DateTime.Now.ToString()}");
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
