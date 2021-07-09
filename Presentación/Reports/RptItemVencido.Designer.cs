
namespace Presentación.Reports
{
    partial class RptItemVencido
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
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.AllColumns allColumns1 = new DevExpress.DataAccess.Sql.AllColumns();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery2 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.AllColumns allColumns2 = new DevExpress.DataAccess.Sql.AllColumns();
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RptItemVencido));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.thankYouLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.totalTable = new DevExpress.XtraReports.UI.XRTable();
            this.totalRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.totalCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.total = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.headerTable = new DevExpress.XtraReports.UI.XRTable();
            this.headerTableRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.productDesctiptionCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.quantityCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.unitPriceCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.lineTotalCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.baseControlStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.evenDetailStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.oddDetailStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
            this.detailTable = new DevExpress.XtraReports.UI.XRTable();
            this.detailTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.productName = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.quantity = new DevExpress.XtraReports.UI.XRTableCell();
            this.unitPrice = new DevExpress.XtraReports.UI.XRTableCell();
            this.lineTotal = new DevExpress.XtraReports.UI.XRTableCell();
            this.detailTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.productDescription = new DevExpress.XtraReports.UI.XRTableCell();
            this.detailTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.detailTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.detailTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.calculatedField1 = new DevExpress.XtraReports.UI.CalculatedField();
            this.calculatedField2 = new DevExpress.XtraReports.UI.CalculatedField();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Expanded = false;
            this.Detail.HeightF = 50F;
            this.Detail.KeepTogether = true;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.StyleName = "baseControlStyle";
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 50F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.StylePriority.UseBackColor = false;
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.thankYouLabel});
            this.BottomMargin.HeightF = 67.02982F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.StyleName = "baseControlStyle";
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // thankYouLabel
            // 
            this.thankYouLabel.CanGrow = false;
            this.thankYouLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thankYouLabel.LocationFloat = new DevExpress.Utils.PointFloat(9.999977F, 9.999964F);
            this.thankYouLabel.Name = "thankYouLabel";
            this.thankYouLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.thankYouLabel.SizeF = new System.Drawing.SizeF(305F, 20.66021F);
            this.thankYouLabel.StylePriority.UseFont = false;
            this.thankYouLabel.StylePriority.UseForeColor = false;
            this.thankYouLabel.StylePriority.UseTextAlignment = false;
            this.thankYouLabel.Text = "Impreso por SCI";
            this.thankYouLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // GroupHeader2
            // 
            this.GroupHeader2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel17,
            this.xrTable3});
            this.GroupHeader2.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("InvoiceNumber", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader2.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader2.HeightF = 91.20833F;
            this.GroupHeader2.Level = 1;
            this.GroupHeader2.Name = "GroupHeader2";
            this.GroupHeader2.StyleName = "baseControlStyle";
            this.GroupHeader2.StylePriority.UseBackColor = false;
            // 
            // xrLabel17
            // 
            this.xrLabel17.CanGrow = false;
            this.xrLabel17.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(9.999974F, 10.00001F);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(305F, 66.00002F);
            this.xrLabel17.StylePriority.UseFont = false;
            this.xrLabel17.StylePriority.UseForeColor = false;
            this.xrLabel17.StylePriority.UsePadding = false;
            this.xrLabel17.StylePriority.UseTextAlignment = false;
            this.xrLabel17.Text = "Productos Vencidos";
            this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTable3
            // 
            this.xrTable3.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(449.9684F, 10.00001F);
            this.xrTable3.Name = "xrTable3";
            this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3,
            this.xrTableRow4,
            this.xrTableRow7});
            this.xrTable3.SizeF = new System.Drawing.SizeF(266.0979F, 66F);
            this.xrTable3.StylePriority.UseTextAlignment = false;
            this.xrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell13});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 0.88D;
            // 
            // xrTableCell13
            // 
            this.xrTableCell13.Multiline = true;
            this.xrTableCell13.Name = "xrTableCell13";
            this.xrTableCell13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell13.Text = "Distribuidora San Jose";
            this.xrTableCell13.Weight = 1D;
            // 
            // xrTableRow4
            // 
            this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell14});
            this.xrTableRow4.Name = "xrTableRow4";
            this.xrTableRow4.Weight = 0.88000000000000012D;
            // 
            // xrTableCell14
            // 
            this.xrTableCell14.Multiline = true;
            this.xrTableCell14.Name = "xrTableCell14";
            this.xrTableCell14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell14.Text = "Ciudad Sandino, Managua, Nicaragua";
            this.xrTableCell14.Weight = 1D;
            // 
            // xrTableRow7
            // 
            this.xrTableRow7.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell11});
            this.xrTableRow7.Name = "xrTableRow7";
            this.xrTableRow7.Weight = 0.88D;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.Multiline = true;
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell11.Text = "8679-5356";
            this.xrTableCell11.Weight = 1D;
            // 
            // totalTable
            // 
            this.totalTable.ForeColor = System.Drawing.Color.Black;
            this.totalTable.LocationFloat = new DevExpress.Utils.PointFloat(423.9267F, 0F);
            this.totalTable.Name = "totalTable";
            this.totalTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.totalRow});
            this.totalTable.SizeF = new System.Drawing.SizeF(316.0733F, 37.96946F);
            this.totalTable.StylePriority.UseForeColor = false;
            this.totalTable.StylePriority.UsePadding = false;
            // 
            // totalRow
            // 
            this.totalRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.totalCaption,
            this.total});
            this.totalRow.Name = "totalRow";
            this.totalRow.Weight = 1.4D;
            // 
            // totalCaption
            // 
            this.totalCaption.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCaption.Name = "totalCaption";
            this.totalCaption.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 0, 100F);
            this.totalCaption.StyleName = "evenDetailStyle";
            this.totalCaption.StylePriority.UseBackColor = false;
            this.totalCaption.StylePriority.UseBorderColor = false;
            this.totalCaption.StylePriority.UseBorders = false;
            this.totalCaption.StylePriority.UseBorderWidth = false;
            this.totalCaption.StylePriority.UseFont = false;
            this.totalCaption.StylePriority.UseForeColor = false;
            this.totalCaption.StylePriority.UsePadding = false;
            this.totalCaption.StylePriority.UseTextAlignment = false;
            this.totalCaption.Text = "TOTAL PERDIDO";
            this.totalCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.totalCaption.Weight = 1.6334021146879181D;
            // 
            // total
            // 
            this.total.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Sum([calculatedField2])")});
            this.total.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Name = "total";
            this.total.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F);
            this.total.StyleName = "evenDetailStyle";
            this.total.StylePriority.UseBackColor = false;
            this.total.StylePriority.UseBorderColor = false;
            this.total.StylePriority.UseBorders = false;
            this.total.StylePriority.UseBorderWidth = false;
            this.total.StylePriority.UseFont = false;
            this.total.StylePriority.UseForeColor = false;
            this.total.StylePriority.UsePadding = false;
            this.total.StylePriority.UseTextAlignment = false;
            this.total.Text = "0,00 C$";
            this.total.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.total.TextFormatString = "{0:$0.00}";
            this.total.Weight = 1.1322956248302925D;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.headerTable});
            this.GroupHeader1.HeightF = 30F;
            this.GroupHeader1.Name = "GroupHeader1";
            this.GroupHeader1.RepeatEveryPage = true;
            this.GroupHeader1.StyleName = "baseControlStyle";
            // 
            // headerTable
            // 
            this.headerTable.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerTable.LocationFloat = new DevExpress.Utils.PointFloat(10.00021F, 0F);
            this.headerTable.Name = "headerTable";
            this.headerTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.headerTableRow});
            this.headerTable.SizeF = new System.Drawing.SizeF(729.9998F, 30F);
            this.headerTable.StylePriority.UseFont = false;
            this.headerTable.StylePriority.UsePadding = false;
            // 
            // headerTableRow
            // 
            this.headerTableRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.productDesctiptionCaption,
            this.xrTableCell1,
            this.quantityCaption,
            this.unitPriceCaption,
            this.lineTotalCaption});
            this.headerTableRow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.headerTableRow.Name = "headerTableRow";
            this.headerTableRow.StylePriority.UseFont = false;
            this.headerTableRow.Weight = 6.8299491460003461D;
            // 
            // productDesctiptionCaption
            // 
            this.productDesctiptionCaption.Name = "productDesctiptionCaption";
            this.productDesctiptionCaption.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.productDesctiptionCaption.StylePriority.UseBackColor = false;
            this.productDesctiptionCaption.StylePriority.UseFont = false;
            this.productDesctiptionCaption.StylePriority.UseForeColor = false;
            this.productDesctiptionCaption.StylePriority.UsePadding = false;
            this.productDesctiptionCaption.StylePriority.UseTextAlignment = false;
            this.productDesctiptionCaption.Text = "DESCRIPCION DEL PRODUCTO";
            this.productDesctiptionCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.productDesctiptionCaption.Weight = 0.8090826986817713D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 0, 100F);
            this.xrTableCell1.StylePriority.UseBackColor = false;
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.StylePriority.UseForeColor = false;
            this.xrTableCell1.StylePriority.UsePadding = false;
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.Text = "FECHA VENCE";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell1.Weight = 0.30545711923354973D;
            // 
            // quantityCaption
            // 
            this.quantityCaption.Name = "quantityCaption";
            this.quantityCaption.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 0, 100F);
            this.quantityCaption.StylePriority.UseBackColor = false;
            this.quantityCaption.StylePriority.UseFont = false;
            this.quantityCaption.StylePriority.UseForeColor = false;
            this.quantityCaption.StylePriority.UsePadding = false;
            this.quantityCaption.StylePriority.UseTextAlignment = false;
            this.quantityCaption.Text = "CANTIDAD";
            this.quantityCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.quantityCaption.Weight = 0.23859408643945468D;
            // 
            // unitPriceCaption
            // 
            this.unitPriceCaption.Name = "unitPriceCaption";
            this.unitPriceCaption.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.unitPriceCaption.StylePriority.UseBackColor = false;
            this.unitPriceCaption.StylePriority.UseFont = false;
            this.unitPriceCaption.StylePriority.UseForeColor = false;
            this.unitPriceCaption.StylePriority.UsePadding = false;
            this.unitPriceCaption.StylePriority.UseTextAlignment = false;
            this.unitPriceCaption.Text = "COSTO UNIT";
            this.unitPriceCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.unitPriceCaption.Weight = 0.26403618278420932D;
            // 
            // lineTotalCaption
            // 
            this.lineTotalCaption.Name = "lineTotalCaption";
            this.lineTotalCaption.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 5, 0, 0, 100F);
            this.lineTotalCaption.StylePriority.UseBackColor = false;
            this.lineTotalCaption.StylePriority.UseFont = false;
            this.lineTotalCaption.StylePriority.UseForeColor = false;
            this.lineTotalCaption.StylePriority.UsePadding = false;
            this.lineTotalCaption.StylePriority.UseTextAlignment = false;
            this.lineTotalCaption.Text = "TOTAL";
            this.lineTotalCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lineTotalCaption.Weight = 0.3484295442434493D;
            // 
            // baseControlStyle
            // 
            this.baseControlStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.baseControlStyle.Name = "baseControlStyle";
            this.baseControlStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // evenDetailStyle
            // 
            this.evenDetailStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(233)))), ((int)(((byte)(234)))));
            this.evenDetailStyle.Name = "evenDetailStyle";
            this.evenDetailStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // oddDetailStyle
            // 
            this.oddDetailStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.oddDetailStyle.Name = "oddDetailStyle";
            this.oddDetailStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // DetailReport
            // 
            this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail1,
            this.ReportFooter});
            this.DetailReport.DataMember = "VwLote_Vencido";
            this.DetailReport.DataSource = this.sqlDataSource1;
            this.DetailReport.Level = 0;
            this.DetailReport.Name = "DetailReport";
            // 
            // Detail1
            // 
            this.Detail1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.detailTable});
            this.Detail1.HeightF = 51.70835F;
            this.Detail1.Name = "Detail1";
            // 
            // detailTable
            // 
            this.detailTable.EvenStyleName = "evenDetailStyle";
            this.detailTable.LocationFloat = new DevExpress.Utils.PointFloat(10.00018F, 0F);
            this.detailTable.Name = "detailTable";
            this.detailTable.OddStyleName = "oddDetailStyle";
            this.detailTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.detailTableRow1,
            this.detailTableRow2});
            this.detailTable.SizeF = new System.Drawing.SizeF(729.9998F, 50F);
            this.detailTable.StyleName = "evenDetailStyle";
            this.detailTable.StylePriority.UseBorderColor = false;
            this.detailTable.StylePriority.UseBorders = false;
            this.detailTable.StylePriority.UseFont = false;
            // 
            // detailTableRow1
            // 
            this.detailTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.productName,
            this.xrTableCell2,
            this.quantity,
            this.unitPrice,
            this.lineTotal});
            this.detailTableRow1.Name = "detailTableRow1";
            this.detailTableRow1.Weight = 7.4675601980203563D;
            // 
            // productName
            // 
            this.productName.BorderColor = System.Drawing.Color.White;
            this.productName.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.productName.BorderWidth = 5F;
            this.productName.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Descripcion]")});
            this.productName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.productName.Name = "productName";
            this.productName.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 0, 100F);
            this.productName.StylePriority.UseBackColor = false;
            this.productName.StylePriority.UseBorderColor = false;
            this.productName.StylePriority.UseBorders = false;
            this.productName.StylePriority.UseBorderWidth = false;
            this.productName.StylePriority.UseFont = false;
            this.productName.StylePriority.UsePadding = false;
            this.productName.StylePriority.UseTextAlignment = false;
            this.productName.Text = "Product1";
            this.productName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            this.productName.Weight = 0.83950518615807024D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.BorderColor = System.Drawing.Color.White;
            this.xrTableCell2.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.xrTableCell2.BorderWidth = 5F;
            this.xrTableCell2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Fecha de Vencimiento]")});
            this.xrTableCell2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 0, 100F);
            this.xrTableCell2.StylePriority.UseBackColor = false;
            this.xrTableCell2.StylePriority.UseBorderColor = false;
            this.xrTableCell2.StylePriority.UseBorders = false;
            this.xrTableCell2.StylePriority.UseBorderWidth = false;
            this.xrTableCell2.StylePriority.UseFont = false;
            this.xrTableCell2.StylePriority.UsePadding = false;
            this.xrTableCell2.StylePriority.UseTextAlignment = false;
            this.xrTableCell2.Text = "xrTableCell2";
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            this.xrTableCell2.TextFormatString = "{0:dd/MM/yyyy}";
            this.xrTableCell2.Weight = 0.3169426807851991D;
            // 
            // quantity
            // 
            this.quantity.BorderColor = System.Drawing.Color.White;
            this.quantity.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.quantity.BorderWidth = 5F;
            this.quantity.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Cantidad]")});
            this.quantity.Name = "quantity";
            this.quantity.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100F);
            this.quantity.RowSpan = 2;
            this.quantity.StylePriority.UseBackColor = false;
            this.quantity.StylePriority.UseBorderColor = false;
            this.quantity.StylePriority.UseBorders = false;
            this.quantity.StylePriority.UseBorderWidth = false;
            this.quantity.StylePriority.UseFont = false;
            this.quantity.StylePriority.UsePadding = false;
            this.quantity.StylePriority.UseTextAlignment = false;
            this.quantity.Text = "1";
            this.quantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.quantity.Weight = 0.24756549511058382D;
            // 
            // unitPrice
            // 
            this.unitPrice.BorderColor = System.Drawing.Color.White;
            this.unitPrice.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.unitPrice.BorderWidth = 5F;
            this.unitPrice.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CostoUnidad]")});
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.unitPrice.RowSpan = 2;
            this.unitPrice.StylePriority.UseBackColor = false;
            this.unitPrice.StylePriority.UseBorderColor = false;
            this.unitPrice.StylePriority.UseBorders = false;
            this.unitPrice.StylePriority.UseBorderWidth = false;
            this.unitPrice.StylePriority.UseFont = false;
            this.unitPrice.StylePriority.UsePadding = false;
            this.unitPrice.StylePriority.UseTextAlignment = false;
            this.unitPrice.Text = "0,00 C$";
            this.unitPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.unitPrice.TextFormatString = "{0:C$0.00}";
            this.unitPrice.Weight = 0.273961915780567D;
            // 
            // lineTotal
            // 
            this.lineTotal.BorderColor = System.Drawing.Color.White;
            this.lineTotal.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.lineTotal.BorderWidth = 5F;
            this.lineTotal.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[calculatedField2]")});
            this.lineTotal.Name = "lineTotal";
            this.lineTotal.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 5, 0, 0, 100F);
            this.lineTotal.RowSpan = 2;
            this.lineTotal.StylePriority.UseBackColor = false;
            this.lineTotal.StylePriority.UseBorderColor = false;
            this.lineTotal.StylePriority.UseBorders = false;
            this.lineTotal.StylePriority.UseBorderWidth = false;
            this.lineTotal.StylePriority.UseFont = false;
            this.lineTotal.StylePriority.UseForeColor = false;
            this.lineTotal.StylePriority.UsePadding = false;
            this.lineTotal.StylePriority.UseTextAlignment = false;
            this.lineTotal.Text = "0,00 C$";
            this.lineTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lineTotal.TextFormatString = "{0:$0.00}";
            this.lineTotal.Weight = 0.36153341912581838D;
            // 
            // detailTableRow2
            // 
            this.detailTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.productDescription,
            this.detailTableCell1,
            this.detailTableCell2,
            this.detailTableCell5});
            this.detailTableRow2.Name = "detailTableRow2";
            this.detailTableRow2.Weight = 7.4675601980203572D;
            // 
            // productDescription
            // 
            this.productDescription.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Marca]")});
            this.productDescription.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.productDescription.Name = "productDescription";
            this.productDescription.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 100F);
            this.productDescription.StylePriority.UseBackColor = false;
            this.productDescription.StylePriority.UseBorders = false;
            this.productDescription.StylePriority.UseFont = false;
            this.productDescription.StylePriority.UseForeColor = false;
            this.productDescription.StylePriority.UsePadding = false;
            this.productDescription.Text = "Product1 description";
            this.productDescription.Weight = 1.1564478627900394D;
            // 
            // detailTableCell1
            // 
            this.detailTableCell1.Name = "detailTableCell1";
            this.detailTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 5, 0, 100F);
            this.detailTableCell1.StylePriority.UsePadding = false;
            this.detailTableCell1.StylePriority.UseTextAlignment = false;
            this.detailTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.detailTableCell1.Weight = 0.24756550081967638D;
            // 
            // detailTableCell2
            // 
            this.detailTableCell2.Name = "detailTableCell2";
            this.detailTableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 5, 0, 100F);
            this.detailTableCell2.StylePriority.UsePadding = false;
            this.detailTableCell2.StylePriority.UseTextAlignment = false;
            this.detailTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.detailTableCell2.Weight = 0.27396180971915485D;
            // 
            // detailTableCell5
            // 
            this.detailTableCell5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.detailTableCell5.Name = "detailTableCell5";
            this.detailTableCell5.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 5, 0, 100F);
            this.detailTableCell5.StylePriority.UseFont = false;
            this.detailTableCell5.StylePriority.UsePadding = false;
            this.detailTableCell5.StylePriority.UseTextAlignment = false;
            this.detailTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.detailTableCell5.Weight = 0.36153360022693409D;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.totalTable});
            this.ReportFooter.HeightF = 38.16668F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "ConexionBD";
            this.sqlDataSource1.Name = "sqlDataSource1";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"223\" />";
            table1.Name = "VwLote_Vencido";
            allColumns1.Table = table1;
            selectQuery1.Columns.Add(allColumns1);
            selectQuery1.Name = "VwLote_Vencido";
            selectQuery1.Tables.Add(table1);
            table2.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"223\" />";
            table2.Name = "VwLote_PorVencer";
            allColumns2.Table = table2;
            selectQuery2.Columns.Add(allColumns2);
            selectQuery2.Name = "VwLote_PorVencer";
            selectQuery2.Tables.Add(table2);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1,
            selectQuery2});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // calculatedField1
            // 
            this.calculatedField1.DataMember = "VwLote_PorVencer";
            this.calculatedField1.DataSource = this.sqlDataSource1;
            this.calculatedField1.DisplayName = "Total";
            this.calculatedField1.Expression = "[CostoUnidad] * [Cantidad]";
            this.calculatedField1.FieldType = DevExpress.XtraReports.UI.FieldType.Float;
            this.calculatedField1.Name = "calculatedField1";
            // 
            // calculatedField2
            // 
            this.calculatedField2.DataMember = "VwLote_Vencido";
            this.calculatedField2.DataSource = this.sqlDataSource1;
            this.calculatedField2.DisplayName = "Total";
            this.calculatedField2.Expression = "[CostoUnidad]*[Cantidad]";
            this.calculatedField2.Name = "calculatedField2";
            // 
            // RptItemVencido
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GroupHeader2,
            this.GroupHeader1,
            this.DetailReport});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.calculatedField1,
            this.calculatedField2});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(50, 50, 50, 67);
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.baseControlStyle,
            this.evenDetailStyle,
            this.oddDetailStyle});
            this.Version = "20.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRLabel thankYouLabel;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader2;
        private DevExpress.XtraReports.UI.XRTable totalTable;
        private DevExpress.XtraReports.UI.XRTableRow totalRow;
        private DevExpress.XtraReports.UI.XRTableCell totalCaption;
        private DevExpress.XtraReports.UI.XRTableCell total;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRTable headerTable;
        private DevExpress.XtraReports.UI.XRTableRow headerTableRow;
        private DevExpress.XtraReports.UI.XRTableCell productDesctiptionCaption;
        private DevExpress.XtraReports.UI.XRTableCell quantityCaption;
        private DevExpress.XtraReports.UI.XRTableCell unitPriceCaption;
        private DevExpress.XtraReports.UI.XRTableCell lineTotalCaption;
        private DevExpress.XtraReports.UI.XRControlStyle baseControlStyle;
        private DevExpress.XtraReports.UI.XRControlStyle evenDetailStyle;
        private DevExpress.XtraReports.UI.XRControlStyle oddDetailStyle;
        private DevExpress.XtraReports.UI.XRTable xrTable3;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell13;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell14;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow7;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell11;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport;
        private DevExpress.XtraReports.UI.DetailBand Detail1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.CalculatedField calculatedField1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel17;
        private DevExpress.XtraReports.UI.CalculatedField calculatedField2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTable detailTable;
        private DevExpress.XtraReports.UI.XRTableRow detailTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell productName;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell quantity;
        private DevExpress.XtraReports.UI.XRTableCell unitPrice;
        private DevExpress.XtraReports.UI.XRTableCell lineTotal;
        private DevExpress.XtraReports.UI.XRTableRow detailTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell productDescription;
        private DevExpress.XtraReports.UI.XRTableCell detailTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell detailTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell detailTableCell5;
    }
}
