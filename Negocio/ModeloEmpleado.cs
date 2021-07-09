using Datos.Repositorio;
using Entidad;
using Negocio.Utils;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Negocio
{
    public class ModeloEmpleado : IModelo
	{
		private readonly RepositorioEmpleado repositorio;
		public EEmpleado Entidad { get; set; }
		public string Mensaje { get; set; }
		public Accion Accion { get; set; }
		public bool Exito { get; set; }

        public ModeloEmpleado()
        {
			repositorio = new RepositorioEmpleado();
			Entidad = new EEmpleado();
		}

		public int Accionar()
		{
			int Result = 0;
			try
			{
				switch (Accion)
				{
					case Accion.Agregar:
						Exito = true;
						Result = repositorio.Agregar(Entidad);
						Mensaje = "Se ha registrado correctamente";
						break;
					case Accion.Actualizar:
						Exito = true;
						Result = repositorio.Actualizar(Entidad);
						Mensaje = "Se ha editado correctamente";
						break;
					case Accion.Eliminar:
						Exito = true;
						Result = repositorio.Eliminar(Entidad);
						Mensaje = "Se ha Eliminar correctamente";
						break;
					default:
						Exito = false;
						Mensaje = "No se especificó ninguna acción";
						break;
				}
			}
			catch (SqlException ex)
			{
				Exito = false;
				Mensaje = ex.Message;
			}
			return Result;
		}

		public DataTable LeerTabla()
		{
			try
			{
				Exito = true;
				Mensaje = "Operacion exitosa";
				return repositorio.LeerTabla(Entidad);
			}
			catch (SqlException ex)
			{
				Mensaje = ex.Message;
				Exito = false;
				return new DataTable();
			}
		}

		public EEmpleado LeerEntidad()
		{
			try
			{
				Exito = true;
				Mensaje = "Operacion exitosa";
				return repositorio.LeerEntidad(Entidad);
			}
			catch (SqlException ex)
			{
				Mensaje = ex.Message;
				Exito = false;
				return new EEmpleado();
			}
		}

		public List<EEmpleado> LeerLista()
		{
			try
			{
				Exito = true;
				Mensaje = "Operacion exitosa";
				return repositorio.LeerLista(Entidad);
			}
			catch (SqlException ex)
			{
				Mensaje = ex.Message;
				Exito = false;
				return new List<EEmpleado>();
			}
		}
	}
}