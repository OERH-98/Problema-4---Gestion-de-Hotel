namespace Vistas.Formularios
{
    partial class frmLogin
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
            this.lblMensaje = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblClave = new LabelTransparente();
            this.lblCorreo = new LabelTransparente();
            this.pbPerfil = new CustomControls.RJControls.PictureBoxRedondo();
            this.btnIniciarSesion = new Vistas.Formularios.Componentes_Improvisados.IPESBotonRedondeado();
            this.btnCrearCuenta = new Vistas.Formularios.Componentes_Improvisados.IPESBotonRedondeado();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pbOjo1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOjo1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.BackColor = System.Drawing.Color.Transparent;
            this.lblMensaje.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.White;
            this.lblMensaje.Location = new System.Drawing.Point(387, 9);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(239, 50);
            this.lblMensaje.TabIndex = 1;
            this.lblMensaje.Text = "Inicia Sesión";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(293, 363);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(424, 33);
            this.txtCorreo.TabIndex = 5;
            // 
            // txtClave
            // 
            this.txtClave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClave.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(293, 470);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(383, 26);
            this.txtClave.TabIndex = 6;
            this.txtClave.UseSystemPasswordChar = true;
            // 
            // lblClave
            // 
            this.lblClave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblClave.AutoSize = true;
            this.lblClave.BackColor = System.Drawing.Color.Transparent;
            this.lblClave.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(288, 417);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(109, 25);
            this.lblClave.TabIndex = 4;
            this.lblClave.Text = "Contraseña";
            // 
            // lblCorreo
            // 
            this.lblCorreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = System.Drawing.Color.Transparent;
            this.lblCorreo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(288, 322);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(70, 25);
            this.lblCorreo.TabIndex = 3;
            this.lblCorreo.Text = "Correo";
            // 
            // pbPerfil
            // 
            this.pbPerfil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbPerfil.BackColor = System.Drawing.Color.Transparent;
            this.pbPerfil.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pbPerfil.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pbPerfil.BorderColor2 = System.Drawing.Color.HotPink;
            this.pbPerfil.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pbPerfil.BorderSize = 4;
            this.pbPerfil.GradientAngle = 50F;
            this.pbPerfil.Location = new System.Drawing.Point(396, 84);
            this.pbPerfil.Name = "pbPerfil";
            this.pbPerfil.Size = new System.Drawing.Size(199, 199);
            this.pbPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPerfil.TabIndex = 2;
            this.pbPerfil.TabStop = false;
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIniciarSesion.BackColor = System.Drawing.Color.Black;
            this.btnIniciarSesion.BackgroundColor = System.Drawing.Color.Black;
            this.btnIniciarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIniciarSesion.BorderColor = System.Drawing.Color.White;
            this.btnIniciarSesion.BorderRadius = 20;
            this.btnIniciarSesion.BorderSize = 4;
            this.btnIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarSesion.FlatAppearance.BorderSize = 0;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.Location = new System.Drawing.Point(293, 522);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(149, 68);
            this.btnIniciarSesion.TabIndex = 55;
            this.btnIniciarSesion.Text = "Iniciar Sesión";
            this.btnIniciarSesion.TextColor = System.Drawing.Color.White;
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCrearCuenta.BackColor = System.Drawing.Color.Black;
            this.btnCrearCuenta.BackgroundColor = System.Drawing.Color.Black;
            this.btnCrearCuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCrearCuenta.BorderColor = System.Drawing.Color.White;
            this.btnCrearCuenta.BorderRadius = 20;
            this.btnCrearCuenta.BorderSize = 4;
            this.btnCrearCuenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearCuenta.FlatAppearance.BorderSize = 0;
            this.btnCrearCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearCuenta.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnCrearCuenta.ForeColor = System.Drawing.Color.White;
            this.btnCrearCuenta.Location = new System.Drawing.Point(568, 522);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Size = new System.Drawing.Size(149, 68);
            this.btnCrearCuenta.TabIndex = 57;
            this.btnCrearCuenta.Text = "Crear Cuenta";
            this.btnCrearCuenta.TextColor = System.Drawing.Color.White;
            this.btnCrearCuenta.UseVisualStyleBackColor = false;
            this.btnCrearCuenta.Click += new System.EventHandler(this.btnCrearCuenta_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // pbOjo1
            // 
            this.pbOjo1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbOjo1.BackColor = System.Drawing.Color.Transparent;
            this.pbOjo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbOjo1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbOjo1.Image = global::Vistas.Properties.Resources.icons8_invisible_96;
            this.pbOjo1.Location = new System.Drawing.Point(675, 470);
            this.pbOjo1.Name = "pbOjo1";
            this.pbOjo1.Size = new System.Drawing.Size(42, 26);
            this.pbOjo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOjo1.TabIndex = 58;
            this.pbOjo1.TabStop = false;
            this.pbOjo1.Click += new System.EventHandler(this.pbOjo1_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(976, 652);
            this.Controls.Add(this.pbOjo1);
            this.Controls.Add(this.btnCrearCuenta);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.pbPerfil);
            this.Controls.Add(this.lblMensaje);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOjo1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensaje;
        private CustomControls.RJControls.PictureBoxRedondo pbPerfil;
        private LabelTransparente lblCorreo;
        private LabelTransparente lblClave;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtClave;
        private Componentes_Improvisados.IPESBotonRedondeado btnIniciarSesion;
        private Componentes_Improvisados.IPESBotonRedondeado btnCrearCuenta;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.PictureBox pbOjo1;
    }
}