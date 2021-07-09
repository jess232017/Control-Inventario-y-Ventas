using DevExpress.XtraEditors;
using Presentación;
using System;

namespace Presentación.Forms.Principal.Caja
{
    public partial class DineroInicial : XtraForm
    {
        private static float MontoInicial = 0.0f;

        private DineroInicial()
        {
            InitializeComponent();
        }

        public static float Show()
        {
            new DineroInicial().ShowDialog();
            return MontoInicial;
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            if(!float.TryParse(txtMonto.Text, out MontoInicial))
            {
                XtraMessageBox.Show("El monto ingresado no es valido");
                return;
            }

            Close();
        }

        private void BtnOmitir_Click(object sender, EventArgs e)
        {
            if (float.TryParse("0", out MontoInicial))
            {
                Close();
            }
        }
    }
}