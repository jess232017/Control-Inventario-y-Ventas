using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
	public class ELote
	{
		public int? IdLote { get; set; }
		public int IdProducto { get; set; }
		public int IdProveedor { get; set; }
		public string Lote { get; set; }
		public bool Fragil { get; set; }
		public int Cantidad { get; set; }
		public float CostoUnidad { get; set; }
		public DateTime FechaRegistro { get; set; }
		public DateTime? FechaVence { get; set; }
		public bool Agotado { get; set; }
		public string Observacion { get; set; }
	}
}
