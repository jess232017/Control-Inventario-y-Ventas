
namespace Presentación.Forms.Secundario.Empleado
{
    partial class FrmEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnAgregar = new Guna.UI2.WinForms.Guna2Button();
            this.BtnEditar = new Guna.UI2.WinForms.Guna2Button();
            this.BtnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.BtnRefrescar = new Guna.UI2.WinForms.Guna2Button();
            this.BtnImprimir = new Guna.UI2.WinForms.Guna2Button();
            this.colIdEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTienda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdRol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApellidos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFoto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCorreo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.div2.SuspendLayout();
            this.div3.SuspendLayout();
            this.div1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackButtons)).BeginInit();
            this.stackButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.div4.SuspendLayout();
            this.SuspendLayout();
            // 
            // div2
            // 
            this.div2.Size = new System.Drawing.Size(1008, 517);
            // 
            // div3
            // 
            this.div3.Size = new System.Drawing.Size(1006, 491);
            // 
            // div1
            // 
            this.div1.Size = new System.Drawing.Size(1028, 537);
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "SP_EmpleadoSeleccionar";
            this.gridControl1.Size = new System.Drawing.Size(986, 380);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpleado,
            this.colIdTienda,
            this.colIdRol,
            this.colNombres,
            this.colApellidos,
            this.colUsuario,
            this.colClave,
            this.colFoto,
            this.colCorreo,
            this.colEstado});
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // stackButtons
            // 
            this.stackButtons.Controls.Add(this.BtnAgregar);
            this.stackButtons.Controls.Add(this.BtnEditar);
            this.stackButtons.Controls.Add(this.BtnEliminar);
            this.stackButtons.Controls.Add(this.BtnRefrescar);
            this.stackButtons.Controls.Add(this.BtnImprimir);
            // 
            // bar3
            // 
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            // 
            // div4
            // 
            this.div4.Size = new System.Drawing.Size(986, 380);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Animated = true;
            this.BtnAgregar.CheckedState.Parent = this.BtnAgregar;
            this.BtnAgregar.CustomImages.Parent = this.BtnAgregar;
            this.BtnAgregar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.BtnAgregar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.HoverState.BorderColor = System.Drawing.Color.Black;
            this.BtnAgregar.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.HoverState.Parent = this.BtnAgregar;
            this.BtnAgregar.Image = global::Presentación.Properties.Resources.icons8_plus_math_48;
            this.BtnAgregar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnAgregar.ImageSize = new System.Drawing.Size(18, 18);
            this.BtnAgregar.Location = new System.Drawing.Point(0, 10);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.ShadowDecoration.Parent = this.BtnAgregar;
            this.BtnAgregar.Size = new System.Drawing.Size(90, 27);
            this.BtnAgregar.TabIndex = 117;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Animated = true;
            this.BtnEditar.CheckedState.Parent = this.BtnEditar;
            this.BtnEditar.CustomImages.Parent = this.BtnEditar;
            this.BtnEditar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.BtnEditar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnEditar.ForeColor = System.Drawing.Color.White;
            this.BtnEditar.HoverState.BorderColor = System.Drawing.Color.Black;
            this.BtnEditar.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnEditar.HoverState.Parent = this.BtnEditar;
            this.BtnEditar.Image = global::Presentación.Properties.Resources.icons8_edit_file_32;
            this.BtnEditar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnEditar.ImageSize = new System.Drawing.Size(18, 18);
            this.BtnEditar.Location = new System.Drawing.Point(95, 10);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.ShadowDecoration.Parent = this.BtnEditar;
            this.BtnEditar.Size = new System.Drawing.Size(90, 27);
            this.BtnEditar.TabIndex = 119;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Animated = true;
            this.BtnEliminar.CheckedState.Parent = this.BtnEliminar;
            this.BtnEliminar.CustomImages.Parent = this.BtnEliminar;
            this.BtnEliminar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.BtnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.HoverState.BorderColor = System.Drawing.Color.Black;
            this.BtnEliminar.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.HoverState.Parent = this.BtnEliminar;
            this.BtnEliminar.Image = global::Presentación.Properties.Resources.icons8_delete_file_32__1_;
            this.BtnEliminar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnEliminar.ImageSize = new System.Drawing.Size(18, 18);
            this.BtnEliminar.Location = new System.Drawing.Point(190, 10);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.ShadowDecoration.Parent = this.BtnEliminar;
            this.BtnEliminar.Size = new System.Drawing.Size(90, 27);
            this.BtnEliminar.TabIndex = 120;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnRefrescar
            // 
            this.BtnRefrescar.Animated = true;
            this.BtnRefrescar.CheckedState.Parent = this.BtnRefrescar;
            this.BtnRefrescar.CustomImages.Parent = this.BtnRefrescar;
            this.BtnRefrescar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.BtnRefrescar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnRefrescar.ForeColor = System.Drawing.Color.White;
            this.BtnRefrescar.HoverState.BorderColor = System.Drawing.Color.Black;
            this.BtnRefrescar.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnRefrescar.HoverState.Parent = this.BtnRefrescar;
            this.BtnRefrescar.Image = global::Presentación.Properties.Resources.icons8_refresh_32;
            this.BtnRefrescar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnRefrescar.ImageSize = new System.Drawing.Size(18, 18);
            this.BtnRefrescar.Location = new System.Drawing.Point(285, 10);
            this.BtnRefrescar.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.BtnRefrescar.Name = "BtnRefrescar";
            this.BtnRefrescar.ShadowDecoration.Parent = this.BtnRefrescar;
            this.BtnRefrescar.Size = new System.Drawing.Size(90, 27);
            this.BtnRefrescar.TabIndex = 121;
            this.BtnRefrescar.Text = "Refrescar";
            this.BtnRefrescar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Animated = true;
            this.BtnImprimir.CheckedState.Parent = this.BtnImprimir;
            this.BtnImprimir.CustomImages.Parent = this.BtnImprimir;
            this.BtnImprimir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(206)))));
            this.BtnImprimir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnImprimir.ForeColor = System.Drawing.Color.White;
            this.BtnImprimir.HoverState.BorderColor = System.Drawing.Color.Black;
            this.BtnImprimir.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnImprimir.HoverState.Parent = this.BtnImprimir;
            this.BtnImprimir.Image = global::Presentación.Properties.Resources.icons8_print_20;
            this.BtnImprimir.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnImprimir.Location = new System.Drawing.Point(380, 10);
            this.BtnImprimir.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.ShadowDecoration.Parent = this.BtnImprimir;
            this.BtnImprimir.Size = new System.Drawing.Size(39, 27);
            this.BtnImprimir.TabIndex = 118;
            this.BtnImprimir.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // colIdEmpleado
            // 
            this.colIdEmpleado.FieldName = "IdEmpleado";
            this.colIdEmpleado.Name = "colIdEmpleado";
            this.colIdEmpleado.Visible = true;
            this.colIdEmpleado.VisibleIndex = 0;
            // 
            // colIdTienda
            // 
            this.colIdTienda.FieldName = "IdTienda";
            this.colIdTienda.Name = "colIdTienda";
            this.colIdTienda.Visible = true;
            this.colIdTienda.VisibleIndex = 1;
            // 
            // colIdRol
            // 
            this.colIdRol.FieldName = "IdRol";
            this.colIdRol.Name = "colIdRol";
            this.colIdRol.Visible = true;
            this.colIdRol.VisibleIndex = 2;
            // 
            // colNombres
            // 
            this.colNombres.FieldName = "Nombres";
            this.colNombres.Name = "colNombres";
            this.colNombres.Visible = true;
            this.colNombres.VisibleIndex = 3;
            // 
            // colApellidos
            // 
            this.colApellidos.FieldName = "Apellidos";
            this.colApellidos.Name = "colApellidos";
            this.colApellidos.Visible = true;
            this.colApellidos.VisibleIndex = 4;
            // 
            // colUsuario
            // 
            this.colUsuario.FieldName = "Usuario";
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.Visible = true;
            this.colUsuario.VisibleIndex = 5;
            // 
            // colClave
            // 
            this.colClave.FieldName = "Clave";
            this.colClave.Name = "colClave";
            this.colClave.Visible = true;
            this.colClave.VisibleIndex = 6;
            // 
            // colFoto
            // 
            this.colFoto.FieldName = "Foto";
            this.colFoto.Name = "colFoto";
            this.colFoto.Visible = true;
            this.colFoto.VisibleIndex = 7;
            // 
            // colCorreo
            // 
            this.colCorreo.FieldName = "Correo";
            this.colCorreo.Name = "colCorreo";
            this.colCorreo.Visible = true;
            this.colCorreo.VisibleIndex = 8;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 9;
            // 
            // FrmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 602);
            this.Name = "FrmEmpleados";
            this.Text = "FrmEmpleados";
            this.div2.ResumeLayout(false);
            this.div3.ResumeLayout(false);
            this.div1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackButtons)).EndInit();
            this.stackButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.div4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected Guna.UI2.WinForms.Guna2Button BtnAgregar;
        protected Guna.UI2.WinForms.Guna2Button BtnEditar;
        protected Guna.UI2.WinForms.Guna2Button BtnEliminar;
        protected Guna.UI2.WinForms.Guna2Button BtnRefrescar;
        protected Guna.UI2.WinForms.Guna2Button BtnImprimir;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTienda;
        private DevExpress.XtraGrid.Columns.GridColumn colIdRol;
        private DevExpress.XtraGrid.Columns.GridColumn colNombres;
        private DevExpress.XtraGrid.Columns.GridColumn colApellidos;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colClave;
        private DevExpress.XtraGrid.Columns.GridColumn colFoto;
        private DevExpress.XtraGrid.Columns.GridColumn colCorreo;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
    }
}