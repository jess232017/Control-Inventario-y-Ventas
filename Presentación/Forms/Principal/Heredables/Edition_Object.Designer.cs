
namespace Presentación.Forms.Principal.Heredables
{
    partial class Edition_Object
    {

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
        protected void InitializeComponent()
        {
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions2 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions3 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions4 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions5 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions6 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edition_Object));
            this.lbTitulo = new System.Windows.Forms.Label();
            this.plPrincipal = new System.Windows.Forms.Panel();
            this.lytControl = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.dataNavigator1 = new DevExpress.XtraEditors.DataNavigator();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BottomMenu = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.BtnCerrar = new Guna.UI2.WinForms.Guna2Button();
            this.plPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lytControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
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
            this.lbTitulo.Size = new System.Drawing.Size(718, 58);
            this.lbTitulo.TabIndex = 89;
            this.lbTitulo.Text = "{0}";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plPrincipal
            // 
            this.plPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.plPrincipal.Controls.Add(this.lytControl);
            this.plPrincipal.Controls.Add(this.dataNavigator1);
            this.plPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plPrincipal.Location = new System.Drawing.Point(0, 58);
            this.plPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.plPrincipal.Name = "plPrincipal";
            this.plPrincipal.Padding = new System.Windows.Forms.Padding(20);
            this.plPrincipal.Size = new System.Drawing.Size(718, 420);
            this.plPrincipal.TabIndex = 91;
            // 
            // lytControl
            // 
            this.lytControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lytControl.Location = new System.Drawing.Point(20, 20);
            this.lytControl.Name = "lytControl";
            this.lytControl.Root = this.Root;
            this.lytControl.Size = new System.Drawing.Size(678, 350);
            this.lytControl.TabIndex = 0;
            this.lytControl.Text = "dataLayoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(678, 350);
            this.Root.TextVisible = false;
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.Buttons.Append.Visible = false;
            this.dataNavigator1.Buttons.CancelEdit.Visible = false;
            this.dataNavigator1.Buttons.EndEdit.Visible = false;
            this.dataNavigator1.Buttons.Remove.Enabled = false;
            this.dataNavigator1.Buttons.Remove.Visible = false;
            this.dataNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataNavigator1.Location = new System.Drawing.Point(20, 370);
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.Size = new System.Drawing.Size(678, 30);
            this.dataNavigator1.TabIndex = 2;
            this.dataNavigator1.Text = "dataNavigator1";
            this.dataNavigator1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            this.BottomMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            windowsUIButtonImageOptions1.ImageUri.Uri = "Save;Size32x32;GrayScaled";
            windowsUIButtonImageOptions2.ImageUri.Uri = "SaveAndClose;Size32x32;GrayScaled";
            windowsUIButtonImageOptions3.ImageUri.Uri = "SaveAndNew;Size32x32;GrayScaled";
            windowsUIButtonImageOptions4.ImageUri.Uri = "Reset;Size32x32;GrayScaled";
            windowsUIButtonImageOptions5.ImageUri.Uri = "Edit/Delete;Size32x32;GrayScaled";
            windowsUIButtonImageOptions6.ImageUri.Uri = "Print";
            this.BottomMenu.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Guardar", true, windowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Guardar y Cerrar", true, windowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Guardar Como", true, windowsUIButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Deshacer Cambios", true, windowsUIButtonImageOptions4, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Eliminar", true, windowsUIButtonImageOptions5, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Imprimir", true, windowsUIButtonImageOptions6, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
            this.BottomMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomMenu.EnableImageTransparency = true;
            this.BottomMenu.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BottomMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.BottomMenu.Location = new System.Drawing.Point(0, 478);
            this.BottomMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BottomMenu.MaximumSize = new System.Drawing.Size(0, 70);
            this.BottomMenu.MinimumSize = new System.Drawing.Size(60, 60);
            this.BottomMenu.Name = "BottomMenu";
            this.BottomMenu.Size = new System.Drawing.Size(718, 70);
            this.BottomMenu.TabIndex = 90;
            this.BottomMenu.Text = "Menu Inferior";
            this.BottomMenu.UseButtonBackgroundImages = false;
            this.BottomMenu.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.BottomMenu_ButtonClick);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BtnCerrar.CheckedState.Parent = this.BtnCerrar;
            this.BtnCerrar.CustomImages.Parent = this.BtnCerrar;
            this.BtnCerrar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.BtnCerrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.BtnCerrar.HoverState.Image = global::Presentación.Properties.Resources.icons8_back_arrow_30;
            this.BtnCerrar.HoverState.Parent = this.BtnCerrar;
            this.BtnCerrar.Image = global::Presentación.Properties.Resources.icons8_back_arrow_30;
            this.BtnCerrar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnCerrar.ImageSize = new System.Drawing.Size(32, 32);
            this.BtnCerrar.Location = new System.Drawing.Point(0, 12);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.ShadowDecoration.Parent = this.BtnCerrar;
            this.BtnCerrar.Size = new System.Drawing.Size(49, 37);
            this.BtnCerrar.TabIndex = 92;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // Edition_Object
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 548);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.plPrincipal);
            this.Controls.Add(this.BottomMenu);
            this.Controls.Add(this.lbTitulo);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Edition_Object.IconOptions.Image")));
            this.Name = "Edition_Object";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "{0}";
            this.plPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lytControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Label lbTitulo;
        protected System.Windows.Forms.Panel plPrincipal;
        protected Guna.UI2.WinForms.Guna2Button BtnCerrar;
        protected System.Windows.Forms.OpenFileDialog openFileDialog1;
        protected DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel BottomMenu;
        protected DevExpress.XtraDataLayout.DataLayoutControl lytControl;
        protected DevExpress.XtraLayout.LayoutControlGroup Root;
        protected DevExpress.XtraEditors.DataNavigator dataNavigator1;
        private System.ComponentModel.IContainer components;
    }
}