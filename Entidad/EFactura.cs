using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
	public class EFactura
	{
		public int? IdFactura { get; set; }
		public int IdEmpleado { get; set; }
		public int IdCliente { get; set; }
		public int IdForma { get; set; }
		public DateTime FechaVenta { get; set; }
		public float Total { get; set; }
		public float SubTotal { get; set; }
		public float PagoCon { get; set; }
		public string Comentario { get; set; }
		public string Estado { get; set; }
	}
}
