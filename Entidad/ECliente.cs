using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Entidad.ValueObjects;

namespace Entidad
{
	public class ECliente : BaseEntidad
	{
		public int? IdCliente { get; set; }

		[Required(ErrorMessage = "El Nombre no debe estar vacio")]
		public string Nombre { get; set; }

		[Required(ErrorMessage = "El Apellido no debe estar vacio")]
		public string Apellido { get; set; }

		public string Telefono { get; set; }

		public bool Estado { get; set; }

		public byte[] Imagen { get; set; }
	}
}
