using System;
using System.Windows.Forms;

namespace Presentación.Forms.Credito
{
    public partial class Forma_Abono : Form
    {
        private int Opcion = 0;
        private readonly float Saldo;
        private readonly float Exchange = 34.92f;
        private static float Abono, PagoCon;

        private Forma_Abono(float saldo)
        {
            Saldo = saldo;
            InitializeComponent();
            LbSaldo.Text = "C$ " + saldo;
        }

        public static float GetValor(float Saldo)
        {
            new Forma_Abono(Saldo).ShowDialog(null);
            return Abono;
        }

        private bool ValidarTodo()
        {
            if (Abono.CompareTo(Saldo) > 0)
            {
                MessageBox.Show("El abono es mayor al Saldo");
                return false;
            }

            if (Abono.CompareTo(0) <= 0)
            {
                MessageBox.Show("El Abono no puede ser menor o igual a cero");
                return false;
            }

            if (Abono.CompareTo(PagoCon) > 0)
            {
                MessageBox.Show("Verifique: El efectivo es menor al monto a pagar");
                return false;
            }
            return true;
        }

        private void BtnAbonar_Click(object sender, EventArgs e)
        {
            if (ValidarTodo())
            {
                Close();
            }
        }

        private void BtnSoloAbonar_Click(object sender, EventArgs e)
        {
            if (ValidarTodo())
            {
                Close();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
            Abono = 0;
        }  

        private void TabMxin_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {
            Opcion = int.Parse(TabMxin.SelectedPage.Tag.ToString());
            if (Opcion == 0)
            {
                TxtAbona_TextChanged(sender, e);
                TxtPagoCor_TextChanged(sender, e);
            }
            else
            {
                TxtAbonaDolar_TextChanged(sender, e);
                TxtPagoDolar_TextChanged(sender, e);
            }
        }

        private void TxtAbona_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(TxtAbona.Text, out Abono))
            {
                errorProvider1.SetError(TxtAbona, ValidarAbono());
            }
            else
            {
                Abono = 0;
            }
            lbAbona.Text = "C$ " + Abono;
        }

        private void TxtAbonaDolar_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(TxtAbonaDolar.Text, out Abono))
            {
                Abono *= Exchange;
                errorProvider1.SetError(TxtAbonaDolar, ValidarAbono());
            }
            else
            {
                Abono = 0;
            }
            lbAbona.Text = "C$ " + Abono; 
        }

        private void TxtPagoCor_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(TxtAbona.Text, out Abono) && float.TryParse(TxtPagoCor.Text, out PagoCon))
            {
                float vuelto = PagoCon - Abono;
                errorProvider1.SetError(TxtPagoCor, ValidarPagoCon());
                TxtCambioEfectivo.Text = "C$ " + vuelto;
            }
        }

        private void TxtPagoDolar_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(TxtPagoDolar.Text, out float PagoDolar))
            {
                PagoCon = PagoDolar * Exchange;
                TxtEquivDolar.Text = PagoCon.ToString();
                float cambio = PagoCon - Abono;

                errorProvider1.SetError(TxtPagoDolar, ValidarPagoCon());
                TxtCambioDolar.Text = cambio.ToString();
            }
        }

        private string ValidarAbono()
        {
            if (Abono.CompareTo(Saldo) > 0)
            {
                return "El abono es mayor al Saldo";
            }
            else
            {
                return "";
            }
        }

        private string ValidarPagoCon()
        {
            if (Abono.CompareTo(PagoCon) > 0)
            {
                return "Verifique: El efectivo es menor al monto a pagar";
            }
            else
            {
                return "";
            }
        }
    }
}