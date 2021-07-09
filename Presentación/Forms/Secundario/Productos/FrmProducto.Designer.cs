
namespace Presentación.Forms.Secundario.Productos
{
    partial class FrmProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProducto));
            this.inventarioVentaDataSet = new Presentación.InventarioVentaDataSet();
            this.inventarioVentaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoTableAdapter = new Presentación.InventarioVentaDataSetTableAdapters.ProductoTableAdapter();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForDescripcion = new DevExpress.XtraLayout.LayoutControlItem();
            this.DescripcionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForPrecioVenta = new DevExpress.XtraLayout.LayoutControlItem();
            this.PrecioVentaTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForCantidad = new DevExpress.XtraLayout.LayoutControlItem();
            this.CantidadTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForIdCategoria = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForMarca = new DevExpress.XtraLayout.LayoutControlItem();
            this.MarcaTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForImagen = new DevExpress.XtraLayout.LayoutControlItem();
            this.ImagenPictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.ItemForIdProducto = new DevExpress.XtraLayout.LayoutControlItem();
            this.IdProductoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForStockMinimo = new DevExpress.XtraLayout.LayoutControlItem();
            this.StockMinimoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForCodigoQR = new DevExpress.XtraLayout.LayoutControlItem();
            this.CodigoQRTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForInventariado = new DevExpress.XtraLayout.LayoutControlItem();
            this.InventariadoCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.ItemForGranel = new DevExpress.XtraLayout.LayoutControlItem();
            this.GranelCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.BtnAgregarLote = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.BtnAgregarCategoria = new DevExpress.XtraEditors.SimpleButton();
            this.IdCategoriaTextEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.plPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lytControl)).BeginInit();
            this.lytControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioVentaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioVentaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescripcionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPrecioVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioVentaTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarcaTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdProductoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStockMinimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockMinimoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCodigoQR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodigoQRTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForInventariado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventariadoCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGranel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GranelCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdCategoriaTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
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
            // 
            // lytControl
            // 
            this.lytControl.Controls.Add(this.BtnAgregarCategoria);
            this.lytControl.Controls.Add(this.BtnAgregarLote);
            this.lytControl.Controls.Add(this.IdProductoTextEdit);
            this.lytControl.Controls.Add(this.DescripcionTextEdit);
            this.lytControl.Controls.Add(this.MarcaTextEdit);
            this.lytControl.Controls.Add(this.InventariadoCheckEdit);
            this.lytControl.Controls.Add(this.CantidadTextEdit);
            this.lytControl.Controls.Add(this.PrecioVentaTextEdit);
            this.lytControl.Controls.Add(this.CodigoQRTextEdit);
            this.lytControl.Controls.Add(this.ImagenPictureEdit);
            this.lytControl.Controls.Add(this.StockMinimoTextEdit);
            this.lytControl.Controls.Add(this.GranelCheckEdit);
            this.lytControl.Controls.Add(this.IdCategoriaTextEdit);
            this.lytControl.DataSource = this.productoBindingSource;
            this.lytControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(702, 120, 650, 400);
            // 
            // Root
            // 
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.Buttons.Append.Visible = false;
            this.dataNavigator1.Buttons.CancelEdit.Visible = false;
            this.dataNavigator1.Buttons.EndEdit.Visible = false;
            this.dataNavigator1.Buttons.Remove.Enabled = false;
            this.dataNavigator1.Buttons.Remove.Visible = false;
            this.dataNavigator1.DataSource = this.productoBindingSource;
            // 
            // inventarioVentaDataSet
            // 
            this.inventarioVentaDataSet.DataSetName = "InventarioVentaDataSet";
            this.inventarioVentaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventarioVentaDataSetBindingSource
            // 
            this.inventarioVentaDataSetBindingSource.DataSource = this.inventarioVentaDataSet;
            this.inventarioVentaDataSetBindingSource.Position = 0;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.inventarioVentaDataSetBindingSource;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForDescripcion,
            this.ItemForPrecioVenta,
            this.ItemForCantidad,
            this.ItemForIdCategoria,
            this.ItemForMarca,
            this.ItemForImagen,
            this.ItemForIdProducto,
            this.ItemForStockMinimo,
            this.ItemForCodigoQR,
            this.ItemForInventariado,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.ItemForGranel,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(658, 330);
            // 
            // ItemForDescripcion
            // 
            this.ItemForDescripcion.Control = this.DescripcionTextEdit;
            this.ItemForDescripcion.Location = new System.Drawing.Point(0, 0);
            this.ItemForDescripcion.Name = "ItemForDescripcion";
            this.ItemForDescripcion.Size = new System.Drawing.Size(444, 24);
            this.ItemForDescripcion.Text = "Descripcion";
            this.ItemForDescripcion.TextSize = new System.Drawing.Size(61, 13);
            // 
            // DescripcionTextEdit
            // 
            this.DescripcionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productoBindingSource, "Descripcion", true));
            this.DescripcionTextEdit.Location = new System.Drawing.Point(85, 12);
            this.DescripcionTextEdit.Name = "DescripcionTextEdit";
            this.DescripcionTextEdit.Size = new System.Drawing.Size(367, 20);
            this.DescripcionTextEdit.StyleController = this.lytControl;
            this.DescripcionTextEdit.TabIndex = 6;
            // 
            // ItemForPrecioVenta
            // 
            this.ItemForPrecioVenta.Control = this.PrecioVentaTextEdit;
            this.ItemForPrecioVenta.Location = new System.Drawing.Point(0, 50);
            this.ItemForPrecioVenta.Name = "ItemForPrecioVenta";
            this.ItemForPrecioVenta.Size = new System.Drawing.Size(444, 24);
            this.ItemForPrecioVenta.Text = "Precio Venta";
            this.ItemForPrecioVenta.TextSize = new System.Drawing.Size(61, 13);
            // 
            // PrecioVentaTextEdit
            // 
            this.PrecioVentaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productoBindingSource, "PrecioVenta", true));
            this.PrecioVentaTextEdit.Location = new System.Drawing.Point(85, 62);
            this.PrecioVentaTextEdit.Name = "PrecioVentaTextEdit";
            this.PrecioVentaTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.PrecioVentaTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.PrecioVentaTextEdit.Properties.Mask.EditMask = "F";
            this.PrecioVentaTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.PrecioVentaTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.PrecioVentaTextEdit.Size = new System.Drawing.Size(367, 20);
            this.PrecioVentaTextEdit.StyleController = this.lytControl;
            this.PrecioVentaTextEdit.TabIndex = 10;
            // 
            // ItemForCantidad
            // 
            this.ItemForCantidad.Control = this.CantidadTextEdit;
            this.ItemForCantidad.Location = new System.Drawing.Point(0, 74);
            this.ItemForCantidad.Name = "ItemForCantidad";
            this.ItemForCantidad.Size = new System.Drawing.Size(412, 26);
            this.ItemForCantidad.Text = "Cantidad";
            this.ItemForCantidad.TextSize = new System.Drawing.Size(61, 13);
            // 
            // CantidadTextEdit
            // 
            this.CantidadTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productoBindingSource, "Cantidad", true));
            this.CantidadTextEdit.Location = new System.Drawing.Point(85, 86);
            this.CantidadTextEdit.Name = "CantidadTextEdit";
            this.CantidadTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.CantidadTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.CantidadTextEdit.Properties.Mask.EditMask = "N0";
            this.CantidadTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.CantidadTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.CantidadTextEdit.Size = new System.Drawing.Size(335, 20);
            this.CantidadTextEdit.StyleController = this.lytControl;
            this.CantidadTextEdit.TabIndex = 9;
            // 
            // ItemForIdCategoria
            // 
            this.ItemForIdCategoria.Control = this.IdCategoriaTextEdit;
            this.ItemForIdCategoria.Location = new System.Drawing.Point(0, 24);
            this.ItemForIdCategoria.Name = "ItemForIdCategoria";
            this.ItemForIdCategoria.Size = new System.Drawing.Size(412, 26);
            this.ItemForIdCategoria.Text = "Categoria";
            this.ItemForIdCategoria.TextSize = new System.Drawing.Size(61, 13);
            // 
            // ItemForMarca
            // 
            this.ItemForMarca.Control = this.MarcaTextEdit;
            this.ItemForMarca.Location = new System.Drawing.Point(0, 100);
            this.ItemForMarca.Name = "ItemForMarca";
            this.ItemForMarca.Size = new System.Drawing.Size(444, 24);
            this.ItemForMarca.Text = "Marca";
            this.ItemForMarca.TextSize = new System.Drawing.Size(61, 13);
            // 
            // MarcaTextEdit
            // 
            this.MarcaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productoBindingSource, "Marca", true));
            this.MarcaTextEdit.Location = new System.Drawing.Point(85, 112);
            this.MarcaTextEdit.Name = "MarcaTextEdit";
            this.MarcaTextEdit.Size = new System.Drawing.Size(367, 20);
            this.MarcaTextEdit.StyleController = this.lytControl;
            this.MarcaTextEdit.TabIndex = 7;
            // 
            // ItemForImagen
            // 
            this.ItemForImagen.Control = this.ImagenPictureEdit;
            this.ItemForImagen.Location = new System.Drawing.Point(481, 0);
            this.ItemForImagen.Name = "ItemForImagen";
            this.ItemForImagen.Size = new System.Drawing.Size(177, 209);
            this.ItemForImagen.StartNewLine = true;
            this.ItemForImagen.Text = "Imagen";
            this.ItemForImagen.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForImagen.TextVisible = false;
            // 
            // ImagenPictureEdit
            // 
            this.ImagenPictureEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productoBindingSource, "Imagen", true));
            this.ImagenPictureEdit.Location = new System.Drawing.Point(493, 12);
            this.ImagenPictureEdit.Name = "ImagenPictureEdit";
            this.ImagenPictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.ImagenPictureEdit.Size = new System.Drawing.Size(173, 205);
            this.ImagenPictureEdit.StyleController = this.lytControl;
            this.ImagenPictureEdit.TabIndex = 12;
            this.ImagenPictureEdit.DoubleClick += new System.EventHandler(this.ImagenPictureEdit_DoubleClick);
            // 
            // ItemForIdProducto
            // 
            this.ItemForIdProducto.Control = this.IdProductoTextEdit;
            this.ItemForIdProducto.Location = new System.Drawing.Point(481, 209);
            this.ItemForIdProducto.Name = "ItemForIdProducto";
            this.ItemForIdProducto.Size = new System.Drawing.Size(177, 24);
            this.ItemForIdProducto.Text = "Id Producto";
            this.ItemForIdProducto.TextSize = new System.Drawing.Size(61, 13);
            // 
            // IdProductoTextEdit
            // 
            this.IdProductoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productoBindingSource, "IdProducto", true));
            this.IdProductoTextEdit.Location = new System.Drawing.Point(566, 221);
            this.IdProductoTextEdit.Name = "IdProductoTextEdit";
            this.IdProductoTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.IdProductoTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.IdProductoTextEdit.Properties.Mask.EditMask = "N0";
            this.IdProductoTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.IdProductoTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.IdProductoTextEdit.Properties.ReadOnly = true;
            this.IdProductoTextEdit.Properties.UseReadOnlyAppearance = false;
            this.IdProductoTextEdit.Size = new System.Drawing.Size(100, 20);
            this.IdProductoTextEdit.StyleController = this.lytControl;
            this.IdProductoTextEdit.TabIndex = 4;
            // 
            // ItemForStockMinimo
            // 
            this.ItemForStockMinimo.Control = this.StockMinimoTextEdit;
            this.ItemForStockMinimo.Location = new System.Drawing.Point(0, 124);
            this.ItemForStockMinimo.Name = "ItemForStockMinimo";
            this.ItemForStockMinimo.Size = new System.Drawing.Size(444, 24);
            this.ItemForStockMinimo.Text = "Stock Minimo";
            this.ItemForStockMinimo.TextSize = new System.Drawing.Size(61, 13);
            // 
            // StockMinimoTextEdit
            // 
            this.StockMinimoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productoBindingSource, "StockMinimo", true));
            this.StockMinimoTextEdit.Location = new System.Drawing.Point(85, 136);
            this.StockMinimoTextEdit.Name = "StockMinimoTextEdit";
            this.StockMinimoTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.StockMinimoTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.StockMinimoTextEdit.Properties.Mask.EditMask = "N0";
            this.StockMinimoTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.StockMinimoTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.StockMinimoTextEdit.Size = new System.Drawing.Size(367, 20);
            this.StockMinimoTextEdit.StyleController = this.lytControl;
            this.StockMinimoTextEdit.TabIndex = 13;
            // 
            // ItemForCodigoQR
            // 
            this.ItemForCodigoQR.Control = this.CodigoQRTextEdit;
            this.ItemForCodigoQR.Location = new System.Drawing.Point(0, 148);
            this.ItemForCodigoQR.Name = "ItemForCodigoQR";
            this.ItemForCodigoQR.Size = new System.Drawing.Size(444, 24);
            this.ItemForCodigoQR.Text = "Codigo QR";
            this.ItemForCodigoQR.TextSize = new System.Drawing.Size(61, 13);
            // 
            // CodigoQRTextEdit
            // 
            this.CodigoQRTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productoBindingSource, "CodigoQR", true));
            this.CodigoQRTextEdit.Location = new System.Drawing.Point(85, 160);
            this.CodigoQRTextEdit.Name = "CodigoQRTextEdit";
            this.CodigoQRTextEdit.Size = new System.Drawing.Size(367, 20);
            this.CodigoQRTextEdit.StyleController = this.lytControl;
            this.CodigoQRTextEdit.TabIndex = 11;
            // 
            // ItemForInventariado
            // 
            this.ItemForInventariado.Control = this.InventariadoCheckEdit;
            this.ItemForInventariado.Location = new System.Drawing.Point(0, 172);
            this.ItemForInventariado.Name = "ItemForInventariado";
            this.ItemForInventariado.Size = new System.Drawing.Size(220, 158);
            this.ItemForInventariado.Text = "Inventariado";
            this.ItemForInventariado.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForInventariado.TextVisible = false;
            // 
            // InventariadoCheckEdit
            // 
            this.InventariadoCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productoBindingSource, "Inventariado", true));
            this.InventariadoCheckEdit.Location = new System.Drawing.Point(12, 184);
            this.InventariadoCheckEdit.Name = "InventariadoCheckEdit";
            this.InventariadoCheckEdit.Properties.Caption = "Inventariado";
            this.InventariadoCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.InventariadoCheckEdit.Size = new System.Drawing.Size(216, 18);
            this.InventariadoCheckEdit.StyleController = this.lytControl;
            this.InventariadoCheckEdit.TabIndex = 8;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(481, 233);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(177, 97);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(444, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(37, 330);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ItemForGranel
            // 
            this.ItemForGranel.Control = this.GranelCheckEdit;
            this.ItemForGranel.Location = new System.Drawing.Point(220, 172);
            this.ItemForGranel.Name = "ItemForGranel";
            this.ItemForGranel.Size = new System.Drawing.Size(224, 158);
            this.ItemForGranel.Text = "Granel";
            this.ItemForGranel.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForGranel.TextVisible = false;
            // 
            // GranelCheckEdit
            // 
            this.GranelCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productoBindingSource, "Granel", true));
            this.GranelCheckEdit.Location = new System.Drawing.Point(232, 184);
            this.GranelCheckEdit.Name = "GranelCheckEdit";
            this.GranelCheckEdit.Properties.Caption = "Granel";
            this.GranelCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.GranelCheckEdit.Size = new System.Drawing.Size(220, 18);
            this.GranelCheckEdit.StyleController = this.lytControl;
            this.GranelCheckEdit.TabIndex = 14;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.BtnAgregarLote;
            this.layoutControlItem2.Location = new System.Drawing.Point(412, 74);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(32, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // BtnAgregarLote
            // 
            this.BtnAgregarLote.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregarLote.ImageOptions.Image")));
            this.BtnAgregarLote.Location = new System.Drawing.Point(424, 86);
            this.BtnAgregarLote.Name = "BtnAgregarLote";
            this.BtnAgregarLote.Size = new System.Drawing.Size(28, 22);
            this.BtnAgregarLote.StyleController = this.lytControl;
            this.BtnAgregarLote.TabIndex = 16;
            this.BtnAgregarLote.Click += new System.EventHandler(this.BtnAgregarLote_Click);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.BtnAgregarCategoria;
            this.layoutControlItem3.Location = new System.Drawing.Point(412, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(32, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // BtnAgregarCategoria
            // 
            this.BtnAgregarCategoria.ImageOptions.Image = global::Presentación.Properties.Resources.add_16x16;
            this.BtnAgregarCategoria.Location = new System.Drawing.Point(424, 36);
            this.BtnAgregarCategoria.Name = "BtnAgregarCategoria";
            this.BtnAgregarCategoria.Size = new System.Drawing.Size(28, 22);
            this.BtnAgregarCategoria.StyleController = this.lytControl;
            this.BtnAgregarCategoria.TabIndex = 17;
            this.BtnAgregarCategoria.Click += new System.EventHandler(this.BtnAgregarCategoria_Click);
            // 
            // IdCategoriaTextEdit
            // 
            this.IdCategoriaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productoBindingSource, "IdCategoria", true));
            this.IdCategoriaTextEdit.Location = new System.Drawing.Point(85, 36);
            this.IdCategoriaTextEdit.Name = "IdCategoriaTextEdit";
            this.IdCategoriaTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.IdCategoriaTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.IdCategoriaTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.IdCategoriaTextEdit.Properties.DisplayMember = "Nombre";
            this.IdCategoriaTextEdit.Properties.NullText = "";
            this.IdCategoriaTextEdit.Properties.PopupView = this.searchLookUpEdit1View;
            this.IdCategoriaTextEdit.Properties.ValueMember = "IdCategoria";
            this.IdCategoriaTextEdit.Size = new System.Drawing.Size(335, 20);
            this.IdCategoriaTextEdit.StyleController = this.lytControl;
            this.IdCategoriaTextEdit.TabIndex = 5;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 548);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("FrmProducto.IconOptions.Image")));
            this.Name = "FrmProducto";
            this.Text = "FrmProducto";
            this.Load += new System.EventHandler(this.FrmProducto_Load);
            this.plPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lytControl)).EndInit();
            this.lytControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioVentaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioVentaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescripcionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPrecioVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioVentaTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarcaTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdProductoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStockMinimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockMinimoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCodigoQR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodigoQRTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForInventariado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventariadoCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGranel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GranelCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdCategoriaTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource inventarioVentaDataSetBindingSource;
        private InventarioVentaDataSet inventarioVentaDataSet;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private InventarioVentaDataSetTableAdapters.ProductoTableAdapter productoTableAdapter;
        private DevExpress.XtraEditors.TextEdit IdProductoTextEdit;
        private DevExpress.XtraEditors.TextEdit DescripcionTextEdit;
        private DevExpress.XtraEditors.TextEdit MarcaTextEdit;
        private DevExpress.XtraEditors.CheckEdit InventariadoCheckEdit;
        private DevExpress.XtraEditors.TextEdit CantidadTextEdit;
        private DevExpress.XtraEditors.TextEdit PrecioVentaTextEdit;
        private DevExpress.XtraEditors.TextEdit CodigoQRTextEdit;
        private DevExpress.XtraEditors.PictureEdit ImagenPictureEdit;
        private DevExpress.XtraEditors.TextEdit StockMinimoTextEdit;
        private DevExpress.XtraEditors.CheckEdit GranelCheckEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDescripcion;
        private DevExpress.XtraLayout.LayoutControlItem ItemForInventariado;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPrecioVenta;
        private DevExpress.XtraLayout.LayoutControlItem ItemForStockMinimo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForGranel;
        private DevExpress.XtraLayout.LayoutControlItem ItemForImagen;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIdCategoria;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMarca;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCantidad;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCodigoQR;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIdProducto;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.SimpleButton BtnAgregarCategoria;
        private DevExpress.XtraEditors.SimpleButton BtnAgregarLote;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SearchLookUpEdit IdCategoriaTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
    }
}