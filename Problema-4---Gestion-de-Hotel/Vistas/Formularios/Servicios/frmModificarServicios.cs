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

namespace Vistas.Formularios.Servicios
{
    public partial class frmModificarServicios : Form
    {
        public frmModificarServicios()
        {
            InitializeComponent();
            MostrarServiciosExistentes();
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
        private void MostrarServiciosExistentes()
        {
            try
            {
                dgvServicios.DataSource = null;
                dgvServicios.DataSource = ServiciosHotel.CargarServicios();
            }
            catch (Exception ex)
            {
                DialogResult = IPES_CDD.Show("Error al cargar servicios: " + ex.Message, "Error Fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }   

        private void dgvServicios_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvServicios != null)
                {
                    txtServicio.Text = dgvServicios.CurrentRow.Cells["Definicion del servicio"].Value.ToString();
                    txtDescripcion.Text = dgvServicios.CurrentRow.Cells["Descripción"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                DialogResult = IPES_CDD.Show("Error al cargar datos del servicio: " + ex.Message, "Error Fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvServicios.DataSource = null;
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
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ServiciosHotel servicio = new ServiciosHotel();
            try
            {
                var confirmResult = DialogResult = IPES_CDD.Show("¿Estás seguro de eliminar este gerente?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    var fila = dgvServicios.SelectedRows[0];
                    var numero = fila.Cells["Número de Servicio"].Value.ToString();
                    ServiciosHotel servicios = new ServiciosHotel();
                    servicio.IdServicio = int.Parse(numero);
                    if (servicio.EliminarServicio())
                    {
                        DialogResult = IPES_CDD.Show("Servicio eliminado exitosamente.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MostrarServiciosExistentes();
                        txtDescripcion.Clear();
                        txtServicio.Clear();
                        txtBusqueda.Clear();
                    }
                    else
                    {
                        DialogResult = IPES_CDD.Show("Error al eliminar el servicio. Por favor, inténtalo de nuevo.", "Error de Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                DialogResult = IPES_CDD.Show("Error al eliminar el servicio: " + ex.Message, "Error Fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtServicio.Text.Trim()))
            {
                errorProvider.SetError(txtServicio, "El nombre del servicio no puede estar vacío.");
                return;
            }
            if (string.IsNullOrEmpty(txtDescripcion.Text.Trim()))
            {
                errorProvider.SetError(txtDescripcion, "La descripción del servicio no puede estar vacía.");
                return;
            }
            ServiciosHotel servicio = new ServiciosHotel();
            try
            {
                var fila = dgvServicios.SelectedRows[0];
                var numero = fila.Cells["Número de Servicio"].Value.ToString();
                servicio.IdServicio = int.Parse(numero);
                servicio.NombreServicio = txtServicio.Text.Trim();
                servicio.DescripcionServicio = txtDescripcion.Text.Trim();
                if (servicio.ModificarServicio())
                {
                    DialogResult = IPES_CDD.Show("Servicio modificado exitosamente.", "Modificación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarServiciosExistentes();
                }
                else
                {
                    DialogResult = IPES_CDD.Show("Error al modificar el servicio. Por favor, inténtalo de nuevo.", "Error de Modificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                DialogResult = IPES_CDD.Show("Error al modificar el servicio: " + ex.Message, "Error Fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            string nombre = txtBusqueda.Text.Trim();
            if (string.IsNullOrEmpty(nombre))
            {
                errorProvider.SetError(txtBusqueda, "Por favor ingrese un nombre de un servicio para comenzar.");
                return;
            }
            try
            {
                // Buscar en Gerentes
                var resultadosGerente = ServiciosHotel.BuscarServicio(nombre);
                if (resultadosGerente != null && resultadosGerente.Rows.Count > 0)
                {
                    dgvServicios.DataSource = resultadosGerente;
                }
                else
                {
                    errorProvider.SetError(txtBusqueda, "No se encontraron resultados en Servicios.");
                    dgvServicios.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                errorProvider.SetError(txtBusqueda, "Error al buscar El Servicio: " + ex.Message);
            }
        }
    }
}
