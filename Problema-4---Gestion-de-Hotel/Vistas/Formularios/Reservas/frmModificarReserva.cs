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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Logica para Eliminar Reserva
            try
            {
                if (dgvReserva.CurrentRow != null)
                {
                    int idReserva = Convert.ToInt32(dgvReserva.CurrentRow.Cells["Identificador de Reserva"].Value);
                    var reserva = Modelos.Entidades.Reservas_Hotel.ObtenerReservaPorId(idReserva);
                    bool resultado = false;
                    if (reserva != null)
                    {
                        resultado = reserva.EliminarReserva();
                    }
                    if (resultado)
                    {
                        DialogResult = IPES_CDD.Show("Reserva eliminada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MostrarReservas();
                        cbHabitacion.SelectedIndex = -1;
                        cbServicio.SelectedIndex = -1;
                        dtp2.Value = DateTime.Now;
                        txtBusquedaReserva.Clear();
                    }
                    else
                    {
                        DialogResult = IPES_CDD.Show("No se pudo eliminar la reserva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    DialogResult = IPES_CDD.Show("No hay ninguna reserva seleccionada para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                DialogResult = IPES_CDD.Show("Error al eliminar la reserva: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarReserva_Click(object sender, EventArgs e)
        {
            // Logica para Modificar Reserva
            try
            {
                if (dgvReserva.CurrentRow != null)
                {
                    Modelos.Entidades.Reservas_Hotel reserva = new Modelos.Entidades.Reservas_Hotel
                    {
                        IdReserva = Convert.ToInt32(dgvReserva.CurrentRow.Cells["Identificador de Reserva"].Value),
                        IdHabitacion = Convert.ToInt32(cbHabitacion.SelectedValue),
                        IdServicio = Convert.ToInt32(cbServicio.SelectedValue),
                        FechaReserva = dtp2.Value
                    };
                    bool resultado = reserva.ModificarReserva();
                    if (resultado)
                    {
                        DialogResult = IPES_CDD.Show("Reserva modificada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MostrarReservas();
                        cbHabitacion.SelectedIndex = -1;
                        cbServicio.SelectedIndex = -1;
                        dtp2.Value = DateTime.Now;
                        txtBusquedaReserva.Clear();
                    }
                    else
                    {
                        DialogResult = IPES_CDD.Show("No se pudo modificar la reserva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    DialogResult = IPES_CDD.Show("No hay ninguna reserva seleccionada para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                DialogResult = IPES_CDD.Show("Error al modificar la reserva: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblLimpiarDGV2_Click(object sender, EventArgs e)
        {
            txtBusquedaReserva.Clear();
            MostrarReservas();
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
