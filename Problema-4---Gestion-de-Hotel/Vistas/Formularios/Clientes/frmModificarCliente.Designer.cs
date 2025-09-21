namespace Vistas.Formularios.Clientes
{
    partial class frmModificarCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.msktxtDui = new System.Windows.Forms.MaskedTextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.msktxtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.rbtnHombre = new System.Windows.Forms.RadioButton();
            this.rbtnMujer = new System.Windows.Forms.RadioButton();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.lblLimpiarDGV = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnEliminar = new Vistas.Formularios.Componentes_Improvisados.IPESBotonRedondeado();
            this.btnBusqueda = new Vistas.Formularios.Componentes_Improvisados.IPESBotonRedondeado();
            this.btnMenu = new Vistas.Formularios.Componentes_Improvisados.IPESBotonRedondeado();
            this.btnModificar = new Vistas.Formularios.Componentes_Improvisados.IPESBotonRedondeado();
            this.lblDUI = new LabelTransparente();
            this.lblMujer = new LabelTransparente();
            this.lblHombre = new LabelTransparente();
            this.lblGenero = new LabelTransparente();
            this.lblFechaNacimiento = new LabelTransparente();
            this.lblTelefono = new LabelTransparente();
            this.lblDireccion = new LabelTransparente();
            this.lblApellido = new LabelTransparente();
            this.lblNombre = new LabelTransparente();
            this.lblRegistro = new LabelTransparente();
            this.pbCajaRegistro = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCajaRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // msktxtDui
            // 
            this.msktxtDui.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.msktxtDui.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.msktxtDui.Location = new System.Drawing.Point(98, 560);
            this.msktxtDui.Mask = "0000000-0";
            this.msktxtDui.Name = "msktxtDui";
            this.msktxtDui.ShortcutsEnabled = false;
            this.msktxtDui.Size = new System.Drawing.Size(325, 27);
            this.msktxtDui.TabIndex = 83;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtNombre.Location = new System.Drawing.Point(98, 141);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ShortcutsEnabled = false;
            this.txtNombre.Size = new System.Drawing.Size(325, 27);
            this.txtNombre.TabIndex = 65;
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtApellido.Location = new System.Drawing.Point(98, 218);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ShortcutsEnabled = false;
            this.txtApellido.Size = new System.Drawing.Size(325, 27);
            this.txtApellido.TabIndex = 66;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCiudad.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtCiudad.Location = new System.Drawing.Point(98, 276);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.ShortcutsEnabled = false;
            this.txtCiudad.Size = new System.Drawing.Size(325, 27);
            this.txtCiudad.TabIndex = 67;
            // 
            // msktxtTelefono
            // 
            this.msktxtTelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.msktxtTelefono.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.msktxtTelefono.Location = new System.Drawing.Point(98, 347);
            this.msktxtTelefono.Mask = "0000-0000";
            this.msktxtTelefono.Name = "msktxtTelefono";
            this.msktxtTelefono.ShortcutsEnabled = false;
            this.msktxtTelefono.Size = new System.Drawing.Size(325, 27);
            this.msktxtTelefono.TabIndex = 68;
            // 
            // rbtnHombre
            // 
            this.rbtnHombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtnHombre.AutoSize = true;
            this.rbtnHombre.BackColor = System.Drawing.Color.Transparent;
            this.rbtnHombre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnHombre.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnHombre.ForeColor = System.Drawing.Color.Transparent;
            this.rbtnHombre.Location = new System.Drawing.Point(98, 429);
            this.rbtnHombre.Name = "rbtnHombre";
            this.rbtnHombre.Size = new System.Drawing.Size(14, 13);
            this.rbtnHombre.TabIndex = 69;
            this.rbtnHombre.UseVisualStyleBackColor = false;
            // 
            // rbtnMujer
            // 
            this.rbtnMujer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtnMujer.AutoSize = true;
            this.rbtnMujer.BackColor = System.Drawing.Color.Transparent;
            this.rbtnMujer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnMujer.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMujer.ForeColor = System.Drawing.Color.Transparent;
            this.rbtnMujer.Location = new System.Drawing.Point(293, 435);
            this.rbtnMujer.Name = "rbtnMujer";
            this.rbtnMujer.Size = new System.Drawing.Size(14, 13);
            this.rbtnMujer.TabIndex = 70;
            this.rbtnMujer.UseVisualStyleBackColor = false;
            // 
            // dtp1
            // 
            this.dtp1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.dtp1.Location = new System.Drawing.Point(98, 488);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(322, 27);
            this.dtp1.TabIndex = 71;
            // 
            // dgvClientes
            // 
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            this.dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvClientes.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvClientes.Location = new System.Drawing.Point(485, 429);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvClientes.Size = new System.Drawing.Size(485, 195);
            this.dgvClientes.TabIndex = 244;
            this.dgvClientes.DoubleClick += new System.EventHandler(this.dgvClientes_DoubleClick);
            // 
            // lblLimpiarDGV
            // 
            this.lblLimpiarDGV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLimpiarDGV.AutoSize = true;
            this.lblLimpiarDGV.BackColor = System.Drawing.Color.White;
            this.lblLimpiarDGV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLimpiarDGV.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimpiarDGV.ForeColor = System.Drawing.Color.Black;
            this.lblLimpiarDGV.Location = new System.Drawing.Point(761, 355);
            this.lblLimpiarDGV.Name = "lblLimpiarDGV";
            this.lblLimpiarDGV.Size = new System.Drawing.Size(27, 30);
            this.lblLimpiarDGV.TabIndex = 246;
            this.lblLimpiarDGV.Text = "X";
            this.lblLimpiarDGV.Click += new System.EventHandler(this.lblLimpiarDGV_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBusqueda.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(499, 355);
            this.txtBusqueda.Multiline = true;
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.ShortcutsEnabled = false;
            this.txtBusqueda.Size = new System.Drawing.Size(233, 46);
            this.txtBusqueda.TabIndex = 245;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.BackColor = System.Drawing.Color.Black;
            this.btnEliminar.BackgroundColor = System.Drawing.Color.Black;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEliminar.BorderRadius = 15;
            this.btnEliminar.BorderSize = 2;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(558, 266);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(336, 75);
            this.btnEliminar.TabIndex = 248;
            this.btnEliminar.Text = "Eliminar Cliente";
            this.btnEliminar.TextColor = System.Drawing.Color.White;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.btnBusqueda.Location = new System.Drawing.Point(825, 347);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(134, 54);
            this.btnBusqueda.TabIndex = 247;
            this.btnBusqueda.Text = "Buscar";
            this.btnBusqueda.TextColor = System.Drawing.Color.White;
            this.btnBusqueda.UseVisualStyleBackColor = false;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMenu.BackColor = System.Drawing.Color.Black;
            this.btnMenu.BackgroundColor = System.Drawing.Color.Black;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMenu.BorderRadius = 15;
            this.btnMenu.BorderSize = 2;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(558, 167);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(336, 78);
            this.btnMenu.TabIndex = 85;
            this.btnMenu.Text = "Regresar al Menú";
            this.btnMenu.TextColor = System.Drawing.Color.White;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModificar.BackColor = System.Drawing.Color.Black;
            this.btnModificar.BackgroundColor = System.Drawing.Color.Black;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnModificar.BorderRadius = 15;
            this.btnModificar.BorderSize = 2;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(558, 52);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(336, 75);
            this.btnModificar.TabIndex = 84;
            this.btnModificar.Text = "Modificar Cliente";
            this.btnModificar.TextColor = System.Drawing.Color.White;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblDUI
            // 
            this.lblDUI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDUI.AutoSize = true;
            this.lblDUI.BackColor = System.Drawing.Color.Transparent;
            this.lblDUI.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblDUI.ForeColor = System.Drawing.Color.White;
            this.lblDUI.Location = new System.Drawing.Point(93, 532);
            this.lblDUI.Name = "lblDUI";
            this.lblDUI.Size = new System.Drawing.Size(46, 25);
            this.lblDUI.TabIndex = 82;
            this.lblDUI.Text = "DUI";
            // 
            // lblMujer
            // 
            this.lblMujer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMujer.AutoSize = true;
            this.lblMujer.BackColor = System.Drawing.Color.Transparent;
            this.lblMujer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMujer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblMujer.ForeColor = System.Drawing.Color.White;
            this.lblMujer.Location = new System.Drawing.Point(313, 429);
            this.lblMujer.Name = "lblMujer";
            this.lblMujer.Size = new System.Drawing.Size(65, 25);
            this.lblMujer.TabIndex = 80;
            this.lblMujer.Text = "Mujer";
            this.lblMujer.Click += new System.EventHandler(this.lblMujer_Click);
            // 
            // lblHombre
            // 
            this.lblHombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHombre.AutoSize = true;
            this.lblHombre.BackColor = System.Drawing.Color.Transparent;
            this.lblHombre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHombre.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblHombre.ForeColor = System.Drawing.Color.White;
            this.lblHombre.Location = new System.Drawing.Point(123, 426);
            this.lblHombre.Name = "lblHombre";
            this.lblHombre.Size = new System.Drawing.Size(86, 25);
            this.lblHombre.TabIndex = 79;
            this.lblHombre.Text = "Hombre";
            this.lblHombre.Click += new System.EventHandler(this.lblHombre_Click);
            // 
            // lblGenero
            // 
            this.lblGenero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGenero.AutoSize = true;
            this.lblGenero.BackColor = System.Drawing.Color.Transparent;
            this.lblGenero.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblGenero.ForeColor = System.Drawing.Color.White;
            this.lblGenero.Location = new System.Drawing.Point(93, 384);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(78, 25);
            this.lblGenero.TabIndex = 78;
            this.lblGenero.Text = "Genero";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblFechaNacimiento.ForeColor = System.Drawing.Color.White;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(93, 451);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(201, 25);
            this.lblFechaNacimiento.TabIndex = 77;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento ";
            // 
            // lblTelefono
            // 
            this.lblTelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTelefono.ForeColor = System.Drawing.Color.White;
            this.lblTelefono.Location = new System.Drawing.Point(93, 306);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(200, 25);
            this.lblTelefono.TabIndex = 76;
            this.lblTelefono.Text = "Número de Teléfono ";
            // 
            // lblDireccion
            // 
            this.lblDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.BackColor = System.Drawing.Color.Transparent;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblDireccion.ForeColor = System.Drawing.Color.White;
            this.lblDireccion.Location = new System.Drawing.Point(93, 248);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(195, 25);
            this.lblDireccion.TabIndex = 73;
            this.lblDireccion.Text = "Ciudad // Dirección :";
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblApellido.ForeColor = System.Drawing.Color.White;
            this.lblApellido.Location = new System.Drawing.Point(93, 181);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(86, 25);
            this.lblApellido.TabIndex = 75;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(93, 102);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(86, 25);
            this.lblNombre.TabIndex = 74;
            this.lblNombre.Text = "Nombre";
            // 
            // lblRegistro
            // 
            this.lblRegistro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistro.Font = new System.Drawing.Font("Segoe UI", 20.75F, System.Drawing.FontStyle.Bold);
            this.lblRegistro.ForeColor = System.Drawing.Color.White;
            this.lblRegistro.Location = new System.Drawing.Point(121, 42);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(299, 38);
            this.lblRegistro.TabIndex = 72;
            this.lblRegistro.Text = "Modifica a tu Cliente ";
            // 
            // pbCajaRegistro
            // 
            this.pbCajaRegistro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbCajaRegistro.BackColor = System.Drawing.Color.Transparent;
            this.pbCajaRegistro.Image = global::Vistas.Properties.Resources.caga_registro_v2;
            this.pbCajaRegistro.Location = new System.Drawing.Point(68, 33);
            this.pbCajaRegistro.Name = "pbCajaRegistro";
            this.pbCajaRegistro.Size = new System.Drawing.Size(398, 591);
            this.pbCajaRegistro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCajaRegistro.TabIndex = 81;
            this.pbCajaRegistro.TabStop = false;
            // 
            // frmModificarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Vistas.Properties.Resources.e;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1045, 656);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.lblLimpiarDGV);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.msktxtDui);
            this.Controls.Add(this.lblDUI);
            this.Controls.Add(this.lblMujer);
            this.Controls.Add(this.lblHombre);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.msktxtTelefono);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.rbtnHombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.rbtnMujer);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.pbCajaRegistro);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmModificarCliente";
            this.Text = "frmModificarCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCajaRegistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox msktxtDui;
        private LabelTransparente lblDUI;
        private LabelTransparente lblMujer;
        private LabelTransparente lblHombre;
        private LabelTransparente lblGenero;
        private System.Windows.Forms.TextBox txtNombre;
        private LabelTransparente lblFechaNacimiento;
        private System.Windows.Forms.TextBox txtApellido;
        private LabelTransparente lblTelefono;
        private System.Windows.Forms.TextBox txtCiudad;
        private LabelTransparente lblDireccion;
        private System.Windows.Forms.MaskedTextBox msktxtTelefono;
        private LabelTransparente lblApellido;
        private System.Windows.Forms.RadioButton rbtnHombre;
        private LabelTransparente lblNombre;
        private System.Windows.Forms.RadioButton rbtnMujer;
        private LabelTransparente lblRegistro;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.PictureBox pbCajaRegistro;
        private Componentes_Improvisados.IPESBotonRedondeado btnMenu;
        private Componentes_Improvisados.IPESBotonRedondeado btnModificar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private Componentes_Improvisados.IPESBotonRedondeado btnBusqueda;
        private System.Windows.Forms.Label lblLimpiarDGV;
        private System.Windows.Forms.TextBox txtBusqueda;
        private Componentes_Improvisados.IPESBotonRedondeado btnEliminar;
    }
}