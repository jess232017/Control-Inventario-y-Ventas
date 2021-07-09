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

namespace Presentación.Forms.Secundario.Lotes
{
    public partial class FrmLotes : Edition_Collection
    {
        public FrmLotes()
        {
            InitializeComponent();
            modelo = new ModeloLote();
        }
    }
}