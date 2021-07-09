using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentación.Forms.Secundario.Ventas
{
    public partial class Venta_Granel : Form
    {
        private static DialogResult result = DialogResult.Cancel;
        private static float Cantidad;
        private float Precio;
        private float Importe;

        private Venta_Granel(string Descripcion, float Precio, float Stock)
        {
            InitializeComponent();
            this.Precio = Precio;
            lbItem.Text = Descripcion;
            TxtCantidad.Properties.MaxValue = (decimal)Stock;
            PriceTag.Text = string.Format(PriceTag.Text, Precio);
        }

        public static DialogResult GetAmount(string Descripcion, ref float Amount, float Precio, float Stock, bool Iniciable = false)
        {
            Venta_Granel frmGranel = new Venta_Granel(Descripcion, Precio, Stock);

            if (Iniciable)
            {
                frmGranel.TxtCantidad.Value = (decimal)Amount;
            }

            frmGranel.ShowDialog();
            Amount = Cantidad;
            return result;
        }

        private void TxtCantidad_EditValueChanged(object sender, EventArgs e)
        {
            if (float.TryParse(TxtCantidad.Text, out float Cantidad))
            {
                Importe = Cantidad * Precio;
                TxtImporte.Text = Importe.ToString();
            }
        }

        private void TxtImporte_EditValueChanged(object sender, EventArgs e)
        {
            if (float.TryParse(TxtImporte.Text, out Importe))
            {
                Cantidad = Importe / Precio;
                TxtCantidad.Text = Cantidad.ToString();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            result = DialogResult.Cancel;
            Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            result = DialogResult.OK;
            Close();
        }
    }
}
