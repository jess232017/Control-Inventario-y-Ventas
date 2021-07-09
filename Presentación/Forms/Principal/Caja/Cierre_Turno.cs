using DevExpress.XtraEditors;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using Negocio;
using Negocio.Utils;

namespace Presentación.Forms.Caja
{
    public partial class Cierre_Turno : XtraForm
    {
        private static DialogResult result;
        private readonly ModeloMovimiento modelo;
        private readonly string SerialPC;
        private readonly float Esperado;
        private float Diferencia;
        private float Realidad;

        private Cierre_Turno()
        {
            InitializeComponent();

            modelo = new ModeloMovimiento();

            //Buscar el movimiento actual
            SerialPC = Datos.ObtenerSerial();
            modelo.Entidad.IdMovimiento = modelo.BuscarIdMovimiento(SerialPC);
            modelo.Entidad = modelo.LeerEntidad();

            //Asignar el Dinero con el que se inicio la caja
            txtExpect.Text = "C$ " + modelo.Entidad.DineroInicial;
            Esperado = modelo.Entidad.DineroInicial;
        }

        #region Metodos

        public static DialogResult Show()
        {
            new Cierre_Turno().ShowDialog(null);
            return result;
        }

        private void GuardarCambio()
        {
            //Definir los datos a cambiar del Movimiento
            modelo.Entidad.Estado = "CERRADO";
            modelo.Entidad.FechaFin = DateTime.Now;
            modelo.Entidad.DineroCierre = Realidad;

            if (Realidad < Esperado)
                modelo.Entidad.Saldo = Diferencia;
            else
                modelo.Entidad.Diferencia = Diferencia;

            //Definir la accion como Actualizar
            modelo.Accion = Accion.Actualizar;

            //Realizar la Accion
            modelo.Accionar();

            if (!modelo.Exito)
                XtraMessageBox.Show(modelo.Mensaje);
        }

        #endregion

        #region Eventos

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            result = DialogResult.Cancel;
            Close();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            GuardarCambio();
            result = modelo.Exito ? DialogResult.OK : DialogResult.Abort;
            Close();
        }

        private void TxtReality_TextChanged(object sender, EventArgs e)
        {
            if (!float.TryParse(TxtReality.Text, out Realidad))
            {
                Realidad = 0;
            }

            Diferencia = Realidad - Esperado;
            TxtDiferencia.Text = "C$ " + string.Format("{0:F2}", Diferencia);

            if (Diferencia == 0)
            {
                LbAviso.Text = "Genial, Todo esta perfecto 👍";
                LbAviso.ForeColor = Color.FromArgb(0, 166, 63);
                TxtDiferencia.ForeColor = Color.FromArgb(0, 166, 63);
                LbAviso.Visible = true;
                return;
            }
            
            if (Realidad < Esperado)
            {
                LbAviso.Text = "La diferencia sera Registrada en su Turno y se enviara a Gerencia";
                LbAviso.ForeColor = Color.FromArgb(231, 63, 67);
                TxtDiferencia.ForeColor = Color.Red;
                LbAviso.Visible = true;
                return;
            }

            LbAviso.Text = "La diferencia sera Registrada en su Turno y se enviara a Gerencia";
            LbAviso.ForeColor = Color.FromArgb(0, 166, 63);
            TxtDiferencia.ForeColor = Color.FromArgb(0, 166, 63);
            LbAviso.Visible = true;
        }

        #endregion
    }
}