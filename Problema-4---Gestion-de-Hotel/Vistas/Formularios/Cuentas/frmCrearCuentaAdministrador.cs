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
using Vistas.Formularios.Visualizador;

namespace Vistas.Formularios.Login
{
    public partial class frmCrearCuentaAdministrador : Form
    {
        public frmCrearCuentaAdministrador()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            // Validación básica
            if (string.IsNullOrWhiteSpace(txtNombreUsuario.Text) || (string.IsNullOrWhiteSpace(txtNombre.Text) || (string.IsNullOrWhiteSpace(txtApellido.Text) || string.IsNullOrWhiteSpace(txtEmailUNIQUE.Text) || string.IsNullOrWhiteSpace(txtCiudad.Text) || string.IsNullOrWhiteSpace(msktxtTelefono.Text) || string.IsNullOrWhiteSpace(txtClave.Text) || string.IsNullOrWhiteSpace(txtConfirmarClave.Text))))
            {
                // Si alguno de los campos está vacío, mostrar un mensaje de error
                DialogResult resultado = IPES_CDD.Show("Por favor, completa todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtNombreUsuario.Text.Length >= 15)
            {
                errorProvider.SetError(txtNombreUsuario, "Te has excedido del maximo de caracteres del Nombre de Usuario, 15 caracteres es el maximo.");
                return;
            }

            if (txtNombre.Text.Length >= 40)
            {
                errorProvider.SetError(txtNombre, "Te has excedido del maximo de caracteres del Nombre, 40 caracteres es el maximo.");
                return;
            }

            else if (txtNombre.Text.Any(char.IsDigit))
            {
                errorProvider.SetError(txtNombre, "No se permiten números en el nombre.");
                return;
            }

            if (txtApellido.Text.Length >= 40)
            {
                errorProvider.SetError(txtApellido, "Te has excedido del maximo de caracteres del Apellido, 40 caracteres es el maximo.");
                return;
            }

            else if (txtApellido.Text.Any(char.IsDigit))
            {
                errorProvider.SetError(txtApellido, "No se permiten números en el apellido.");
                return;
            }

            if (txtEmailUNIQUE.Text.Length >= 125)
            {
                errorProvider.SetError(txtEmailUNIQUE, "Te has excedido del maximo de caracteres del Correo Electronico, 125 caracteres es el maximo.");
                return;
            }

            if (txtCiudad.Text.Length >= 100)
            {
                errorProvider.SetError(txtCiudad, "Te has excedido del maximo de caracteres de la Ciudad, 100 caracteres es el maximo.");
                return;
            }

            if (txtClave.Text.Length >= 40)
            {
                errorProvider.SetError(txtClave, "Te has excedido del maximo de caracteres de la Contraseña, 40 caracteres es el maximo.");
                return;
            }

            if (txtConfirmarClave.Text.Length >= 40)
            {
                errorProvider.SetError(txtConfirmarClave, "Te has excedido del maximo de caracteres de la Confirmación de Contraseña, 40 caracteres es el maximo.");
                return;
            }

            if (txtLaborador.Text.Length >= 125)
            {
                errorProvider.SetError(txtLaborador, "Te has excedido del maximo de caracteres del Laborador.");
                return;
            }

            else if (msktxtTelefono.Text.Any(char.IsLetter))
            {
                errorProvider.SetError(msktxtTelefono, "Solo se permiten números.");
                return;
            }

            if (!txtEmailUNIQUE.Text.Contains("@") || !txtEmailUNIQUE.Text.Contains("."))
            {
                // Muestra un mensaje de error si el correo electrónico no es válido
                errorProvider.SetError(txtEmailUNIQUE, "El correo electrónico no es válido. Debe contener '@' y '.'");
                return;
            }

            else if (string.IsNullOrWhiteSpace(txtCiudad.Text) || string.IsNullOrWhiteSpace(msktxtTelefono.Text))
            {
                // Si los campos de ciudad o teléfono están vacíos, mostrar un mensaje de error
                DialogResult resultado = IPES_CDD.Show("Por favor, completa los campos de Ciudad o Teléfono.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtNombreUsuario.Text))
            {
                // Si el campo de nombre de usuario está vacío, mostrar un mensaje de error
                errorProvider.SetError(txtNombreUsuario, "El campo Nombre de Usuario no puede estar vacío.");
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                // Si el campo de nombre está vacío, mostrar un mensaje de error
                errorProvider.SetError(txtNombre, "El campo Nombre no puede estar vacío.");
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                // Si el campo de apellido está vacío, mostrar un mensaje de error
                errorProvider.SetError(txtApellido, "El campo Apellido no puede estar vacío.");
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtEmailUNIQUE.Text))
            {
                // Si el campo de correo electrónico está vacío, mostrar un mensaje de error
                errorProvider.SetError(txtEmailUNIQUE, "El campo Correo Electrónico no puede estar vacío.");
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtClave.Text))
            {
                //Si el campo de contraseña está vacío, mostrar un mensaje de error
                errorProvider.SetError(txtClave, "El campo Contraseña no puede estar vacío.");
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtConfirmarClave.Text))
            {
                // Si el campo de confirmación de contraseña está vacío, mostrar un mensaje de error
                errorProvider.SetError(txtConfirmarClave, "El campo Confirmar Contraseña no puede estar vacío.");
                return;
            }

            if (txtClave.Text != txtConfirmarClave.Text)
            {
                // Si las contraseñas no coinciden, mostrar un mensaje de error
                errorProvider.SetError(txtConfirmarClave, "Las contraseñas no coinciden.");
                return;
            }
            if (txtClave.TextLength < 8)
            {
                // Si la contraseña es demasiado corta, mostrar un mensaje de error
                errorProvider.SetError(txtClave, "La contraseña debe tener al menos 8 caracteres.");
                return;
            }
            if (txtLaborador.Text != "2025C112.25-2B")
            {
                // Si el campo de laborador no es "Administrador", mostrar un mensaje de error
                errorProvider.SetError(txtLaborador, "El campo Laborador es incorrecto, No puedes crearte tu Cuenta de administrador\\nTu empresa debe de proporcionarte \" +\n\"Una clave unica para crear esta cuenta\\nde lo contrario el administrador existente te añadira como empleado.");
                return;
            }
            if (!rbtnHombre.Checked && !rbtnMujer.Checked)
            {
                DialogResult = IPES_CDD.Show("Debes de Seleccionar al menos un Genero", "Selecciona un Genero", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (dtp1.Value >= DateTime.Now)
            {
                errorProvider.SetError(dtp1, "La fecha de nacimiento no puede ser en el futuro.");
                return;
            }
            if (dtp1.Value <= DateTime.Now.AddYears(-100))
            {
                errorProvider.SetError(dtp1, "La fecha de nacimiento no puede ser mayor a 100 años.");
                return;
            }
            if (dtp1.Value >= DateTime.Now.AddYears(-18))
            {
                errorProvider.SetError(dtp1, "El empleado debe ser mayor de 18 años.");
                return;
            }
            if (dtp1.Value == null)
            {
                errorProvider.SetError(dtp1, "Por favor, selecciona una fecha de nacimiento.");
                return;
            }

            // Intentar registrar al nuevo administrador
            try
            {
                Registrar_Usuarios administrador = new Registrar_Usuarios();
                administrador.NombreSistemaUsuario = txtNombreUsuario.Text;
                administrador.Nombre = txtNombre.Text;
                administrador.Apellido = txtApellido.Text;
                administrador.CorreoElectronico = txtEmailUNIQUE.Text;
                administrador.Direccion = txtCiudad.Text;
                administrador.NumeroTelefono = msktxtTelefono.Text;
                administrador.Clave= BCrypt.Net.BCrypt.HashPassword(txtClave.Text);
                administrador.IdRol = 1; // Asignar el rol de administrador
                administrador.Genero = ObtenerGeneroSeleccionado();
                administrador.FechaCumpleanios = dtp1.Value;
                if (imagenBytes != null)
                {
                    administrador.FotoPerfil = imagenBytes;
                }
                else
                {
                    administrador.FotoPerfil = null;
                }

                if (administrador.RegistrarAdministrador())
                {
                    if (rbtnHombre.Checked)
                    {
                        DialogResult resultado = IPES_CDD.Show("Administrador registrado exitosamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (rbtnMujer.Checked)
                    {
                        DialogResult resultado = IPES_CDD.Show("Administradora registrada exitosamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    Console.WriteLine("Llamando al Login");
                    frmLogin Inicio = new frmLogin();
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
                else
                {
                    DialogResult resultado = IPES_CDD.Show("Error al registrar el administrador. Por favor, inténtalo de nuevo.", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                DialogResult resultado = IPES_CDD.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        // Agregamos este campo a nivel de clase para almacenar los bytes de la imagen
        private byte[] imagenBytes;

        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            // Mostrar el diálogo para seleccionar archivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Cargar la imagen en el PictureBox
                    pbFotoPerfil.Image = Image.FromFile(openFileDialog.FileName);

                    // Opcional: Redimensionar la imagen si es muy grande
                    RedimensionarImagenSiEsNecesario();

                    // Convertir la imagen a bytes para la base de datos
                    imagenBytes = ImageToByteArray(pbFotoPerfil.Image);

                    Console.WriteLine("Foto de perfil cargada exitosamente!!: " + openFileDialog.FileName);
                    Console.WriteLine("Tamaño en bytes: " + (imagenBytes?.Length ?? 0) + " bytes");

                    // Opcional: Mostrar mensaje de éxito
                    DialogResult = IPES_CDD.Show("Imagen cargada correctamente. Ya esta lista para subirse a la base de datos.",
                                  "Imágen Cargada con Exito!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    DialogResult = IPES_CDD.Show("Error al cargar la imagen, por favor inténtalo de nuevo: " + ex.Message, "Error FATAL",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Método para convertir Image a byte[]
        private byte[] ImageToByteArray(Image image)
        {
            if (image == null) return null;

            using (MemoryStream ms = new MemoryStream())
            {
                //Convertir Imagen a PNG
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void RedimensionarImagenSiEsNecesario()
        {
            if (pbFotoPerfil.Image != null)
            {
                // Si la imagen es muy grande, redimensionarla
                if (pbFotoPerfil.Image.Width > 400 || pbFotoPerfil.Image.Height > 400)
                {
                    int nuevoAncho = 400;
                    int nuevoAlto = 400;

                    // Mantener la relación de aspecto
                    if (pbFotoPerfil.Image.Width > pbFotoPerfil.Image.Height)
                    {
                        nuevoAlto = (int)((double)pbFotoPerfil.Image.Height / pbFotoPerfil.Image.Width * nuevoAncho);
                    }
                    else
                    {
                        nuevoAncho = (int)((double)pbFotoPerfil.Image.Width / pbFotoPerfil.Image.Height * nuevoAlto);
                    }

                    Bitmap imagenRedimensionada = new Bitmap(nuevoAncho, nuevoAlto);
                    using (Graphics g = Graphics.FromImage(imagenRedimensionada))
                    {
                        g.DrawImage(pbFotoPerfil.Image, 0, 0, nuevoAncho, nuevoAlto);
                    }

                    pbFotoPerfil.Image = imagenRedimensionada;
                }
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

        private void rbtnHombre_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnHombre.Checked)
            {
                Console.WriteLine("Genero seleccionado: Hombre");
            }
            else if (rbtnMujer.Checked)
            {
                Console.WriteLine("Genero seleccionado: Mujer");
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
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000; // Habilita el estilo WS_EX_COMPOSITED para mejorar el rendimiento de redimensionamiento
                return handleparam;
            }
        }
        private void pbOjo2_Click(object sender, EventArgs e)
        {
            // Cambia la visibilidad del campo de contraseña al hacer clic en el icono del ojo
            if (txtConfirmarClave.UseSystemPasswordChar)
            {
                // Si el campo de contraseña está oculto, mostrarlo
                txtConfirmarClave.UseSystemPasswordChar = false;
                pbOjo2.Image = Properties.Resources.icons8_visible_96; // Cambia el icono a "ojo abierto"
            }
            else
            {
                // Si el campo de contraseña está visible, ocultarlo
                txtConfirmarClave.UseSystemPasswordChar = true;
                pbOjo2.Image = Properties.Resources.icons8_invisible_96; // Cambia el icono a "ojo cerrado"
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
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
        }
    }
}
