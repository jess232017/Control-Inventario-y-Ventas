
namespace Presentación.Forms.Credito
{
    partial class Forma_Abono
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
            this.lbAbona = new System.Windows.Forms.Label();
            this.TabMxin = new DevExpress.XtraBars.Navigation.TabPane();
            this.TabEfectivo = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPagoCor = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCambioEfectivo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtAbona = new Guna.UI2.WinForms.Guna2TextBox();
            this.TabMixto = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtAbona3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtCambioMixto = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtDolarMixto = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtEfectivoMixto = new Guna.UI2.WinForms.Guna2TextBox();
            this.TabDolares = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtAbonaDolar = new Guna.UI2.WinForms.Guna2TextBox();
            this.LbTipChange = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtCambioDolar = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtEquivDolar = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPagoDolar = new Guna.UI2.WinForms.Guna2TextBox();
            this.PlMain = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LbSaldo = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.BtnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.BtnSoloAbonar = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAbonar = new Guna.UI2.WinForms.Guna2Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TabMxin)).BeginInit();
            this.TabMxin.SuspendLayout();
            this.TabEfectivo.SuspendLayout();
            this.TabMixto.SuspendLayout();
            this.panel1.SuspendLayout();
            this.TabDolares.SuspendLayout();
            this.PlMain.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAbona
            // 
            this.lbAbona.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbAbona.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAbona.ForeColor = System.Drawing.Color.White;
            this.lbAbona.Location = new System.Drawing.Point(10, 0);
            this.lbAbona.Name = "lbAbona";
            this.lbAbona.Size = new System.Drawing.Size(583, 58);
            this.lbAbona.TabIndex = 90;
            this.lbAbona.Text = "C$ 0";
            this.lbAbona.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TabMxin
            // 
            this.TabMxin.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.TabMxin.Appearance.Options.UseBorderColor = true;
            this.TabMxin.Controls.Add(this.TabEfectivo);
            this.TabMxin.Controls.Add(this.TabMixto);
            this.TabMxin.Controls.Add(this.TabDolares);
            this.TabMxin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabMxin.Location = new System.Drawing.Point(0, 0);
            this.TabMxin.Name = "TabMxin";
            this.TabMxin.PageProperties.AppearanceCaption.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.TabMxin.PageProperties.AppearanceCaption.Options.UseBorderColor = true;
            this.TabMxin.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.TabMxin.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.TabEfectivo,
            this.TabDolares,
            this.TabMixto});
            this.TabMxin.RegularSize = new System.Drawing.Size(581, 371);
            this.TabMxin.SelectedPage = this.TabEfectivo;
            this.TabMxin.Size = new System.Drawing.Size(581, 371);
            this.TabMxin.TabIndex = 92;
            this.TabMxin.Text = "tabPane1";
            this.TabMxin.SelectedPageChanged += new DevExpress.XtraBars.Navigation.SelectedPageChangedEventHandler(this.TabMxin_SelectedPageChanged);
            // 
            // TabEfectivo
            // 
            this.TabEfectivo.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabEfectivo.Appearance.Options.UseFont = true;
            this.TabEfectivo.Caption = "Efectivo";
            this.TabEfectivo.Controls.Add(this.label3);
            this.TabEfectivo.Controls.Add(this.TxtPagoCor);
            this.TabEfectivo.Controls.Add(this.label2);
            this.TabEfectivo.Controls.Add(this.TxtCambioEfectivo);
            this.TabEfectivo.Controls.Add(this.label1);
            this.TabEfectivo.Controls.Add(this.TxtAbona);
            this.TabEfectivo.ImageOptions.Image = global::Presentación.Properties.Resources.icons8_cash_40;
            this.TabEfectivo.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.TabEfectivo.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.TabEfectivo.Name = "TabEfectivo";
            this.TabEfectivo.Properties.AppearanceCaption.Options.UseImage = true;
            this.TabEfectivo.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.TabEfectivo.Size = new System.Drawing.Size(581, 324);
            this.TabEfectivo.Tag = "0";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(92, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pagó Con:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtPagoCor
            // 
            this.TxtPagoCor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPagoCor.BackColor = System.Drawing.Color.White;
            this.TxtPagoCor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtPagoCor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPagoCor.DefaultText = "";
            this.TxtPagoCor.DisabledState.Parent = this.TxtPagoCor;
            this.TxtPagoCor.FocusedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.TxtPagoCor.FocusedState.Parent = this.TxtPagoCor;
            this.TxtPagoCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TxtPagoCor.ForeColor = System.Drawing.Color.Black;
            this.TxtPagoCor.HoverState.Parent = this.TxtPagoCor;
            this.TxtPagoCor.Location = new System.Drawing.Point(228, 131);
            this.TxtPagoCor.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.TxtPagoCor.Name = "TxtPagoCor";
            this.TxtPagoCor.PasswordChar = '\0';
            this.TxtPagoCor.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtPagoCor.PlaceholderText = "C$ -";
            this.TxtPagoCor.SelectedText = "";
            this.TxtPagoCor.ShadowDecoration.Parent = this.TxtPagoCor;
            this.TxtPagoCor.Size = new System.Drawing.Size(208, 32);
            this.TxtPagoCor.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TxtPagoCor.TabIndex = 6;
            this.TxtPagoCor.TextChanged += new System.EventHandler(this.TxtPagoCor_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(122, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Su Cambio:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtCambioEfectivo
            // 
            this.TxtCambioEfectivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCambioEfectivo.BackColor = System.Drawing.Color.White;
            this.TxtCambioEfectivo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtCambioEfectivo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCambioEfectivo.DefaultText = "";
            this.TxtCambioEfectivo.DisabledState.Parent = this.TxtCambioEfectivo;
            this.TxtCambioEfectivo.FocusedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.TxtCambioEfectivo.FocusedState.Parent = this.TxtCambioEfectivo;
            this.TxtCambioEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TxtCambioEfectivo.ForeColor = System.Drawing.Color.Black;
            this.TxtCambioEfectivo.HoverState.Parent = this.TxtCambioEfectivo;
            this.TxtCambioEfectivo.Location = new System.Drawing.Point(228, 193);
            this.TxtCambioEfectivo.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.TxtCambioEfectivo.Name = "TxtCambioEfectivo";
            this.TxtCambioEfectivo.PasswordChar = '\0';
            this.TxtCambioEfectivo.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtCambioEfectivo.PlaceholderText = "C$ -";
            this.TxtCambioEfectivo.ReadOnly = true;
            this.TxtCambioEfectivo.SelectedText = "";
            this.TxtCambioEfectivo.ShadowDecoration.Parent = this.TxtCambioEfectivo;
            this.TxtCambioEfectivo.Size = new System.Drawing.Size(208, 32);
            this.TxtCambioEfectivo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TxtCambioEfectivo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(92, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Abona:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtAbona
            // 
            this.TxtAbona.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtAbona.BackColor = System.Drawing.Color.White;
            this.TxtAbona.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtAbona.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtAbona.DefaultText = "";
            this.TxtAbona.DisabledState.Parent = this.TxtAbona;
            this.TxtAbona.FocusedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.TxtAbona.FocusedState.Parent = this.TxtAbona;
            this.TxtAbona.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TxtAbona.ForeColor = System.Drawing.Color.Black;
            this.TxtAbona.HoverState.Parent = this.TxtAbona;
            this.TxtAbona.Location = new System.Drawing.Point(228, 69);
            this.TxtAbona.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.TxtAbona.Name = "TxtAbona";
            this.TxtAbona.PasswordChar = '\0';
            this.TxtAbona.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtAbona.PlaceholderText = "C$ -";
            this.TxtAbona.SelectedText = "";
            this.TxtAbona.ShadowDecoration.Parent = this.TxtAbona;
            this.TxtAbona.Size = new System.Drawing.Size(208, 32);
            this.TxtAbona.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TxtAbona.TabIndex = 2;
            this.TxtAbona.Tag = "C$";
            this.TxtAbona.TextChanged += new System.EventHandler(this.TxtAbona_TextChanged);
            // 
            // TabMixto
            // 
            this.TabMixto.Caption = "Mixto";
            this.TabMixto.Controls.Add(this.panel1);
            this.TabMixto.ImageOptions.Image = global::Presentación.Properties.Resources.icons8_buy_for_cash_40;
            this.TabMixto.ImageOptions.SvgImageSize = new System.Drawing.Size(10, 10);
            this.TabMixto.Name = "TabMixto";
            this.TabMixto.Padding = new System.Windows.Forms.Padding(30, 25, 30, 25);
            this.TabMixto.PageVisible = false;
            this.TabMixto.Properties.AppearanceCaption.Options.UseImage = true;
            this.TabMixto.Size = new System.Drawing.Size(581, 324);
            this.TabMixto.Tag = "2";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.TxtAbona3);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.TxtCambioMixto);
            this.panel1.Controls.Add(this.guna2Separator1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.TxtDolarMixto);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.TxtEfectivoMixto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(30, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 274);
            this.panel1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(66, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 32);
            this.label9.TabIndex = 32;
            this.label9.Text = "Abona:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtAbona3
            // 
            this.TxtAbona3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtAbona3.BackColor = System.Drawing.Color.White;
            this.TxtAbona3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtAbona3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtAbona3.DefaultText = "";
            this.TxtAbona3.DisabledState.Parent = this.TxtAbona3;
            this.TxtAbona3.FocusedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.TxtAbona3.FocusedState.Parent = this.TxtAbona3;
            this.TxtAbona3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TxtAbona3.ForeColor = System.Drawing.Color.Black;
            this.TxtAbona3.HoverState.Parent = this.TxtAbona3;
            this.TxtAbona3.Location = new System.Drawing.Point(172, 17);
            this.TxtAbona3.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.TxtAbona3.Name = "TxtAbona3";
            this.TxtAbona3.PasswordChar = '\0';
            this.TxtAbona3.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtAbona3.PlaceholderText = "C$ 0";
            this.TxtAbona3.SelectedText = "";
            this.TxtAbona3.ShadowDecoration.Parent = this.TxtAbona3;
            this.TxtAbona3.Size = new System.Drawing.Size(267, 32);
            this.TxtAbona3.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TxtAbona3.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(25, 219);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(141, 32);
            this.label13.TabIndex = 30;
            this.label13.Text = "Su Cambio:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtCambioMixto
            // 
            this.TxtCambioMixto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCambioMixto.BackColor = System.Drawing.Color.White;
            this.TxtCambioMixto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtCambioMixto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCambioMixto.DefaultText = "";
            this.TxtCambioMixto.DisabledState.Parent = this.TxtCambioMixto;
            this.TxtCambioMixto.FocusedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.TxtCambioMixto.FocusedState.Parent = this.TxtCambioMixto;
            this.TxtCambioMixto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TxtCambioMixto.ForeColor = System.Drawing.Color.Black;
            this.TxtCambioMixto.HoverState.Parent = this.TxtCambioMixto;
            this.TxtCambioMixto.Location = new System.Drawing.Point(172, 219);
            this.TxtCambioMixto.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.TxtCambioMixto.Name = "TxtCambioMixto";
            this.TxtCambioMixto.PasswordChar = '\0';
            this.TxtCambioMixto.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtCambioMixto.PlaceholderText = "C$ 0";
            this.TxtCambioMixto.ReadOnly = true;
            this.TxtCambioMixto.SelectedText = "";
            this.TxtCambioMixto.ShadowDecoration.Parent = this.TxtCambioMixto;
            this.TxtCambioMixto.Size = new System.Drawing.Size(267, 32);
            this.TxtCambioMixto.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TxtCambioMixto.TabIndex = 29;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(172, 191);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(267, 10);
            this.guna2Separator1.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(25, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 32);
            this.label10.TabIndex = 27;
            this.label10.Text = "Dólares:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtDolarMixto
            // 
            this.TxtDolarMixto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDolarMixto.BackColor = System.Drawing.Color.White;
            this.TxtDolarMixto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtDolarMixto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtDolarMixto.DefaultText = "";
            this.TxtDolarMixto.DisabledState.Parent = this.TxtDolarMixto;
            this.TxtDolarMixto.FocusedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.TxtDolarMixto.FocusedState.Parent = this.TxtDolarMixto;
            this.TxtDolarMixto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TxtDolarMixto.ForeColor = System.Drawing.Color.Black;
            this.TxtDolarMixto.HoverState.Parent = this.TxtDolarMixto;
            this.TxtDolarMixto.Location = new System.Drawing.Point(172, 141);
            this.TxtDolarMixto.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.TxtDolarMixto.Name = "TxtDolarMixto";
            this.TxtDolarMixto.PasswordChar = '\0';
            this.TxtDolarMixto.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtDolarMixto.PlaceholderText = "C$ 0";
            this.TxtDolarMixto.SelectedText = "";
            this.TxtDolarMixto.ShadowDecoration.Parent = this.TxtDolarMixto;
            this.TxtDolarMixto.Size = new System.Drawing.Size(267, 32);
            this.TxtDolarMixto.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TxtDolarMixto.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(66, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 32);
            this.label12.TabIndex = 25;
            this.label12.Text = "Efectivo:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtEfectivoMixto
            // 
            this.TxtEfectivoMixto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtEfectivoMixto.BackColor = System.Drawing.Color.White;
            this.TxtEfectivoMixto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtEfectivoMixto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtEfectivoMixto.DefaultText = "";
            this.TxtEfectivoMixto.DisabledState.Parent = this.TxtEfectivoMixto;
            this.TxtEfectivoMixto.FocusedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.TxtEfectivoMixto.FocusedState.Parent = this.TxtEfectivoMixto;
            this.TxtEfectivoMixto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TxtEfectivoMixto.ForeColor = System.Drawing.Color.Black;
            this.TxtEfectivoMixto.HoverState.Parent = this.TxtEfectivoMixto;
            this.TxtEfectivoMixto.Location = new System.Drawing.Point(172, 79);
            this.TxtEfectivoMixto.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.TxtEfectivoMixto.Name = "TxtEfectivoMixto";
            this.TxtEfectivoMixto.PasswordChar = '\0';
            this.TxtEfectivoMixto.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtEfectivoMixto.PlaceholderText = "$ 0";
            this.TxtEfectivoMixto.SelectedText = "";
            this.TxtEfectivoMixto.ShadowDecoration.Parent = this.TxtEfectivoMixto;
            this.TxtEfectivoMixto.Size = new System.Drawing.Size(267, 32);
            this.TxtEfectivoMixto.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TxtEfectivoMixto.TabIndex = 24;
            // 
            // TabDolares
            // 
            this.TabDolares.Caption = "Dólares";
            this.TabDolares.Controls.Add(this.label8);
            this.TabDolares.Controls.Add(this.TxtAbonaDolar);
            this.TabDolares.Controls.Add(this.LbTipChange);
            this.TabDolares.Controls.Add(this.label7);
            this.TabDolares.Controls.Add(this.TxtCambioDolar);
            this.TabDolares.Controls.Add(this.label6);
            this.TabDolares.Controls.Add(this.label4);
            this.TabDolares.Controls.Add(this.TxtEquivDolar);
            this.TabDolares.Controls.Add(this.label5);
            this.TabDolares.Controls.Add(this.TxtPagoDolar);
            this.TabDolares.ImageOptions.Image = global::Presentación.Properties.Resources.icons8_stack_of_money_40;
            this.TabDolares.Name = "TabDolares";
            this.TabDolares.Size = new System.Drawing.Size(581, 324);
            this.TabDolares.Tag = "1";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(73, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 32);
            this.label8.TabIndex = 23;
            this.label8.Text = "Abona:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtAbonaDolar
            // 
            this.TxtAbonaDolar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtAbonaDolar.BackColor = System.Drawing.Color.White;
            this.TxtAbonaDolar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtAbonaDolar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtAbonaDolar.DefaultText = "";
            this.TxtAbonaDolar.DisabledState.Parent = this.TxtAbonaDolar;
            this.TxtAbonaDolar.FocusedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.TxtAbonaDolar.FocusedState.Parent = this.TxtAbonaDolar;
            this.TxtAbonaDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TxtAbonaDolar.ForeColor = System.Drawing.Color.Black;
            this.TxtAbonaDolar.HoverState.Parent = this.TxtAbonaDolar;
            this.TxtAbonaDolar.Location = new System.Drawing.Point(216, 55);
            this.TxtAbonaDolar.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.TxtAbonaDolar.Name = "TxtAbonaDolar";
            this.TxtAbonaDolar.PasswordChar = '\0';
            this.TxtAbonaDolar.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtAbonaDolar.PlaceholderText = "$ 0";
            this.TxtAbonaDolar.SelectedText = "";
            this.TxtAbonaDolar.ShadowDecoration.Parent = this.TxtAbonaDolar;
            this.TxtAbonaDolar.Size = new System.Drawing.Size(222, 32);
            this.TxtAbonaDolar.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TxtAbonaDolar.TabIndex = 22;
            this.TxtAbonaDolar.Tag = "$";
            this.TxtAbonaDolar.TextChanged += new System.EventHandler(this.TxtAbonaDolar_TextChanged);
            // 
            // LbTipChange
            // 
            this.LbTipChange.AutoSize = true;
            this.LbTipChange.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTipChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LbTipChange.Location = new System.Drawing.Point(213, 211);
            this.LbTipChange.Name = "LbTipChange";
            this.LbTipChange.Size = new System.Drawing.Size(144, 17);
            this.LbTipChange.TabIndex = 21;
            this.LbTipChange.Text = "(Tipo de Cambio C${0})";
            this.LbTipChange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(69, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 32);
            this.label7.TabIndex = 20;
            this.label7.Text = "Cambio en Pesos:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtCambioDolar
            // 
            this.TxtCambioDolar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCambioDolar.BackColor = System.Drawing.Color.White;
            this.TxtCambioDolar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtCambioDolar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCambioDolar.DefaultText = "";
            this.TxtCambioDolar.DisabledState.Parent = this.TxtCambioDolar;
            this.TxtCambioDolar.FocusedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.TxtCambioDolar.FocusedState.Parent = this.TxtCambioDolar;
            this.TxtCambioDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TxtCambioDolar.ForeColor = System.Drawing.Color.Black;
            this.TxtCambioDolar.HoverState.Parent = this.TxtCambioDolar;
            this.TxtCambioDolar.Location = new System.Drawing.Point(216, 243);
            this.TxtCambioDolar.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.TxtCambioDolar.Name = "TxtCambioDolar";
            this.TxtCambioDolar.PasswordChar = '\0';
            this.TxtCambioDolar.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtCambioDolar.PlaceholderText = "C$ 0";
            this.TxtCambioDolar.ReadOnly = true;
            this.TxtCambioDolar.SelectedText = "";
            this.TxtCambioDolar.ShadowDecoration.Parent = this.TxtCambioDolar;
            this.TxtCambioDolar.Size = new System.Drawing.Size(222, 32);
            this.TxtCambioDolar.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TxtCambioDolar.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(446, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 32);
            this.label6.TabIndex = 18;
            this.label6.Text = "Dlls";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(86, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 32);
            this.label4.TabIndex = 17;
            this.label4.Text = "Equivalente a:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtEquivDolar
            // 
            this.TxtEquivDolar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtEquivDolar.BackColor = System.Drawing.Color.White;
            this.TxtEquivDolar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtEquivDolar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtEquivDolar.DefaultText = "";
            this.TxtEquivDolar.DisabledState.Parent = this.TxtEquivDolar;
            this.TxtEquivDolar.FocusedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.TxtEquivDolar.FocusedState.Parent = this.TxtEquivDolar;
            this.TxtEquivDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TxtEquivDolar.ForeColor = System.Drawing.Color.Black;
            this.TxtEquivDolar.HoverState.Parent = this.TxtEquivDolar;
            this.TxtEquivDolar.Location = new System.Drawing.Point(216, 179);
            this.TxtEquivDolar.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.TxtEquivDolar.Name = "TxtEquivDolar";
            this.TxtEquivDolar.PasswordChar = '\0';
            this.TxtEquivDolar.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtEquivDolar.PlaceholderText = "C$ 0";
            this.TxtEquivDolar.ReadOnly = true;
            this.TxtEquivDolar.SelectedText = "";
            this.TxtEquivDolar.ShadowDecoration.Parent = this.TxtEquivDolar;
            this.TxtEquivDolar.Size = new System.Drawing.Size(222, 32);
            this.TxtEquivDolar.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TxtEquivDolar.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(110, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 32);
            this.label5.TabIndex = 15;
            this.label5.Text = "Pagó con:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtPagoDolar
            // 
            this.TxtPagoDolar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPagoDolar.BackColor = System.Drawing.Color.White;
            this.TxtPagoDolar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtPagoDolar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPagoDolar.DefaultText = "";
            this.TxtPagoDolar.DisabledState.Parent = this.TxtPagoDolar;
            this.TxtPagoDolar.FocusedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.TxtPagoDolar.FocusedState.Parent = this.TxtPagoDolar;
            this.TxtPagoDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TxtPagoDolar.ForeColor = System.Drawing.Color.Black;
            this.TxtPagoDolar.HoverState.Parent = this.TxtPagoDolar;
            this.TxtPagoDolar.Location = new System.Drawing.Point(216, 117);
            this.TxtPagoDolar.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.TxtPagoDolar.Name = "TxtPagoDolar";
            this.TxtPagoDolar.PasswordChar = '\0';
            this.TxtPagoDolar.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtPagoDolar.PlaceholderText = "$ 0";
            this.TxtPagoDolar.SelectedText = "";
            this.TxtPagoDolar.ShadowDecoration.Parent = this.TxtPagoDolar;
            this.TxtPagoDolar.Size = new System.Drawing.Size(222, 32);
            this.TxtPagoDolar.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TxtPagoDolar.TabIndex = 14;
            this.TxtPagoDolar.TextChanged += new System.EventHandler(this.TxtPagoDolar_TextChanged);
            // 
            // PlMain
            // 
            this.PlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.PlMain.Controls.Add(this.panel3);
            this.PlMain.Controls.Add(this.lbAbona);
            this.PlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlMain.Location = new System.Drawing.Point(0, 0);
            this.PlMain.Name = "PlMain";
            this.PlMain.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.PlMain.Size = new System.Drawing.Size(603, 441);
            this.PlMain.TabIndex = 93;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.TabMxin);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(10, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(583, 373);
            this.panel3.TabIndex = 658;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.panel2.Controls.Add(this.LbSaldo);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.BtnCancelar);
            this.panel2.Controls.Add(this.BtnSoloAbonar);
            this.panel2.Controls.Add(this.BtnAbonar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(603, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20);
            this.panel2.Size = new System.Drawing.Size(229, 441);
            this.panel2.TabIndex = 94;
            // 
            // LbSaldo
            // 
            this.LbSaldo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSaldo.ForeColor = System.Drawing.Color.White;
            this.LbSaldo.Location = new System.Drawing.Point(23, 197);
            this.LbSaldo.Name = "LbSaldo";
            this.LbSaldo.Size = new System.Drawing.Size(180, 32);
            this.LbSaldo.TabIndex = 657;
            this.LbSaldo.Text = "C$ {0}";
            this.LbSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(23, 165);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(180, 32);
            this.label14.TabIndex = 656;
            this.label14.Text = "El Usuario debe:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Animated = true;
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.BtnCancelar.BorderColor = System.Drawing.Color.White;
            this.BtnCancelar.CheckedState.Parent = this.BtnCancelar;
            this.BtnCancelar.CustomImages.Parent = this.BtnCancelar;
            this.BtnCancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.HoverState.BorderColor = System.Drawing.Color.Black;
            this.BtnCancelar.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.HoverState.Parent = this.BtnCancelar;
            this.BtnCancelar.Image = global::Presentación.Properties.Resources.icons8_waste_32;
            this.BtnCancelar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnCancelar.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.BtnCancelar.Location = new System.Drawing.Point(23, 125);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnCancelar.MinimumSize = new System.Drawing.Size(23, 29);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.ShadowDecoration.Parent = this.BtnCancelar;
            this.BtnCancelar.Size = new System.Drawing.Size(180, 35);
            this.BtnCancelar.TabIndex = 654;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnSoloAbonar
            // 
            this.BtnSoloAbonar.Animated = true;
            this.BtnSoloAbonar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.BtnSoloAbonar.BorderColor = System.Drawing.Color.White;
            this.BtnSoloAbonar.CheckedState.Parent = this.BtnSoloAbonar;
            this.BtnSoloAbonar.CustomImages.Parent = this.BtnSoloAbonar;
            this.BtnSoloAbonar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.BtnSoloAbonar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnSoloAbonar.ForeColor = System.Drawing.Color.White;
            this.BtnSoloAbonar.HoverState.BorderColor = System.Drawing.Color.Black;
            this.BtnSoloAbonar.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnSoloAbonar.HoverState.Parent = this.BtnSoloAbonar;
            this.BtnSoloAbonar.Image = global::Presentación.Properties.Resources.icons8_waste_32;
            this.BtnSoloAbonar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnSoloAbonar.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.BtnSoloAbonar.Location = new System.Drawing.Point(23, 80);
            this.BtnSoloAbonar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnSoloAbonar.MinimumSize = new System.Drawing.Size(23, 29);
            this.BtnSoloAbonar.Name = "BtnSoloAbonar";
            this.BtnSoloAbonar.ShadowDecoration.Parent = this.BtnSoloAbonar;
            this.BtnSoloAbonar.Size = new System.Drawing.Size(180, 35);
            this.BtnSoloAbonar.TabIndex = 653;
            this.BtnSoloAbonar.Text = "Abonar sin Imprimir";
            this.BtnSoloAbonar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnSoloAbonar.Click += new System.EventHandler(this.BtnSoloAbonar_Click);
            // 
            // BtnAbonar
            // 
            this.BtnAbonar.Animated = true;
            this.BtnAbonar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.BtnAbonar.BorderColor = System.Drawing.Color.White;
            this.BtnAbonar.CheckedState.Parent = this.BtnAbonar;
            this.BtnAbonar.CustomImages.Parent = this.BtnAbonar;
            this.BtnAbonar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.BtnAbonar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnAbonar.ForeColor = System.Drawing.Color.White;
            this.BtnAbonar.HoverState.BorderColor = System.Drawing.Color.Black;
            this.BtnAbonar.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnAbonar.HoverState.Parent = this.BtnAbonar;
            this.BtnAbonar.Image = global::Presentación.Properties.Resources.icons8_waste_32;
            this.BtnAbonar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnAbonar.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.BtnAbonar.Location = new System.Drawing.Point(23, 35);
            this.BtnAbonar.Margin = new System.Windows.Forms.Padding(3, 15, 3, 5);
            this.BtnAbonar.MinimumSize = new System.Drawing.Size(23, 29);
            this.BtnAbonar.Name = "BtnAbonar";
            this.BtnAbonar.ShadowDecoration.Parent = this.BtnAbonar;
            this.BtnAbonar.Size = new System.Drawing.Size(180, 35);
            this.BtnAbonar.TabIndex = 652;
            this.BtnAbonar.Text = "Abonar e Imprimir Ticket";
            this.BtnAbonar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnAbonar.Click += new System.EventHandler(this.BtnAbonar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Forma_Abono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(832, 441);
            this.Controls.Add(this.PlMain);
            this.Controls.Add(this.panel2);
            this.MinimumSize = new System.Drawing.Size(720, 480);
            this.Name = "Forma_Abono";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Venta -> Abonar";
            ((System.ComponentModel.ISupportInitialize)(this.TabMxin)).EndInit();
            this.TabMxin.ResumeLayout(false);
            this.TabEfectivo.ResumeLayout(false);
            this.TabMixto.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.TabDolares.ResumeLayout(false);
            this.TabDolares.PerformLayout();
            this.PlMain.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Label lbAbona;
        private DevExpress.XtraBars.Navigation.TabPane TabMxin;
        private DevExpress.XtraBars.Navigation.TabNavigationPage TabEfectivo;
        private DevExpress.XtraBars.Navigation.TabNavigationPage TabMixto;
        private System.Windows.Forms.Panel PlMain;
        public Guna.UI2.WinForms.Guna2TextBox TxtAbona;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2TextBox TxtCambioEfectivo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        protected Guna.UI2.WinForms.Guna2Button BtnAbonar;
        protected Guna.UI2.WinForms.Guna2Button BtnSoloAbonar;
        protected Guna.UI2.WinForms.Guna2Button BtnCancelar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label LbSaldo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage TabDolares;
        private System.Windows.Forms.Label label13;
        public Guna.UI2.WinForms.Guna2TextBox TxtCambioMixto;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label10;
        public Guna.UI2.WinForms.Guna2TextBox TxtDolarMixto;
        private System.Windows.Forms.Label label12;
        public Guna.UI2.WinForms.Guna2TextBox TxtEfectivoMixto;
        private System.Windows.Forms.Label LbTipChange;
        private System.Windows.Forms.Label label7;
        public Guna.UI2.WinForms.Guna2TextBox TxtCambioDolar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        public Guna.UI2.WinForms.Guna2TextBox TxtEquivDolar;
        private System.Windows.Forms.Label label5;
        public Guna.UI2.WinForms.Guna2TextBox TxtPagoDolar;
        private System.Windows.Forms.Label label3;
        public Guna.UI2.WinForms.Guna2TextBox TxtPagoCor;
        private System.Windows.Forms.Label label8;
        public Guna.UI2.WinForms.Guna2TextBox TxtAbonaDolar;
        private System.Windows.Forms.Label label9;
        public Guna.UI2.WinForms.Guna2TextBox TxtAbona3;
    }
}