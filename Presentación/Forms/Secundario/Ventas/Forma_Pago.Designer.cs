
namespace Presentación.Forms.Secundario.Ventas
{
    partial class Forma_Pago
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
            this.lbTotalPagar = new System.Windows.Forms.Label();
            this.TabMxin = new DevExpress.XtraBars.Navigation.TabPane();
            this.TabEfectivo = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCambioEfectivo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPagoEfectivo = new Guna.UI2.WinForms.Guna2TextBox();
            this.TabCredito = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.LkeCliente = new DevExpress.XtraEditors.LookUpEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.TabDolares = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.LbTipChange = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtCambioDolar = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtEquivDolar = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPagoDolar = new Guna.UI2.WinForms.Guna2TextBox();
            this.TabMixto = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtCambioMixto = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtDolarMixto = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtEfectivoMixto = new Guna.UI2.WinForms.Guna2TextBox();
            this.PlMain = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.BtnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.BtnRegistrar = new Guna.UI2.WinForms.Guna2Button();
            this.BtnCobrar = new Guna.UI2.WinForms.Guna2Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TabMxin)).BeginInit();
            this.TabMxin.SuspendLayout();
            this.TabEfectivo.SuspendLayout();
            this.TabCredito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LkeCliente.Properties)).BeginInit();
            this.TabDolares.SuspendLayout();
            this.TabMixto.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PlMain.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTotalPagar
            // 
            this.lbTotalPagar.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTotalPagar.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPagar.ForeColor = System.Drawing.Color.White;
            this.lbTotalPagar.Location = new System.Drawing.Point(10, 0);
            this.lbTotalPagar.Name = "lbTotalPagar";
            this.lbTotalPagar.Size = new System.Drawing.Size(596, 58);
            this.lbTotalPagar.TabIndex = 90;
            this.lbTotalPagar.Text = "{0}";
            this.lbTotalPagar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TabMxin
            // 
            this.TabMxin.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.TabMxin.Appearance.Options.UseBorderColor = true;
            this.TabMxin.Controls.Add(this.TabEfectivo);
            this.TabMxin.Controls.Add(this.TabCredito);
            this.TabMxin.Controls.Add(this.TabDolares);
            this.TabMxin.Controls.Add(this.TabMixto);
            this.TabMxin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabMxin.Location = new System.Drawing.Point(0, 0);
            this.TabMxin.Name = "TabMxin";
            this.TabMxin.PageProperties.AppearanceCaption.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.TabMxin.PageProperties.AppearanceCaption.Options.UseBorderColor = true;
            this.TabMxin.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.TabMxin.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.TabEfectivo,
            this.TabCredito,
            this.TabDolares,
            this.TabMixto});
            this.TabMxin.RegularSize = new System.Drawing.Size(594, 371);
            this.TabMxin.SelectedPage = this.TabEfectivo;
            this.TabMxin.Size = new System.Drawing.Size(594, 371);
            this.TabMxin.TabIndex = 92;
            this.TabMxin.Text = "tabPane1";
            this.TabMxin.SelectedPageChanged += new DevExpress.XtraBars.Navigation.SelectedPageChangedEventHandler(this.TabMxin_SelectedPageChanged);
            // 
            // TabEfectivo
            // 
            this.TabEfectivo.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabEfectivo.Appearance.Options.UseFont = true;
            this.TabEfectivo.Caption = "Efectivo";
            this.TabEfectivo.Controls.Add(this.label2);
            this.TabEfectivo.Controls.Add(this.TxtCambioEfectivo);
            this.TabEfectivo.Controls.Add(this.label1);
            this.TabEfectivo.Controls.Add(this.TxtPagoEfectivo);
            this.TabEfectivo.ImageOptions.Image = global::Presentación.Properties.Resources.icons8_cash_40;
            this.TabEfectivo.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.TabEfectivo.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.TabEfectivo.Name = "TabEfectivo";
            this.TabEfectivo.Properties.AppearanceCaption.Options.UseImage = true;
            this.TabEfectivo.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.TabEfectivo.Size = new System.Drawing.Size(594, 307);
            this.TabEfectivo.Tag = "0";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(122, 131);
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
            this.TxtCambioEfectivo.Location = new System.Drawing.Point(228, 131);
            this.TxtCambioEfectivo.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.TxtCambioEfectivo.Name = "TxtCambioEfectivo";
            this.TxtCambioEfectivo.PasswordChar = '\0';
            this.TxtCambioEfectivo.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtCambioEfectivo.PlaceholderText = "C$ -";
            this.TxtCambioEfectivo.ReadOnly = true;
            this.TxtCambioEfectivo.SelectedText = "";
            this.TxtCambioEfectivo.ShadowDecoration.Parent = this.TxtCambioEfectivo;
            this.TxtCambioEfectivo.Size = new System.Drawing.Size(221, 32);
            this.TxtCambioEfectivo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TxtCambioEfectivo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(122, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pagó con:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtPagoEfectivo
            // 
            this.TxtPagoEfectivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPagoEfectivo.BackColor = System.Drawing.Color.White;
            this.TxtPagoEfectivo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtPagoEfectivo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPagoEfectivo.DefaultText = "";
            this.TxtPagoEfectivo.DisabledState.Parent = this.TxtPagoEfectivo;
            this.TxtPagoEfectivo.FocusedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.TxtPagoEfectivo.FocusedState.Parent = this.TxtPagoEfectivo;
            this.TxtPagoEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TxtPagoEfectivo.ForeColor = System.Drawing.Color.Black;
            this.TxtPagoEfectivo.HoverState.Parent = this.TxtPagoEfectivo;
            this.TxtPagoEfectivo.Location = new System.Drawing.Point(228, 69);
            this.TxtPagoEfectivo.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.TxtPagoEfectivo.Name = "TxtPagoEfectivo";
            this.TxtPagoEfectivo.PasswordChar = '\0';
            this.TxtPagoEfectivo.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtPagoEfectivo.PlaceholderText = "C$ -";
            this.TxtPagoEfectivo.SelectedText = "";
            this.TxtPagoEfectivo.ShadowDecoration.Parent = this.TxtPagoEfectivo;
            this.TxtPagoEfectivo.Size = new System.Drawing.Size(221, 32);
            this.TxtPagoEfectivo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TxtPagoEfectivo.TabIndex = 2;
            this.TxtPagoEfectivo.TextChanged += new System.EventHandler(this.TxtPagoEfectivo_TextChanged);
            // 
            // TabCredito
            // 
            this.TabCredito.Caption = "Crédito";
            this.TabCredito.Controls.Add(this.LkeCliente);
            this.TabCredito.Controls.Add(this.label3);
            this.TabCredito.ImageOptions.Image = global::Presentación.Properties.Resources.icons8_credit_card_cash_withdrawal_40;
            this.TabCredito.Name = "TabCredito";
            this.TabCredito.PageVisible = false;
            this.TabCredito.Size = new System.Drawing.Size(594, 371);
            this.TabCredito.Tag = "1";
            // 
            // LkeCliente
            // 
            this.LkeCliente.Location = new System.Drawing.Point(208, 54);
            this.LkeCliente.Name = "LkeCliente";
            this.LkeCliente.Properties.AutoHeight = false;
            this.LkeCliente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LkeCliente.Size = new System.Drawing.Size(312, 32);
            this.LkeCliente.TabIndex = 5;
            this.LkeCliente.EditValueChanged += new System.EventHandler(this.LkeCliente_EditValueChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(70, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Seleccione cliente:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TabDolares
            // 
            this.TabDolares.Caption = "Dólares";
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
            this.TabDolares.Size = new System.Drawing.Size(594, 371);
            this.TabDolares.Tag = "2";
            // 
            // LbTipChange
            // 
            this.LbTipChange.AutoSize = true;
            this.LbTipChange.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTipChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LbTipChange.Location = new System.Drawing.Point(227, 148);
            this.LbTipChange.Name = "LbTipChange";
            this.LbTipChange.Size = new System.Drawing.Size(144, 17);
            this.LbTipChange.TabIndex = 13;
            this.LbTipChange.Text = "(Tipo de Cambio C${0})";
            this.LbTipChange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(83, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 32);
            this.label7.TabIndex = 12;
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
            this.TxtCambioDolar.Location = new System.Drawing.Point(230, 180);
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
            this.TxtCambioDolar.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(460, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "Dlls";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(100, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 32);
            this.label4.TabIndex = 9;
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
            this.TxtEquivDolar.Location = new System.Drawing.Point(230, 116);
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
            this.TxtEquivDolar.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(124, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 32);
            this.label5.TabIndex = 7;
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
            this.TxtPagoDolar.Location = new System.Drawing.Point(230, 54);
            this.TxtPagoDolar.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.TxtPagoDolar.Name = "TxtPagoDolar";
            this.TxtPagoDolar.PasswordChar = '\0';
            this.TxtPagoDolar.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtPagoDolar.PlaceholderText = "$ 0";
            this.TxtPagoDolar.SelectedText = "";
            this.TxtPagoDolar.ShadowDecoration.Parent = this.TxtPagoDolar;
            this.TxtPagoDolar.Size = new System.Drawing.Size(222, 32);
            this.TxtPagoDolar.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TxtPagoDolar.TabIndex = 6;
            this.TxtPagoDolar.TextChanged += new System.EventHandler(this.TxtPagoDolar_TextChanged);
            // 
            // TabMixto
            // 
            this.TabMixto.Caption = "Mixto";
            this.TabMixto.Controls.Add(this.panel1);
            this.TabMixto.ImageOptions.Image = global::Presentación.Properties.Resources.icons8_buy_for_cash_40;
            this.TabMixto.ImageOptions.SvgImageSize = new System.Drawing.Size(10, 10);
            this.TabMixto.Name = "TabMixto";
            this.TabMixto.Padding = new System.Windows.Forms.Padding(30, 25, 30, 25);
            this.TabMixto.Properties.AppearanceCaption.Options.UseImage = true;
            this.TabMixto.Size = new System.Drawing.Size(594, 307);
            this.TabMixto.Tag = "3";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.panel1.Size = new System.Drawing.Size(534, 257);
            this.panel1.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(24, 181);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(141, 32);
            this.label13.TabIndex = 23;
            this.label13.Text = "Restante:";
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
            this.TxtCambioMixto.Location = new System.Drawing.Point(171, 181);
            this.TxtCambioMixto.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.TxtCambioMixto.Name = "TxtCambioMixto";
            this.TxtCambioMixto.PasswordChar = '\0';
            this.TxtCambioMixto.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtCambioMixto.PlaceholderText = "C$ 0";
            this.TxtCambioMixto.ReadOnly = true;
            this.TxtCambioMixto.SelectedText = "";
            this.TxtCambioMixto.ShadowDecoration.Parent = this.TxtCambioMixto;
            this.TxtCambioMixto.Size = new System.Drawing.Size(280, 32);
            this.TxtCambioMixto.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TxtCambioMixto.TabIndex = 22;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(100, 153);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(351, 10);
            this.guna2Separator1.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(24, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 32);
            this.label10.TabIndex = 19;
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
            this.TxtDolarMixto.Location = new System.Drawing.Point(171, 103);
            this.TxtDolarMixto.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.TxtDolarMixto.Name = "TxtDolarMixto";
            this.TxtDolarMixto.PasswordChar = '\0';
            this.TxtDolarMixto.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtDolarMixto.PlaceholderText = "C$ 0";
            this.TxtDolarMixto.SelectedText = "";
            this.TxtDolarMixto.ShadowDecoration.Parent = this.TxtDolarMixto;
            this.TxtDolarMixto.Size = new System.Drawing.Size(280, 32);
            this.TxtDolarMixto.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TxtDolarMixto.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(65, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 32);
            this.label12.TabIndex = 15;
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
            this.TxtEfectivoMixto.Location = new System.Drawing.Point(171, 41);
            this.TxtEfectivoMixto.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.TxtEfectivoMixto.Name = "TxtEfectivoMixto";
            this.TxtEfectivoMixto.PasswordChar = '\0';
            this.TxtEfectivoMixto.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtEfectivoMixto.PlaceholderText = "$ 0";
            this.TxtEfectivoMixto.SelectedText = "";
            this.TxtEfectivoMixto.ShadowDecoration.Parent = this.TxtEfectivoMixto;
            this.TxtEfectivoMixto.Size = new System.Drawing.Size(280, 32);
            this.TxtEfectivoMixto.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TxtEfectivoMixto.TabIndex = 14;
            // 
            // PlMain
            // 
            this.PlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.PlMain.Controls.Add(this.panel3);
            this.PlMain.Controls.Add(this.lbTotalPagar);
            this.PlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlMain.Location = new System.Drawing.Point(0, 0);
            this.PlMain.Name = "PlMain";
            this.PlMain.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.PlMain.Size = new System.Drawing.Size(616, 441);
            this.PlMain.TabIndex = 93;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.TabMxin);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(10, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(596, 373);
            this.panel3.TabIndex = 658;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.guna2Button3);
            this.panel2.Controls.Add(this.BtnCancelar);
            this.panel2.Controls.Add(this.BtnRegistrar);
            this.panel2.Controls.Add(this.BtnCobrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(616, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20);
            this.panel2.Size = new System.Drawing.Size(216, 441);
            this.panel2.TabIndex = 94;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(23, 242);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(170, 32);
            this.label15.TabIndex = 657;
            this.label15.Text = "5";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(23, 210);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(170, 32);
            this.label14.TabIndex = 656;
            this.label14.Text = "Total de Artículos:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Button3
            // 
            this.guna2Button3.Animated = true;
            this.guna2Button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.guna2Button3.BorderColor = System.Drawing.Color.White;
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.BorderColor = System.Drawing.Color.Black;
            this.guna2Button3.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Image = global::Presentación.Properties.Resources.icons8_speaker_notes_32;
            this.guna2Button3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button3.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.guna2Button3.Location = new System.Drawing.Point(23, 170);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.guna2Button3.MinimumSize = new System.Drawing.Size(23, 29);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(170, 35);
            this.guna2Button3.TabIndex = 655;
            this.guna2Button3.Text = "Ingresar notas";
            this.guna2Button3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.BtnCancelar.Size = new System.Drawing.Size(170, 35);
            this.BtnCancelar.TabIndex = 654;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Animated = true;
            this.BtnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.BtnRegistrar.BorderColor = System.Drawing.Color.White;
            this.BtnRegistrar.CheckedState.Parent = this.BtnRegistrar;
            this.BtnRegistrar.CustomImages.Parent = this.BtnRegistrar;
            this.BtnRegistrar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.BtnRegistrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnRegistrar.ForeColor = System.Drawing.Color.White;
            this.BtnRegistrar.HoverState.BorderColor = System.Drawing.Color.Black;
            this.BtnRegistrar.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnRegistrar.HoverState.Parent = this.BtnRegistrar;
            this.BtnRegistrar.Image = global::Presentación.Properties.Resources.icons8_cheque_32;
            this.BtnRegistrar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnRegistrar.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.BtnRegistrar.Location = new System.Drawing.Point(23, 80);
            this.BtnRegistrar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnRegistrar.MinimumSize = new System.Drawing.Size(23, 29);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.ShadowDecoration.Parent = this.BtnRegistrar;
            this.BtnRegistrar.Size = new System.Drawing.Size(170, 35);
            this.BtnRegistrar.TabIndex = 653;
            this.BtnRegistrar.Text = "Solo Cobrar";
            this.BtnRegistrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // BtnCobrar
            // 
            this.BtnCobrar.Animated = true;
            this.BtnCobrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.BtnCobrar.BorderColor = System.Drawing.Color.White;
            this.BtnCobrar.CheckedState.Parent = this.BtnCobrar;
            this.BtnCobrar.CustomImages.Parent = this.BtnCobrar;
            this.BtnCobrar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.BtnCobrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnCobrar.ForeColor = System.Drawing.Color.White;
            this.BtnCobrar.HoverState.BorderColor = System.Drawing.Color.Black;
            this.BtnCobrar.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnCobrar.HoverState.Parent = this.BtnCobrar;
            this.BtnCobrar.Image = global::Presentación.Properties.Resources.icons8_check_32;
            this.BtnCobrar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnCobrar.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.BtnCobrar.Location = new System.Drawing.Point(23, 35);
            this.BtnCobrar.Margin = new System.Windows.Forms.Padding(3, 15, 3, 5);
            this.BtnCobrar.MinimumSize = new System.Drawing.Size(23, 29);
            this.BtnCobrar.Name = "BtnCobrar";
            this.BtnCobrar.ShadowDecoration.Parent = this.BtnCobrar;
            this.BtnCobrar.Size = new System.Drawing.Size(170, 35);
            this.BtnCobrar.TabIndex = 652;
            this.BtnCobrar.Text = "Cobrar e Imprimir Ticket";
            this.BtnCobrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnCobrar.Click += new System.EventHandler(this.BtnCobrar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Forma_Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(832, 441);
            this.Controls.Add(this.PlMain);
            this.Controls.Add(this.panel2);
            this.MinimumSize = new System.Drawing.Size(720, 480);
            this.Name = "Forma_Pago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Forma de Pago";
            ((System.ComponentModel.ISupportInitialize)(this.TabMxin)).EndInit();
            this.TabMxin.ResumeLayout(false);
            this.TabEfectivo.ResumeLayout(false);
            this.TabCredito.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LkeCliente.Properties)).EndInit();
            this.TabDolares.ResumeLayout(false);
            this.TabDolares.PerformLayout();
            this.TabMixto.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.PlMain.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Label lbTotalPagar;
        private DevExpress.XtraBars.Navigation.TabPane TabMxin;
        private DevExpress.XtraBars.Navigation.TabNavigationPage TabEfectivo;
        private DevExpress.XtraBars.Navigation.TabNavigationPage TabCredito;
        private DevExpress.XtraBars.Navigation.TabNavigationPage TabDolares;
        private DevExpress.XtraBars.Navigation.TabNavigationPage TabMixto;
        private System.Windows.Forms.Panel PlMain;
        public Guna.UI2.WinForms.Guna2TextBox TxtPagoEfectivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2TextBox TxtCambioEfectivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public Guna.UI2.WinForms.Guna2TextBox TxtEquivDolar;
        private System.Windows.Forms.Label label5;
        public Guna.UI2.WinForms.Guna2TextBox TxtPagoDolar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public Guna.UI2.WinForms.Guna2TextBox TxtCambioDolar;
        private System.Windows.Forms.Label LbTipChange;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        public Guna.UI2.WinForms.Guna2TextBox TxtDolarMixto;
        private System.Windows.Forms.Label label12;
        public Guna.UI2.WinForms.Guna2TextBox TxtEfectivoMixto;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label13;
        public Guna.UI2.WinForms.Guna2TextBox TxtCambioMixto;
        private System.Windows.Forms.Panel panel2;
        protected Guna.UI2.WinForms.Guna2Button BtnCobrar;
        protected Guna.UI2.WinForms.Guna2Button BtnRegistrar;
        protected Guna.UI2.WinForms.Guna2Button BtnCancelar;
        protected Guna.UI2.WinForms.Guna2Button guna2Button3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraEditors.LookUpEdit LkeCliente;
    }
}