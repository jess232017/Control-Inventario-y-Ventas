using DevExpress.XtraCharts;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Media;
using Axis = LiveCharts.Wpf.Axis;

namespace Presentación.Forms.Principal.Admin
{
    public partial class DashboardV2 : Form
    {
        private readonly FlyNotify ntf;
        private readonly FlyConfig cni;
        
        public DashboardV2()
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

            TxtStockBajo.Text = TileStock.Elements[0].Text;
            TxtProducto.Text = TileProducts.Elements[0].Text;
            TxtTotalVenta.Text += $" {TileVentas.Elements[0].Text}";
            TxtCategory.Text = Datos.ExecuteScalar("SELECT dbo.SfCategoria_ContarTodos()", CommandType.Text).ToString();
            TxtVencidos.Text = Datos.ExecuteScalar("SELECT dbo.SfLote_CantidadVencida()", CommandType.Text).ToString();
        }

        private void GraficarTopVendidos()
        {
            // Define las etiquetas que apareceran sobre el cuadro
            // en este caso se mostrara el valor dado y el porcentaje e.g 123 (8%)  
            string labelPoint(ChartPoint chartPoint) => string.Format("{0}", chartPoint.Y);

            // Define una colecion de items para mostrar en el cuadro
            LiveCharts.SeriesCollection piechartData = new LiveCharts.SeriesCollection();

            DataTable dtProductos = Datos.ExecuteReader("SELECT TOP 5 * FROM dbo.VwDetalle_MasVendido ORDER BY Cantidad DESC", CommandType.Text);

            foreach (DataRow filas in dtProductos.Rows)
            {
                // Aregar nuevos item dinamicamente 
                piechartData.Add(
                    new PieSeries
                    {
                        Title = filas["Nombre del Producto"].ToString(),
                        Values = new ChartValues<double> { Safety.SafeDouble(filas["Cantidad"].ToString()) },
                        DataLabels = true,
                        LabelPoint = labelPoint
                    }
                );
            }

            DefaultLegend customLegend = new DefaultLegend
            {
                BulletSize = 15,
                Foreground = System.Windows.Media.Brushes.White,
                Orientation = System.Windows.Controls.Orientation.Vertical
            };

            PieTopVendidos.DefaultLegend = customLegend;

            PieTopVendidos.Series = piechartData;
            PieTopVendidos.LegendLocation = LegendLocation.Right;
        }

        private void GraficarTopEmpleados()
        {
            DataTable data = Datos.ExecuteReader("SELECT * FROM VwEmpleado_MejorVendedor", CommandType.Text);

            ColumnSeries series2 = new ColumnSeries()
            {
                DataLabels = true,
                Values = new ChartValues<int>(),
                LabelPoint = point => data.Rows.Cast<DataRow>().Where(i => Convert.ToDouble(i["Cantidad"]) == point.Y).Select(i => i["Cantidad"].ToString() ).First(),
                Title = "Ventas",
                Foreground = System.Windows.Media.Brushes.White,
            };

            var labels = new string[data.Rows.Count];
            int index = 0;

            foreach (DataRow filas in data.Rows)
            {
                series2.Values.Add(Convert.ToInt32(filas["Cantidad"]));
                labels[index++] = $"{Regex.Replace(filas["Nombres"].ToString(), " .*.", "")} {Regex.Replace(filas["Apellidos"].ToString(), " .*.", "")}";
            }

            Axis axisX = new Axis()
            {
                Separator = new Separator() { Step = 1, IsEnabled = false },
                Labels = labels
            };

            Axis axisY = new Axis()
            {
                LabelFormatter = y => y.ToString(),
                Separator = new Separator(),
                Title = "Ventas"
            };

            ChartTopVendor.Series.Add(series2);
            ChartTopVendor.AxisX.Add(axisX);
            ChartTopVendor.AxisY.Add(axisY);
        }

        private void GraficarGastosAño()
        {
            int año = Convert.ToInt32(DateYear.EditValue);
            DataTable dt = Datos.ExecuteReader("SELECT TOP 10 * FROM TfContable_PorAnio(@Anio)", CommandType.Text, 
                new SqlParameter("@Anio", año));

            ChartValues<double> Egreso = new ChartValues<double>();
            var Etiquetas = new string[dt.Rows.Count];
            int index = 0;

            foreach (DataRow filas in dt.Rows)
            {
                Egreso.Add(Math.Round(Convert.ToDouble(filas["Monto"]), 2));
                Etiquetas[index++] = filas["Motivo"].ToString();
            }

            chartGastosAño.Series.Clear();
            chartGastosAño.AxisX.Clear();
            chartGastosAño.AxisY.Clear();

            //Ingreso
            chartGastosAño.Series = new LiveCharts.SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Egreso",
                    Values = Egreso
                }
            };

            chartGastosAño.AxisX.Add(new Axis
            {
                Title = "Motivo",
                Labels = Etiquetas
            });

            chartGastosAño.AxisY.Add(new Axis
            {
                Title = "Monto",
                LabelFormatter = value => value.ToString("N")
            });
        }

        private void GraficarGastosMes()
        {
            int año = Convert.ToInt32(DateYear.EditValue);
            string mes = DateMonth.EditValue.ToString();

            DataTable dt = Datos.ExecuteReader("SELECT TOP 10 * FROM TfContable_PorMes(@Anio, @Mes)",
                CommandType.Text,
                new SqlParameter("@Anio", año),
                new SqlParameter("@Mes", mes));

            ChartValues<double> Egreso = new ChartValues<double>();

            var Etiquetas = new string[dt.Rows.Count];
            int index = 0;

            foreach (DataRow filas in dt.Rows)
            {
                Egreso.Add(Math.Round(Convert.ToDouble(filas["Monto"]), 2));
                Etiquetas[index++] = filas["Motivo"].ToString();
            }


            /*******/
            chartGastosMes.Series.Clear();
            chartGastosMes.AxisX.Clear();
            chartGastosMes.AxisY.Clear();

            //Ingreso
            chartGastosMes.Series = new LiveCharts.SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Egreso",
                    Values = Egreso
                }
            };

            chartGastosMes.AxisX.Add(new Axis
            {
                Title = "Motivo",
                Labels = Etiquetas
            });

            chartGastosMes.AxisY.Add(new Axis
            {
                Title = "Monto",
                LabelFormatter = value => value.ToString("N")
            });
        }

        private void GraficarVentas()
        {
            DataTable dtventas;

            if (CbFiltrar.Checked)
            {
                dtventas = Datos.ExecuteReader("SELECT * FROM TfFactura_SegunFecha(@FechaInit, @FechaFin) ORDER BY FechaVenta ASC", CommandType.Text,
                    new SqlParameter("@FechaInit", DateInit.EditValue),
                    new SqlParameter("@FechaFin", DateEnd.EditValue));
            }
            else
            {
                dtventas = Datos.ExecuteReader("SELECT * FROM TfFactura_Todos() ORDER BY FechaVenta ASC", CommandType.Text);
            }

            var values = new ChartValues<double>();
            var dates = new string[dtventas.Rows.Count];
            int index = 0;
            foreach (DataRow filas in dtventas.Rows) 
            {
                values.Add(Math.Round(Convert.ToDouble(filas["Total"]), 2));
                dates[index++] = filas["FechaVenta"].ToString();
            }

            ChartVentas.Series.Add(new LineSeries
            {
                Values = values,
                Title = "Monto: C$"
            });

            ChartVentas.AxisX.Add(new Axis
            {
                MinValue = 0,
                MaxValue = 25,
                Title = "Fecha",
                Labels = dates
            });

            //Eventos para el grafico

            PreviousVentas.Click += (obj, evt) =>
            {
                ChartVentas.AxisX[0].MinValue -= 25;
                ChartVentas.AxisX[0].MaxValue -= 25;
            };

            NextVentas.Click += (obj, evt) =>
            {
                ChartVentas.AxisX[0].MinValue += 25;
                ChartVentas.AxisX[0].MaxValue += 25;
            };
        }

        private void GraficarProductosActivos()
        {
            solidGauge1.Uses360Mode = true;
            solidGauge1.From = 0;
            solidGauge1.To = 100;
            solidGauge1.Value = Safety.SafeDouble(Datos.ExecuteScalar("SELECT dbo.SfProducto_PorcentajeActivo()", CommandType.Text).ToString());
            solidGauge1.Base.GaugeRenderTransform = new TransformGroup
            {
                Children = new TransformCollection
                {
                    new RotateTransform(90),
                    new ScaleTransform {ScaleX = -1}
                }
            };
            solidGauge1.Base.Foreground = System.Windows.Media.Brushes.White;
        }

        #endregion

        #region Eventos

        private void Dashboard_Load(object sender, EventArgs e)
        {
            SetearConteo();
            GraficarTopVendidos();
            GraficarProductosActivos();

            DateYear.Properties.DataSource = Datos.ExecuteReader("SELECT Anio AS Año FROM TfContable_Anios() ORDER BY Anio DESC", CommandType.Text);
            DateYear.Properties.DisplayMember = "Año";
            DateYear.Properties.ValueMember = "Año";
            DateYear.ItemIndex = 0;
            DateMonth.ItemIndex = 0;
            CbFiltrar.Checked = false; 
            GraficarVentas();
            GraficarTopEmpleados();
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

            GraficarGastosMes();
        }

        private void Control_ValueChanged(object sender, EventArgs e)
        {
            GraficarVentas();
        }

        #endregion
    }
}
