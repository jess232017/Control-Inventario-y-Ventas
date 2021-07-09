using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorio
{
    public class RepositorioTienda : Repositorio
    {
		public int Agregar(ETienda entity)
		{
			return ExecuteNonQuery("SP_TiendaInsertar",
				new SqlParameter("@Nombre", entity.Nombre),
				new SqlParameter("@Direccion", entity.Direccion),
				new SqlParameter("@Departamento", entity.Departamento),
				new SqlParameter("@Anuncio", entity.Anuncio),
				new SqlParameter("@RUC", entity.RUC));
		}

		public int Actualizar(ETienda entity)
		{
			return ExecuteNonQuery("SP_TiendaActualizar",
				new SqlParameter("@IdTienda", entity.IdTienda),
				new SqlParameter("@Nombre", entity.Nombre),
				new SqlParameter("@Direccion", entity.Direccion),
				new SqlParameter("@Departamento", entity.Departamento),
				new SqlParameter("@Anuncio", entity.Anuncio),
				new SqlParameter("@RUC", entity.RUC));
		}

		public int Eliminar(ETienda entity)
		{
			return ExecuteNonQuery("SP_TiendaEliminar",
				new SqlParameter("@IdTienda", entity.IdTienda));
		}

		public DataTable LeerTabla(ETienda entity)
		{
			return ExecuteReader("SP_TiendaSeleccionar",
				new SqlParameter("@IdTienda", SafeNull(entity.IdTienda)));
		}

		public ETienda LeerEntidad(ETienda entity)
		{
			DataRow row = LeerTabla(entity).Rows[0];
			return new ETienda
			{
				IdTienda = row.Field<int>("IdTienda"),
				Nombre = row.Field<string>("Nombre"),
				Direccion = row.Field<string>("Direccion"),
				Departamento = row.Field<string>("Departamento"),
				Anuncio = row.Field<string>("Anuncio"),
				RUC = row.Field<string>("RUC"),
			};
		}

		public List<ETienda> LeerLista(ETienda entity)
		{
			return LeerTabla(entity).AsEnumerable().Select(row =>
			new ETienda
			{
				IdTienda = row.Field<int>("IdTienda"),
				Nombre = row.Field<string>("Nombre"),
				Direccion = row.Field<string>("Direccion"),
				Departamento = row.Field<string>("Departamento"),
				Anuncio = row.Field<string>("Anuncio"),
				RUC = row.Field<string>("RUC"),
			}).ToList();
		}

	}
}
