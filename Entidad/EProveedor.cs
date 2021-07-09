using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
	public class EProveedor
	{
		public int? IdProveedor { get; set; }
		public string Empresa { get; set; }
		public string Contacto { get; set; }
		public string Direccion { get; set; }
		public bool Estado { get; set; }
		public string Celular { get; set; }
		public byte[] Foto { get; set; }
	}
}
