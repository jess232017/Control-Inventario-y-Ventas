using Entidad.ValueObjects;
using System.ComponentModel.DataAnnotations;

namespace Entidad
{
	public class EProducto : BaseEntidad
	{
		public int? IdProducto { get; set; }

		[Required(ErrorMessage = "Debe elegir una Categoria")]
		public int IdCategoria { get; set; }

		[Required(ErrorMessage = "El Nombre del producto es requerido")]
		public string Descripcion { get; set; }

		[Required(ErrorMessage = "La Marca del producto es requerido")]
		public string Marca { get; set; }
		public bool Inventariado { get; set; }
		public int Cantidad { get; set; }

		[Range(1, float.MaxValue, ErrorMessage = "Precio de venta debe ser mayor a {0} y menor a {1}")]
		public float PrecioVenta { get; set; }

		[StringLength(5, ErrorMessage = "El codigo QR debe ser de al menos 5 Digitos")]
		public string CodigoQR { get; set; }
		public byte[] Imagen { get; set; }

		[Range(1, int.MaxValue, ErrorMessage = "El Stock minimo debe ser mayor a {0} y menor a {1}")]
		public int? StockMinimo { get; set; }

		public bool Granel { get; set; }
	}
}
