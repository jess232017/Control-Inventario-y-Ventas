
using System.Windows.Forms;

namespace Presentación.Forms.Principal.Server
{
    partial class Cambiar_Server
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
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtInitCatalog = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnCambiar = new Guna.UI2.WinForms.Guna2Button();
            this.txtServerName = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.panel2.Controls.Add(this.TxtInitCatalog);
            this.panel2.Controls.Add(this.BtnCambiar);
            this.panel2.Controls.Add(this.txtServerName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.panel2.Size = new System.Drawing.Size(375, 276);
            this.panel2.TabIndex = 2;
            // 
            // TxtInitCatalog
            // 
            this.TxtInitCatalog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtInitCatalog.BackColor = System.Drawing.Color.White;
            this.TxtInitCatalog.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtInitCatalog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtInitCatalog.DefaultText = "";
            this.TxtInitCatalog.DisabledState.Parent = this.TxtInitCatalog;
            this.TxtInitCatalog.FocusedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.TxtInitCatalog.FocusedState.Parent = this.TxtInitCatalog;
            this.TxtInitCatalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TxtInitCatalog.ForeColor = System.Drawing.Color.Black;
            this.TxtInitCatalog.HoverState.Parent = this.TxtInitCatalog;
            this.TxtInitCatalog.IconLeft = global::Presentación.Properties.Resources.icons8_database_administrator_48;
            this.TxtInitCatalog.Location = new System.Drawing.Point(33, 148);
            this.TxtInitCatalog.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.TxtInitCatalog.Name = "TxtInitCatalog";
            this.TxtInitCatalog.PasswordChar = '\0';
            this.TxtInitCatalog.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtInitCatalog.PlaceholderText = "Catalogo Inicial";
            this.TxtInitCatalog.SelectedText = "";
            this.TxtInitCatalog.ShadowDecoration.Parent = this.TxtInitCatalog;
            this.TxtInitCatalog.Size = new System.Drawing.Size(312, 32);
            this.TxtInitCatalog.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TxtInitCatalog.TabIndex = 4;
            // 
            // BtnCambiar
            // 
            this.BtnCambiar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCambiar.AutoRoundedCorners = true;
            this.BtnCambiar.BackColor = System.Drawing.Color.Transparent;
            this.BtnCambiar.BorderRadius = 19;
            this.BtnCambiar.CheckedState.Parent = this.BtnCambiar;
            this.BtnCambiar.CustomImages.Parent = this.BtnCambiar;
            this.BtnCambiar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.BtnCambiar.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.BtnCambiar.ForeColor = System.Drawing.Color.White;
            this.BtnCambiar.HoverState.Parent = this.BtnCambiar;
            this.BtnCambiar.Location = new System.Drawing.Point(229, 210);
            this.BtnCambiar.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.BtnCambiar.Name = "BtnCambiar";
            this.BtnCambiar.ShadowDecoration.Parent = this.BtnCambiar;
            this.BtnCambiar.Size = new System.Drawing.Size(116, 40);
            this.BtnCambiar.TabIndex = 3;
            this.BtnCambiar.Text = "Cambiar";
            this.BtnCambiar.UseTransparentBackground = true;
            this.BtnCambiar.Click += new System.EventHandler(this.BtnCambiar_Click);
            // 
            // txtServerName
            // 
            this.txtServerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServerName.BackColor = System.Drawing.Color.White;
            this.txtServerName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtServerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtServerName.DefaultText = "";
            this.txtServerName.DisabledState.Parent = this.txtServerName;
            this.txtServerName.FocusedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txtServerName.FocusedState.Parent = this.txtServerName;
            this.txtServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtServerName.ForeColor = System.Drawing.Color.Black;
            this.txtServerName.HoverState.Parent = this.txtServerName;
            this.txtServerName.IconLeft = global::Presentación.Properties.Resources.icons8_database_administrator_48;
            this.txtServerName.Location = new System.Drawing.Point(33, 86);
            this.txtServerName.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.PasswordChar = '\0';
            this.txtServerName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtServerName.PlaceholderText = "Nombre del Servidor";
            this.txtServerName.SelectedText = "";
            this.txtServerName.ShadowDecoration.Parent = this.txtServerName;
            this.txtServerName.Size = new System.Drawing.Size(312, 32);
            this.txtServerName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtServerName.TabIndex = 1;
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
            this.label2.Text = "Cambiar Server";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.panel1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // Cambiar_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 316);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cambiar_Server";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2TextBox txtServerName;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Button BtnCambiar;
        public Guna.UI2.WinForms.Guna2TextBox TxtInitCatalog;
    }
}