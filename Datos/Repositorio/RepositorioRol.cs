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
   public class RepositorioRol : Repositorio
    {

		public int Agregar(ERol entity)
		{
			return ExecuteNonQuery("SP_RolInsertar",
				new SqlParameter("@Rol", entity.Rol),
				new SqlParameter("@Descripcion", entity.Descripcion));
		}

		public int Actualizar(ERol entity)
		{
			return ExecuteNonQuery("SP_RolActualizar",
				new SqlParameter("@IdRol", entity.IdRol),
				new SqlParameter("@Rol", entity.Rol),
				new SqlParameter("@Descripcion", entity.Descripcion));
		}

		public int Eliminar(ERol entity)
		{
			return ExecuteNonQuery("SP_RolEliminar",
				new SqlParameter("@IdRol", entity.IdRol));
		}

		public DataTable LeerTabla(ERol entity)
		{
			return ExecuteReader("SP_RolSeleccionar",
				new SqlParameter("@IdRol", SafeNull(entity.IdRol)));
		}

		public ERol LeerEntidad(ERol entity)
		{
			DataRow row = LeerTabla(entity).Rows[0];
			return new ERol
			{
				IdRol = row.Field<int>("IdRol"),
				Rol = row.Field<string>("Rol"),
				Descripcion = row.Field<string>("Descripcion"),
			};
		}

		public List<ERol> LeerLista(ERol entity)
		{
			return LeerTabla(entity).AsEnumerable().Select(row =>
			new ERol
			{
				IdRol = row.Field<int>("IdRol"),
				Rol = row.Field<string>("Rol"),
				Descripcion = row.Field<string>("Descripcion"),
			}).ToList();
		}

	}
}
