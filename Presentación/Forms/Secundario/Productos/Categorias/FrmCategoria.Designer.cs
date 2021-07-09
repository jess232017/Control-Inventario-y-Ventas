
namespace Presentación.Forms.Secundario.Productos.Categorias
{
    partial class FrmCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategoria));
            this.inventarioVentaDataSet = new Presentación.InventarioVentaDataSet();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaTableAdapter = new Presentación.InventarioVentaDataSetTableAdapters.CategoriaTableAdapter();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.IdCategoriaTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForIdCategoria = new DevExpress.XtraLayout.LayoutControlItem();
            this.NombreTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForNombre = new DevExpress.XtraLayout.LayoutControlItem();
            this.PorDefectoCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.ItemForPorDefecto = new DevExpress.XtraLayout.LayoutControlItem();
            this.DescripcionMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.ItemForDescripcion = new DevExpress.XtraLayout.LayoutControlItem();
            this.plPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lytControl)).BeginInit();
            this.lytControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioVentaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdCategoriaTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NombreTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PorDefectoCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPorDefecto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescripcionMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDescripcion)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.Size = new System.Drawing.Size(478, 58);
            // 
            // plPrincipal
            // 
            this.plPrincipal.Size = new System.Drawing.Size(478, 320);
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
            this.BottomMenu.Location = new System.Drawing.Point(0, 378);
            this.BottomMenu.Size = new System.Drawing.Size(478, 70);
            // 
            // lytControl
            // 
            this.lytControl.Controls.Add(this.IdCategoriaTextEdit);
            this.lytControl.Controls.Add(this.NombreTextEdit);
            this.lytControl.Controls.Add(this.PorDefectoCheckEdit);
            this.lytControl.Controls.Add(this.DescripcionMemoEdit);
            this.lytControl.DataSource = this.categoriaBindingSource;
            this.lytControl.Size = new System.Drawing.Size(438, 250);
            // 
            // Root
            // 
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Size = new System.Drawing.Size(438, 250);
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.Buttons.Append.Visible = false;
            this.dataNavigator1.Buttons.CancelEdit.Visible = false;
            this.dataNavigator1.Buttons.EndEdit.Visible = false;
            this.dataNavigator1.Buttons.Remove.Enabled = false;
            this.dataNavigator1.Buttons.Remove.Visible = false;
            this.dataNavigator1.Location = new System.Drawing.Point(20, 270);
            this.dataNavigator1.Size = new System.Drawing.Size(438, 30);
            // 
            // inventarioVentaDataSet
            // 
            this.inventarioVentaDataSet.DataSetName = "InventarioVentaDataSet";
            this.inventarioVentaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "Categoria";
            this.categoriaBindingSource.DataSource = this.inventarioVentaDataSet;
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForIdCategoria,
            this.ItemForNombre,
            this.ItemForDescripcion,
            this.ItemForPorDefecto});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(418, 230);
            // 
            // IdCategoriaTextEdit
            // 
            this.IdCategoriaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("ReadOnly", this.categoriaBindingSource, "IdCategoria", true));
            this.IdCategoriaTextEdit.Location = new System.Drawing.Point(84, 12);
            this.IdCategoriaTextEdit.Name = "IdCategoriaTextEdit";
            this.IdCategoriaTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.IdCategoriaTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.IdCategoriaTextEdit.Properties.Mask.EditMask = "N0";
            this.IdCategoriaTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.IdCategoriaTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.IdCategoriaTextEdit.Size = new System.Drawing.Size(342, 20);
            this.IdCategoriaTextEdit.StyleController = this.lytControl;
            this.IdCategoriaTextEdit.TabIndex = 4;
            // 
            // ItemForIdCategoria
            // 
            this.ItemForIdCategoria.Control = this.IdCategoriaTextEdit;
            this.ItemForIdCategoria.Location = new System.Drawing.Point(0, 0);
            this.ItemForIdCategoria.Name = "ItemForIdCategoria";
            this.ItemForIdCategoria.Size = new System.Drawing.Size(418, 24);
            this.ItemForIdCategoria.Text = "Id Categoria";
            this.ItemForIdCategoria.TextSize = new System.Drawing.Size(60, 13);
            // 
            // NombreTextEdit
            // 
            this.NombreTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.categoriaBindingSource, "Nombre", true));
            this.NombreTextEdit.Location = new System.Drawing.Point(84, 36);
            this.NombreTextEdit.Name = "NombreTextEdit";
            this.NombreTextEdit.Size = new System.Drawing.Size(342, 20);
            this.NombreTextEdit.StyleController = this.lytControl;
            this.NombreTextEdit.TabIndex = 5;
            // 
            // ItemForNombre
            // 
            this.ItemForNombre.Control = this.NombreTextEdit;
            this.ItemForNombre.Location = new System.Drawing.Point(0, 24);
            this.ItemForNombre.Name = "ItemForNombre";
            this.ItemForNombre.Size = new System.Drawing.Size(418, 24);
            this.ItemForNombre.Text = "Nombre";
            this.ItemForNombre.TextSize = new System.Drawing.Size(60, 13);
            // 
            // PorDefectoCheckEdit
            // 
            this.PorDefectoCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.categoriaBindingSource, "PorDefecto", true));
            this.PorDefectoCheckEdit.Location = new System.Drawing.Point(84, 220);
            this.PorDefectoCheckEdit.Name = "PorDefectoCheckEdit";
            this.PorDefectoCheckEdit.Properties.Caption = "";
            this.PorDefectoCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.PorDefectoCheckEdit.Size = new System.Drawing.Size(342, 18);
            this.PorDefectoCheckEdit.StyleController = this.lytControl;
            this.PorDefectoCheckEdit.TabIndex = 6;
            // 
            // ItemForPorDefecto
            // 
            this.ItemForPorDefecto.Control = this.PorDefectoCheckEdit;
            this.ItemForPorDefecto.Location = new System.Drawing.Point(0, 208);
            this.ItemForPorDefecto.Name = "ItemForPorDefecto";
            this.ItemForPorDefecto.Size = new System.Drawing.Size(418, 22);
            this.ItemForPorDefecto.Text = "Por Defecto";
            this.ItemForPorDefecto.TextSize = new System.Drawing.Size(60, 13);
            // 
            // DescripcionMemoEdit
            // 
            this.DescripcionMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.categoriaBindingSource, "Descripcion", true));
            this.DescripcionMemoEdit.Location = new System.Drawing.Point(84, 60);
            this.DescripcionMemoEdit.Name = "DescripcionMemoEdit";
            this.DescripcionMemoEdit.Size = new System.Drawing.Size(342, 156);
            this.DescripcionMemoEdit.StyleController = this.lytControl;
            this.DescripcionMemoEdit.TabIndex = 7;
            // 
            // ItemForDescripcion
            // 
            this.ItemForDescripcion.Control = this.DescripcionMemoEdit;
            this.ItemForDescripcion.Location = new System.Drawing.Point(0, 48);
            this.ItemForDescripcion.Name = "ItemForDescripcion";
            this.ItemForDescripcion.Size = new System.Drawing.Size(418, 160);
            this.ItemForDescripcion.StartNewLine = true;
            this.ItemForDescripcion.Text = "Descripcion";
            this.ItemForDescripcion.TextSize = new System.Drawing.Size(60, 13);
            // 
            // FrmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 448);
            this.Name = "FrmCategoria";
            this.Text = "FrmCategoria";
            this.Load += new System.EventHandler(this.FrmCategoria_Load);
            this.plPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lytControl)).EndInit();
            this.lytControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioVentaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdCategoriaTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NombreTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PorDefectoCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPorDefecto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescripcionMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDescripcion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private InventarioVentaDataSet inventarioVentaDataSet;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private InventarioVentaDataSetTableAdapters.CategoriaTableAdapter categoriaTableAdapter;
        private DevExpress.XtraEditors.TextEdit IdCategoriaTextEdit;
        private DevExpress.XtraEditors.TextEdit NombreTextEdit;
        private DevExpress.XtraEditors.CheckEdit PorDefectoCheckEdit;
        private DevExpress.XtraEditors.MemoEdit DescripcionMemoEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIdCategoria;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNombre;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDescripcion;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPorDefecto;
    }
}