using DevExpress.XtraBars.Docking;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Helpers;
using Presentación.Forms.Caja;
using Presentación.Forms.Principal;
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
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Presentación.Forms
{
    public partial class MenuV2 : XtraForm
    {
        public float DineroInicial { get; set; } = 0;
        private Guna2GradientButton ControlActual;
        private readonly Panel leftBorderBtn;

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


        public MenuV2()
        {
            InitializeComponent();

            //Abrir panel determinado
            ControlActual = BtnDashboard;
            AbrirComoTab(GetDashboard());

            //Indicador
            leftBorderBtn = new Panel();
            SubContactos.Visible = false;
            leftBorderBtn.Visible = true;
            leftBorderBtn.Size = new Size(7, 45);
            DivNav.Controls.Add(leftBorderBtn);
            leftBorderBtn.BackColor = Color.FromArgb(0, 120, 215);
            leftBorderBtn.Location = new Point(0, ControlActual.Location.Y);
            leftBorderBtn.BringToFront();
            CambiarImageOffset(new Point(-80, 0));

            //Pantalla Maximizada
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Bounds = Screen.PrimaryScreen.Bounds;
        }

        #region Metodos

        private void AbrirComoTab(DockPanel panel, bool expanded = false)
        {
            SubContactos.Visible = expanded;
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
                DashboardV2 dash = new DashboardV2();

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
            foreach (var Item in DivNav.Controls)
            {
                if (Item is Guna2GradientButton button)
                {
                    if (button.Text.Equals(Titulo))
                    {
                        ActivarBoton(button);
                        return;
                    }
                }
            };

            foreach (var Item in SubContactos.Controls)
            {
                if (Item is Guna2GradientButton button)
                {
                    if (button.Text.Equals(Titulo))
                    {
                        ActivarBoton(button);
                        return;
                    }
                }
            };
        }

        private void ActivarBoton(Guna2GradientButton Actual)
        {
            ControlActual.FillColor = Color.Transparent;
            ControlActual.FillColor2 = Color.Transparent;
            Actual.FillColor = Color.FromArgb(31, 97, 206);
            Actual.FillColor2 = Color.FromArgb(31, 97, 206);
            ControlActual = Actual;
            
            //
            if(!(Actual.Text.Equals("Clientes") || Actual.Text.Equals("Empleados") || Actual.Text.Equals("Proveedores")))
            {
                leftBorderBtn.Location = new Point(0, ControlActual.Location.Y);
            }
            leftBorderBtn.BringToFront();
        }

        private void CambiarImageOffset(Point point)
        {
            foreach (var Item in DivNav.Controls)
            {
                if (Item is Guna2GradientButton button)
                {
                    button.ImageOffset = point;
                }
            };

            foreach (var Item in SubContactos.Controls)
            {
                if (Item is Guna2GradientButton button)
                {

                    button.ImageOffset = point;
                }
            };
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

        private DockPanel visorPDF;

        private void SbAyuda_Click(object sender, EventArgs e)
        {

            if (visorPDF == null || visorPDF.IsDisposed)
            {
                visorPDF = CrearDockPanel(new VisorPDF());
            }
            AbrirComoTab(visorPDF);
        }

        private void SbInfoCreditos_Click(object sender, EventArgs e)
        {
            new FrmCreditos().ShowDialog();
        }

        private void BtnContactos_Click(object sender, EventArgs e)
        {
            if (!BtnShowAgain.Visible)
            {
                SubContactos.Visible = !SubContactos.Visible;
                leftBorderBtn.Location = new Point(0, BtnContactos.Location.Y);
                leftBorderBtn.BringToFront();
            }
            else
            {
                flyNotify1.ShowBeakForm();
            }
        }

        private void SubContactos_VisibleChanged(object sender, EventArgs e)
        {
            BtnContactos.CustomImages.Image = (SubContactos.Visible) ? Properties.Resources.icons8_sort_up_48 : Properties.Resources.icons8_sort_down_48;
            Point point = (SubContactos.Visible) ? new Point(-72, 0) : new Point(-80, 0);
            CambiarImageOffset(point);
        }

        private void PicLogo_Click(object sender, EventArgs e)
        {
            SubContactos.Visible = false;
            BtnShowAgain.Visible = DivHeader.Visible;
            DivHeader.Visible = !DivHeader.Visible;
            SideMenu.Width = (DivHeader.Visible) ? 229 :48;
            BtnConfiguracion.Text = (DivHeader.Visible) ? "Configuración" : "";
            ToolTip.InitialDelay = (DivHeader.Visible) ? 6000: 300;
            Point point = (DivHeader.Visible) ? new Point(-80, 0) : new Point(0, 0);
            BtnContactos.CustomImages.ImageSize = (DivHeader.Visible) ? new Size(20, 20) : new Size(0, 0);

            CambiarImageOffset(point);
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