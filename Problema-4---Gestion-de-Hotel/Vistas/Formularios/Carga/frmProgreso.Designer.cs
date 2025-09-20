namespace Vistas.Formularios.Carga
{
    partial class frmProgreso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProgreso));
            this.tmrOcultarAnimacion = new System.Windows.Forms.Timer(this.components);
            this.tmrAnimacion = new System.Windows.Forms.Timer(this.components);
            this.pnlBarradeCarga = new System.Windows.Forms.Panel();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.pbFondo = new System.Windows.Forms.PictureBox();
            this.lblMensaje = new LabelTransparente();
            this.pgbProgreso = new Vistas.Formularios.Componentes_Improvisados.barra_de_carga_redondeada();
            this.pbLogo = new CustomControls.RJControls.PictureBoxRedondo();
            this.pnlBarradeCarga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrOcultarAnimacion
            // 
            this.tmrOcultarAnimacion.Interval = 10;
            this.tmrOcultarAnimacion.Tick += new System.EventHandler(this.tmrOcultarAnimacion_Tick);
            // 
            // tmrAnimacion
            // 
            this.tmrAnimacion.Interval = 10;
            this.tmrAnimacion.Tick += new System.EventHandler(this.tmrAnimacion_Tick_1);
            // 
            // pnlBarradeCarga
            // 
            this.pnlBarradeCarga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBarradeCarga.BackColor = System.Drawing.Color.Black;
            this.pnlBarradeCarga.Controls.Add(this.pgbProgreso);
            this.pnlBarradeCarga.Location = new System.Drawing.Point(62, 436);
            this.pnlBarradeCarga.Name = "pnlBarradeCarga";
            this.pnlBarradeCarga.Size = new System.Drawing.Size(463, 70);
            this.pnlBarradeCarga.TabIndex = 10;
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.BackColor = System.Drawing.Color.Black;
            this.lblPorcentaje.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblPorcentaje.ForeColor = System.Drawing.Color.White;
            this.lblPorcentaje.Location = new System.Drawing.Point(544, 438);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(98, 65);
            this.lblPorcentaje.TabIndex = 14;
            this.lblPorcentaje.Text = "0%";
            // 
            // pbFondo
            // 
            this.pbFondo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbFondo.BackColor = System.Drawing.Color.Transparent;
            this.pbFondo.Image = global::Vistas.Properties.Resources.Cargav2;
            this.pbFondo.Location = new System.Drawing.Point(28, 12);
            this.pbFondo.Name = "pbFondo";
            this.pbFondo.Size = new System.Drawing.Size(678, 582);
            this.pbFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFondo.TabIndex = 8;
            this.pbFondo.TabStop = false;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.BackColor = System.Drawing.Color.Transparent;
            this.lblMensaje.Font = new System.Drawing.Font("Segoe UI", 27F, System.Drawing.FontStyle.Bold);
            this.lblMensaje.ForeColor = System.Drawing.Color.White;
            this.lblMensaje.Location = new System.Drawing.Point(87, 43);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(586, 48);
            this.lblMensaje.TabIndex = 13;
            this.lblMensaje.Text = "Bienvenido a Gestión de Hoteles  ";
            // 
            // pgbProgreso
            // 
            this.pgbProgreso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pgbProgreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pgbProgreso.ColorBorde = System.Drawing.Color.Transparent;
            this.pgbProgreso.EstiloBorde = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pgbProgreso.ForeColor = System.Drawing.Color.White;
            this.pgbProgreso.GrosorBorde = 0F;
            this.pgbProgreso.Location = new System.Drawing.Point(16, 10);
            this.pgbProgreso.Name = "pgbProgreso";
            this.pgbProgreso.Radio_Esquina = 20;
            this.pgbProgreso.Size = new System.Drawing.Size(432, 57);
            this.pgbProgreso.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pgbProgreso.TabIndex = 9;
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Black;
            this.pbLogo.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pbLogo.BorderColor = System.Drawing.Color.Black;
            this.pbLogo.BorderColor2 = System.Drawing.Color.Black;
            this.pbLogo.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pbLogo.BorderSize = 0;
            this.pbLogo.GradientAngle = 50F;
            this.pbLogo.Image = global::Vistas.Properties.Resources.icons8_visible_96;
            this.pbLogo.Location = new System.Drawing.Point(267, 162);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(199, 199);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 12;
            this.pbLogo.TabStop = false;
            // 
            // frmProgreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(739, 627);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.pnlBarradeCarga);
            this.Controls.Add(this.pbFondo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProgreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProgreso";
            this.Load += new System.EventHandler(this.frmProgreso_Load);
            this.pnlBarradeCarga.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmrOcultarAnimacion;
        private System.Windows.Forms.Timer tmrAnimacion;
        private System.Windows.Forms.PictureBox pbFondo;
        private Componentes_Improvisados.barra_de_carga_redondeada pgbProgreso;
        private System.Windows.Forms.Panel pnlBarradeCarga;
        private LabelTransparente lblMensaje;
        private System.Windows.Forms.Label lblPorcentaje;
        private CustomControls.RJControls.PictureBoxRedondo pbLogo;
    }
}