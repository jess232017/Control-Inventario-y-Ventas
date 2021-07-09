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
    public class RepositorioEmpleado : Repositorio
    {
		public int Agregar(EEmpleado entity)
		{
			return ExecuteNonQuery("SP_EmpleadoInsertar",
				new SqlParameter("@IdTienda", entity.IdTienda),
				new SqlParameter("@IdRol", entity.IdRol),
				new SqlParameter("@Nombres", entity.Nombres),
				new SqlParameter("@Apellidos", entity.Apellidos),
				new SqlParameter("@Usuario", entity.Usuario),
				new SqlParameter("@Clave", entity.Clave),
				new SqlParameter("@Foto", SafeNull(entity.Foto)),
				new SqlParameter("@Correo", entity.Correo),
				new SqlParameter("@Estado", entity.Estado));
		}

		public int Actualizar(EEmpleado entity)
		{
			return ExecuteNonQuery("SP_EmpleadoActualizar",
				new SqlParameter("@IdEmpleado", entity.IdEmpleado),
				new SqlParameter("@IdTienda", entity.IdTienda),
				new SqlParameter("@IdRol", entity.IdRol),
				new SqlParameter("@Nombres", entity.Nombres),
				new SqlParameter("@Apellidos", entity.Apellidos),
				new SqlParameter("@Usuario", entity.Usuario),
				new SqlParameter("@Clave", entity.Clave),
				new SqlParameter("@Foto", SafeNull(entity.Foto)),
				new SqlParameter("@Correo", entity.Correo),
				new SqlParameter("@Estado", entity.Estado));
		}

		public int Eliminar(EEmpleado entity)
		{
			return ExecuteNonQuery("SP_EmpleadoEliminar",
				new SqlParameter("@IdEmpleado", entity.IdEmpleado));
		}

		public DataTable LeerTabla(EEmpleado entity)
		{
			return ExecuteReader("SP_EmpleadoSeleccionar",
				new SqlParameter("@IdEmpleado", SafeNull(entity.IdEmpleado)));
		}

		public EEmpleado LeerEntidad(EEmpleado entity)
		{
			DataRow row = LeerTabla(entity).Rows[0];
			return new EEmpleado
			{
				IdEmpleado = row.Field<int>("IdEmpleado"),
				IdTienda = row.Field<int>("IdTienda"),
				IdRol = row.Field<int>("IdRol"),
				Nombres = row.Field<string>("Nombres"),
				Apellidos = row.Field<string>("Apellidos"),
				Usuario = row.Field<string>("Usuario"),
				Clave = row.Field<string>("Clave"),
				Foto = row.Field<byte[]>("Foto"),
				Correo = row.Field<string>("Correo"),
				Estado = row.Field<string>("Estado"),
			};
		}

		public List<EEmpleado> LeerLista(EEmpleado entity)
		{
			return LeerTabla(entity).AsEnumerable().Select(row =>
			new EEmpleado
			{
				IdEmpleado = row.Field<int>("IdEmpleado"),
				IdTienda = row.Field<int>("IdTienda"),
				IdRol = row.Field<int>("IdRol"),
				Nombres = row.Field<string>("Nombres"),
				Apellidos = row.Field<string>("Apellidos"),
				Usuario = row.Field<string>("Usuario"),
				Clave = row.Field<string>("Clave"),
				Foto = row.Field<byte[]>("Foto"),
				Correo = row.Field<string>("Correo"),
				Estado = row.Field<string>("Estado"),
			}).ToList();
		}

	}
}
