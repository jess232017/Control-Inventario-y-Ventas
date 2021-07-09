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

namespace Presentación.Forms.Secundario.Contactos.Proveedor
{
    public partial class FrmProveedor : Edition_Object
    {
        private readonly ModeloProveedor modelo;

        #region SobreCargas
        public FrmProveedor()
        {
            InitializeComponent();
        }

        public FrmProveedor(ModeloProveedor modelo, int Index) : base(modelo)
        {
            this.modelo = modelo;
            SelectedIndex = Index;
            InitializeComponent();
        }
        #endregion

        #region Metodos
        
        protected override void SetearDatos()
        {
            modelo.Entidad = new Entidad.EProveedor
            {
                IdProveedor = Safety.SafeInt(IdProveedorTextEdit.Text),
                Empresa = EmpresaTextEdit.Text,
                Contacto = ContactoTextEdit.Text,
                Direccion = DireccionTextEdit.Text,
                Estado = EstadoCheckEdit.Checked,
                Celular = CelularTextEdit.Text,
                Foto = Safety.SafeByte(FotoPictureEdit.Image),
            };
        }

        protected override void ObtenerDatos()
        {
            modelo.Entidad = modelo.LeerEntidad();

            if (modelo.Exito)
            {
                IdProveedorTextEdit.Text = modelo.Entidad.IdProveedor.ToString();
                EmpresaTextEdit.Text = modelo.Entidad.Empresa.ToString();
                ContactoTextEdit.Text = modelo.Entidad.Contacto.ToString();
                DireccionTextEdit.Text = modelo.Entidad.Direccion.ToString();
                EstadoCheckEdit.Checked = modelo.Entidad.Estado;
                CelularTextEdit.Text = modelo.Entidad.Celular.ToString();
                FotoPictureEdit.Image = Safety.SafeImage(modelo.Entidad.Foto);
            }
        }
        #endregion

        #region Eventos
        private void FrmProveedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'inventarioVentaDataSet.Proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.Fill(this.inventarioVentaDataSet.Proveedor);
            dataNavigator1.Position = SelectedIndex - 1;
            if (modelo.Accion == Accion.Agregar)
            {
                proveedorBindingSource.AddNew();
            }
        }

        #endregion
    }
}