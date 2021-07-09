using DevExpress.XtraEditors;
using Entidad;
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

namespace Presentación.Forms.Secundario.Contactos.Cliente
{
    public partial class FrmCliente : Edition_Object
    {
		private readonly ModeloCliente modelo;

		[Obsolete("Solo Diseñador", true)] 
        public FrmCliente()
        {
            InitializeComponent();
        }

		public FrmCliente(ModeloCliente modelo, int Index) : base(modelo)
		{
			this.modelo = modelo;
			SelectedIndex = Index;
			InitializeComponent();
		}

		private void FrmCliente_Load(object sender, EventArgs e)
        {
			clienteBindingSource.DataSource = modelo.LeerLista();
			dataNavigator1.Position = SelectedIndex -1;

			if (modelo.Accion == Accion.Agregar)
			{
				clienteBindingSource.AddNew();
			}
		}

		protected override void SetearDatos()
		{
			modelo.Entidad = new Entidad.ECliente
			{
				IdCliente = Safety.SafeInt(IdClienteTextEdit.Text),
				Nombre = NombreTextEdit.Text,
				Apellido = ApellidoTextEdit.Text,
				Telefono = TelefonoTextEdit.Text,
				Estado = EstadoCheckEdit.Checked,
				Imagen = Safety.SafeByte(ImagenPictureEdit.Image),
			};
		}

		protected override void ObtenerDatos()
		{
			modelo.Entidad = modelo.LeerEntidad();

			if (modelo.Exito)
			{
				IdClienteTextEdit.Text = modelo.Entidad.IdCliente.ToString();
				NombreTextEdit.Text = modelo.Entidad.Nombre.ToString();
				ApellidoTextEdit.Text = modelo.Entidad.Apellido.ToString();
				TelefonoTextEdit.Text = modelo.Entidad.Telefono.ToString();
				EstadoCheckEdit.Checked = modelo.Entidad.Estado;
				ImagenPictureEdit.Image = Safety.SafeImage(modelo.Entidad.Imagen);
			}
		}
	}
}