using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentación.Forms.Principal.Admin
{
    public partial class FrmCreditos : DevExpress.XtraEditors.XtraForm
    {
        public FrmCreditos()
        {
            InitializeComponent();
        }

        private void FrmCreditos_Load(object sender, EventArgs e)
        {
            richTextBox1.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\nouicompat\\deflang2058{\\fonttbl{\\f0\\fnil\\fcharset0 Segoe UI;}}{\\colortbl ;\\red255\\green255\\blue255;}\\viewkind4\\uc1 \\pard\\sa200\\sl276\\slmult1\\cf1\\b\\f0\\fs22\\lang9 Integrantes:\\tab\\tab\\tab\\tab\\tab\\tab\\tab Carnet:\\b0\\par\\pard {\\pntext\\f0 1.\\tab}{\\*\\pn\\pnlvlbody\\pnf0\\pnindent0\\pnstart1\\pndec{\\pntxta.}}\\fi-360\\li1440\\sl240\\slmult1 Jes\\'fas Enmanuel Hern\\'e1ndez Gonz\\'e1lez \\tab #2017-0505U\\par{\\pntext\\f0 2.\\tab}Danilo Jos\\lang19466\\'e9\\lang9  Acevedo Flores\\tab\\tab\\tab #2017-0016U\\par{\\pntext\\f0 3.\\tab}Juan Carlos L\\'f3pez Arauz\\tab\\tab\\tab #2017-0499U\\par}";
        }
    }
}