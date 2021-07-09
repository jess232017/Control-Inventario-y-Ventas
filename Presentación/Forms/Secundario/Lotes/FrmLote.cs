using DevExpress.XtraEditors;
using Negocio;
using Presentación.Forms.Principal.Heredables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentación.Forms.Secundario.Lotes
{
    public partial class FrmLote : Edition_Object
    {
		private ModeloLote modelo;
        public FrmLote()
        {
            InitializeComponent();
			modelo = new ModeloLote();
        }

		public FrmLote(ModeloLote Modelo, int Index) : base(Modelo)
		{
			modelo = Modelo;
			SelectedIndex = Index;
			InitializeComponent();
			modelo = new ModeloLote();
		}

		#region Metodos

		protected override void SetearDatos()
		{
			modelo.Entidad = new Entidad.ELote
			{
				IdLote = Safety.SafeInt(IdLoteTextEdit.Text),
				IdProducto = Safety.SafeInt(IdProductoSearchLookUpEdit.EditValue.ToString()),
				IdProveedor = Safety.SafeInt(IdProveedorSearchLookUpEdit.EditValue.ToString()),
				Lote = LoteTextEdit.Text,
				Fragil = FragilCheckEdit.Checked,
				Cantidad = Safety.SafeInt(CantidadTextEdit.Text),
				CostoUnidad = Safety.SafeFloat(CostoUnidadTextEdit.Text),
				FechaRegistro = Safety.SafeDateTime(FechaRegistroDateEdit.EditValue.ToString()),
				FechaVence = Safety.SafeDateTime(FechaVenceDateEdit.EditValue.ToString()),
				Agotado = AgotadoCheckEdit.Checked,
				Observacion = ObservacionMemoEdit.Text,
			};
		}

		protected override void ObtenerDatos()
		{
			modelo.Entidad = modelo.LeerEntidad();

			if (modelo.Exito)
			{
                IdLoteTextEdit.Text = modelo.Entidad.IdLote.ToString();
				IdProveedorSearchLookUpEdit.EditValue = modelo.Entidad.IdProducto.ToString();
				IdProveedorSearchLookUpEdit.EditValue = modelo.Entidad.IdProveedor.ToString();
				LoteTextEdit.Text = modelo.Entidad.Lote.ToString();
				FragilCheckEdit.Checked = modelo.Entidad.Fragil;
				CantidadTextEdit.Text = modelo.Entidad.Cantidad.ToString();
				CostoUnidadTextEdit.Text = modelo.Entidad.CostoUnidad.ToString();
				FechaRegistroDateEdit.EditValue = modelo.Entidad.FechaRegistro;
				FechaVenceDateEdit.EditValue = modelo.Entidad.FechaVence;
				AgotadoCheckEdit.Checked = modelo.Entidad.Agotado;
				ObservacionMemoEdit.Text = modelo.Entidad.Observacion.ToString();
			}
		}

		#endregion

		private void FrmLote_Load(object sender, EventArgs e)
        {
			//loteBindingSource.DataSource = new ModeloLote().LeerLista();
			this.loteTableAdapter.Fill(this.inventarioVentaDataSet.Lote);


			IdProductoSearchLookUpEdit.Properties.DataSource = Datos.ExecuteReader("SELECT IdProducto, Descripcion + ' ' + Marca AS Descripcion, Cantidad FROM Producto", CommandType.Text);
			IdProductoSearchLookUpEdit.Properties.DisplayMember = "Descripcion";
			IdProductoSearchLookUpEdit.Properties.ValueMember = "IdProducto";

			IdProveedorSearchLookUpEdit.Properties.DataSource = new ModeloProveedor().LeerLista();
			IdProveedorSearchLookUpEdit.Properties.DisplayMember = "Contacto";
			IdProveedorSearchLookUpEdit.Properties.ValueMember = "IdProveedor";

		}
    }
}