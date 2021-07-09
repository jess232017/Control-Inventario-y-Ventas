
namespace Presentación.Reports.Comprobantes
{
    partial class RptComprasDetalle
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
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RptComprasDetalle));
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings1 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.headerTable = new DevExpress.XtraReports.UI.XRTable();
            this.headerTableRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.quantityCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.productNameCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.unitPriceCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.lineTotalCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.summariesTable = new DevExpress.XtraReports.UI.XRTable();
            this.totalRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.totalCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.total = new DevExpress.XtraReports.UI.XRTableCell();
            this.baseControlStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.IdProveedor = new DevExpress.XtraReports.Parameters.Parameter();
            this.detailTable = new DevExpress.XtraReports.UI.XRTable();
            this.detailTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.quantity = new DevExpress.XtraReports.UI.XRTableCell();
            this.productName = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.unitPrice = new DevExpress.XtraReports.UI.XRTableCell();
            this.lineTotal = new DevExpress.XtraReports.UI.XRTableCell();
            this.detailTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.detailTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.productDescription = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.detailTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.detailTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.ReportFooter1 = new DevExpress.XtraReports.UI.ReportFooterBand();
            ((System.ComponentModel.ISupportInitialize)(this.headerTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.summariesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "ConexionBD";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "SP_LoteBuscarProveedor";
            queryParameter1.Name = "@IdProveedor";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("?IdProveedor", typeof(int));
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.StoredProcName = "SP_LoteBuscarProveedor";
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = "select \"Proveedor\".\"IdProveedor\", \"Proveedor\".\"Contacto\" + \' [\'+\r\n       \"Proveed" +
    "or\".\"Empresa\" + \']\' Contacto\r\n  from \"dbo\".\"Proveedor\" \"Proveedor\"";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1,
            customSqlQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.detailTable});
            this.Detail.HeightF = 46.20832F;
            this.Detail.KeepTogether = true;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.StyleName = "baseControlStyle";
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLine2
            // 
            this.xrLine2.ForeColor = System.Drawing.Color.Gray;
            this.xrLine2.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(20.00113F, 25F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(607.1247F, 10F);
            this.xrLine2.StylePriority.UseForeColor = false;
            // 
            // headerTable
            // 
            this.headerTable.LocationFloat = new DevExpress.Utils.PointFloat(20.00144F, 0F);
            this.headerTable.Name = "headerTable";
            this.headerTable.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 5, 0, 100F);
            this.headerTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.headerTableRow});
            this.headerTable.SizeF = new System.Drawing.SizeF(607.1245F, 25F);
            this.headerTable.StylePriority.UsePadding = false;
            // 
            // headerTableRow
            // 
            this.headerTableRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.quantityCaption,
            this.productNameCaption,
            this.xrTableCell1,
            this.unitPriceCaption,
            this.lineTotalCaption});
            this.headerTableRow.Name = "headerTableRow";
            this.headerTableRow.Weight = 11.5D;
            // 
            // quantityCaption
            // 
            this.quantityCaption.Name = "quantityCaption";
            this.quantityCaption.StylePriority.UseTextAlignment = false;
            this.quantityCaption.Text = "Cantidad";
            this.quantityCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.quantityCaption.Weight = 0.33673102836656521D;
            // 
            // productNameCaption
            // 
            this.productNameCaption.Name = "productNameCaption";
            this.productNameCaption.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 5, 0, 100F);
            this.productNameCaption.StylePriority.UsePadding = false;
            this.productNameCaption.Text = "Descripcion";
            this.productNameCaption.Weight = 1.1013065348977087D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 5, 0, 100F);
            this.xrTableCell1.StylePriority.UsePadding = false;
            this.xrTableCell1.Text = "Registrado/Vence";
            this.xrTableCell1.Weight = 0.60623255281084065D;
            // 
            // unitPriceCaption
            // 
            this.unitPriceCaption.Name = "unitPriceCaption";
            this.unitPriceCaption.StylePriority.UseTextAlignment = false;
            this.unitPriceCaption.Text = "Precio";
            this.unitPriceCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.unitPriceCaption.Weight = 0.4557100264985442D;
            // 
            // lineTotalCaption
            // 
            this.lineTotalCaption.Name = "lineTotalCaption";
            this.lineTotalCaption.StylePriority.UseTextAlignment = false;
            this.lineTotalCaption.Text = "Total";
            this.lineTotalCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.lineTotalCaption.Weight = 0.60418975673756425D;
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.StylePriority.UseBackColor = false;
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 76F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // summariesTable
            // 
            this.summariesTable.ForeColor = System.Drawing.Color.Black;
            this.summariesTable.LocationFloat = new DevExpress.Utils.PointFloat(333.9611F, 0F);
            this.summariesTable.Name = "summariesTable";
            this.summariesTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.totalRow});
            this.summariesTable.SizeF = new System.Drawing.SizeF(293.1647F, 33F);
            this.summariesTable.StylePriority.UseForeColor = false;
            // 
            // totalRow
            // 
            this.totalRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.totalCaption,
            this.total});
            this.totalRow.Name = "totalRow";
            this.totalRow.Weight = 1.3199999999999998D;
            // 
            // totalCaption
            // 
            this.totalCaption.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.totalCaption.Name = "totalCaption";
            this.totalCaption.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 5, 100F);
            this.totalCaption.StylePriority.UseFont = false;
            this.totalCaption.StylePriority.UsePadding = false;
            this.totalCaption.StylePriority.UseTextAlignment = false;
            this.totalCaption.Text = "TOTAL";
            this.totalCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.totalCaption.Weight = 1.285340326007431D;
            // 
            // total
            // 
            this.total.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Sum([CostoUnidad] *[Cantidad])")});
            this.total.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.total.Name = "total";
            this.total.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 5, 100F);
            this.total.StylePriority.UseFont = false;
            this.total.StylePriority.UsePadding = false;
            this.total.StylePriority.UseTextAlignment = false;
            this.total.Text = "0,00 C$";
            this.total.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.total.TextFormatString = "{0:C$0.00}";
            this.total.Weight = 0.86792584643922543D;
            // 
            // baseControlStyle
            // 
            this.baseControlStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.baseControlStyle.Name = "baseControlStyle";
            this.baseControlStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // IdProveedor
            // 
            this.IdProveedor.Description = "Id del Proveedor";
            this.IdProveedor.Name = "IdProveedor";
            this.IdProveedor.Type = typeof(int);
            this.IdProveedor.ValueInfo = "0";
            dynamicListLookUpSettings1.DataMember = "Query";
            dynamicListLookUpSettings1.DataSource = this.sqlDataSource1;
            dynamicListLookUpSettings1.DisplayMember = "Contacto";
            dynamicListLookUpSettings1.FilterString = null;
            dynamicListLookUpSettings1.SortMember = null;
            dynamicListLookUpSettings1.ValueMember = "IdProveedor";
            this.IdProveedor.ValueSourceSettings = dynamicListLookUpSettings1;
            // 
            // detailTable
            // 
            this.detailTable.LocationFloat = new DevExpress.Utils.PointFloat(20.00144F, 0F);
            this.detailTable.Name = "detailTable";
            this.detailTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.detailTableRow1,
            this.detailTableRow2});
            this.detailTable.SizeF = new System.Drawing.SizeF(607.1247F, 46F);
            this.detailTable.StylePriority.UseFont = false;
            // 
            // detailTableRow1
            // 
            this.detailTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.quantity,
            this.productName,
            this.xrTableCell2,
            this.unitPrice,
            this.lineTotal});
            this.detailTableRow1.Name = "detailTableRow1";
            this.detailTableRow1.Weight = 10.58D;
            // 
            // quantity
            // 
            this.quantity.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Cantidad]")});
            this.quantity.Name = "quantity";
            this.quantity.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 5, 0, 100F);
            this.quantity.RowSpan = 2;
            this.quantity.StylePriority.UsePadding = false;
            this.quantity.StylePriority.UseTextAlignment = false;
            this.quantity.Text = "1";
            this.quantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.quantity.Weight = 0.37746485222820259D;
            // 
            // productName
            // 
            this.productName.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Descripcion]")});
            this.productName.Name = "productName";
            this.productName.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 5, 0, 100F);
            this.productName.StylePriority.UsePadding = false;
            this.productName.Text = "ProductName";
            this.productName.Weight = 1.2345255415100664D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[FechaRegistro]")});
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 5, 0, 100F);
            this.xrTableCell2.StylePriority.UsePadding = false;
            this.xrTableCell2.Text = "xrTableCell2";
            this.xrTableCell2.TextFormatString = "{0:dd/MM/yyyy}";
            this.xrTableCell2.Weight = 0.67956479734283681D;
            this.xrTableCell2.WordWrap = false;
            // 
            // unitPrice
            // 
            this.unitPrice.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CostoUnidad]")});
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 5, 0, 100F);
            this.unitPrice.RowSpan = 2;
            this.unitPrice.StylePriority.UsePadding = false;
            this.unitPrice.StylePriority.UseTextAlignment = false;
            this.unitPrice.Text = "0,00 C$";
            this.unitPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.unitPrice.TextFormatString = "{0:C$0.00}";
            this.unitPrice.Weight = 0.51084868701634978D;
            // 
            // lineTotal
            // 
            this.lineTotal.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CostoUnidad] * [Cantidad]")});
            this.lineTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lineTotal.Name = "lineTotal";
            this.lineTotal.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 5, 0, 100F);
            this.lineTotal.RowSpan = 2;
            this.lineTotal.StylePriority.UseFont = false;
            this.lineTotal.StylePriority.UseForeColor = false;
            this.lineTotal.StylePriority.UsePadding = false;
            this.lineTotal.StylePriority.UseTextAlignment = false;
            this.lineTotal.Text = "0,00 C$";
            this.lineTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.lineTotal.TextFormatString = "{0:C$0.00}";
            this.lineTotal.Weight = 0.67726098379848D;
            // 
            // detailTableRow2
            // 
            this.detailTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.detailTableCell1,
            this.productDescription,
            this.xrTableCell3,
            this.detailTableCell2,
            this.detailTableCell5});
            this.detailTableRow2.Name = "detailTableRow2";
            this.detailTableRow2.Weight = 10.58D;
            // 
            // detailTableCell1
            // 
            this.detailTableCell1.Name = "detailTableCell1";
            this.detailTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 5, 0, 100F);
            this.detailTableCell1.StylePriority.UsePadding = false;
            this.detailTableCell1.StylePriority.UseTextAlignment = false;
            this.detailTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.detailTableCell1.Weight = 0.54910187890336415D;
            // 
            // productDescription
            // 
            this.productDescription.CanShrink = true;
            this.productDescription.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Marca]")});
            this.productDescription.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.productDescription.ForeColor = System.Drawing.Color.Gray;
            this.productDescription.Name = "productDescription";
            this.productDescription.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 5, 100F);
            this.productDescription.StylePriority.UseFont = false;
            this.productDescription.StylePriority.UseForeColor = false;
            this.productDescription.StylePriority.UsePadding = false;
            this.productDescription.Text = "ProductDescription";
            this.productDescription.Weight = 1.7958765321300148D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[FechaVence]")});
            this.xrTableCell3.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.xrTableCell3.ForeColor = System.Drawing.Color.Gray;
            this.xrTableCell3.Multiline = true;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 5, 100F);
            this.xrTableCell3.StylePriority.UseFont = false;
            this.xrTableCell3.StylePriority.UseForeColor = false;
            this.xrTableCell3.StylePriority.UsePadding = false;
            this.xrTableCell3.Text = "xrTableCell3";
            this.xrTableCell3.TextFormatString = "{0:dd/MM/yyyy}";
            this.xrTableCell3.Weight = 0.988570712882764D;
            // 
            // detailTableCell2
            // 
            this.detailTableCell2.Name = "detailTableCell2";
            this.detailTableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 5, 0, 100F);
            this.detailTableCell2.StylePriority.UsePadding = false;
            this.detailTableCell2.Weight = 0.7431353468089501D;
            // 
            // detailTableCell5
            // 
            this.detailTableCell5.Name = "detailTableCell5";
            this.detailTableCell5.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 5, 0, 100F);
            this.detailTableCell5.StylePriority.UseFont = false;
            this.detailTableCell5.StylePriority.UsePadding = false;
            this.detailTableCell5.StylePriority.UseTextAlignment = false;
            this.detailTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.detailTableCell5.Weight = 0.98521852759305073D;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine2,
            this.headerTable});
            this.ReportHeader.HeightF = 35F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // ReportFooter1
            // 
            this.ReportFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.summariesTable});
            this.ReportFooter1.HeightF = 33F;
            this.ReportFooter1.Name = "ReportFooter1";
            // 
            // RptComprasDetalle
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.ReportFooter1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "SP_LoteBuscarProveedor";
            this.DataSource = this.sqlDataSource1;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(101, 100, 100, 76);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.IdProveedor});
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.baseControlStyle});
            this.Version = "20.1";
            ((System.ComponentModel.ISupportInitialize)(this.headerTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.summariesTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRTable summariesTable;
        private DevExpress.XtraReports.UI.XRTableRow totalRow;
        private DevExpress.XtraReports.UI.XRTableCell totalCaption;
        private DevExpress.XtraReports.UI.XRTableCell total;
        private DevExpress.XtraReports.UI.XRLine xrLine2;
        private DevExpress.XtraReports.UI.XRTable headerTable;
        private DevExpress.XtraReports.UI.XRTableRow headerTableRow;
        private DevExpress.XtraReports.UI.XRTableCell quantityCaption;
        private DevExpress.XtraReports.UI.XRTableCell productNameCaption;
        private DevExpress.XtraReports.UI.XRTableCell unitPriceCaption;
        private DevExpress.XtraReports.UI.XRTableCell lineTotalCaption;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.XRControlStyle baseControlStyle;
        private DevExpress.XtraReports.Parameters.Parameter IdProveedor;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTable detailTable;
        private DevExpress.XtraReports.UI.XRTableRow detailTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell quantity;
        private DevExpress.XtraReports.UI.XRTableCell productName;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell unitPrice;
        private DevExpress.XtraReports.UI.XRTableCell lineTotal;
        private DevExpress.XtraReports.UI.XRTableRow detailTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell detailTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell productDescription;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTableCell detailTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell detailTableCell5;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter1;
    }
}
