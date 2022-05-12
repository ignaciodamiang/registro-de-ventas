using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using registro_de_ventas.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace registro_de_ventas.Controllers
{
    public class PresentacionController : Controller
    {
        
        public PresentacionController()
        {
           
        }
        [HttpGet]
        public IActionResult Bienvenido()
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
