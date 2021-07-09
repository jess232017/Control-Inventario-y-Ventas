
namespace Presentación.Forms
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.SbDashboard = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.SbVentas = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.SbInventarios = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.SbMovimientos = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.SbProductos = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.SbCajas = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.SbTiendas = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.sbContactos = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.SbClientes = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.SbEmpleados = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.SbProveedores = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.SbConfiguracion = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.SbAyuda = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.SbInfoCreditos = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.SbCerrarSesion = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.widgetView1 = new DevExpress.XtraBars.Docking2010.Views.Widget.WidgetView(this.components);
            this.tabbedView2 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.SbCreditos = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widgetView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.SbDashboard,
            this.SbVentas,
            this.SbInventarios,
            this.SbMovimientos,
            this.SbProductos,
            this.SbCajas,
            this.SbTiendas,
            this.sbContactos,
            this.SbConfiguracion,
            this.SbAyuda,
            this.SbInfoCreditos,
            this.SbCerrarSesion});
            this.accordionControl1.ItemHeight = 24;
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.OptionsMinimizing.AllowMinimizeMode = DevExpress.Utils.DefaultBoolean.True;
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(214, 681);
            this.accordionControl1.TabIndex = 0;
            this.accordionControl1.Text = "accordionControl1";
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // SbDashboard
            // 
            this.SbDashboard.Appearance.Disabled.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbDashboard.Appearance.Disabled.Options.UseFont = true;
            this.SbDashboard.Appearance.Hovered.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbDashboard.Appearance.Hovered.Options.UseFont = true;
            this.SbDashboard.Appearance.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.SbDashboard.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SbDashboard.Appearance.Normal.Options.UseBackColor = true;
            this.SbDashboard.Appearance.Normal.Options.UseFont = true;
            this.SbDashboard.Appearance.Pressed.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbDashboard.Appearance.Pressed.Options.UseFont = true;
            this.SbDashboard.Height = 45;
            this.SbDashboard.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("SbDashboard.ImageOptions.SvgImage")));
            this.SbDashboard.Name = "SbDashboard";
            this.SbDashboard.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.SbDashboard.Text = "Panel de Datos";
            this.SbDashboard.Click += new System.EventHandler(this.SbDashboard_Click);
            // 
            // SbVentas
            // 
            this.SbVentas.Appearance.Disabled.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbVentas.Appearance.Disabled.Options.UseFont = true;
            this.SbVentas.Appearance.Hovered.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbVentas.Appearance.Hovered.Options.UseFont = true;
            this.SbVentas.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbVentas.Appearance.Normal.Options.UseFont = true;
            this.SbVentas.Appearance.Pressed.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbVentas.Appearance.Pressed.Options.UseFont = true;
            this.SbVentas.Height = 45;
            this.SbVentas.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("SbVentas.ImageOptions.SvgImage")));
            this.SbVentas.Name = "SbVentas";
            this.SbVentas.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.SbVentas.Text = "Ventas";
            this.SbVentas.Click += new System.EventHandler(this.SbVentas_Click);
            // 
            // SbInventarios
            // 
            this.SbInventarios.Appearance.Disabled.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbInventarios.Appearance.Disabled.Options.UseFont = true;
            this.SbInventarios.Appearance.Hovered.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbInventarios.Appearance.Hovered.Options.UseFont = true;
            this.SbInventarios.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbInventarios.Appearance.Normal.Options.UseBackColor = true;
            this.SbInventarios.Appearance.Normal.Options.UseFont = true;
            this.SbInventarios.Appearance.Pressed.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbInventarios.Appearance.Pressed.Options.UseFont = true;
            this.SbInventarios.Height = 45;
            this.SbInventarios.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("SbInventarios.ImageOptions.SvgImage")));
            this.SbInventarios.Name = "SbInventarios";
            this.SbInventarios.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.SbInventarios.Text = "Inventarios";
            this.SbInventarios.Click += new System.EventHandler(this.SbInventario_Click);
            // 
            // SbMovimientos
            // 
            this.SbMovimientos.Appearance.Disabled.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbMovimientos.Appearance.Disabled.Options.UseFont = true;
            this.SbMovimientos.Appearance.Hovered.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbMovimientos.Appearance.Hovered.Options.UseFont = true;
            this.SbMovimientos.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbMovimientos.Appearance.Normal.Options.UseFont = true;
            this.SbMovimientos.Appearance.Pressed.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbMovimientos.Appearance.Pressed.Options.UseFont = true;
            this.SbMovimientos.Height = 45;
            this.SbMovimientos.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("SbMovimientos.ImageOptions.SvgImage")));
            this.SbMovimientos.Name = "SbMovimientos";
            this.SbMovimientos.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.SbMovimientos.Text = "Movimientos";
            this.SbMovimientos.Click += new System.EventHandler(this.SbMovimientos_Click);
            // 
            // SbProductos
            // 
            this.SbProductos.Appearance.Disabled.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbProductos.Appearance.Disabled.Options.UseFont = true;
            this.SbProductos.Appearance.Hovered.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbProductos.Appearance.Hovered.Options.UseFont = true;
            this.SbProductos.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbProductos.Appearance.Normal.Options.UseFont = true;
            this.SbProductos.Appearance.Pressed.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbProductos.Appearance.Pressed.Options.UseFont = true;
            this.SbProductos.Height = 45;
            this.SbProductos.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("SbProductos.ImageOptions.SvgImage")));
            this.SbProductos.Name = "SbProductos";
            this.SbProductos.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.SbProductos.Text = "Productos";
            this.SbProductos.Click += new System.EventHandler(this.SbProductos_Click);
            // 
            // SbCajas
            // 
            this.SbCajas.Appearance.Disabled.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbCajas.Appearance.Disabled.Options.UseFont = true;
            this.SbCajas.Appearance.Hovered.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbCajas.Appearance.Hovered.Options.UseFont = true;
            this.SbCajas.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbCajas.Appearance.Normal.Options.UseFont = true;
            this.SbCajas.Appearance.Pressed.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbCajas.Appearance.Pressed.Options.UseFont = true;
            this.SbCajas.Height = 45;
            this.SbCajas.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("SbCajas.ImageOptions.SvgImage")));
            this.SbCajas.Name = "SbCajas";
            this.SbCajas.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.SbCajas.Text = "Cajas";
            this.SbCajas.Click += new System.EventHandler(this.SbCajas_Click);
            // 
            // SbTiendas
            // 
            this.SbTiendas.Appearance.Disabled.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbTiendas.Appearance.Disabled.Options.UseFont = true;
            this.SbTiendas.Appearance.Hovered.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbTiendas.Appearance.Hovered.Options.UseFont = true;
            this.SbTiendas.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbTiendas.Appearance.Normal.Options.UseFont = true;
            this.SbTiendas.Appearance.Pressed.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbTiendas.Appearance.Pressed.Options.UseFont = true;
            this.SbTiendas.Height = 45;
            this.SbTiendas.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("SbTiendas.ImageOptions.SvgImage")));
            this.SbTiendas.Name = "SbTiendas";
            this.SbTiendas.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.SbTiendas.Text = "Tiendas";
            this.SbTiendas.Visible = false;
            this.SbTiendas.Click += new System.EventHandler(this.SbTiendas_Click);
            // 
            // sbContactos
            // 
            this.sbContactos.Appearance.Disabled.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.sbContactos.Appearance.Disabled.Options.UseFont = true;
            this.sbContactos.Appearance.Hovered.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.sbContactos.Appearance.Hovered.Options.UseFont = true;
            this.sbContactos.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.sbContactos.Appearance.Normal.Options.UseFont = true;
            this.sbContactos.Appearance.Pressed.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.sbContactos.Appearance.Pressed.Options.UseFont = true;
            this.sbContactos.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.SbClientes,
            this.SbEmpleados,
            this.SbProveedores});
            this.sbContactos.Expanded = true;
            this.sbContactos.Height = 45;
            this.sbContactos.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("sbContactos.ImageOptions.SvgImage")));
            this.sbContactos.Name = "sbContactos";
            this.sbContactos.Text = "Contactos";
            // 
            // SbClientes
            // 
            this.SbClientes.Appearance.Disabled.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbClientes.Appearance.Disabled.Options.UseFont = true;
            this.SbClientes.Appearance.Hovered.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbClientes.Appearance.Hovered.Options.UseFont = true;
            this.SbClientes.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbClientes.Appearance.Normal.Options.UseFont = true;
            this.SbClientes.Appearance.Pressed.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbClientes.Appearance.Pressed.Options.UseFont = true;
            this.SbClientes.Height = 45;
            this.SbClientes.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("SbClientes.ImageOptions.SvgImage")));
            this.SbClientes.Name = "SbClientes";
            this.SbClientes.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.SbClientes.Text = "Clientes";
            this.SbClientes.Click += new System.EventHandler(this.SbClientes_Click);
            // 
            // SbEmpleados
            // 
            this.SbEmpleados.Appearance.Disabled.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbEmpleados.Appearance.Disabled.Options.UseFont = true;
            this.SbEmpleados.Appearance.Hovered.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbEmpleados.Appearance.Hovered.Options.UseFont = true;
            this.SbEmpleados.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbEmpleados.Appearance.Normal.Options.UseFont = true;
            this.SbEmpleados.Appearance.Pressed.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbEmpleados.Appearance.Pressed.Options.UseFont = true;
            this.SbEmpleados.Height = 45;
            this.SbEmpleados.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("SbEmpleados.ImageOptions.SvgImage")));
            this.SbEmpleados.Name = "SbEmpleados";
            this.SbEmpleados.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.SbEmpleados.Text = "Empleados";
            this.SbEmpleados.Click += new System.EventHandler(this.SbEmpleados_Click);
            // 
            // SbProveedores
            // 
            this.SbProveedores.Appearance.Disabled.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbProveedores.Appearance.Disabled.Options.UseFont = true;
            this.SbProveedores.Appearance.Hovered.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbProveedores.Appearance.Hovered.Options.UseFont = true;
            this.SbProveedores.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbProveedores.Appearance.Normal.Options.UseFont = true;
            this.SbProveedores.Appearance.Pressed.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbProveedores.Appearance.Pressed.Options.UseFont = true;
            this.SbProveedores.Height = 45;
            this.SbProveedores.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("SbProveedores.ImageOptions.SvgImage")));
            this.SbProveedores.Name = "SbProveedores";
            this.SbProveedores.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.SbProveedores.Text = "Proveedores";
            this.SbProveedores.Click += new System.EventHandler(this.SbProveedores_Click);
            // 
            // SbConfiguracion
            // 
            this.SbConfiguracion.Appearance.Disabled.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbConfiguracion.Appearance.Disabled.Options.UseFont = true;
            this.SbConfiguracion.Appearance.Hovered.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbConfiguracion.Appearance.Hovered.Options.UseFont = true;
            this.SbConfiguracion.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbConfiguracion.Appearance.Normal.Options.UseFont = true;
            this.SbConfiguracion.Appearance.Pressed.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbConfiguracion.Appearance.Pressed.Options.UseFont = true;
            this.SbConfiguracion.Height = 45;
            this.SbConfiguracion.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("SbConfiguracion.ImageOptions.SvgImage")));
            this.SbConfiguracion.Name = "SbConfiguracion";
            this.SbConfiguracion.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.SbConfiguracion.Text = "Configuración";
            this.SbConfiguracion.Click += new System.EventHandler(this.SbConfiguracion_Click);
            // 
            // SbAyuda
            // 
            this.SbAyuda.Appearance.Disabled.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbAyuda.Appearance.Disabled.Options.UseFont = true;
            this.SbAyuda.Appearance.Hovered.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbAyuda.Appearance.Hovered.Options.UseFont = true;
            this.SbAyuda.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbAyuda.Appearance.Normal.Options.UseFont = true;
            this.SbAyuda.Appearance.Pressed.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbAyuda.Appearance.Pressed.Options.UseFont = true;
            this.SbAyuda.Height = 45;
            this.SbAyuda.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("SbAyuda.ImageOptions.SvgImage")));
            this.SbAyuda.Name = "SbAyuda";
            this.SbAyuda.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.SbAyuda.Text = "Ayuda";
            this.SbAyuda.Click += new System.EventHandler(this.SbAyuda_Click);
            // 
            // SbInfoCreditos
            // 
            this.SbInfoCreditos.Appearance.Disabled.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbInfoCreditos.Appearance.Disabled.Options.UseFont = true;
            this.SbInfoCreditos.Appearance.Hovered.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbInfoCreditos.Appearance.Hovered.Options.UseFont = true;
            this.SbInfoCreditos.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbInfoCreditos.Appearance.Normal.Options.UseFont = true;
            this.SbInfoCreditos.Appearance.Pressed.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbInfoCreditos.Appearance.Pressed.Options.UseFont = true;
            this.SbInfoCreditos.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl)});
            this.SbInfoCreditos.Height = 45;
            this.SbInfoCreditos.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("SbInfoCreditos.ImageOptions.SvgImage")));
            this.SbInfoCreditos.Name = "SbInfoCreditos";
            this.SbInfoCreditos.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.SbInfoCreditos.Text = "Créditos";
            this.SbInfoCreditos.Click += new System.EventHandler(this.SbInfoCreditos_Click);
            // 
            // SbCerrarSesion
            // 
            this.SbCerrarSesion.Appearance.Disabled.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbCerrarSesion.Appearance.Disabled.Options.UseFont = true;
            this.SbCerrarSesion.Appearance.Hovered.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbCerrarSesion.Appearance.Hovered.Options.UseFont = true;
            this.SbCerrarSesion.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbCerrarSesion.Appearance.Normal.Options.UseFont = true;
            this.SbCerrarSesion.Appearance.Pressed.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbCerrarSesion.Appearance.Pressed.Options.UseFont = true;
            this.SbCerrarSesion.Height = 45;
            this.SbCerrarSesion.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("SbCerrarSesion.ImageOptions.SvgImage")));
            this.SbCerrarSesion.Name = "SbCerrarSesion";
            this.SbCerrarSesion.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.SbCerrarSesion.Text = "Cerrar Sesión";
            // 
            // documentManager1
            // 
            this.documentManager1.ContainerControl = this;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1,
            this.widgetView1,
            this.tabbedView2});
            this.documentManager1.DocumentActivate += new DevExpress.XtraBars.Docking2010.Views.DocumentEventHandler(this.DocumentManager1_DocumentActivate);
            // 
            // widgetView1
            // 
            this.widgetView1.RootContainer.Orientation = System.Windows.Forms.Orientation.Vertical;
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
            // 
            // SbCreditos
            // 
            this.SbCreditos.Appearance.Disabled.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbCreditos.Appearance.Disabled.Options.UseFont = true;
            this.SbCreditos.Appearance.Hovered.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbCreditos.Appearance.Hovered.Options.UseFont = true;
            this.SbCreditos.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbCreditos.Appearance.Normal.Options.UseFont = true;
            this.SbCreditos.Appearance.Pressed.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SbCreditos.Appearance.Pressed.Options.UseFont = true;
            this.SbCreditos.Height = 45;
            this.SbCreditos.Name = "SbCreditos";
            this.SbCreditos.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.SbCreditos.Text = "Creditos";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.accordionControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.Image = global::Presentación.Properties.Resources.icons8_online_shop_shopping_bag_96;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Inventarios y Ventas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widgetView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Widget.WidgetView widgetView1;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement SbCreditos;
        private DevExpress.XtraBars.Navigation.AccordionControlElement SbVentas;
        private DevExpress.XtraBars.Navigation.AccordionControlElement SbInventarios;
        private DevExpress.XtraBars.Navigation.AccordionControlElement SbProductos;
        private DevExpress.XtraBars.Navigation.AccordionControlElement SbDashboard;
        private DevExpress.XtraBars.Navigation.AccordionControlElement SbInfoCreditos;
        private DevExpress.XtraBars.Navigation.AccordionControlElement SbAyuda;
        private DevExpress.XtraBars.Navigation.AccordionControlElement SbConfiguracion;
        private DevExpress.XtraBars.Navigation.AccordionControlElement sbContactos;
        private DevExpress.XtraBars.Navigation.AccordionControlElement SbProveedores;
        private DevExpress.XtraBars.Navigation.AccordionControlElement SbEmpleados;
        private DevExpress.XtraBars.Navigation.AccordionControlElement SbClientes;
        public DevExpress.XtraBars.Navigation.AccordionControlElement SbCerrarSesion;
        private DevExpress.XtraBars.Navigation.AccordionControlElement SbMovimientos;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView2;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement SbCajas;
        private DevExpress.XtraBars.Navigation.AccordionControlElement SbTiendas;
    }
}

