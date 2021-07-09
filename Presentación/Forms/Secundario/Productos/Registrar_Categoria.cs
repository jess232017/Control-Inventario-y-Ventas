using DevExpress.XtraEditors;
using Negocio;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Presentación.Forms.Secundario.Productos
{
    public partial class Registrar_Categoria : XtraForm
    {
        private readonly ModeloCategoria modelo;
        private static DialogResult dialogResult = new DialogResult();

        private Registrar_Categoria()
        {
            InitializeComponent();
            modelo = new ModeloCategoria();
        }

        public static DialogResult Show()
        {
            new Registrar_Categoria().ShowDialog();

            return dialogResult;
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            modelo.Accion = Negocio.Utils.Accion.Agregar;
            modelo.Entidad = new Entidad.ECategoria
            {
                Descripcion = TxtDescripcion.Text,
                Nombre = txtNombre.Text,
                PorDefecto = checkButton1.Checked
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

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            dialogResult = DialogResult.Cancel;
            Close();
        }
    }
}