namespace Vistas.Formularios.Servicios
{
    partial class frmModificarServicios
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblRegistroServicio = new LabelTransparente();
            this.lblHoraActual = new System.Windows.Forms.Label();
            this.tmrHoraActual = new System.Windows.Forms.Timer(this.components);
            this.btnMenu = new Vistas.Formularios.Componentes_Improvisados.IPESBotonRedondeado();
            this.btnModificar = new Vistas.Formularios.Componentes_Improvisados.IPESBotonRedondeado();
            this.pnlElemento = new System.Windows.Forms.Panel();
            this.pbFotoUsuario = new CustomControls.RJControls.PictureBoxRedondo();
            this.lblNombreSistemaUsuario = new LabelTransparente();
            this.lblTiempo = new LabelTransparente();
            this.dgvServicios = new System.Windows.Forms.DataGridView();
            this.lblExistencia = new LabelTransparente();
            this.btnBusqueda = new Vistas.Formularios.Componentes_Improvisados.IPESBotonRedondeado();
            this.lblLimpiarDGV = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.txtServicio = new System.Windows.Forms.TextBox();
            this.lblNombre = new LabelTransparente();
            this.lblRegistro = new LabelTransparente();
            this.btnEliminar = new Vistas.Formularios.Componentes_Improvisados.IPESBotonRedondeado();
            this.labelTransparente1 = new LabelTransparente();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.pnlElemento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 16.25F, System.Drawing.FontStyle.Bold);
            this.txtDescripcion.Location = new System.Drawing.Point(169, 243);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDescripcion.ShortcutsEnabled = false;
            this.txtDescripcion.Size = new System.Drawing.Size(677, 97);
            this.txtDescripcion.TabIndex = 245;
            // 
            // lblRegistroServicio
            // 
            this.lblRegistroServicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegistroServicio.AutoSize = true;
            this.lblRegistroServicio.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistroServicio.Font = new System.Drawing.Font("Segoe UI", 16.25F, System.Drawing.FontStyle.Bold);
            this.lblRegistroServicio.ForeColor = System.Drawing.Color.White;
            this.lblRegistroServicio.Location = new System.Drawing.Point(164, 190);
            this.lblRegistroServicio.Name = "lblRegistroServicio";
            this.lblRegistroServicio.Size = new System.Drawing.Size(266, 30);
            this.lblRegistroServicio.TabIndex = 244;
            this.lblRegistroServicio.Text = "Descripción del Servicio ";
            // 
            // lblHoraActual
            // 
            this.lblHoraActual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHoraActual.AutoSize = true;
            this.lblHoraActual.BackColor = System.Drawing.Color.Transparent;
            this.lblHoraActual.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblHoraActual.ForeColor = System.Drawing.Color.White;
            this.lblHoraActual.Location = new System.Drawing.Point(1018, 691);
            this.lblHoraActual.Name = "lblHoraActual";
            this.lblHoraActual.Size = new System.Drawing.Size(138, 37);
            this.lblHoraActual.TabIndex = 243;
            this.lblHoraActual.Text = "10:25 PM";
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenu.BorderColor = System.Drawing.Color.White;
            this.btnMenu.BorderRadius = 15;
            this.btnMenu.BorderSize = 2;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(860, 282);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(210, 58);
            this.btnMenu.TabIndex = 246;
            this.btnMenu.Text = "Regresar a Menú";
            this.btnMenu.TextColor = System.Drawing.Color.White;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModificar.BackColor = System.Drawing.Color.Black;
            this.btnModificar.BackgroundColor = System.Drawing.Color.Black;
            this.btnModificar.BorderColor = System.Drawing.Color.White;
            this.btnModificar.BorderRadius = 15;
            this.btnModificar.BorderSize = 4;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 13.75F, System.Drawing.FontStyle.Bold);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(860, 133);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(208, 63);
            this.btnModificar.TabIndex = 242;
            this.btnModificar.Text = "Modificar Servicio";
            this.btnModificar.TextColor = System.Drawing.Color.White;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // pnlElemento
            // 
            this.pnlElemento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlElemento.BackColor = System.Drawing.Color.Transparent;
            this.pnlElemento.Controls.Add(this.pbFotoUsuario);
            this.pnlElemento.Controls.Add(this.lblNombreSistemaUsuario);
            this.pnlElemento.Controls.Add(this.lblTiempo);
            this.pnlElemento.Location = new System.Drawing.Point(12, 643);
            this.pnlElemento.Name = "pnlElemento";
            this.pnlElemento.Size = new System.Drawing.Size(664, 152);
            this.pnlElemento.TabIndex = 241;
            // 
            // pbFotoUsuario
            // 
            this.pbFotoUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbFotoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.pbFotoUsuario.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pbFotoUsuario.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pbFotoUsuario.BorderColor2 = System.Drawing.Color.HotPink;
            this.pbFotoUsuario.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pbFotoUsuario.BorderSize = 4;
            this.pbFotoUsuario.GradientAngle = 50F;
            this.pbFotoUsuario.Location = new System.Drawing.Point(37, 18);
            this.pbFotoUsuario.Name = "pbFotoUsuario";
            this.pbFotoUsuario.Size = new System.Drawing.Size(122, 122);
            this.pbFotoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFotoUsuario.TabIndex = 58;
            this.pbFotoUsuario.TabStop = false;
            // 
            // lblNombreSistemaUsuario
            // 
            this.lblNombreSistemaUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombreSistemaUsuario.AutoSize = true;
            this.lblNombreSistemaUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreSistemaUsuario.Font = new System.Drawing.Font("Segoe UI", 20.75F, System.Drawing.FontStyle.Bold);
            this.lblNombreSistemaUsuario.ForeColor = System.Drawing.Color.White;
            this.lblNombreSistemaUsuario.Location = new System.Drawing.Point(187, 92);
            this.lblNombreSistemaUsuario.Name = "lblNombreSistemaUsuario";
            this.lblNombreSistemaUsuario.Size = new System.Drawing.Size(364, 38);
            this.lblNombreSistemaUsuario.TabIndex = 60;
            this.lblNombreSistemaUsuario.Text = "{Nombre Sistema Usuario}";
            // 
            // lblTiempo
            // 
            this.lblTiempo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.BackColor = System.Drawing.Color.Transparent;
            this.lblTiempo.Font = new System.Drawing.Font("Segoe UI", 20.75F, System.Drawing.FontStyle.Bold);
            this.lblTiempo.ForeColor = System.Drawing.Color.White;
            this.lblTiempo.Location = new System.Drawing.Point(187, 29);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(258, 38);
            this.lblTiempo.TabIndex = 59;
            this.lblTiempo.Text = "¡Buenos {Tiempo}!";
            // 
            // dgvServicios
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvServicios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvServicios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvServicios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvServicios.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvServicios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvServicios.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvServicios.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvServicios.Location = new System.Drawing.Point(172, 437);
            this.dgvServicios.Name = "dgvServicios";
            this.dgvServicios.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvServicios.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvServicios.Size = new System.Drawing.Size(898, 132);
            this.dgvServicios.TabIndex = 239;
            this.dgvServicios.DoubleClick += new System.EventHandler(this.dgvServicios_DoubleClick);
            // 
            // lblExistencia
            // 
            this.lblExistencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblExistencia.AutoSize = true;
            this.lblExistencia.BackColor = System.Drawing.Color.Transparent;
            this.lblExistencia.Font = new System.Drawing.Font("Segoe UI", 24.25F, System.Drawing.FontStyle.Bold);
            this.lblExistencia.ForeColor = System.Drawing.Color.White;
            this.lblExistencia.Location = new System.Drawing.Point(164, 361);
            this.lblExistencia.Name = "lblExistencia";
            this.lblExistencia.Size = new System.Drawing.Size(324, 45);
            this.lblExistencia.TabIndex = 240;
            this.lblExistencia.Text = "Servicios Existentes";
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBusqueda.BackColor = System.Drawing.Color.Black;
            this.btnBusqueda.BackgroundColor = System.Drawing.Color.Black;
            this.btnBusqueda.BorderColor = System.Drawing.Color.White;
            this.btnBusqueda.BorderRadius = 15;
            this.btnBusqueda.BorderSize = 4;
            this.btnBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBusqueda.FlatAppearance.BorderSize = 0;
            this.btnBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusqueda.Font = new System.Drawing.Font("Segoe UI", 13.75F, System.Drawing.FontStyle.Bold);
            this.btnBusqueda.ForeColor = System.Drawing.Color.White;
            this.btnBusqueda.Location = new System.Drawing.Point(934, 350);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(134, 54);
            this.btnBusqueda.TabIndex = 238;
            this.btnBusqueda.Text = "Buscar";
            this.btnBusqueda.TextColor = System.Drawing.Color.White;
            this.btnBusqueda.UseVisualStyleBackColor = false;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // lblLimpiarDGV
            // 
            this.lblLimpiarDGV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLimpiarDGV.AutoSize = true;
            this.lblLimpiarDGV.BackColor = System.Drawing.Color.White;
            this.lblLimpiarDGV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLimpiarDGV.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimpiarDGV.ForeColor = System.Drawing.Color.Black;
            this.lblLimpiarDGV.Location = new System.Drawing.Point(855, 361);
            this.lblLimpiarDGV.Name = "lblLimpiarDGV";
            this.lblLimpiarDGV.Size = new System.Drawing.Size(27, 30);
            this.lblLimpiarDGV.TabIndex = 237;
            this.lblLimpiarDGV.Text = "X";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBusqueda.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(616, 361);
            this.txtBusqueda.Multiline = true;
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.ShortcutsEnabled = false;
            this.txtBusqueda.Size = new System.Drawing.Size(233, 46);
            this.txtBusqueda.TabIndex = 236;
            // 
            // txtServicio
            // 
            this.txtServicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtServicio.Font = new System.Drawing.Font("Segoe UI", 16.25F, System.Drawing.FontStyle.Bold);
            this.txtServicio.Location = new System.Drawing.Point(172, 151);
            this.txtServicio.Name = "txtServicio";
            this.txtServicio.ShortcutsEnabled = false;
            this.txtServicio.Size = new System.Drawing.Size(677, 36);
            this.txtServicio.TabIndex = 235;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 16.25F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(164, 118);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(224, 30);
            this.lblNombre.TabIndex = 234;
            this.lblNombre.Text = "Nombre del Servicio";
            // 
            // lblRegistro
            // 
            this.lblRegistro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistro.Font = new System.Drawing.Font("Segoe UI", 30.75F, System.Drawing.FontStyle.Bold);
            this.lblRegistro.ForeColor = System.Drawing.Color.White;
            this.lblRegistro.Location = new System.Drawing.Point(385, -125);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(552, 55);
            this.lblRegistro.TabIndex = 233;
            this.lblRegistro.Text = "Registra Los Servicios Aqui ";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.BackColor = System.Drawing.Color.Black;
            this.btnEliminar.BackgroundColor = System.Drawing.Color.Black;
            this.btnEliminar.BorderColor = System.Drawing.Color.White;
            this.btnEliminar.BorderRadius = 15;
            this.btnEliminar.BorderSize = 4;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 13.75F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(860, 213);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(208, 63);
            this.btnEliminar.TabIndex = 247;
            this.btnEliminar.Text = "Eliminar Servicio";
            this.btnEliminar.TextColor = System.Drawing.Color.White;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // labelTransparente1
            // 
            this.labelTransparente1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTransparente1.AutoSize = true;
            this.labelTransparente1.BackColor = System.Drawing.Color.Transparent;
            this.labelTransparente1.Font = new System.Drawing.Font("Segoe UI", 30.75F, System.Drawing.FontStyle.Bold);
            this.labelTransparente1.ForeColor = System.Drawing.Color.White;
            this.labelTransparente1.Location = new System.Drawing.Point(339, 23);
            this.labelTransparente1.Name = "labelTransparente1";
            this.labelTransparente1.Size = new System.Drawing.Size(566, 55);
            this.labelTransparente1.TabIndex = 248;
            this.labelTransparente1.Text = "Modifica Los Servicios Aqui ";
            // 
            // frmModificarServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Vistas.Properties.Resources.e;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1230, 807);
            this.Controls.Add(this.labelTransparente1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblRegistroServicio);
            this.Controls.Add(this.lblHoraActual);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.pnlElemento);
            this.Controls.Add(this.dgvServicios);
            this.Controls.Add(this.lblExistencia);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.lblLimpiarDGV);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.txtServicio);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblRegistro);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmModificarServicios";
            this.Text = "frmModificarServicios";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.pnlElemento.ResumeLayout(false);
            this.pnlElemento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox txtDescripcion;
        private LabelTransparente lblRegistroServicio;
        private System.Windows.Forms.Label lblHoraActual;
        private Componentes_Improvisados.IPESBotonRedondeado btnMenu;
        private Componentes_Improvisados.IPESBotonRedondeado btnModificar;
        private System.Windows.Forms.Panel pnlElemento;
        private CustomControls.RJControls.PictureBoxRedondo pbFotoUsuario;
        private LabelTransparente lblNombreSistemaUsuario;
        private LabelTransparente lblTiempo;
        private System.Windows.Forms.DataGridView dgvServicios;
        private LabelTransparente lblExistencia;
        private Componentes_Improvisados.IPESBotonRedondeado btnBusqueda;
        private System.Windows.Forms.Label lblLimpiarDGV;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.TextBox txtServicio;
        private LabelTransparente lblNombre;
        private LabelTransparente lblRegistro;
        private System.Windows.Forms.Timer tmrHoraActual;
        private Componentes_Improvisados.IPESBotonRedondeado btnEliminar;
        private LabelTransparente labelTransparente1;
    }
}