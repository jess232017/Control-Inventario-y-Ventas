using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Negocio;
using System;
using System.Data;

namespace Presentación.Forms.Secundario.Contable
{
    public partial class ListadoContable : XtraForm
    {
        private readonly ModeloContable modelo;
        public ListadoContable()
        {
            InitializeComponent();
            modelo = new ModeloContable();

            int IdMovimiento = MovimientoActual();
            GridEntradas.DataSource = modelo.BuscarPorMovimientoTipo(IdMovimiento, "Ingreso");
            GridSalidas.DataSource = modelo.BuscarPorMovimientoTipo(IdMovimiento, "Egreso");
            TxtSum.Text = SumarColumna(gridView1);
        }

        private string SumarColumna(GridView gridView)
        {
            double sumNetPrice = 0;
            for (int i = 0; i < gridView.DataRowCount; ++i)
            {
                DataRow row = gridView.GetDataRow(i);
                sumNetPrice += Convert.ToDouble(row["Monto"].ToString());
            }
            return sumNetPrice.ToString("C$ #,##0.00");
        }

        private int MovimientoActual()
        {
            string SerialPC = Datos.ObtenerSerial();
            //Buscar el movimiento actual
            return new ModeloMovimiento().BuscarIdMovimiento(SerialPC);
        }

        private void TabControl_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            bool isFirst = Convert.ToBoolean(TabControl.SelectedTabPageIndex);
            TxtSum.Text = (isFirst) ? SumarColumna(gridView2) : SumarColumna(gridView1);
        }

        private void ListadoContable_Load(object sender, EventArgs e)
        {
            SumarColumna(gridView1);
        }
    }
}
