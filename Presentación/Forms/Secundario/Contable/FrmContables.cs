using DevExpress.XtraEditors;
using Negocio;
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
    public partial class FrmContables : Edition_Collection
    {
        public FrmContables()
        {
            InitializeComponent();
            modelo = new ModeloContable();
        }
    }
}