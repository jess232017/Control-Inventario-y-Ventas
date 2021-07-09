using DevExpress.XtraCharts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Presentación.Forms.Principal.Admin
{
    public partial class Dashboard : Form
    {
        private readonly FlyNotify ntf;
        private readonly FlyConfig cni;
        
        public Dashboard()
        {
            InitializeComponent();
            ntf = new FlyNotify(BtnNotify, ref LBadges);
            cni = new FlyConfig(BtnSeting);
        }

        #region Metodos
        private void SetearConteo()
        {
            TileVentas.Elements[0].Text = Datos.ExecuteScalar("SELECT dbo.SfFactura_ContarTodos()", CommandType.Text).ToString();
            TileProducts.Elements[0].Text = Datos.ExecuteScalar("SELECT dbo.SfProducto_ContarTodos()", CommandType.Text).ToString();
            TileClients.Elements[0].Text = Datos.ExecuteScalar("SELECT dbo.SfCliente_ContarTodos()", CommandType.Text).ToString();
            TileStock.Elements[0].Text = Datos.ExecuteScalar("SELECT dbo.SfProducto_StockBajo()", CommandType.Text).ToString();
            TileEmployess.Elements[0].Text = Datos.ExecuteScalar("SELECT dbo.SfEmpleado_ContarTodos()", CommandType.Text).ToString();
            TileSupplier.Elements[0].Text = Datos.ExecuteScalar("SELECT dbo.SfProveedor_ContarTodos()", CommandType.Text).ToString();
            TileInventories.Elements[0].Text = Datos.ExecuteScalar("SELECT dbo.SfInventario_ContarTodos()", CommandType.Text).ToString();
            TileMovements.Elements[0].Text = Datos.ExecuteScalar("SELECT dbo.SfMovimiento_ContarTodos()", CommandType.Text).ToString();
        }

        private void GraficarTopVendidos()
        {
            ArrayList cantidad = new ArrayList();
            ArrayList producto = new ArrayList();
            DataTable dtProductos = Datos.ExecuteReader("SELECT TOP 5 * FROM [dbo].[VwDetalle_MasVendido] ORDER BY [Cantidad] DESC", CommandType.Text);

            foreach (DataRow filas in dtProductos.Rows)
            {
                cantidad.Add(filas["Cantidad"]);
                producto.Add(filas["Nombre del Producto"]);
            }
            chartProductos.Series[0].Points.DataBindXY(producto, cantidad);
        }


        private void GraficarGastosAño()
        {
            int año = Convert.ToInt32(DateYear.EditValue);
            DataTable dt = Datos.ExecuteReader("SELECT TOP 10 * FROM TfContable_PorAnio(@Anio)", CommandType.Text, 
                new SqlParameter("@Anio", año));

            ArrayList monto = new ArrayList();
            ArrayList descripcion = new ArrayList();
            foreach (DataRow filas in dt.Rows)
            {
                monto.Add(Math.Round(Convert.ToDouble(filas["Monto"]), 2));
                descripcion.Add(filas["Motivo"]);
            }
            chartGastosAño.Series[0].Points.DataBindXY(descripcion, monto);
        }

        private void GraficarGastosMes()
        {
            int año = Convert.ToInt32(DateYear.EditValue);
            string mes = DateMonth.EditValue.ToString();

            DataTable dt = Datos.ExecuteReader("SELECT TOP 10 * FROM TfContable_PorMes(@Anio, @Mes)",
                CommandType.Text,
                new SqlParameter("@Anio", año),
                new SqlParameter("@Mes", mes));

            ArrayList monto = new ArrayList();
            ArrayList descripcion = new ArrayList();

            foreach (DataRow filas in dt.Rows)
            {
                monto.Add(Math.Round(Convert.ToDouble(filas["Monto"]), 2));
                descripcion.Add(filas["Motivo"]);
            }
            
            chartGastosMes.Series[0].Points.DataBindXY(descripcion, monto);
        }

        private void GraficarVentas()
        {
            ArrayList fecha = new ArrayList();
            ArrayList monto = new ArrayList();
            DataTable dtventas;

            if (CbFiltrar.Checked)
            {
                dtventas = Datos.ExecuteReader("SELECT TOP 10 * FROM TfFactura_SegunFecha(@FechaInit, @FechaFin) ORDER BY FechaVenta ASC", CommandType.Text,
                    new SqlParameter("@FechaInit", DateInit.EditValue),
                    new SqlParameter("@FechaFin", DateEnd.EditValue));
            }
            else
            {
                dtventas = Datos.ExecuteReader("SELECT TOP 10 * FROM TfFactura_Todos() ORDER BY FechaVenta ASC", CommandType.Text);
            }

            foreach (DataRow filas in dtventas.Rows)
            {
                fecha.Add(filas["FechaVenta"].ToString());
                monto.Add(Math.Round(Convert.ToDouble(filas["Total"]), 2));
            }
            chartVentas.Series[0].Points.DataBindXY(fecha, monto);
        }
        #endregion

        #region Eventos

        private void Dashboard_Load(object sender, EventArgs e)
        {
            SetearConteo();
            GraficarTopVendidos();

            DateYear.Properties.DataSource = Datos.ExecuteReader("SELECT Anio AS Año FROM TfContable_Anios() ORDER BY Anio DESC", CommandType.Text);
            DateYear.Properties.DisplayMember = "Año";
            DateYear.Properties.ValueMember = "Año";
            DateYear.ItemIndex = 0;
            DateMonth.ItemIndex = 0;
            CbFiltrar.Checked = false; 
            GraficarVentas();
        }

        private void BtnSeting_Click(object sender, EventArgs e)
        {
            if (!ntf.Visible)
                cni.ShowBeakForm();
            else
                cni.HideBeakForm();
        }

        private void BtnNotify_Click(object sender, EventArgs e)
        {
            if (!ntf.Visible)
                ntf.ShowBeakForm();
            else
                ntf.HideBeakForm();
        }

        private void DateMonth_EditValueChanged(object sender, EventArgs e)
        {
            GraficarGastosMes();
        }

        private void DateYear_EditValueChanged(object sender, EventArgs e)
        {
            GraficarGastosAño();

            int año = Convert.ToInt32(DateYear.EditValue);


            DateMonth.Properties.DataSource = Datos.ExecuteReader("SELECT * FROM TfContable_MesSegunAnio(@Anio)", CommandType.Text,
                new SqlParameter("@Anio", año));
            DateMonth.Properties.DisplayMember = "Mes";
            DateMonth.Properties.ValueMember = "Mes";
            DateMonth.ItemIndex = 0;
        }

        private void Control_ValueChanged(object sender, EventArgs e)
        {
            GraficarVentas();
        }

        #endregion
    }
}
