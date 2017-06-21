using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Esta es una app de .NET Core y Docker";
            ViewData["SistemaOperativo"] = System.Runtime.InteropServices.RuntimeInformation.OSDescription;
            ViewData["IdContenedor"] = System.Environment.MachineName;

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
