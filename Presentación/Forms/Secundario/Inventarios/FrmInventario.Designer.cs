
namespace Presentación.Forms.Secundario.Inventarios
{
    partial class FrmInventario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventario));
            this.inventarioVentaDataSet = new Presentación.InventarioVentaDataSet();
            this.inventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventarioTableAdapter = new Presentación.InventarioVentaDataSetTableAdapters.InventarioTableAdapter();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForCostoUnit = new DevExpress.XtraLayout.LayoutControlItem();
            this.CostoUnitTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForNota = new DevExpress.XtraLayout.LayoutControlItem();
            this.NotaTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.ItemForIdProducto = new DevExpress.XtraLayout.LayoutControlItem();
            this.IdProductoTextEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.ItemForMotivo = new DevExpress.XtraLayout.LayoutControlItem();
            this.MotivoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForEstado = new DevExpress.XtraLayout.LayoutControlItem();
            this.EstadoTextEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForTotal = new DevExpress.XtraLayout.LayoutControlItem();
            this.TotalTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForSubTotal = new DevExpress.XtraLayout.LayoutControlItem();
            this.SubTotalTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForIdMovimiento = new DevExpress.XtraLayout.LayoutControlItem();
            this.IdMovimientoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForIdInventario = new DevExpress.XtraLayout.LayoutControlItem();
            this.IdInventarioTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.ItemForFecha = new DevExpress.XtraLayout.LayoutControlItem();
            this.FechaDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ItemForCantidad = new DevExpress.XtraLayout.LayoutControlItem();
            this.CantidadTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.plPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lytControl)).BeginInit();
            this.lytControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioVentaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCostoUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostoUnitTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotaTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdProductoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMotivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MotivoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstadoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSubTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubTotalTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdMovimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdMovimientoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdInventarioTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FechaDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FechaDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // plPrincipal
            // 
            this.plPrincipal.Size = new System.Drawing.Size(718, 340);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton;
            this.BtnCerrar.CheckedState.Parent = this.BtnCerrar;
            this.BtnCerrar.CustomImages.Parent = this.BtnCerrar;
            this.BtnCerrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnCerrar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.BtnCerrar.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.HoverState.Image")));
            this.BtnCerrar.HoverState.Parent = this.BtnCerrar;
            this.BtnCerrar.ShadowDecoration.Parent = this.BtnCerrar;
            this.BtnCerrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnCerrar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BtnCerrar.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            // 
            // BottomMenu
            // 
            this.BottomMenu.AppearanceButton.Hovered.BackColor = System.Drawing.Color.White;
            this.BottomMenu.AppearanceButton.Hovered.FontSizeDelta = -1;
            this.BottomMenu.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.White;
            this.BottomMenu.AppearanceButton.Hovered.Options.UseBackColor = true;
            this.BottomMenu.AppearanceButton.Hovered.Options.UseFont = true;
            this.BottomMenu.AppearanceButton.Hovered.Options.UseForeColor = true;
            this.BottomMenu.AppearanceButton.Normal.FontSizeDelta = -1;
            this.BottomMenu.AppearanceButton.Normal.Options.UseFont = true;
            this.BottomMenu.AppearanceButton.Pressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.BottomMenu.AppearanceButton.Pressed.FontSizeDelta = -1;
            this.BottomMenu.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.BottomMenu.AppearanceButton.Pressed.Options.UseBackColor = true;
            this.BottomMenu.AppearanceButton.Pressed.Options.UseFont = true;
            this.BottomMenu.AppearanceButton.Pressed.Options.UseForeColor = true;
            this.BottomMenu.Location = new System.Drawing.Point(0, 398);
            // 
            // lytControl
            // 
            this.lytControl.Controls.Add(this.IdInventarioTextEdit);
            this.lytControl.Controls.Add(this.IdMovimientoTextEdit);
            this.lytControl.Controls.Add(this.MotivoTextEdit);
            this.lytControl.Controls.Add(this.FechaDateEdit);
            this.lytControl.Controls.Add(this.CantidadTextEdit);
            this.lytControl.Controls.Add(this.CostoUnitTextEdit);
            this.lytControl.Controls.Add(this.SubTotalTextEdit);
            this.lytControl.Controls.Add(this.TotalTextEdit);
            this.lytControl.Controls.Add(this.NotaTextEdit);
            this.lytControl.Controls.Add(this.IdProductoTextEdit);
            this.lytControl.Controls.Add(this.EstadoTextEdit);
            this.lytControl.DataSource = this.inventarioBindingSource;
            this.lytControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(716, 37, 650, 400);
            this.lytControl.Size = new System.Drawing.Size(678, 270);
            // 
            // Root
            // 
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Size = new System.Drawing.Size(678, 270);
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.Buttons.Append.Visible = false;
            this.dataNavigator1.Buttons.CancelEdit.Visible = false;
            this.dataNavigator1.Buttons.EndEdit.Visible = false;
            this.dataNavigator1.Buttons.Remove.Enabled = false;
            this.dataNavigator1.Buttons.Remove.Visible = false;
            this.dataNavigator1.DataSource = this.inventarioBindingSource;
            this.dataNavigator1.Location = new System.Drawing.Point(20, 290);
            // 
            // inventarioVentaDataSet
            // 
            this.inventarioVentaDataSet.DataSetName = "InventarioVentaDataSet";
            this.inventarioVentaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventarioBindingSource
            // 
            this.inventarioBindingSource.DataMember = "Inventario";
            this.inventarioBindingSource.DataSource = this.inventarioVentaDataSet;
            // 
            // inventarioTableAdapter
            // 
            this.inventarioTableAdapter.ClearBeforeFill = true;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForCostoUnit,
            this.ItemForNota,
            this.ItemForIdProducto,
            this.ItemForMotivo,
            this.ItemForEstado,
            this.emptySpaceItem2,
            this.layoutControlGroup2,
            this.emptySpaceItem3,
            this.ItemForFecha,
            this.ItemForCantidad});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(658, 250);
            // 
            // ItemForCostoUnit
            // 
            this.ItemForCostoUnit.Control = this.CostoUnitTextEdit;
            this.ItemForCostoUnit.Location = new System.Drawing.Point(0, 24);
            this.ItemForCostoUnit.Name = "ItemForCostoUnit";
            this.ItemForCostoUnit.Size = new System.Drawing.Size(336, 24);
            this.ItemForCostoUnit.Text = "Costo Unit";
            this.ItemForCostoUnit.TextSize = new System.Drawing.Size(63, 13);
            // 
            // CostoUnitTextEdit
            // 
            this.CostoUnitTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.inventarioBindingSource, "CostoUnit", true));
            this.CostoUnitTextEdit.Location = new System.Drawing.Point(87, 36);
            this.CostoUnitTextEdit.Name = "CostoUnitTextEdit";
            this.CostoUnitTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.CostoUnitTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.CostoUnitTextEdit.Properties.Mask.EditMask = "F";
            this.CostoUnitTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.CostoUnitTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.CostoUnitTextEdit.Size = new System.Drawing.Size(257, 20);
            this.CostoUnitTextEdit.StyleController = this.lytControl;
            this.CostoUnitTextEdit.TabIndex = 11;
            // 
            // ItemForNota
            // 
            this.ItemForNota.Control = this.NotaTextEdit;
            this.ItemForNota.Location = new System.Drawing.Point(0, 72);
            this.ItemForNota.Name = "ItemForNota";
            this.ItemForNota.Size = new System.Drawing.Size(336, 178);
            this.ItemForNota.Text = "Nota";
            this.ItemForNota.TextSize = new System.Drawing.Size(63, 13);
            // 
            // NotaTextEdit
            // 
            this.NotaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.inventarioBindingSource, "Nota", true));
            this.NotaTextEdit.Location = new System.Drawing.Point(87, 84);
            this.NotaTextEdit.Name = "NotaTextEdit";
            this.NotaTextEdit.Size = new System.Drawing.Size(257, 174);
            this.NotaTextEdit.StyleController = this.lytControl;
            this.NotaTextEdit.TabIndex = 14;
            // 
            // ItemForIdProducto
            // 
            this.ItemForIdProducto.Control = this.IdProductoTextEdit;
            this.ItemForIdProducto.Location = new System.Drawing.Point(0, 0);
            this.ItemForIdProducto.Name = "ItemForIdProducto";
            this.ItemForIdProducto.Size = new System.Drawing.Size(336, 24);
            this.ItemForIdProducto.Text = "Producto";
            this.ItemForIdProducto.TextSize = new System.Drawing.Size(63, 13);
            // 
            // IdProductoTextEdit
            // 
            this.IdProductoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.inventarioBindingSource, "IdProducto", true));
            this.IdProductoTextEdit.Location = new System.Drawing.Point(87, 12);
            this.IdProductoTextEdit.Name = "IdProductoTextEdit";
            this.IdProductoTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.IdProductoTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.IdProductoTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.IdProductoTextEdit.Properties.DisplayMember = "Descripcion";
            this.IdProductoTextEdit.Properties.NullText = "";
            this.IdProductoTextEdit.Properties.ValueMember = "IdProducto";
            this.IdProductoTextEdit.Size = new System.Drawing.Size(257, 20);
            this.IdProductoTextEdit.StyleController = this.lytControl;
            this.IdProductoTextEdit.TabIndex = 6;
            // 
            // ItemForMotivo
            // 
            this.ItemForMotivo.Control = this.MotivoTextEdit;
            this.ItemForMotivo.Location = new System.Drawing.Point(349, 0);
            this.ItemForMotivo.Name = "ItemForMotivo";
            this.ItemForMotivo.Size = new System.Drawing.Size(309, 24);
            this.ItemForMotivo.Text = "Motivo";
            this.ItemForMotivo.TextSize = new System.Drawing.Size(63, 13);
            // 
            // MotivoTextEdit
            // 
            this.MotivoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.inventarioBindingSource, "Motivo", true));
            this.MotivoTextEdit.Location = new System.Drawing.Point(436, 12);
            this.MotivoTextEdit.Name = "MotivoTextEdit";
            this.MotivoTextEdit.Size = new System.Drawing.Size(230, 20);
            this.MotivoTextEdit.StyleController = this.lytControl;
            this.MotivoTextEdit.TabIndex = 7;
            // 
            // ItemForEstado
            // 
            this.ItemForEstado.Control = this.EstadoTextEdit;
            this.ItemForEstado.Location = new System.Drawing.Point(349, 24);
            this.ItemForEstado.Name = "ItemForEstado";
            this.ItemForEstado.Size = new System.Drawing.Size(309, 24);
            this.ItemForEstado.Text = "Estado";
            this.ItemForEstado.TextSize = new System.Drawing.Size(63, 13);
            // 
            // EstadoTextEdit
            // 
            this.EstadoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.inventarioBindingSource, "Estado", true));
            this.EstadoTextEdit.Location = new System.Drawing.Point(436, 36);
            this.EstadoTextEdit.Name = "EstadoTextEdit";
            this.EstadoTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EstadoTextEdit.Properties.Items.AddRange(new object[] {
            "Salida ",
            "Entrada",
            "Ajustes",
            "Devolucion"});
            this.EstadoTextEdit.Size = new System.Drawing.Size(230, 20);
            this.EstadoTextEdit.StyleController = this.lytControl;
            this.EstadoTextEdit.TabIndex = 9;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(336, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(13, 250);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForTotal,
            this.ItemForSubTotal,
            this.ItemForIdMovimiento,
            this.ItemForIdInventario});
            this.layoutControlGroup2.Location = new System.Drawing.Point(349, 109);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(309, 141);
            this.layoutControlGroup2.Text = "AutoGenerado";
            // 
            // ItemForTotal
            // 
            this.ItemForTotal.Control = this.TotalTextEdit;
            this.ItemForTotal.Location = new System.Drawing.Point(0, 72);
            this.ItemForTotal.Name = "ItemForTotal";
            this.ItemForTotal.Size = new System.Drawing.Size(285, 24);
            this.ItemForTotal.Text = "Total";
            this.ItemForTotal.TextSize = new System.Drawing.Size(63, 13);
            // 
            // TotalTextEdit
            // 
            this.TotalTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.inventarioBindingSource, "Total", true));
            this.TotalTextEdit.Location = new System.Drawing.Point(448, 226);
            this.TotalTextEdit.Name = "TotalTextEdit";
            this.TotalTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.TotalTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TotalTextEdit.Properties.Mask.EditMask = "F";
            this.TotalTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TotalTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.TotalTextEdit.Properties.ReadOnly = true;
            this.TotalTextEdit.Properties.UseReadOnlyAppearance = false;
            this.TotalTextEdit.Size = new System.Drawing.Size(206, 20);
            this.TotalTextEdit.StyleController = this.lytControl;
            this.TotalTextEdit.TabIndex = 13;
            // 
            // ItemForSubTotal
            // 
            this.ItemForSubTotal.Control = this.SubTotalTextEdit;
            this.ItemForSubTotal.Location = new System.Drawing.Point(0, 48);
            this.ItemForSubTotal.Name = "ItemForSubTotal";
            this.ItemForSubTotal.Size = new System.Drawing.Size(285, 24);
            this.ItemForSubTotal.Text = "Sub Total";
            this.ItemForSubTotal.TextSize = new System.Drawing.Size(63, 13);
            // 
            // SubTotalTextEdit
            // 
            this.SubTotalTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.inventarioBindingSource, "SubTotal", true));
            this.SubTotalTextEdit.Location = new System.Drawing.Point(448, 202);
            this.SubTotalTextEdit.Name = "SubTotalTextEdit";
            this.SubTotalTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.SubTotalTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.SubTotalTextEdit.Properties.Mask.EditMask = "F";
            this.SubTotalTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.SubTotalTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.SubTotalTextEdit.Properties.ReadOnly = true;
            this.SubTotalTextEdit.Properties.UseReadOnlyAppearance = false;
            this.SubTotalTextEdit.Size = new System.Drawing.Size(206, 20);
            this.SubTotalTextEdit.StyleController = this.lytControl;
            this.SubTotalTextEdit.TabIndex = 12;
            // 
            // ItemForIdMovimiento
            // 
            this.ItemForIdMovimiento.Control = this.IdMovimientoTextEdit;
            this.ItemForIdMovimiento.Location = new System.Drawing.Point(0, 24);
            this.ItemForIdMovimiento.Name = "ItemForIdMovimiento";
            this.ItemForIdMovimiento.Size = new System.Drawing.Size(285, 24);
            this.ItemForIdMovimiento.Text = "Id Sesión";
            this.ItemForIdMovimiento.TextSize = new System.Drawing.Size(63, 13);
            // 
            // IdMovimientoTextEdit
            // 
            this.IdMovimientoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.inventarioBindingSource, "IdMovimiento", true));
            this.IdMovimientoTextEdit.Location = new System.Drawing.Point(448, 178);
            this.IdMovimientoTextEdit.Name = "IdMovimientoTextEdit";
            this.IdMovimientoTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.IdMovimientoTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.IdMovimientoTextEdit.Properties.Mask.EditMask = "N0";
            this.IdMovimientoTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.IdMovimientoTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.IdMovimientoTextEdit.Properties.ReadOnly = true;
            this.IdMovimientoTextEdit.Properties.UseReadOnlyAppearance = false;
            this.IdMovimientoTextEdit.Size = new System.Drawing.Size(206, 20);
            this.IdMovimientoTextEdit.StyleController = this.lytControl;
            this.IdMovimientoTextEdit.TabIndex = 5;
            // 
            // ItemForIdInventario
            // 
            this.ItemForIdInventario.Control = this.IdInventarioTextEdit;
            this.ItemForIdInventario.Location = new System.Drawing.Point(0, 0);
            this.ItemForIdInventario.Name = "ItemForIdInventario";
            this.ItemForIdInventario.Size = new System.Drawing.Size(285, 24);
            this.ItemForIdInventario.Text = "Id Inventario";
            this.ItemForIdInventario.TextSize = new System.Drawing.Size(63, 13);
            // 
            // IdInventarioTextEdit
            // 
            this.IdInventarioTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.inventarioBindingSource, "IdInventario", true));
            this.IdInventarioTextEdit.Location = new System.Drawing.Point(448, 154);
            this.IdInventarioTextEdit.Name = "IdInventarioTextEdit";
            this.IdInventarioTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.IdInventarioTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.IdInventarioTextEdit.Properties.Mask.EditMask = "N0";
            this.IdInventarioTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.IdInventarioTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.IdInventarioTextEdit.Properties.ReadOnly = true;
            this.IdInventarioTextEdit.Properties.UseReadOnlyAppearance = false;
            this.IdInventarioTextEdit.Size = new System.Drawing.Size(206, 20);
            this.IdInventarioTextEdit.StyleController = this.lytControl;
            this.IdInventarioTextEdit.TabIndex = 4;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(349, 72);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(309, 37);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ItemForFecha
            // 
            this.ItemForFecha.Control = this.FechaDateEdit;
            this.ItemForFecha.Location = new System.Drawing.Point(349, 48);
            this.ItemForFecha.Name = "ItemForFecha";
            this.ItemForFecha.Size = new System.Drawing.Size(309, 24);
            this.ItemForFecha.Text = "Fecha";
            this.ItemForFecha.TextSize = new System.Drawing.Size(63, 13);
            // 
            // FechaDateEdit
            // 
            this.FechaDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.inventarioBindingSource, "Fecha", true));
            this.FechaDateEdit.EditValue = null;
            this.FechaDateEdit.Location = new System.Drawing.Point(436, 60);
            this.FechaDateEdit.Name = "FechaDateEdit";
            this.FechaDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FechaDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FechaDateEdit.Size = new System.Drawing.Size(230, 20);
            this.FechaDateEdit.StyleController = this.lytControl;
            this.FechaDateEdit.TabIndex = 8;
            // 
            // ItemForCantidad
            // 
            this.ItemForCantidad.Control = this.CantidadTextEdit;
            this.ItemForCantidad.Location = new System.Drawing.Point(0, 48);
            this.ItemForCantidad.Name = "ItemForCantidad";
            this.ItemForCantidad.Size = new System.Drawing.Size(336, 24);
            this.ItemForCantidad.Text = "Cantidad";
            this.ItemForCantidad.TextSize = new System.Drawing.Size(63, 13);
            // 
            // CantidadTextEdit
            // 
            this.CantidadTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.inventarioBindingSource, "Cantidad", true));
            this.CantidadTextEdit.Location = new System.Drawing.Point(87, 60);
            this.CantidadTextEdit.Name = "CantidadTextEdit";
            this.CantidadTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.CantidadTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.CantidadTextEdit.Properties.Mask.EditMask = "N0";
            this.CantidadTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.CantidadTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.CantidadTextEdit.Size = new System.Drawing.Size(257, 20);
            this.CantidadTextEdit.StyleController = this.lytControl;
            this.CantidadTextEdit.TabIndex = 10;
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 468);
            this.Name = "FrmInventario";
            this.Text = "FrmInventario";
            this.Load += new System.EventHandler(this.FrmInventario_Load);
            this.plPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lytControl)).EndInit();
            this.lytControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioVentaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCostoUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostoUnitTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotaTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdProductoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMotivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MotivoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstadoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSubTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubTotalTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdMovimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdMovimientoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdInventarioTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FechaDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FechaDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private InventarioVentaDataSet inventarioVentaDataSet;
        private System.Windows.Forms.BindingSource inventarioBindingSource;
        private InventarioVentaDataSetTableAdapters.InventarioTableAdapter inventarioTableAdapter;
        private DevExpress.XtraEditors.TextEdit IdInventarioTextEdit;
        private DevExpress.XtraEditors.TextEdit IdMovimientoTextEdit;
        private DevExpress.XtraEditors.TextEdit MotivoTextEdit;
        private DevExpress.XtraEditors.DateEdit FechaDateEdit;
        private DevExpress.XtraEditors.TextEdit CantidadTextEdit;
        private DevExpress.XtraEditors.TextEdit CostoUnitTextEdit;
        private DevExpress.XtraEditors.TextEdit SubTotalTextEdit;
        private DevExpress.XtraEditors.TextEdit TotalTextEdit;
        private DevExpress.XtraEditors.MemoEdit NotaTextEdit;
        private DevExpress.XtraEditors.LookUpEdit IdProductoTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIdInventario;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIdMovimiento;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIdProducto;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMotivo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForFecha;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEstado;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCantidad;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCostoUnit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSubTotal;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTotal;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNota;
        private DevExpress.XtraEditors.ComboBoxEdit EstadoTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
    }
}