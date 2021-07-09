using DevExpress.XtraReports.UI;
using Negocio;
using Negocio.Utils;
using Presentación.Forms.Principal.Heredables;
using Presentación.Reports;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Presentación.Forms.Secundario.Productos
{
    public partial class FrmProductos : Edition_Collection
    {
        public FrmProductos()
        {
            InitializeComponent();
            IdColumnName = "IdProducto";
            modelo = new ModeloProducto();
        }

        #region Eventos

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            modelo.Accion = Accion.Agregar;
            OpenChildForm(new FrmProducto((ModeloProducto)modelo, SelectedId));
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            modelo.Accion = Accion.Actualizar;
            OpenChildForm(new FrmProducto((ModeloProducto)modelo, SelectedId));
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            modelo.Accion = Accion.Eliminar;
            OpenChildForm(new FrmProducto((ModeloProducto)modelo, SelectedId));
        }

        private void BtnRefrescar_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = modelo.LeerTabla();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            //gridControl1.ShowPrintPreview();
            new RptItems().ShowPreview();
        }

        #endregion
    }
}