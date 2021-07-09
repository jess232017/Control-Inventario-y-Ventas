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
    public class RepositorioFormaPago : Repositorio
    {
		public int Agregar(EFormaPago entity)
		{
			return ExecuteNonQuery("SP_FormaPagoInsertar",
				new SqlParameter("@Nombre", entity.Nombre),
				new SqlParameter("@Descripcion", entity.Descripcion));
		}

		public int Actualizar(EFormaPago entity)
		{
			return ExecuteNonQuery("SP_FormaPagoActualizar",
				new SqlParameter("@IdForma", entity.IdForma),
				new SqlParameter("@Nombre", entity.Nombre),
				new SqlParameter("@Descripcion", entity.Descripcion));
		}

		public int Eliminar(EFormaPago entity)
		{
			return ExecuteNonQuery("SP_FormaPagoEliminar",
				new SqlParameter("@IdForma", entity.IdForma));
		}

		public DataTable LeerTabla(EFormaPago entity)
		{
			return ExecuteReader("SP_FormaPagoSeleccionar",
				new SqlParameter("@IdForma", SafeNull(entity.IdForma)));
		}

		public EFormaPago LeerEntidad(EFormaPago entity)
		{
			DataRow row = LeerTabla(entity).Rows[0];
			return new EFormaPago
			{
				IdForma = row.Field<int>("IdForma"),
				Nombre = row.Field<string>("Nombre"),
				Descripcion = row.Field<string>("Descripcion"),
			};
		}

		public List<EFormaPago> LeerLista(EFormaPago entity)
		{
			return LeerTabla(entity).AsEnumerable().Select(row =>
			new EFormaPago
			{
				IdForma = row.Field<int>("IdForma"),
				Nombre = row.Field<string>("Nombre"),
				Descripcion = row.Field<string>("Descripcion"),
			}).ToList();
		}

	}
}
