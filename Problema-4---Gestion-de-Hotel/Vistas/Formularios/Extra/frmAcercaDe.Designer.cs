namespace Vistas.Formularios.Extra
{
    partial class frmAcercaDe
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
            this.tbpnl = new System.Windows.Forms.TableLayoutPanel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblCorporacion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnAceptar = new Vistas.Formularios.Componentes_Improvisados.IPESBotonRedondeado();
            this.tbpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tbpnl
            // 
            this.tbpnl.ColumnCount = 2;
            this.tbpnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tbpnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tbpnl.Controls.Add(this.pbLogo, 0, 0);
            this.tbpnl.Controls.Add(this.lblNombreProducto, 1, 0);
            this.tbpnl.Controls.Add(this.lblVersion, 1, 1);
            this.tbpnl.Controls.Add(this.lblCopyright, 1, 2);
            this.tbpnl.Controls.Add(this.lblCorporacion, 1, 3);
            this.tbpnl.Controls.Add(this.txtDescripcion, 1, 4);
            this.tbpnl.Controls.Add(this.btnAceptar, 1, 5);
            this.tbpnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpnl.Location = new System.Drawing.Point(0, 0);
            this.tbpnl.Name = "tbpnl";
            this.tbpnl.RowCount = 6;
            this.tbpnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tbpnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tbpnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tbpnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tbpnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbpnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tbpnl.Size = new System.Drawing.Size(800, 450);
            this.tbpnl.TabIndex = 1;
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogo.Image = global::Vistas.Properties.Resources.Hotel;
            this.pbLogo.Location = new System.Drawing.Point(3, 3);
            this.pbLogo.Name = "pbLogo";
            this.tbpnl.SetRowSpan(this.pbLogo, 6);
            this.pbLogo.Size = new System.Drawing.Size(258, 444);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 12;
            this.pbLogo.TabStop = false;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombreProducto.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.lblNombreProducto.Location = new System.Drawing.Point(270, 0);
            this.lblNombreProducto.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.lblNombreProducto.MaximumSize = new System.Drawing.Size(0, 17);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(527, 17);
            this.lblNombreProducto.TabIndex = 19;
            this.lblNombreProducto.Text = "Nombre de producto";
            this.lblNombreProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVersion
            // 
            this.lblVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.lblVersion.Location = new System.Drawing.Point(270, 45);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.lblVersion.MaximumSize = new System.Drawing.Size(0, 17);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(527, 17);
            this.lblVersion.TabIndex = 0;
            this.lblVersion.Text = "Versión";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCopyright
            // 
            this.lblCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCopyright.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.lblCopyright.Location = new System.Drawing.Point(270, 90);
            this.lblCopyright.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.lblCopyright.MaximumSize = new System.Drawing.Size(0, 17);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(527, 17);
            this.lblCopyright.TabIndex = 21;
            this.lblCopyright.Text = "Copyright";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCorporacion
            // 
            this.lblCorporacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCorporacion.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.lblCorporacion.Location = new System.Drawing.Point(270, 135);
            this.lblCorporacion.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.lblCorporacion.MaximumSize = new System.Drawing.Size(0, 17);
            this.lblCorporacion.Name = "lblCorporacion";
            this.lblCorporacion.Size = new System.Drawing.Size(527, 17);
            this.lblCorporacion.TabIndex = 22;
            this.lblCorporacion.Text = "Nombre de la compañía";
            this.lblCorporacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(270, 183);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDescripcion.Size = new System.Drawing.Size(527, 219);
            this.txtDescripcion.TabIndex = 23;
            this.txtDescripcion.TabStop = false;
            this.txtDescripcion.Text = "Descripción";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.BackColor = System.Drawing.Color.Black;
            this.btnAceptar.BackgroundColor = System.Drawing.Color.Black;
            this.btnAceptar.BorderColor = System.Drawing.Color.White;
            this.btnAceptar.BorderRadius = 15;
            this.btnAceptar.BorderSize = 4;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(685, 408);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(112, 34);
            this.btnAceptar.TabIndex = 24;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextColor = System.Drawing.Color.White;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmAcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbpnl);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAcercaDe";
            this.Text = "frmAcercaDe";
            this.tbpnl.ResumeLayout(false);
            this.tbpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbpnl;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblCorporacion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private Componentes_Improvisados.IPESBotonRedondeado btnAceptar;
    }
}