
namespace Presentación.Forms.Principal.Registro
{
    partial class Iniciar_Sesion
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
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.ControlClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSetServer = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CbxIntegratedSecurity = new Guna.UI2.WinForms.Guna2CheckBox();
            this.BtnIngresar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkRestaurar = new System.Windows.Forms.LinkLabel();
            this.txtPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // ControlClose
            // 
            this.ControlClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.ControlClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.ControlClose.HoverState.FillColor = System.Drawing.Color.Red;
            this.ControlClose.HoverState.Parent = this.ControlClose;
            this.ControlClose.IconColor = System.Drawing.Color.White;
            this.ControlClose.Location = new System.Drawing.Point(335, 0);
            this.ControlClose.Name = "ControlClose";
            this.ControlClose.ShadowDecoration.Parent = this.ControlClose;
            this.ControlClose.Size = new System.Drawing.Size(40, 40);
            this.ControlClose.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnSetServer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ControlClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 40);
            this.panel1.TabIndex = 1;
            // 
            // BtnSetServer
            // 
            this.BtnSetServer.CheckedState.Parent = this.BtnSetServer;
            this.BtnSetServer.CustomImages.Parent = this.BtnSetServer;
            this.BtnSetServer.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnSetServer.FillColor = System.Drawing.Color.Transparent;
            this.BtnSetServer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnSetServer.ForeColor = System.Drawing.Color.White;
            this.BtnSetServer.HoverState.Parent = this.BtnSetServer;
            this.BtnSetServer.Image = global::Presentación.Properties.Resources.icons8_settings_32;
            this.BtnSetServer.Location = new System.Drawing.Point(295, 0);
            this.BtnSetServer.Name = "BtnSetServer";
            this.BtnSetServer.ShadowDecoration.Parent = this.BtnSetServer;
            this.BtnSetServer.Size = new System.Drawing.Size(40, 40);
            this.BtnSetServer.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Punto de Venta";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CbxIntegratedSecurity);
            this.panel2.Controls.Add(this.BtnIngresar);
            this.panel2.Controls.Add(this.guna2CirclePictureBox1);
            this.panel2.Controls.Add(this.guna2Separator1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.linkLabel2);
            this.panel2.Controls.Add(this.linkRestaurar);
            this.panel2.Controls.Add(this.txtPass);
            this.panel2.Controls.Add(this.txtUser);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.panel2.Size = new System.Drawing.Size(375, 537);
            this.panel2.TabIndex = 2;
            // 
            // CbxIntegratedSecurity
            // 
            this.CbxIntegratedSecurity.AutoSize = true;
            this.CbxIntegratedSecurity.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.CbxIntegratedSecurity.CheckedState.BorderRadius = 3;
            this.CbxIntegratedSecurity.CheckedState.BorderThickness = 0;
            this.CbxIntegratedSecurity.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.CbxIntegratedSecurity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CbxIntegratedSecurity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CbxIntegratedSecurity.Location = new System.Drawing.Point(230, 335);
            this.CbxIntegratedSecurity.Name = "CbxIntegratedSecurity";
            this.CbxIntegratedSecurity.Size = new System.Drawing.Size(122, 17);
            this.CbxIntegratedSecurity.TabIndex = 11;
            this.CbxIntegratedSecurity.Text = "Seguridad Integrada";
            this.CbxIntegratedSecurity.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CbxIntegratedSecurity.UncheckedState.BorderRadius = 3;
            this.CbxIntegratedSecurity.UncheckedState.BorderThickness = 0;
            this.CbxIntegratedSecurity.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnIngresar.AutoRoundedCorners = true;
            this.BtnIngresar.BackColor = System.Drawing.Color.Transparent;
            this.BtnIngresar.BorderRadius = 19;
            this.BtnIngresar.CheckedState.Parent = this.BtnIngresar;
            this.BtnIngresar.CustomImages.Parent = this.BtnIngresar;
            this.BtnIngresar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.BtnIngresar.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.BtnIngresar.ForeColor = System.Drawing.Color.White;
            this.BtnIngresar.HoverState.Parent = this.BtnIngresar;
            this.BtnIngresar.Location = new System.Drawing.Point(33, 360);
            this.BtnIngresar.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.ShadowDecoration.Parent = this.BtnIngresar;
            this.BtnIngresar.Size = new System.Drawing.Size(116, 40);
            this.BtnIngresar.TabIndex = 3;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseTransparentBackground = true;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::Presentación.Properties.Resources.Avatar1;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(131, 100);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(100, 100);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 10;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Separator1.FillColor = System.Drawing.Color.Gray;
            this.guna2Separator1.FillStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.guna2Separator1.Location = new System.Drawing.Point(30, 463);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(315, 10);
            this.guna2Separator1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(30, 473);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Punto de venta 0.2.0, Hecho en Nicaragua";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.Gray;
            this.linkLabel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linkLabel2.LinkColor = System.Drawing.Color.SteelBlue;
            this.linkLabel2.Location = new System.Drawing.Point(30, 504);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(315, 13);
            this.linkLabel2.TabIndex = 9;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "https://AlkFramework.com";
            this.linkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkRestaurar
            // 
            this.linkRestaurar.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.linkRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkRestaurar.AutoSize = true;
            this.linkRestaurar.LinkColor = System.Drawing.Color.Silver;
            this.linkRestaurar.Location = new System.Drawing.Point(236, 416);
            this.linkRestaurar.Name = "linkRestaurar";
            this.linkRestaurar.Size = new System.Drawing.Size(106, 13);
            this.linkRestaurar.TabIndex = 4;
            this.linkRestaurar.TabStop = true;
            this.linkRestaurar.Text = "Olvide mi contraseña";
            this.linkRestaurar.Visible = false;
            // 
            // txtPass
            // 
            this.txtPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPass.Animated = true;
            this.txtPass.BackColor = System.Drawing.Color.White;
            this.txtPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.DefaultText = "";
            this.txtPass.DisabledState.Parent = this.txtPass;
            this.txtPass.FocusedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txtPass.FocusedState.Parent = this.txtPass;
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtPass.ForeColor = System.Drawing.Color.Black;
            this.txtPass.HoverState.Parent = this.txtPass;
            this.txtPass.IconLeft = global::Presentación.Properties.Resources.icons8_lock_48;
            this.txtPass.IconRight = global::Presentación.Properties.Resources.icons8_hide_32;
            this.txtPass.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.txtPass.Location = new System.Drawing.Point(33, 298);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.txtPass.MaxLength = 6;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '\0';
            this.txtPass.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPass.PlaceholderText = "Contraseña";
            this.txtPass.SelectedText = "";
            this.txtPass.ShadowDecoration.Parent = this.txtPass;
            this.txtPass.Size = new System.Drawing.Size(312, 32);
            this.txtPass.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtPass.TabIndex = 2;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtUser
            // 
            this.txtUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUser.Animated = true;
            this.txtUser.BackColor = System.Drawing.Color.White;
            this.txtUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.DefaultText = "";
            this.txtUser.DisabledState.Parent = this.txtUser;
            this.txtUser.FocusedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txtUser.FocusedState.Parent = this.txtUser;
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtUser.ForeColor = System.Drawing.Color.Black;
            this.txtUser.HoverState.Parent = this.txtUser;
            this.txtUser.IconLeft = global::Presentación.Properties.Resources.icons8_name_48;
            this.txtUser.Location = new System.Drawing.Point(33, 236);
            this.txtUser.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUser.PlaceholderText = "Usuario";
            this.txtUser.SelectedText = "";
            this.txtUser.ShadowDecoration.Parent = this.txtUser;
            this.txtUser.Size = new System.Drawing.Size(312, 32);
            this.txtUser.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtUser.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 56);
            this.label2.TabIndex = 2;
            this.label2.Text = "Iniciar Sesion";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.panel1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // Iniciar_Sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(375, 577);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Iniciar_Sesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar";
            this.Load += new System.EventHandler(this.Iniciar_Sesion_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2ControlBox ControlClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2TextBox txtPass;
        public Guna.UI2.WinForms.Guna2TextBox txtUser;
        private System.Windows.Forms.LinkLabel linkRestaurar;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Button BtnIngresar;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Button BtnSetServer;
        private Guna.UI2.WinForms.Guna2CheckBox CbxIntegratedSecurity;
    }
}