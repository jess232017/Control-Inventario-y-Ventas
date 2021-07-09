
using System.Windows.Forms;

namespace Presentación.Forms.Principal.Registro
{
    partial class Restaurar_Pass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Restaurar_Pass));
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rtbMensaje = new System.Windows.Forms.RichTextBox();
            this.BtnRestaurar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.LbAclaracion = new System.Windows.Forms.Label();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(335, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(40, 40);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.guna2ControlBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 40);
            this.panel1.TabIndex = 1;
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
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.panel2.Controls.Add(this.rtbMensaje);
            this.panel2.Controls.Add(this.BtnRestaurar);
            this.panel2.Controls.Add(this.guna2Separator1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.linkLabel2);
            this.panel2.Controls.Add(this.LbAclaracion);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.panel2.Size = new System.Drawing.Size(375, 296);
            this.panel2.TabIndex = 2;
            // 
            // rtbMensaje
            // 
            this.rtbMensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.rtbMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbMensaje.ForeColor = System.Drawing.Color.White;
            this.rtbMensaje.Location = new System.Drawing.Point(218, 191);
            this.rtbMensaje.Name = "rtbMensaje";
            this.rtbMensaje.Size = new System.Drawing.Size(131, 25);
            this.rtbMensaje.TabIndex = 10;
            this.rtbMensaje.Text = resources.GetString("rtbMensaje.Text");
            this.rtbMensaje.Visible = false;
            // 
            // BtnRestaurar
            // 
            this.BtnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRestaurar.AutoRoundedCorners = true;
            this.BtnRestaurar.BackColor = System.Drawing.Color.Transparent;
            this.BtnRestaurar.BorderRadius = 19;
            this.BtnRestaurar.CheckedState.Parent = this.BtnRestaurar;
            this.BtnRestaurar.CustomImages.Parent = this.BtnRestaurar;
            this.BtnRestaurar.FillColor = System.Drawing.Color.DodgerBlue;
            this.BtnRestaurar.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.BtnRestaurar.ForeColor = System.Drawing.Color.White;
            this.BtnRestaurar.HoverState.Parent = this.BtnRestaurar;
            this.BtnRestaurar.Location = new System.Drawing.Point(33, 148);
            this.BtnRestaurar.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.BtnRestaurar.Name = "BtnRestaurar";
            this.BtnRestaurar.ShadowDecoration.Parent = this.BtnRestaurar;
            this.BtnRestaurar.Size = new System.Drawing.Size(116, 40);
            this.BtnRestaurar.TabIndex = 3;
            this.BtnRestaurar.Text = "Restaurar";
            this.BtnRestaurar.UseTransparentBackground = true;
            this.BtnRestaurar.Click += new System.EventHandler(this.BtnRestaurar_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Separator1.FillColor = System.Drawing.Color.Gray;
            this.guna2Separator1.FillStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.guna2Separator1.Location = new System.Drawing.Point(30, 222);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(315, 10);
            this.guna2Separator1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(30, 232);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Punto de venta 0.0.1, Hecho en Nicaragua";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.Gray;
            this.linkLabel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linkLabel2.LinkColor = System.Drawing.Color.SteelBlue;
            this.linkLabel2.Location = new System.Drawing.Point(30, 263);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(315, 13);
            this.linkLabel2.TabIndex = 9;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "https://AlkFramework.com";
            this.linkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbAclaracion
            // 
            this.LbAclaracion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LbAclaracion.AutoSize = true;
            this.LbAclaracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LbAclaracion.Location = new System.Drawing.Point(188, 120);
            this.LbAclaracion.Name = "LbAclaracion";
            this.LbAclaracion.Size = new System.Drawing.Size(161, 13);
            this.LbAclaracion.TabIndex = 4;
            this.LbAclaracion.TabStop = true;
            this.LbAclaracion.Text = "*Con el que registrates tu cuenta";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.Parent = this.txtEmail;
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txtEmail.FocusedState.Parent = this.txtEmail;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.HoverState.Parent = this.txtEmail;
            this.txtEmail.IconLeft = global::Presentación.Properties.Resources.icons8_mail_48;
            this.txtEmail.Location = new System.Drawing.Point(33, 86);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.PlaceholderText = "Correo electronico";
            this.txtEmail.SelectedText = "";
            this.txtEmail.ShadowDecoration.Parent = this.txtEmail;
            this.txtEmail.Size = new System.Drawing.Size(312, 32);
            this.txtEmail.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtEmail.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 51);
            this.label2.TabIndex = 2;
            this.label2.Text = "Restaurar contraseña";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.panel1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // Restaurar_Pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 336);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Restaurar_Pass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private System.Windows.Forms.Label LbAclaracion;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Button BtnRestaurar;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private RichTextBox rtbMensaje;
    }
}