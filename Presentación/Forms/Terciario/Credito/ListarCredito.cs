using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Presentación.Forms.Credito
{
    public partial class ListarCredito : Form
    {
        private float Saldo;
        public ListarCredito()
        {
            InitializeComponent();
            GetSource();
        }

        private void GetSource()
        {
        }

        private void LukCliente_EditValueChanged(object sender, EventArgs e)
        {
            if (LukCliente.EditValue != null)
            {
                int IdCliente = (int) LukCliente.EditValue;
                LookUpEdit edit = sender as LookUpEdit;

                if (!float.TryParse(edit.GetColumnValue("Saldo").ToString(), out Saldo))
                {
                    Saldo = 0;
                }
                TxtSaldo.Text = "C$ " + Saldo;
            }
        }

        private void BtnAbonar_Click(object sender, EventArgs e)
        {
            Saldo = 1521;
            if(Saldo > 0)
            {
                float Abono = Forma_Abono.GetValor(Saldo);
            }
            else
            {
                XtraMessageBox.Show("No tiene cuentas pendientes que abonar","Abonar Credito");
            }
        }

        private void BtnDetalles_Click(object sender, EventArgs e)
        {
            //new DetalleAbono().ShowDialog();
        }
    }
}
