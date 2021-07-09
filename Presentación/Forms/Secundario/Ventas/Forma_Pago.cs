using DevExpress.XtraReports.UI;
using Negocio;
using Presentación.Reports;
using System;
using System.Data;
using System.Windows.Forms;

namespace Presentación.Forms.Secundario.Ventas
{
    public partial class Forma_Pago : Form
    {
        private float PagoCon;
        private int Opcion = 0;
        private bool Procede = false;
        private readonly float TotalPagar;
        private readonly string TextoTotal;
        private readonly ModeloFactura Modelo;
        private readonly float Exchange = 34.92f;
        private readonly DataTable dt;

        public Forma_Pago(string TextoTotal, ModeloFactura modelo, DataTable dt)
        {
            InitializeComponent();
            this.dt = dt;
            Modelo = modelo;
            this.TextoTotal = TextoTotal;
            lbTotalPagar.Text = TextoTotal;
            TextoTotal = TextoTotal.Replace("C$", "");

            if (!float.TryParse(TextoTotal, out TotalPagar))
            {
                MessageBox.Show("OCURRE ALGO");
                Close();
            }
            GetSouce();
        }

        private void GetSouce()
        {
            LbTipChange.Text = string.Format(LbTipChange.Text, Exchange);
            LkeCliente.Properties.DataSource = new ModeloCliente().LeerTabla();
            LkeCliente.Properties.ValueMember = "IdCliente";
            LkeCliente.Properties.DisplayMember = "Nombre";
        }

        private int InsertarVenta()
        {
            Modelo.Entidad = new Entidad.EFactura
            {
                IdEmpleado = 1,
                IdCliente = 1,
                IdForma = 1,
                FechaVenta = DateTime.Today,
                Total = TotalPagar,
                SubTotal = TotalPagar,
                PagoCon = PagoCon,
                Comentario = null,
                Estado = "PAGADO",
            };
            Modelo.Accion = Negocio.Utils.Accion.Agregar;
            Modelo.Accionar();

            MessageBox.Show(Modelo.Mensaje);
            if (!Modelo.Exito)
            {
                return -1;
            }

            return (int)Datos.ExecuteScalar("SELECT TOP(1) IdFactura FROM Factura ORDER BY 1 DESC", CommandType.Text);
        }

        public static void InsertarDetalles(int IdVenta, DataRowCollection dataRow)
        {
            ModeloDetalle_Factura modeloDetalle = new ModeloDetalle_Factura();

            foreach (DataRow row in dataRow)
            {
                modeloDetalle.Entidad = new Entidad.EDetalle_Factura
                {
                    IdProducto = Safety.SafeInt(row["IdProducto"].ToString()),
                    IdFactura = IdVenta,
                    Precio = Safety.SafeFloat(row["Precio"].ToString()),
                    Cantidad = Safety.SafeFloat(row["Cantidad"].ToString()),
                    Descuento = 0,
                    AlPorMayor = false,
                };

                modeloDetalle.Accion = Negocio.Utils.Accion.Agregar;
                modeloDetalle.Accionar();


                /*Modelo.ReducirStock(Convert.ToInt32(row["IdProducto"]), Convert.ToInt32(row["ClCantidad"]));


                if (row["ClStock"].ToString() != "Ilimitado")
                {
                    Consulta.ExecuteNonQuerySP("insertar_KARDEX_SALIDA",
                        new SqlParameter("@Fecha", DateTime.Now),
                        new SqlParameter("@Motivo", "Venta #" + IdVenta + " " + row["IdProducto"]),
                        new SqlParameter("@Cantidad ", row["ClCantidad"]),
                        new SqlParameter("@Id_producto", row["IdProducto"]),
                        new SqlParameter("@Id_usuario", 1),
                        new SqlParameter("@Tipo", "SALIDA"),
                        new SqlParameter("@Estado", "DESPACHO CONFIRMADO"),
                        new SqlParameter("@Id_caja", 1));
                }*/
            }
        }

        private void ImprimirRecibo(int IdVenta)
        {
            var report = new RptVenta();
            report.Parameters["IdFactura"].Value = IdVenta;
            report.RequestParameters = false;
            report.ShowPreview();
        }

        private void BtnCobrar_Click(object sender, EventArgs e)
        {
            if (!Procede)
            {
                MessageBox.Show("Verifique: El efectivo es menor al monto a pagar");
                return;
            }

            switch (Opcion)
            {
                case 0:
                    PagoCon = float.Parse(TxtPagoEfectivo.Text);
                    break;
                case 2:
                    ///PagoDolares();
                    break;
                case 3:
                    //PagoMixto();
                    break;
            }


            int IdVenta = InsertarVenta();
            InsertarDetalles(IdVenta, dt.Rows);

            if (true)
            {
                ImprimirRecibo(IdVenta);
            }

            Close();
        }

        private void TxtPagoEfectivo_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(TxtPagoEfectivo.Text, out float pago))
            {
                float cambio = pago - TotalPagar;
                if (cambio < 0)
                {
                    Procede = false;
                    errorProvider1.SetError(TxtCambioEfectivo, "Verifique: El efectivo es menor al monto a pagar");
                    TxtCambioEfectivo.Clear();
                }
                else
                {
                    Procede = true;
                    TxtCambioEfectivo.Text = cambio.ToString();
                    errorProvider1.Clear();
                }
            }
        }

        private void TxtPagoDolar_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(TxtPagoDolar.Text, out float PagoDolar))
            {
                float EquivCordoba = PagoDolar * Exchange;
                TxtEquivDolar.Text = EquivCordoba.ToString();

                float cambio = EquivCordoba - TotalPagar;
                if (cambio < 0)
                {
                    errorProvider1.SetError(TxtCambioDolar, "Verifique: El efectivo es menor al monto a pagar");
                    TxtCambioDolar.Clear();
                }
                else
                {
                    TxtCambioDolar.Text = cambio.ToString();
                    errorProvider1.Clear();
                }
            }
        }

        private void TabMxin_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {
            Opcion = int.Parse(TabMxin.SelectedPage.Tag.ToString());
            if (Opcion == 2)
            {
                lbTotalPagar.Text = "$ " + (TotalPagar / Exchange) + " USD";
            }
            else
            {
                lbTotalPagar.Text = TextoTotal;
            }
        }

        private void LkeCliente_EditValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(LkeCliente.Properties.ValueMember);
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        /* txtImpresora.Items.Clear();
            for (var I=0;I< PrinterSettings.InstalledPrinters.Count;I++)
            {
                txtImpresora.Items.Add(PrinterSettings.InstalledPrinters[I]);
            }
            txtImpresora.Items.Add("Ninguna");
         */
    }
}
