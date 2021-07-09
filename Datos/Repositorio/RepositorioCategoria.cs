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
    public class RepositorioCategoria : Repositorio
    {
		public int Agregar(ECategoria entity)
		{
			return ExecuteNonQuery("SP_CategoriaInsertar",
				new SqlParameter("@Nombre", entity.Nombre),
				new SqlParameter("@PorDefecto", entity.PorDefecto),
				new SqlParameter("@Descripcion", entity.Descripcion));
		}

		public int Actualizar(ECategoria entity)
		{
			return ExecuteNonQuery("SP_CategoriaActualizar",
				new SqlParameter("@IdCategoria", entity.IdCategoria),
				new SqlParameter("@Nombre", entity.Nombre),
				new SqlParameter("@PorDefecto", entity.PorDefecto),
				new SqlParameter("@Descripcion", entity.Descripcion));
		}

		public int Eliminar(ECategoria entity)
		{
			return ExecuteNonQuery("SP_CategoriaEliminar",
				new SqlParameter("@IdCategoria", entity.IdCategoria));
		}

		public DataTable LeerTabla(ECategoria entity)
		{
			return ExecuteReader("SP_CategoriaSeleccionar",
				new SqlParameter("@IdCategoria", SafeNull(entity.IdCategoria)));
		}

		public ECategoria LeerEntidad(ECategoria entity)
		{
			DataRow row = LeerTabla(entity).Rows[0];
			return new ECategoria
			{
				IdCategoria = row.Field<int>("IdCategoria"),
				Nombre = row.Field<string>("Nombre"),
				PorDefecto = row.Field<bool>("PorDefecto"),
				Descripcion = row.Field<string>("Descripcion"),
			};
		}

		public List<ECategoria> LeerLista(ECategoria entity)
		{
			return LeerTabla(entity).AsEnumerable().Select(row =>
			new ECategoria
			{
				IdCategoria = row.Field<int>("IdCategoria"),
				Nombre = row.Field<string>("Nombre"),
				PorDefecto = row.Field<bool>("PorDefecto"),
				Descripcion = row.Field<string>("Descripcion"),
			}).ToList();
		}

	}
}
