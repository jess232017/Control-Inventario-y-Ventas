using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Datos.Repositorio
{
    public class RepositorioFactura : Repositorio
    {
		public int Agregar(EFactura entity)
		{
			return ExecuteNonQuery("SP_FacturaInsertar",
				new SqlParameter("@IdEmpleado", entity.IdEmpleado),
				new SqlParameter("@IdCliente", entity.IdCliente),
				new SqlParameter("@IdForma", entity.IdForma),
				new SqlParameter("@FechaVenta", entity.FechaVenta),
				new SqlParameter("@Total", entity.Total),
				new SqlParameter("@SubTotal", entity.SubTotal),
				new SqlParameter("@PagoCon", entity.PagoCon),
				new SqlParameter("@Comentario", SafeNull(entity.Comentario)),
				new SqlParameter("@Estado", entity.Estado));
		}

		public int Actualizar(EFactura entity)
		{
			return ExecuteNonQuery("SP_FacturaActualizar",
				new SqlParameter("@IdFactura", entity.IdFactura),
				new SqlParameter("@IdEmpleado", entity.IdEmpleado),
				new SqlParameter("@IdCliente", entity.IdCliente),
				new SqlParameter("@IdForma", entity.IdForma),
				new SqlParameter("@FechaVenta", entity.FechaVenta),
				new SqlParameter("@Total", entity.Total),
				new SqlParameter("@SubTotal", entity.SubTotal),
				new SqlParameter("@PagoCon", entity.PagoCon),
				new SqlParameter("@Comentario", entity.Comentario),
				new SqlParameter("@Estado", entity.Estado));
		}

		public int Eliminar(EFactura entity)
		{
			return ExecuteNonQuery("SP_FacturaEliminar",
				new SqlParameter("@IdFactura", entity.IdFactura));
		}

		public DataTable LeerTabla(EFactura entity)
		{
			return ExecuteReader("SP_FacturaSeleccionar",
				new SqlParameter("@IdFactura", SafeNull(entity.IdFactura)));
		}

		public EFactura LeerEntidad(EFactura entity)
		{
			DataRow row = LeerTabla(entity).Rows[0];
			return new EFactura
			{
				IdFactura = row.Field<int>("IdFactura"),
				IdEmpleado = row.Field<int>("IdEmpleado"),
				IdCliente = row.Field<int>("IdCliente"),
				IdForma = row.Field<int>("IdForma"),
				FechaVenta = row.Field<DateTime>("FechaVenta"),
				Total = (float)GetSafeValue(row["Total"], typeof(float)),
				SubTotal = (float)GetSafeValue(row["SubTotal"], typeof(float)),
				PagoCon = (float)GetSafeValue(row["PagoCon"], typeof(float)),
				Comentario = row.Field<string>("Comentario"),
				Estado = row.Field<string>("Estado"),
			};
		}

		public List<EFactura> LeerLista(EFactura entity)
		{
			return LeerTabla(entity).AsEnumerable().Select(row =>
			new EFactura
			{
				IdFactura = row.Field<int>("IdFactura"),
				IdEmpleado = row.Field<int>("IdEmpleado"),
				IdCliente = row.Field<int>("IdCliente"),
				IdForma = row.Field<int>("IdForma"),
				FechaVenta = row.Field<DateTime>("FechaVenta"),
				Total = (float)GetSafeValue(row["Total"], typeof(float)),
				SubTotal = (float)GetSafeValue(row["SubTotal"], typeof(float)),
				PagoCon = (float)GetSafeValue(row["PagoCon"], typeof(float)),
				Comentario = row.Field<string>("Comentario"),
				Estado = row.Field<string>("Estado"),
			}).ToList();
		}

	}
}
