using Presentación.Forms.Base;
using System;
using System.ComponentModel;
using System.Drawing;

namespace Presentación.Forms.Principal.Heredables.Items
{
    public partial class IconButton : ItemBase
    {
        public IconButton()
        {
            InitializeComponent();
            AuxColor = BackColor;
            ControlEvent(Imagen);
            ControlEvent(Texto);
        }

        #region Atributos
        [Category("Personalizar")]
        private Image myImage;

        public Image Icono
        {
            get { return myImage; }
            set {
                myImage = value;
                Imagen.Image = value; }
        }

        [Category("Personalizar")]
        private string myText;

        public string Titulo
        {
            get { return myText; }
            set {
                myText = value;
                Texto.Text = value; }
        }

        private EventHandler Clicker;

        public EventHandler Clicking
        {
            get { return Clicker; }
            set {
                Click += value;
                Clicker = value;
                Texto.Click += value;
                Imagen.Click += value;
            }
        }


        #endregion
    }
}
