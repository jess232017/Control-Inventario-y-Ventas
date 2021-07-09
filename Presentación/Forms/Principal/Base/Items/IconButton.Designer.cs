
namespace Presentación.Forms.Principal.Heredables.Items
{
    partial class IconButton
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Texto = new System.Windows.Forms.Label();
            this.Imagen = new Guna.UI2.WinForms.Guna2PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // Texto
            // 
            this.Texto.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Texto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Texto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Texto.Location = new System.Drawing.Point(0, 52);
            this.Texto.Name = "Texto";
            this.Texto.Size = new System.Drawing.Size(80, 23);
            this.Texto.TabIndex = 4;
            this.Texto.Text = "Usuarios";
            this.Texto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Imagen
            // 
            this.Imagen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Imagen.Image = global::Presentación.Properties.Resources.icons8_shop_48;
            this.Imagen.Location = new System.Drawing.Point(0, 0);
            this.Imagen.Name = "Imagen";
            this.Imagen.ShadowDecoration.Parent = this.Imagen;
            this.Imagen.Size = new System.Drawing.Size(80, 52);
            this.Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Imagen.TabIndex = 5;
            this.Imagen.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            // 
            // IconButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.Imagen);
            this.Controls.Add(this.Texto);
            this.Name = "IconButton";
            this.Size = new System.Drawing.Size(80, 75);
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        internal System.Windows.Forms.Label Texto;
        private Guna.UI2.WinForms.Guna2PictureBox Imagen;
        private System.Windows.Forms.Timer timer1;
    }
}
