using Negocio;
using Negocio.Utils;
using Presentación.Forms.Principal.Heredables;
using System;
using System.Data;

namespace Presentación.Forms.Secundario.Inventarios
{
    public partial class FrmInventario : Edition_Object
    {
        private readonly ModeloInventario modelo;

        public FrmInventario()
        {
            InitializeComponent();
            CargarComboBox();
        }

        public FrmInventario(ModeloInventario Modelo, int Index) : base(Modelo)
        {
            modelo = Modelo;
            SelectedIndex = Index;
            InitializeComponent();
            CargarComboBox();
        }

        private void CargarComboBox()
        {
            IdProductoTextEdit.Properties.DataSource = Datos.ExecuteReader("SELECT IdProducto, Descripcion FROM Producto", CommandType.Text);
            IdProductoTextEdit.Properties.DisplayMember = "Descripcion";
            IdProductoTextEdit.Properties.ValueMember = "IdProducto";
        }

        private void FrmInventario_Load(object sender, EventArgs e)
        {
            inventarioBindingSource.DataSource = modelo.LeerLista();
            dataNavigator1.Position = SelectedIndex - 1;

            if (modelo.Accion == Accion.Agregar)
            {
                inventarioBindingSource.AddNew();
            }
        }
    }
}