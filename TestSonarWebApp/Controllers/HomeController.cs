using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestSonarWebApp.Models;

namespace TestSonarWebApp.Controllers
{
    public class HomeController : Controller
    {
        public string Hello = "Hello";
        public IActionResult Index()
        {
            string Hello = "Hello";
            int mandatory = 1;
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            string Error = "Hello Error";
            int mandatoryError = 1;
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
