using DevExpress.XtraReports.UI;
using Negocio;
using Negocio.Utils;
using Presentación.Forms.Principal.Heredables;
using Presentación.Reports;
using System;
using System.Data;

namespace Presentación.Forms.Secundario.Inventarios
{
    public partial class FrmInventarios : Edition_Collection
    {
        private Reporte reporte = Reporte.Undefined;

        public FrmInventarios()
        {
            InitializeComponent();
            IdColumnName = "IdInventario";
            modelo = new ModeloInventario();
        }

        #region Metodos

        #endregion

        #region Eventos

        private void BtnKardex_Click(object sender, EventArgs e)
        {
            if(reporte != Reporte.Undefined)
            {
                reporte = Reporte.Undefined;
                lbSubtitulo.Text = "Listado de Inventarios";
                gridControl1.DataSource = modelo.LeerTabla();
                IdColumnName = "IdInventario";
                gridView1.PopulateColumns();
            }

            if (FlyEdition.Visible)
                FlyEdition.HideBeakForm();
            else
                FlyEdition.ShowBeakForm();
        }

        private void BtnKardexAdd_Click(object sender, EventArgs e)
        {
            modelo.Accion = Accion.Agregar;
            OpenChildForm(new FrmInventario((ModeloInventario)modelo, SelectedId));
        }

        private void BtnKardexEdit_Click(object sender, EventArgs e)
        {
            modelo.Accion = Accion.Actualizar;
            OpenChildForm(new FrmInventario((ModeloInventario)modelo, SelectedId));
        }

        private void BtnKardexDelete_Click(object sender, EventArgs e)
        {
            modelo.Accion = Accion.Eliminar;
            OpenChildForm(new FrmInventario((ModeloInventario)modelo, SelectedId));
        }


        private void BtnItemBajos_Click(object sender, EventArgs e)
        {
            reporte = Reporte.PorAcabar;
            lbSubtitulo.Text = "Lista de Productos pronto a Agotarse";
            gridControl1.DataSource = Datos.ExecuteReader("SELECT * FROM VwProducto_StockBajo", CommandType.Text);
            IdColumnName = "IdProducto";
            gridView1.PopulateColumns();
        }

        private void BtnItemVence_Click(object sender, EventArgs e)
        {
            if (FlyVence.Visible)
                FlyVence.HideBeakForm();
            else
                FlyVence.ShowBeakForm();
        }

        private void BtnVenceAll_Click(object sender, EventArgs e)
        {
            reporte = Reporte.Vencido;
            lbSubtitulo.Text = "Listado de Productos Vencidos";
            gridControl1.DataSource = Datos.ExecuteReader("SELECT * FROM VwLote_Vencido", CommandType.Text);
            IdColumnName = "IdProducto";
            gridView1.PopulateColumns();
        }

        private void BtnToExpire_Click(object sender, EventArgs e)
        {
            reporte = Reporte.PorVencer;
            lbSubtitulo.Text = "Listado de Productos por Vencerse";
            gridControl1.DataSource = Datos.ExecuteReader("SELECT * FROM VwLote_PorVencer", CommandType.Text);
            IdColumnName = "IdProducto";
            gridView1.PopulateColumns();
        }

        private void BtnPrintRpt_Click(object sender, EventArgs e)
        {
            switch (reporte)
            {
                case Reporte.Vencido:
                    new RptItemVencido().ShowPreview();
                    break;
                case Reporte.PorVencer:
                    new RptItemVence().ShowPreview();
                    break;
                case Reporte.PorAcabar:
                    gridControl1.ShowPrintPreview();
                    break;
                default:
                    gridControl1.ShowPrintPreview();
                    break;
            }
        }

        #endregion
    }

    enum Reporte { Vencido, PorVencer, PorAcabar, Undefined }
}