using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Datos.Repositorio
{
    public class RepositorioMovimiento : Repositorio
    {
		public int Agregar(EMovimiento entity)
		{
			return ExecuteNonQuery("SP_MovimientoInsertar",
				new SqlParameter("@IdEmpleado", entity.IdEmpleado),
				new SqlParameter("@IdCaja", entity.IdCaja),
				new SqlParameter("@Estado", entity.Estado),
				new SqlParameter("@FechaInicio", entity.FechaInicio),
				new SqlParameter("@FechaFin", SafeNull(entity.FechaFin)),
				new SqlParameter("@DineroInicial", entity.DineroInicial),
				new SqlParameter("@DineroCierre", SafeNull(entity.DineroCierre)),
				new SqlParameter("@Saldo", SafeNull(entity.Saldo)),
				new SqlParameter("@Diferencia", SafeNull(entity.Diferencia)));
		}

		public int Actualizar(EMovimiento entity)
		{
			return ExecuteNonQuery("SP_MovimientoActualizar",
				new SqlParameter("@IdMovimiento", entity.IdMovimiento),
				new SqlParameter("@IdEmpleado", entity.IdEmpleado),
				new SqlParameter("@IdCaja", entity.IdCaja),
				new SqlParameter("@Estado", entity.Estado),
				new SqlParameter("@FechaInicio", entity.FechaInicio),
				new SqlParameter("@FechaFin", SafeNull(entity.FechaFin)),
				new SqlParameter("@DineroInicial", entity.DineroInicial),
				new SqlParameter("@DineroCierre", SafeNull(entity.DineroCierre)),
				new SqlParameter("@Saldo", SafeNull(entity.Saldo)),
				new SqlParameter("@Diferencia", SafeNull(entity.Diferencia)));
		}

		public int Eliminar(EMovimiento entity)
		{
			return ExecuteNonQuery("SP_MovimientoEliminar",
				new SqlParameter("@IdMovimiento", entity.IdMovimiento));
		}

		public DataTable LeerTabla(EMovimiento entity)
		{
			return ExecuteReader("SP_MovimientoSeleccionar",
				new SqlParameter("@IdMovimiento", SafeNull(entity.IdMovimiento)));
		}

		public EMovimiento LeerEntidad(EMovimiento entity)
		{
			DataRow row = LeerTabla(entity).Rows[0];
			return new EMovimiento
			{
				IdMovimiento = row.Field<int>("IdMovimiento"),
				IdEmpleado = row.Field<int>("IdEmpleado"),
				IdCaja = row.Field<int>("IdCaja"),
				Estado = row.Field<string>("Estado"),
				FechaInicio = row.Field<DateTime>("FechaInicio"),
				FechaFin = (DateTime)GetSafeValue(row["FechaFin"], typeof(DateTime)),
				DineroInicial = (float)GetSafeValue(row["DineroInicial"], typeof(float)),
				DineroCierre = (float)GetSafeValue(row["DineroCierre"], typeof(float)),
				Saldo = (float)GetSafeValue(row["Saldo"], typeof(float)),
				Diferencia = (float)GetSafeValue(row["Diferencia"], typeof(float)),
			};
		}

		public List<EMovimiento> LeerLista(EMovimiento entity)
		{
			return LeerTabla(entity).AsEnumerable().Select(row =>
			new EMovimiento
			{
				IdMovimiento = row.Field<int>("IdMovimiento"),
				IdEmpleado = row.Field<int>("IdEmpleado"),
				IdCaja = row.Field<int>("IdCaja"),
				Estado = row.Field<string>("Estado"),
				FechaInicio = row.Field<DateTime>("FechaInicio"),
				FechaFin = (DateTime)GetSafeValue(row["FechaFin"], typeof(DateTime)),
				DineroInicial = (float)GetSafeValue(row["DineroInicial"], typeof(float)),
				DineroCierre = (float)GetSafeValue(row["DineroCierre"], typeof(float)),
				Saldo = (float)GetSafeValue(row["Saldo"], typeof(float)),
				Diferencia = (float)GetSafeValue(row["Diferencia"], typeof(float)),
			}).ToList();
		}

		public int BuscarIdCaja(string Serial)
		{
			type = CommandType.Text;
			return (int)ExecuteScalar("SELECT dbo.SfCaja_ObtenerId(@Serial_PC)",
				new SqlParameter("@Serial_PC", Serial));
		}

		public int BuscarIdEmpleado(string Serial)
		{
			type = CommandType.Text;
			return (int)ExecuteScalar("SELECT dbo.SfMovimiento_ObtenerEmpleado(@Serial_PC)", 
				new SqlParameter("@Serial_PC", Serial));
		}

		public int BuscarIdMovimiento(string Serial)
		{
			type = CommandType.Text;
			return (int)ExecuteScalar("SELECT dbo.SfMovimiento_ObtenerId(@Serial_PC)",
				new SqlParameter("@Serial_PC", Serial));
		}
	}
}
