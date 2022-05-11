using Microsoft.AspNetCore.Mvc;

namespace registro_de_ventas.Controllers
{
    public class VentasController : Controller
    {
        public IActionResult RegistrarVenta()
        {
            return View();
        }

        public IActionResult Resultados()
        {
            return View();
        }
    }
}
