
namespace Presentación.Forms.Secundario.Ventas
{
    partial class FrmVentas
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentas));
            this.BtnVender = new Guna.UI2.WinForms.Guna2Button();
            this.BtnEspera = new Guna.UI2.WinForms.Guna2Button();
            this.BtnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.BtnRefrescar = new Guna.UI2.WinForms.Guna2Button();
            this.BtnImprimir = new Guna.UI2.WinForms.Guna2Button();
            this.colIdFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdForma = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaVenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPagoCon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComentario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.div2.SuspendLayout();
            this.div3.SuspendLayout();
            this.div1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackButtons)).BeginInit();
            this.stackButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.div4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.Text = "Administracion de Administrar {0}";
            // 
            // div2
            // 
            this.div2.Size = new System.Drawing.Size(1008, 517);
            // 
            // div3
            // 
            this.div3.Size = new System.Drawing.Size(1006, 491);
            // 
            // lbSubtitulo
            // 
            this.lbSubtitulo.Text = "Listado de Administrar {0}";
            // 
            // div1
            // 
            this.div1.Size = new System.Drawing.Size(1028, 537);
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "SP_FacturaSeleccionar";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.gridControl1.Size = new System.Drawing.Size(986, 380);
            this.gridControl1.Load += new System.EventHandler(this.GridControl1_Load);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdFactura,
            this.colIdEmpleado,
            this.colIdCliente,
            this.colIdForma,
            this.colFechaVenta,
            this.colTotal,
            this.colSubTotal,
            this.colPagoCon,
            this.colComentario,
            this.colEstado});
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // stackButtons
            // 
            this.stackButtons.Controls.Add(this.BtnVender);
            this.stackButtons.Controls.Add(this.BtnEspera);
            this.stackButtons.Controls.Add(this.BtnEliminar);
            this.stackButtons.Controls.Add(this.BtnRefrescar);
            this.stackButtons.Controls.Add(this.BtnImprimir);
            // 
            // bar3
            // 
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            // 
            // div4
            // 
            this.div4.Size = new System.Drawing.Size(986, 380);
            // 
            // BtnVender
            // 
            this.BtnVender.Animated = true;
            this.BtnVender.CheckedState.Parent = this.BtnVender;
            this.BtnVender.CustomImages.Parent = this.BtnVender;
            this.BtnVender.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.BtnVender.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnVender.ForeColor = System.Drawing.Color.White;
            this.BtnVender.HoverState.BorderColor = System.Drawing.Color.Black;
            this.BtnVender.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnVender.HoverState.Parent = this.BtnVender;
            this.BtnVender.Image = global::Presentación.Properties.Resources.icons8_create_order_32;
            this.BtnVender.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnVender.ImageSize = new System.Drawing.Size(18, 18);
            this.BtnVender.Location = new System.Drawing.Point(0, 10);
            this.BtnVender.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.BtnVender.Name = "BtnVender";
            this.BtnVender.ShadowDecoration.Parent = this.BtnVender;
            this.BtnVender.Size = new System.Drawing.Size(111, 27);
            this.BtnVender.TabIndex = 112;
            this.BtnVender.Text = "Tomar Venta";
            this.BtnVender.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnVender.Click += new System.EventHandler(this.BtnVender_Click);
            // 
            // BtnEspera
            // 
            this.BtnEspera.Animated = true;
            this.BtnEspera.CheckedState.Parent = this.BtnEspera;
            this.BtnEspera.CustomImages.Parent = this.BtnEspera;
            this.BtnEspera.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.BtnEspera.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnEspera.ForeColor = System.Drawing.Color.White;
            this.BtnEspera.HoverState.BorderColor = System.Drawing.Color.Black;
            this.BtnEspera.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnEspera.HoverState.Parent = this.BtnEspera;
            this.BtnEspera.Image = global::Presentación.Properties.Resources.icons8_reservation_32;
            this.BtnEspera.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnEspera.ImageSize = new System.Drawing.Size(18, 18);
            this.BtnEspera.Location = new System.Drawing.Point(116, 10);
            this.BtnEspera.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.BtnEspera.Name = "BtnEspera";
            this.BtnEspera.ShadowDecoration.Parent = this.BtnEspera;
            this.BtnEspera.Size = new System.Drawing.Size(99, 27);
            this.BtnEspera.TabIndex = 114;
            this.BtnEspera.Text = "En Espera";
            this.BtnEspera.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Animated = true;
            this.BtnEliminar.CheckedState.Parent = this.BtnEliminar;
            this.BtnEliminar.CustomImages.Parent = this.BtnEliminar;
            this.BtnEliminar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.BtnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.HoverState.BorderColor = System.Drawing.Color.Black;
            this.BtnEliminar.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.HoverState.Parent = this.BtnEliminar;
            this.BtnEliminar.Image = global::Presentación.Properties.Resources.icons8_delete_file_32__1_;
            this.BtnEliminar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnEliminar.ImageSize = new System.Drawing.Size(18, 18);
            this.BtnEliminar.Location = new System.Drawing.Point(220, 10);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.ShadowDecoration.Parent = this.BtnEliminar;
            this.BtnEliminar.Size = new System.Drawing.Size(90, 27);
            this.BtnEliminar.TabIndex = 115;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BtnRefrescar
            // 
            this.BtnRefrescar.Animated = true;
            this.BtnRefrescar.CheckedState.Parent = this.BtnRefrescar;
            this.BtnRefrescar.CustomImages.Parent = this.BtnRefrescar;
            this.BtnRefrescar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.BtnRefrescar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnRefrescar.ForeColor = System.Drawing.Color.White;
            this.BtnRefrescar.HoverState.BorderColor = System.Drawing.Color.Black;
            this.BtnRefrescar.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnRefrescar.HoverState.Parent = this.BtnRefrescar;
            this.BtnRefrescar.Image = global::Presentación.Properties.Resources.icons8_refresh_32;
            this.BtnRefrescar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnRefrescar.ImageSize = new System.Drawing.Size(18, 18);
            this.BtnRefrescar.Location = new System.Drawing.Point(315, 10);
            this.BtnRefrescar.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.BtnRefrescar.Name = "BtnRefrescar";
            this.BtnRefrescar.ShadowDecoration.Parent = this.BtnRefrescar;
            this.BtnRefrescar.Size = new System.Drawing.Size(90, 27);
            this.BtnRefrescar.TabIndex = 116;
            this.BtnRefrescar.Text = "Refrescar";
            this.BtnRefrescar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Animated = true;
            this.BtnImprimir.CheckedState.Parent = this.BtnImprimir;
            this.BtnImprimir.CustomImages.Parent = this.BtnImprimir;
            this.BtnImprimir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.BtnImprimir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnImprimir.ForeColor = System.Drawing.Color.White;
            this.BtnImprimir.HoverState.BorderColor = System.Drawing.Color.Black;
            this.BtnImprimir.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnImprimir.HoverState.Parent = this.BtnImprimir;
            this.BtnImprimir.Image = global::Presentación.Properties.Resources.icons8_print_20;
            this.BtnImprimir.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnImprimir.Location = new System.Drawing.Point(410, 10);
            this.BtnImprimir.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.ShadowDecoration.Parent = this.BtnImprimir;
            this.BtnImprimir.Size = new System.Drawing.Size(39, 27);
            this.BtnImprimir.TabIndex = 113;
            this.BtnImprimir.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // colIdFactura
            // 
            this.colIdFactura.FieldName = "IdFactura";
            this.colIdFactura.Name = "colIdFactura";
            this.colIdFactura.Visible = true;
            this.colIdFactura.VisibleIndex = 0;
            // 
            // colIdEmpleado
            // 
            this.colIdEmpleado.FieldName = "IdEmpleado";
            this.colIdEmpleado.Name = "colIdEmpleado";
            this.colIdEmpleado.Visible = true;
            this.colIdEmpleado.VisibleIndex = 1;
            // 
            // colIdCliente
            // 
            this.colIdCliente.FieldName = "IdCliente";
            this.colIdCliente.Name = "colIdCliente";
            this.colIdCliente.Visible = true;
            this.colIdCliente.VisibleIndex = 2;
            // 
            // colIdForma
            // 
            this.colIdForma.FieldName = "IdForma";
            this.colIdForma.Name = "colIdForma";
            this.colIdForma.Visible = true;
            this.colIdForma.VisibleIndex = 3;
            // 
            // colFechaVenta
            // 
            this.colFechaVenta.FieldName = "FechaVenta";
            this.colFechaVenta.Name = "colFechaVenta";
            this.colFechaVenta.Visible = true;
            this.colFechaVenta.VisibleIndex = 4;
            // 
            // colTotal
            // 
            this.colTotal.DisplayFormat.FormatString = "{0:#.00}";
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 5;
            // 
            // colSubTotal
            // 
            this.colSubTotal.DisplayFormat.FormatString = "{0:#.00}";
            this.colSubTotal.FieldName = "SubTotal";
            this.colSubTotal.GroupFormat.FormatString = "{0:#.00}";
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.Visible = true;
            this.colSubTotal.VisibleIndex = 6;
            // 
            // colPagoCon
            // 
            this.colPagoCon.DisplayFormat.FormatString = "{0:#.00}";
            this.colPagoCon.FieldName = "PagoCon";
            this.colPagoCon.Name = "colPagoCon";
            this.colPagoCon.Visible = true;
            this.colPagoCon.VisibleIndex = 7;
            // 
            // colComentario
            // 
            this.colComentario.FieldName = "Comentario";
            this.colComentario.Name = "colComentario";
            this.colComentario.Visible = true;
            this.colComentario.VisibleIndex = 8;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 9;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn2.ImageOptions.Image")));
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 10;
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 602);
            this.Name = "FrmVentas";
            this.Text = "FrmVentas";
            this.div2.ResumeLayout(false);
            this.div3.ResumeLayout(false);
            this.div1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackButtons)).EndInit();
            this.stackButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.div4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected Guna.UI2.WinForms.Guna2Button BtnVender;
        protected Guna.UI2.WinForms.Guna2Button BtnEspera;
        protected Guna.UI2.WinForms.Guna2Button BtnEliminar;
        protected Guna.UI2.WinForms.Guna2Button BtnRefrescar;
        protected Guna.UI2.WinForms.Guna2Button BtnImprimir;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colIdForma;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaVenta;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colSubTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colPagoCon;
        private DevExpress.XtraGrid.Columns.GridColumn colComentario;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}