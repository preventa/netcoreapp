using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using CoreWebApp.Data;

namespace CoreWebApp.Controllers
{
    public class HomeController : Controller
    {

        public async Task<IActionResult> Index()
        {
            ViewData["Message"] = "Esta es una app de .NET Core y Docker... Mola!!";
            ViewData["SistemaOperativo"] = String.Concat("El sistema operativo: ", System.Runtime.InteropServices.RuntimeInformation.OSDescription);
            ViewData["IdContenedor"] = String.Concat("La máquina / contenedor: ", System.Environment.MachineName);

            try
            {
                IPGeographicalLocation model = await IPGeographicalLocation.QueryGeographicalLocationAsync(Request.HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString());

                if (String.IsNullOrEmpty(model.CountryName))
                {
                    ViewData["Location"] = "El pais y ciudad: Recuerda que en localhost esto no va.";
                }
                else
                {
                    ViewData["Location"] = String.Format("El país y ciudad: {0}, {1}", model.CountryName, model.City);
                }                
            }
            catch (Exception)
            {
                ViewData["Location"] = "El pais y ciudad: Va a ser que ahora no.";
            }
            

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
