using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
//using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreWebApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Tina just created a ASP.Net Core web application!";
            return View();
        }

        public IActionResult Error()
        {
            ViewData["Message"] = "We've encountered an error :(";
            return View();
        }

        public IActionResult BadCode()
        {
            try
            {
                ViewData["Message"] = "Test try catch block";
                return View();
            }
            catch
            {
                return Error();
            }            
        }
    }
}
