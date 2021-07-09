
namespace Presentación.Forms.Secundario.Ventas
{
    partial class Venta_Granel
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
            this.PlMain = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TxtImporte = new DevExpress.XtraEditors.SpinEdit();
            this.TxtCantidad = new DevExpress.XtraEditors.SpinEdit();
            this.BtnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.BtnOk = new Guna.UI2.WinForms.Guna2Button();
            this.PriceTag = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbItem = new System.Windows.Forms.Label();
            this.PlMain.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtImporte.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCantidad.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // PlMain
            // 
            this.PlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.PlMain.Controls.Add(this.panel3);
            this.PlMain.Controls.Add(this.lbItem);
            this.PlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlMain.Location = new System.Drawing.Point(0, 0);
            this.PlMain.Name = "PlMain";
            this.PlMain.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.PlMain.Size = new System.Drawing.Size(584, 361);
            this.PlMain.TabIndex = 94;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.TxtImporte);
            this.panel3.Controls.Add(this.TxtCantidad);
            this.panel3.Controls.Add(this.BtnCancel);
            this.panel3.Controls.Add(this.BtnOk);
            this.panel3.Controls.Add(this.PriceTag);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(10, 58);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(15);
            this.panel3.Size = new System.Drawing.Size(564, 293);
            this.panel3.TabIndex = 658;
            // 
            // TxtImporte
            // 
            this.TxtImporte.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.TxtImporte.Location = new System.Drawing.Point(303, 90);
            this.TxtImporte.Name = "TxtImporte";
            this.TxtImporte.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtImporte.Properties.Appearance.Options.UseFont = true;
            this.TxtImporte.Properties.AutoHeight = false;
            this.TxtImporte.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtImporte.Size = new System.Drawing.Size(221, 32);
            this.TxtImporte.TabIndex = 656;
            this.TxtImporte.EditValueChanged += new System.EventHandler(this.TxtImporte_EditValueChanged);
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.TxtCantidad.Location = new System.Drawing.Point(42, 90);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantidad.Properties.Appearance.Options.UseFont = true;
            this.TxtCantidad.Properties.AutoHeight = false;
            this.TxtCantidad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtCantidad.Size = new System.Drawing.Size(221, 32);
            this.TxtCantidad.TabIndex = 655;
            this.TxtCantidad.EditValueChanged += new System.EventHandler(this.TxtCantidad_EditValueChanged);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.Animated = true;
            this.BtnCancel.AutoRoundedCorners = true;
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.BtnCancel.BorderColor = System.Drawing.Color.White;
            this.BtnCancel.BorderRadius = 16;
            this.BtnCancel.CheckedState.Parent = this.BtnCancel;
            this.BtnCancel.CustomImages.Parent = this.BtnCancel;
            this.BtnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.HoverState.BorderColor = System.Drawing.Color.Black;
            this.BtnCancel.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.HoverState.Parent = this.BtnCancel;
            this.BtnCancel.Image = global::Presentación.Properties.Resources.icons8_cancel_30;
            this.BtnCancel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnCancel.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.BtnCancel.Location = new System.Drawing.Point(348, 236);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(3, 15, 3, 5);
            this.BtnCancel.MinimumSize = new System.Drawing.Size(23, 29);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.BtnCancel.ShadowDecoration.Parent = this.BtnCancel;
            this.BtnCancel.Size = new System.Drawing.Size(95, 35);
            this.BtnCancel.TabIndex = 654;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnOk
            // 
            this.BtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOk.Animated = true;
            this.BtnOk.AutoRoundedCorners = true;
            this.BtnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.BtnOk.BorderColor = System.Drawing.Color.White;
            this.BtnOk.BorderRadius = 16;
            this.BtnOk.CheckedState.Parent = this.BtnOk;
            this.BtnOk.CustomImages.Parent = this.BtnOk;
            this.BtnOk.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.BtnOk.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnOk.ForeColor = System.Drawing.Color.White;
            this.BtnOk.HoverState.BorderColor = System.Drawing.Color.Black;
            this.BtnOk.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnOk.HoverState.Parent = this.BtnOk;
            this.BtnOk.Image = global::Presentación.Properties.Resources.icons8_ok_30;
            this.BtnOk.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnOk.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.BtnOk.Location = new System.Drawing.Point(449, 236);
            this.BtnOk.Margin = new System.Windows.Forms.Padding(3, 15, 3, 5);
            this.BtnOk.MinimumSize = new System.Drawing.Size(23, 29);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.BtnOk.ShadowDecoration.Parent = this.BtnOk;
            this.BtnOk.Size = new System.Drawing.Size(95, 35);
            this.BtnOk.TabIndex = 653;
            this.BtnOk.Text = "Aceptar";
            this.BtnOk.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // PriceTag
            // 
            this.PriceTag.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTag.ForeColor = System.Drawing.Color.White;
            this.PriceTag.Location = new System.Drawing.Point(36, 149);
            this.PriceTag.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.PriceTag.Name = "PriceTag";
            this.PriceTag.Size = new System.Drawing.Size(488, 37);
            this.PriceTag.TabIndex = 91;
            this.PriceTag.Text = "Precio Unitario = C${0}";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(299, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Importe Actual:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cantidad de Producto:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbItem
            // 
            this.lbItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbItem.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbItem.ForeColor = System.Drawing.Color.White;
            this.lbItem.Location = new System.Drawing.Point(10, 0);
            this.lbItem.Name = "lbItem";
            this.lbItem.Size = new System.Drawing.Size(564, 58);
            this.lbItem.TabIndex = 90;
            this.lbItem.Text = "{0}";
            this.lbItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Venta_Granel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.PlMain);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 350);
            this.Name = "Venta_Granel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Venta a Granel";
            this.PlMain.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TxtImporte.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCantidad.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PlMain;
        private System.Windows.Forms.Panel panel3;
        protected System.Windows.Forms.Label lbItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label PriceTag;
        protected Guna.UI2.WinForms.Guna2Button BtnOk;
        protected Guna.UI2.WinForms.Guna2Button BtnCancel;
        private DevExpress.XtraEditors.SpinEdit TxtCantidad;
        private DevExpress.XtraEditors.SpinEdit TxtImporte;
    }
}