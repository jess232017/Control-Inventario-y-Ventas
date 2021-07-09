using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentación.Forms.Principal
{
    public partial class VisorPDF : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public VisorPDF()
        {
            InitializeComponent();

            try
            {
                var Ruta = Path.Combine(Directory.GetCurrentDirectory(), "Manual de Usuario.pdf");
                pdfViewer1.LoadDocument(Ruta);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
    }
}