using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;


namespace Datos.Repositorio
{
    public class RepositorioProveedor : Repositorio
    {
		public int Agregar(EProveedor entity)
		{
			return ExecuteNonQuery("SP_ProveedorInsertar",
				new SqlParameter("@Empresa", entity.Empresa),
				new SqlParameter("@Contacto", entity.Contacto),
				new SqlParameter("@Direccion", entity.Direccion),
				new SqlParameter("@Estado", entity.Estado),
				new SqlParameter("@Celular", entity.Celular),
				new SqlParameter("@Foto", SafeNull(entity.Foto)));
		}

		public int Actualizar(EProveedor entity)
		{
			return ExecuteNonQuery("SP_ProveedorActualizar",
				new SqlParameter("@IdProveedor", entity.IdProveedor),
				new SqlParameter("@Empresa", entity.Empresa),
				new SqlParameter("@Contacto", entity.Contacto),
				new SqlParameter("@Direccion", entity.Direccion),
				new SqlParameter("@Estado", entity.Estado),
				new SqlParameter("@Celular", entity.Celular),
				new SqlParameter("@Foto", SafeNull(entity.Foto)));
		}

		public int Eliminar(EProveedor entity)
		{
			return ExecuteNonQuery("SP_ProveedorEliminar",
				new SqlParameter("@IdProveedor", entity.IdProveedor));
		}

		public DataTable LeerTabla(EProveedor entity)
		{
			return ExecuteReader("SP_ProveedorSeleccionar",
				new SqlParameter("@IdProveedor", SafeNull(entity.IdProveedor)));
		}

		public EProveedor LeerEntidad(EProveedor entity)
		{
			DataRow row = LeerTabla(entity).Rows[0];
			return new EProveedor
			{
				IdProveedor = row.Field<int>("IdProveedor"),
				Empresa = row.Field<string>("Empresa"),
				Contacto = row.Field<string>("Contacto"),
				Direccion = row.Field<string>("Direccion"),
				Estado = row.Field<bool>("Estado"),
				Celular = row.Field<string>("Celular"),
				Foto = row.Field<byte[]>("Foto"),
			};
		}

		public List<EProveedor> LeerLista(EProveedor entity)
		{
			return LeerTabla(entity).AsEnumerable().Select(row =>
			new EProveedor
			{
				IdProveedor = row.Field<int>("IdProveedor"),
				Empresa = row.Field<string>("Empresa"),
				Contacto = row.Field<string>("Contacto"),
				Direccion = row.Field<string>("Direccion"),
				Estado = row.Field<bool>("Estado"),
				Celular = row.Field<string>("Celular"),
				Foto = row.Field<byte[]>("Foto"),
			}).ToList();
		}
	}
}
