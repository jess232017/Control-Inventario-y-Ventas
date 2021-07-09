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
    public class RepositorioContable : Repositorio
    {
		public int Agregar(EContable entity)
		{
			return ExecuteNonQuery("SP_ContableInsertar",
				new SqlParameter("@IdMovimiento", entity.IdMovimiento),
				new SqlParameter("@FechaRegistro", entity.FechaRegistro),
				new SqlParameter("@Monto", entity.Monto),
				new SqlParameter("@Motivo", entity.Motivo),
				new SqlParameter("@Tipo", entity.Tipo),
				new SqlParameter("@Nota", entity.Nota));
		}

		public int Actualizar(EContable entity)
		{
			return ExecuteNonQuery("SP_ContableActualizar",
				new SqlParameter("@IdContable", entity.IdContable),
				new SqlParameter("@IdMovimiento", entity.IdMovimiento),
				new SqlParameter("@FechaRegistro", entity.FechaRegistro),
				new SqlParameter("@Monto", entity.Monto),
				new SqlParameter("@Motivo", entity.Motivo),
				new SqlParameter("@Tipo", entity.Tipo),
				new SqlParameter("@Nota", entity.Nota));
		}

		public int Eliminar(EContable entity)
		{
			return ExecuteNonQuery("SP_ContableEliminar",
				new SqlParameter("@IdContable", entity.IdContable));
		}

		public DataTable LeerTabla(EContable entity)
		{
			return ExecuteReader("SP_ContableSeleccionar",
				new SqlParameter("@IdContable", SafeNull(entity.IdContable)));
		}

		public EContable LeerEntidad(EContable entity)
		{
			DataRow row = LeerTabla(entity).Rows[0];
			return new EContable
			{
				IdContable = row.Field<int>("IdContable"),
				IdMovimiento = row.Field<int>("IdMovimiento"),
				FechaRegistro = row.Field<DateTime>("FechaRegistro"),
				Monto = (float)GetSafeValue(row["Monto"], typeof(float)),
				Motivo = row.Field<string>("Motivo"),
				Tipo = row.Field<string>("Tipo"),
				Nota = row.Field<string>("Nota"),
			};
		}

		public List<EContable> LeerLista(EContable entity)
		{
			return LeerTabla(entity).AsEnumerable().Select(row =>
			new EContable
			{
				IdContable = row.Field<int>("IdContable"),
				IdMovimiento = row.Field<int>("IdMovimiento"),
				FechaRegistro = row.Field<DateTime>("FechaRegistro"),
				Monto = (float)GetSafeValue(row["Monto"], typeof(float)),
				Motivo = row.Field<string>("Motivo"),
				Tipo = row.Field<string>("Tipo"),
				Nota = row.Field<string>("Nota"),
			}).ToList();
		}

		public DataTable BuscarPorMovimientoTipo(int IdMovimiento, string Tipo)
		{
			type = CommandType.Text;
			return ExecuteReader("SELECT * FROM TfContable_PorMovimientoTipo(@IdMovimiento, @Tipo)", 
				new SqlParameter("@IdMovimiento", IdMovimiento),
				new SqlParameter("@Tipo", Tipo));
		}
	}
}
