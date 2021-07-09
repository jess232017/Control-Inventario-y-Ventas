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
    public class RepositorioCaja : Repositorio
    {
		public int Agregar(ECaja entity)
		{
			return ExecuteNonQuery("SP_CajaInsertar",
				new SqlParameter("@Descripcion", entity.Descripcion),
				new SqlParameter("@Serial_PC", entity.Serial_PC),
				new SqlParameter("@Impresora_Ticket", entity.Impresora_Ticket),
				new SqlParameter("@Impresora_A4", entity.Impresora_A4),
				new SqlParameter("@Estado", entity.Estado));
		}

		public int Actualizar(ECaja entity)
		{
			return ExecuteNonQuery("SP_CajaActualizar",
				new SqlParameter("@IdCaja", entity.IdCaja),
				new SqlParameter("@Descripcion", entity.Descripcion),
				new SqlParameter("@Serial_PC", entity.Serial_PC),
				new SqlParameter("@Impresora_Ticket", entity.Impresora_Ticket),
				new SqlParameter("@Impresora_A4", entity.Impresora_A4),
				new SqlParameter("@Estado", entity.Estado));
		}

		public int Eliminar(ECaja entity)
		{
			return ExecuteNonQuery("SP_CajaEliminar",
				new SqlParameter("@IdCaja", entity.IdCaja));
		}

		public DataTable LeerTabla(ECaja entity)
		{
			return ExecuteReader("SP_CajaSeleccionar",
				new SqlParameter("@IdCaja", SafeNull(entity.IdCaja)));
		}

		public ECaja LeerEntidad(ECaja entity)
		{
			DataRow row = LeerTabla(entity).Rows[0];
			return new ECaja
			{
				IdCaja = row.Field<int>("IdCaja"),
				Descripcion = row.Field<string>("Descripcion"),
				Serial_PC = row.Field<string>("Serial_PC"),
				Impresora_Ticket = row.Field<string>("Impresora_Ticket"),
				Impresora_A4 = row.Field<string>("Impresora_A4"),
				Estado = row.Field<bool>("Estado"),
			};
		}

		public List<ECaja> LeerLista(ECaja entity)
		{
			return LeerTabla(entity).AsEnumerable().Select(row =>
			new ECaja
			{
				IdCaja = row.Field<int>("IdCaja"),
				Descripcion = row.Field<string>("Descripcion"),
				Serial_PC = row.Field<string>("Serial_PC"),
				Impresora_Ticket = row.Field<string>("Impresora_Ticket"),
				Impresora_A4 = row.Field<string>("Impresora_A4"),
				Estado = row.Field<bool>("Estado"),
			}).ToList();
		}

	}
}
