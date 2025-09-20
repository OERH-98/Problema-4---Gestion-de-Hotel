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
using Vistas.Formularios.Extra;
using Vistas.Formularios.Login;
using Vistas.Formularios.Visualizador;

namespace Vistas.Formularios.Menu
{
    public partial class frmMenuOpcionRecepcionista : Form
    {
        public frmMenuOpcionRecepcionista()
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
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            frmAcercaDe acerca = new frmAcercaDe();
            acerca.TopLevel = false;
            acerca.FormBorderStyle = FormBorderStyle.None;
            acerca.Dock = DockStyle.Fill;
            // Nueva Forma de Abrir Formularios
            frmContenedor principal = Application.OpenForms["frmContenedor"] as frmContenedor;
            if (principal != null)
            {
                principal.pnlContenedor.Controls.Clear();
                principal.pnlContenedor.Controls.Add(acerca);
                acerca.Show();
            }
        }

        private void btnCerrarSesión_Click(object sender, EventArgs e)
        {
            DialogResult resultado = IPES_CDD.Show("¿Estás seguro de que deseas cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                // Un if para verificar si hay un usuario activo de lo contrario no hace nada solo redirige al login
                if (Sesion.UsuarioActivo != null)
                {
                    Sesion.Cerrar(); // Cierra la sesión del usuario activo
                }
                Console.WriteLine("Llamando a formulario...");
                frmLogin Inicio = new frmLogin();
                Inicio.TopLevel = false;
                Inicio.FormBorderStyle = FormBorderStyle.None;
                Inicio.Dock = DockStyle.Fill;
                // Nueva Forma de Abrir Formularios
                frmContenedor principal = Application.OpenForms["frmContenedor"] as frmContenedor;
                if (principal != null)
                {
                    principal.pnlContenedor.Controls.Clear();
                    principal.pnlContenedor.Controls.Add(Inicio);
                    Inicio.Show();
                }
                Console.WriteLine("Cierre de Sesión Aprobado");
            }
            else
            {
                // Si el usuario no confirma, no hace nada
                Console.WriteLine("Cierre de Sesión Cancelado");
                return;
            }
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
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000; // Habilita el estilo WS_EX_COMPOSITED para mejorar el rendimiento de redimensionamiento
                return handleparam;
            }
        }

        private void btnFotoPerfil_Click(object sender, EventArgs e)
        {
            frmActualizarPerfil usuarios = new frmActualizarPerfil();
            usuarios.TopLevel = false;
            usuarios.FormBorderStyle = FormBorderStyle.None;
            usuarios.Dock = DockStyle.Fill;
            // Nueva Forma de Abrir Formularios
            frmContenedor principal = Application.OpenForms["frmContenedor"] as frmContenedor;
            if (principal != null)
            {
                principal.pnlContenedor.Controls.Clear();
                principal.pnlContenedor.Controls.Add(usuarios);
                usuarios.Show();
            }
        }

        private void frmMenuOpcionRecepcionista_Load(object sender, EventArgs e)
        {
            tmrHoraActual.Start();         // Inicia reloj en tiempo real
            ActualizarHoraYSaludo();       // Saludo Acorde a la hora actual
        }

        private void tmrHoraActual_Tick(object sender, EventArgs e)
        {
            // Actualiza la hora actual y el saludo cada segundo
            ActualizarHoraYSaludo();
            lblHoraActual.Text = DateTime.Now.ToString("h:mm tt"); // Actualiza la hora actual cada segundo con el even Tick del Timer
        }
    }
}
