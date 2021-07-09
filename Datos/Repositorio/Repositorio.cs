using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Datos.Repositorio
{
    public class Repositorio
    {
        protected CommandType type = CommandType.StoredProcedure;
        private readonly string connectionString;

        public Repositorio()
        {
               connectionString = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;    
        }

        /// <summary>
        /// Realiza una consulta de tipo INSERT, DELETE, UPDATE
        /// </summary>
        /// <param name="TransactSql">Consulta o Procedimiento a realizar</param>
        /// <param name="sqlParameters">Parametros que requiere la consulta</param>
        /// <returns>Entero con las filas afectadas</returns>
        protected int ExecuteNonQuery(string TransactSql, params SqlParameter[] sqlParameters)
        {
            using (var conexion = new SqlConnection(connectionString))
            {
                conexion.Open();

                using (var cmd = new SqlCommand(TransactSql, conexion))
                {
                    cmd.CommandType = type;

                    foreach (SqlParameter item in sqlParameters)
                    {
                        cmd.Parameters.Add(item);
                    }

                    type = CommandType.StoredProcedure;
                    return cmd.ExecuteNonQuery();
                }
            }
        }
       
        /// <summary>
        /// Realiza una consulta de tipo SELECT
        /// </summary>
        /// <param name="TransactSql">Consulta o Procedimiento a realizar</param>
        /// <param name="sqlParameters">Parametros que requiere la consulta</param>
        /// <returns>DataTable con las filas obtenidas</returns>
        protected DataTable ExecuteReader(string TransactSql, params SqlParameter[] sqlParameters)
        {
            using (var conexion = new SqlConnection(connectionString))
            {
                conexion.Open();

                using (var cmd = new SqlCommand(TransactSql, conexion))
                {
                    cmd.CommandType = type;

                    foreach (SqlParameter item in sqlParameters)
                    {
                        cmd.Parameters.Add(item);
                    }

                    SqlDataReader reader = cmd.ExecuteReader();
                    using (var table = new DataTable())
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            type = CommandType.StoredProcedure;
                            conexion.Close();
                            da.Fill(table);
                            return table;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Realiza una consulta donde se retorne un unico valor
        /// </summary>
        /// <param name="TransactSql">Consulta o Procedimiento a realizar</param>
        /// <param name="sqlParameters">Parametros que requiere la consulta</param>
        /// <returns>Objecto que contiene un valor unico</returns>
        protected object ExecuteScalar(string TransactSql, params SqlParameter[] sqlParameters)
        {
            using (var conexion = new SqlConnection(connectionString))
            {
                conexion.Open();

                using (var cmd = new SqlCommand(TransactSql, conexion))
                {
                    // Especifica que será un procedimiento almacenado.
                    cmd.CommandType = type;

                    // Agrega los parámetros SI LOS HAY
                    foreach (SqlParameter parametro in sqlParameters)
                    {
                        cmd.Parameters.Add(parametro);
                    }
                    type = CommandType.StoredProcedure;
                    return cmd.ExecuteScalar();
                }
            }
        }

        ///Utilidades
        /// <summary>
        /// Verifica que el valor del objecto no sea DBNull
        /// </summary>
        /// <param name="value">Valor</param>
        /// <returns>Flotante valido</returns>
        protected double SafeDoubleReturn(object value) => (value != DBNull.Value) ? Convert.ToDouble(value) : 0;

        protected object GetSafeValue(object value, Type type)
        {
            if (type == typeof(int))
                return (value != DBNull.Value) ? Convert.ToInt32(value) : 0;

            if (type == typeof(float))
                return (value != DBNull.Value) ? float.Parse(value.ToString()) : 0.0f;

            if (type == typeof(double))
                return (value != DBNull.Value) ? Convert.ToDouble(value) : 0.0f;

            if (type == typeof(string))
                return (value != DBNull.Value) ? Convert.ToString(value) : "";

            if (type == typeof(DateTime))
                return (value != DBNull.Value) ? Convert.ToDateTime(value) : new DateTime();

            return null;
        }

        /// <summary>
        /// Devuelve un valor DBNull.Value si el objecto es nulo
        /// </summary>
        /// <param name="value">Variable a verificar</param>
        /// <returns></returns>
        protected object SafeNull(object value) => value ?? DBNull.Value;
    }
}