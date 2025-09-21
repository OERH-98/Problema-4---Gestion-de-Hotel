namespace Vistas.Formularios.Clientes
{
    partial class frmInsertarCliente
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
            this.btnMenu = new Vistas.Formularios.Componentes_Improvisados.IPESBotonRedondeado();
            this.lblMujer = new LabelTransparente();
            this.lblHombre = new LabelTransparente();
            this.lblGenero = new LabelTransparente();
            this.lblFechaNacimiento = new LabelTransparente();
            this.lblTelefono = new LabelTransparente();
            this.lblDireccion = new LabelTransparente();
            this.lblApellido = new LabelTransparente();
            this.lblNombre = new LabelTransparente();
            this.lblRegistro = new LabelTransparente();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.rbtnMujer = new System.Windows.Forms.RadioButton();
            this.rbtnHombre = new System.Windows.Forms.RadioButton();
            this.btnRegistrar = new Vistas.Formularios.Componentes_Improvisados.IPESBotonRedondeado();
            this.msktxtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDUI = new LabelTransparente();
            this.msktxtDui = new System.Windows.Forms.MaskedTextBox();
            this.pbCajaRegistro = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCajaRegistro)).BeginInit();
            this.SuspendLayout();
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
            this.btnMenu.Location = new System.Drawing.Point(546, 338);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(343, 111);
            this.btnMenu.TabIndex = 61;
            this.btnMenu.Text = "Regresar al Menú";
            this.btnMenu.TextColor = System.Drawing.Color.White;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblMujer
            // 
            this.lblMujer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMujer.AutoSize = true;
            this.lblMujer.BackColor = System.Drawing.Color.Transparent;
            this.lblMujer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMujer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblMujer.ForeColor = System.Drawing.Color.White;
            this.lblMujer.Location = new System.Drawing.Point(275, 402);
            this.lblMujer.Name = "lblMujer";
            this.lblMujer.Size = new System.Drawing.Size(65, 25);
            this.lblMujer.TabIndex = 59;
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
            this.lblHombre.Location = new System.Drawing.Point(85, 399);
            this.lblHombre.Name = "lblHombre";
            this.lblHombre.Size = new System.Drawing.Size(86, 25);
            this.lblHombre.TabIndex = 58;
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
            this.lblGenero.Location = new System.Drawing.Point(55, 357);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(78, 25);
            this.lblGenero.TabIndex = 57;
            this.lblGenero.Text = "Genero";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblFechaNacimiento.ForeColor = System.Drawing.Color.White;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(55, 437);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(201, 25);
            this.lblFechaNacimiento.TabIndex = 53;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento ";
            // 
            // lblTelefono
            // 
            this.lblTelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTelefono.ForeColor = System.Drawing.Color.White;
            this.lblTelefono.Location = new System.Drawing.Point(55, 279);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(200, 25);
            this.lblTelefono.TabIndex = 51;
            this.lblTelefono.Text = "Número de Teléfono ";
            // 
            // lblDireccion
            // 
            this.lblDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.BackColor = System.Drawing.Color.Transparent;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblDireccion.ForeColor = System.Drawing.Color.White;
            this.lblDireccion.Location = new System.Drawing.Point(55, 221);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(195, 25);
            this.lblDireccion.TabIndex = 48;
            this.lblDireccion.Text = "Ciudad // Dirección :";
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblApellido.ForeColor = System.Drawing.Color.White;
            this.lblApellido.Location = new System.Drawing.Point(55, 154);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(86, 25);
            this.lblApellido.TabIndex = 49;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(55, 75);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(86, 25);
            this.lblNombre.TabIndex = 48;
            this.lblNombre.Text = "Nombre";
            // 
            // lblRegistro
            // 
            this.lblRegistro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistro.Font = new System.Drawing.Font("Segoe UI", 20.75F, System.Drawing.FontStyle.Bold);
            this.lblRegistro.ForeColor = System.Drawing.Color.White;
            this.lblRegistro.Location = new System.Drawing.Point(83, 15);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(289, 38);
            this.lblRegistro.TabIndex = 47;
            this.lblRegistro.Text = "Registra a tu Cliente ";
            // 
            // dtp1
            // 
            this.dtp1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.dtp1.Location = new System.Drawing.Point(60, 475);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(322, 27);
            this.dtp1.TabIndex = 45;
            // 
            // rbtnMujer
            // 
            this.rbtnMujer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtnMujer.AutoSize = true;
            this.rbtnMujer.BackColor = System.Drawing.Color.Transparent;
            this.rbtnMujer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnMujer.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMujer.ForeColor = System.Drawing.Color.Transparent;
            this.rbtnMujer.Location = new System.Drawing.Point(255, 408);
            this.rbtnMujer.Name = "rbtnMujer";
            this.rbtnMujer.Size = new System.Drawing.Size(14, 13);
            this.rbtnMujer.TabIndex = 39;
            this.rbtnMujer.UseVisualStyleBackColor = false;
            // 
            // rbtnHombre
            // 
            this.rbtnHombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtnHombre.AutoSize = true;
            this.rbtnHombre.BackColor = System.Drawing.Color.Transparent;
            this.rbtnHombre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnHombre.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnHombre.ForeColor = System.Drawing.Color.Transparent;
            this.rbtnHombre.Location = new System.Drawing.Point(60, 402);
            this.rbtnHombre.Name = "rbtnHombre";
            this.rbtnHombre.Size = new System.Drawing.Size(14, 13);
            this.rbtnHombre.TabIndex = 38;
            this.rbtnHombre.UseVisualStyleBackColor = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistrar.BackColor = System.Drawing.Color.Black;
            this.btnRegistrar.BackgroundColor = System.Drawing.Color.Black;
            this.btnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistrar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRegistrar.BorderRadius = 15;
            this.btnRegistrar.BorderSize = 2;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(546, 165);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(343, 111);
            this.btnRegistrar.TabIndex = 35;
            this.btnRegistrar.Text = "Registrar Cliente ";
            this.btnRegistrar.TextColor = System.Drawing.Color.White;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // msktxtTelefono
            // 
            this.msktxtTelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.msktxtTelefono.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.msktxtTelefono.Location = new System.Drawing.Point(60, 320);
            this.msktxtTelefono.Mask = "0000-0000";
            this.msktxtTelefono.Name = "msktxtTelefono";
            this.msktxtTelefono.ShortcutsEnabled = false;
            this.msktxtTelefono.Size = new System.Drawing.Size(325, 27);
            this.msktxtTelefono.TabIndex = 34;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCiudad.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtCiudad.Location = new System.Drawing.Point(60, 249);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.ShortcutsEnabled = false;
            this.txtCiudad.Size = new System.Drawing.Size(325, 27);
            this.txtCiudad.TabIndex = 13;
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtApellido.Location = new System.Drawing.Point(60, 191);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ShortcutsEnabled = false;
            this.txtApellido.Size = new System.Drawing.Size(325, 27);
            this.txtApellido.TabIndex = 12;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtNombre.Location = new System.Drawing.Point(60, 114);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ShortcutsEnabled = false;
            this.txtNombre.Size = new System.Drawing.Size(325, 27);
            this.txtNombre.TabIndex = 11;
            // 
            // lblDUI
            // 
            this.lblDUI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDUI.AutoSize = true;
            this.lblDUI.BackColor = System.Drawing.Color.Transparent;
            this.lblDUI.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblDUI.ForeColor = System.Drawing.Color.White;
            this.lblDUI.Location = new System.Drawing.Point(55, 505);
            this.lblDUI.Name = "lblDUI";
            this.lblDUI.Size = new System.Drawing.Size(46, 25);
            this.lblDUI.TabIndex = 63;
            this.lblDUI.Text = "DUI";
            // 
            // msktxtDui
            // 
            this.msktxtDui.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.msktxtDui.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.msktxtDui.Location = new System.Drawing.Point(60, 533);
            this.msktxtDui.Mask = "0000000-0";
            this.msktxtDui.Name = "msktxtDui";
            this.msktxtDui.ShortcutsEnabled = false;
            this.msktxtDui.Size = new System.Drawing.Size(325, 27);
            this.msktxtDui.TabIndex = 64;
            // 
            // pbCajaRegistro
            // 
            this.pbCajaRegistro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbCajaRegistro.BackColor = System.Drawing.Color.Transparent;
            this.pbCajaRegistro.Image = global::Vistas.Properties.Resources.caga_registro_v2;
            this.pbCajaRegistro.Location = new System.Drawing.Point(30, 6);
            this.pbCajaRegistro.Name = "pbCajaRegistro";
            this.pbCajaRegistro.Size = new System.Drawing.Size(398, 591);
            this.pbCajaRegistro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCajaRegistro.TabIndex = 62;
            this.pbCajaRegistro.TabStop = false;
            // 
            // frmInsertarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Vistas.Properties.Resources.black_and_blue_background_abstract_light_leak_p6f2434y35fq33tb;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1035, 609);
            this.Controls.Add(this.msktxtDui);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lblDUI);
            this.Controls.Add(this.lblMujer);
            this.Controls.Add(this.btnRegistrar);
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
            this.Name = "frmInsertarCliente";
            this.Text = "frmInsertarCliente";
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
        private LabelTransparente lblFechaNacimiento;
        private LabelTransparente lblTelefono;
        private LabelTransparente lblDireccion;
        private LabelTransparente lblApellido;
        private LabelTransparente lblNombre;
        private LabelTransparente lblRegistro;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.RadioButton rbtnMujer;
        private System.Windows.Forms.RadioButton rbtnHombre;
        private System.Windows.Forms.MaskedTextBox msktxtTelefono;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.PictureBox pbCajaRegistro;
        private Componentes_Improvisados.IPESBotonRedondeado btnMenu;
        private Componentes_Improvisados.IPESBotonRedondeado btnRegistrar;
    }
}