using DevExpress.XtraEditors;
using Negocio;
using Presentación.Forms.Principal.Heredables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentación.Forms.Secundario.Movimientos
{
    public partial class FrmMovimientos : Edition_Collection
    {

        public FrmMovimientos()
        {
            InitializeComponent();
            modelo = new ModeloMovimiento();
            DeFecha.Properties.Mask.EditMask = "dd/MM/yyyy";
            RellenarCombobox();
        }

        #region Metodos

        private void RellenarCombobox()
        {
            //Cambiar por el modelo cuando este disponible
            //LkBuscarMovimiento.Properties.DataSource = new ModeloEmpleado().LeerTabla();
            LkBuscarMovimiento.Properties.DataSource = Datos.ExecuteReader("SELECT IdEmpleado, Nombres + ' ' + Apellidos AS Nombres FROM Empleado", CommandType.Text);
            LkBuscarMovimiento.Properties.DisplayMember = "Nombres";
            LkBuscarMovimiento.Properties.ValueMember = "IdEmpleado";

            //LkBuscarVanced.Properties.DataSource = new ModeloEmpleado().LeerTabla();
            LkVendedorVanced.Properties.DataSource = Datos.ExecuteReader("SELECT IdEmpleado, Nombres + ' ' + Apellidos AS Nombres FROM Empleado", CommandType.Text);
            LkVendedorVanced.Properties.DisplayMember = "Nombres";
            LkVendedorVanced.Properties.ValueMember = "IdEmpleado";
        }

        #endregion

        #region Eventos
        private void BtnFiltrar_Click(object sender, EventArgs e)
        {

        }

        private void BtnFilterVanced_Click(object sender, EventArgs e)
        {
            if (FlyVanceMoving.Visible)
            {
                FlyMovimiento.ShowPopup();
                FlyVanceMoving.HidePopup();
            }
            else
            {
                FlyVanceMoving.ShowPopup();
                FlyMovimiento.HidePopup();
            }
        }

        private void BtnHideFilter_Click(object sender, EventArgs e)
        {
            if (FlyVanceMoving.Visible)
            {
                FlyMovimiento.ShowPopup();
                FlyVanceMoving.HidePopup();
            }
            else
            {
                FlyVanceMoving.ShowPopup();
                FlyMovimiento.HidePopup();
            }
        }

        private void LkBuscarMovimiento_EditValueChanged(object sender, EventArgs e)
        {
            gridControl1.DataSource = Datos.ExecuteReader("SELECT * FROM TfMovimiento_SegunEmpleado(@IdEmpleado)", CommandType.Text,
                new SqlParameter("@IdEmpleado", LkBuscarMovimiento.EditValue));
        }

        private void Control_ValueChanged(object sender, EventArgs e)
        {
            if (LkVendedorVanced.EditValue is null || DeFecha.EditValue is null || CbeEstado.EditValue is null)
                return;

            MessageBox.Show(LkVendedorVanced.EditValue + " " + DeFecha.EditValue + " " + CbeEstado.EditValue);
            gridControl1.DataSource = Datos.ExecuteReader("SELECT * FROM TfMovimiento_FiltroAvanzado(@IdEmpleado, @Fecha, @Estado) ", CommandType.Text,
                new SqlParameter("@IdEmpleado", LkVendedorVanced.EditValue),
                new SqlParameter("@Fecha", DeFecha.EditValue.ToString()),
                new SqlParameter("@Estado", CbeEstado.EditValue)); 

        }
        #endregion       
    }
}