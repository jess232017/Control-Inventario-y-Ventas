using System;
using System.Windows.Forms;

namespace Presentación.Forms.Credito
{
    public partial class PorPagar : Form
    {
        public PorPagar()
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
