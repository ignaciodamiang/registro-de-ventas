using registro_de_ventas.Models;
using System.Collections.Generic;

namespace registro_de_ventas.Services
{
    public interface IVentasService
    {
        IEnumerable<VentaViewModel> Resultados();
        void RegistrarVenta(VentaViewModel equipoNuevo);
    }
}
