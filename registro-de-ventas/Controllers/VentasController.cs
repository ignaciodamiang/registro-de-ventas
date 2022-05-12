using Microsoft.AspNetCore.Mvc;
using registro_de_ventas.Models;
using registro_de_ventas.Services;

namespace registro_de_ventas.Controllers
{
    public class VentasController : Controller
    {
        private readonly IVentasService _ventasService;

        public VentasController(IVentasService ventasService)
        {
            _ventasService = ventasService;
        }

        [HttpGet]
        public IActionResult RegistrarVenta()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RegistrarVenta(VentaViewModel nuevaVenta)
        {
            if(ModelState.IsValid)
            {
                _ventasService.RegistrarVenta(nuevaVenta);
            }
            return RedirectToAction(nameof(Resultados));
        }

        [HttpGet]
        public IActionResult Resultados()
        {
            return View(_ventasService.Resultados());
        }
    }
}
