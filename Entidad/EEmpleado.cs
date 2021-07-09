using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
	public class EEmpleado
	{
		public int? IdEmpleado { get; set; }
		public int IdTienda { get; set; }
		public int IdRol { get; set; }
		public string Nombres { get; set; }
		public string Apellidos { get; set; }
		public string Usuario { get; set; }
		public string Clave { get; set; }
		public byte[] Foto { get; set; }
		public string Correo { get; set; }
		public string Estado { get; set; }
	}
}
