using DevExpress.XtraEditors;
using System;
using System.Configuration;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Presentación.Forms.Principal.Server
{
    public partial class CrearServidor : XtraForm
    {
        public static string Server_Name;
        public static string Initial_Catalog;

        public CrearServidor()
        {
            InitializeComponent();
            var Ruta = Path.Combine(Directory.GetCurrentDirectory(), "script.sql");
            TxtCreateDb.Text = File.ReadAllText(Ruta);
        }

        private void BtnAbrirScript_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "sql files (*.sql)|*.sql|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
            //
            MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
        }

        private void BtnEjecutar_Click(object sender, EventArgs e)
        {
            if (!Servidor.CrearDatabase(TxtServerName.Text, TxtDBName.Text))
            {
                return;
            }

            if (ckCrearUsuario.Checked)
            {
                //Reemplazando lo dato por el del usuario
                txtCrearUser.Text = txtCrearUser.Text.Replace("ada369", TxtUserName.Text);
                txtCrearUser.Text = txtCrearUser.Text.Replace("BASEADA", TxtDBName.Text);
                txtCrearUser.Text = txtCrearUser.Text.Replace("softwarereal", TxtPassword.Text);

                //Adjuntar al script de la Base de datos
                TxtCreateDb.Text = txtCrearUser.Text + Environment.NewLine + txtCrearUser.Text;
            }

            TxtCreateDb.Text = TxtCreateDb.Text.Replace("InventarioVenta", TxtDBName.Text);
            if (Servidor.CrearEsquema(TxtServerName.Text, TxtCreateDb.Text))
            {
                XtraMessageBox.Show("El programa debe reiniciarse");
                Close();
            }
        }

        private void ckCrearUsuario_CheckedChanged(object sender, EventArgs e)
        {
            TxtUserName.Enabled = ckCrearUsuario.Checked;
            TxtPassword.Enabled = ckCrearUsuario.Checked;
        }
    }
}