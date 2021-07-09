using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Negocio;
using Presentación.Forms.Principal.Heredables;

namespace Presentación.Forms.Secundario.Cajas
{
    public partial class FrmCaja : Edition_Object
    {
        private readonly ModeloCaja modelo;
        public FrmCaja()
        {
            InitializeComponent();
            modelo = new ModeloCaja();
        }

        public FrmCaja(ModeloCaja Modelo, int Index) : base(Modelo)
        {
            modelo = Modelo;
            SelectedIndex = Index;
            InitializeComponent();
        }

        #region Metodos

        private void CargarImpresoras()
        {
            ComboBoxItemCollection ItemsA4 = Impresora_A4TextEdit.Properties.Items;
            ComboBoxItemCollection ItemTicket = Impresora_TicketTextEdit.Properties.Items;

            ItemsA4.BeginUpdate();
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                //MessageBox.Show(printer);Serial_PCTextEdit.Properties.
                try
                {
                    ItemsA4.Add(printer);
                    ItemTicket.Add(printer);
                }
                finally
                {
                    ItemsA4.EndUpdate();
                    ItemTicket.EndUpdate();
                }
            }

            Impresora_A4TextEdit.SelectedIndex = -1;
            Impresora_TicketTextEdit.SelectedIndex = -1;
        }

        protected override void ObtenerDatos()
        {
            modelo.Entidad = modelo.LeerEntidad();

            if (modelo.Exito)
            {
                IdCajaTextEdit.Text = modelo.Entidad.IdCaja.ToString();
                DescripcionTextEdit.Text = modelo.Entidad.Descripcion.ToString();
                Serial_PCTextEdit.Text = modelo.Entidad.Serial_PC.ToString();
                Impresora_TicketTextEdit.Text = modelo.Entidad.Impresora_Ticket.ToString();
                Impresora_A4TextEdit.Text = modelo.Entidad.Impresora_A4.ToString();
                EstadoCheckEdit.Checked = modelo.Entidad.Estado;
            }
        }

        protected override void SetearDatos()
        {
            modelo.Entidad = new Entidad.ECaja
            {
                IdCaja = Safety.SafeInt(IdCajaTextEdit.Text),
                Descripcion = DescripcionTextEdit.Text,
                Serial_PC = Serial_PCTextEdit.Text,
                Impresora_Ticket = Impresora_TicketTextEdit.Text,
                Impresora_A4 = Impresora_A4TextEdit.Text,
                Estado = EstadoCheckEdit.Checked,
            };
        }
        #endregion

        #region Eventos

        private void FrmCaja_Load(object sender, System.EventArgs e)
        {
            CargarImpresoras();
            cajaBindingSource.DataSource = modelo.LeerLista();
        }

        #endregion

    }
}