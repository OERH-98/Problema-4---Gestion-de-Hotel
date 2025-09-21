namespace Vistas.Formularios.Reservas
{
    partial class frmModificarReserva
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.cbServicio = new System.Windows.Forms.ComboBox();
            this.cbHabitacion = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLimpiarDGV2 = new System.Windows.Forms.Label();
            this.txtBusquedaReserva = new System.Windows.Forms.TextBox();
            this.dgvReserva = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new Vistas.Formularios.Componentes_Improvisados.IPESBotonRedondeado();
            this.btnBuscarReserva = new Vistas.Formularios.Componentes_Improvisados.IPESBotonRedondeado();
            this.lblReserva = new LabelTransparente();
            this.btnMenu = new Vistas.Formularios.Componentes_Improvisados.IPESBotonRedondeado();
            this.btnModificarReserva = new Vistas.Formularios.Componentes_Improvisados.IPESBotonRedondeado();
            this.lblFechaRef = new LabelTransparente();
            this.lblServicio = new LabelTransparente();
            this.lblHabitacionNo = new LabelTransparente();
            this.lblRegistracion = new LabelTransparente();
            this.lblRegistro = new LabelTransparente();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp2
            // 
            this.dtp2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp2.Cursor = System.Windows.Forms.Cursors.No;
            this.dtp2.Enabled = false;
            this.dtp2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.dtp2.Location = new System.Drawing.Point(77, 448);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(361, 33);
            this.dtp2.TabIndex = 281;
            // 
            // cbServicio
            // 
            this.cbServicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbServicio.BackColor = System.Drawing.Color.White;
            this.cbServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbServicio.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbServicio.FormattingEnabled = true;
            this.cbServicio.Location = new System.Drawing.Point(77, 347);
            this.cbServicio.Name = "cbServicio";
            this.cbServicio.Size = new System.Drawing.Size(361, 33);
            this.cbServicio.TabIndex = 278;
            // 
            // cbHabitacion
            // 
            this.cbHabitacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbHabitacion.BackColor = System.Drawing.Color.White;
            this.cbHabitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHabitacion.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHabitacion.FormattingEnabled = true;
            this.cbHabitacion.Location = new System.Drawing.Point(77, 263);
            this.cbHabitacion.Name = "cbHabitacion";
            this.cbHabitacion.Size = new System.Drawing.Size(361, 33);
            this.cbHabitacion.TabIndex = 276;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Vistas.Properties.Resources.caga_registro_v2;
            this.pictureBox1.Location = new System.Drawing.Point(58, 162);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(398, 357);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 274;
            this.pictureBox1.TabStop = false;
            // 
            // lblLimpiarDGV2
            // 
            this.lblLimpiarDGV2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLimpiarDGV2.AutoSize = true;
            this.lblLimpiarDGV2.BackColor = System.Drawing.Color.White;
            this.lblLimpiarDGV2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLimpiarDGV2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimpiarDGV2.ForeColor = System.Drawing.Color.Black;
            this.lblLimpiarDGV2.Location = new System.Drawing.Point(1093, 188);
            this.lblLimpiarDGV2.Name = "lblLimpiarDGV2";
            this.lblLimpiarDGV2.Size = new System.Drawing.Size(27, 30);
            this.lblLimpiarDGV2.TabIndex = 295;
            this.lblLimpiarDGV2.Text = "X";
            this.lblLimpiarDGV2.Click += new System.EventHandler(this.lblLimpiarDGV2_Click);
            // 
            // txtBusquedaReserva
            // 
            this.txtBusquedaReserva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBusquedaReserva.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBusquedaReserva.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaReserva.Location = new System.Drawing.Point(854, 179);
            this.txtBusquedaReserva.Multiline = true;
            this.txtBusquedaReserva.Name = "txtBusquedaReserva";
            this.txtBusquedaReserva.ShortcutsEnabled = false;
            this.txtBusquedaReserva.Size = new System.Drawing.Size(233, 46);
            this.txtBusquedaReserva.TabIndex = 294;
            // 
            // dgvReserva
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvReserva.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReserva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvReserva.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvReserva.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReserva.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReserva.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReserva.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReserva.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvReserva.Location = new System.Drawing.Point(854, 270);
            this.dgvReserva.Name = "dgvReserva";
            this.dgvReserva.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReserva.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReserva.Size = new System.Drawing.Size(376, 289);
            this.dgvReserva.TabIndex = 292;
            this.dgvReserva.DoubleClick += new System.EventHandler(this.dgvReserva_DoubleClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.BackColor = System.Drawing.Color.Black;
            this.btnEliminar.BackgroundColor = System.Drawing.Color.Black;
            this.btnEliminar.BorderColor = System.Drawing.Color.White;
            this.btnEliminar.BorderRadius = 20;
            this.btnEliminar.BorderSize = 4;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(527, 312);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(212, 68);
            this.btnEliminar.TabIndex = 297;
            this.btnEliminar.Text = "Eliminar Reserva";
            this.btnEliminar.TextColor = System.Drawing.Color.White;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscarReserva
            // 
            this.btnBuscarReserva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarReserva.BackColor = System.Drawing.Color.Black;
            this.btnBuscarReserva.BackgroundColor = System.Drawing.Color.Black;
            this.btnBuscarReserva.BorderColor = System.Drawing.Color.White;
            this.btnBuscarReserva.BorderRadius = 15;
            this.btnBuscarReserva.BorderSize = 4;
            this.btnBuscarReserva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarReserva.FlatAppearance.BorderSize = 0;
            this.btnBuscarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarReserva.Font = new System.Drawing.Font("Segoe UI", 13.75F, System.Drawing.FontStyle.Bold);
            this.btnBuscarReserva.ForeColor = System.Drawing.Color.White;
            this.btnBuscarReserva.Location = new System.Drawing.Point(1143, 171);
            this.btnBuscarReserva.Name = "btnBuscarReserva";
            this.btnBuscarReserva.Size = new System.Drawing.Size(99, 54);
            this.btnBuscarReserva.TabIndex = 296;
            this.btnBuscarReserva.Text = "Buscar";
            this.btnBuscarReserva.TextColor = System.Drawing.Color.White;
            this.btnBuscarReserva.UseVisualStyleBackColor = false;
            this.btnBuscarReserva.Click += new System.EventHandler(this.btnBuscarReserva_Click);
            // 
            // lblReserva
            // 
            this.lblReserva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReserva.AutoSize = true;
            this.lblReserva.BackColor = System.Drawing.Color.Transparent;
            this.lblReserva.Font = new System.Drawing.Font("Segoe UI", 17.75F, System.Drawing.FontStyle.Bold);
            this.lblReserva.ForeColor = System.Drawing.Color.White;
            this.lblReserva.Location = new System.Drawing.Point(859, 114);
            this.lblReserva.Name = "lblReserva";
            this.lblReserva.Size = new System.Drawing.Size(371, 32);
            this.lblReserva.TabIndex = 293;
            this.lblReserva.Text = "Selecciona tu Reserva Existente";
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMenu.BackColor = System.Drawing.Color.Black;
            this.btnMenu.BackgroundColor = System.Drawing.Color.Black;
            this.btnMenu.BorderColor = System.Drawing.Color.White;
            this.btnMenu.BorderRadius = 20;
            this.btnMenu.BorderSize = 4;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(512, 416);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(255, 68);
            this.btnMenu.TabIndex = 288;
            this.btnMenu.Text = "Regresar al Menú de Opciones";
            this.btnMenu.TextColor = System.Drawing.Color.White;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnModificarReserva
            // 
            this.btnModificarReserva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModificarReserva.BackColor = System.Drawing.Color.Black;
            this.btnModificarReserva.BackgroundColor = System.Drawing.Color.Black;
            this.btnModificarReserva.BorderColor = System.Drawing.Color.White;
            this.btnModificarReserva.BorderRadius = 20;
            this.btnModificarReserva.BorderSize = 4;
            this.btnModificarReserva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarReserva.FlatAppearance.BorderSize = 0;
            this.btnModificarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarReserva.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnModificarReserva.ForeColor = System.Drawing.Color.White;
            this.btnModificarReserva.Location = new System.Drawing.Point(527, 188);
            this.btnModificarReserva.Name = "btnModificarReserva";
            this.btnModificarReserva.Size = new System.Drawing.Size(212, 68);
            this.btnModificarReserva.TabIndex = 287;
            this.btnModificarReserva.Text = "Modificar Reserva";
            this.btnModificarReserva.TextColor = System.Drawing.Color.White;
            this.btnModificarReserva.UseVisualStyleBackColor = false;
            this.btnModificarReserva.Click += new System.EventHandler(this.btnModificarReserva_Click);
            // 
            // lblFechaRef
            // 
            this.lblFechaRef.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFechaRef.AutoSize = true;
            this.lblFechaRef.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaRef.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblFechaRef.ForeColor = System.Drawing.Color.White;
            this.lblFechaRef.Location = new System.Drawing.Point(72, 405);
            this.lblFechaRef.Name = "lblFechaRef";
            this.lblFechaRef.Size = new System.Drawing.Size(136, 25);
            this.lblFechaRef.TabIndex = 280;
            this.lblFechaRef.Text = "Fecha Reserva";
            // 
            // lblServicio
            // 
            this.lblServicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblServicio.AutoSize = true;
            this.lblServicio.BackColor = System.Drawing.Color.Transparent;
            this.lblServicio.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblServicio.ForeColor = System.Drawing.Color.White;
            this.lblServicio.Location = new System.Drawing.Point(72, 310);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(172, 25);
            this.lblServicio.TabIndex = 279;
            this.lblServicio.Text = "Servicio a Agarrar";
            // 
            // lblHabitacionNo
            // 
            this.lblHabitacionNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHabitacionNo.AutoSize = true;
            this.lblHabitacionNo.BackColor = System.Drawing.Color.Transparent;
            this.lblHabitacionNo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblHabitacionNo.ForeColor = System.Drawing.Color.White;
            this.lblHabitacionNo.Location = new System.Drawing.Point(72, 231);
            this.lblHabitacionNo.Name = "lblHabitacionNo";
            this.lblHabitacionNo.Size = new System.Drawing.Size(220, 25);
            this.lblHabitacionNo.TabIndex = 277;
            this.lblHabitacionNo.Text = "Número de Habitación ";
            // 
            // lblRegistracion
            // 
            this.lblRegistracion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegistracion.AutoSize = true;
            this.lblRegistracion.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistracion.Font = new System.Drawing.Font("Segoe UI", 20.75F, System.Drawing.FontStyle.Bold);
            this.lblRegistracion.ForeColor = System.Drawing.Color.White;
            this.lblRegistracion.Location = new System.Drawing.Point(130, 174);
            this.lblRegistracion.Name = "lblRegistracion";
            this.lblRegistracion.Size = new System.Drawing.Size(261, 38);
            this.lblRegistracion.TabIndex = 275;
            this.lblRegistracion.Text = "Modificar Reserva ";
            // 
            // lblRegistro
            // 
            this.lblRegistro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistro.Font = new System.Drawing.Font("Segoe UI", 20.75F, System.Drawing.FontStyle.Bold);
            this.lblRegistro.ForeColor = System.Drawing.Color.White;
            this.lblRegistro.Location = new System.Drawing.Point(468, 9);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(331, 38);
            this.lblRegistro.TabIndex = 254;
            this.lblRegistro.Text = "Realiza tu Reserva Aquí ";
            // 
            // frmModificarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1254, 738);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscarReserva);
            this.Controls.Add(this.lblLimpiarDGV2);
            this.Controls.Add(this.txtBusquedaReserva);
            this.Controls.Add(this.lblReserva);
            this.Controls.Add(this.dgvReserva);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnModificarReserva);
            this.Controls.Add(this.dtp2);
            this.Controls.Add(this.lblFechaRef);
            this.Controls.Add(this.lblServicio);
            this.Controls.Add(this.cbServicio);
            this.Controls.Add(this.lblHabitacionNo);
            this.Controls.Add(this.cbHabitacion);
            this.Controls.Add(this.lblRegistracion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblRegistro);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmModificarReserva";
            this.Text = "frmModificarReserva";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Componentes_Improvisados.IPESBotonRedondeado btnMenu;
        private Componentes_Improvisados.IPESBotonRedondeado btnModificarReserva;
        private System.Windows.Forms.DateTimePicker dtp2;
        private LabelTransparente lblFechaRef;
        private LabelTransparente lblServicio;
        private System.Windows.Forms.ComboBox cbServicio;
        private LabelTransparente lblHabitacionNo;
        private System.Windows.Forms.ComboBox cbHabitacion;
        private LabelTransparente lblRegistracion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private LabelTransparente lblRegistro;
        private Componentes_Improvisados.IPESBotonRedondeado btnBuscarReserva;
        private System.Windows.Forms.Label lblLimpiarDGV2;
        private System.Windows.Forms.TextBox txtBusquedaReserva;
        private LabelTransparente lblReserva;
        private System.Windows.Forms.DataGridView dgvReserva;
        private Componentes_Improvisados.IPESBotonRedondeado btnEliminar;
    }
}