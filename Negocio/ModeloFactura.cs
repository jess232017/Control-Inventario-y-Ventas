using Datos.Repositorio;
using Entidad;
using Negocio.Utils;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Negocio
{
    public class ModeloFactura : IModelo
	{
		private readonly RepositorioFactura repositorio;
		public EFactura Entidad { get; set; }
		public string Mensaje { get; set; }
		public Accion Accion { get; set; }
		public bool Exito { get; set; }

        public ModeloFactura()
        {
			repositorio = new RepositorioFactura();
			Entidad = new EFactura();
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

		public EFactura LeerEntidad()
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
				return new EFactura();
			}
		}

		public List<EFactura> LeerLista()
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
				return new List<EFactura>();
			}
		}
	}
}