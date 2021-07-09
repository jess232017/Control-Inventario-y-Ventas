
using System.Windows.Forms;

namespace Presentación.Forms
{
    partial class MenuV2
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
            this.SbCreditos = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.DivNav = new DevExpress.XtraEditors.XtraScrollableControl();
            this.BtnCreditos = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BtnAyuda = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SubContactos = new System.Windows.Forms.Panel();
            this.BtnProveedores = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BtnEmpleados = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BtnClientes = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BtnContactos = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BtnTiendas = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BtnCajas = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BtnProductos = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BtnMovimientos = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BtnInventarios = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BtnVentas = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BtnDashboard = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dockPanel2 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.SideMenu = new System.Windows.Forms.Panel();
            this.BtnShowAgain = new Guna.UI2.WinForms.Guna2GradientButton();
            this.DivFooter = new DevExpress.XtraEditors.PanelControl();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.BtnConfiguracion = new Guna.UI2.WinForms.Guna2GradientButton();
            this.DivHeader = new System.Windows.Forms.Panel();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.SbCerrarSesion = new Guna.UI2.WinForms.Guna2GradientButton();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.flyNotify1 = new Presentación.Forms.Principal.Admin.FlyNotify();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.flyoutPanelControl1 = new DevExpress.Utils.FlyoutPanelControl();
            this.ToolTip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.DivNav.SuspendLayout();
            this.SubContactos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.dockPanel2.SuspendLayout();
            this.SideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DivFooter)).BeginInit();
            this.DivFooter.SuspendLayout();
            this.DivHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyNotify1)).BeginInit();
            this.flyNotify1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).BeginInit();
            this.SuspendLayout();
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
            // DivNav
            // 
            this.DivNav.AllowTouchScroll = true;
            this.DivNav.Controls.Add(this.BtnCreditos);
            this.DivNav.Controls.Add(this.BtnAyuda);
            this.DivNav.Controls.Add(this.SubContactos);
            this.DivNav.Controls.Add(this.BtnContactos);
            this.DivNav.Controls.Add(this.BtnTiendas);
            this.DivNav.Controls.Add(this.BtnCajas);
            this.DivNav.Controls.Add(this.BtnProductos);
            this.DivNav.Controls.Add(this.BtnMovimientos);
            this.DivNav.Controls.Add(this.BtnInventarios);
            this.DivNav.Controls.Add(this.BtnVentas);
            this.DivNav.Controls.Add(this.BtnDashboard);
            this.DivNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DivNav.Location = new System.Drawing.Point(0, 140);
            this.DivNav.Name = "DivNav";
            this.DivNav.Size = new System.Drawing.Size(229, 359);
            this.DivNav.TabIndex = 0;
            // 
            // BtnCreditos
            // 
            this.BtnCreditos.Animated = true;
            this.BtnCreditos.BackColor = System.Drawing.Color.Transparent;
            this.BtnCreditos.CheckedState.Parent = this.BtnCreditos;
            this.BtnCreditos.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnCreditos.CustomImages.Parent = this.BtnCreditos;
            this.BtnCreditos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCreditos.FillColor = System.Drawing.Color.Empty;
            this.BtnCreditos.FillColor2 = System.Drawing.Color.Empty;
            this.BtnCreditos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreditos.ForeColor = System.Drawing.Color.White;
            this.BtnCreditos.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.BtnCreditos.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.BtnCreditos.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnCreditos.HoverState.Parent = this.BtnCreditos;
            this.BtnCreditos.Image = global::Presentación.Properties.Resources.icons8_about_48;
            this.BtnCreditos.ImageOffset = new System.Drawing.Point(-70, 0);
            this.BtnCreditos.Location = new System.Drawing.Point(0, 540);
            this.BtnCreditos.Name = "BtnCreditos";
            this.BtnCreditos.ShadowDecoration.Parent = this.BtnCreditos;
            this.BtnCreditos.Size = new System.Drawing.Size(212, 45);
            this.BtnCreditos.TabIndex = 33;
            this.BtnCreditos.Text = "Créditos";
            this.BtnCreditos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnCreditos.TextOffset = new System.Drawing.Point(50, 0);
            this.ToolTip.SetToolTip(this.BtnCreditos, "Créditos");
            this.BtnCreditos.UseTransparentBackground = true;
            this.BtnCreditos.Click += new System.EventHandler(this.SbInfoCreditos_Click);
            // 
            // BtnAyuda
            // 
            this.BtnAyuda.Animated = true;
            this.BtnAyuda.BackColor = System.Drawing.Color.Transparent;
            this.BtnAyuda.CheckedState.Parent = this.BtnAyuda;
            this.BtnAyuda.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnAyuda.CustomImages.Parent = this.BtnAyuda;
            this.BtnAyuda.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAyuda.FillColor = System.Drawing.Color.Empty;
            this.BtnAyuda.FillColor2 = System.Drawing.Color.Empty;
            this.BtnAyuda.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAyuda.ForeColor = System.Drawing.Color.White;
            this.BtnAyuda.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.BtnAyuda.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.BtnAyuda.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnAyuda.HoverState.Parent = this.BtnAyuda;
            this.BtnAyuda.Image = global::Presentación.Properties.Resources.icons8_help_48;
            this.BtnAyuda.ImageOffset = new System.Drawing.Point(-70, 0);
            this.BtnAyuda.Location = new System.Drawing.Point(0, 495);
            this.BtnAyuda.Name = "BtnAyuda";
            this.BtnAyuda.ShadowDecoration.Parent = this.BtnAyuda;
            this.BtnAyuda.Size = new System.Drawing.Size(212, 45);
            this.BtnAyuda.TabIndex = 30;
            this.BtnAyuda.Text = "Ayuda";
            this.BtnAyuda.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnAyuda.TextOffset = new System.Drawing.Point(50, 0);
            this.ToolTip.SetToolTip(this.BtnAyuda, "Ayuda");
            this.BtnAyuda.UseTransparentBackground = true;
            this.BtnAyuda.Click += new System.EventHandler(this.SbAyuda_Click);
            // 
            // SubContactos
            // 
            this.SubContactos.Controls.Add(this.BtnProveedores);
            this.SubContactos.Controls.Add(this.BtnEmpleados);
            this.SubContactos.Controls.Add(this.BtnClientes);
            this.SubContactos.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubContactos.Location = new System.Drawing.Point(0, 360);
            this.SubContactos.Name = "SubContactos";
            this.SubContactos.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.SubContactos.Size = new System.Drawing.Size(212, 135);
            this.SubContactos.TabIndex = 31;
            this.SubContactos.VisibleChanged += new System.EventHandler(this.SubContactos_VisibleChanged);
            // 
            // BtnProveedores
            // 
            this.BtnProveedores.Animated = true;
            this.BtnProveedores.BackColor = System.Drawing.Color.Transparent;
            this.BtnProveedores.CheckedState.Parent = this.BtnProveedores;
            this.BtnProveedores.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnProveedores.CustomImages.Parent = this.BtnProveedores;
            this.BtnProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProveedores.FillColor = System.Drawing.Color.Empty;
            this.BtnProveedores.FillColor2 = System.Drawing.Color.Empty;
            this.BtnProveedores.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProveedores.ForeColor = System.Drawing.Color.White;
            this.BtnProveedores.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.BtnProveedores.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BtnProveedores.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnProveedores.HoverState.Parent = this.BtnProveedores;
            this.BtnProveedores.Image = global::Presentación.Properties.Resources.icons8_supplier_48;
            this.BtnProveedores.ImageOffset = new System.Drawing.Point(-70, 0);
            this.BtnProveedores.Location = new System.Drawing.Point(7, 90);
            this.BtnProveedores.Name = "BtnProveedores";
            this.BtnProveedores.ShadowDecoration.Parent = this.BtnProveedores;
            this.BtnProveedores.Size = new System.Drawing.Size(205, 45);
            this.BtnProveedores.TabIndex = 14;
            this.BtnProveedores.Text = "Proveedores";
            this.BtnProveedores.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnProveedores.TextOffset = new System.Drawing.Point(50, 0);
            this.BtnProveedores.UseTransparentBackground = true;
            this.BtnProveedores.Click += new System.EventHandler(this.SbProveedores_Click);
            // 
            // BtnEmpleados
            // 
            this.BtnEmpleados.Animated = true;
            this.BtnEmpleados.BackColor = System.Drawing.Color.Transparent;
            this.BtnEmpleados.CheckedState.Parent = this.BtnEmpleados;
            this.BtnEmpleados.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnEmpleados.CustomImages.Parent = this.BtnEmpleados;
            this.BtnEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEmpleados.FillColor = System.Drawing.Color.Empty;
            this.BtnEmpleados.FillColor2 = System.Drawing.Color.Empty;
            this.BtnEmpleados.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmpleados.ForeColor = System.Drawing.Color.White;
            this.BtnEmpleados.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.BtnEmpleados.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BtnEmpleados.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnEmpleados.HoverState.Parent = this.BtnEmpleados;
            this.BtnEmpleados.Image = global::Presentación.Properties.Resources.icons8_collaborator_male_48;
            this.BtnEmpleados.ImageOffset = new System.Drawing.Point(-70, 0);
            this.BtnEmpleados.Location = new System.Drawing.Point(7, 45);
            this.BtnEmpleados.Name = "BtnEmpleados";
            this.BtnEmpleados.ShadowDecoration.Parent = this.BtnEmpleados;
            this.BtnEmpleados.Size = new System.Drawing.Size(205, 45);
            this.BtnEmpleados.TabIndex = 13;
            this.BtnEmpleados.Text = "Empleados";
            this.BtnEmpleados.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnEmpleados.TextOffset = new System.Drawing.Point(50, 0);
            this.BtnEmpleados.UseTransparentBackground = true;
            this.BtnEmpleados.Click += new System.EventHandler(this.SbEmpleados_Click);
            // 
            // BtnClientes
            // 
            this.BtnClientes.Animated = true;
            this.BtnClientes.BackColor = System.Drawing.Color.Transparent;
            this.BtnClientes.CheckedState.Parent = this.BtnClientes;
            this.BtnClientes.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnClientes.CustomImages.Parent = this.BtnClientes;
            this.BtnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnClientes.FillColor = System.Drawing.Color.Empty;
            this.BtnClientes.FillColor2 = System.Drawing.Color.Empty;
            this.BtnClientes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClientes.ForeColor = System.Drawing.Color.White;
            this.BtnClientes.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.BtnClientes.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BtnClientes.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnClientes.HoverState.Parent = this.BtnClientes;
            this.BtnClientes.Image = global::Presentación.Properties.Resources.icons8_user_tag_48;
            this.BtnClientes.ImageOffset = new System.Drawing.Point(-70, 0);
            this.BtnClientes.Location = new System.Drawing.Point(7, 0);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.ShadowDecoration.Parent = this.BtnClientes;
            this.BtnClientes.Size = new System.Drawing.Size(205, 45);
            this.BtnClientes.TabIndex = 12;
            this.BtnClientes.Text = "Clientes";
            this.BtnClientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnClientes.TextOffset = new System.Drawing.Point(50, 0);
            this.BtnClientes.UseTransparentBackground = true;
            this.BtnClientes.Click += new System.EventHandler(this.SbClientes_Click);
            // 
            // BtnContactos
            // 
            this.BtnContactos.Animated = true;
            this.BtnContactos.BackColor = System.Drawing.Color.Transparent;
            this.BtnContactos.CheckedState.Parent = this.BtnContactos;
            this.BtnContactos.CustomImages.Image = global::Presentación.Properties.Resources.icons8_sort_down_48;
            this.BtnContactos.CustomImages.Parent = this.BtnContactos;
            this.BtnContactos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnContactos.FillColor = System.Drawing.Color.Empty;
            this.BtnContactos.FillColor2 = System.Drawing.Color.Empty;
            this.BtnContactos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnContactos.ForeColor = System.Drawing.Color.White;
            this.BtnContactos.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.BtnContactos.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BtnContactos.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnContactos.HoverState.Parent = this.BtnContactos;
            this.BtnContactos.Image = global::Presentación.Properties.Resources.icons8_couple_48;
            this.BtnContactos.ImageOffset = new System.Drawing.Point(-70, 0);
            this.BtnContactos.Location = new System.Drawing.Point(0, 315);
            this.BtnContactos.Name = "BtnContactos";
            this.BtnContactos.ShadowDecoration.Parent = this.BtnContactos;
            this.BtnContactos.Size = new System.Drawing.Size(212, 45);
            this.BtnContactos.TabIndex = 29;
            this.BtnContactos.Text = "Contactos";
            this.BtnContactos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnContactos.TextOffset = new System.Drawing.Point(50, 0);
            this.ToolTip.SetToolTip(this.BtnContactos, "Contactos");
            this.BtnContactos.UseTransparentBackground = true;
            this.BtnContactos.Click += new System.EventHandler(this.BtnContactos_Click);
            // 
            // BtnTiendas
            // 
            this.BtnTiendas.Animated = true;
            this.BtnTiendas.BackColor = System.Drawing.Color.Transparent;
            this.BtnTiendas.CheckedState.Parent = this.BtnTiendas;
            this.BtnTiendas.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnTiendas.CustomImages.Parent = this.BtnTiendas;
            this.BtnTiendas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnTiendas.FillColor = System.Drawing.Color.Empty;
            this.BtnTiendas.FillColor2 = System.Drawing.Color.Empty;
            this.BtnTiendas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTiendas.ForeColor = System.Drawing.Color.White;
            this.BtnTiendas.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.BtnTiendas.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BtnTiendas.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnTiendas.HoverState.Parent = this.BtnTiendas;
            this.BtnTiendas.Image = global::Presentación.Properties.Resources.icons8_map_marker_48;
            this.BtnTiendas.ImageOffset = new System.Drawing.Point(-70, 0);
            this.BtnTiendas.Location = new System.Drawing.Point(0, 270);
            this.BtnTiendas.Name = "BtnTiendas";
            this.BtnTiendas.ShadowDecoration.Parent = this.BtnTiendas;
            this.BtnTiendas.Size = new System.Drawing.Size(212, 45);
            this.BtnTiendas.TabIndex = 28;
            this.BtnTiendas.Text = "Tiendas";
            this.BtnTiendas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnTiendas.TextOffset = new System.Drawing.Point(50, 0);
            this.ToolTip.SetToolTip(this.BtnTiendas, "Tiendas");
            this.BtnTiendas.UseTransparentBackground = true;
            this.BtnTiendas.Visible = false;
            this.BtnTiendas.Click += new System.EventHandler(this.SbTiendas_Click);
            // 
            // BtnCajas
            // 
            this.BtnCajas.Animated = true;
            this.BtnCajas.BackColor = System.Drawing.Color.Transparent;
            this.BtnCajas.CheckedState.Parent = this.BtnCajas;
            this.BtnCajas.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnCajas.CustomImages.Parent = this.BtnCajas;
            this.BtnCajas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCajas.FillColor = System.Drawing.Color.Empty;
            this.BtnCajas.FillColor2 = System.Drawing.Color.Empty;
            this.BtnCajas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCajas.ForeColor = System.Drawing.Color.White;
            this.BtnCajas.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.BtnCajas.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BtnCajas.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnCajas.HoverState.Parent = this.BtnCajas;
            this.BtnCajas.Image = global::Presentación.Properties.Resources.icons8_cash_register_48;
            this.BtnCajas.ImageOffset = new System.Drawing.Point(-70, 0);
            this.BtnCajas.Location = new System.Drawing.Point(0, 225);
            this.BtnCajas.Name = "BtnCajas";
            this.BtnCajas.ShadowDecoration.Parent = this.BtnCajas;
            this.BtnCajas.Size = new System.Drawing.Size(212, 45);
            this.BtnCajas.TabIndex = 27;
            this.BtnCajas.Text = "Cajas";
            this.BtnCajas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnCajas.TextOffset = new System.Drawing.Point(50, 0);
            this.ToolTip.SetToolTip(this.BtnCajas, "Cajas");
            this.BtnCajas.UseTransparentBackground = true;
            this.BtnCajas.Click += new System.EventHandler(this.SbCajas_Click);
            // 
            // BtnProductos
            // 
            this.BtnProductos.Animated = true;
            this.BtnProductos.BackColor = System.Drawing.Color.Transparent;
            this.BtnProductos.CheckedState.Parent = this.BtnProductos;
            this.BtnProductos.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnProductos.CustomImages.Parent = this.BtnProductos;
            this.BtnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProductos.FillColor = System.Drawing.Color.Empty;
            this.BtnProductos.FillColor2 = System.Drawing.Color.Empty;
            this.BtnProductos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProductos.ForeColor = System.Drawing.Color.White;
            this.BtnProductos.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.BtnProductos.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BtnProductos.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnProductos.HoverState.Parent = this.BtnProductos;
            this.BtnProductos.Image = global::Presentación.Properties.Resources.icons8_ingredients_48;
            this.BtnProductos.ImageOffset = new System.Drawing.Point(-70, 0);
            this.BtnProductos.Location = new System.Drawing.Point(0, 180);
            this.BtnProductos.Name = "BtnProductos";
            this.BtnProductos.ShadowDecoration.Parent = this.BtnProductos;
            this.BtnProductos.Size = new System.Drawing.Size(212, 45);
            this.BtnProductos.TabIndex = 26;
            this.BtnProductos.Text = "Productos";
            this.BtnProductos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnProductos.TextOffset = new System.Drawing.Point(50, 0);
            this.ToolTip.SetToolTip(this.BtnProductos, "Productos");
            this.BtnProductos.UseTransparentBackground = true;
            this.BtnProductos.Click += new System.EventHandler(this.SbProductos_Click);
            // 
            // BtnMovimientos
            // 
            this.BtnMovimientos.Animated = true;
            this.BtnMovimientos.BackColor = System.Drawing.Color.Transparent;
            this.BtnMovimientos.CheckedState.Parent = this.BtnMovimientos;
            this.BtnMovimientos.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnMovimientos.CustomImages.Parent = this.BtnMovimientos;
            this.BtnMovimientos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnMovimientos.FillColor = System.Drawing.Color.Empty;
            this.BtnMovimientos.FillColor2 = System.Drawing.Color.Empty;
            this.BtnMovimientos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMovimientos.ForeColor = System.Drawing.Color.White;
            this.BtnMovimientos.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.BtnMovimientos.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.BtnMovimientos.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnMovimientos.HoverState.Parent = this.BtnMovimientos;
            this.BtnMovimientos.Image = global::Presentación.Properties.Resources.icons8_locker_48;
            this.BtnMovimientos.ImageOffset = new System.Drawing.Point(-70, 0);
            this.BtnMovimientos.Location = new System.Drawing.Point(0, 135);
            this.BtnMovimientos.Name = "BtnMovimientos";
            this.BtnMovimientos.ShadowDecoration.Parent = this.BtnMovimientos;
            this.BtnMovimientos.Size = new System.Drawing.Size(212, 45);
            this.BtnMovimientos.TabIndex = 25;
            this.BtnMovimientos.Text = "Movimientos";
            this.BtnMovimientos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnMovimientos.TextOffset = new System.Drawing.Point(50, 0);
            this.ToolTip.SetToolTip(this.BtnMovimientos, "Movimientos");
            this.BtnMovimientos.UseTransparentBackground = true;
            this.BtnMovimientos.Click += new System.EventHandler(this.SbMovimientos_Click);
            // 
            // BtnInventarios
            // 
            this.BtnInventarios.Animated = true;
            this.BtnInventarios.BackColor = System.Drawing.Color.Transparent;
            this.BtnInventarios.CheckedState.Parent = this.BtnInventarios;
            this.BtnInventarios.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnInventarios.CustomImages.Parent = this.BtnInventarios;
            this.BtnInventarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnInventarios.FillColor = System.Drawing.Color.Empty;
            this.BtnInventarios.FillColor2 = System.Drawing.Color.Empty;
            this.BtnInventarios.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInventarios.ForeColor = System.Drawing.Color.White;
            this.BtnInventarios.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.BtnInventarios.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.BtnInventarios.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnInventarios.HoverState.Parent = this.BtnInventarios;
            this.BtnInventarios.Image = global::Presentación.Properties.Resources.icons8_warehouse_48;
            this.BtnInventarios.ImageOffset = new System.Drawing.Point(-70, 0);
            this.BtnInventarios.Location = new System.Drawing.Point(0, 90);
            this.BtnInventarios.Name = "BtnInventarios";
            this.BtnInventarios.ShadowDecoration.Parent = this.BtnInventarios;
            this.BtnInventarios.Size = new System.Drawing.Size(212, 45);
            this.BtnInventarios.TabIndex = 24;
            this.BtnInventarios.Text = "Inventarios";
            this.BtnInventarios.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnInventarios.TextOffset = new System.Drawing.Point(50, 0);
            this.ToolTip.SetToolTip(this.BtnInventarios, "Inventarios");
            this.BtnInventarios.UseTransparentBackground = true;
            this.BtnInventarios.Click += new System.EventHandler(this.SbInventario_Click);
            // 
            // BtnVentas
            // 
            this.BtnVentas.Animated = true;
            this.BtnVentas.BackColor = System.Drawing.Color.Transparent;
            this.BtnVentas.CheckedState.Parent = this.BtnVentas;
            this.BtnVentas.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnVentas.CustomImages.Parent = this.BtnVentas;
            this.BtnVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnVentas.FillColor = System.Drawing.Color.Empty;
            this.BtnVentas.FillColor2 = System.Drawing.Color.Empty;
            this.BtnVentas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVentas.ForeColor = System.Drawing.Color.White;
            this.BtnVentas.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.BtnVentas.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.BtnVentas.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnVentas.HoverState.Parent = this.BtnVentas;
            this.BtnVentas.Image = global::Presentación.Properties.Resources.icons8_shopping_basket_48;
            this.BtnVentas.ImageOffset = new System.Drawing.Point(-70, 0);
            this.BtnVentas.Location = new System.Drawing.Point(0, 45);
            this.BtnVentas.Name = "BtnVentas";
            this.BtnVentas.ShadowDecoration.Parent = this.BtnVentas;
            this.BtnVentas.Size = new System.Drawing.Size(212, 45);
            this.BtnVentas.TabIndex = 23;
            this.BtnVentas.Text = "Ventas";
            this.BtnVentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnVentas.TextOffset = new System.Drawing.Point(50, 0);
            this.ToolTip.SetToolTip(this.BtnVentas, "Ventas");
            this.BtnVentas.UseTransparentBackground = true;
            this.BtnVentas.Click += new System.EventHandler(this.SbVentas_Click);
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.Animated = true;
            this.BtnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.BtnDashboard.CheckedState.Parent = this.BtnDashboard;
            this.BtnDashboard.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnDashboard.CustomImages.Parent = this.BtnDashboard;
            this.BtnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.BtnDashboard.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.BtnDashboard.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDashboard.ForeColor = System.Drawing.Color.White;
            this.BtnDashboard.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.BtnDashboard.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.BtnDashboard.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnDashboard.HoverState.Parent = this.BtnDashboard;
            this.BtnDashboard.Image = global::Presentación.Properties.Resources.icons8_dashboard;
            this.BtnDashboard.ImageOffset = new System.Drawing.Point(-70, 0);
            this.BtnDashboard.Location = new System.Drawing.Point(0, 0);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.ShadowDecoration.Parent = this.BtnDashboard;
            this.BtnDashboard.Size = new System.Drawing.Size(212, 45);
            this.BtnDashboard.TabIndex = 32;
            this.BtnDashboard.Text = "Panel de Datos";
            this.BtnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnDashboard.TextOffset = new System.Drawing.Point(50, 0);
            this.ToolTip.SetToolTip(this.BtnDashboard, "Panel de Datos");
            this.BtnDashboard.UseTransparentBackground = true;
            this.BtnDashboard.Click += new System.EventHandler(this.SbDashboard_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1264, 40);
            this.panelControl1.TabIndex = 2;
            this.panelControl1.Visible = false;
            // 
            // dockPanel2
            // 
            this.dockPanel2.Controls.Add(this.dockPanel2_Container);
            this.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.dockPanel2.ID = new System.Guid("bebb3c97-d76f-487a-966e-2b690c4af077");
            this.dockPanel2.Location = new System.Drawing.Point(1064, 0);
            this.dockPanel2.Name = "dockPanel2";
            this.dockPanel2.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel2.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.dockPanel2.SavedIndex = 0;
            this.dockPanel2.Size = new System.Drawing.Size(200, 681);
            this.dockPanel2.Text = "dockPanel2";
            this.dockPanel2.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            // 
            // dockPanel2_Container
            // 
            this.dockPanel2_Container.Location = new System.Drawing.Point(4, 46);
            this.dockPanel2_Container.Name = "dockPanel2_Container";
            this.dockPanel2_Container.Size = new System.Drawing.Size(193, 632);
            this.dockPanel2_Container.TabIndex = 0;
            // 
            // SideMenu
            // 
            this.SideMenu.AutoScroll = true;
            this.SideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.SideMenu.Controls.Add(this.DivNav);
            this.SideMenu.Controls.Add(this.BtnShowAgain);
            this.SideMenu.Controls.Add(this.DivFooter);
            this.SideMenu.Controls.Add(this.DivHeader);
            this.SideMenu.Controls.Add(this.SbCerrarSesion);
            this.SideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMenu.Location = new System.Drawing.Point(0, 40);
            this.SideMenu.Name = "SideMenu";
            this.SideMenu.Size = new System.Drawing.Size(229, 641);
            this.SideMenu.TabIndex = 4;
            // 
            // BtnShowAgain
            // 
            this.BtnShowAgain.BackColor = System.Drawing.Color.Transparent;
            this.BtnShowAgain.BorderColor = System.Drawing.Color.Silver;
            this.BtnShowAgain.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.BtnShowAgain.CheckedState.Parent = this.BtnShowAgain;
            this.BtnShowAgain.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnShowAgain.CustomImages.Parent = this.BtnShowAgain;
            this.BtnShowAgain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnShowAgain.FillColor = System.Drawing.Color.Empty;
            this.BtnShowAgain.FillColor2 = System.Drawing.Color.Empty;
            this.BtnShowAgain.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnShowAgain.ForeColor = System.Drawing.Color.White;
            this.BtnShowAgain.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.BtnShowAgain.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.BtnShowAgain.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.BtnShowAgain.HoverState.Parent = this.BtnShowAgain;
            this.BtnShowAgain.Image = global::Presentación.Properties.Resources.forward_400px;
            this.BtnShowAgain.Location = new System.Drawing.Point(0, 499);
            this.BtnShowAgain.Name = "BtnShowAgain";
            this.BtnShowAgain.ShadowDecoration.Parent = this.BtnShowAgain;
            this.BtnShowAgain.Size = new System.Drawing.Size(229, 45);
            this.BtnShowAgain.TabIndex = 13;
            this.ToolTip.SetToolTip(this.BtnShowAgain, "Expandir Menu");
            this.BtnShowAgain.UseTransparentBackground = true;
            this.BtnShowAgain.Visible = false;
            this.BtnShowAgain.Click += new System.EventHandler(this.PicLogo_Click);
            // 
            // DivFooter
            // 
            this.DivFooter.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.DivFooter.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.DivFooter.Appearance.Options.UseBackColor = true;
            this.DivFooter.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.DivFooter.Controls.Add(this.guna2Separator1);
            this.DivFooter.Controls.Add(this.BtnConfiguracion);
            this.DivFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DivFooter.Location = new System.Drawing.Point(0, 544);
            this.DivFooter.Name = "DivFooter";
            this.DivFooter.Size = new System.Drawing.Size(229, 52);
            this.DivFooter.TabIndex = 12;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Separator1.FillColor = System.Drawing.Color.Gray;
            this.guna2Separator1.Location = new System.Drawing.Point(0, -3);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(229, 10);
            this.guna2Separator1.TabIndex = 7;
            // 
            // BtnConfiguracion
            // 
            this.BtnConfiguracion.Animated = true;
            this.BtnConfiguracion.BackColor = System.Drawing.Color.Transparent;
            this.BtnConfiguracion.CheckedState.Parent = this.BtnConfiguracion;
            this.BtnConfiguracion.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnConfiguracion.CustomImages.Parent = this.BtnConfiguracion;
            this.BtnConfiguracion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnConfiguracion.FillColor = System.Drawing.Color.Empty;
            this.BtnConfiguracion.FillColor2 = System.Drawing.Color.Empty;
            this.BtnConfiguracion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnConfiguracion.ForeColor = System.Drawing.Color.White;
            this.BtnConfiguracion.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.BtnConfiguracion.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.BtnConfiguracion.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.BtnConfiguracion.HoverState.Parent = this.BtnConfiguracion;
            this.BtnConfiguracion.Image = global::Presentación.Properties.Resources.icons8_settings_48;
            this.BtnConfiguracion.Location = new System.Drawing.Point(0, 7);
            this.BtnConfiguracion.Name = "BtnConfiguracion";
            this.BtnConfiguracion.ShadowDecoration.Parent = this.BtnConfiguracion;
            this.BtnConfiguracion.Size = new System.Drawing.Size(229, 45);
            this.BtnConfiguracion.TabIndex = 8;
            this.BtnConfiguracion.Text = "Configuración";
            this.ToolTip.SetToolTip(this.BtnConfiguracion, "Configuración");
            this.BtnConfiguracion.UseTransparentBackground = true;
            this.BtnConfiguracion.Click += new System.EventHandler(this.SbConfiguracion_Click);
            // 
            // DivHeader
            // 
            this.DivHeader.Controls.Add(this.PicLogo);
            this.DivHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.DivHeader.Location = new System.Drawing.Point(0, 0);
            this.DivHeader.Name = "DivHeader";
            this.DivHeader.Size = new System.Drawing.Size(229, 140);
            this.DivHeader.TabIndex = 11;
            // 
            // PicLogo
            // 
            this.PicLogo.Image = global::Presentación.Properties.Resources.UK_company_database;
            this.PicLogo.Location = new System.Drawing.Point(38, 12);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(133, 103);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicLogo.TabIndex = 1;
            this.PicLogo.TabStop = false;
            this.ToolTip.SetToolTip(this.PicLogo, "Contraer Menu");
            this.PicLogo.Click += new System.EventHandler(this.PicLogo_Click);
            // 
            // SbCerrarSesion
            // 
            this.SbCerrarSesion.Animated = true;
            this.SbCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.SbCerrarSesion.CheckedState.Parent = this.SbCerrarSesion;
            this.SbCerrarSesion.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SbCerrarSesion.CustomImages.Parent = this.SbCerrarSesion;
            this.SbCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SbCerrarSesion.FillColor = System.Drawing.Color.Empty;
            this.SbCerrarSesion.FillColor2 = System.Drawing.Color.Empty;
            this.SbCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SbCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.SbCerrarSesion.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.SbCerrarSesion.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.SbCerrarSesion.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.SbCerrarSesion.HoverState.Parent = this.SbCerrarSesion;
            this.SbCerrarSesion.Image = global::Presentación.Properties.Resources.icons8_settings_48;
            this.SbCerrarSesion.Location = new System.Drawing.Point(0, 596);
            this.SbCerrarSesion.Name = "SbCerrarSesion";
            this.SbCerrarSesion.ShadowDecoration.Parent = this.SbCerrarSesion;
            this.SbCerrarSesion.Size = new System.Drawing.Size(229, 45);
            this.SbCerrarSesion.TabIndex = 14;
            this.SbCerrarSesion.Text = "CerrarSesion";
            this.ToolTip.SetToolTip(this.SbCerrarSesion, "Configuración");
            this.SbCerrarSesion.UseTransparentBackground = true;
            this.SbCerrarSesion.Visible = false;
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
            // documentManager1
            // 
            this.documentManager1.ContainerControl = this;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            this.documentManager1.DocumentActivate += new DevExpress.XtraBars.Docking2010.Views.DocumentEventHandler(this.DocumentManager1_DocumentActivate);
            // 
            // flyNotify1
            // 
            this.flyNotify1.Controls.Add(this.guna2GradientButton1);
            this.flyNotify1.Controls.Add(this.guna2GradientButton2);
            this.flyNotify1.Controls.Add(this.guna2GradientButton3);
            this.flyNotify1.Controls.Add(this.flyoutPanelControl1);
            this.flyNotify1.Location = new System.Drawing.Point(235, 328);
            this.flyNotify1.Name = "flyNotify1";
            this.flyNotify1.OptionsBeakPanel.BeakLocation = DevExpress.Utils.BeakPanelBeakLocation.Left;
            this.flyNotify1.OptionsButtonPanel.ButtonPanelHeight = 60;
            this.flyNotify1.OwnerControl = this.BtnContactos;
            this.flyNotify1.Size = new System.Drawing.Size(207, 135);
            this.flyNotify1.TabIndex = 5;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.Animated = true;
            this.guna2GradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientButton1.FillColor = System.Drawing.Color.Empty;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.Empty;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.guna2GradientButton1.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.guna2GradientButton1.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Image = global::Presentación.Properties.Resources.icons8_supplier_48;
            this.guna2GradientButton1.ImageOffset = new System.Drawing.Point(-70, 0);
            this.guna2GradientButton1.Location = new System.Drawing.Point(0, 90);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(207, 45);
            this.guna2GradientButton1.TabIndex = 17;
            this.guna2GradientButton1.Text = "Proveedores";
            this.guna2GradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton1.TextOffset = new System.Drawing.Point(50, 0);
            this.guna2GradientButton1.UseTransparentBackground = true;
            this.guna2GradientButton1.Click += new System.EventHandler(this.SbProveedores_Click);
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.Animated = true;
            this.guna2GradientButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton2.CheckedState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton2.CustomImages.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientButton2.FillColor = System.Drawing.Color.Empty;
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.Empty;
            this.guna2GradientButton2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.guna2GradientButton2.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.guna2GradientButton2.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.guna2GradientButton2.HoverState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Image = global::Presentación.Properties.Resources.icons8_collaborator_male_48;
            this.guna2GradientButton2.ImageOffset = new System.Drawing.Point(-70, 0);
            this.guna2GradientButton2.Location = new System.Drawing.Point(0, 45);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.ShadowDecoration.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Size = new System.Drawing.Size(207, 45);
            this.guna2GradientButton2.TabIndex = 16;
            this.guna2GradientButton2.Text = "Empleados";
            this.guna2GradientButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton2.TextOffset = new System.Drawing.Point(50, 0);
            this.guna2GradientButton2.UseTransparentBackground = true;
            this.guna2GradientButton2.Click += new System.EventHandler(this.SbEmpleados_Click);
            // 
            // guna2GradientButton3
            // 
            this.guna2GradientButton3.Animated = true;
            this.guna2GradientButton3.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton3.CheckedState.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton3.CustomImages.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientButton3.FillColor = System.Drawing.Color.Empty;
            this.guna2GradientButton3.FillColor2 = System.Drawing.Color.Empty;
            this.guna2GradientButton3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.guna2GradientButton3.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton3.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.guna2GradientButton3.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.guna2GradientButton3.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.guna2GradientButton3.HoverState.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.Image = global::Presentación.Properties.Resources.icons8_user_tag_48;
            this.guna2GradientButton3.ImageOffset = new System.Drawing.Point(-70, 0);
            this.guna2GradientButton3.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientButton3.Name = "guna2GradientButton3";
            this.guna2GradientButton3.ShadowDecoration.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.Size = new System.Drawing.Size(207, 45);
            this.guna2GradientButton3.TabIndex = 15;
            this.guna2GradientButton3.Text = "Clientes";
            this.guna2GradientButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton3.TextOffset = new System.Drawing.Point(50, 0);
            this.guna2GradientButton3.UseTransparentBackground = true;
            this.guna2GradientButton3.Click += new System.EventHandler(this.SbClientes_Click);
            // 
            // flyoutPanelControl1
            // 
            this.flyoutPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flyoutPanelControl1.FlyoutPanel = this.flyNotify1;
            this.flyoutPanelControl1.Location = new System.Drawing.Point(0, 0);
            this.flyoutPanelControl1.Name = "flyoutPanelControl1";
            this.flyoutPanelControl1.Size = new System.Drawing.Size(207, 135);
            this.flyoutPanelControl1.TabIndex = 1;
            // 
            // ToolTip
            // 
            this.ToolTip.AllowLinksHandling = true;
            this.ToolTip.AutoPopDelay = 2500;
            this.ToolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ToolTip.BorderColor = System.Drawing.Color.Silver;
            this.ToolTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ToolTip.InitialDelay = 6000;
            this.ToolTip.MaximumSize = new System.Drawing.Size(0, 0);
            this.ToolTip.ReshowDelay = 100;
            // 
            // MenuV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.flyNotify1);
            this.Controls.Add(this.SideMenu);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.Image = global::Presentación.Properties.Resources.icons8_online_shop_shopping_bag_96;
            this.Name = "MenuV2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Inventarios y Ventas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.DivNav.ResumeLayout(false);
            this.SubContactos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.dockPanel2.ResumeLayout(false);
            this.SideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DivFooter)).EndInit();
            this.DivFooter.ResumeLayout(false);
            this.DivHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyNotify1)).EndInit();
            this.flyNotify1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Navigation.AccordionControlElement SbCreditos;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel2;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
        private Panel SideMenu;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private Panel DivHeader;
        private PictureBox PicLogo;
        private DevExpress.XtraEditors.PanelControl DivFooter;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2GradientButton BtnConfiguracion;
        private DevExpress.XtraEditors.XtraScrollableControl DivNav;
        private Guna.UI2.WinForms.Guna2GradientButton BtnDashboard;
        private Guna.UI2.WinForms.Guna2GradientButton BtnAyuda;
        private Guna.UI2.WinForms.Guna2GradientButton BtnVentas;
        private Guna.UI2.WinForms.Guna2GradientButton BtnContactos;
        private Guna.UI2.WinForms.Guna2GradientButton BtnInventarios;
        private Guna.UI2.WinForms.Guna2GradientButton BtnTiendas;
        private Guna.UI2.WinForms.Guna2GradientButton BtnMovimientos;
        private Guna.UI2.WinForms.Guna2GradientButton BtnCajas;
        private Guna.UI2.WinForms.Guna2GradientButton BtnProductos;
        private Guna.UI2.WinForms.Guna2GradientButton BtnCreditos;
        private Panel SubContactos;
        private Guna.UI2.WinForms.Guna2GradientButton BtnProveedores;
        private Guna.UI2.WinForms.Guna2GradientButton BtnEmpleados;
        private Guna.UI2.WinForms.Guna2GradientButton BtnClientes;
        private Guna.UI2.WinForms.Guna2GradientButton BtnShowAgain;
        private Principal.Admin.FlyNotify flyNotify1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton3;
        private DevExpress.Utils.FlyoutPanelControl flyoutPanelControl1;
        private Guna.UI2.WinForms.Guna2HtmlToolTip ToolTip;
        public Guna.UI2.WinForms.Guna2GradientButton SbCerrarSesion;
    }
}

