using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using Negocio;
using Presentación.Forms.Principal.Heredables;
using Presentación.Forms.Secundario.Contactos.Cliente;
using Presentación.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentación.Forms.Secundario.Cliente
{
    public partial class FrmClientes : Edition_Collection
    {
        public FrmClientes()
        {
            InitializeComponent();
            IdColumnName = "IdCliente";
            modelo = new ModeloCliente();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            modelo.Accion = Negocio.Utils.Accion.Agregar;
            OpenChildForm(new FrmCliente((ModeloCliente)modelo, SelectedId));
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            modelo.Accion = Negocio.Utils.Accion.Actualizar;
            OpenChildForm(new FrmCliente((ModeloCliente)modelo, SelectedId));
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            modelo.Accion = Negocio.Utils.Accion.Eliminar;
            OpenChildForm(new FrmCliente((ModeloCliente)modelo, SelectedId));
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            new RptClientes().ShowPreview();
        }
    }
}