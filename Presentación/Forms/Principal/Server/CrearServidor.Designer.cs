
using System.Windows.Forms;

namespace Presentación.Forms.Principal.Server
{
    partial class CrearServidor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearServidor));
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BD = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TxtCreateDb = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtCrearUser = new System.Windows.Forms.RichTextBox();
            this.BtnEjecutar = new Guna.UI2.WinForms.Guna2Button();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.ckCrearUsuario = new DevExpress.XtraEditors.CheckEdit();
            this.TxtPassword = new DevExpress.XtraEditors.TextEdit();
            this.TxtUserName = new DevExpress.XtraEditors.TextEdit();
            this.TxtDBName = new DevExpress.XtraEditors.TextEdit();
            this.TxtServerName = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.BD.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckCrearUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDBName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtServerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
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
            this.panel2.Controls.Add(this.BD);
            this.panel2.Controls.Add(this.BtnEjecutar);
            this.panel2.Controls.Add(this.layoutControl1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.panel2.Size = new System.Drawing.Size(375, 350);
            this.panel2.TabIndex = 2;
            // 
            // BD
            // 
            this.BD.Controls.Add(this.tabPage1);
            this.BD.Controls.Add(this.tabPage2);
            this.BD.Location = new System.Drawing.Point(191, 6);
            this.BD.Name = "BD";
            this.BD.SelectedIndex = 0;
            this.BD.Size = new System.Drawing.Size(147, 65);
            this.BD.TabIndex = 658;
            this.BD.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.TxtCreateDb);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(139, 39);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DB";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TxtCreateDb
            // 
            this.TxtCreateDb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCreateDb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtCreateDb.Location = new System.Drawing.Point(3, 3);
            this.TxtCreateDb.Name = "TxtCreateDb";
            this.TxtCreateDb.Size = new System.Drawing.Size(133, 33);
            this.TxtCreateDb.TabIndex = 657;
            this.TxtCreateDb.Text = "";
            this.TxtCreateDb.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtCrearUser);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(139, 39);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "User";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtCrearUser
            // 
            this.txtCrearUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCrearUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCrearUser.Location = new System.Drawing.Point(3, 3);
            this.txtCrearUser.Name = "txtCrearUser";
            this.txtCrearUser.Size = new System.Drawing.Size(133, 33);
            this.txtCrearUser.TabIndex = 0;
            this.txtCrearUser.Text = resources.GetString("txtCrearUser.Text");
            // 
            // BtnEjecutar
            // 
            this.BtnEjecutar.Animated = true;
            this.BtnEjecutar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.BtnEjecutar.BorderColor = System.Drawing.Color.White;
            this.BtnEjecutar.CheckedState.Parent = this.BtnEjecutar;
            this.BtnEjecutar.CustomImages.Parent = this.BtnEjecutar;
            this.BtnEjecutar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.BtnEjecutar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnEjecutar.ForeColor = System.Drawing.Color.White;
            this.BtnEjecutar.HoverState.BorderColor = System.Drawing.Color.Black;
            this.BtnEjecutar.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnEjecutar.HoverState.Parent = this.BtnEjecutar;
            this.BtnEjecutar.Image = global::Presentación.Properties.Resources.icons8_play_48;
            this.BtnEjecutar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnEjecutar.ImageOffset = new System.Drawing.Point(-2, 0);
            this.BtnEjecutar.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnEjecutar.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.BtnEjecutar.Location = new System.Drawing.Point(238, 292);
            this.BtnEjecutar.MinimumSize = new System.Drawing.Size(23, 29);
            this.BtnEjecutar.Name = "BtnEjecutar";
            this.BtnEjecutar.ShadowDecoration.Parent = this.BtnEjecutar;
            this.BtnEjecutar.Size = new System.Drawing.Size(100, 35);
            this.BtnEjecutar.TabIndex = 656;
            this.BtnEjecutar.Text = "Ejecutar";
            this.BtnEjecutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnEjecutar.Click += new System.EventHandler(this.BtnEjecutar_Click);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.ckCrearUsuario);
            this.layoutControl1.Controls.Add(this.TxtPassword);
            this.layoutControl1.Controls.Add(this.TxtUserName);
            this.layoutControl1.Controls.Add(this.TxtDBName);
            this.layoutControl1.Controls.Add(this.TxtServerName);
            this.layoutControl1.Location = new System.Drawing.Point(22, 74);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(328, 204);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // ckCrearUsuario
            // 
            this.ckCrearUsuario.Location = new System.Drawing.Point(126, 162);
            this.ckCrearUsuario.Name = "ckCrearUsuario";
            this.ckCrearUsuario.Properties.Caption = "";
            this.ckCrearUsuario.Size = new System.Drawing.Size(178, 18);
            this.ckCrearUsuario.StyleController = this.layoutControl1;
            this.ckCrearUsuario.TabIndex = 658;
            this.ckCrearUsuario.CheckedChanged += new System.EventHandler(this.ckCrearUsuario_CheckedChanged);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Enabled = false;
            this.TxtPassword.Location = new System.Drawing.Point(126, 138);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(178, 20);
            this.TxtPassword.StyleController = this.layoutControl1;
            this.TxtPassword.TabIndex = 11;
            // 
            // TxtUserName
            // 
            this.TxtUserName.Enabled = false;
            this.TxtUserName.Location = new System.Drawing.Point(126, 114);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(178, 20);
            this.TxtUserName.StyleController = this.layoutControl1;
            this.TxtUserName.TabIndex = 10;
            // 
            // TxtDBName
            // 
            this.TxtDBName.Location = new System.Drawing.Point(114, 36);
            this.TxtDBName.Name = "TxtDBName";
            this.TxtDBName.Size = new System.Drawing.Size(202, 20);
            this.TxtDBName.StyleController = this.layoutControl1;
            this.TxtDBName.TabIndex = 5;
            // 
            // TxtServerName
            // 
            this.TxtServerName.Location = new System.Drawing.Point(114, 12);
            this.TxtServerName.Name = "TxtServerName";
            this.TxtServerName.Size = new System.Drawing.Size(202, 20);
            this.TxtServerName.StyleController = this.layoutControl1;
            this.TxtServerName.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlGroup1,
            this.emptySpaceItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(328, 204);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.TxtServerName;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(308, 24);
            this.layoutControlItem1.Text = "Nombre de Instancia";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(99, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.TxtDBName;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(308, 24);
            this.layoutControlItem2.Text = "Base de Datos";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(99, 13);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem6,
            this.layoutControlItem7});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 69);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(308, 115);
            this.layoutControlGroup1.Text = "Usuario Master";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.TxtUserName;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(284, 24);
            this.layoutControlItem4.Text = "Nombre de Usuario";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(99, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.TxtPassword;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(284, 24);
            this.layoutControlItem6.Text = "Contraseña";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(99, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.ckCrearUsuario;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(284, 22);
            this.layoutControlItem7.Text = "Crear Usuario";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(99, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 48);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(308, 21);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 51);
            this.label2.TabIndex = 2;
            this.label2.Text = "Crear Base de Datos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.panel1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CrearServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 390);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrearServidor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.BD.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ckCrearUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDBName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtServerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit TxtDBName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        protected Guna.UI2.WinForms.Guna2Button BtnEjecutar;
        private RichTextBox TxtCreateDb;
        private DevExpress.XtraEditors.CheckEdit ckCrearUsuario;
        private DevExpress.XtraEditors.TextEdit TxtPassword;
        private DevExpress.XtraEditors.TextEdit TxtUserName;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.TextEdit TxtServerName;
        private TabControl BD;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private RichTextBox txtCrearUser;
        private OpenFileDialog openFileDialog1;
    }
}