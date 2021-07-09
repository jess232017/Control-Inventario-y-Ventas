using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Negocio;

namespace Presentación.Forms.Secundario.Contable
{
    public partial class RegistrarIngreso : Form
    {
        public RegistrarIngreso()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            Datos.ExecuteNonQuery("insertar_Ingresos_varios", CommandType.StoredProcedure,
                new SqlParameter("@Fecha", DatePicker.Text),
                new SqlParameter("@Nro_comprobante", "-"),
                new SqlParameter("@Tipo_comprobante", "-"),
                new SqlParameter("@Importe", float.Parse(TxtImporte.Text)),
                new SqlParameter("@Descripcion", TxtDetalle.Text));
        }
    }
}
