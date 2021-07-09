
namespace Presentación.Reports.Comprobantes
{
    partial class RptCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RptCompra));
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column7 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression7 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.MasterDetailInfo masterDetailInfo1 = new DevExpress.DataAccess.Sql.MasterDetailInfo();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.MasterDetailInfo masterDetailInfo2 = new DevExpress.DataAccess.Sql.MasterDetailInfo();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo2 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrPictureBox4 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.lbTitle = new DevExpress.XtraReports.UI.XRLabel();
            this.xrSubreport1 = new DevExpress.XtraReports.UI.XRSubreport();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lbPersonName = new DevExpress.XtraReports.UI.XRLabel();
            this.lbCustomer = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.lbOccupation1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbOccupation = new DevExpress.XtraReports.UI.XRLabel();
            this.lbCompany1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbCompany = new DevExpress.XtraReports.UI.XRLabel();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox4});
            this.BottomMargin.HeightF = 112F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // xrPictureBox4
            // 
            this.xrPictureBox4.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("xrPictureBox4.ImageSource"));
            this.xrPictureBox4.LocationFloat = new DevExpress.Utils.PointFloat(325.6667F, 10.00001F);
            this.xrPictureBox4.Name = "xrPictureBox4";
            this.xrPictureBox4.NavigateUrl = "http://www.devexpress.com/Products/NET/Reporting/";
            this.xrPictureBox4.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrPictureBox4.SizeF = new System.Drawing.SizeF(33.33333F, 33.33333F);
            this.xrPictureBox4.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize;
            this.xrPictureBox4.UseImageResolution = false;
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubreport1,
            this.xrTable1});
            this.Detail.HeightF = 93.75F;
            this.Detail.Name = "Detail";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lbTitle});
            this.ReportHeader.HeightF = 64.58334F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // lbTitle
            // 
            this.lbTitle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(142)))), ((int)(((byte)(158)))));
            this.lbTitle.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.lbTitle.BorderWidth = 2F;
            this.lbTitle.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(142)))), ((int)(((byte)(158)))));
            this.lbTitle.LocationFloat = new DevExpress.Utils.PointFloat(17F, 20F);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbTitle.SizeF = new System.Drawing.SizeF(628F, 28F);
            this.lbTitle.Text = "Lista de Proveedores y su ventas";
            this.lbTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // xrSubreport1
            // 
            this.xrSubreport1.LocationFloat = new DevExpress.Utils.PointFloat(9.536743E-05F, 70.00002F);
            this.xrSubreport1.Name = "xrSubreport1";
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("IdProveedor", null, "Proveedor.IdProveedor"));
            this.xrSubreport1.ReportSource = new Presentación.Reports.Comprobantes.RptComprasDetalle();
            this.xrSubreport1.SizeF = new System.Drawing.SizeF(644.9999F, 23F);
            // 
            // xrTable1
            // 
            this.xrTable1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(237)))));
            this.xrTable1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(214)))), ((int)(((byte)(200)))));
            this.xrTable1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Bookmark", "PersonName")});
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(6.357829E-05F, 10.00001F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(650F, 60F);
            this.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)));
            this.xrTableCell1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lbPersonName,
            this.lbCustomer});
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell1.Text = "xrTableCell1";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell1.Weight = 0.42038216560509556D;
            // 
            // lbPersonName
            // 
            this.lbPersonName.BorderColor = System.Drawing.Color.Black;
            this.lbPersonName.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lbPersonName.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Contacto]")});
            this.lbPersonName.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbPersonName.LocationFloat = new DevExpress.Utils.PointFloat(80F, 8F);
            this.lbPersonName.Name = "lbPersonName";
            this.lbPersonName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbPersonName.SizeF = new System.Drawing.SizeF(106F, 25F);
            this.lbPersonName.Text = "lbPersonName";
            this.lbPersonName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lbCustomer
            // 
            this.lbCustomer.BorderColor = System.Drawing.Color.Black;
            this.lbCustomer.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lbCustomer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(157)))), ((int)(((byte)(134)))));
            this.lbCustomer.LocationFloat = new DevExpress.Utils.PointFloat(8F, 8F);
            this.lbCustomer.Name = "lbCustomer";
            this.lbCustomer.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbCustomer.SizeF = new System.Drawing.SizeF(70F, 25F);
            this.lbCustomer.Text = "Proveedor";
            this.lbCustomer.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox1,
            this.lbOccupation1,
            this.lbOccupation,
            this.lbCompany1,
            this.lbCompany});
            this.xrTableCell2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Proveedor].[Foto]")});
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell2.Text = "xrTableCell2";
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell2.Weight = 0.61464968152866251D;
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ImageSource", "[Foto]")});
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(329.3333F, 7.999992F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(41.66669F, 39.99999F);
            // 
            // lbOccupation1
            // 
            this.lbOccupation1.BorderColor = System.Drawing.Color.Black;
            this.lbOccupation1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lbOccupation1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "iif([Estado], \'Activo\', \'Inactivo\')")});
            this.lbOccupation1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbOccupation1.LocationFloat = new DevExpress.Utils.PointFloat(104F, 28F);
            this.lbOccupation1.Name = "lbOccupation1";
            this.lbOccupation1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbOccupation1.SizeF = new System.Drawing.SizeF(150F, 20F);
            this.lbOccupation1.Text = "xrLabel4";
            this.lbOccupation1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lbOccupation
            // 
            this.lbOccupation.BorderColor = System.Drawing.Color.Black;
            this.lbOccupation.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lbOccupation.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbOccupation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(157)))), ((int)(((byte)(134)))));
            this.lbOccupation.LocationFloat = new DevExpress.Utils.PointFloat(12F, 28F);
            this.lbOccupation.Name = "lbOccupation";
            this.lbOccupation.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbOccupation.SizeF = new System.Drawing.SizeF(91F, 20F);
            this.lbOccupation.Text = "Estado:";
            this.lbOccupation.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lbCompany1
            // 
            this.lbCompany1.BorderColor = System.Drawing.Color.Black;
            this.lbCompany1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lbCompany1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Empresa]")});
            this.lbCompany1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbCompany1.LocationFloat = new DevExpress.Utils.PointFloat(104F, 8F);
            this.lbCompany1.Name = "lbCompany1";
            this.lbCompany1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbCompany1.SizeF = new System.Drawing.SizeF(150F, 17F);
            this.lbCompany1.Text = "xrLabel3";
            this.lbCompany1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lbCompany
            // 
            this.lbCompany.BorderColor = System.Drawing.Color.Black;
            this.lbCompany.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lbCompany.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(157)))), ((int)(((byte)(134)))));
            this.lbCompany.LocationFloat = new DevExpress.Utils.PointFloat(12F, 8F);
            this.lbCompany.Name = "lbCompany";
            this.lbCompany.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbCompany.SizeF = new System.Drawing.SizeF(83F, 17F);
            this.lbCompany.Text = "Compañia:";
            this.lbCompany.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "ConexionBD";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "IdProveedor";
            table1.Name = "Proveedor";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "Empresa";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "Contacto";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "Direccion";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "Estado";
            columnExpression5.Table = table1;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "Celular";
            columnExpression6.Table = table1;
            column6.Expression = columnExpression6;
            columnExpression7.ColumnName = "Foto";
            columnExpression7.Table = table1;
            column7.Expression = columnExpression7;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Columns.Add(column6);
            selectQuery1.Columns.Add(column7);
            selectQuery1.MetaSerializable = "<Meta X=\"144\" Y=\"20\" Width=\"100\" Height=\"181\" />";
            selectQuery1.Name = "Proveedor";
            selectQuery1.Tables.Add(table1);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            masterDetailInfo1.DetailQueryName = "Proveedor";
            relationColumnInfo1.NestedKeyColumn = "IdProveedor";
            relationColumnInfo1.ParentKeyColumn = "IdProveedor";
            masterDetailInfo1.KeyColumns.Add(relationColumnInfo1);
            masterDetailInfo1.MasterQueryName = "Lote";
            masterDetailInfo2.DetailQueryName = "SP_LoteBuscarProveedor";
            relationColumnInfo2.NestedKeyColumn = "IdProveedor";
            relationColumnInfo2.ParentKeyColumn = "IdProveedor";
            masterDetailInfo2.KeyColumns.Add(relationColumnInfo2);
            masterDetailInfo2.MasterQueryName = "SP_ProveedorSeleccionar";
            this.sqlDataSource1.Relations.AddRange(new DevExpress.DataAccess.Sql.MasterDetailInfo[] {
            masterDetailInfo1,
            masterDetailInfo2});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // RptCompra
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.ReportHeader});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "Proveedor";
            this.DataSource = this.sqlDataSource1;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(100, 100, 100, 112);
            this.Version = "20.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel lbTitle;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRLabel lbPersonName;
        private DevExpress.XtraReports.UI.XRLabel lbCustomer;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRLabel lbOccupation1;
        private DevExpress.XtraReports.UI.XRLabel lbOccupation;
        private DevExpress.XtraReports.UI.XRLabel lbCompany1;
        private DevExpress.XtraReports.UI.XRLabel lbCompany;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport1;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox4;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
    }
}
