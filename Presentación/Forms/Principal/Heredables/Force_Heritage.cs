using System.Windows.Forms;
using System.ComponentModel;
using System.Windows.Forms.Design;
using DevExpress.XtraGrid;
using DevExpress.XtraBars;
using DevExpress.Utils.Layout;
using DevExpress.XtraGrid.Views.Grid;

namespace Presentación.Forms.Principal.Heredables
{
    /// <summary>
    /// Da Solucion al problema de no poder modificar por diseño los botones
    /// </summary>
    [Designer(typeof(ParentControlDesigner))]
    public class Force_Heritage : FlowLayoutPanel{    }

    [Designer(typeof(ParentControlDesigner))]
    public class StackPanelHeritable : StackPanel { }

}
