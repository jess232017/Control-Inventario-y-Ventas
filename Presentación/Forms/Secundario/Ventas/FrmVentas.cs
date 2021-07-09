using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraReports.UI;
using Negocio;
using Presentación.Forms.Principal.Heredables;
using Presentación.Reports;
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
    public partial class FrmVentas : Edition_Collection
    {
        public FrmVentas() 
        {
            InitializeComponent();
            IdColumnName = "IdFactura";
            modelo = new ModeloFactura();
        }


        private void BtnVender_Click(object sender, EventArgs e)
        {
            OpenAboveForm(new Registrar_Venta((ModeloFactura)modelo));
        }


        private void GridControl1_Load(object sender, EventArgs e)
        {
            AddItemButton("Imprimir", "Imprimir Recibo", ButtonPredefines.Glyph, Properties.Resources.print_16x16).
            ButtonClick += (_sender, _e) => {
                var value = gridView1.GetFocusedRowCellValue("IdFactura");
                var report = new RptVenta();
                report.Parameters["IdFactura"].Value = value;
                report.RequestParameters = false;
                report.ShowPreview();
            };
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            //gridControl1.ShowPrintPreview();
            new RptAllVentas().ShowPreview();
        }
    }
}