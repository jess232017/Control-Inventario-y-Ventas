
namespace Presentación.Forms.Caja
{
    partial class OpcionCierre
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.BtnSalir = new Guna.UI2.WinForms.Guna2Button();
            this.BtnCerrar = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.panel2.Controls.Add(this.guna2Panel1);
            this.panel2.Controls.Add(this.BtnSalir);
            this.panel2.Controls.Add(this.BtnCerrar);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.panel2.Size = new System.Drawing.Size(373, 289);
            this.panel2.TabIndex = 3;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Gray;
            this.guna2Panel1.BorderRadius = 5;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.guna2Button3);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(30, 224);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(5);
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(313, 45);
            this.guna2Panel1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(27, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(281, 35);
            this.label5.TabIndex = 0;
            this.label5.Text = "Si dejas tu turno abierto solo tu o un Administrador podrán abrir el programa";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Button3
            // 
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Image = global::Presentación.Properties.Resources.icons8_error_48;
            this.guna2Button3.Location = new System.Drawing.Point(5, 5);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(22, 35);
            this.guna2Button3.TabIndex = 1;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BorderRadius = 16;
            this.BtnSalir.CheckedState.Parent = this.BtnSalir;
            this.BtnSalir.CustomImages.Parent = this.BtnSalir;
            this.BtnSalir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnSalir.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.BtnSalir.ForeColor = System.Drawing.Color.White;
            this.BtnSalir.HoverState.Parent = this.BtnSalir;
            this.BtnSalir.Image = global::Presentación.Properties.Resources.icons8_exit_48;
            this.BtnSalir.Location = new System.Drawing.Point(36, 154);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.ShadowDecoration.Parent = this.BtnSalir;
            this.BtnSalir.Size = new System.Drawing.Size(309, 40);
            this.BtnSalir.TabIndex = 12;
            this.BtnSalir.Text = "Dejar turno abierto y Salir...";
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BorderRadius = 16;
            this.BtnCerrar.CheckedState.Parent = this.BtnCerrar;
            this.BtnCerrar.CustomImages.Parent = this.BtnCerrar;
            this.BtnCerrar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.BtnCerrar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.HoverState.Parent = this.BtnCerrar;
            this.BtnCerrar.Image = global::Presentación.Properties.Resources.icons8_exit_48__1_;
            this.BtnCerrar.Location = new System.Drawing.Point(36, 106);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.ShadowDecoration.Parent = this.BtnCerrar;
            this.BtnCerrar.Size = new System.Drawing.Size(306, 40);
            this.BtnCerrar.TabIndex = 11;
            this.BtnCerrar.Text = "Cerrar Turno ...";
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(30, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(313, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "Por favor elige la opción que deseas...";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Salir del Sistema";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OpcionCierre
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 289);
            this.Controls.Add(this.panel2);
            this.IconOptions.Image = global::Presentación.Properties.Resources.icons8_cash_register_48;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(375, 321);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(375, 321);
            this.Name = "OpcionCierre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Inventario -> Cerrar Caja";
            this.panel2.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button BtnSalir;
        private Guna.UI2.WinForms.Guna2Button BtnCerrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}