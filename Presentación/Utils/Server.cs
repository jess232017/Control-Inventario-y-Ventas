using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentación
{
    public static class Servidor
    {
        #region Metodos para el Servidor sql

        public static bool CheckDatabase(string connectionString)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    var query = "select 1";

                    var command = new SqlCommand(query, connection);
                    connection.Open();
                    command.ExecuteScalar();
                    return true;
                }
            }
            catch (SqlException ex)
            {
                XtraMessageBox.Show(ex.Message);
                return false;
            }
        }

        public static bool CrearDatabase(string ServerName, string DBName)
        {
            string connectionString = $"Server={ServerName};Integrated security=yes;database=master";
            string TransactSql = $"CREATE DATABASE {DBName}";

            try
            {
                using (var conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    using (var cmd = new SqlCommand(TransactSql, conexion))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                    }
                }
                CambiarConexion(ServerName, DBName);

                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
               return false;
            }
        }

        public static bool CrearEsquema(string ServerName, string SqlScript)
        {
            var Ruta = Path.Combine(Directory.GetCurrentDirectory(), "ScriptSQL.txt");
            StreamWriter sw;
            
            try
            {
                if(File.Exists(Ruta))
                {
                    File.Delete(Ruta);
                }

                sw = File.CreateText(Ruta);
                sw.WriteLine(SqlScript);
                sw.Flush();
                sw.Close();

                Process Pross = new Process();
                Pross.StartInfo.FileName = "sqlcmd";
                Pross.StartInfo.Arguments = " -S " + ServerName + " -i " + "ScriptSQL.txt";
                Pross.Start();
                Pross.WaitForExit();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
   
        public static void ListaServers(ComboBoxItemCollection itemCollection)
        {
            //itemCollection.BeginUpdate();

            string myServer = Environment.MachineName;
            DataTable servers = SqlDataSourceEnumerator.Instance.GetDataSources();
            for (int i = 0; i < servers.Rows.Count; i++)
            {
                try
                {
                    if ((servers.Rows[i]["InstanceName"] as string) != null)
                        MessageBox.Show(servers.Rows[i]["ServerName"] + "\\" + servers.Rows[i]["InstanceName"]);
                    else
                        MessageBox.Show(servers.Rows[i]["ServerName"].ToString());

                    //MessageBox.Show(servers.Rows[i]["ServerName"].ToString());
                }
                finally
                {
                    //itemCollection.EndUpdate();
                }
            }
        }

        #endregion

        #region Metodos para la aplicacion

        public static void CambiarConexion(string ServerName, string DBName)
        {
            string StringConection = $"Data source = {ServerName}; Initial Catalog = "
                       + $"{DBName}; Integrated Security= true";

            SetSetting("ConexionBD", StringConection);
        }

        public static string GetSetting(string key)
        {
            return ConfigurationManager.ConnectionStrings[key].ConnectionString;
        }

        public static void SetSetting(string key, string value)
        {
            Configuration appconfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            appconfig.ConnectionStrings.ConnectionStrings[key].ConnectionString = value;
            appconfig.Save();

            Properties.Settings.Default.Save();
        }

        /*public static void GetParameters()
        {
            string Result = GetSetting("ConexionBD");

            Server_Name = Regex.Replace(Result, "Data source = ", "");
            Server_Name = Regex.Replace(Server_Name, "[;].*.", "");

            Initial_Catalog = Regex.Replace(Result, ".*.Initial Catalog = ", "");
            Initial_Catalog = Regex.Replace(Initial_Catalog, "[;].*.", "");
        }*/

        /* if (CbxIntegratedSecurity.Checked)
            {
                StringConection = $"Data source = {Cambiar_Server.Server_Name}; Initial Catalog = "
                    + $"{Cambiar_Server.Initial_Catalog}; Integrated Security= true";
            }
            else
            {
                StringConection = $"Data source = {Cambiar_Server.Server_Name}; User ID = "
                    + txtUser.Text + $"; password = {txtPass.Text};";
            }*/

        #endregion
    }
}