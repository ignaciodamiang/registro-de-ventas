using System.ComponentModel.DataAnnotations;

namespace registro_de_ventas.Models
{
    public class VentaViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo Cliente es obligatorio")]
        [StringLength(maximumLength: 50, ErrorMessage = "El campo Cliente debe tener una longitud máxima de 50 caracteres")]
        public string Cliente { get; set; }
        [Required(ErrorMessage = "El campo Cantidad Vendida es obligatorio")]
        [Range(1, 300, ErrorMessage = "El campo Cantidad Vendida debe estar entre 1 y 300")]
        public int CantidadVendida { get; set; }
        [Required(ErrorMessage = "El campo Precio Unitario es obligatorio")]
        [Range(10, 1000, ErrorMessage = "El campo Precio Unitario debe estar entre 10 y 1000")]
        public int PrecioUnitario { get; set; }
        public int TotalVenta => CantidadVendida * PrecioUnitario;

    }
}
