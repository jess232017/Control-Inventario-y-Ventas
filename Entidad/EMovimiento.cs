using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
	public class EMovimiento
	{
		public int? IdMovimiento { get; set; }
		public int IdEmpleado { get; set; }
		public int IdCaja { get; set; }
		public string Estado { get; set; }
		public DateTime FechaInicio { get; set; }
		public DateTime? FechaFin { get; set; }
		public float DineroInicial { get; set; }
		public float? DineroCierre { get; set; }
		public float? Saldo { get; set; }
		public float? Diferencia { get; set; }
	}
}
