using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentación.Forms.Principal.Heredables.Items
{
    class Badget : Label
    {
        public Badget()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            AutoSize = true;
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(63)))), ((int)(((byte)(67)))));
            Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            ForeColor = System.Drawing.Color.White;
            Location = new System.Drawing.Point(1025, 9);
            Name = "LBadges";
            Size = new System.Drawing.Size(13, 13);
            TabIndex = 601;
            Text = "0";
            TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Visible = false;
        }

        private string Origen;

        public string DataSource
        {
            get { return Origen; }
            set { Origen = value; }
        }

    }
}
