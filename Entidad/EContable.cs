using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class EContable
    {
		public int? IdContable { get; set; }
		public int IdMovimiento { get; set; }
		public DateTime FechaRegistro { get; set; }
		public float Monto { get; set; }
		public string Motivo { get; set; }
		public string Tipo { get; set; }
		public string Nota { get; set; }
	}
}
