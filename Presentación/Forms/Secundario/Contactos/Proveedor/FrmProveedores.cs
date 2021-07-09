using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using Negocio;
using Negocio.Utils;
using Presentación.Forms.Principal.Heredables;
using Presentación.Reports;
using Presentación.Reports.Comprobantes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentación.Forms.Secundario.Contactos.Proveedor
{
    public partial class FrmProveedores : Edition_Collection
    {
        public FrmProveedores()
        {
            InitializeComponent();
            IdColumnName = "IdProveedor";
            modelo = new ModeloProveedor();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            new RptCompra().ShowPreview();
        }

        private void BtnPrintProveedores_Click(object sender, EventArgs e)
        {
            new RptProveedores().ShowPreview();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            modelo.Accion = Accion.Agregar;
            OpenChildForm(new FrmProveedor((ModeloProveedor)modelo, SelectedId));
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            modelo.Accion = Accion.Actualizar;
            OpenChildForm(new FrmProveedor((ModeloProveedor)modelo, SelectedId));
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            modelo.Accion = Accion.Eliminar;
            OpenChildForm(new FrmProveedor((ModeloProveedor)modelo, SelectedId));
        }
    }
}