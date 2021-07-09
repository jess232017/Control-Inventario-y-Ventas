using System;
using System.Windows.Forms;

namespace Presentación.Forms.Caja
{
    public partial class InfoCierre : Form
    {

        public InfoCierre()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
