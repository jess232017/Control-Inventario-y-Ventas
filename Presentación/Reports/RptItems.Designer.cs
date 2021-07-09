
namespace Presentación.Reports
{
    partial class RptItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RptItems));
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.pictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.lbTitle = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader0 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.table3 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.table1 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.ReportFooter1 = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.table4 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.General = new DevExpress.XtraReports.UI.XRControlStyle();
            this.TableHeaderStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.TableStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.FirstLetter = new DevExpress.XtraReports.UI.CalculatedField();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.PrimerLetra = new DevExpress.XtraReports.UI.CalculatedField();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            ((System.ComponentModel.ISupportInitialize)(this.table3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pictureBox1,
            this.xrPageInfo2,
            this.lbTitle});
            this.ReportHeader.HeightF = 138.1917F;
            this.ReportHeader.Name = "ReportHeader";
            this.ReportHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.ReportHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("pictureBox1.ImageSource"));
            this.pictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(636.0253F, 11.45833F);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.SizeF = new System.Drawing.SizeF(40.01636F, 40.06726F);
            this.pictureBox1.StylePriority.UsePadding = false;
            // 
            // xrPageInfo2
            // 
            this.xrPageInfo2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 60.20612F);
            this.xrPageInfo2.Name = "xrPageInfo2";
            this.xrPageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.xrPageInfo2.SizeF = new System.Drawing.SizeF(96F, 16F);
            this.xrPageInfo2.StyleName = "General";
            this.xrPageInfo2.StylePriority.UsePadding = false;
            this.xrPageInfo2.StylePriority.UseTextAlignment = false;
            this.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrPageInfo2.TextFormatString = "{0:d}";
            // 
            // lbTitle
            // 
            this.lbTitle.BorderColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Arial", 21F, System.Drawing.FontStyle.Bold);
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.lbTitle.LocationFloat = new DevExpress.Utils.PointFloat(0F, 18.10891F);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbTitle.SizeF = new System.Drawing.SizeF(451.0834F, 33.41667F);
            this.lbTitle.StylePriority.UseBorderColor = false;
            this.lbTitle.StylePriority.UseFont = false;
            this.lbTitle.StylePriority.UseForeColor = false;
            this.lbTitle.StylePriority.UsePadding = false;
            this.lbTitle.Text = "Lista Alfabetica de Productos";
            this.lbTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // GroupHeader0
            // 
            this.GroupHeader0.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1});
            this.GroupHeader0.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("PrimerLetra", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader0.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader0.HeightF = 64F;
            this.GroupHeader0.Level = 1;
            this.GroupHeader0.Name = "GroupHeader0";
            this.GroupHeader0.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader0.PrintAcrossBands = true;
            this.GroupHeader0.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel1
            // 
            this.xrLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(128)))));
            this.xrLabel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PrimerLetra]")});
            this.xrLabel1.Font = new System.Drawing.Font("Arial", 21F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.SizeF = new System.Drawing.SizeF(60F, 62F);
            this.xrLabel1.StylePriority.UseBackColor = false;
            this.xrLabel1.StylePriority.UseBorderColor = false;
            this.xrLabel1.StylePriority.UseBorders = false;
            this.xrLabel1.StylePriority.UseBorderWidth = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseForeColor = false;
            this.xrLabel1.StylePriority.UsePadding = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // Detail
            // 
            this.Detail.BorderColor = System.Drawing.Color.White;
            this.Detail.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table3});
            this.Detail.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Detail.HeightF = 32F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Descripcion", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table3
            // 
            this.table3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.table3.Name = "table3";
            this.table3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow3});
            this.table3.SizeF = new System.Drawing.SizeF(700F, 32F);
            this.table3.StylePriority.UseBorderColor = false;
            this.table3.StylePriority.UseBorders = false;
            this.table3.StylePriority.UseFont = false;
            this.table3.StylePriority.UseForeColor = false;
            // 
            // tableRow3
            // 
            this.tableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.tableCell9,
            this.xrTableCell5,
            this.tableCell10,
            this.tableCell11,
            this.tableCell12});
            this.tableRow3.Name = "tableRow3";
            this.tableRow3.Weight = 2.7878787878787881D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(128)))));
            this.xrTableCell1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCell1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "[ProductName] != [][[^.FirstLetter] == [FirstLetter]].Min([ProductName])")});
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.StyleName = "TableStyle";
            this.xrTableCell1.StylePriority.UseBackColor = false;
            this.xrTableCell1.StylePriority.UseBorderColor = false;
            this.xrTableCell1.StylePriority.UseBorders = false;
            this.xrTableCell1.StylePriority.UseBorderWidth = false;
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.StylePriority.UseForeColor = false;
            this.xrTableCell1.StylePriority.UsePadding = false;
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.Weight = 80.547271640703542D;
            // 
            // tableCell9
            // 
            this.tableCell9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Descripcion]")});
            this.tableCell9.Multiline = true;
            this.tableCell9.Name = "tableCell9";
            this.tableCell9.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 0, 100F);
            this.tableCell9.StyleName = "TableStyle";
            this.tableCell9.StylePriority.UseBackColor = false;
            this.tableCell9.StylePriority.UseBorderColor = false;
            this.tableCell9.StylePriority.UseBorders = false;
            this.tableCell9.StylePriority.UseBorderWidth = false;
            this.tableCell9.StylePriority.UseFont = false;
            this.tableCell9.StylePriority.UseForeColor = false;
            this.tableCell9.StylePriority.UsePadding = false;
            this.tableCell9.StylePriority.UseTextAlignment = false;
            this.tableCell9.Text = "tableCell1";
            this.tableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.tableCell9.Weight = 232.03110892617013D;
            // 
            // tableCell10
            // 
            this.tableCell10.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Categoria]")});
            this.tableCell10.Multiline = true;
            this.tableCell10.Name = "tableCell10";
            this.tableCell10.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 0, 100F);
            this.tableCell10.StyleName = "TableStyle";
            this.tableCell10.StylePriority.UseBackColor = false;
            this.tableCell10.StylePriority.UseBorderColor = false;
            this.tableCell10.StylePriority.UseBorders = false;
            this.tableCell10.StylePriority.UseBorderWidth = false;
            this.tableCell10.StylePriority.UseFont = false;
            this.tableCell10.StylePriority.UseForeColor = false;
            this.tableCell10.StylePriority.UsePadding = false;
            this.tableCell10.StylePriority.UseTextAlignment = false;
            this.tableCell10.Text = "tableCell6";
            this.tableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.tableCell10.Weight = 141.800100530036D;
            // 
            // tableCell11
            // 
            this.tableCell11.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PrecioVenta]")});
            this.tableCell11.KeepTogether = true;
            this.tableCell11.Multiline = true;
            this.tableCell11.Name = "tableCell11";
            this.tableCell11.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 0, 100F);
            this.tableCell11.StyleName = "TableStyle";
            this.tableCell11.StylePriority.UseBackColor = false;
            this.tableCell11.StylePriority.UseBorderColor = false;
            this.tableCell11.StylePriority.UseBorders = false;
            this.tableCell11.StylePriority.UseBorderWidth = false;
            this.tableCell11.StylePriority.UseFont = false;
            this.tableCell11.StylePriority.UseForeColor = false;
            this.tableCell11.StylePriority.UsePadding = false;
            this.tableCell11.StylePriority.UseTextAlignment = false;
            this.tableCell11.Text = "tableCell7";
            this.tableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.tableCell11.TextFormatString = "{0:#.00}";
            this.tableCell11.Weight = 149.95894912870602D;
            // 
            // tableCell12
            // 
            this.tableCell12.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
            this.tableCell12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Cantidad]")});
            this.tableCell12.KeepTogether = true;
            this.tableCell12.Multiline = true;
            this.tableCell12.Name = "tableCell12";
            this.tableCell12.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 8, 0, 0, 100F);
            this.tableCell12.StyleName = "TableStyle";
            this.tableCell12.StylePriority.UseBackColor = false;
            this.tableCell12.StylePriority.UseBorderColor = false;
            this.tableCell12.StylePriority.UseBorders = false;
            this.tableCell12.StylePriority.UseBorderWidth = false;
            this.tableCell12.StylePriority.UseFont = false;
            this.tableCell12.StylePriority.UseForeColor = false;
            this.tableCell12.StylePriority.UsePadding = false;
            this.tableCell12.StylePriority.UseTextAlignment = false;
            this.tableCell12.Text = "xrTableCell6";
            this.tableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell12.TextFormatString = "{0:#.00}";
            this.tableCell12.Weight = 170.04688720478396D;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel2});
            this.BottomMargin.HeightF = 88F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Arial", 9F);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(249.9139F, 31.1416F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(201.1695F, 23F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "Impreso por:  Sistema";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.HeightF = 85F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine1,
            this.table1});
            this.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader1.HeightF = 32F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // xrLine1
            // 
            this.xrLine1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.xrLine1.LineWidth = 2F;
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(700F, 2F);
            this.xrLine1.StylePriority.UseBorderColor = false;
            this.xrLine1.StylePriority.UseForeColor = false;
            // 
            // table1
            // 
            this.table1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Bookmark", "FirstLetter")});
            this.table1.LocationFloat = new DevExpress.Utils.PointFloat(60F, 2F);
            this.table1.Name = "table1";
            this.table1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow1});
            this.table1.SizeF = new System.Drawing.SizeF(640F, 30F);
            this.table1.StylePriority.UseBackColor = false;
            this.table1.StylePriority.UseBorderColor = false;
            this.table1.StylePriority.UseBorders = false;
            this.table1.StylePriority.UseFont = false;
            this.table1.StylePriority.UseForeColor = false;
            this.table1.StylePriority.UsePadding = false;
            this.table1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // tableRow1
            // 
            this.tableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell2,
            this.xrTableCell4,
            this.tableCell3,
            this.tableCell4,
            this.tableCell5});
            this.tableRow1.Name = "tableRow1";
            this.tableRow1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow1.Weight = 0.9538342864480398D;
            // 
            // tableCell2
            // 
            this.tableCell2.Name = "tableCell2";
            this.tableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.tableCell2.StyleName = "TableHeaderStyle";
            this.tableCell2.StylePriority.UseTextAlignment = false;
            this.tableCell2.Text = "Nombre del Producto";
            this.tableCell2.Weight = 0.38575415685319997D;
            // 
            // tableCell3
            // 
            this.tableCell3.Name = "tableCell3";
            this.tableCell3.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.tableCell3.StyleName = "TableHeaderStyle";
            this.tableCell3.StylePriority.UseTextAlignment = false;
            this.tableCell3.Text = "Categoria";
            this.tableCell3.Weight = 0.23574421792486711D;
            // 
            // tableCell4
            // 
            this.tableCell4.Name = "tableCell4";
            this.tableCell4.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.tableCell4.StyleName = "TableHeaderStyle";
            this.tableCell4.StylePriority.UseTextAlignment = false;
            this.tableCell4.Text = "Precio Unitario";
            this.tableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.tableCell4.Weight = 0.24930836983492541D;
            // 
            // tableCell5
            // 
            this.tableCell5.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.tableCell5.Name = "tableCell5";
            this.tableCell5.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 8, 0, 0, 100F);
            this.tableCell5.StyleName = "TableHeaderStyle";
            this.tableCell5.StylePriority.UseBorders = false;
            this.tableCell5.StylePriority.UsePadding = false;
            this.tableCell5.StylePriority.UseTextAlignment = false;
            this.tableCell5.Text = "Stock disponible";
            this.tableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell5.Weight = 0.2827047740661241D;
            // 
            // ReportFooter1
            // 
            this.ReportFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table4});
            this.ReportFooter1.HeightF = 2F;
            this.ReportFooter1.Name = "ReportFooter1";
            // 
            // table4
            // 
            this.table4.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.table4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.table4.Name = "table4";
            this.table4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.table4.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.table4.SizeF = new System.Drawing.SizeF(700.0001F, 2F);
            this.table4.StylePriority.UseBorders = false;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell2,
            this.xrTableCell3});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(128)))));
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.StylePriority.UseBorderColor = false;
            this.xrTableCell2.Weight = 0.5999999618530274D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(237)))));
            this.xrTableCell3.Multiline = true;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.StylePriority.UseBorderColor = false;
            this.xrTableCell3.Weight = 6.4000006484985352D;
            // 
            // General
            // 
            this.General.Font = new System.Drawing.Font("Arial", 10F);
            this.General.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.General.Name = "General";
            // 
            // TableHeaderStyle
            // 
            this.TableHeaderStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(237)))));
            this.TableHeaderStyle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.TableHeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.TableHeaderStyle.Name = "TableHeaderStyle";
            this.TableHeaderStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 0, 100F);
            // 
            // TableStyle
            // 
            this.TableStyle.BackColor = System.Drawing.Color.Transparent;
            this.TableStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(237)))));
            this.TableStyle.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.TableStyle.BorderWidth = 1F;
            this.TableStyle.Font = new System.Drawing.Font("Arial", 9F);
            this.TableStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.TableStyle.Name = "TableStyle";
            this.TableStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 0, 100F);
            // 
            // FirstLetter
            // 
            this.FirstLetter.DataMember = "Products";
            this.FirstLetter.Expression = "Substring([ProductName], 0, 1)";
            this.FirstLetter.Name = "FirstLetter";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "ConexionBD";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "SP_ProductoBuscar";
            queryParameter1.Name = "@Buscar";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("\'\'", typeof(string));
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.StoredProcName = "SP_ProductoBuscar";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // PrimerLetra
            // 
            this.PrimerLetra.DataMember = "SP_ProductoBuscar";
            this.PrimerLetra.Expression = "Substring([Descripcion], 0, 1)";
            this.PrimerLetra.FieldType = DevExpress.XtraReports.UI.FieldType.String;
            this.PrimerLetra.Name = "PrimerLetra";
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Multiline = true;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.xrTableCell4.StyleName = "TableHeaderStyle";
            this.xrTableCell4.StylePriority.UseTextAlignment = false;
            this.xrTableCell4.Text = "Marca";
            this.xrTableCell4.Weight = 0.27487015427449707D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Marca]")});
            this.xrTableCell5.Multiline = true;
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 0, 100F);
            this.xrTableCell5.StyleName = "TableStyle";
            this.xrTableCell5.StylePriority.UseBackColor = false;
            this.xrTableCell5.StylePriority.UseBorderColor = false;
            this.xrTableCell5.StylePriority.UseBorders = false;
            this.xrTableCell5.StylePriority.UseBorderWidth = false;
            this.xrTableCell5.StylePriority.UseFont = false;
            this.xrTableCell5.StylePriority.UseForeColor = false;
            this.xrTableCell5.StylePriority.UsePadding = false;
            this.xrTableCell5.StylePriority.UseTextAlignment = false;
            this.xrTableCell5.Text = "xrTableCell5";
            this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell5.Weight = 165.33436678444141D;
            // 
            // RptItems
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.ReportHeader,
            this.GroupHeader0,
            this.Detail,
            this.BottomMargin,
            this.topMarginBand1,
            this.GroupHeader1,
            this.ReportFooter1});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.FirstLetter,
            this.PrimerLetra});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "SP_ProductoBuscar";
            this.DataSource = this.sqlDataSource1;
            this.DisplayName = "Product List";
            this.Margins = new System.Drawing.Printing.Margins(75, 75, 85, 88);
            this.ShowPreviewMarginLines = false;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.General,
            this.TableHeaderStyle,
            this.TableStyle});
            this.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.Version = "20.1";
            ((System.ComponentModel.ISupportInitialize)(this.table3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRPictureBox pictureBox1;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo2;
        private DevExpress.XtraReports.UI.XRLabel lbTitle;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader0;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRTable table3;
        private DevExpress.XtraReports.UI.XRTableRow tableRow3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell tableCell9;
        private DevExpress.XtraReports.UI.XRTableCell tableCell10;
        private DevExpress.XtraReports.UI.XRTableCell tableCell11;
        private DevExpress.XtraReports.UI.XRTableCell tableCell12;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRTable table1;
        private DevExpress.XtraReports.UI.XRTableRow tableRow1;
        private DevExpress.XtraReports.UI.XRTableCell tableCell2;
        private DevExpress.XtraReports.UI.XRTableCell tableCell3;
        private DevExpress.XtraReports.UI.XRTableCell tableCell4;
        private DevExpress.XtraReports.UI.XRTableCell tableCell5;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter1;
        private DevExpress.XtraReports.UI.XRTable table4;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRControlStyle General;
        private DevExpress.XtraReports.UI.XRControlStyle TableHeaderStyle;
        private DevExpress.XtraReports.UI.XRControlStyle TableStyle;
        private DevExpress.XtraReports.UI.CalculatedField FirstLetter;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.CalculatedField PrimerLetra;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
    }
}
