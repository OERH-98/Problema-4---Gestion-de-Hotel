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

namespace Vistas.Formularios.Servicios
{
    public partial class frmAgregarServicios : Form
    {
        public frmAgregarServicios()
        {
            InitializeComponent();
            lblNombreSistemaUsuario.Text = Sesion.UsuarioActivo.NombreSistemaUsuario;
            byte[] imagenBytes = Sesion.UsuarioActivo.FotoPerfil;
            if (imagenBytes != null)
            {
                // Convertir bytes a Image y asignar al PictureBox
                pbFotoUsuario.Image = ByteArrayToImage(imagenBytes);
            }
            else
            {
                // Mostrar imagen por defecto si no hay foto
                pbFotoUsuario.Image = null;
            }
            MostrarServiciosExistentes();
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

        private void frmAgregarServicios_Load(object sender, EventArgs e)
        {
            tmrHoraActual.Start();         // Inicia reloj en tiempo real
            ActualizarHoraYSaludo();       // Saludo Acorde a la hora actual
        }
        private Image ByteArrayToImage(byte[] byteArray)
        {
            if (byteArray == null || byteArray.Length == 0)
                return null;

            try
            {
                using (MemoryStream ms = new MemoryStream(byteArray))
                {
                    return Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                DialogResult = IPES_CDD.Show("Error al convertir imagen: " + ex.Message, "Error Fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void ActualizarHoraYSaludo()
        {
            //Obtene la hora actual y determina el saludo adecuado
            DateTime horaActual = DateTime.Now;
            //Declaramos la variable de saludo
            string saludo;
            //Si la hora es menor a 12 es de mañana ya que me inspire en el formato 24 horas
            if (horaActual.Hour < 12)
            {
                saludo = "¡Buenos días!";
            }
            //Si la hora es mayor a 12 y menor a 18 es de tarde
            else if (horaActual.Hour < 18)
            {
                saludo = "¡Buenas tardes!";
            }
            // De lo contrario un default para ser sincero es de noche o lo que c# quiera interpretar
            else
            {
                saludo = "¡Buenas noches!";
            }
            lblTiempo.Text = saludo; // Actualiza el label con el saludo correspondiente
        }

        private void tmrHoraActual_Tick(object sender, EventArgs e)
        {
            // Actualiza la hora actual y el saludo cada segundo
            ActualizarHoraYSaludo();
            lblHoraActual.Text = DateTime.Now.ToString("h:mm tt"); // Actualiza la hora actual cada segundo con el even Tick del Timer
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                ServiciosHotel servicio = new ServiciosHotel();

                servicio.NombreServicio = txtServicio.Text;
                servicio.DescripcionServicio = txtDescripcion.Text;


                if (servicio.InsertarServicio())
                {
                    DialogResult = IPES_CDD.Show("Servicio registrado exitosamente!!", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtServicio.Clear();
                    txtDescripcion.Clear();
                }
                else
                {
                    DialogResult = IPES_CDD.Show("No se pudo registrar el servicio, intente nuevamente.", "Error al Registrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                DialogResult = IPES_CDD.Show("Error: " + ex.Message, "Error Fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void lblLimpiarDGV_Click(object sender, EventArgs e)
        {
            txtBusqueda.Clear();
            MostrarServiciosExistentes();
        }
    }
    }

