using DevExpress.Utils;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Presentación.Forms.Principal.Admin
{
    public partial class FlyNotify : FlyoutPanel
    {
        protected FlyoutPanelControl flyPanel;
        protected Label lBadges;
        public int Contador;

        public FlyNotify() { InitializeComponent(); }

        public FlyNotify(Control owner, ref Label LBadges)
        {
            InitializeComponent();
            OwnerControl = owner;
            lBadges = LBadges;
            DrawVencidos();

            if(Contador > 0)
            {
                LBadges.Visible = true;
                LBadges.Text = Contador.ToString();
            }
        }
        
        private void InitializeComponent()
        {
            this.flyPanel = new DevExpress.Utils.FlyoutPanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.flyPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // flyPanel
            // 
            this.flyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flyPanel.FlyoutPanel = this;
            this.flyPanel.Location = new System.Drawing.Point(0, 0);
            this.flyPanel.Name = "flyPanel";
            this.flyPanel.Size = new System.Drawing.Size(301, 374);
            this.flyPanel.TabIndex = 0;
            // 
            // FlyNotify
            // 
            this.Controls.Add(this.flyPanel);
            this.Location = new System.Drawing.Point(617, 101);
            this.Name = "FlyNotify";
            this.OptionsButtonPanel.ButtonPanelHeight = 60;
            this.Size = new System.Drawing.Size(301, 374);
            this.Shown += new DevExpress.Utils.FlyoutPanelEventHandler(this.FlyNotify_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.flyPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }
        
        private void DrawVencidos()
        {
            try
            {
                int CantidadVencida = (int)Datos.ExecuteScalar("SELECT dbo.SfLote_CantidadVencida()", System.Data.CommandType.Text);

                if(CantidadVencida > 0)
                {
                    Label b = new Label();
                    Panel p1 = new Panel();
                    Panel p2 = new Panel();
                    PictureBox I1 = new PictureBox();
                    PictureBox I2 = new PictureBox();
                    Label L = new Label();

                    b.Text = "Tienes Lote(s) Vencido(s)";
                    b.Name = CantidadVencida.ToString();
                    b.Size = new Size(430, 35);
                    b.Font = new Font("Segoe UI", 10);
                    b.BackColor = Color.Transparent;
                    b.ForeColor = Color.Black;
                    b.Dock = DockStyle.Top;
                    b.TextAlign = ContentAlignment.MiddleLeft;

                    L.Text = "(" + CantidadVencida + ") Lote(s) Vencido(s)";
                    L.Name = CantidadVencida.ToString();
                    L.Size = new Size(430, 18);
                    L.Font = new Font("Segoe UI", 10);
                    L.BackColor = Color.Transparent;
                    L.ForeColor = Color.Gray;
                    L.Dock = DockStyle.Fill;
                    L.TextAlign = ContentAlignment.MiddleLeft;

                    I2.BackgroundImage = Properties.Resources.icons8_high_risk_48;
                    I2.BackgroundImageLayout = ImageLayout.Zoom;
                    I2.Size = new Size(18, 18);
                    I2.Dock = DockStyle.Left;

                    p1.Size = new Size(430, 67);
                    p1.BorderStyle = BorderStyle.FixedSingle;
                    p1.Dock = DockStyle.Top;
                    p1.BackColor = Color.White;

                    p2.Size = new Size(287, 22);
                    p2.Dock = DockStyle.Top;
                    p2.BackColor = Color.Transparent;

                    I1.BackgroundImage = Properties.Resources.icons8_leave_96;
                    I1.BackgroundImageLayout = ImageLayout.Zoom;
                    I1.Size = new Size(90, 69);
                    I1.Dock = DockStyle.Left;
                    I1.BackColor = Color.Transparent;


                    p1.Controls.Add(b);
                    p1.Controls.Add(I1);
                    p1.Controls.Add(p2);
                    p2.Controls.Add(I2);
                    p2.Controls.Add(L);

                    p2.BringToFront();
                    b.SendToBack();
                    I1.SendToBack();
                    L.BringToFront();

                    Contador++;
                    flyPanel.Controls.Add(p1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void FlyNotify_Shown(object sender, FlyoutPanelEventArgs e)
        { 
            if(lBadges!=null)
                lBadges.Visible = false;
        }
    }

    public class FlyConfig : FlyNotify
    {
        public FlyConfig(Control owner)
        {
            Configuracion config = new Configuracion();
            config.TopLevel = false;
            config.BringToFront();
            config.Show();

            OwnerControl = owner;
            flyPanel.Controls.Add(config);
            Size = new Size(768, 634);
        }
    }
}