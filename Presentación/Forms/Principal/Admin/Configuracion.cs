namespace Presentación.Forms.Principal.Admin
{
    public partial class Configuracion : DevExpress.XtraEditors.XtraForm
    {
        public Configuracion()
        {
            InitializeComponent();
        }

        private void BtnCajas_Click(object sender, System.EventArgs e)
        {
            //new Caja.Admin_Caja().ShowDialog();
        }

        private void BtnCerrar_Click(object sender, System.EventArgs e)
        {
            Close();
            Dispose();
        }
    }
}
