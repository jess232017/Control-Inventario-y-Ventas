
namespace Presentación.Forms.Secundario.Contable
{
    partial class RegistrarIngreso
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
            this.LbTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtImporte = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.BtnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDetalle = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DatePicker = new DevExpress.XtraEditors.DateEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatePicker.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatePicker.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LbTitulo
            // 
            this.LbTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.LbTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.LbTitulo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitulo.ForeColor = System.Drawing.Color.White;
            this.LbTitulo.Location = new System.Drawing.Point(15, 0);
            this.LbTitulo.Name = "LbTitulo";
            this.LbTitulo.Size = new System.Drawing.Size(570, 58);
            this.LbTitulo.TabIndex = 91;
            this.LbTitulo.Text = "Entrada de Efectivo";
            this.LbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TxtImporte);
            this.panel1.Controls.Add(this.BtnCancelar);
            this.panel1.Controls.Add(this.BtnGuardar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TxtDetalle);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DatePicker);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(15, 58);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15);
            this.panel1.Size = new System.Drawing.Size(570, 329);
            this.panel1.TabIndex = 92;
            // 
            // TxtImporte
            // 
            this.TxtImporte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtImporte.BackColor = System.Drawing.Color.White;
            this.TxtImporte.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtImporte.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtImporte.DefaultText = "";
            this.TxtImporte.DisabledState.Parent = this.TxtImporte;
            this.TxtImporte.FocusedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.TxtImporte.FocusedState.Parent = this.TxtImporte;
            this.TxtImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TxtImporte.ForeColor = System.Drawing.Color.Black;
            this.TxtImporte.HoverState.Parent = this.TxtImporte;
            this.TxtImporte.IconLeft = global::Presentación.Properties.Resources.icons8_money_48;
            this.TxtImporte.Location = new System.Drawing.Point(187, 63);
            this.TxtImporte.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.TxtImporte.Name = "TxtImporte";
            this.TxtImporte.PasswordChar = '\0';
            this.TxtImporte.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtImporte.PlaceholderText = "C$";
            this.TxtImporte.SelectedText = "";
            this.TxtImporte.ShadowDecoration.Parent = this.TxtImporte;
            this.TxtImporte.Size = new System.Drawing.Size(311, 32);
            this.TxtImporte.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TxtImporte.TabIndex = 662;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Animated = true;
            this.BtnCancelar.BorderColor = System.Drawing.Color.Gray;
            this.BtnCancelar.CheckedState.Parent = this.BtnCancelar;
            this.BtnCancelar.CustomImages.Parent = this.BtnCancelar;
            this.BtnCancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.BtnCancelar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnCancelar.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.HoverState.Parent = this.BtnCancelar;
            this.BtnCancelar.Image = global::Presentación.Properties.Resources.icons8_cancel_32;
            this.BtnCancelar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnCancelar.ImageSize = new System.Drawing.Size(18, 18);
            this.BtnCancelar.Location = new System.Drawing.Point(292, 233);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.ShadowDecoration.Parent = this.BtnCancelar;
            this.BtnCancelar.Size = new System.Drawing.Size(100, 35);
            this.BtnCancelar.TabIndex = 659;
            this.BtnCancelar.Text = "Cerrar";
            this.BtnCancelar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Animated = true;
            this.BtnGuardar.BorderColor = System.Drawing.Color.Gray;
            this.BtnGuardar.CheckedState.Parent = this.BtnGuardar;
            this.BtnGuardar.CustomImages.Parent = this.BtnGuardar;
            this.BtnGuardar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.BtnGuardar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnGuardar.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.HoverState.Parent = this.BtnGuardar;
            this.BtnGuardar.Image = global::Presentación.Properties.Resources.icons8_save_32;
            this.BtnGuardar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnGuardar.ImageSize = new System.Drawing.Size(18, 18);
            this.BtnGuardar.Location = new System.Drawing.Point(398, 233);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.ShadowDecoration.Parent = this.BtnGuardar;
            this.BtnGuardar.Size = new System.Drawing.Size(100, 35);
            this.BtnGuardar.TabIndex = 658;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(46, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha de Ingreso:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtDetalle
            // 
            this.TxtDetalle.BackColor = System.Drawing.Color.White;
            this.TxtDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDetalle.ForeColor = System.Drawing.Color.Black;
            this.TxtDetalle.Location = new System.Drawing.Point(187, 156);
            this.TxtDetalle.Name = "TxtDetalle";
            this.TxtDetalle.Size = new System.Drawing.Size(311, 64);
            this.TxtDetalle.TabIndex = 7;
            this.TxtDetalle.Text = "";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(79, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Detalle:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cantidad:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DatePicker
            // 
            this.DatePicker.EditValue = null;
            this.DatePicker.Location = new System.Drawing.Point(187, 108);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Properties.AutoHeight = false;
            this.DatePicker.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DatePicker.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DatePicker.Properties.ContextImageOptions.Image = global::Presentación.Properties.Resources.icons8_calendar_20;
            this.DatePicker.Properties.DisplayFormat.FormatString = "";
            this.DatePicker.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DatePicker.Properties.EditFormat.FormatString = "";
            this.DatePicker.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DatePicker.Properties.NullText = "[Vacío]";
            this.DatePicker.Size = new System.Drawing.Size(311, 32);
            this.DatePicker.TabIndex = 657;
            // 
            // RegistrarIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(600, 402);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LbTitulo);
            this.Name = "RegistrarIngreso";
            this.Padding = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registrar Ingreso";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatePicker.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatePicker.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Label LbTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox TxtDetalle;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.DateEdit DatePicker;
        protected Guna.UI2.WinForms.Guna2Button BtnGuardar;
        protected Guna.UI2.WinForms.Guna2Button BtnCancelar;
        public Guna.UI2.WinForms.Guna2TextBox TxtImporte;
    }
}