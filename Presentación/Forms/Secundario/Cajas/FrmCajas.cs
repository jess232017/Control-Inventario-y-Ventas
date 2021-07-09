using DevExpress.XtraReports.UI;
using Negocio;
using Negocio.Utils;
using Presentación.Forms.Principal.Heredables;
using Presentación.Reports;
using System;

namespace Presentación.Forms.Secundario.Cajas
{
    public partial class FrmCajas : Edition_Collection
    {
        public FrmCajas()
        {
            modelo = new ModeloCaja();
            InitializeComponent();
        }

        #region Eventos

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            modelo.Accion = Accion.Agregar;
            OpenChildForm(new FrmCaja((ModeloCaja)modelo, SelectedId));
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            modelo.Accion = Accion.Actualizar;
            OpenChildForm(new FrmCaja((ModeloCaja)modelo, SelectedId));
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            modelo.Accion = Accion.Eliminar;
            OpenChildForm(new FrmCaja((ModeloCaja)modelo, SelectedId));
        }

        private void BtnRefrescar_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = modelo.LeerTabla();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            //gridControl1.ShowPrintPreview();
            new RptTienda().ShowPreview();
        }

        #endregion
    }
}