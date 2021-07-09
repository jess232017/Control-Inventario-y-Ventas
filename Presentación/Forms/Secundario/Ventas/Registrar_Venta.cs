using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Data;
using System.Windows.Forms;
using Presentación.Forms.Secundario.Contable;
using System.Data.SqlClient;
using Negocio;

namespace Presentación.Forms.Secundario.Ventas
{
    public partial class Registrar_Venta : Form
    {
        private readonly int IdVenta = -1;
        private DataTable dtProductos;
        private readonly ModeloFactura Modelo;

        public Registrar_Venta(ModeloFactura modelo, int IdVenta)
        {
            InitializeComponent();
            Modelo = modelo;
            BuscarProductos();
            CreateTable();

            this.IdVenta = IdVenta;
            RestaurarVenta(IdVenta);
        }

        public Registrar_Venta(ModeloFactura modelo)
        {
            InitializeComponent();
            Modelo = modelo;
            BuscarProductos();
            CreateTable();
        }

        private void RestaurarVenta(int IdVenta)
        {
            //var Result = Modelo.GetDetalleVenta(IdVenta);
            /*foreach (DataRow item in Result.Rows)
            {
                DataRow myDataRow = dtProductos.NewRow();
                myDataRow["Stock"] = item["Stock"];
                myDataRow["Precio"] = item["P_Unit"];
                myDataRow["Importe"] = item["Importe"];
                myDataRow["Granel"] = item["Se_vende_a"];
                myDataRow["IdProducto"] = item["Id_producto"];
                myDataRow["Descripcion"] = item["Producto"];
                myDataRow["Cantidad"] = item["Cant"];

                dtProductos.Rows.Add(myDataRow);
            }*/
        }

        private void CreateTable()
        {
            // Create a new DataTable.    
            dtProductos = new DataTable("Productos");

            // Add column to the DataColumnCollection.
            dtProductos.Columns.Add(NewColumn("IdProducto", "Id Producto", typeof(int), true, true));
            dtProductos.Columns.Add(NewColumn("Descripcion", "Descripción", typeof(string), true));
            dtProductos.Columns.Add(NewColumn("Precio", "Precio Venta", typeof(string), true));
            dtProductos.Columns.Add(NewColumn("Cantidad", "Cantidad", typeof(float), false));
            dtProductos.Columns.Add(NewColumn("Importe", "Importe", typeof(float), false));
            dtProductos.Columns.Add(NewColumn("Stock", "Existencias", typeof(string), true));
            dtProductos.Columns.Add(NewColumn("Granel", "Granel", typeof(bool), true));
            dtProductos.RowChanged += new DataRowChangeEventHandler(OnRowChanged);
            dtProductos.RowDeleted += new DataRowChangeEventHandler(OnRowChanged);

            // bound gridcontrol with created datable
            gridControl1.DataSource = dtProductos;

            AddDeleteButton();
            AddPsMsButton();
        }

        private DataColumn NewColumn(string ColumnName, string Caption, Type Tipo, bool ReadOnly, bool Unique = false)
        {
            DataColumn dtColumn = new DataColumn
            {
                ColumnName = ColumnName,
                ReadOnly = ReadOnly,
                Caption = Caption,
                DataType = Tipo,
                Unique = Unique,
            };

            return dtColumn;
        }

        private void AddDeleteButton()
        {
            GridColumn gridColumn = gridView1.Columns.AddVisible("Eliminar", string.Empty);
            RepositoryItemButtonEdit btnBorrar = new RepositoryItemButtonEdit();
            btnBorrar.TextEditStyle = TextEditStyles.HideTextEditor;
            btnBorrar.ButtonClick += (sender, e) => {
                if (e.Button.Kind == ButtonPredefines.Delete)
                {
                    if (XtraMessageBox.Show("¿Desea remover este producto?", "Remover", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        gridView1.DeleteRow(gridView1.FocusedRowHandle);
                    }
                }
            };
            btnBorrar.Buttons[0].Kind = ButtonPredefines.Delete;
            btnBorrar.Buttons[0].Caption = "Eliminar Producto";

            gridControl1.RepositoryItems.Add(btnBorrar);
            gridColumn.ColumnEdit = btnBorrar;
        }

        private void AddPsMsButton()
        {
            // Show a button in a grid cell            
            gridView1.OptionsView.ShowButtonMode = ShowButtonModeEnum.ShowAlways;
            RepositoryItemButtonEdit UpDown = new RepositoryItemButtonEdit();
            RepositoryItemButtonEdit Bulk = new RepositoryItemButtonEdit();
            UpDown.Buttons.Clear();
            Bulk.Buttons.Clear();

            UpDown.Buttons.Add(new EditorButton(ButtonPredefines.Plus, "Aumentar"));
            UpDown.Buttons.Add(new EditorButton(ButtonPredefines.Minus, "Reducir"));
            Bulk.Buttons.Add(new EditorButton(ButtonPredefines.Up, "Venta a Granel"));

            UpDown.ButtonClick += (sender, e) => {
                int index = int.Parse(gridView1.FocusedRowHandle.ToString());
                DataRow dato = dtProductos.Rows[index];
                int cantidad;

                if (e.Button.Kind == ButtonPredefines.Plus)
                {
                    cantidad = int.Parse(dato["Cantidad"].ToString()) + 1;
                    if (cantidad > int.Parse(dato["Stock"].ToString()))
                    {
                        XtraMessageBox.Show("Se ha quedado sin inventario", "Ventas");
                        return;
                    }
                }
                else
                {
                    cantidad = int.Parse(dato["Cantidad"].ToString()) - 1;
                    if (cantidad < 1)
                    {
                        XtraMessageBox.Show("Presione el botón eliminar si lo que desea es eliminar el producto de la lista", "Ventas");
                        return;
                    }
                }

                dato["Importe"] = float.Parse(dato["Precio"].ToString()) * cantidad;
                dato["Cantidad"] = cantidad;

                gridView1.UpdateCurrentRow();
            };

            Bulk.ButtonClick += (sender, e) => {
                int index = int.Parse(gridView1.FocusedRowHandle.ToString());
                DataRow dato = dtProductos.Rows[index];

                string Descripcion = dato["Descripcion"].ToString();
                float Stock = float.Parse(dato["Stock"].ToString());
                float Precio = float.Parse(dato["Precio"].ToString());
                float cantidad = float.Parse(dato["Cantidad"].ToString());

                if (Venta_Granel.GetAmount(Descripcion, ref cantidad, Precio, Stock, true) == DialogResult.OK)
                {
                    if (cantidad > float.Parse(dato["Stock"].ToString()))
                    {
                        XtraMessageBox.Show("Se ha quedado sin inventario", "Ventas");
                        return;
                    }
                    else if (cantidad < 0)
                    {
                        XtraMessageBox.Show("Presione el botón eliminar si lo que desea es eliminar el producto de la lista", "Ventas");
                        return;
                    }

                    dato["Importe"] = cantidad * Precio;
                    dato["Cantidad"] = cantidad;

                    gridView1.UpdateCurrentRow();
                }
            };

            gridView1.CustomRowCellEdit += (s, e) => {
                if (e.Column.FieldName == "Cantidad")
                {
                    GridView view = s as GridView;
                    string forma = view.GetRowCellValue(e.RowHandle, "Granel").ToString();
                    e.RepositoryItem = forma.Contains("False") ? UpDown : Bulk;
                }
            };

        }

        private void OnRowChanged(object sender, DataRowChangeEventArgs args)
        {
            if (args.Action != DataRowAction.Nothing)
            {
                txtTotal.Text = "C$ " + dtProductos.Compute("SUM(Importe)", string.Empty);
                TxtItems.Text = dtProductos.Compute("SUM(Cantidad)", string.Empty) + " Items";
            }
        }

        private void BuscarProductos()
        {
            TxtBuscar.Properties.DataSource = Datos.ExecuteReader("SP_ProductoBuscar", CommandType.StoredProcedure,
                new SqlParameter("@Buscar", ""));
            TxtBuscar.Properties.DisplayMember = "Descripcion";
            TxtBuscar.Properties.ValueMember = "IdProducto";
        }

        private bool VentaIsGenerada()
        {
            if (IdVenta == -1)
            {
                Modelo.Entidad = new Entidad.EFactura
                {
                    IdEmpleado = 1,
                    IdCliente = 1,
                    IdForma = 1,
                    FechaVenta = DateTime.Today,
                    Total = 0,
                    SubTotal = 0,
                    PagoCon = 0,
                    Comentario = null,
                    Estado = "NOPAGADO",
                };

                Modelo.Accion = Negocio.Utils.Accion.Agregar;
                Modelo.Accionar();

                if (!Modelo.Exito)
                {
                    XtraMessageBox.Show(Modelo.Mensaje);
                    return false;
                }
                //IdVenta = Modelo.GetIdVenta(ModeloMetadata.GetIdCaja());
            }
            return true;
        }

        private void InsertarDetalle()
        {
            /*Modelo.Detalle = new EDetalleVenta
            {
                idventa = IdVenta,
                Id_producto = Convert.ToInt32(row["IdProducto"]),
                cantidad = Convert.ToDecimal(row["ClCantidad"]),
                preciounitario = Convert.ToDecimal(row["ClPrecio"]),
                Moneda = "C$",
                Unidad_de_medida = "Unidad",
                Cantidad_mostrada = Convert.ToDecimal(row["ClCantidad"]),
                Estado = "CONFIRMADO",
                Descripcion = row["Descripcion"].ToString(),
                Codigo = "NOIMPLEMENTADO",
                Stock = row["ClStock"].ToString(),
                Se_vende_a = "UNIDAD",
                Usa_inventarios = "SI",
                Costo = 120
            };
            Modelo.AddDetalleVenta();
            Modelo.ReducirStock(Convert.ToInt32(row["IdProducto"]), Convert.ToInt32(row["ClCantidad"]));
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

        private void TxtBuscar_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtBuscar.EditValue != null /*& VentaIsGenerada()*/)
            {
                LookUpEdit edit = sender as LookUpEdit;
                string IdProducto = TxtBuscar.EditValue.ToString();
                bool Granel = edit.GetColumnValue("Granel").ToString().Equals("True");
                float Stock = float.Parse(edit.GetColumnValue("Cantidad").ToString());
                string Descripcion = edit.GetColumnValue("Descripcion").ToString();
                float Precio = float.Parse(edit.GetColumnValue("PrecioVenta").ToString());

                //Verificar Existencia
                if (edit.GetColumnValue("Inventariado").ToString().Equals("1") && Stock == 0)
                {
                    XtraMessageBox.Show("No existe stock para este producto", "Stock Agotado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtBuscar.EditValue = null;
                    return;
                }

                //Verificando si ya esta dentro de los detalles de la venta
                DataRow[] Existe = dtProductos.Select("IdProducto = '" + IdProducto + "'");

                if (Existe.Length != 0)
                {

                    float Amount = 1;
                    if (Granel)
                    {
                        if (Venta_Granel.GetAmount(Descripcion, ref Amount, Precio, Stock) == DialogResult.Cancel)
                        {
                            XtraMessageBox.Show("Venta de Producto Cancelada");
                            TxtBuscar.EditValue = null;
                            return;
                        }
                    }

                    Amount = float.Parse(Existe[0]["Cantidad"].ToString()) + Amount;
                    Existe[0]["Importe"] = Precio * Amount;
                    Existe[0]["Cantidad"] = Amount;
                }
                else
                {
                    DataRow myDataRow = dtProductos.NewRow();
                    myDataRow["Stock"] = Stock;
                    myDataRow["Precio"] = Precio;
                    myDataRow["Importe"] = Precio;
                    myDataRow["Granel"] = Granel;
                    myDataRow["IdProducto"] = IdProducto;
                    myDataRow["Descripcion"] = Descripcion;

                    float Amount = 1;
                    if (Granel)
                    {
                        if (Venta_Granel.GetAmount(Descripcion, ref Amount, Precio, Stock) == DialogResult.Cancel)
                        {
                            XtraMessageBox.Show("Venta de Producto Cancelada");
                            TxtBuscar.EditValue = null;
                            return;
                        }
                    }
                    myDataRow["Cantidad"] = Amount;

                    dtProductos.Rows.Add(myDataRow);
                }
                TxtBuscar.EditValue = null;
            }
        }

        private void TxtBuscar_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TxtBuscar.Properties.Columns["Inventariado"].Visible = false;
            TxtBuscar.Properties.Columns["Granel"].Visible = false;
            TxtBuscar.Properties.Columns["IdProducto"].Visible = false;
            TxtBuscar.Properties.Columns["Cantidad"].Visible = false;
        }

        private void GridView1_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            GridView view = sender as GridView;
            if (view.FocusedColumn.FieldName == "Cantidad")
            {
                if (!double.TryParse(e.Value as string, out _))
                {
                    e.Valid = false;
                    e.ErrorText = "Digite solo valores numericos.";
                }
            }
        }

        private void BtnHerramientas_Click(object sender, EventArgs e)
        {
            if (PlTools.Visible)
                PlTools.Visible = false;
            else
                PlTools.Visible = true;
        }

        private void BtnCobrar_Click(object sender, EventArgs e)
        {
            if (dtProductos.Rows.Count > 0)
                new Forma_Pago(txtTotal.Text, Modelo, dtProductos).ShowDialog(this);
            else
                XtraMessageBox.Show("Debe registrar al menos un producto a la venta.", "Cobrar Venta");
        }

        private void BtnInEspera_Click(object sender, EventArgs e)
        {
            if (dtProductos.Rows.Count > 0)
            {
                int IdVenta = 0;
                string Response = XtraInputBox.Show("Nombre de la venta: ", "¿Desea asignarle un nombre manualmente a esta venta?", "Ticket #" + IdVenta, MessageBoxButtons.YesNo);
            }
            else
            {
                XtraMessageBox.Show("Debe registrar al menos un producto a la venta.", "Poner en Espera");
            }

        }

        private void BtnEntrada_Click(object sender, EventArgs e)
        {
            Registrar_Contable.Show();
        }

        private void BtnSalida_Click(object sender, EventArgs e)
        {
            Registrar_Contable.Show();
        }

        private void BtnContable_Click(object sender, EventArgs e)
        {
            new ListadoContable().ShowDialog(this);
            //new FrmContables().Show();
        }

        private void BtnMayoreo_Click(object sender, EventArgs e)
        {
            if (int.TryParse(gridView1.GetFocusedRowCellValue("IdProducto").ToString(), out int IdProducto))
            {

            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}