using DevExpress.XtraEditors;
using Negocio;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Presentación.Forms.Secundario.Contable
{
    public partial class Registrar_Contable : XtraForm
    {
        private readonly ModeloContable modelo;
        private static DialogResult dialogResult = new DialogResult();

        private Registrar_Contable()
        {
            InitializeComponent();
            modelo = new ModeloContable();
        }

        public static DialogResult Show()
        {
            new Registrar_Contable().ShowDialog();

            return dialogResult;
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            modelo.Accion = Negocio.Utils.Accion.Agregar;
            modelo.Entidad = new Entidad.EContable
            {
                FechaRegistro = Safety.SafeDateTime(FechaRegistroDateEdit.Text),
                Monto = Safety.SafeFloat(MontoTextEdit.Text),
                IdMovimiento = MovimientoActual(),
                Motivo = MotivoTextEdit.Text,
                Tipo = TipoTextEdit.Text,
                Nota = NotaTextEdit.Text,
            };
            modelo.Accionar();

            if (modelo.Exito)
            {
                dialogResult = DialogResult.OK;
                Close();
                return;
            }

            XtraMessageBox.Show(modelo.Mensaje);
        }

        private int MovimientoActual()
        {
            string SerialPC = Datos.ObtenerSerial();
            //Buscar el movimiento actual
            return new ModeloMovimiento().BuscarIdMovimiento(SerialPC);
        }


        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            dialogResult = DialogResult.Cancel;
            Close();
        }
    }
}