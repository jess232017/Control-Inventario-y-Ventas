
namespace Presentación.Forms.Secundario.Contable
{
    partial class FrmContable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContable));
            this.inventarioVentaDataSet = new Presentación.InventarioVentaDataSet();
            this.contableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contableTableAdapter = new Presentación.InventarioVentaDataSetTableAdapters.ContableTableAdapter();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForFechaRegistro = new DevExpress.XtraLayout.LayoutControlItem();
            this.FechaRegistroDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ItemForMonto = new DevExpress.XtraLayout.LayoutControlItem();
            this.MontoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForMotivo = new DevExpress.XtraLayout.LayoutControlItem();
            this.MotivoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForTipo = new DevExpress.XtraLayout.LayoutControlItem();
            this.TipoTextEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ItemForNota = new DevExpress.XtraLayout.LayoutControlItem();
            this.NotaTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForIdMovimiento = new DevExpress.XtraLayout.LayoutControlItem();
            this.IdMovimientoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForIdContable = new DevExpress.XtraLayout.LayoutControlItem();
            this.IdContableTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.plPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lytControl)).BeginInit();
            this.lytControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioVentaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFechaRegistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FechaRegistroDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FechaRegistroDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMonto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MontoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMotivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MotivoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TipoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotaTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdMovimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdMovimientoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdContable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdContableTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.Size = new System.Drawing.Size(518, 58);
            // 
            // plPrincipal
            // 
            this.plPrincipal.Size = new System.Drawing.Size(518, 282);
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
            this.BottomMenu.Location = new System.Drawing.Point(0, 340);
            this.BottomMenu.Size = new System.Drawing.Size(518, 70);
            // 
            // lytControl
            // 
            this.lytControl.Controls.Add(this.IdContableTextEdit);
            this.lytControl.Controls.Add(this.IdMovimientoTextEdit);
            this.lytControl.Controls.Add(this.FechaRegistroDateEdit);
            this.lytControl.Controls.Add(this.MontoTextEdit);
            this.lytControl.Controls.Add(this.MotivoTextEdit);
            this.lytControl.Controls.Add(this.NotaTextEdit);
            this.lytControl.Controls.Add(this.TipoTextEdit);
            this.lytControl.DataSource = this.contableBindingSource;
            this.lytControl.Size = new System.Drawing.Size(478, 212);
            // 
            // Root
            // 
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Size = new System.Drawing.Size(478, 212);
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.Buttons.Append.Visible = false;
            this.dataNavigator1.Buttons.CancelEdit.Visible = false;
            this.dataNavigator1.Buttons.EndEdit.Visible = false;
            this.dataNavigator1.Buttons.Remove.Enabled = false;
            this.dataNavigator1.Buttons.Remove.Visible = false;
            this.dataNavigator1.DataSource = this.contableBindingSource;
            this.dataNavigator1.Location = new System.Drawing.Point(20, 232);
            this.dataNavigator1.Size = new System.Drawing.Size(478, 30);
            // 
            // inventarioVentaDataSet
            // 
            this.inventarioVentaDataSet.DataSetName = "InventarioVentaDataSet";
            this.inventarioVentaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contableBindingSource
            // 
            this.contableBindingSource.DataMember = "Contable";
            this.contableBindingSource.DataSource = this.inventarioVentaDataSet;
            // 
            // contableTableAdapter
            // 
            this.contableTableAdapter.ClearBeforeFill = true;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForFechaRegistro,
            this.ItemForMonto,
            this.ItemForMotivo,
            this.ItemForTipo,
            this.ItemForNota,
            this.layoutControlGroup2,
            this.emptySpaceItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(458, 192);
            // 
            // ItemForFechaRegistro
            // 
            this.ItemForFechaRegistro.Control = this.FechaRegistroDateEdit;
            this.ItemForFechaRegistro.Location = new System.Drawing.Point(0, 0);
            this.ItemForFechaRegistro.Name = "ItemForFechaRegistro";
            this.ItemForFechaRegistro.Size = new System.Drawing.Size(229, 28);
            this.ItemForFechaRegistro.Text = "Fecha Registro";
            this.ItemForFechaRegistro.TextSize = new System.Drawing.Size(72, 13);
            // 
            // FechaRegistroDateEdit
            // 
            this.FechaRegistroDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.contableBindingSource, "FechaRegistro", true));
            this.FechaRegistroDateEdit.EditValue = null;
            this.FechaRegistroDateEdit.Location = new System.Drawing.Point(96, 12);
            this.FechaRegistroDateEdit.Name = "FechaRegistroDateEdit";
            this.FechaRegistroDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FechaRegistroDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FechaRegistroDateEdit.Properties.ContextImageOptions.Image = global::Presentación.Properties.Resources.icons8_calendar_20;
            this.FechaRegistroDateEdit.Size = new System.Drawing.Size(141, 24);
            this.FechaRegistroDateEdit.StyleController = this.lytControl;
            this.FechaRegistroDateEdit.TabIndex = 6;
            // 
            // ItemForMonto
            // 
            this.ItemForMonto.Control = this.MontoTextEdit;
            this.ItemForMonto.Location = new System.Drawing.Point(239, 0);
            this.ItemForMonto.Name = "ItemForMonto";
            this.ItemForMonto.Size = new System.Drawing.Size(219, 28);
            this.ItemForMonto.Text = "Monto";
            this.ItemForMonto.TextSize = new System.Drawing.Size(72, 13);
            // 
            // MontoTextEdit
            // 
            this.MontoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.contableBindingSource, "Monto", true));
            this.MontoTextEdit.Location = new System.Drawing.Point(335, 12);
            this.MontoTextEdit.Name = "MontoTextEdit";
            this.MontoTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.MontoTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.MontoTextEdit.Properties.ContextImageOptions.Image = global::Presentación.Properties.Resources.icons8_money_20;
            this.MontoTextEdit.Properties.Mask.EditMask = "F";
            this.MontoTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.MontoTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.MontoTextEdit.Size = new System.Drawing.Size(131, 24);
            this.MontoTextEdit.StyleController = this.lytControl;
            this.MontoTextEdit.TabIndex = 7;
            // 
            // ItemForMotivo
            // 
            this.ItemForMotivo.Control = this.MotivoTextEdit;
            this.ItemForMotivo.Location = new System.Drawing.Point(0, 28);
            this.ItemForMotivo.Name = "ItemForMotivo";
            this.ItemForMotivo.Size = new System.Drawing.Size(229, 28);
            this.ItemForMotivo.Text = "Motivo";
            this.ItemForMotivo.TextSize = new System.Drawing.Size(72, 13);
            // 
            // MotivoTextEdit
            // 
            this.MotivoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.contableBindingSource, "Motivo", true));
            this.MotivoTextEdit.Location = new System.Drawing.Point(96, 40);
            this.MotivoTextEdit.Name = "MotivoTextEdit";
            this.MotivoTextEdit.Properties.ContextImageOptions.Image = global::Presentación.Properties.Resources.icons8_concept_20;
            this.MotivoTextEdit.Size = new System.Drawing.Size(141, 24);
            this.MotivoTextEdit.StyleController = this.lytControl;
            this.MotivoTextEdit.TabIndex = 8;
            // 
            // ItemForTipo
            // 
            this.ItemForTipo.Control = this.TipoTextEdit;
            this.ItemForTipo.Location = new System.Drawing.Point(239, 28);
            this.ItemForTipo.Name = "ItemForTipo";
            this.ItemForTipo.Size = new System.Drawing.Size(219, 28);
            this.ItemForTipo.Text = "Tipo";
            this.ItemForTipo.TextSize = new System.Drawing.Size(72, 13);
            // 
            // TipoTextEdit
            // 
            this.TipoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.contableBindingSource, "Tipo", true));
            this.TipoTextEdit.Location = new System.Drawing.Point(335, 40);
            this.TipoTextEdit.Name = "TipoTextEdit";
            this.TipoTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TipoTextEdit.Properties.ContextImageOptions.Image = global::Presentación.Properties.Resources.icons8_ballot_20;
            this.TipoTextEdit.Properties.Items.AddRange(new object[] {
            "Ingreso",
            "Egreso"});
            this.TipoTextEdit.Size = new System.Drawing.Size(131, 24);
            this.TipoTextEdit.StyleController = this.lytControl;
            this.TipoTextEdit.TabIndex = 9;
            // 
            // ItemForNota
            // 
            this.ItemForNota.Control = this.NotaTextEdit;
            this.ItemForNota.Location = new System.Drawing.Point(0, 56);
            this.ItemForNota.Name = "ItemForNota";
            this.ItemForNota.Size = new System.Drawing.Size(458, 67);
            this.ItemForNota.Text = "Nota";
            this.ItemForNota.TextSize = new System.Drawing.Size(72, 13);
            // 
            // NotaTextEdit
            // 
            this.NotaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.contableBindingSource, "Nota", true));
            this.NotaTextEdit.Location = new System.Drawing.Point(96, 68);
            this.NotaTextEdit.Name = "NotaTextEdit";
            this.NotaTextEdit.Size = new System.Drawing.Size(370, 63);
            this.NotaTextEdit.StyleController = this.lytControl;
            this.NotaTextEdit.TabIndex = 10;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForIdMovimiento,
            this.ItemForIdContable});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 123);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(458, 69);
            this.layoutControlGroup2.Text = "Autogenerado";
            this.layoutControlGroup2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // ItemForIdMovimiento
            // 
            this.ItemForIdMovimiento.Control = this.IdMovimientoTextEdit;
            this.ItemForIdMovimiento.Location = new System.Drawing.Point(217, 0);
            this.ItemForIdMovimiento.Name = "ItemForIdMovimiento";
            this.ItemForIdMovimiento.Size = new System.Drawing.Size(217, 24);
            this.ItemForIdMovimiento.Text = "Id Movimiento";
            this.ItemForIdMovimiento.TextSize = new System.Drawing.Size(72, 13);
            // 
            // IdMovimientoTextEdit
            // 
            this.IdMovimientoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.contableBindingSource, "IdMovimiento", true));
            this.IdMovimientoTextEdit.Location = new System.Drawing.Point(325, 168);
            this.IdMovimientoTextEdit.Name = "IdMovimientoTextEdit";
            this.IdMovimientoTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.IdMovimientoTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.IdMovimientoTextEdit.Properties.Mask.EditMask = "N0";
            this.IdMovimientoTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.IdMovimientoTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.IdMovimientoTextEdit.Properties.ReadOnly = true;
            this.IdMovimientoTextEdit.Properties.UseReadOnlyAppearance = false;
            this.IdMovimientoTextEdit.Size = new System.Drawing.Size(129, 20);
            this.IdMovimientoTextEdit.StyleController = this.lytControl;
            this.IdMovimientoTextEdit.TabIndex = 5;
            // 
            // ItemForIdContable
            // 
            this.ItemForIdContable.Control = this.IdContableTextEdit;
            this.ItemForIdContable.Location = new System.Drawing.Point(0, 0);
            this.ItemForIdContable.Name = "ItemForIdContable";
            this.ItemForIdContable.Size = new System.Drawing.Size(217, 24);
            this.ItemForIdContable.Text = "Id Contable";
            this.ItemForIdContable.TextSize = new System.Drawing.Size(72, 13);
            // 
            // IdContableTextEdit
            // 
            this.IdContableTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.contableBindingSource, "IdContable", true));
            this.IdContableTextEdit.Location = new System.Drawing.Point(108, 168);
            this.IdContableTextEdit.Name = "IdContableTextEdit";
            this.IdContableTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.IdContableTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.IdContableTextEdit.Properties.Mask.EditMask = "N0";
            this.IdContableTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.IdContableTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.IdContableTextEdit.Properties.ReadOnly = true;
            this.IdContableTextEdit.Properties.UseReadOnlyAppearance = false;
            this.IdContableTextEdit.Size = new System.Drawing.Size(129, 20);
            this.IdContableTextEdit.StyleController = this.lytControl;
            this.IdContableTextEdit.TabIndex = 4;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(229, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(10, 56);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // FrmContable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 410);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("FrmContable.IconOptions.Image")));
            this.Name = "FrmContable";
            this.Text = "FrmContable";
            this.Load += new System.EventHandler(this.FrmContable_Load);
            this.plPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lytControl)).EndInit();
            this.lytControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioVentaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFechaRegistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FechaRegistroDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FechaRegistroDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMonto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MontoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMotivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MotivoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TipoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotaTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdMovimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdMovimientoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdContable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdContableTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private InventarioVentaDataSet inventarioVentaDataSet;
        private System.Windows.Forms.BindingSource contableBindingSource;
        private InventarioVentaDataSetTableAdapters.ContableTableAdapter contableTableAdapter;
        private DevExpress.XtraEditors.TextEdit IdContableTextEdit;
        private DevExpress.XtraEditors.TextEdit IdMovimientoTextEdit;
        private DevExpress.XtraEditors.DateEdit FechaRegistroDateEdit;
        private DevExpress.XtraEditors.TextEdit MontoTextEdit;
        private DevExpress.XtraEditors.TextEdit MotivoTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIdContable;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIdMovimiento;
        private DevExpress.XtraLayout.LayoutControlItem ItemForFechaRegistro;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMonto;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMotivo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTipo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNota;
        private DevExpress.XtraEditors.MemoEdit NotaTextEdit;
        private DevExpress.XtraEditors.ComboBoxEdit TipoTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}