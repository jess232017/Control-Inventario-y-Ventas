using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Datos.Repositorio
{
    public class RepositorioProducto : Repositorio
    {
		public int Agregar(EProducto entity)
		{
			return ExecuteNonQuery("SP_ProductoInsertar",
				new SqlParameter("@IdCategoria", entity.IdCategoria),
				new SqlParameter("@Descripcion", entity.Descripcion),
				new SqlParameter("@Marca", entity.Marca),
				new SqlParameter("@Inventariado", entity.Inventariado),
				new SqlParameter("@Cantidad", entity.Cantidad),
				new SqlParameter("@PrecioVenta", entity.PrecioVenta),
				new SqlParameter("@CodigoQR", entity.CodigoQR),
				new SqlParameter("@Imagen", SafeNull(entity.Imagen)),
				new SqlParameter("@StockMinimo", entity.StockMinimo),
				new SqlParameter("@Granel", entity.Granel));
		}

		public int Actualizar(EProducto entity)
		{
			return ExecuteNonQuery("SP_ProductoActualizar",
				new SqlParameter("@IdProducto", entity.IdProducto),
				new SqlParameter("@IdCategoria", entity.IdCategoria),
				new SqlParameter("@Descripcion", entity.Descripcion),
				new SqlParameter("@Marca", entity.Marca),
				new SqlParameter("@Inventariado", entity.Inventariado),
				new SqlParameter("@Cantidad", entity.Cantidad),
				new SqlParameter("@PrecioVenta", entity.PrecioVenta),
				new SqlParameter("@CodigoQR", entity.CodigoQR),
				new SqlParameter("@Imagen", entity.Imagen),
				new SqlParameter("@StockMinimo", entity.StockMinimo),
				new SqlParameter("@Granel", entity.Granel));
		}

		public int Eliminar(EProducto entity)
		{
			return ExecuteNonQuery("SP_ProductoEliminar",
				new SqlParameter("@IdProducto", entity.IdProducto));
		}

		public DataTable LeerTabla(EProducto entity)
		{
			return ExecuteReader("SP_ProductoSeleccionar",
				new SqlParameter("@IdProducto", SafeNull(entity.IdProducto)));
		}

		public EProducto LeerEntidad(EProducto entity)
		{
			DataRow row = LeerTabla(entity).Rows[0];
			return new EProducto
			{
				IdProducto = row.Field<int>("IdProducto"),
				IdCategoria = row.Field<int>("IdCategoria"),
				Descripcion = row.Field<string>("Descripcion"),
				Marca = row.Field<string>("Marca"),
				Inventariado = row.Field<bool>("Inventariado"),
				Cantidad = row.Field<int>("Cantidad"),
				PrecioVenta = (float)GetSafeValue(row["PrecioVenta"], typeof(float)),
				CodigoQR = row.Field<string>("CodigoQR"),
				Imagen = row.Field<byte[]>("Imagen"),
				StockMinimo = (int?)GetSafeValue(row["StockMinimo"], typeof(int)),
				Granel = row.Field<bool>("Granel")
			};
		}

		public List<EProducto> LeerLista(EProducto entity)
		{
			return LeerTabla(entity).AsEnumerable().Select(row => new EProducto
                {
                    IdProducto = row.Field<int>("IdProducto"),
                    IdCategoria = row.Field<int>("IdCategoria"),
                    Descripcion = row.Field<string>("Descripcion"),
                    Marca = row.Field<string>("Marca"),
                    Inventariado = row.Field<bool>("Inventariado"),
                    Cantidad = row.Field<int>("Cantidad"),
					PrecioVenta = (float)GetSafeValue(row["PrecioVenta"], typeof(float)),
					CodigoQR = row.Field<string>("CodigoQR"),
                    Imagen = row.Field<byte[]>("Imagen"),
                    StockMinimo = (int?)GetSafeValue(row["StockMinimo"], typeof(int)),
                    Granel = row.Field<bool>("Granel")
                })
			.ToList();
		}
	}
}
