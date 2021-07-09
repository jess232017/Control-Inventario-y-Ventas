
namespace Presentación.Reports
{
    partial class RptTopEmpleados
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
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RptTopEmpleados));
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.xrChart1 = new DevExpress.XtraReports.UI.XRChart();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.table1 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.table3 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            ((System.ComponentModel.ISupportInitialize)(this.xrChart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1});
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel2});
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table3});
            this.Detail.HeightF = 32.70836F;
            this.Detail.Name = "Detail";
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(176.0417F, 28.08332F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(313.5416F, 33.41667F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseForeColor = false;
            this.xrLabel1.Text = "Mejores Empleados según ventas";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "ConexionBD";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "Nombres";
            table2.Name = "VwEmpleado_MejorVendedor";
            columnExpression1.Table = table2;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "Apellidos";
            columnExpression2.Table = table2;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "Cantidad";
            columnExpression3.Table = table2;
            column3.Expression = columnExpression3;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Name = "VwEmpleado_MejorVendedor";
            selectQuery1.Tables.Add(table2);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // xrChart1
            // 
            this.xrChart1.BorderColor = System.Drawing.Color.Black;
            this.xrChart1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrChart1.DataSource = this.sqlDataSource1;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.DefaultPane.EnableAxisXScrolling = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram1.DefaultPane.EnableAxisXZooming = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram1.DefaultPane.EnableAxisYScrolling = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram1.DefaultPane.EnableAxisYZooming = DevExpress.Utils.DefaultBoolean.False;
            this.xrChart1.Diagram = xyDiagram1;
            this.xrChart1.Legend.Name = "Default Legend";
            this.xrChart1.LocationFloat = new DevExpress.Utils.PointFloat(56.25F, 10.00001F);
            this.xrChart1.Name = "xrChart1";
            series1.ArgumentDataMember = "VwEmpleado_MejorVendedor.Nombres";
            series1.Name = "Ventas";
            series1.ValueDataMembersSerializable = "VwEmpleado_MejorVendedor.Cantidad";
            this.xrChart1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.xrChart1.SizeF = new System.Drawing.SizeF(545.8333F, 200F);
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrChart1});
            this.ReportHeader.HeightF = 210F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table1});
            this.PageHeader.HeightF = 83.54166F;
            this.PageHeader.Name = "PageHeader";
            // 
            // table1
            // 
            this.table1.BorderColor = System.Drawing.Color.DarkGray;
            this.table1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Bookmark", "FirstLetter")});
            this.table1.LocationFloat = new DevExpress.Utils.PointFloat(10.0001F, 53.54166F);
            this.table1.Name = "table1";
            this.table1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow1});
            this.table1.SizeF = new System.Drawing.SizeF(629.9999F, 30F);
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
            this.tableCell5});
            this.tableRow1.Name = "tableRow1";
            this.tableRow1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow1.Weight = 0.9538342864480398D;
            // 
            // tableCell2
            // 
            this.tableCell2.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.tableCell2.Name = "tableCell2";
            this.tableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.tableCell2.StylePriority.UseBorders = false;
            this.tableCell2.StylePriority.UseTextAlignment = false;
            this.tableCell2.Text = "Nombres";
            this.tableCell2.Weight = 0.39302432929510323D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableCell4.Multiline = true;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.xrTableCell4.StylePriority.UseBorders = false;
            this.xrTableCell4.StylePriority.UseTextAlignment = false;
            this.xrTableCell4.Text = "Apellidos";
            this.xrTableCell4.Weight = 0.39302439263225547D;
            // 
            // tableCell5
            // 
            this.tableCell5.BorderColor = System.Drawing.Color.DarkGray;
            this.tableCell5.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.tableCell5.Name = "tableCell5";
            this.tableCell5.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 8, 0, 0, 100F);
            this.tableCell5.StylePriority.UseBorderColor = false;
            this.tableCell5.StylePriority.UseBorders = false;
            this.tableCell5.StylePriority.UsePadding = false;
            this.tableCell5.StylePriority.UseTextAlignment = false;
            this.tableCell5.Text = "Ventas Realizadas";
            this.tableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell5.Weight = 0.374601512374691D;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Arial", 9F);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(223.3334F, 33.22493F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(201.1695F, 23F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "Impreso por:  Sistema";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // table3
            // 
            this.table3.LocationFloat = new DevExpress.Utils.PointFloat(10.00013F, 0F);
            this.table3.Name = "table3";
            this.table3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow3});
            this.table3.SizeF = new System.Drawing.SizeF(629.9999F, 32F);
            this.table3.StylePriority.UseBorderColor = false;
            this.table3.StylePriority.UseBorders = false;
            this.table3.StylePriority.UseFont = false;
            this.table3.StylePriority.UseForeColor = false;
            // 
            // tableRow3
            // 
            this.tableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell10,
            this.tableCell11,
            this.tableCell12});
            this.tableRow3.Name = "tableRow3";
            this.tableRow3.Weight = 2.7878787878787881D;
            // 
            // tableCell10
            // 
            this.tableCell10.BorderColor = System.Drawing.Color.DimGray;
            this.tableCell10.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.tableCell10.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Nombres]")});
            this.tableCell10.Multiline = true;
            this.tableCell10.Name = "tableCell10";
            this.tableCell10.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 0, 100F);
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
            this.tableCell10.Weight = 156.37868977295025D;
            // 
            // tableCell11
            // 
            this.tableCell11.BorderColor = System.Drawing.Color.DimGray;
            this.tableCell11.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.tableCell11.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Apellidos]")});
            this.tableCell11.KeepTogether = true;
            this.tableCell11.Multiline = true;
            this.tableCell11.Name = "tableCell11";
            this.tableCell11.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 0, 100F);
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
            this.tableCell11.Weight = 156.37876032886433D;
            // 
            // tableCell12
            // 
            this.tableCell12.BorderColor = System.Drawing.Color.DimGray;
            this.tableCell12.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.tableCell12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Cantidad]")});
            this.tableCell12.KeepTogether = true;
            this.tableCell12.Multiline = true;
            this.tableCell12.Name = "tableCell12";
            this.tableCell12.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 8, 0, 0, 100F);
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
            this.tableCell12.Weight = 149.04848676171139D;
            // 
            // RptTopEmpleados
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.ReportHeader,
            this.PageHeader});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "VwEmpleado_MejorVendedor";
            this.DataSource = this.sqlDataSource1;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Version = "20.1";
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrChart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRChart xrChart1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRTable table1;
        private DevExpress.XtraReports.UI.XRTableRow tableRow1;
        private DevExpress.XtraReports.UI.XRTableCell tableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell tableCell5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRTable table3;
        private DevExpress.XtraReports.UI.XRTableRow tableRow3;
        private DevExpress.XtraReports.UI.XRTableCell tableCell10;
        private DevExpress.XtraReports.UI.XRTableCell tableCell11;
        private DevExpress.XtraReports.UI.XRTableCell tableCell12;
    }
}
