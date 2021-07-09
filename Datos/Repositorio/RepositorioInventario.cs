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
    public class RepositorioInventario : Repositorio
    {
		public int Agregar(EInventario entity)
		{
			return ExecuteNonQuery("SP_InventarioInsertar",
				new SqlParameter("@IdMovimiento", entity.IdMovimiento),
				new SqlParameter("@IdProducto", entity.IdProducto),
				new SqlParameter("@Motivo", entity.Motivo),
				new SqlParameter("@Fecha", entity.Fecha),
				new SqlParameter("@Estado", entity.Estado),
				new SqlParameter("@Cantidad", entity.Cantidad),
				new SqlParameter("@CostoUnit", entity.CostoUnit),
				new SqlParameter("@SubTotal", entity.SubTotal),
				new SqlParameter("@Total", entity.Total),
				new SqlParameter("@Nota", entity.Nota));
		}

		public int Actualizar(EInventario entity)
		{
			return ExecuteNonQuery("SP_InventarioActualizar",
				new SqlParameter("@IdInventario", entity.IdInventario),
				new SqlParameter("@IdMovimiento", entity.IdMovimiento),
				new SqlParameter("@IdProducto", entity.IdProducto),
				new SqlParameter("@Motivo", entity.Motivo),
				new SqlParameter("@Fecha", entity.Fecha),
				new SqlParameter("@Estado", entity.Estado),
				new SqlParameter("@Cantidad", entity.Cantidad),
				new SqlParameter("@CostoUnit", entity.CostoUnit),
				new SqlParameter("@SubTotal", entity.SubTotal),
				new SqlParameter("@Total", entity.Total),
				new SqlParameter("@Nota", entity.Nota));
		}

		public int Eliminar(EInventario entity)
		{
			return ExecuteNonQuery("SP_InventarioEliminar",
				new SqlParameter("@IdInventario", entity.IdInventario));
		}

		public DataTable LeerTabla(EInventario entity)
		{
			return ExecuteReader("SP_InventarioSeleccionar",
				new SqlParameter("@IdInventario", SafeNull(entity.IdInventario)));
		}

		public EInventario LeerEntidad(EInventario entity)
		{
			DataRow row = LeerTabla(entity).Rows[0];
			return new EInventario
			{
				IdInventario = row.Field<int>("IdInventario"),
				IdMovimiento = row.Field<int>("IdMovimiento"),
				IdProducto = row.Field<int>("IdProducto"),
				Motivo = row.Field<string>("Motivo"),
				Fecha = row.Field<DateTime>("Fecha"),
				Estado = row.Field<string>("Estado"),
				Cantidad = row.Field<int>("Cantidad"),
				CostoUnit = (float)GetSafeValue(row["CostoUnit"], typeof(float)),
				SubTotal = (float)GetSafeValue(row["SubTotal"], typeof(float)),
				Total = (float)GetSafeValue(row["Total"], typeof(float)),
				Nota = row.Field<string>("Nota")
			};
		}

		public List<EInventario> LeerLista(EInventario entity)
		{
			return LeerTabla(entity).AsEnumerable().Select(row => 
				new EInventario
                {
                    IdInventario = row.Field<int>("IdInventario"),
                    IdMovimiento = row.Field<int>("IdMovimiento"),
                    IdProducto = row.Field<int>("IdProducto"),
                    Motivo = row.Field<string>("Motivo"),
                    Fecha = row.Field<DateTime>("Fecha"),
                    Estado = row.Field<string>("Estado"),
                    Cantidad = row.Field<int>("Cantidad"),
                    CostoUnit = (float)GetSafeValue(row["CostoUnit"], typeof(float)),
                    SubTotal = (float)GetSafeValue(row["SubTotal"], typeof(float)),
                    Total = (float)GetSafeValue(row["Total"], typeof(float)),
                    Nota = row.Field<string>("Nota")
                })
			.ToList();
		}

	}
}
