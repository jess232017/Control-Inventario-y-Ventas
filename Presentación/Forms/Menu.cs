using DevExpress.XtraBars.Docking;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using Presentación.Forms.Caja;
using Presentación.Forms.Principal.Admin;
using Presentación.Forms.Secundario.Cajas;
using Presentación.Forms.Secundario.Cliente;
using Presentación.Forms.Secundario.Contactos.Proveedor;
using Presentación.Forms.Secundario.Empleado;
using Presentación.Forms.Secundario.Inventarios;
using Presentación.Forms.Secundario.Movimientos;
using Presentación.Forms.Secundario.Productos;
using Presentación.Forms.Secundario.Tiendas;
using Presentación.Forms.Secundario.Ventas;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Presentación.Forms
{
    public partial class Menu : XtraForm
    {
        public float DineroInicial { get; set; } = 0;
        private AccordionControlElement ControlActual;

        private DockPanel dashboard;
        //private DockPanel frmVentas;
        private DockPanel frmInventarios;
        private DockPanel frmProveedores;
        private DockPanel frmMovimientos;
        private DockPanel frmProductos;
        private DockPanel frmEmpleados;
        private DockPanel frmClientes;
        private DockPanel frmTiendas;
        private DockPanel frmCajas;

        public Menu()
        {
            InitializeComponent();

            //Abrir panel determinado
            ControlActual = SbDashboard;
            AbrirComoTab(GetDashboard());

            WindowState = FormWindowState.Normal;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Bounds = Screen.PrimaryScreen.Bounds;
            sbContactos.Expanded = false;
        }

        #region Metodos

        private void AbrirComoTab(DockPanel panel, bool expanded = false)
        {
            sbContactos.Expanded = expanded;
            if (documentManager1.View.Documents.TryGetValue(panel, out BaseDocument document))
            {
                documentManager1.View.Controller.Activate(document);
                return;
            }

            documentManager1.View.AddDocument(panel);
            documentManager1.View.ActivateDocument(panel);
        }

        private DockPanel CrearDockPanel(Form form)
        {
            DockPanel p = new DockPanel();
            form.MdiParent = documentManager1.View.Manager.MdiParent;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Text = form.Text.Replace("Frm", "");
            form.Dock = DockStyle.Fill;
            p.Register(dockManager1);
            form.ControlBox = false;
            form.TopLevel = false;
            p.Controls.Add(form);
            p.Text = form.Text;
            //p.Tag = icon;

            form.BringToFront();
            form.Show();
            p.BringToFront();
            p.Show();

            return p;
        }

        private DockPanel GetDashboard()
        {
            if (dashboard == null || dashboard.IsDisposed)
            {
                Dashboard dash = new Dashboard();

                //Asignar los mismo eventos de click
                dash.TileVentas.ItemClick += SbVentas_Click;
                dash.TileProducts.ItemClick += SbProductos_Click;
                dash.TileClients.ItemClick += SbClientes_Click;
                dash.TileStock.ItemClick += SbInventario_Click;
                dash.TileEmployess.ItemClick += SbEmpleados_Click;
                dash.TileSupplier.ItemClick += SbProveedores_Click;
                dash.TileInventories.ItemClick += SbInventario_Click;
                dash.TileMovements.ItemClick += SbMovimientos_Click;

                dashboard = CrearDockPanel(dash);
            }

            return dashboard;
        }

        private void BuscarActivo(string Titulo)
        {
            foreach (var Item in accordionControl1.Elements)
            {
                if (Item.Text.Equals(Titulo))
                {
                    ActivarBoton(Item);
                    return;
                }

                foreach (var SubItem in Item.Elements)
                {
                    if (SubItem.Text.Equals(Titulo))
                    {
                        ActivarBoton(SubItem);
                        return;
                    }
                }
            };
        }

        private void ActivarBoton(AccordionControlElement Actual)
        {
            ControlActual.Appearance.Normal.BackColor = System.Drawing.Color.Transparent;
            Actual.Appearance.Normal.BackColor = System.Drawing.Color.FromArgb(31, 97, 206);
            ControlActual = Actual;
        }

        #endregion

        #region Eventos

        // Botones Laterales
        private void SbDashboard_Click(object sender, EventArgs e)
        {
            AbrirComoTab(GetDashboard());
        }

        private void SbVentas_Click(object sender, EventArgs e)
        {
            /*if (frmVentas == null || frmVentas.IsDisposed)
            {
                frmVentas = CrearDockPanel(new FrmVentas());
            }*/

            AbrirComoTab(CrearDockPanel(new FrmVentas()));
        }

        private void SbInventario_Click(object sender, EventArgs e)
        {
            if (frmInventarios == null || frmInventarios.IsDisposed)
            {
                frmInventarios = CrearDockPanel(new FrmInventarios());
            }

            AbrirComoTab(frmInventarios);
        }

        private void SbProductos_Click(object sender, EventArgs e)
        {
            if (frmProductos == null || frmProductos.IsDisposed)
            {
                frmProductos = CrearDockPanel(new FrmProductos());
            }

            AbrirComoTab(frmProductos);
        }

        private void SbMovimientos_Click(object sender, EventArgs e)
        {
            if (frmMovimientos == null || frmMovimientos.IsDisposed)
            {
                frmMovimientos = CrearDockPanel(new FrmMovimientos());
            }

            AbrirComoTab(frmMovimientos);
        }

        private void SbProveedores_Click(object sender, EventArgs e)
        {
            if (frmProveedores == null || frmProveedores.IsDisposed)
            {
                frmProveedores = CrearDockPanel(new FrmProveedores());
            }
            AbrirComoTab(frmProveedores, true);
        }

        private void SbEmpleados_Click(object sender, EventArgs e)
        {
            if (frmEmpleados == null || frmEmpleados.IsDisposed)
            {
                frmEmpleados = CrearDockPanel(new FrmEmpleados());
            }

            AbrirComoTab(frmEmpleados, true);
        }

        private void SbClientes_Click(object sender, EventArgs e)
        {
            if (frmClientes == null || frmClientes.IsDisposed)
            {
                frmClientes = CrearDockPanel(new FrmClientes());
            }
            AbrirComoTab(frmClientes, true);
        }

        private void SbCajas_Click(object sender, EventArgs e)
        {
            if (frmCajas == null || frmCajas.IsDisposed)
            {
                frmCajas = CrearDockPanel(new FrmCajas());
            }
            AbrirComoTab(frmCajas);
        }

        private void SbTiendas_Click(object sender, EventArgs e)
        {
            if (frmTiendas == null || frmTiendas.IsDisposed)
            {
                frmTiendas = CrearDockPanel(new FrmTiendas());
            }
            AbrirComoTab(frmTiendas);
        }

        private void SbConfiguracion_Click(object sender, EventArgs e)
        {
            new Configuracion().ShowDialog();
        }

        private void SbAyuda_Click(object sender, EventArgs e)
        {
            try
            {
                var Ruta = Path.Combine(Directory.GetCurrentDirectory(), "Manual de Usuario.pdf");
                ProcessStartInfo startInfo = new ProcessStartInfo(Ruta);
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void SbInfoCreditos_Click(object sender, EventArgs e)
        {
            new FrmCreditos().ShowDialog();
        }

        //Otros eventos

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = OpcionCierre.Show();

            switch (result)
            {
                case DialogResult.OK:
                    e.Cancel = false;
                    break;

                case DialogResult.Yes:
                    if (Cierre_Turno.Show() != DialogResult.OK)
                    {
                        e.Cancel = true;
                    }
                    break;
                default:
                    e.Cancel = true;
                    break;
            }
        }

        private void DocumentManager1_DocumentActivate(object sender, DocumentEventArgs e)
        {
            if (documentManager1.View.ActiveDocument != null)
            {
                BuscarActivo(documentManager1.View.ActiveDocument.Control.Text);
            }
        }


        #endregion
    }
}