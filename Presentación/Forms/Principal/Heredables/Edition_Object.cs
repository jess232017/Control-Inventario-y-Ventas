using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraEditors;
using Negocio.Utils;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Presentación.Forms.Principal.Heredables
{
    /// <summary>
    /// Interfaz herededa para todos los semejantes
    /// </summary>
    public partial class Edition_Object : XtraForm
    {
        protected int SelectedIndex = 0;
        protected readonly IModelo Modelo;


        #region Overload
        public Edition_Object()
        {
            InitializeComponent();
        }

        public Edition_Object(IModelo Modelo)
        {
            this.Modelo = Modelo;

            InitializeComponent();
            Load += new EventHandler(Edition_Object_Load);
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Setea los datos requeridos por el modelo
        /// </summary>
        protected virtual void SetearDatos()
        {
            //throw new NotImplementedException(); 
        }

        /// <summary>
        /// Obtiene los datos y los muestra en la interfaz
        /// </summary>
        protected virtual void ObtenerDatos()
        {
            //throw new NotImplementedException(); 
        }
        #endregion

        #region Eventos

        protected void Edition_Object_Load(object sender, EventArgs e)
        {
            //Setea el titulo del formulario
            Text = Text.Replace("Frm", "");
            lbTitulo.Text = string.Format(Modelo.Accion.ToString() + ' ' + lbTitulo.Text, Text);

            //Define que botones se van a mostrar
            switch (Modelo.Accion)
            {
                case Accion.Agregar:
                    BottomMenu.Buttons[2].Properties.Visible = false;
                    BottomMenu.Buttons[4].Properties.Visible = false;
                    break;
                case Accion.Actualizar:
                    BottomMenu.Buttons[4].Properties.Visible = false;
                    break;
                case Accion.Eliminar:
                    BottomMenu.Buttons[0].Properties.Visible = false;
                    BottomMenu.Buttons[1].Properties.Visible = false;
                    BottomMenu.Buttons[2].Properties.Visible = false;
                    BottomMenu.Buttons[3].Properties.Visible = false;
                    break;
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BottomMenu_ButtonClick(object sender, ButtonEventArgs e)
        {
            SetearDatos();

            switch (e.Button.Properties.Caption)
            {
                case "Guardar":
                    Modelo.Accionar();
                    XtraMessageBox.Show(Modelo.Mensaje);
                    break;

                case "Guardar y Cerrar":
                    Modelo.Accionar();
                    XtraMessageBox.Show(Modelo.Mensaje);
                    Close();
                    break;

                case "Guardar Como":
                    Modelo.Accion = Accion.Agregar;

                    Modelo.Accionar();
                    XtraMessageBox.Show(Modelo.Mensaje);
                    Close();
                    break;

                case "Deshacer Cambios":
                    if (Modelo.Accion != Accion.Agregar)
                        dataNavigator1.Position = SelectedIndex;
                    //else
                        // LimpiarTextos(this);
                    break;

                case "Eliminar":
                    Modelo.Accionar();
                    XtraMessageBox.Show(Modelo.Mensaje);
                    break;

                case "Imprimir":
                    XtraMessageBox.Show(e.Button.Properties.Caption);
                    break;
            }

            //Saver.GetSource();
        }
        
        #endregion
    }
}