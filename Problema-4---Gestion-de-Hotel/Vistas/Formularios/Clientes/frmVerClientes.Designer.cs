namespace Vistas.Formularios.Clientes
{
    partial class frmVerClientes
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
            this.btnMenu = new Vistas.Formularios.Componentes_Improvisados.IPESBotonRedondeado();
            this.lblExistencia = new LabelTransparente();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnBusqueda = new Vistas.Formularios.Componentes_Improvisados.IPESBotonRedondeado();
            this.lblLimpiarDGV = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenu.BorderColor = System.Drawing.Color.White;
            this.btnMenu.BorderRadius = 15;
            this.btnMenu.BorderSize = 2;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(812, 211);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(210, 79);
            this.btnMenu.TabIndex = 245;
            this.btnMenu.Text = "Regresar a Menú";
            this.btnMenu.TextColor = System.Drawing.Color.White;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblExistencia
            // 
            this.lblExistencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblExistencia.AutoSize = true;
            this.lblExistencia.BackColor = System.Drawing.Color.Transparent;
            this.lblExistencia.Font = new System.Drawing.Font("Segoe UI", 44.25F, System.Drawing.FontStyle.Bold);
            this.lblExistencia.ForeColor = System.Drawing.Color.White;
            this.lblExistencia.Location = new System.Drawing.Point(310, 70);
            this.lblExistencia.Name = "lblExistencia";
            this.lblExistencia.Size = new System.Drawing.Size(548, 78);
            this.lblExistencia.TabIndex = 244;
            this.lblExistencia.Text = "Clientes Existentes";
            // 
            // dgvClientes
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClientes.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvClientes.Location = new System.Drawing.Point(124, 312);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvClientes.Size = new System.Drawing.Size(898, 320);
            this.dgvClientes.TabIndex = 243;
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
            this.btnBusqueda.Location = new System.Drawing.Point(611, 224);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(134, 54);
            this.btnBusqueda.TabIndex = 242;
            this.btnBusqueda.Text = "Buscar";
            this.btnBusqueda.TextColor = System.Drawing.Color.White;
            this.btnBusqueda.UseVisualStyleBackColor = false;
            // 
            // lblLimpiarDGV
            // 
            this.lblLimpiarDGV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLimpiarDGV.AutoSize = true;
            this.lblLimpiarDGV.BackColor = System.Drawing.Color.White;
            this.lblLimpiarDGV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLimpiarDGV.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimpiarDGV.ForeColor = System.Drawing.Color.Black;
            this.lblLimpiarDGV.Location = new System.Drawing.Point(547, 232);
            this.lblLimpiarDGV.Name = "lblLimpiarDGV";
            this.lblLimpiarDGV.Size = new System.Drawing.Size(27, 30);
            this.lblLimpiarDGV.TabIndex = 241;
            this.lblLimpiarDGV.Text = "X";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBusqueda.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(285, 232);
            this.txtBusqueda.Multiline = true;
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.ShortcutsEnabled = false;
            this.txtBusqueda.Size = new System.Drawing.Size(233, 46);
            this.txtBusqueda.TabIndex = 240;
            // 
            // frmVerClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Vistas.Properties.Resources.e;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1146, 703);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lblExistencia);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.lblLimpiarDGV);
            this.Controls.Add(this.txtBusqueda);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVerClientes";
            this.Text = "frmVerClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes_Improvisados.IPESBotonRedondeado btnMenu;
        private LabelTransparente lblExistencia;
        private System.Windows.Forms.DataGridView dgvClientes;
        private Componentes_Improvisados.IPESBotonRedondeado btnBusqueda;
        private System.Windows.Forms.Label lblLimpiarDGV;
        private System.Windows.Forms.TextBox txtBusqueda;
    }
}