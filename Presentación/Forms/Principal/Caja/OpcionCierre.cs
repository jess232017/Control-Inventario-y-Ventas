using DevExpress.XtraEditors;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Presentación.Forms.Caja
{
    public partial class OpcionCierre : XtraForm
    {
        private static DialogResult result;
        
        private OpcionCierre()
        {
            InitializeComponent();
        }

        public static DialogResult Show()
        {
            new OpcionCierre().ShowDialog();
            return result;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes;
            Close();
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            result = DialogResult.OK;
            Close();
        }
    }
}