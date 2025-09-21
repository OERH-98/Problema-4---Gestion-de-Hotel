using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vistas.Formularios.Componentes_Nuevos;
using Vistas.Formularios.Menu;
using Vistas.Formularios.Visualizador;

namespace Vistas.Formularios.Clientes
{
    public partial class frmModificarCliente : Form
    {
        public frmModificarCliente()
        {
            InitializeComponent();
            MostrarClientes();
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
        private void MostrarClientes()
        {
            ClientesHotel cliente = new ClientesHotel();
            try
            {
                dgvClientes.DataSource = null; // Limpiar el DataSource antes de asignar uno nuevo
                dgvClientes.DataSource = ClientesHotel.CargarClientes();
            }
            catch (Exception ex)
            {
                DialogResult = IPES_CDD.Show("Error al cargar los clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvClientes.DataSource = null;
            }
        }

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

        private void btnMenu_Click_1(object sender, EventArgs e)
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

        private string ObtenerGeneroSeleccionado()
        {
            if (rbtnHombre.Checked)
                return "Hombre";
            else if (rbtnMujer.Checked)
                return "Mujer";
            else
                return string.Empty; // o un valor por defecto
        }

        private int clienteIdActual = 0; // Variable para almacenar el ID   

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (clienteIdActual == 0)
            {
                IPES_CDD.Show("No hay cliente seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                ClientesHotel clientela = new ClientesHotel();
                clientela.IdCliente = clienteIdActual; // Usar el ID almacenado
                clientela.NombreCliente = txtNombre.Text;
                clientela.ApellidoCliente = txtApellido.Text;
                clientela.DireccionCliente = txtCiudad.Text;
                clientela.NumeroTelefono = msktxtTelefono.Text;
                clientela.Genero = ObtenerGeneroSeleccionado();
                clientela.DUI = msktxtDui.Text;
                clientela.FechaCumpleanios = dtp1.Value;
                if (clientela.ModificarCliente())
                {
                    DialogResult = IPES_CDD.Show("Cliente modificado con éxito", "Modificación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Clear();
                    txtApellido.Clear();
                    txtCiudad.Clear();
                    msktxtTelefono.Clear();
                    msktxtDui.Clear();
                    dtp1.Value = DateTime.Now;
                    MostrarClientes();
                    rbtnMujer.Checked = false;
                    rbtnHombre.Checked = false;
                    clienteIdActual = 0; // Reiniciar el ID después de la modificación
                }
                else
                {
                    DialogResult = IPES_CDD.Show("No se pudo modificar el cliente. Inténtelo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                DialogResult = IPES_CDD.Show("Error al modificar cliente: " + ex.Message, "Error Fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void lblLimpiarDGV_Click(object sender, EventArgs e)
        {
            MostrarClientes();
            txtBusqueda.Clear();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Eliminacion del Cliente
            if (clienteIdActual == 0)
            {
                IPES_CDD.Show("No hay cliente seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtBusqueda.Clear();
            try
            {
                ClientesHotel eliminarCliente = new ClientesHotel();
                eliminarCliente.IdCliente = clienteIdActual; // Usar el ID almacenado
                DialogResult confirmacion = IPES_CDD.Show("¿Estás seguro de que deseas eliminar este cliente?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmacion == DialogResult.Yes)
                {
                    if (eliminarCliente.EliminarCliente())
                    {
                        IPES_CDD.Show("Cliente eliminado con éxito", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNombre.Clear();
                        txtApellido.Clear();
                        txtCiudad.Clear();
                        msktxtTelefono.Clear();
                        msktxtDui.Clear();
                        dtp1.Value = DateTime.Now;
                        MostrarClientes();
                        rbtnHombre.Checked = false;
                        rbtnMujer.Checked = false;
                        clienteIdActual = 0; // Reiniciar el ID después de la eliminación
                    }
                    else
                    {
                        IPES_CDD.Show("No se pudo eliminar el cliente. Inténtelo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                DialogResult = IPES_CDD.Show("Error al eliminar cliente: " + ex.Message, "Error Fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblHombre_Click(object sender, EventArgs e)
        {
            rbtnHombre.Checked = true;
        }

        private void lblMujer_Click(object sender, EventArgs e)
        {
            rbtnMujer.Checked = true;
        }
    }
}
