using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vistas.Formularios.Componentes_Nuevos;
using Vistas.Formularios.Login;
using Vistas.Formularios.Visualizador;
using Vistas.Formularios.Menu;

namespace Vistas.Formularios
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
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

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCorreo.Text) || string.IsNullOrWhiteSpace(txtClave.Text))
            {
                // Muestra un mensaje de advertencia si los campos están vacíos
                DialogResult resultado = IPES_CDD.Show("Por favor, completa todos los campos requeridos para que puedas iniciar sesión.", "Campos Vacios, Por Favor Completalos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtCorreo.Text.Length >= 125)
            {
                errorProvider.SetError(txtCorreo, "Te has excedido del maximo de caracteres (125).");
                return;
            }

            if (txtClave.Text.Length >= 40)
            {
                errorProvider.SetError(txtClave, "Te has excedido del maximo de caracteres (40).");
                return;
            }

            if (!txtCorreo.Text.Contains("@") || !txtCorreo.Text.Contains("."))
            {
                // Muestra un mensaje de error si el correo electrónico no es válido
                errorProvider.SetError(txtCorreo, "El correo electrónico no es válido. Debe contener '@' y '.'");
                return;
            }
            try
            {
                // Intenta iniciar sesión con las credenciales proporcionadas
                Sesion.Iniciar(txtCorreo.Text.Trim(), txtClave.Text.Trim());
            }
            catch (SqlException ex)
            {
                // Muestra un mensaje de error si hay un problema de conexión a la base de datos
                DialogResult resultado = IPES_CDD.Show("Error al conectar con la base de datos: " + ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Sesion usuario = new Sesion();
            if (usuario.VerificarLogin(txtCorreo.Text.Trim(), txtClave.Text.Trim()))
            {
                string nombre = Sesion.UsuarioActivo.Nombre;
                string apellido = Sesion.UsuarioActivo.Apellido;
                // Cargar y mostrar la foto de perfil del usuario
                byte[] imagenBytes = Sesion.UsuarioActivo.FotoPerfil;
                if (imagenBytes != null)
                {
                    // Convertir bytes a Image y asignar al PictureBox
                    pbPerfil.Image = ByteArrayToImage(imagenBytes);
                }
                else
                {
                    // Mostrar imagen por defecto si no hay foto
                    pbPerfil.Image = null;
                }
                //if (Sesion.UsuarioActivo.Genero == "Masculino")
                //{
                //    DialogResult resultado = IPES_CDD.Show($"¡Bienvenido, {nombre} {apellido}!", "Acceso concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else if (Sesion.UsuarioActivo.Genero == "Femenino")
                //{
                //    DialogResult resultado = IPES_CDD.Show($"¡Bienvenida, {nombre} {apellido}!", "Acceso concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                if (Sesion.UsuarioActivo.IdRol == 1 && Sesion.UsuarioActivo.Genero == "Hombre")
                {
                    DialogResult resultado = IPES_CDD.Show($"¡Eres El Administrador del Sistema!\n¡Bienvenido! {nombre} {apellido}", "Acceso concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (Sesion.UsuarioActivo.IdRol == 1 && Sesion.UsuarioActivo.Genero == "Mujer")
                {
                    DialogResult resultado = IPES_CDD.Show($"¡Eres La Administradora del Sistema!\n¡Bienvenida! {nombre} {apellido}", "Acceso concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //Recepcionistas
                if (Sesion.UsuarioActivo.IdRol == 2 && Sesion.UsuarioActivo.Genero == "Hombre")
                {
                    DialogResult resultado = IPES_CDD.Show($"¡Eres El Recepcionista del Sistema!\n¡Bienvenido! {nombre} {apellido}", "Acceso concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (Sesion.UsuarioActivo.IdRol == 2 && Sesion.UsuarioActivo.Genero == "Mujer")
                {
                    DialogResult resultado = IPES_CDD.Show($"¡Eres La Recepcionista del Sistema!\n¡Bienvenida! {nombre} {apellido}", "Acceso concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (Sesion.UsuarioActivo.IdRol == 3 && Sesion.UsuarioActivo.Genero == "Hombre")
                {
                    DialogResult resultado = IPES_CDD.Show($"¡Eres El Gerente del Sistema!\n¡Bienvenido! {nombre} {apellido}", "Acceso concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (Sesion.UsuarioActivo.IdRol == 3 && Sesion.UsuarioActivo.Genero == "Mujer")
                {
                    DialogResult resultado = IPES_CDD.Show($"¡Eres La Gerente del Sistema!\n¡Bienvenida! {nombre} {apellido}", "Acceso concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Console.WriteLine("Inicio de sesión exitoso");
                Console.WriteLine("Llamando al Selector de Opciones");
                if (Sesion.UsuarioActivo.IdRol == 1) 
                {
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
                else if (Sesion.UsuarioActivo.IdRol == 3) 
                {
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
                else if (Sesion.UsuarioActivo.IdRol == 2) 
                {
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

            }
            else
            {
                DialogResult resultado = IPES_CDD.Show("Credenciales incorrectas. Verifica tu email o contraseña.\n¿Olvidastes tu contraseña?\nRecuperala dandole Click al Boton\nOlvidastes la Contraseña", "Acceso Denegado, Credenciales Incorrectas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            frmCrearCuentaAdministrador Inicio = new frmCrearCuentaAdministrador();
            Inicio.TopLevel = false;
            Inicio.FormBorderStyle = FormBorderStyle.None;
            Inicio.Dock = DockStyle.Fill;
            // Cierra el formulario actual y muestra el formulario de inicio de sesión
            frmContenedor principal = Application.OpenForms["frmContenedor"] as frmContenedor;
            if (principal != null)
            {
                principal.pnlContenedor.Controls.Clear();
                principal.pnlContenedor.Controls.Add(Inicio);
                Inicio.Show();
            }
        }

        private void pbOjo1_Click(object sender, EventArgs e)
        {
            // Cambia la visibilidad del campo de contraseña al hacer clic en el icono del ojo
            if (txtClave.UseSystemPasswordChar)
            {
                // Si el campo de contraseña está oculto, mostrarlo
                txtClave.UseSystemPasswordChar = false;
                pbOjo1.Image = Properties.Resources.icons8_visible_96; // Cambia el icono a "ojo abierto"
            }
            else
            {
                // Si el campo de contraseña está visible, ocultarlo
                txtClave.UseSystemPasswordChar = true;
                pbOjo1.Image = Properties.Resources.icons8_invisible_96; // Cambia el icono a "ojo cerrado"
            }
        }
    }
}
