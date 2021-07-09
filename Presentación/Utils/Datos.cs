using DevExpress.XtraEditors;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Management;

namespace Presentación
{
    public static class Datos
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;

        public static string ObtenerSerial()
        {
            ManagementObject MOS = new ManagementObject(@"Win32_PhysicalMedia='\\.\PHYSICALDRIVE0'");
            return MOS.Properties["SerialNumber"].Value.ToString();
        }

        /// <summary>
        /// Realiza una consulta de tipo INSERT, DELETE, UPDATE
        /// </summary>
        /// <param name="TransactSql">Consulta o Procedimiento a realizar</param>
        /// <param name="sqlParameters">Parametros que requiere la consulta</param>
        /// <returns>Entero con las filas afectadas</returns>
        public static int ExecuteNonQuery(string TransactSql, CommandType type, params SqlParameter[] sqlParameters)
        {
            try
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

                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                XtraMessageBox.Show(ex.Message);
                return 0;
            }
        }

        /// <summary>
        /// Realiza una consulta de tipo SELECT
        /// </summary>
        /// <param name="TransactSql">Consulta o Procedimiento a realizar</param>
        /// <param name="sqlParameters">Parametros que requiere la consulta</param>
        /// <returns>DataTable con las filas obtenidas</returns>
        public static DataTable ExecuteReader(string TransactSql, CommandType type, params SqlParameter[] sqlParameters)
        {
            try
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
                                conexion.Close();
                                da.Fill(table);
                                return table;
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                XtraMessageBox.Show(ex.Message);
                return new DataTable();
            }
        }

        /// <summary>
        /// Realiza una consulta donde se retorne un unico valor
        /// </summary>
        /// <param name="TransactSql">Consulta o Procedimiento a realizar</param>
        /// <param name="sqlParameters">Parametros que requiere la consulta</param>
        /// <returns>Objecto que contiene un valor unico</returns>
        public static object ExecuteScalar(string TransactSql, CommandType type, params SqlParameter[] sqlParameters)
        {
            try
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
                        return cmd.ExecuteScalar();
                    }
                }
            }
            catch (SqlException ex)
            {
                XtraMessageBox.Show(ex.Message);
                return 0;
            }
        }
    
    }
}
