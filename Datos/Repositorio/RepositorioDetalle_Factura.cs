using Entidad;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Datos.Repositorio
{
    public class RepositorioDetalle_Factura : Repositorio
    {
		public int Agregar(EDetalle_Factura entity)
		{
			return ExecuteNonQuery("SP_Detalle_FacturaInsertar",
				new SqlParameter("@IdProducto", entity.IdProducto),
				new SqlParameter("@IdFactura", entity.IdFactura),
				new SqlParameter("@Precio", entity.Precio),
				new SqlParameter("@Cantidad", entity.Cantidad),
				new SqlParameter("@Descuento", entity.Descuento),
				new SqlParameter("@AlPorMayor", entity.AlPorMayor));
		}

		public int Actualizar(EDetalle_Factura entity)
		{
			return ExecuteNonQuery("SP_Detalle_FacturaActualizar",
				new SqlParameter("@IdDetalleFactura", entity.IdDetalleFactura),
				new SqlParameter("@IdProducto", entity.IdProducto),
				new SqlParameter("@IdFactura", entity.IdFactura),
				new SqlParameter("@Precio", entity.Precio),
				new SqlParameter("@Cantidad", entity.Cantidad),
				new SqlParameter("@Descuento", entity.Descuento),
				new SqlParameter("@AlPorMayor", entity.AlPorMayor));
		}

		public int Eliminar(EDetalle_Factura entity)
		{
			return ExecuteNonQuery("SP_Detalle_FacturaEliminar",
				new SqlParameter("@IdDetalleFactura", entity.IdDetalleFactura));
		}

		public DataTable LeerTabla(EDetalle_Factura entity)
		{
			return ExecuteReader("SP_Detalle_FacturaSeleccionar",
				new SqlParameter("@IdDetalleFactura", SafeNull(entity.IdDetalleFactura)));
		}

		public EDetalle_Factura LeerEntidad(EDetalle_Factura entity)
		{
			DataRow row = LeerTabla(entity).Rows[0];
			return new EDetalle_Factura
			{
				IdDetalleFactura = row.Field<int>("IdDetalleFactura"),
				IdProducto = row.Field<int>("IdProducto"),
				IdFactura = row.Field<int>("IdFactura"),
				Precio = (float)GetSafeValue(row["Precio"], typeof(float)),
				Cantidad = (float)GetSafeValue(row["Cantidad"], typeof(float)),
				Descuento = (float)GetSafeValue(row["Descuento"], typeof(float)),
				AlPorMayor = row.Field<bool>("AlPorMayor"),
			};
		}

		public List<EDetalle_Factura> LeerLista(EDetalle_Factura entity)
		{
			return LeerTabla(entity).AsEnumerable().Select(row =>
			new EDetalle_Factura
			{
				IdDetalleFactura = row.Field<int>("IdDetalleFactura"),
				IdProducto = row.Field<int>("IdProducto"),
				IdFactura = row.Field<int>("IdFactura"),
				Precio = (float)GetSafeValue(row["Precio"], typeof(float)),
				Cantidad = (float)GetSafeValue(row["Cantidad"], typeof(float)),
				Descuento = (float)GetSafeValue(row["Descuento"], typeof(float)),
				AlPorMayor = row.Field<bool>("AlPorMayor"),
			}).ToList();
		}
	}
}
