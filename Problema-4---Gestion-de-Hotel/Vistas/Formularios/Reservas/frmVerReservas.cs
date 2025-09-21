using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vistas.Formularios.Componentes_Nuevos;
using Vistas.Formularios.Menu;
using Vistas.Formularios.Visualizador;

namespace Vistas.Formularios.Reservas
{
    public partial class frmVerReservas : Form
    {
        public frmVerReservas()
        {
            InitializeComponent();
            MostrarReservas();
        }

        private void lblLimpiarDGV2_Click(object sender, EventArgs e)
        {
            txtBusquedaReserva.Clear();
            MostrarReservas();

        }
        private void MostrarReservas()
        {
            try
            {
                dgvReserva.DataSource = null;
                dgvReserva.DataSource = Modelos.Entidades.Reservas_Hotel.CargarReservas();
            }
            catch (Exception ex)
            {
                DialogResult = IPES_CDD.Show("Error al cargar las reservas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvReserva.DataSource = null;
            }
        }
        private void btnBuscarReserva_Click(object sender, EventArgs e)
        {
            //Logica para Buscar Reserva
            try
            {
                string criterioBusqueda = txtBusquedaReserva.Text.Trim();
                if (!string.IsNullOrEmpty(criterioBusqueda))
                {
                    dgvReserva.DataSource = Modelos.Entidades.Reservas_Hotel.BuscarReserva(criterioBusqueda);
                }
                else
                {
                    DialogResult = IPES_CDD.Show("Por favor, ingrese un criterio de búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                DialogResult = IPES_CDD.Show("Error al buscar la reserva: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000; // Habilita el estilo WS_EX_COMPOSITED para mejorar el rendimiento de redimensionamiento
                return handleparam;
            }
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (Sesion.UsuarioActivo.IdRol == 1) // Administrador
            {
                Console.WriteLine("Llamando al Selector de Opciones");
                frmMenuOpcionAdministrador opciones = new frmMenuOpcionAdministrador();
                opciones.TopLevel = false;
                opciones.FormBorderStyle = FormBorderStyle.None;
                opciones.Dock = DockStyle.Fill;

                frmContenedor principal = Application.OpenForms["frmContenedor"] as frmContenedor;
                if (principal != null)
                {
                    principal.pnlContenedor.Controls.Clear();
                    principal.pnlContenedor.Controls.Add(opciones);
                    opciones.Show();
                }
            }
            else if (Sesion.UsuarioActivo.IdRol == 2) // Recepcionista
            {
                Console.WriteLine("Llamando al Selector de Opciones");
                frmMenuOpcionRecepcionista opciones = new frmMenuOpcionRecepcionista();
                opciones.TopLevel = false;
                opciones.FormBorderStyle = FormBorderStyle.None;
                opciones.Dock = DockStyle.Fill;

                frmContenedor principal = Application.OpenForms["frmContenedor"] as frmContenedor;
                if (principal != null)
                {
                    principal.pnlContenedor.Controls.Clear();
                    principal.pnlContenedor.Controls.Add(opciones);
                    opciones.Show();
                }
            }
            else if (Sesion.UsuarioActivo.IdRol == 3) // Gerente
            {
                Console.WriteLine("Llamando al Selector de Opciones");
                frmMenuOpcionGerente opciones = new frmMenuOpcionGerente();
                opciones.TopLevel = false;
                opciones.FormBorderStyle = FormBorderStyle.None;
                opciones.Dock = DockStyle.Fill;

                frmContenedor principal = Application.OpenForms["frmContenedor"] as frmContenedor;
                if (principal != null)
                {
                    principal.pnlContenedor.Controls.Clear();
                    principal.pnlContenedor.Controls.Add(opciones);
                    opciones.Show();
                }
            }
        }
    }
}
