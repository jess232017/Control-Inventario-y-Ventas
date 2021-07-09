using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Negocio;

namespace Presentación.Forms.Secundario.Contable
{
    public partial class RegistrarEgreso : Form
    {
        public RegistrarEgreso()
        {
            InitializeComponent();
            GetConceptos();
        }

        private void GetConceptos()
        {
               LkConcepto.Properties.DataSource = Datos.ExecuteReader("buscar_conceptos", CommandType.StoredProcedure,
                new SqlParameter("@letra", ""));
            LkConcepto.Properties.DisplayMember = "Concepto";
            LkConcepto.Properties.ValueMember = "Id_concepto";
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Datos.ExecuteNonQuery("insertar_Gastos_varios", CommandType.StoredProcedure,
                new SqlParameter("@Fecha", DatePicker.Text),
                new SqlParameter("@Nro_documento", "-"),
                new SqlParameter("@Tipo_comprobante", "-"),
                new SqlParameter("@Importe", float.Parse(TxtImporte.Text)),
                new SqlParameter("@Descripcion", richTextBox1.Text),
                new SqlParameter("@Id_concepto", LkConcepto.EditValue));
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            string Response = XtraInputBox.Show("Nombre: ", "Agregar nuevo concepto", "");
            if (!Response.Equals(""))
            {
                Datos.ExecuteNonQuery("insertar_Conceptos", CommandType.StoredProcedure,
                    new SqlParameter("@Descripcion", Response));
                GetConceptos();
            }
            else
            {
                XtraMessageBox.Show("Cancelado");
            }

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
