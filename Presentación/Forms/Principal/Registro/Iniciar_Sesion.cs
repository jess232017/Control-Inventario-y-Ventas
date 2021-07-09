using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Negocio;
using Negocio.Utils;
using Presentación.Forms.Principal.Caja;
using Presentación.Forms.Principal.Server;

namespace Presentación.Forms.Principal.Registro
{
    public partial class Iniciar_Sesion : Form
    {
        private readonly ModeloMovimiento modelo;

        public Iniciar_Sesion()
        {
            InitializeComponent();
            modelo = new ModeloMovimiento();
            txtUser.Text = Datos.ObtenerSerial();
        }

        #region Metodos
        
        private bool RegistraMovimiento(float DineroInicial)
        {
            //crear una entidad para realizar el registro
            modelo.Entidad = new Entidad.EMovimiento
            {
                IdEmpleado = 1,
                IdCaja = modelo.BuscarIdCaja(Datos.ObtenerSerial()),
                Estado = "ACTIVO",
                FechaInicio = DateTime.Now,
                FechaFin = null,
                DineroInicial = DineroInicial,
                DineroCierre = null,
                Saldo = null,
                Diferencia = null,
            };

            //Intentar realizar el registro
            modelo.Accion = Accion.Agregar;
            modelo.Accionar();

            //Mostrar alerta si falla
            if (!modelo.Exito)
            {
                XtraMessageBox.Show(modelo.Mensaje);
            }

            return modelo.Exito;
        }

        private void EventosMenu(MenuV2 menu)
        {
            //Valida si el cierre del menu se hace para cambiar de usuario
            bool CerrarTodo = false;

            //Mostrar este form si se desea cambiar de usuario
            menu.SbCerrarSesion.Click += (obj, args) =>
            {
                txtPass.Text = "";
                txtUser.Text = "";
                CerrarTodo = true;
                menu.Close();
                Show();
            };

            //Cerrar este formulario si se cierra menu
            menu.FormClosed += (obj, Args) => {
                //Si no es un cambio de sesion
                if (!CerrarTodo)
                {
                    Close();
                }
            };
        }

        #endregion

        #region Eventos
        
        private void Iniciar_Sesion_Load(object sender, EventArgs e)
        {
            BtnSetServer.Click += (emisor, args) =>{
                Cambiar_Server.Show();
            };

            txtPass.IconRightClick += (emisor, args) =>{
                txtPass.IconRight = txtPass.UseSystemPasswordChar ? Properties.Resources.icons8_eye_32 : Properties.Resources.icons8_hide_32;
                txtPass.UseSystemPasswordChar = !txtPass.UseSystemPasswordChar;
            };

            linkRestaurar.LinkClicked += (emisor, args) => {
                Hide();
                new Restaurar_Pass().ShowDialog(this);
                Show();
            };

            CbxIntegratedSecurity.CheckedChanged += (emisor, args) =>
            {
                txtPass.Enabled = !txtPass.Enabled;
                txtUser.Enabled = !txtUser.Enabled;
            };
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            //Mostrar menu un poco prematuramente
            Hide();
            MenuV2 menu = new MenuV2();
            menu.Show();
            menu.DineroInicial = DineroInicial.Show();

            //Si falla el registro
            if(!RegistraMovimiento(menu.DineroInicial))
            {
                Show();
                menu.Close();
                return;
            }

            //Registrar eventos para el Form Menu
            EventosMenu(menu);
        }
        
        #endregion
    }
}