using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Presentación.Forms.Base
{
    public partial class ItemBase : UserControl
    {
        protected Color AuxColor;

        public ItemBase()
        {
            InitializeComponent();
        }

        #region Atributos
        [Category("Personalizar")]
        private Color ColorHover;

        public Color HoverColor
        {
            get { return ColorHover; }
            set { ColorHover = value; }
        }
        #endregion

        #region Eventos
        protected void ControlEvent(Control control)
        {
            control.MouseEnter += MEnter;
            control.MouseLeave += MLeave;
            control.MouseClick += MClick;
        }

        private void MEnter(object sender, EventArgs e)
        {
            BackColor = HoverColor;
        }

        private void MLeave(object sender, EventArgs e)
        {
            BackColor = AuxColor;
        }

        private void MClick(object sender, MouseEventArgs e)
        {
            BackColor = AuxColor;
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Interval >= 10)
            {
                BackColor = HoverColor;
                timer1.Stop();
            }
        }
        #endregion
    }
}
