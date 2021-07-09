using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using Negocio.Utils;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Presentación.Forms.Principal.Heredables
{
    public partial class Edition_Collection : Form
    {
        protected IModelo modelo;
        protected string IdColumnName;
        protected int SelectedId = 0;

        public Edition_Collection()
        {
            InitializeComponent();
            Load += new EventHandler(Edition_Collection_Load);
        }

        #region Metodos

        /// <summary>
        /// Abre un Formulacio encima del actual
        /// </summary>
        /// <param name="hijo"></param>
        public void OpenAboveForm(Form hijo)
        {
            bar3.Visible = false;
            lbTitulo.Visible = false;

            hijo.FormBorderStyle = FormBorderStyle.None;
            hijo.Dock = DockStyle.Fill;
            hijo.TopLevel = false;
            hijo.FormClosed += (sender, e) => {
                lbTitulo.Visible = true;
                bar3.Visible = true;
            };

            Controls.Add(hijo);
            hijo.BringToFront();
            hijo.Show();
        }


        /// <summary>
        /// Abre un formulario hijo con un fondo obscuro
        /// </summary>
        protected void OpenChildForm(Form hijo)
        {
            using (hijo)
            {
                //Crear un formulario capa  
                Form overlayForm = new Form();
                overlayForm.StartPosition = FormStartPosition.Manual;
                overlayForm.FormBorderStyle = FormBorderStyle.None;
                overlayForm.StartPosition = FormStartPosition.CenterScreen;
                overlayForm.WindowState = FormWindowState.Maximized;
                overlayForm.Opacity = 0.59D;
                overlayForm.BackColor = Color.Black;
                overlayForm.Size = this.Size;
                overlayForm.Location = this.Location;
                overlayForm.ShowInTaskbar = false;
                overlayForm.Show();

                //Mostrar el Dialog 
                hijo.Owner = overlayForm;
                hijo.ShowDialog();

                //Desechar al cerrar el formulario 
                overlayForm.Dispose();
            }
        }

        /// <summary>
        /// Cierra el formulario encimado
        /// </summary>
        public void CloseChildForm(Form hijo)
        {
            lbTitulo.Visible = true;
            Controls.Remove(hijo);
        }

        /// <summary>
        /// Agregar un boton al DataGrid
        /// </summary>
        /// <param name="fieldName">Nombre del campo</param>
        /// <param name="Caption">Descripcion</param>
        /// <param name="predefines">Predefinido</param>
        /// <returns></returns>
        protected RepositoryItemButtonEdit AddItemButton(string fieldName, string Caption, ButtonPredefines predefines, Image btnImage = null)
        {
            GridColumn newgridColumn = gridView1.Columns.AddField(fieldName);
            RepositoryItemButtonEdit newButton = new RepositoryItemButtonEdit();

            newButton.Buttons[0].Kind = predefines;
            newButton.Buttons[0].Caption = Caption;

            if (predefines == ButtonPredefines.Glyph)
            {
                newButton.Buttons[0].Image = btnImage;
            }
            newButton.TextEditStyle = TextEditStyles.HideTextEditor;

            gridControl1.RepositoryItems.Add(newButton);
            newgridColumn.ColumnEdit = newButton;
            newgridColumn.VisibleIndex = 10;
            newgridColumn.Visible = true;

            return newButton;
        }

        #endregion

        #region Eventos
        
        protected void Edition_Collection_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = string.Format(lbTitulo.Text, Text);
            lbSubtitulo.Text = string.Format(lbSubtitulo.Text, Text);
            lbTitulo.Text = lbTitulo.Text.Replace("Administrar ", "");
            lbSubtitulo.Text = lbSubtitulo.Text.Replace("Administrar ", "");

            gridView1.OptionsBehavior.ReadOnly = true;

            if(!(modelo is null))
            {
                gridControl1.DataSource = modelo.LeerTabla();
                if (!modelo.Exito)
                {
                    MessageBox.Show(modelo.Mensaje);
                }
            }
        }

        private void GridView1_RowCountChanged(object sender, EventArgs e)
        {
            barHeaderItem1.Caption = string.Format(barHeaderItem1.Caption, gridView1.RowCount);
        }

        private void GridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            SelectedId = (int)(gridView1.GetFocusedRowCellValue(IdColumnName) ?? 0);
        }
        
        #endregion
    }
}