using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class ECaja
    {
		public int? IdCaja { get; set; }
		public string Descripcion { get; set; }
		public string Serial_PC { get; set; }
		public string Impresora_Ticket { get; set; }
		public string Impresora_A4 { get; set; }
		public bool Estado { get; set; }
	}
}
