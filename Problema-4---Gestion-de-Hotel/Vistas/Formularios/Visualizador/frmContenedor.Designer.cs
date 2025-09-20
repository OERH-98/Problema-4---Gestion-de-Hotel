namespace Vistas.Formularios.Visualizador
{
    partial class frmContenedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContenedor));
            this.pnlBarraArriba = new System.Windows.Forms.Panel();
            this.pbIconoOficial = new System.Windows.Forms.PictureBox();
            this.fplnBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.pbMinimiza = new System.Windows.Forms.PictureBox();
            this.pbMaximizar = new System.Windows.Forms.PictureBox();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.lblGestion = new LabelTransparente();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pnlBarraArriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconoOficial)).BeginInit();
            this.fplnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimiza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBarraArriba
            // 
            this.pnlBarraArriba.BackColor = System.Drawing.Color.White;
            this.pnlBarraArriba.Controls.Add(this.pbIconoOficial);
            this.pnlBarraArriba.Controls.Add(this.fplnBotones);
            this.pnlBarraArriba.Controls.Add(this.lblGestion);
            this.pnlBarraArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraArriba.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraArriba.Name = "pnlBarraArriba";
            this.pnlBarraArriba.Size = new System.Drawing.Size(1280, 35);
            this.pnlBarraArriba.TabIndex = 0;
            // 
            // pbIconoOficial
            // 
            this.pbIconoOficial.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbIconoOficial.Image = global::Vistas.Properties.Resources.icons8_5_star_hotel_96__1_;
            this.pbIconoOficial.Location = new System.Drawing.Point(8, 2);
            this.pbIconoOficial.Name = "pbIconoOficial";
            this.pbIconoOficial.Size = new System.Drawing.Size(36, 33);
            this.pbIconoOficial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIconoOficial.TabIndex = 10;
            this.pbIconoOficial.TabStop = false;
            // 
            // fplnBotones
            // 
            this.fplnBotones.BackColor = System.Drawing.Color.Transparent;
            this.fplnBotones.Controls.Add(this.pbMinimiza);
            this.fplnBotones.Controls.Add(this.pbMaximizar);
            this.fplnBotones.Controls.Add(this.pbCerrar);
            this.fplnBotones.Dock = System.Windows.Forms.DockStyle.Right;
            this.fplnBotones.Location = new System.Drawing.Point(1167, 0);
            this.fplnBotones.Name = "fplnBotones";
            this.fplnBotones.Size = new System.Drawing.Size(113, 35);
            this.fplnBotones.TabIndex = 2;
            // 
            // pbMinimiza
            // 
            this.pbMinimiza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMinimiza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMinimiza.Image = global::Vistas.Properties.Resources.icons8_minimizar_96;
            this.pbMinimiza.Location = new System.Drawing.Point(3, 3);
            this.pbMinimiza.Name = "pbMinimiza";
            this.pbMinimiza.Size = new System.Drawing.Size(31, 33);
            this.pbMinimiza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMinimiza.TabIndex = 9;
            this.pbMinimiza.TabStop = false;
            this.pbMinimiza.Click += new System.EventHandler(this.pbMinimiza_Click);
            // 
            // pbMaximizar
            // 
            this.pbMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMaximizar.Image = global::Vistas.Properties.Resources.icons8_maximizar_96;
            this.pbMaximizar.Location = new System.Drawing.Point(40, 3);
            this.pbMaximizar.Name = "pbMaximizar";
            this.pbMaximizar.Size = new System.Drawing.Size(31, 33);
            this.pbMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMaximizar.TabIndex = 8;
            this.pbMaximizar.TabStop = false;
            this.pbMaximizar.Click += new System.EventHandler(this.pbMaximizar_Click);
            // 
            // pbCerrar
            // 
            this.pbCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCerrar.Image = global::Vistas.Properties.Resources.icons8_cerrar_ventana_96;
            this.pbCerrar.Location = new System.Drawing.Point(77, 3);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(29, 33);
            this.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCerrar.TabIndex = 7;
            this.pbCerrar.TabStop = false;
            this.pbCerrar.Click += new System.EventHandler(this.pbCerrar_Click);
            // 
            // lblGestion
            // 
            this.lblGestion.AutoSize = true;
            this.lblGestion.BackColor = System.Drawing.Color.Transparent;
            this.lblGestion.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestion.ForeColor = System.Drawing.Color.Black;
            this.lblGestion.Location = new System.Drawing.Point(50, 2);
            this.lblGestion.Name = "lblGestion";
            this.lblGestion.Size = new System.Drawing.Size(194, 30);
            this.lblGestion.TabIndex = 1;
            this.lblGestion.Text = "Gestión de Hoteles";
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.Black;
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 35);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1280, 725);
            this.pnlContenedor.TabIndex = 1;
            // 
            // frmContenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 760);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlBarraArriba);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmContenedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Hoteles";
            this.pnlBarraArriba.ResumeLayout(false);
            this.pnlBarraArriba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconoOficial)).EndInit();
            this.fplnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimiza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraArriba;
        private LabelTransparente lblGestion;
        private System.Windows.Forms.FlowLayoutPanel fplnBotones;
        private System.Windows.Forms.PictureBox pbMinimiza;
        private System.Windows.Forms.PictureBox pbMaximizar;
        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.PictureBox pbIconoOficial;
        public System.Windows.Forms.Panel pnlContenedor;
    }
}