using DevExpress.XtraEditors;
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

namespace Presentación.Forms.Secundario.Contable
{
    public partial class FrmContable : Edition_Object
    {
        public FrmContable()
        {
            InitializeComponent();
        }

        private void FrmContable_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'inventarioVentaDataSet.Contable' Puede moverla o quitarla según sea necesario.
            this.contableTableAdapter.Fill(this.inventarioVentaDataSet.Contable);

        }
    }
}