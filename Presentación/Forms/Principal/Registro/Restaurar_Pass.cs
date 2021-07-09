using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using Negocio;

namespace Presentación.Forms.Principal.Registro
{
    public partial class Restaurar_Pass : Form
    {
        public Restaurar_Pass()
        {
            InitializeComponent();
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            DataTable Info = Datos.ExecuteReader("buscar_USUARIO_por_correo", CommandType.StoredProcedure,
                            new SqlParameter("@correo", txtEmail.Text));

            if (Info.Rows.Count == 1)
            {
                string Password = Info.Rows[0][0].ToString();
                string Correo = Info.Rows[0][1].ToString();
                string Nombre = Info.Rows[0][2].ToString();

                rtbMensaje.Text = rtbMensaje.Text.Replace("@PASS", Password);
                rtbMensaje.Text = rtbMensaje.Text.Replace("@EMAIL", Correo);
                rtbMensaje.Text = rtbMensaje.Text.Replace("@NOMBRE", Nombre);

                EnviarCorreo("DevPrueba19d4dd@gmail.com", "Deving19d4dd", rtbMensaje.Text, "Solicitud de Contraseña", txtEmail.Text);
                Close();
            }
            else
            {
                XtraMessageBox.Show("Datos ingresados no validos");
            }
        }

        internal void EnviarCorreo(string Emisor, string Password, string Mensaje, string Asunto, string Destinatario)
        {
            try
            {
                MailMessage Correos = new MailMessage();
                SmtpClient Envios = new SmtpClient();
                Correos.To.Clear();
                Correos.Body = "";
                Correos.Subject = "";
                Correos.Body = Mensaje;
                Correos.Subject = Asunto;
                Correos.IsBodyHtml = true;
                Correos.To.Add((Destinatario));
                Correos.From = new MailAddress(Emisor);
                Envios.Credentials = new NetworkCredential(Emisor, Password);

                Envios.Host = "smtp.gmail.com";
                Envios.Port = 587;
                Envios.EnableSsl = true;

                Envios.Send(Correos);
                XtraMessageBox.Show("Contraseña Enviada, revisa tu correo Electronico", "Restauracion de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("ERROR, revisa tu correo Electronico: " + ex, "Restauracion de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}