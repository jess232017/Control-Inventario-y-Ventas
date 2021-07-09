
namespace Presentación.Reports
{
    partial class RptClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RptClientes));
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.lbCaption = new DevExpress.XtraReports.UI.XRLabel();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrPanel2 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrPictureBox4 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lbCaption});
            this.ReportHeader.HeightF = 75F;
            this.ReportHeader.Name = "ReportHeader";
            this.ReportHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.ReportHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lbCaption
            // 
            this.lbCaption.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbCaption.Font = new System.Drawing.Font("Tahoma", 20.25F);
            this.lbCaption.ForeColor = System.Drawing.Color.White;
            this.lbCaption.LocationFloat = new DevExpress.Utils.PointFloat(3.999996F, 0F);
            this.lbCaption.Name = "lbCaption";
            this.lbCaption.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbCaption.SizeF = new System.Drawing.SizeF(638F, 50F);
            this.lbCaption.StylePriority.UseBackColor = false;
            this.lbCaption.Text = "Lista de Clientes";
            this.lbCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel2});
            this.Detail.HeightF = 174F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPanel2
            // 
            this.xrPanel2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox1,
            this.xrTable1,
            this.xrLabel4,
            this.xrLabel2,
            this.xrLabel9,
            this.xrLabel6,
            this.xrLabel7,
            this.xrLabel8});
            this.xrPanel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Bookmark", "\'Employee: \' + [LastName]")});
            this.xrPanel2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrPanel2.Name = "xrPanel2";
            this.xrPanel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrPanel2.SizeF = new System.Drawing.SizeF(650F, 146.8125F);
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ImageSource", "[Imagen]")});
            this.xrPictureBox1.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("xrPictureBox1.ImageSource"));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(35.00001F, 13.00004F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(135.9375F, 120F);
            // 
            // xrTable1
            // 
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(205.5417F, 100F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F);
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(436.4583F, 33F);
            this.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell3});
            this.xrTableRow1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F);
            this.xrTableRow1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.xrTableCell1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.xrTableCell1.ForeColor = System.Drawing.Color.White;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(11, 6, 6, 4, 100F);
            this.xrTableCell1.StylePriority.UseBackColor = false;
            this.xrTableCell1.Text = "Estado:";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell1.Weight = 0.26225488999310664D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.BackColor = System.Drawing.Color.Silver;
            this.xrTableCell3.BorderColor = System.Drawing.Color.White;
            this.xrTableCell3.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.xrTableCell3.BorderWidth = 4F;
            this.xrTableCell3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Estado]")});
            this.xrTableCell3.ForeColor = System.Drawing.Color.Black;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Padding = new DevExpress.XtraPrinting.PaddingInfo(9, 6, 4, 4, 100F);
            this.xrTableCell3.StylePriority.UseBackColor = false;
            this.xrTableCell3.Text = "xrTableCell3";
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell3.Weight = 0.76470588235294112D;
            // 
            // xrLabel4
            // 
            this.xrLabel4.BackColor = System.Drawing.Color.Silver;
            this.xrLabel4.BorderColor = System.Drawing.Color.Black;
            this.xrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Nombre] + \' \' + [Apellido]")});
            this.xrLabel4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(321F, 13F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(9, 6, 4, 4, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(320F, 25F);
            this.xrLabel4.StylePriority.UseBackColor = false;
            this.xrLabel4.Text = "[Nombre] [Apellido]";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            // 
            // xrLabel2
            // 
            this.xrLabel2.BackColor = System.Drawing.Color.Silver;
            this.xrLabel2.BorderColor = System.Drawing.Color.Black;
            this.xrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Telefono]")});
            this.xrLabel2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(321F, 42F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(9, 6, 4, 4, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(320F, 25F);
            this.xrLabel2.StylePriority.UseBackColor = false;
            this.xrLabel2.Text = "xrLabel2";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel9
            // 
            this.xrLabel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.xrLabel9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.xrLabel9.ForeColor = System.Drawing.Color.White;
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(205.5417F, 71.00004F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(11, 6, 5, 4, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(111.4583F, 25F);
            this.xrLabel9.StylePriority.UseBackColor = false;
            this.xrLabel9.Text = "Identificacion:";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel6
            // 
            this.xrLabel6.BackColor = System.Drawing.Color.Silver;
            this.xrLabel6.BorderColor = System.Drawing.Color.Black;
            this.xrLabel6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[IdCliente]")});
            this.xrLabel6.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(321F, 71F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(9, 6, 4, 4, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(320F, 25F);
            this.xrLabel6.StylePriority.UseBackColor = false;
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLabel6.TextFormatString = "{0}";
            this.xrLabel6.XlsxFormatString = "dddd, mmmm dd, yyyy";
            // 
            // xrLabel7
            // 
            this.xrLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.xrLabel7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.xrLabel7.ForeColor = System.Drawing.Color.White;
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(205.5417F, 13.00001F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(11, 6, 5, 4, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(111.4583F, 25F);
            this.xrLabel7.StylePriority.UseBackColor = false;
            this.xrLabel7.Text = "Nombre:";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel8
            // 
            this.xrLabel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.xrLabel8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.xrLabel8.ForeColor = System.Drawing.Color.White;
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(205.5417F, 42.00001F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(11, 6, 5, 4, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(111.4583F, 25F);
            this.xrLabel8.StylePriority.UseBackColor = false;
            this.xrLabel8.Text = "Telefono:";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox4,
            this.xrPageInfo1});
            this.BottomMargin.HeightF = 75F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPictureBox4
            // 
            this.xrPictureBox4.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("xrPictureBox4.ImageSource"));
            this.xrPictureBox4.LocationFloat = new DevExpress.Utils.PointFloat(317F, 20.12501F);
            this.xrPictureBox4.Name = "xrPictureBox4";
            this.xrPictureBox4.NavigateUrl = "http://www.devexpress.com/Products/NET/Reporting/";
            this.xrPictureBox4.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrPictureBox4.SizeF = new System.Drawing.SizeF(33.33333F, 33.33333F);
            this.xrPictureBox4.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize;
            this.xrPictureBox4.UseImageResolution = false;
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic);
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(542F, 4F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(98F, 17F);
            this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrPageInfo1.TextFormatString = "Pagina : {0 } / {1}";
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.HeightF = 105F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "ConexionBD";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "SP_ClienteSeleccionar";
            queryParameter1.Name = "@IdCliente";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("?", typeof(int));
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.StoredProcName = "SP_ClienteSeleccionar";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // RptClientes
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.ReportHeader,
            this.Detail,
            this.BottomMargin,
            this.topMarginBand1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "SP_ClienteSeleccionar";
            this.DataSource = this.sqlDataSource1;
            this.DisplayName = "Shrink & Grow";
            this.Margins = new System.Drawing.Printing.Margins(100, 100, 105, 75);
            this.Version = "20.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel lbCaption;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRPanel xrPanel2;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox4;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
    }
}
