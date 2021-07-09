using System;
using System.Windows.Forms;

namespace Presentación.Forms.Credito
{
    public partial class PorCobrar : Form
    {
        public PorCobrar()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }
    }
}
