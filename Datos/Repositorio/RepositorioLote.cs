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
    public class RepositorioLote : Repositorio
    {
		public int Agregar(ELote entity)
		{
			return ExecuteNonQuery("SP_LoteInsertar",
				new SqlParameter("@IdProducto", entity.IdProducto),
				new SqlParameter("@IdProveedor", entity.IdProveedor),
				new SqlParameter("@Lote", entity.Lote),
				new SqlParameter("@Fragil", entity.Fragil),
				new SqlParameter("@Cantidad", entity.Cantidad),
				new SqlParameter("@CostoUnidad", entity.CostoUnidad),
				new SqlParameter("@FechaRegistro", entity.FechaRegistro),
				new SqlParameter("@FechaVence", entity.FechaVence),
				new SqlParameter("@Agotado", entity.Agotado),
				new SqlParameter("@Observacion", entity.Observacion));
		}

		public int Actualizar(ELote entity)
		{
			return ExecuteNonQuery("SP_LoteActualizar",
				new SqlParameter("@IdLote", entity.IdLote),
				new SqlParameter("@IdProducto", entity.IdProducto),
				new SqlParameter("@IdProveedor", entity.IdProveedor),
				new SqlParameter("@Lote", entity.Lote),
				new SqlParameter("@Fragil", entity.Fragil),
				new SqlParameter("@Cantidad", entity.Cantidad),
				new SqlParameter("@CostoUnidad", entity.CostoUnidad),
				new SqlParameter("@FechaRegistro", entity.FechaRegistro),
				new SqlParameter("@FechaVence", entity.FechaVence),
				new SqlParameter("@Agotado", entity.Agotado),
				new SqlParameter("@Observacion", entity.Observacion));
		}

		public int Eliminar(ELote entity)
		{
			return ExecuteNonQuery("SP_LoteEliminar",
				new SqlParameter("@IdLote", entity.IdLote));
		}

		public DataTable LeerTabla(ELote entity)
		{
			return ExecuteReader("SP_LoteSeleccionar",
				new SqlParameter("@IdLote", SafeNull(entity.IdLote)));
		}

		public ELote LeerEntidad(ELote entity)
		{
			DataRow row = LeerTabla(entity).Rows[0];
			return new ELote
			{
				IdLote = row.Field<int>("IdLote"),
				IdProducto = row.Field<int>("IdProducto"),
				IdProveedor = row.Field<int>("IdProveedor"),
				Lote = row.Field<string>("Lote"),
				Fragil = row.Field<bool>("Fragil"),
				Cantidad = row.Field<int>("Cantidad"),
				CostoUnidad = (float)GetSafeValue(row["CostoUnidad"], typeof(float)),
				FechaRegistro = row.Field<DateTime>("FechaRegistro"),
				FechaVence = row.Field<DateTime>("FechaVence"),
				Agotado = row.Field<bool>("Agotado"),
				Observacion = row.Field<string>("Observacion"),
			};
		}

		public List<ELote> LeerLista(ELote entity)
		{
			return LeerTabla(entity).AsEnumerable().Select(row =>
			new ELote
			{
				IdLote = row.Field<int>("IdLote"),
				IdProducto = row.Field<int>("IdProducto"),
				IdProveedor = row.Field<int>("IdProveedor"),
				Lote = row.Field<string>("Lote"),
				Fragil = row.Field<bool>("Fragil"),
				Cantidad = row.Field<int>("Cantidad"),
				CostoUnidad = (float)GetSafeValue(row["CostoUnidad"], typeof(float)),
				FechaRegistro = row.Field<DateTime>("FechaRegistro"),
				FechaVence = row.Field<DateTime>("FechaVence"),
				Agotado = row.Field<bool>("Agotado"),
				Observacion = row.Field<string>("Observacion"),
			}).ToList();
		}
	}
}
