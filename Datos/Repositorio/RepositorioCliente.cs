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
    public class RepositorioCliente : Repositorio
    {
		public int Agregar(ECliente entity)
		{
			return ExecuteNonQuery("SP_ClienteInsertar",
				new SqlParameter("@Nombre", entity.Nombre),
				new SqlParameter("@Apellido", entity.Apellido),
				new SqlParameter("@Telefono", entity.Telefono),
				new SqlParameter("@Estado", entity.Estado),
				new SqlParameter("@Imagen", SafeNull(entity.Imagen)));
		}

		public int Actualizar(ECliente entity)
		{
			return ExecuteNonQuery("SP_ClienteActualizar",
				new SqlParameter("@IdCliente", entity.IdCliente),
				new SqlParameter("@Nombre", entity.Nombre),
				new SqlParameter("@Apellido", entity.Apellido),
				new SqlParameter("@Telefono", entity.Telefono),
				new SqlParameter("@Estado", entity.Estado),
				new SqlParameter("@Imagen", SafeNull(entity.Imagen)));
		}

		public int Eliminar(ECliente entity)
		{
			return ExecuteNonQuery("SP_ClienteEliminar",
				new SqlParameter("@IdCliente", entity.IdCliente));
		}

		public DataTable LeerTabla(ECliente entity)
		{
			return ExecuteReader("SP_ClienteSeleccionar",
				new SqlParameter("@IdCliente", SafeNull(entity.IdCliente)));
		}

		public ECliente LeerEntidad(ECliente entity)
		{
			DataRow row = LeerTabla(entity).Rows[0];
			return new ECliente
			{
				IdCliente = row.Field<int>("IdCliente"),
				Nombre = row.Field<string>("Nombre"),
				Apellido = row.Field<string>("Apellido"),
				Telefono = row.Field<string>("Telefono"),
				Estado = row.Field<bool>("Estado"),
				Imagen = row.Field<byte[]>("Imagen"),
			};
		}

		public List<ECliente> LeerLista(ECliente entity)
		{
			return LeerTabla(entity).AsEnumerable().Select(row =>
			new ECliente
			{
				IdCliente = row.Field<int>("IdCliente"),
				Nombre = row.Field<string>("Nombre"),
				Apellido = row.Field<string>("Apellido"),
				Telefono = row.Field<string>("Telefono"),
				Estado = row.Field<bool>("Estado"),
				Imagen = row.Field<byte[]>("Imagen"),
			}).ToList();
		}

	}
}
