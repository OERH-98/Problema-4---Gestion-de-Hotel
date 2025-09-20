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
    public partial class frmVerServicios : Form
    {
        public frmVerServicios()
        {
            InitializeComponent();
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
                dgvServicios.DataSource = null;
            }
        }
        private void lblLimpiarDGV_Click(object sender, EventArgs e)
        {
            txtBusqueda.Clear();
            MostrarServiciosExistentes();
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
