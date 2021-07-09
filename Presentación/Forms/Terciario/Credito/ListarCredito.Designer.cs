
namespace Presentación.Forms.Credito
{
    partial class ListarCredito
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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.plSubMain = new System.Windows.Forms.Panel();
            this.plDatosMenu = new System.Windows.Forms.Panel();
            this.plGridControl = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.heritable2 = new Presentación.Forms.Principal.Heredables.Force_Heritage();
            this.label2 = new System.Windows.Forms.Label();
            this.lookUpEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.PlTools = new System.Windows.Forms.Panel();
            this.FlowPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.BtnPrint = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAbonar = new Guna.UI2.WinForms.Guna2Button();
            this.BtnItemBajos = new Guna.UI2.WinForms.Guna2Button();
            this.BtnDetalles = new Guna.UI2.WinForms.Guna2Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSaldo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new Presentación.Forms.Principal.Heredables.Force_Heritage();
            this.label1 = new System.Windows.Forms.Label();
            this.LukCliente = new DevExpress.XtraEditors.LookUpEdit();
            this.BtnHerramientas = new Guna.UI2.WinForms.Guna2Button();
            this.lbAdorno = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.plSubMain.SuspendLayout();
            this.plDatosMenu.SuspendLayout();
            this.plGridControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.heritable2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            this.PlTools.SuspendLayout();
            this.FlowPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LukCliente.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.lbTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitulo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(0, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(1028, 44);
            this.lbTitulo.TabIndex = 117;
            this.lbTitulo.Text = "Gestión de Credito";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbTitulo.Visible = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.plSubMain);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 44);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.panel5.Size = new System.Drawing.Size(1028, 558);
            this.panel5.TabIndex = 120;
            // 
            // plSubMain
            // 
            this.plSubMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plSubMain.Controls.Add(this.plDatosMenu);
            this.plSubMain.Controls.Add(this.lbAdorno);
            this.plSubMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plSubMain.Location = new System.Drawing.Point(10, 5);
            this.plSubMain.Name = "plSubMain";
            this.plSubMain.Size = new System.Drawing.Size(1008, 548);
            this.plSubMain.TabIndex = 88;
            // 
            // plDatosMenu
            // 
            this.plDatosMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.plDatosMenu.Controls.Add(this.plGridControl);
            this.plDatosMenu.Controls.Add(this.panel6);
            this.plDatosMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plDatosMenu.Location = new System.Drawing.Point(0, 24);
            this.plDatosMenu.Name = "plDatosMenu";
            this.plDatosMenu.Size = new System.Drawing.Size(1006, 522);
            this.plDatosMenu.TabIndex = 86;
            // 
            // plGridControl
            // 
            this.plGridControl.Controls.Add(this.gridControl1);
            this.plGridControl.Controls.Add(this.panel1);
            this.plGridControl.Controls.Add(this.PlTools);
            this.plGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plGridControl.Location = new System.Drawing.Point(0, 47);
            this.plGridControl.Name = "plGridControl";
            this.plGridControl.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.plGridControl.Size = new System.Drawing.Size(1006, 475);
            this.plGridControl.TabIndex = 88;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(243, 47);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(758, 423);
            this.gridControl1.TabIndex = 89;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.ColumnPanelRowHeight = 35;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsCustomization.AllowSort = false;
            this.gridView1.OptionsFind.AllowFindPanel = false;
            this.gridView1.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowHeight = 25;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(5, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 423);
            this.panel1.TabIndex = 92;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.heritable2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 374);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.panel2.Size = new System.Drawing.Size(236, 47);
            this.panel2.TabIndex = 0;
            // 
            // heritable2
            // 
            this.heritable2.Controls.Add(this.label2);
            this.heritable2.Controls.Add(this.lookUpEdit1);
            this.heritable2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.heritable2.Location = new System.Drawing.Point(10, 9);
            this.heritable2.Margin = new System.Windows.Forms.Padding(0);
            this.heritable2.Name = "heritable2";
            this.heritable2.Size = new System.Drawing.Size(214, 27);
            this.heritable2.TabIndex = 93;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 27);
            this.label2.TabIndex = 101;
            this.label2.Text = "Mostrar Credito:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.EditValue = "No Liquidas";
            this.lookUpEdit1.Location = new System.Drawing.Point(105, 0);
            this.lookUpEdit1.Margin = new System.Windows.Forms.Padding(0);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.AutoHeight = false;
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.Items.AddRange(new object[] {
            "No Liquidas",
            "Ya Liquidas"});
            this.lookUpEdit1.Properties.NullText = "[Vacío]";
            this.lookUpEdit1.Properties.PopupSizeable = true;
            this.lookUpEdit1.Size = new System.Drawing.Size(109, 27);
            this.lookUpEdit1.TabIndex = 102;
            // 
            // PlTools
            // 
            this.PlTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.PlTools.Controls.Add(this.FlowPanel1);
            this.PlTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.PlTools.Location = new System.Drawing.Point(5, 0);
            this.PlTools.Name = "PlTools";
            this.PlTools.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.PlTools.Size = new System.Drawing.Size(996, 47);
            this.PlTools.TabIndex = 90;
            // 
            // FlowPanel1
            // 
            this.FlowPanel1.Controls.Add(this.guna2Button1);
            this.FlowPanel1.Controls.Add(this.BtnPrint);
            this.FlowPanel1.Controls.Add(this.BtnAbonar);
            this.FlowPanel1.Controls.Add(this.BtnItemBajos);
            this.FlowPanel1.Controls.Add(this.BtnDetalles);
            this.FlowPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.FlowPanel1.Location = new System.Drawing.Point(0, 10);
            this.FlowPanel1.Name = "FlowPanel1";
            this.FlowPanel1.Size = new System.Drawing.Size(716, 27);
            this.FlowPanel1.TabIndex = 102;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.BorderColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = global::Presentación.Properties.Resources.icons8_print_20;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.Location = new System.Drawing.Point(0, 0);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(130, 27);
            this.guna2Button1.TabIndex = 118;
            this.guna2Button1.Text = "Imprimir Estado";
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BtnPrint
            // 
            this.BtnPrint.Animated = true;
            this.BtnPrint.CheckedState.Parent = this.BtnPrint;
            this.BtnPrint.CustomImages.Parent = this.BtnPrint;
            this.BtnPrint.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.BtnPrint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnPrint.ForeColor = System.Drawing.Color.White;
            this.BtnPrint.HoverState.BorderColor = System.Drawing.Color.Black;
            this.BtnPrint.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnPrint.HoverState.Parent = this.BtnPrint;
            this.BtnPrint.Image = global::Presentación.Properties.Resources.icons8_print_20;
            this.BtnPrint.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnPrint.Location = new System.Drawing.Point(135, 0);
            this.BtnPrint.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.ShadowDecoration.Parent = this.BtnPrint;
            this.BtnPrint.Size = new System.Drawing.Size(157, 27);
            this.BtnPrint.TabIndex = 117;
            this.BtnPrint.Text = "Imprimir Edo. Cuenta";
            this.BtnPrint.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BtnAbonar
            // 
            this.BtnAbonar.Animated = true;
            this.BtnAbonar.CheckedState.Parent = this.BtnAbonar;
            this.BtnAbonar.CustomImages.Parent = this.BtnAbonar;
            this.BtnAbonar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.BtnAbonar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnAbonar.ForeColor = System.Drawing.Color.White;
            this.BtnAbonar.HoverState.BorderColor = System.Drawing.Color.Black;
            this.BtnAbonar.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnAbonar.HoverState.Parent = this.BtnAbonar;
            this.BtnAbonar.Image = global::Presentación.Properties.Resources.icons8_combi_ticket_32;
            this.BtnAbonar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnAbonar.ImageSize = new System.Drawing.Size(18, 18);
            this.BtnAbonar.Location = new System.Drawing.Point(297, 0);
            this.BtnAbonar.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.BtnAbonar.Name = "BtnAbonar";
            this.BtnAbonar.ShadowDecoration.Parent = this.BtnAbonar;
            this.BtnAbonar.Size = new System.Drawing.Size(91, 27);
            this.BtnAbonar.TabIndex = 114;
            this.BtnAbonar.Text = "Abonar";
            this.BtnAbonar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnAbonar.Click += new System.EventHandler(this.BtnAbonar_Click);
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
            this.BtnItemBajos.Location = new System.Drawing.Point(393, 0);
            this.BtnItemBajos.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.BtnItemBajos.Name = "BtnItemBajos";
            this.BtnItemBajos.ShadowDecoration.Parent = this.BtnItemBajos;
            this.BtnItemBajos.Size = new System.Drawing.Size(134, 27);
            this.BtnItemBajos.TabIndex = 115;
            this.BtnItemBajos.Text = "Liquidar Adeudo";
            this.BtnItemBajos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BtnDetalles
            // 
            this.BtnDetalles.Animated = true;
            this.BtnDetalles.CheckedState.Parent = this.BtnDetalles;
            this.BtnDetalles.CustomImages.Parent = this.BtnDetalles;
            this.BtnDetalles.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.BtnDetalles.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnDetalles.ForeColor = System.Drawing.Color.White;
            this.BtnDetalles.HoverState.BorderColor = System.Drawing.Color.Black;
            this.BtnDetalles.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnDetalles.HoverState.Parent = this.BtnDetalles;
            this.BtnDetalles.Image = global::Presentación.Properties.Resources.icons8_graph_report_script_32;
            this.BtnDetalles.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnDetalles.ImageSize = new System.Drawing.Size(18, 18);
            this.BtnDetalles.Location = new System.Drawing.Point(532, 0);
            this.BtnDetalles.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.BtnDetalles.Name = "BtnDetalles";
            this.BtnDetalles.ShadowDecoration.Parent = this.BtnDetalles;
            this.BtnDetalles.Size = new System.Drawing.Size(132, 27);
            this.BtnDetalles.TabIndex = 116;
            this.BtnDetalles.Text = "Detalle de Abono";
            this.BtnDetalles.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnDetalles.Click += new System.EventHandler(this.BtnDetalles_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panel6.Controls.Add(this.flowLayoutPanel2);
            this.panel6.Controls.Add(this.flowLayoutPanel1);
            this.panel6.Controls.Add(this.BtnHerramientas);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(2, 10, 5, 10);
            this.panel6.Size = new System.Drawing.Size(1006, 47);
            this.panel6.TabIndex = 87;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.txtTotal);
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.TxtSaldo);
            this.flowLayoutPanel2.Controls.Add(this.label5);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(471, 10);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(503, 27);
            this.flowLayoutPanel2.TabIndex = 103;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.Animated = true;
            this.txtTotal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.DefaultText = "";
            this.txtTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotal.DisabledState.Parent = this.txtTotal;
            this.txtTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotal.FocusedState.BorderColor = System.Drawing.Color.DarkBlue;
            this.txtTotal.FocusedState.Parent = this.txtTotal;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotal.ForeColor = System.Drawing.Color.Black;
            this.txtTotal.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtTotal.HoverState.Parent = this.txtTotal;
            this.txtTotal.IconLeftSize = new System.Drawing.Size(16, 16);
            this.txtTotal.IconRightSize = new System.Drawing.Size(10, 10);
            this.txtTotal.Location = new System.Drawing.Point(408, 0);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.txtTotal.MinimumSize = new System.Drawing.Size(90, 27);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtTotal.PlaceholderText = "C$ 0.0\r\n";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.SelectedText = "";
            this.txtTotal.ShadowDecoration.Parent = this.txtTotal;
            this.txtTotal.Size = new System.Drawing.Size(90, 27);
            this.txtTotal.TabIndex = 4;
            this.txtTotal.Tag = "0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Dubai", 9.749999F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(310, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 27);
            this.label4.TabIndex = 101;
            this.label4.Text = "Limite Credito :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtSaldo
            // 
            this.TxtSaldo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSaldo.Animated = true;
            this.TxtSaldo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.TxtSaldo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtSaldo.DefaultText = "";
            this.TxtSaldo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtSaldo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtSaldo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSaldo.DisabledState.Parent = this.TxtSaldo;
            this.TxtSaldo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSaldo.FocusedState.BorderColor = System.Drawing.Color.DarkBlue;
            this.TxtSaldo.FocusedState.Parent = this.TxtSaldo;
            this.TxtSaldo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtSaldo.ForeColor = System.Drawing.Color.Black;
            this.TxtSaldo.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.TxtSaldo.HoverState.Parent = this.TxtSaldo;
            this.TxtSaldo.IconLeftSize = new System.Drawing.Size(16, 16);
            this.TxtSaldo.IconRightSize = new System.Drawing.Size(10, 10);
            this.TxtSaldo.Location = new System.Drawing.Point(215, 0);
            this.TxtSaldo.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.TxtSaldo.MinimumSize = new System.Drawing.Size(50, 20);
            this.TxtSaldo.Name = "TxtSaldo";
            this.TxtSaldo.PasswordChar = '\0';
            this.TxtSaldo.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.TxtSaldo.PlaceholderText = "0 Items";
            this.TxtSaldo.ReadOnly = true;
            this.TxtSaldo.SelectedText = "";
            this.TxtSaldo.ShadowDecoration.Parent = this.TxtSaldo;
            this.TxtSaldo.Size = new System.Drawing.Size(90, 27);
            this.TxtSaldo.TabIndex = 102;
            this.TxtSaldo.Tag = "0";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Dubai", 9.749999F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(120, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 27);
            this.label5.TabIndex = 103;
            this.label5.Text = "Saldo Actual :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.LukCliente);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 10);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(544, 27);
            this.flowLayoutPanel1.TabIndex = 92;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 27);
            this.label1.TabIndex = 101;
            this.label1.Text = "Buscar Cliente:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LukCliente
            // 
            this.LukCliente.Location = new System.Drawing.Point(109, 0);
            this.LukCliente.Margin = new System.Windows.Forms.Padding(0);
            this.LukCliente.Name = "LukCliente";
            this.LukCliente.Properties.AutoHeight = false;
            this.LukCliente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LukCliente.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest;
            this.LukCliente.Size = new System.Drawing.Size(340, 27);
            this.LukCliente.TabIndex = 102;
            this.LukCliente.EditValueChanged += new System.EventHandler(this.LukCliente_EditValueChanged);
            // 
            // BtnHerramientas
            // 
            this.BtnHerramientas.Animated = true;
            this.BtnHerramientas.AutoRoundedCorners = true;
            this.BtnHerramientas.BackColor = System.Drawing.Color.Transparent;
            this.BtnHerramientas.BorderRadius = 12;
            this.BtnHerramientas.CheckedState.Parent = this.BtnHerramientas;
            this.BtnHerramientas.CustomImages.Parent = this.BtnHerramientas;
            this.BtnHerramientas.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnHerramientas.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.BtnHerramientas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnHerramientas.ForeColor = System.Drawing.Color.White;
            this.BtnHerramientas.HoverState.BorderColor = System.Drawing.Color.Black;
            this.BtnHerramientas.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnHerramientas.HoverState.Parent = this.BtnHerramientas;
            this.BtnHerramientas.Image = global::Presentación.Properties.Resources.icons8_sort_down_24;
            this.BtnHerramientas.Location = new System.Drawing.Point(974, 10);
            this.BtnHerramientas.Name = "BtnHerramientas";
            this.BtnHerramientas.ShadowDecoration.Parent = this.BtnHerramientas;
            this.BtnHerramientas.Size = new System.Drawing.Size(27, 27);
            this.BtnHerramientas.TabIndex = 97;
            this.BtnHerramientas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbAdorno
            // 
            this.lbAdorno.BackColor = System.Drawing.Color.Black;
            this.lbAdorno.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbAdorno.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdorno.ForeColor = System.Drawing.Color.White;
            this.lbAdorno.Location = new System.Drawing.Point(0, 0);
            this.lbAdorno.Name = "lbAdorno";
            this.lbAdorno.Size = new System.Drawing.Size(1006, 24);
            this.lbAdorno.TabIndex = 84;
            this.lbAdorno.Text = "Estado de Cuenta";
            this.lbAdorno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ListarCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1028, 602);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.lbTitulo);
            this.Name = "ListarCredito";
            this.Text = "Listar creditos";
            this.panel5.ResumeLayout(false);
            this.plSubMain.ResumeLayout(false);
            this.plDatosMenu.ResumeLayout(false);
            this.plGridControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.heritable2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            this.PlTools.ResumeLayout(false);
            this.FlowPanel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LukCliente.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Panel panel5;
        protected System.Windows.Forms.Panel plSubMain;
        protected System.Windows.Forms.Panel plDatosMenu;
        protected System.Windows.Forms.Panel plGridControl;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        protected System.Windows.Forms.Panel PlTools;
        private Guna.UI2.WinForms.Guna2TextBox txtTotal;
        protected System.Windows.Forms.Panel panel6;
        protected Presentación.Forms.Principal.Heredables.Force_Heritage flowLayoutPanel1;
        internal System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LookUpEdit LukCliente;
        protected Guna.UI2.WinForms.Guna2Button BtnHerramientas;
        protected System.Windows.Forms.Label lbAdorno;
        private System.Windows.Forms.FlowLayoutPanel FlowPanel1;
        protected Guna.UI2.WinForms.Guna2Button guna2Button1;
        protected Guna.UI2.WinForms.Guna2Button BtnPrint;
        protected Guna.UI2.WinForms.Guna2Button BtnAbonar;
        protected Guna.UI2.WinForms.Guna2Button BtnItemBajos;
        protected Guna.UI2.WinForms.Guna2Button BtnDetalles;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        protected Presentación.Forms.Principal.Heredables.Force_Heritage heritable2;
        internal System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.ComboBoxEdit lookUpEdit1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        internal System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox TxtSaldo;
        internal System.Windows.Forms.Label label5;
    }
}