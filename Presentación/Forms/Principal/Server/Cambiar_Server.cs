using DevExpress.XtraEditors;
using System.Configuration;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Presentación.Forms.Principal.Server
{
    public partial class Cambiar_Server : XtraForm
    {
        public static string Server_Name;
        public static string Initial_Catalog;

        private Cambiar_Server()
        {
            InitializeComponent();
            txtServerName.Text = Server_Name;
            TxtInitCatalog.Text = Initial_Catalog;
        }

        public static void Show()
        {
            new Cambiar_Server().ShowDialog();
        }

        private void BtnCambiar_Click(object sender, System.EventArgs e)
        {
            Server_Name = txtServerName.Text;
            Initial_Catalog = TxtInitCatalog.Text;
            Close();
        }
    }
}