using Negocio;
using Negocio.Utils;
using Presentación.Forms.Principal.Heredables;
using Presentación.Forms.Secundario.Lotes;
using System.Drawing;
using System.Windows.Forms;

namespace Presentación.Forms.Secundario.Productos
{
    public partial class FrmProducto : Edition_Object
    {
        private readonly ModeloProducto modelo;
        private readonly ModeloCategoria categoria;

        #region Sobrecargas

        public FrmProducto()
        {
            InitializeComponent();
        }

        public FrmProducto(ModeloProducto Modelo, int Index) : base(Modelo)
        {
            modelo = Modelo;
            SelectedIndex = Index;
            categoria = new ModeloCategoria();
            InitializeComponent();
        }

        #endregion

        #region  Metodos
        protected override void SetearDatos()
        {
            modelo.Entidad = new Entidad.EProducto
            {
                IdProducto = Safety.SafeInt(IdProductoTextEdit.Text),
                IdCategoria = Safety.SafeInt(IdCategoriaTextEdit.EditValue.ToString()),
                Descripcion = DescripcionTextEdit.Text,
                Marca = MarcaTextEdit.Text,
                Inventariado = InventariadoCheckEdit.Checked,
                Cantidad = Safety.SafeInt(CantidadTextEdit.Text),
                PrecioVenta = Safety.SafeFloat(PrecioVentaTextEdit.Text),
                CodigoQR = CodigoQRTextEdit.Text,
                Imagen =  Safety.SafeByte(ImagenPictureEdit.Image),
                StockMinimo = Safety.SafeInt(StockMinimoTextEdit.Text),
                Granel = GranelCheckEdit.Checked,
            };
        }

        protected override void ObtenerDatos()
        {
            modelo.Entidad = modelo.LeerEntidad();

            if (modelo.Exito)
            {
                IdProductoTextEdit.Text = modelo.Entidad.IdProducto.ToString();
                IdCategoriaTextEdit.Text = modelo.Entidad.IdCategoria.ToString();
                DescripcionTextEdit.Text = modelo.Entidad.Descripcion.ToString();
                MarcaTextEdit.Text = modelo.Entidad.Marca.ToString();
                InventariadoCheckEdit.Checked = modelo.Entidad.Inventariado;
                CantidadTextEdit.Text = modelo.Entidad.Cantidad.ToString();
                PrecioVentaTextEdit.Text = modelo.Entidad.PrecioVenta.ToString();
                CodigoQRTextEdit.Text = modelo.Entidad.CodigoQR.ToString();
                ImagenPictureEdit.Image = Safety.SafeImage(modelo.Entidad.Imagen);
                StockMinimoTextEdit.Text = modelo.Entidad.StockMinimo.ToString();
                GranelCheckEdit.Checked = modelo.Entidad.Granel;
            }
        }
        #endregion

        #region Eventos
        private void FrmProducto_Load(object sender, System.EventArgs e)
        {
            productoBindingSource.DataSource = modelo.LeerLista();

            IdCategoriaTextEdit.Properties.DataSource = categoria.LeerLista();
            IdCategoriaTextEdit.Properties.DisplayMember = "Nombre";
            IdCategoriaTextEdit.Properties.ValueMember = "IdCategoria";

            dataNavigator1.Position = SelectedIndex - 1;
            if(modelo.Accion == Accion.Agregar)
            {
                productoBindingSource.AddNew();
            }
        }

        private void ImagenPictureEdit_DoubleClick(object sender, System.EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ImagenPictureEdit.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

        private void BtnAgregarCategoria_Click(object sender, System.EventArgs e)
        {
            if (Registrar_Categoria.Show() == DialogResult.OK)
            {
                IdCategoriaTextEdit.Properties.DataSource = categoria.LeerLista();
            }
        }

        private void BtnAgregarLote_Click(object sender, System.EventArgs e)
        {
            int IdProducto = Safety.SafeInt(IdProductoTextEdit.EditValue.ToString());
            ModeloLote modeloLote = new ModeloLote();
            modeloLote.Accion = Accion.Agregar;
            new FrmLote(modeloLote, IdProducto).ShowDialog();
        }

        #endregion
    }
}