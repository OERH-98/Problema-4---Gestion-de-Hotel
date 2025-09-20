namespace Vistas.Formularios.Componentes_Nuevos
{
    partial class frmMensajedeDialogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMensajedeDialogo));
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlCuerpo = new System.Windows.Forms.Panel();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.pbIcono = new System.Windows.Forms.PictureBox();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btn3 = new Vistas.Formularios.Componentes_Improvisados.IPESBotonRedondeado();
            this.btn2 = new Vistas.Formularios.Componentes_Improvisados.IPESBotonRedondeado();
            this.btn1 = new Vistas.Formularios.Componentes_Improvisados.IPESBotonRedondeado();
            this.pnlTitulo.SuspendLayout();
            this.pnlCuerpo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).BeginInit();
            this.pnlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(433, 35);
            this.pnlTitulo.TabIndex = 5;
            this.pnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitulo_MouseDown);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(9, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(93, 21);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "labelTitulo";
            this.lblTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitulo_MouseDown);
            // 
            // pnlCuerpo
            // 
            this.pnlCuerpo.BackColor = System.Drawing.Color.White;
            this.pnlCuerpo.Controls.Add(this.lblMensaje);
            this.pnlCuerpo.Controls.Add(this.pbIcono);
            this.pnlCuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCuerpo.Location = new System.Drawing.Point(0, 35);
            this.pnlCuerpo.Name = "pnlCuerpo";
            this.pnlCuerpo.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.pnlCuerpo.Size = new System.Drawing.Size(433, 79);
            this.pnlCuerpo.TabIndex = 7;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.BackColor = System.Drawing.Color.Transparent;
            this.lblMensaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMensaje.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.Black;
            this.lblMensaje.Location = new System.Drawing.Point(58, 10);
            this.lblMensaje.MaximumSize = new System.Drawing.Size(600, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Padding = new System.Windows.Forms.Padding(5, 5, 10, 15);
            this.lblMensaje.Size = new System.Drawing.Size(121, 41);
            this.lblMensaje.TabIndex = 1;
            this.lblMensaje.Text = "labelMensaje";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbIcono
            // 
            this.pbIcono.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbIcono.Image = ((System.Drawing.Image)(resources.GetObject("pbIcono.Image")));
            this.pbIcono.Location = new System.Drawing.Point(10, 10);
            this.pbIcono.Name = "pbIcono";
            this.pbIcono.Size = new System.Drawing.Size(48, 69);
            this.pbIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIcono.TabIndex = 0;
            this.pbIcono.TabStop = false;
            // 
            // pnlBotones
            // 
            this.pnlBotones.BackColor = System.Drawing.Color.White;
            this.pnlBotones.Controls.Add(this.btn3);
            this.pnlBotones.Controls.Add(this.btn2);
            this.pnlBotones.Controls.Add(this.btn1);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotones.ForeColor = System.Drawing.Color.White;
            this.pnlBotones.Location = new System.Drawing.Point(0, 114);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(433, 60);
            this.pnlBotones.TabIndex = 6;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.SeaGreen;
            this.btn3.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.btn3.BorderColor = System.Drawing.Color.White;
            this.btn3.BorderRadius = 15;
            this.btn3.BorderSize = 2;
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn3.ForeColor = System.Drawing.Color.White;
            this.btn3.Location = new System.Drawing.Point(295, 13);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(100, 35);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "Boton3";
            this.btn3.TextColor = System.Drawing.Color.White;
            this.btn3.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.SeaGreen;
            this.btn2.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.btn2.BorderColor = System.Drawing.Color.White;
            this.btn2.BorderRadius = 15;
            this.btn2.BorderSize = 2;
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Location = new System.Drawing.Point(168, 13);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(100, 35);
            this.btn2.TabIndex = 4;
            this.btn2.Text = "Boton2";
            this.btn2.TextColor = System.Drawing.Color.White;
            this.btn2.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.SeaGreen;
            this.btn1.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.btn1.BorderColor = System.Drawing.Color.White;
            this.btn1.BorderRadius = 15;
            this.btn1.BorderSize = 2;
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Location = new System.Drawing.Point(41, 13);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(100, 35);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "Boton1";
            this.btn1.TextColor = System.Drawing.Color.White;
            this.btn1.UseVisualStyleBackColor = false;
            // 
            // frmMensajedeDialogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 174);
            this.Controls.Add(this.pnlCuerpo);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.pnlBotones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMensajedeDialogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMensajedeDialogo";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlCuerpo.ResumeLayout(false);
            this.pnlCuerpo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).EndInit();
            this.pnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlCuerpo;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.PictureBox pbIcono;
        private System.Windows.Forms.Panel pnlBotones;
        private Componentes_Improvisados.IPESBotonRedondeado btn3;
        private Componentes_Improvisados.IPESBotonRedondeado btn2;
        private Componentes_Improvisados.IPESBotonRedondeado btn1;
    }
}