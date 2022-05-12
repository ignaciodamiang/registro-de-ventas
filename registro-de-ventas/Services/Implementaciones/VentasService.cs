using registro_de_ventas.Controllers;
using registro_de_ventas.Models;
using System.Collections.Generic;

namespace registro_de_ventas.Services.Implementaciones
{
    public class VentasService : IVentasService
    {
        private static List<VentaViewModel> _ventas = new List<VentaViewModel>()
        {
            new VentaViewModel() { Id =1, Cliente = "Juan", CantidadVendida = 1, PrecioUnitario = 100 },
        };

        public IEnumerable<VentaViewModel> Resultados()
        {
            return _ventas;
        }
        
        public void RegistrarVenta(VentaViewModel ventaNueva)
        {
            _ventas.Add(ventaNueva);
        }
    }
}
