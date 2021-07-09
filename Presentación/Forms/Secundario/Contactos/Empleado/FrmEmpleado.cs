using DevExpress.XtraEditors;
using Negocio;
using Negocio.Utils;
using Presentación.Forms.Principal.Heredables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentación.Forms.Secundario.Empleado
{
    public partial class FrmEmpleado : Edition_Object
    {
        private readonly ModeloEmpleado modelo;

        [Obsolete("Solo Diseñador", true)]
        public FrmEmpleado()
        {
            InitializeComponent();
        }

        public FrmEmpleado(ModeloEmpleado modelo, int Index) : base(modelo)
        {
            this.modelo = modelo;
            SelectedIndex = Index;
			InitializeComponent();
		}

		#region Metodos
		protected override void SetearDatos()
		{
			modelo.Entidad = new Entidad.EEmpleado
			{
				IdEmpleado = Safety.SafeInt(IdEmpleadoTextEdit.Text),
				IdTienda = Safety.SafeInt(IdTiendaTextEdit.EditValue.ToString()),
				IdRol = Safety.SafeInt(IdRolTextEdit.EditValue.ToString()),
				Nombres = NombresTextEdit.Text,
				Apellidos = ApellidosTextEdit.Text,
				Usuario = UsuarioTextEdit.Text,
				Clave = ClaveTextEdit.Text,
				Foto = Safety.SafeByte(FotoPictureEdit.Image),
				Correo = CorreoTextEdit.Text,
				Estado = EstadoTextEdit.Text,
			};
		}

		protected override void ObtenerDatos()
		{
			modelo.Entidad = modelo.LeerEntidad();

			if (modelo.Exito)
			{
				IdEmpleadoTextEdit.Text = modelo.Entidad.IdEmpleado.ToString();
				IdTiendaTextEdit.Text = modelo.Entidad.IdTienda.ToString();
				IdRolTextEdit.Text = modelo.Entidad.IdRol.ToString();
				NombresTextEdit.Text = modelo.Entidad.Nombres.ToString();
				ApellidosTextEdit.Text = modelo.Entidad.Apellidos.ToString();
				UsuarioTextEdit.Text = modelo.Entidad.Usuario.ToString();
				ClaveTextEdit.Text = modelo.Entidad.Clave.ToString();
				FotoPictureEdit.Image = Safety.SafeImage(modelo.Entidad.Foto);
				CorreoTextEdit.Text = modelo.Entidad.Correo.ToString();
				EstadoTextEdit.Text = modelo.Entidad.Estado.ToString();
			}
		}
        #endregion

        #region Eventos
        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            
			empleadoBindingSource.DataSource = modelo.LeerTabla();

			IdRolTextEdit.Properties.DataSource = new ModeloRol().LeerLista();
			IdRolTextEdit.Properties.ValueMember = "IdRol";
			IdRolTextEdit.Properties.DisplayMember = "Rol";

			IdTiendaTextEdit.Properties.DataSource = new ModeloTienda().LeerLista();
			IdTiendaTextEdit.Properties.ValueMember = "IdTienda";
			IdTiendaTextEdit.Properties.DisplayMember = "Nombre";

			dataNavigator1.Position = SelectedIndex - 1;

			if (modelo.Accion == Accion.Agregar)
			{
				empleadoBindingSource.AddNew();
			}
		}
        #endregion
    }
}