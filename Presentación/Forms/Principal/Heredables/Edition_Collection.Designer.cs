
namespace Presentación.Forms.Principal.Heredables
{
    partial class Edition_Collection
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
            this.components = new System.ComponentModel.Container();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.div2 = new System.Windows.Forms.Panel();
            this.div3 = new System.Windows.Forms.Panel();
            this.div4 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.plEspacio = new System.Windows.Forms.Panel();
            this.stackButtons = new Presentación.Forms.Principal.Heredables.StackPanelHeritable();
            this.lbSubtitulo = new System.Windows.Forms.Label();
            this.div1 = new System.Windows.Forms.Panel();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.div2.SuspendLayout();
            this.div3.SuspendLayout();
            this.div4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackButtons)).BeginInit();
            this.div1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitulo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(0, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(1028, 45);
            this.lbTitulo.TabIndex = 83;
            this.lbTitulo.Text = "Administracion de {0}";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // div2
            // 
            this.div2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.div2.Controls.Add(this.div3);
            this.div2.Controls.Add(this.lbSubtitulo);
            this.div2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.div2.Location = new System.Drawing.Point(10, 10);
            this.div2.Name = "div2";
            this.div2.Size = new System.Drawing.Size(1008, 517);
            this.div2.TabIndex = 84;
            // 
            // div3
            // 
            this.div3.Controls.Add(this.div4);
            this.div3.Controls.Add(this.plEspacio);
            this.div3.Controls.Add(this.stackButtons);
            this.div3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.div3.Location = new System.Drawing.Point(0, 24);
            this.div3.Name = "div3";
            this.div3.Padding = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.div3.Size = new System.Drawing.Size(1006, 491);
            this.div3.TabIndex = 86;
            // 
            // div4
            // 
            this.div4.Controls.Add(this.gridControl1);
            this.div4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.div4.Location = new System.Drawing.Point(10, 106);
            this.div4.Name = "div4";
            this.div4.Size = new System.Drawing.Size(986, 380);
            this.div4.TabIndex = 92;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(986, 380);
            this.gridControl1.TabIndex = 90;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowHeight = 25;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GridView1_FocusedRowChanged);
            this.gridView1.RowCountChanged += new System.EventHandler(this.GridView1_RowCountChanged);
            // 
            // plEspacio
            // 
            this.plEspacio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.plEspacio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.plEspacio.Dock = System.Windows.Forms.DockStyle.Top;
            this.plEspacio.Location = new System.Drawing.Point(10, 47);
            this.plEspacio.Name = "plEspacio";
            this.plEspacio.Size = new System.Drawing.Size(986, 59);
            this.plEspacio.TabIndex = 91;
            this.plEspacio.Visible = false;
            // 
            // stackButtons
            // 
            this.stackButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.stackButtons.Location = new System.Drawing.Point(10, 0);
            this.stackButtons.Name = "stackButtons";
            this.stackButtons.Size = new System.Drawing.Size(986, 47);
            this.stackButtons.TabIndex = 89;
            // 
            // lbSubtitulo
            // 
            this.lbSubtitulo.BackColor = System.Drawing.Color.Black;
            this.lbSubtitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbSubtitulo.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubtitulo.ForeColor = System.Drawing.Color.White;
            this.lbSubtitulo.Location = new System.Drawing.Point(0, 0);
            this.lbSubtitulo.Name = "lbSubtitulo";
            this.lbSubtitulo.Size = new System.Drawing.Size(1006, 24);
            this.lbSubtitulo.TabIndex = 84;
            this.lbSubtitulo.Text = "Listado de {0}";
            this.lbSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // div1
            // 
            this.div1.Controls.Add(this.div2);
            this.div1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.div1.Location = new System.Drawing.Point(0, 45);
            this.div1.Margin = new System.Windows.Forms.Padding(0);
            this.div1.Name = "div1";
            this.div1.Padding = new System.Windows.Forms.Padding(10);
            this.div1.Size = new System.Drawing.Size(1028, 537);
            this.div1.TabIndex = 89;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barHeaderItem1});
            this.barManager1.MaxItemId = 2;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Barra de estado";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barHeaderItem1)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Barra de estado";
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Caption = "# de registros: {0}";
            this.barHeaderItem1.Id = 1;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1028, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 582);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1028, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 582);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1028, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 582);
            // 
            // Edition_Collection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1028, 602);
            this.Controls.Add(this.div1);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Edition_Collection";
            this.Text = "Administrar {0}";
            this.div2.ResumeLayout(false);
            this.div3.ResumeLayout(false);
            this.div4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackButtons)).EndInit();
            this.div1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Label lbTitulo;
        protected System.Windows.Forms.Panel div2;
        protected System.Windows.Forms.Panel div3;
        protected System.Windows.Forms.Label lbSubtitulo;
        protected System.Windows.Forms.Panel div1;
        protected DevExpress.XtraGrid.GridControl gridControl1;
        protected DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        protected StackPanelHeritable stackButtons;
        protected System.Windows.Forms.Panel plEspacio;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.ComponentModel.IContainer components;
        protected DevExpress.XtraBars.Bar bar3;
        protected DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        protected System.Windows.Forms.Panel div4;
    }
}