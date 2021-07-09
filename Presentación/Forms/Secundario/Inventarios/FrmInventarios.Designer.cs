
namespace Presentación.Forms.Secundario.Inventarios
{
    partial class FrmInventarios
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
            this.BtnKardex = new Guna.UI2.WinForms.Guna2Button();
            this.BtnItemBajos = new Guna.UI2.WinForms.Guna2Button();
            this.BtnItemVence = new Guna.UI2.WinForms.Guna2Button();
            this.FlyVence = new DevExpress.Utils.FlyoutPanel();
            this.BtnToExpire = new Guna.UI2.WinForms.Guna2Button();
            this.BtnVenceAll = new Guna.UI2.WinForms.Guna2Button();
            this.colIdInventario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMovimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMotivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCostoUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BtnPrintRpt = new Guna.UI2.WinForms.Guna2Button();
            this.FlyEdition = new DevExpress.Utils.FlyoutPanel();
            this.BtnKardexDelete = new Guna.UI2.WinForms.Guna2Button();
            this.BtnKardexEdit = new Guna.UI2.WinForms.Guna2Button();
            this.BtnKardexAdd = new Guna.UI2.WinForms.Guna2Button();
            this.div2.SuspendLayout();
            this.div3.SuspendLayout();
            this.div1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackButtons)).BeginInit();
            this.stackButtons.SuspendLayout();
            this.plEspacio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.div4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FlyVence)).BeginInit();
            this.FlyVence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FlyEdition)).BeginInit();
            this.FlyEdition.SuspendLayout();
            this.SuspendLayout();
            // 
            // div2
            // 
            this.div2.Size = new System.Drawing.Size(1008, 517);
            // 
            // div3
            // 
            this.div3.Size = new System.Drawing.Size(1006, 491);
            // 
            // div1
            // 
            this.div1.Size = new System.Drawing.Size(1028, 537);
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "SP_InventarioSeleccionar";
            this.gridControl1.Size = new System.Drawing.Size(986, 76);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdInventario,
            this.colIdMovimiento,
            this.colIdProducto,
            this.colMotivo,
            this.colFecha,
            this.colEstado,
            this.colCantidad,
            this.colCostoUnit,
            this.colSubTotal,
            this.colTotal,
            this.colNota});
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // stackButtons
            // 
            this.stackButtons.Controls.Add(this.BtnKardex);
            this.stackButtons.Controls.Add(this.BtnItemBajos);
            this.stackButtons.Controls.Add(this.BtnItemVence);
            this.stackButtons.Controls.Add(this.BtnPrintRpt);
            // 
            // plEspacio
            // 
            this.plEspacio.Controls.Add(this.FlyEdition);
            this.plEspacio.Controls.Add(this.FlyVence);
            this.plEspacio.Size = new System.Drawing.Size(986, 363);
            // 
            // bar3
            // 
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            // 
            // div4
            // 
            this.div4.Location = new System.Drawing.Point(10, 410);
            this.div4.Size = new System.Drawing.Size(986, 76);
            // 
            // BtnKardex
            // 
            this.BtnKardex.Animated = true;
            this.BtnKardex.CheckedState.Parent = this.BtnKardex;
            this.BtnKardex.CustomImages.Parent = this.BtnKardex;
            this.BtnKardex.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.BtnKardex.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnKardex.ForeColor = System.Drawing.Color.White;
            this.BtnKardex.HoverState.BorderColor = System.Drawing.Color.Black;
            this.BtnKardex.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnKardex.HoverState.Parent = this.BtnKardex;
            this.BtnKardex.Image = global::Presentación.Properties.Resources.icons8_boarding_pass_32;
            this.BtnKardex.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnKardex.ImageSize = new System.Drawing.Size(18, 20);
            this.BtnKardex.Location = new System.Drawing.Point(0, 10);
            this.BtnKardex.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.BtnKardex.Name = "BtnKardex";
            this.BtnKardex.ShadowDecoration.Parent = this.BtnKardex;
            this.BtnKardex.Size = new System.Drawing.Size(115, 27);
            this.BtnKardex.TabIndex = 118;
            this.BtnKardex.Text = "Inventario";
            this.BtnKardex.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnKardex.Click += new System.EventHandler(this.BtnKardex_Click);
            // 
            // BtnItemBajos
            // 
            this.BtnItemBajos.Animated = true;
            this.BtnItemBajos.CheckedState.Parent = this.BtnItemBajos;
            this.BtnItemBajos.CustomImages.Parent = this.BtnItemBajos;
            this.BtnItemBajos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.BtnItemBajos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnItemBajos.ForeColor = System.Drawing.Color.White;
            this.BtnItemBajos.HoverState.BorderColor = System.Drawing.Color.Black;
            this.BtnItemBajos.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnItemBajos.HoverState.Parent = this.BtnItemBajos;
            this.BtnItemBajos.Image = global::Presentación.Properties.Resources.icons8_ticket_32;
            this.BtnItemBajos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnItemBajos.ImageSize = new System.Drawing.Size(18, 18);
            this.BtnItemBajos.Location = new System.Drawing.Point(120, 10);
            this.BtnItemBajos.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.BtnItemBajos.Name = "BtnItemBajos";
            this.BtnItemBajos.ShadowDecoration.Parent = this.BtnItemBajos;
            this.BtnItemBajos.Size = new System.Drawing.Size(115, 27);
            this.BtnItemBajos.TabIndex = 121;
            this.BtnItemBajos.Text = "Item Bajos";
            this.BtnItemBajos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnItemBajos.Click += new System.EventHandler(this.BtnItemBajos_Click);
            // 
            // BtnItemVence
            // 
            this.BtnItemVence.Animated = true;
            this.BtnItemVence.CheckedState.Parent = this.BtnItemVence;
            this.BtnItemVence.CustomImages.Parent = this.BtnItemVence;
            this.BtnItemVence.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnItemVence.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.BtnItemVence.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnItemVence.ForeColor = System.Drawing.Color.White;
            this.BtnItemVence.HoverState.BorderColor = System.Drawing.Color.Black;
            this.BtnItemVence.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnItemVence.HoverState.Parent = this.BtnItemVence;
            this.BtnItemVence.Image = global::Presentación.Properties.Resources.icons8_expired_32;
            this.BtnItemVence.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnItemVence.Location = new System.Drawing.Point(240, 10);
            this.BtnItemVence.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.BtnItemVence.Name = "BtnItemVence";
            this.BtnItemVence.ShadowDecoration.Parent = this.BtnItemVence;
            this.BtnItemVence.Size = new System.Drawing.Size(115, 27);
            this.BtnItemVence.TabIndex = 119;
            this.BtnItemVence.Text = "Vencimiento";
            this.BtnItemVence.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnItemVence.Click += new System.EventHandler(this.BtnItemVence_Click);
            // 
            // FlyVence
            // 
            this.FlyVence.Controls.Add(this.BtnToExpire);
            this.FlyVence.Controls.Add(this.BtnVenceAll);
            this.FlyVence.Location = new System.Drawing.Point(3, 4);
            this.FlyVence.Name = "FlyVence";
            this.FlyVence.OptionsBeakPanel.BeakLocation = DevExpress.Utils.BeakPanelBeakLocation.Left;
            this.FlyVence.OptionsButtonPanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.FlyVence.OwnerControl = this.BtnItemVence;
            this.FlyVence.Size = new System.Drawing.Size(161, 75);
            this.FlyVence.TabIndex = 123;
            // 
            // BtnToExpire
            // 
            this.BtnToExpire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnToExpire.Animated = true;
            this.BtnToExpire.BorderColor = System.Drawing.Color.Gray;
            this.BtnToExpire.BorderThickness = 1;
            this.BtnToExpire.CheckedState.Parent = this.BtnToExpire;
            this.BtnToExpire.CustomImages.Parent = this.BtnToExpire;
            this.BtnToExpire.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.BtnToExpire.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnToExpire.ForeColor = System.Drawing.Color.White;
            this.BtnToExpire.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.BtnToExpire.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnToExpire.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnToExpire.HoverState.Parent = this.BtnToExpire;
            this.BtnToExpire.Image = global::Presentación.Properties.Resources.icons8_filter_32;
            this.BtnToExpire.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnToExpire.ImageSize = new System.Drawing.Size(18, 18);
            this.BtnToExpire.Location = new System.Drawing.Point(6, 37);
            this.BtnToExpire.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.BtnToExpire.Name = "BtnToExpire";
            this.BtnToExpire.ShadowDecoration.Parent = this.BtnToExpire;
            this.BtnToExpire.Size = new System.Drawing.Size(150, 27);
            this.BtnToExpire.TabIndex = 117;
            this.BtnToExpire.Text = "Por Vencer (30 Dias)";
            this.BtnToExpire.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnToExpire.Click += new System.EventHandler(this.BtnToExpire_Click);
            // 
            // BtnVenceAll
            // 
            this.BtnVenceAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnVenceAll.Animated = true;
            this.BtnVenceAll.BorderColor = System.Drawing.Color.Gray;
            this.BtnVenceAll.BorderThickness = 1;
            this.BtnVenceAll.CheckedState.Parent = this.BtnVenceAll;
            this.BtnVenceAll.CustomImages.Parent = this.BtnVenceAll;
            this.BtnVenceAll.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.BtnVenceAll.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnVenceAll.ForeColor = System.Drawing.Color.White;
            this.BtnVenceAll.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.BtnVenceAll.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnVenceAll.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnVenceAll.HoverState.Parent = this.BtnVenceAll;
            this.BtnVenceAll.Image = global::Presentación.Properties.Resources.icons8_filter_32;
            this.BtnVenceAll.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnVenceAll.ImageSize = new System.Drawing.Size(18, 18);
            this.BtnVenceAll.Location = new System.Drawing.Point(6, 7);
            this.BtnVenceAll.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.BtnVenceAll.Name = "BtnVenceAll";
            this.BtnVenceAll.ShadowDecoration.Parent = this.BtnVenceAll;
            this.BtnVenceAll.Size = new System.Drawing.Size(150, 27);
            this.BtnVenceAll.TabIndex = 116;
            this.BtnVenceAll.Text = "Vencidos (Todos)";
            this.BtnVenceAll.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnVenceAll.Click += new System.EventHandler(this.BtnVenceAll_Click);
            // 
            // colIdInventario
            // 
            this.colIdInventario.FieldName = "IdInventario";
            this.colIdInventario.Name = "colIdInventario";
            this.colIdInventario.Visible = true;
            this.colIdInventario.VisibleIndex = 0;
            // 
            // colIdMovimiento
            // 
            this.colIdMovimiento.FieldName = "IdMovimiento";
            this.colIdMovimiento.Name = "colIdMovimiento";
            this.colIdMovimiento.Visible = true;
            this.colIdMovimiento.VisibleIndex = 1;
            // 
            // colIdProducto
            // 
            this.colIdProducto.FieldName = "IdProducto";
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.Visible = true;
            this.colIdProducto.VisibleIndex = 2;
            // 
            // colMotivo
            // 
            this.colMotivo.FieldName = "Motivo";
            this.colMotivo.Name = "colMotivo";
            this.colMotivo.Visible = true;
            this.colMotivo.VisibleIndex = 3;
            // 
            // colFecha
            // 
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 4;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 5;
            // 
            // colCantidad
            // 
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 6;
            // 
            // colCostoUnit
            // 
            this.colCostoUnit.FieldName = "CostoUnit";
            this.colCostoUnit.Name = "colCostoUnit";
            this.colCostoUnit.Visible = true;
            this.colCostoUnit.VisibleIndex = 7;
            // 
            // colSubTotal
            // 
            this.colSubTotal.FieldName = "SubTotal";
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.Visible = true;
            this.colSubTotal.VisibleIndex = 8;
            // 
            // colTotal
            // 
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 9;
            // 
            // colNota
            // 
            this.colNota.FieldName = "Nota";
            this.colNota.Name = "colNota";
            this.colNota.Visible = true;
            this.colNota.VisibleIndex = 10;
            // 
            // BtnPrintRpt
            // 
            this.BtnPrintRpt.Animated = true;
            this.BtnPrintRpt.CheckedState.Parent = this.BtnPrintRpt;
            this.BtnPrintRpt.CustomImages.Parent = this.BtnPrintRpt;
            this.BtnPrintRpt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.BtnPrintRpt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnPrintRpt.ForeColor = System.Drawing.Color.White;
            this.BtnPrintRpt.HoverState.BorderColor = System.Drawing.Color.Black;
            this.BtnPrintRpt.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnPrintRpt.HoverState.Parent = this.BtnPrintRpt;
            this.BtnPrintRpt.Image = global::Presentación.Properties.Resources.icons8_print_20;
            this.BtnPrintRpt.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnPrintRpt.Location = new System.Drawing.Point(360, 10);
            this.BtnPrintRpt.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.BtnPrintRpt.Name = "BtnPrintRpt";
            this.BtnPrintRpt.ShadowDecoration.Parent = this.BtnPrintRpt;
            this.BtnPrintRpt.Size = new System.Drawing.Size(95, 27);
            this.BtnPrintRpt.TabIndex = 124;
            this.BtnPrintRpt.Text = "Reporte";
            this.BtnPrintRpt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnPrintRpt.Click += new System.EventHandler(this.BtnPrintRpt_Click);
            // 
            // FlyEdition
            // 
            this.FlyEdition.Controls.Add(this.BtnKardexDelete);
            this.FlyEdition.Controls.Add(this.BtnKardexEdit);
            this.FlyEdition.Controls.Add(this.BtnKardexAdd);
            this.FlyEdition.Location = new System.Drawing.Point(170, 11);
            this.FlyEdition.Name = "FlyEdition";
            this.FlyEdition.OptionsBeakPanel.BeakLocation = DevExpress.Utils.BeakPanelBeakLocation.Left;
            this.FlyEdition.OptionsButtonPanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.FlyEdition.OwnerControl = this.BtnKardex;
            this.FlyEdition.ParentForm = this;
            this.FlyEdition.Size = new System.Drawing.Size(161, 102);
            this.FlyEdition.TabIndex = 124;
            // 
            // BtnKardexDelete
            // 
            this.BtnKardexDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnKardexDelete.Animated = true;
            this.BtnKardexDelete.BorderColor = System.Drawing.Color.Gray;
            this.BtnKardexDelete.BorderThickness = 1;
            this.BtnKardexDelete.CheckedState.Parent = this.BtnKardexDelete;
            this.BtnKardexDelete.CustomImages.Parent = this.BtnKardexDelete;
            this.BtnKardexDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.BtnKardexDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnKardexDelete.ForeColor = System.Drawing.Color.White;
            this.BtnKardexDelete.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.BtnKardexDelete.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnKardexDelete.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnKardexDelete.HoverState.Parent = this.BtnKardexDelete;
            this.BtnKardexDelete.Image = global::Presentación.Properties.Resources.icons8_delete_file_32__1_;
            this.BtnKardexDelete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnKardexDelete.ImageSize = new System.Drawing.Size(18, 18);
            this.BtnKardexDelete.Location = new System.Drawing.Point(6, 67);
            this.BtnKardexDelete.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.BtnKardexDelete.Name = "BtnKardexDelete";
            this.BtnKardexDelete.ShadowDecoration.Parent = this.BtnKardexDelete;
            this.BtnKardexDelete.Size = new System.Drawing.Size(150, 27);
            this.BtnKardexDelete.TabIndex = 118;
            this.BtnKardexDelete.Text = "Eliminar";
            this.BtnKardexDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnKardexDelete.Click += new System.EventHandler(this.BtnKardexDelete_Click);
            // 
            // BtnKardexEdit
            // 
            this.BtnKardexEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnKardexEdit.Animated = true;
            this.BtnKardexEdit.BorderColor = System.Drawing.Color.Gray;
            this.BtnKardexEdit.BorderThickness = 1;
            this.BtnKardexEdit.CheckedState.Parent = this.BtnKardexEdit;
            this.BtnKardexEdit.CustomImages.Parent = this.BtnKardexEdit;
            this.BtnKardexEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.BtnKardexEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnKardexEdit.ForeColor = System.Drawing.Color.White;
            this.BtnKardexEdit.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.BtnKardexEdit.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnKardexEdit.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnKardexEdit.HoverState.Parent = this.BtnKardexEdit;
            this.BtnKardexEdit.Image = global::Presentación.Properties.Resources.icons8_edit_file_32;
            this.BtnKardexEdit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnKardexEdit.ImageSize = new System.Drawing.Size(18, 18);
            this.BtnKardexEdit.Location = new System.Drawing.Point(6, 37);
            this.BtnKardexEdit.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.BtnKardexEdit.Name = "BtnKardexEdit";
            this.BtnKardexEdit.ShadowDecoration.Parent = this.BtnKardexEdit;
            this.BtnKardexEdit.Size = new System.Drawing.Size(150, 27);
            this.BtnKardexEdit.TabIndex = 117;
            this.BtnKardexEdit.Text = "Editar";
            this.BtnKardexEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnKardexEdit.Click += new System.EventHandler(this.BtnKardexEdit_Click);
            // 
            // BtnKardexAdd
            // 
            this.BtnKardexAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnKardexAdd.Animated = true;
            this.BtnKardexAdd.BorderColor = System.Drawing.Color.Gray;
            this.BtnKardexAdd.BorderThickness = 1;
            this.BtnKardexAdd.CheckedState.Parent = this.BtnKardexAdd;
            this.BtnKardexAdd.CustomImages.Parent = this.BtnKardexAdd;
            this.BtnKardexAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.BtnKardexAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnKardexAdd.ForeColor = System.Drawing.Color.White;
            this.BtnKardexAdd.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.BtnKardexAdd.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnKardexAdd.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnKardexAdd.HoverState.Parent = this.BtnKardexAdd;
            this.BtnKardexAdd.Image = global::Presentación.Properties.Resources.icons8_plus_math_30;
            this.BtnKardexAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnKardexAdd.ImageSize = new System.Drawing.Size(18, 18);
            this.BtnKardexAdd.Location = new System.Drawing.Point(6, 7);
            this.BtnKardexAdd.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.BtnKardexAdd.Name = "BtnKardexAdd";
            this.BtnKardexAdd.ShadowDecoration.Parent = this.BtnKardexAdd;
            this.BtnKardexAdd.Size = new System.Drawing.Size(150, 27);
            this.BtnKardexAdd.TabIndex = 116;
            this.BtnKardexAdd.Text = "Agregar";
            this.BtnKardexAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnKardexAdd.Click += new System.EventHandler(this.BtnKardexAdd_Click);
            // 
            // FrmInventarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 602);
            this.Name = "FrmInventarios";
            this.Text = "FrmInventarios";
            this.div2.ResumeLayout(false);
            this.div3.ResumeLayout(false);
            this.div1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackButtons)).EndInit();
            this.stackButtons.ResumeLayout(false);
            this.plEspacio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.div4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FlyVence)).EndInit();
            this.FlyVence.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FlyEdition)).EndInit();
            this.FlyEdition.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected Guna.UI2.WinForms.Guna2Button BtnKardex;
        protected Guna.UI2.WinForms.Guna2Button BtnItemBajos;
        protected Guna.UI2.WinForms.Guna2Button BtnItemVence;
        private DevExpress.Utils.FlyoutPanel FlyVence;
        protected Guna.UI2.WinForms.Guna2Button BtnToExpire;
        protected Guna.UI2.WinForms.Guna2Button BtnVenceAll;
        private DevExpress.XtraGrid.Columns.GridColumn colIdInventario;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMovimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colMotivo;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colCostoUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colSubTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colNota;
        protected Guna.UI2.WinForms.Guna2Button BtnPrintRpt;
        private DevExpress.Utils.FlyoutPanel FlyEdition;
        protected Guna.UI2.WinForms.Guna2Button BtnKardexEdit;
        protected Guna.UI2.WinForms.Guna2Button BtnKardexAdd;
        protected Guna.UI2.WinForms.Guna2Button BtnKardexDelete;
    }
}