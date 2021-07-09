
namespace Presentación.Forms.Secundario.Tiendas
{
    partial class FrmTienda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTienda));
            this.plPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lytControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton;
            this.BtnCerrar.CheckedState.Parent = this.BtnCerrar;
            this.BtnCerrar.CustomImages.Parent = this.BtnCerrar;
            this.BtnCerrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnCerrar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.BtnCerrar.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.HoverState.Image")));
            this.BtnCerrar.HoverState.Parent = this.BtnCerrar;
            this.BtnCerrar.ShadowDecoration.Parent = this.BtnCerrar;
            this.BtnCerrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnCerrar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BtnCerrar.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            // 
            // BottomMenu
            // 
            this.BottomMenu.AppearanceButton.Hovered.BackColor = System.Drawing.Color.White;
            this.BottomMenu.AppearanceButton.Hovered.FontSizeDelta = -1;
            this.BottomMenu.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.White;
            this.BottomMenu.AppearanceButton.Hovered.Options.UseBackColor = true;
            this.BottomMenu.AppearanceButton.Hovered.Options.UseFont = true;
            this.BottomMenu.AppearanceButton.Hovered.Options.UseForeColor = true;
            this.BottomMenu.AppearanceButton.Normal.FontSizeDelta = -1;
            this.BottomMenu.AppearanceButton.Normal.Options.UseFont = true;
            this.BottomMenu.AppearanceButton.Pressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.BottomMenu.AppearanceButton.Pressed.FontSizeDelta = -1;
            this.BottomMenu.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.BottomMenu.AppearanceButton.Pressed.Options.UseBackColor = true;
            this.BottomMenu.AppearanceButton.Pressed.Options.UseFont = true;
            this.BottomMenu.AppearanceButton.Pressed.Options.UseForeColor = true;
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.Buttons.Append.Visible = false;
            this.dataNavigator1.Buttons.CancelEdit.Visible = false;
            this.dataNavigator1.Buttons.EndEdit.Visible = false;
            this.dataNavigator1.Buttons.Remove.Enabled = false;
            this.dataNavigator1.Buttons.Remove.Visible = false;
            // 
            // FrmTienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 548);
            this.IconOptions.Image = global::Presentación.Properties.Resources.icons8_franchise_48;
            this.Name = "FrmTienda";
            this.Text = "FrmTienda";
            this.plPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lytControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}