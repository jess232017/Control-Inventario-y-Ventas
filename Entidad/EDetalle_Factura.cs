using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
	public class EDetalle_Factura
	{
		public int? IdDetalleFactura { get; set; }
		public int IdProducto { get; set; }
		public int IdFactura { get; set; }
		public float Precio { get; set; }
		public float Cantidad { get; set; }
		public float? Descuento { get; set; }
		public bool? AlPorMayor { get; set; }
	}
}
