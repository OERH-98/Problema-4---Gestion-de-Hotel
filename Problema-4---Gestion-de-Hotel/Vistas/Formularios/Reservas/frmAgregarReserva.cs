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
using Vistas.Formularios.Menu;
using Vistas.Formularios.Visualizador;
using Vistas.Formularios.Componentes_Nuevos;
using Vistas.Formularios.Clientes;

namespace Vistas.Formularios.Reservas
{
    public partial class frmAgregarReserva : Form
    {
        public frmAgregarReserva()
        {
            InitializeComponent();
            MostrarHabitacionesDisponibles();
            MostrarServiciosDisponibles();
            MostrarClientes();
        }

        private void MostrarClientes()
        {
            try
            {
                dgvClientes.DataSource = ClientesHotel.CargarClientes();
            }
            catch (Exception ex)
            {
                DialogResult = IPES_CDD.Show("Error al cargar los clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        private int clienteIdActual = 0; // Variable para almacenar el ID   
        private void dgvClientes_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                ClientesHotel dgv = new ClientesHotel();
                if (dgvClientes != null)
                {
                    clienteIdActual = Convert.ToInt32(dgvClientes.CurrentRow.Cells["Numero de Cliente"].Value);
                    dgv.IdCliente = clienteIdActual;
                    txtNombre.Text = dgvClientes.CurrentRow.Cells["Nombre"].Value.ToString();
                    txtApellido.Text = dgvClientes.CurrentRow.Cells["Apellido"].Value.ToString();
                    msktxtTelefono.Text = dgvClientes.CurrentRow.Cells["Telefono"].Value.ToString();
                    txtCiudad.Text = dgvClientes.CurrentRow.Cells["Direccion"].Value.ToString();
                    dtp1.Value = Convert.ToDateTime(dgvClientes.CurrentRow.Cells["Fecha de Nacimiento"].Value);
                    msktxtDui.Text = dgvClientes.CurrentRow.Cells["Dui"].Value.ToString();
                    rbtnHombre.Checked = dgvClientes.CurrentRow.Cells["Genero"].Value.ToString() == "Hombre";
                    rbtnMujer.Checked = dgvClientes.CurrentRow.Cells["Genero"].Value.ToString() == "Mujer";
                }
            }
            catch (Exception ex)
            {
                DialogResult = IPES_CDD.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            frmInsertarCliente agregar = new frmInsertarCliente();
            agregar.TopLevel = false;
            agregar.FormBorderStyle = FormBorderStyle.None;
            agregar.Dock = DockStyle.Fill;
            frmContenedor principal = Application.OpenForms["frmContenedor"] as frmContenedor;
            if (principal != null)
            {
                principal.pnlContenedor.Controls.Clear();
                principal.pnlContenedor.Controls.Add(agregar);
                agregar.Show();
            }
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            //Busqueda por Nombre o Apellido
            try
            {
                string criterioBusqueda = txtBusqueda.Text.Trim();
                if (!string.IsNullOrEmpty(criterioBusqueda))
                {
                    dgvClientes.DataSource = ClientesHotel.BuscarCliente(criterioBusqueda);
                }
                else
                {
                    IPES_CDD.Show("Por favor, ingrese un criterio de búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                DialogResult = IPES_CDD.Show("Error al buscar clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblLimpiarDGV_Click(object sender, EventArgs e)
        {
            txtBusqueda.Clear();
            MostrarClientes();
        }

        private void btnRealizarReserva_Click(object sender, EventArgs e)
        {
            if  (clienteIdActual == 0 ||
                cbHabitacion.SelectedIndex == -1 ||
                cbServicio.SelectedIndex == -1)
            {
                DialogResult = IPES_CDD.Show("Por favor, complete todos los campos obligatorios y asegúrese de que las fechas sean válidas.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Reservas_Hotel nuevaReserva = new Reservas_Hotel();
                nuevaReserva.IdCliente = clienteIdActual;
                nuevaReserva.IdHabitacion = (int)cbHabitacion.SelectedValue;
                nuevaReserva.IdServicio = (int)cbServicio.SelectedValue;
                nuevaReserva.IdUsuario = Sesion.UsuarioActivo.IdUsuario;


                if (nuevaReserva.InsertarReserva())
                {
                    DialogResult = IPES_CDD.Show("Reserva realizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult = IPES_CDD.Show("Error al realizar la reserva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            catch (Exception ex)
            {
                DialogResult = IPES_CDD.Show("Error: " + ex.Message, "Error Fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
