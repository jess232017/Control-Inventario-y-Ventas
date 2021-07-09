using Datos.Repositorio;
using Entidad;
using Negocio.Utils;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Negocio
{
    public class ModeloLote : IModelo
	{
		private readonly RepositorioLote repositorio;
		public ELote Entidad { get; set; }
		public string Mensaje { get; set; }
		public Accion Accion { get; set; }
		public bool Exito { get; set; }

        public ModeloLote()
        {
			repositorio = new RepositorioLote();
			Entidad = new ELote();
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

		public ELote LeerEntidad()
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
				return new ELote();
			}
		}

		public List<ELote> LeerLista()
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
				return new List<ELote>();
			}
		}
	}
}