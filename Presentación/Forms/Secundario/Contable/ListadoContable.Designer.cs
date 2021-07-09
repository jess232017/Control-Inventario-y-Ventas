
namespace Presentación.Forms.Secundario.Contable
{
    partial class ListadoContable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoContable));
            this.PlMain = new System.Windows.Forms.Panel();
            this.TabControl = new DevExpress.XtraTab.XtraTabControl();
            this.PageEntradas = new DevExpress.XtraTab.XtraTabPage();
            this.GridEntradas = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PageSalidas = new DevExpress.XtraTab.XtraTabPage();
            this.GridSalidas = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtSum = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.PlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl)).BeginInit();
            this.TabControl.SuspendLayout();
            this.PageEntradas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridEntradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.PageSalidas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridSalidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlMain
            // 
            this.PlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.PlMain.Controls.Add(this.TabControl);
            this.PlMain.Controls.Add(this.panel1);
            this.PlMain.Controls.Add(this.lbTitulo);
            this.PlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlMain.Location = new System.Drawing.Point(0, 0);
            this.PlMain.Name = "PlMain";
            this.PlMain.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.PlMain.Size = new System.Drawing.Size(669, 494);
            this.PlMain.TabIndex = 94;
            // 
            // TabControl
            // 
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(20, 58);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedTabPage = this.PageEntradas;
            this.TabControl.Size = new System.Drawing.Size(629, 370);
            this.TabControl.TabIndex = 91;
            this.TabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.PageEntradas,
            this.PageSalidas});
            this.TabControl.Tag = "";
            this.TabControl.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.TabControl_SelectedPageChanged);
            // 
            // PageEntradas
            // 
            this.PageEntradas.Controls.Add(this.GridEntradas);
            this.PageEntradas.Name = "PageEntradas";
            this.PageEntradas.Size = new System.Drawing.Size(627, 347);
            this.PageEntradas.Tag = "Entrada";
            this.PageEntradas.Text = "Entrada de Dinero";
            // 
            // GridEntradas
            // 
            this.GridEntradas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridEntradas.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridEntradas.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.GridEntradas.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.GridEntradas.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.GridEntradas.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.GridEntradas.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.GridEntradas.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.GridEntradas.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.GridEntradas.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.GridEntradas.EmbeddedNavigator.Buttons.Remove.Enabled = false;
            this.GridEntradas.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.GridEntradas.Location = new System.Drawing.Point(0, 0);
            this.GridEntradas.MainView = this.gridView1;
            this.GridEntradas.Name = "GridEntradas";
            this.GridEntradas.Size = new System.Drawing.Size(627, 347);
            this.GridEntradas.TabIndex = 1;
            this.GridEntradas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.GridEntradas;
            this.gridView1.Name = "gridView1";
            // 
            // PageSalidas
            // 
            this.PageSalidas.Controls.Add(this.GridSalidas);
            this.PageSalidas.Name = "PageSalidas";
            this.PageSalidas.Size = new System.Drawing.Size(627, 347);
            this.PageSalidas.Tag = "Salida";
            this.PageSalidas.Text = "Salida de Dinero";
            // 
            // GridSalidas
            // 
            this.GridSalidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridSalidas.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridSalidas.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.GridSalidas.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.GridSalidas.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.GridSalidas.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.GridSalidas.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.GridSalidas.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.GridSalidas.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.GridSalidas.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.GridSalidas.EmbeddedNavigator.Buttons.Remove.Enabled = false;
            this.GridSalidas.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.GridSalidas.Location = new System.Drawing.Point(0, 0);
            this.GridSalidas.MainView = this.gridView2;
            this.GridSalidas.Name = "GridSalidas";
            this.GridSalidas.Size = new System.Drawing.Size(627, 347);
            this.GridSalidas.TabIndex = 1;
            this.GridSalidas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.GridSalidas;
            this.gridView2.Name = "gridView2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TxtSum);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(20, 428);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 66);
            this.panel1.TabIndex = 94;
            // 
            // TxtSum
            // 
            this.TxtSum.Animated = true;
            this.TxtSum.BackColor = System.Drawing.Color.White;
            this.TxtSum.BorderColor = System.Drawing.Color.Gray;
            this.TxtSum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtSum.DefaultText = "";
            this.TxtSum.DisabledState.Parent = this.TxtSum;
            this.TxtSum.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.TxtSum.FocusedState.BorderColor = System.Drawing.Color.Gray;
            this.TxtSum.FocusedState.Parent = this.TxtSum;
            this.TxtSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TxtSum.ForeColor = System.Drawing.Color.White;
            this.TxtSum.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.TxtSum.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.TxtSum.HoverState.Parent = this.TxtSum;
            this.TxtSum.HoverState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.TxtSum.Location = new System.Drawing.Point(106, 10);
            this.TxtSum.Margin = new System.Windows.Forms.Padding(3, 15, 3, 10);
            this.TxtSum.Name = "TxtSum";
            this.TxtSum.PasswordChar = '\0';
            this.TxtSum.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.TxtSum.PlaceholderText = "C$ 0";
            this.TxtSum.SelectedText = "";
            this.TxtSum.ShadowDecoration.Parent = this.TxtSum;
            this.TxtSum.Size = new System.Drawing.Size(139, 32);
            this.TxtSum.TabIndex = 92;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-4, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 32);
            this.label1.TabIndex = 93;
            this.label1.Text = "Importe Total:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbTitulo
            // 
            this.lbTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitulo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(20, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(629, 58);
            this.lbTitulo.TabIndex = 90;
            this.lbTitulo.Text = "Entradas del turno";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListadoContable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 494);
            this.Controls.Add(this.PlMain);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("ListadoContable.IconOptions.Image")));
            this.Name = "ListadoContable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Listar Contables";
            this.PlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabControl)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.PageEntradas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridEntradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.PageSalidas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridSalidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PlMain;
        protected System.Windows.Forms.Label lbTitulo;
        private DevExpress.XtraTab.XtraTabControl TabControl;
        private DevExpress.XtraTab.XtraTabPage PageEntradas;
        private DevExpress.XtraTab.XtraTabPage PageSalidas;
        protected DevExpress.XtraGrid.GridControl GridEntradas;
        protected DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        protected DevExpress.XtraGrid.GridControl GridSalidas;
        protected DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2TextBox TxtSum;
        private System.Windows.Forms.Panel panel1;
    }
}