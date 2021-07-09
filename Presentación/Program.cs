using DevExpress.LookAndFeel;
using System;
using System.Windows.Forms;

namespace Presentación
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Tema Office Negro
            UserLookAndFeel.Default.SetSkinStyle(SkinSvgPalette.Bezier.OfficeBlack);
            ForzarFormato();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (Servidor.CheckDatabase(Servidor.GetSetting("ConexionBD")))
            {
                Application.Run(new Forms.MenuV2());
                //Application.Run(new Forms.Principal.Registro.Iniciar_Sesion());
            }
            else
            {
                Application.Run(new Forms.Principal.Server.CrearServidor());
            }
        }

        private static void ForzarFormato()
        {
            //Forzar idioma y formato decimal
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-NI");
            System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ",";
            System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ",";
        }
    }
}
