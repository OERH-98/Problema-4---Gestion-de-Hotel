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

namespace Vistas.Formularios.Login
{
    public partial class frmActualizarPerfil : Form
    {
        public frmActualizarPerfil()
        {
            InitializeComponent();
            if (Sesion.UsuarioActivo != null)
            {
                byte[] imagenBytes = Sesion.UsuarioActivo.FotoPerfil;
                if (imagenBytes != null)
                {
                    // Convertir bytes a Image y asignar al PictureBox
                    pbFotoPerfilActual.Image = ByteArrayToImage(imagenBytes);
                }
                else
                {
                    // Mostrar imagen por defecto si no hay foto
                    pbFotoPerfilActual.Image = null;
                }
            }
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
                    pbFotoPerfilNueva.Image = Image.FromFile(openFileDialog.FileName);

                    // Opcional: Redimensionar la imagen si es muy grande
                    RedimensionarImagenSiEsNecesario();

                    // Convertir la imagen a bytes para la base de datos
                    imagenBytes = ImageToByteArray(pbFotoPerfilNueva.Image);

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
            if (pbFotoPerfilNueva.Image != null)
            {
                // Si la imagen es muy grande, redimensionarla
                if (pbFotoPerfilNueva.Image.Width > 400 || pbFotoPerfilNueva.Image.Height > 400)
                {
                    int nuevoAncho = 400;
                    int nuevoAlto = 400;

                    // Mantener la relación de aspecto
                    if (pbFotoPerfilNueva.Image.Width > pbFotoPerfilNueva.Image.Height)
                    {
                        nuevoAlto = (int)((double)pbFotoPerfilNueva.Image.Height / pbFotoPerfilNueva.Image.Width * nuevoAncho);
                    }
                    else
                    {
                        nuevoAncho = (int)((double)pbFotoPerfilNueva.Image.Width / pbFotoPerfilNueva.Image.Height * nuevoAlto);
                    }

                    Bitmap imagenRedimensionada = new Bitmap(nuevoAncho, nuevoAlto);
                    using (Graphics g = Graphics.FromImage(imagenRedimensionada))
                    {
                        g.DrawImage(pbFotoPerfilNueva.Image, 0, 0, nuevoAncho, nuevoAlto);
                    }

                    pbFotoPerfilNueva.Image = imagenRedimensionada;
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Empleadores modificaciones = new Empleadores();

            if (Sesion.UsuarioActivo.FotoPerfil == null && imagenBytes == null)
            {
                DialogResult = IPES_CDD.Show("No has seleccionado ninguna imagen para actualizar tu foto de perfil. Por favor, selecciona una imagen antes de continuar.",
                              "Ninguna Imagen Seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                modificaciones.CorreoElectronico = Sesion.UsuarioActivo.CorreoElectronico;
                modificaciones.FotoPerfil = imagenBytes;

                bool exito = modificaciones.ModificarFotoPerfil();

                DialogResult = IPES_CDD.Show(exito ? "Imagen actualizada correctamente en la base de datos // Se actualizara la foto la proxima vez que inicies sesión" : "No se pudo actualizar la imagen en la base de datos.",
                                exito ? "Actualización Exitosa" : "Error // FATAL", MessageBoxButtons.OK, exito ? MessageBoxIcon.Information : MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                DialogResult = IPES_CDD.Show("Error al actualizar la imagen en la base de datos: " + ex.Message, "Error Fatal",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
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
