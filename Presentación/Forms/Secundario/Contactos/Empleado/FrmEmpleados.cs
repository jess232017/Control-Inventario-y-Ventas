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
    public partial class FrmEmpleados : Edition_Collection
    {
        public FrmEmpleados()
        {
            InitializeComponent();
            IdColumnName = "IdEmpleado";
            modelo = new ModeloEmpleado();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            gridControl1.ShowPrintPreview();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            modelo.Accion = Accion.Agregar;
            OpenChildForm(new FrmEmpleado((ModeloEmpleado)modelo, SelectedId));
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            modelo.Accion = Accion.Actualizar;
            OpenChildForm(new FrmEmpleado((ModeloEmpleado)modelo, SelectedId));
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            modelo.Accion = Accion.Eliminar;
            OpenChildForm(new FrmEmpleado((ModeloEmpleado)modelo, SelectedId));
        }
    }
}