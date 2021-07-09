using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
	public class EInventario
	{
		public int? IdInventario { get; set; }
		public int IdMovimiento { get; set; }
		public int IdProducto { get; set; }
		public string Motivo { get; set; }
		public DateTime Fecha { get; set; }
		public string Estado { get; set; }
		public int Cantidad { get; set; }
		public float CostoUnit { get; set; }
		public float SubTotal { get; set; }
		public float Total { get; set; }
		public string Nota { get; set; }
	}
}
