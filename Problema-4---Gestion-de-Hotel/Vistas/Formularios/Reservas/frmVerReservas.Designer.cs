namespace Vistas.Formularios.Reservas
{
    partial class frmVerReservas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBuscarReserva = new Vistas.Formularios.Componentes_Improvisados.IPESBotonRedondeado();
            this.lblLimpiarDGV2 = new System.Windows.Forms.Label();
            this.txtBusquedaReserva = new System.Windows.Forms.TextBox();
            this.lblReserva = new LabelTransparente();
            this.dgvReserva = new System.Windows.Forms.DataGridView();
            this.btnMenu = new Vistas.Formularios.Componentes_Improvisados.IPESBotonRedondeado();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).BeginInit();
            this.SuspendLayout();
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
            this.btnBuscarReserva.Location = new System.Drawing.Point(561, 116);
            this.btnBuscarReserva.Name = "btnBuscarReserva";
            this.btnBuscarReserva.Size = new System.Drawing.Size(99, 54);
            this.btnBuscarReserva.TabIndex = 301;
            this.btnBuscarReserva.Text = "Buscar";
            this.btnBuscarReserva.TextColor = System.Drawing.Color.White;
            this.btnBuscarReserva.UseVisualStyleBackColor = false;
            this.btnBuscarReserva.Click += new System.EventHandler(this.btnBuscarReserva_Click);
            // 
            // lblLimpiarDGV2
            // 
            this.lblLimpiarDGV2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLimpiarDGV2.AutoSize = true;
            this.lblLimpiarDGV2.BackColor = System.Drawing.Color.White;
            this.lblLimpiarDGV2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLimpiarDGV2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimpiarDGV2.ForeColor = System.Drawing.Color.Black;
            this.lblLimpiarDGV2.Location = new System.Drawing.Point(511, 133);
            this.lblLimpiarDGV2.Name = "lblLimpiarDGV2";
            this.lblLimpiarDGV2.Size = new System.Drawing.Size(27, 30);
            this.lblLimpiarDGV2.TabIndex = 300;
            this.lblLimpiarDGV2.Text = "X";
            this.lblLimpiarDGV2.Click += new System.EventHandler(this.lblLimpiarDGV2_Click);
            // 
            // txtBusquedaReserva
            // 
            this.txtBusquedaReserva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBusquedaReserva.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBusquedaReserva.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaReserva.Location = new System.Drawing.Point(272, 124);
            this.txtBusquedaReserva.Multiline = true;
            this.txtBusquedaReserva.Name = "txtBusquedaReserva";
            this.txtBusquedaReserva.ShortcutsEnabled = false;
            this.txtBusquedaReserva.Size = new System.Drawing.Size(233, 46);
            this.txtBusquedaReserva.TabIndex = 299;
            // 
            // lblReserva
            // 
            this.lblReserva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReserva.AutoSize = true;
            this.lblReserva.BackColor = System.Drawing.Color.Transparent;
            this.lblReserva.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold);
            this.lblReserva.ForeColor = System.Drawing.Color.White;
            this.lblReserva.Location = new System.Drawing.Point(210, 20);
            this.lblReserva.Name = "lblReserva";
            this.lblReserva.Size = new System.Drawing.Size(494, 50);
            this.lblReserva.TabIndex = 298;
            this.lblReserva.Text = "Revisa la Reserva Existente ";
            // 
            // dgvReserva
            // 
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dgvReserva.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvReserva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvReserva.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvReserva.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReserva.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReserva.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReserva.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvReserva.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvReserva.Location = new System.Drawing.Point(58, 204);
            this.dgvReserva.Name = "dgvReserva";
            this.dgvReserva.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReserva.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvReserva.Size = new System.Drawing.Size(802, 240);
            this.dgvReserva.TabIndex = 297;
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.btnMenu.Location = new System.Drawing.Point(325, 464);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(255, 68);
            this.btnMenu.TabIndex = 302;
            this.btnMenu.Text = "Regresar al Menú de Opciones";
            this.btnMenu.TextColor = System.Drawing.Color.White;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // frmVerReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Vistas.Properties.Resources.e;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 563);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnBuscarReserva);
            this.Controls.Add(this.lblLimpiarDGV2);
            this.Controls.Add(this.txtBusquedaReserva);
            this.Controls.Add(this.lblReserva);
            this.Controls.Add(this.dgvReserva);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVerReservas";
            this.Text = "frmVerReservas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes_Improvisados.IPESBotonRedondeado btnBuscarReserva;
        private System.Windows.Forms.Label lblLimpiarDGV2;
        private System.Windows.Forms.TextBox txtBusquedaReserva;
        private LabelTransparente lblReserva;
        private System.Windows.Forms.DataGridView dgvReserva;
        private Componentes_Improvisados.IPESBotonRedondeado btnMenu;
    }
}