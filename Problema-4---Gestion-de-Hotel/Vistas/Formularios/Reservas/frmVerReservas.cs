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
    }
}
