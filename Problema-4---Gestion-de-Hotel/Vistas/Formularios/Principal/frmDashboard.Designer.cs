namespace Vistas.Formularios.Principal
{
    partial class frmDashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxRedondo1 = new CustomControls.RJControls.PictureBoxRedondo();
            this.lblBienvenida = new LabelTransparente();
            this.lblUsuario = new LabelTransparente();
            this.lblDashboard = new LabelTransparente();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRedondo1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblDashboard);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.lblBienvenida);
            this.panel1.Controls.Add(this.pictureBoxRedondo1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 129);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxRedondo1
            // 
            this.pictureBoxRedondo1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxRedondo1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pictureBoxRedondo1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pictureBoxRedondo1.BorderColor2 = System.Drawing.Color.HotPink;
            this.pictureBoxRedondo1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pictureBoxRedondo1.BorderSize = 2;
            this.pictureBoxRedondo1.GradientAngle = 50F;
            this.pictureBoxRedondo1.Location = new System.Drawing.Point(12, 3);
            this.pictureBoxRedondo1.Name = "pictureBoxRedondo1";
            this.pictureBoxRedondo1.Size = new System.Drawing.Size(112, 112);
            this.pictureBoxRedondo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRedondo1.TabIndex = 0;
            this.pictureBoxRedondo1.TabStop = false;
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.BackColor = System.Drawing.Color.Transparent;
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.Location = new System.Drawing.Point(182, 20);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(143, 30);
            this.lblBienvenida.TabIndex = 1;
            this.lblBienvenida.Text = "¡Bienvenido! ";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(182, 75);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(104, 30);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "{Usuario}";
            // 
            // lblDashboard
            // 
            this.lblDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.BackColor = System.Drawing.Color.Transparent;
            this.lblDashboard.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.Location = new System.Drawing.Point(790, 40);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(232, 45);
            this.lblDashboard.TabIndex = 3;
            this.lblDashboard.Text = "DASHBOARD ";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1034, 614);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashboard";
            this.Text = "frmDashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRedondo1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CustomControls.RJControls.PictureBoxRedondo pictureBoxRedondo1;
        private LabelTransparente lblDashboard;
        private LabelTransparente lblUsuario;
        private LabelTransparente lblBienvenida;
    }
}