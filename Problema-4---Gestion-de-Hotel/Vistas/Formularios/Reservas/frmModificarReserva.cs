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

namespace Vistas.Formularios.Reservas
{
    public partial class frmModificarReserva : Form
    {
        public frmModificarReserva()
        {
            InitializeComponent();
            MostrarReservas();
            MostrarHabitacionesDisponibles();
            MostrarServiciosDisponibles();
        }

        private void MostrarHabitacionesDisponibles()
        {
            try
            {
                cbHabitacion.DataSource = Habitaciones.CargarHabitaciones();
                cbHabitacion.DisplayMember = "numeroHabitacion"; // lo que uno ve
                cbHabitacion.ValueMember = "idHabitacion";       // el valor que entiende Windows Forms Supongo?
                cbHabitacion.SelectedIndex = -1; // Para que no seleccione nada al inicio
            }
            catch (Exception ex)
            {
                DialogResult = IPES_CDD.Show("Error al cargar habitaciones: " + ex.Message, "Error Fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void MostrarServiciosDisponibles()
        {
            try
            {
                cbServicio.DataSource = ServiciosHotel.CargarServiciosComboBox();
                cbServicio.DisplayMember = "nombreServicio"; // lo que uno ve
                cbServicio.ValueMember = "idServicio";           // el valor que entiende Windows Forms Supongo?
                cbServicio.SelectedIndex = -1; // Para que no seleccione nada al inicio
            }
            catch (Exception ex)
            {
                DialogResult = IPES_CDD.Show("Error al cargar servicios: " + ex.Message, "Error Fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void dgvReserva_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvReserva != null)
                {
                    cbHabitacion.SelectedValue = Convert.ToInt32(dgvReserva.CurrentRow.Cells["Identificador de Habitacion"].Value);
                    cbServicio.SelectedValue = Convert.ToInt32(dgvReserva.CurrentRow.Cells["Numero de Servicio"].Value);
                    dtp2.Value = Convert.ToDateTime(dgvReserva.CurrentRow.Cells["Fecha de Reserva"].Value);
                }
            }
            catch (Exception)
            {
                DialogResult = IPES_CDD.Show("Error al cargar los datos de la reserva seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvReserva.DataSource = null;
            }
            
        }
    }
}
