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

namespace Vistas.Formularios.Usuarios
{
    public partial class frmModificarUsuarios : Form
    {
        public frmModificarUsuarios()
        {
            InitializeComponent();
            MostrarGerentes();
            MostrarRecepcionistas();
            CargarRoles();
        }
        private void CargarRoles()
        {
            try
            {
                cbRol.DataSource = Roles.CargarRoles();
                cbRol.DisplayMember = "nombreRol"; // lo que uno ve
                cbRol.ValueMember = "idRol";       // el valor que entiende Windows Forms Supongo?
                cbRol.SelectedIndex = -1; // Para que no seleccione nada al inicio
            }
            catch (Exception ex)
            {
                DialogResult = IPES_CDD.Show("Error al cargar roles: " + ex.Message, "Error Fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void MostrarGerentes()
        {
            try
            {

                dgvGerentes.DataSource = null;
                dgvGerentes.DataSource = Empleadores.MostrarGerentes();
                if (dgvGerentes.Columns.Contains("Foto de perfil"))
                {
                    dgvGerentes.Columns["Foto de perfil"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                dgvGerentes.DataSource = null;
                DialogResult = IPES_CDD.Show("Error al cargar los gerentes: " + ex.Message, "Error Fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarRecepcionistas()
        {
            try
            {

                dgvRecepcionistas.DataSource = null;
                dgvRecepcionistas.DataSource = Empleadores.MostrarRecepcionistas();
                if (dgvRecepcionistas.Columns.Contains("Foto de perfil"))
                {
                    dgvRecepcionistas.Columns["Foto de perfil"].Visible = false;
                }
            }
            catch (Exception ex)
            { 
                dgvRecepcionistas.DataSource = null;
                DialogResult = IPES_CDD.Show("Error al cargar los Recepcionistas: " + ex.Message, "Error Fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvGerentes_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvGerentes != null)
                {
                    txtNombreUsuario.Text = dgvGerentes.CurrentRow.Cells["Nombre de Usuario"].Value.ToString();
                    txtNombre.Text = dgvGerentes.CurrentRow.Cells["Nombre"].Value.ToString();
                    txtApellido.Text = dgvGerentes.CurrentRow.Cells["Apellido"].Value.ToString();
                    txtEmailUNIQUE.Text = dgvGerentes.CurrentRow.Cells["Correo Electrónico"].Value.ToString();
                    msktxtTelefono.Text = dgvGerentes.CurrentRow.Cells["Numero Telefonico"].Value.ToString();
                    txtCiudad.Text = dgvGerentes.CurrentRow.Cells["Direccion"].Value.ToString();
                    dtp1.Value = Convert.ToDateTime(dgvGerentes.CurrentRow.Cells["Fecha Nacimiento"].Value);
                    string tipoLaminaTexto = dgvGerentes.CurrentRow.Cells["Rol"].Value?.ToString()?.Trim(); // Nombre INNER JOIN

                    DataTable tablaTipos = (DataTable)cbRol.DataSource;

                    var filaCoincidente = tablaTipos.AsEnumerable()
                        .FirstOrDefault(row => row.Field<string>("nombreRol").Trim().Equals(tipoLaminaTexto, StringComparison.OrdinalIgnoreCase)); // Nombre de la tabla Invitada REAL

                    if (filaCoincidente != null)
                    {
                        cbRol.SelectedValue = filaCoincidente.Field<int>("idRol"); // ID de la tabla HOST
                    }
                    else
                    {
                        DialogResult = IPES_CDD.Show($"No se encontró el tipo de Rol'{tipoLaminaTexto}' en el ComboBox.", "Error Extraño // FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    rbtnHombre.Checked = dgvGerentes.CurrentRow.Cells["Genero"].Value.ToString() == "Hombre";
                    rbtnMujer.Checked = dgvGerentes.CurrentRow.Cells["Genero"].Value.ToString() == "Mujer";


                    // Manejo de la imagen en bytes
                    var fotoPerfilValue = dgvGerentes.CurrentRow.Cells["Foto de perfil"].Value;

                    if (fotoPerfilValue != null && fotoPerfilValue != DBNull.Value)
                    {
                        if (fotoPerfilValue is byte[] imageBytes)
                        {
                            // Convertir bytes a imagen
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                pbPerfil.Image = Image.FromStream(ms);
                            }
                        }
                        else if (fotoPerfilValue is string imageString)
                        {
                            // Si está almacenado como string Base64
                            byte[] bytes = Convert.FromBase64String(imageString);
                            using (MemoryStream ms = new MemoryStream(bytes))
                            {
                                pbPerfil.Image = Image.FromStream(ms);
                            }
                        }
                    }
                    else
                    {
                        pbPerfil.Image = null;
                    }
                }
            }
            catch (Exception ex)
            {
                DialogResult = IPES_CDD.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvRecepcionistas_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvRecepcionistas != null)
                {
                    txtNombreUsuario.Text = dgvRecepcionistas.CurrentRow.Cells["Nombre de Usuario"].Value.ToString();
                    txtNombre.Text = dgvRecepcionistas.CurrentRow.Cells["Nombre"].Value.ToString();
                    txtApellido.Text = dgvRecepcionistas.CurrentRow.Cells["Apellido"].Value.ToString();
                    txtEmailUNIQUE.Text = dgvRecepcionistas.CurrentRow.Cells["Correo Electrónico"].Value.ToString();
                    msktxtTelefono.Text = dgvRecepcionistas.CurrentRow.Cells["Numero Telefonico"].Value.ToString();
                    txtCiudad.Text = dgvRecepcionistas.CurrentRow.Cells["Direccion"].Value.ToString();
                    dtp1.Value = Convert.ToDateTime(dgvRecepcionistas.CurrentRow.Cells["Fecha Nacimiento"].Value);
                    string tipoLaminaTexto = dgvRecepcionistas.CurrentRow.Cells["Rol"].Value?.ToString()?.Trim(); // Nombre INNER JOIN

                    DataTable tablaTipos = (DataTable)cbRol.DataSource;

                    var filaCoincidente = tablaTipos.AsEnumerable()
                        .FirstOrDefault(row => row.Field<string>("nombreRol").Trim().Equals(tipoLaminaTexto, StringComparison.OrdinalIgnoreCase)); // Nombre de la tabla Invitada REAL

                    if (filaCoincidente != null)
                    {
                        cbRol.SelectedValue = filaCoincidente.Field<int>("idRol"); // ID de la tabla HOST
                    }
                    else
                    {
                        DialogResult = IPES_CDD.Show($"No se encontró el tipo de Rol'{tipoLaminaTexto}' en el ComboBox.", "Error Extraño // FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    rbtnHombre.Checked = dgvRecepcionistas.CurrentRow.Cells["Genero"].Value.ToString() == "Hombre";
                    rbtnMujer.Checked = dgvRecepcionistas.CurrentRow.Cells["Genero"].Value.ToString() == "Mujer";


                    // Manejo de la imagen en bytes
                    var fotoPerfilValue = dgvRecepcionistas.CurrentRow.Cells["Foto de perfil"].Value;

                    if (fotoPerfilValue != null && fotoPerfilValue != DBNull.Value)
                    {
                        if (fotoPerfilValue is byte[] imageBytes)
                        {
                            // Convertir bytes a imagen
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                pbPerfil.Image = Image.FromStream(ms);
                            }
                        }
                        else if (fotoPerfilValue is string imageString)
                        {
                            // Si está almacenado como string Base64
                            byte[] bytes = Convert.FromBase64String(imageString);
                            using (MemoryStream ms = new MemoryStream(bytes))
                            {
                                pbPerfil.Image = Image.FromStream(ms);
                            }
                        }
                    }
                    else
                    {
                        pbPerfil.Image = null;
                    }
                }
            }
            catch (Exception ex)
            {
                DialogResult = IPES_CDD.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private byte[] imagenBytes;
        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            // Mostrar el diálogo para seleccionar archivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Cargar la imagen en el PictureBox
                    pbPerfil.Image = Image.FromFile(openFileDialog.FileName);

                    // Opcional: Redimensionar la imagen si es muy grande
                    RedimensionarImagenSiEsNecesario();

                    // Convertir la imagen a bytes para la base de datos
                    imagenBytes = ImageToByteArray(pbPerfil.Image);

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
            if (pbPerfil.Image != null)
            {
                // Si la imagen es muy grande, redimensionarla
                if (pbPerfil.Image.Width > 400 || pbPerfil.Image.Height > 400)
                {
                    int nuevoAncho = 400;
                    int nuevoAlto = 400;

                    // Mantener la relación de aspecto
                    if (pbPerfil.Image.Width > pbPerfil.Image.Height)
                    {
                        nuevoAlto = (int)((double)pbPerfil.Image.Height / pbPerfil.Image.Width * nuevoAncho);
                    }
                    else
                    {
                        nuevoAncho = (int)((double)pbPerfil.Image.Width / pbPerfil.Image.Height * nuevoAlto);
                    }

                    Bitmap imagenRedimensionada = new Bitmap(nuevoAncho, nuevoAlto);
                    using (Graphics g = Graphics.FromImage(imagenRedimensionada))
                    {
                        g.DrawImage(pbPerfil.Image, 0, 0, nuevoAncho, nuevoAlto);
                    }

                    pbPerfil.Image = imagenRedimensionada;
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Empleadores empleador = new Empleadores();
                if (txtEmailUNIQUE.Text != null)
                {
                    empleador.CorreoElectronico = txtEmailUNIQUE.Text.Trim();
                }
                else
                {
                    DialogResult = IPES_CDD.Show("El campo de correo electrónico no puede estar vacío, por favor selecciona a algun empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                empleador.FotoPerfil = imagenBytes;

                bool exito = empleador.ModificarFotoPerfil();

                DialogResult = IPES_CDD.Show(exito ? "Imagen actualizada correctamente en la base de datos // Se actualizara la foto la proxima vez que inicies sesión" : "No se pudo actualizar la imagen en la base de datos.",
                                exito ? "Actualización Exitosa" : "Error // FATAL", MessageBoxButtons.OK, exito ? MessageBoxIcon.Information : MessageBoxIcon.Error);
                MostrarGerentes();
                MostrarRecepcionistas();
            }
            catch (Exception ex)
            {

               DialogResult = IPES_CDD.Show("Error al asignar la foto de Perfil al Correo Seleccionado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnBusquedaGerente_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtBusquedaGerente.Text.Trim();
                if (string.IsNullOrEmpty(nombre))
                {
                    errorProvider.SetError(txtBusquedaGerente, "Por favor ingrese un nombre de gerente para buscar.");
                    return;
                }
                // Buscar en Gerentes
                var resultadosGerente = Empleadores.BuscarUsuarioGerente(nombre);
                if (resultadosGerente != null && resultadosGerente.Rows.Count > 0)
                {
                    dgvGerentes.DataSource = resultadosGerente;
                }
                else
                {
                    errorProvider.SetError(txtBusquedaGerente, "No se encontraron resultados en Gerentes.");
                    dgvGerentes.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                errorProvider.SetError(txtBusquedaGerente, "Error al buscar el gerente: " + ex.Message);
            }
        }

        private void btnBusquedaRecepcionista_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtBusquedaRecepcionista.Text.Trim();
                if (string.IsNullOrEmpty(nombre))
                {
                    errorProvider.SetError(txtBusquedaRecepcionista, "Por favor ingrese un nombre de recepcionista para buscar.");
                    return;
                }

                if (txtBusquedaRecepcionista.Text.Any(char.IsDigit))
                {
                    errorProvider.SetError(txtBusquedaRecepcionista, "No se permiten números en la busqueda.");
                    return;
                }
                // Buscar en Recepcionistas
                var resultadosRecepcionista = Empleadores.BuscarUsuarioRecepcionista(nombre);
                if (resultadosRecepcionista != null && resultadosRecepcionista.Rows.Count > 0)
                {
                    dgvRecepcionistas.DataSource = resultadosRecepcionista;
                }
                else
                {
                    errorProvider.SetError(txtBusquedaRecepcionista, "No se encontraron resultados en Recepcionistas.");
                    dgvRecepcionistas.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                errorProvider.SetError(txtBusquedaRecepcionista, "Error al buscar el recepcionista: " + ex.Message);
            }
        }

        private void lblLimpiarDGV_Click(object sender, EventArgs e)
        {
            txtBusquedaGerente.Clear();
            MostrarGerentes();
        }

        private void lblLimpiarDGV2_Click(object sender, EventArgs e)
        {
            txtBusquedaRecepcionista.Clear();
            MostrarRecepcionistas();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Empleadores modificar = new Empleadores();
            // Validaciones
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errorProvider.SetError(txtNombre, "El nombre no puede estar vacío.");
                return;
            }
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                errorProvider.SetError(txtApellido, "El apellido no puede estar vacío.");
                return;
            }
            if (msktxtTelefono.Text == null)
            {
                errorProvider.SetError(msktxtTelefono, "El número de Telefono no puede estar vacio.");
                return;
            }
            if (string.IsNullOrEmpty(txtCiudad.Text))
            {
                errorProvider.SetError(txtCiudad, "La ciudad no puede estar vacía.");
                return;
            }
            if (string.IsNullOrEmpty(txtNombreUsuario.Text))
            {
                errorProvider.SetError(txtNombreUsuario, "El nombre de usuario no puede estar vacío.");
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
            try
            {
                Empleadores empleado = new Empleadores();
                empleado.NombreSistemaUsuario = txtNombreUsuario.Text;
                empleado.Nombre = txtNombre.Text;
                empleado.CorreoElectronico = txtEmailUNIQUE.Text;
                empleado.Apellido = txtApellido.Text;
                empleado.Direccion = txtCiudad.Text;
                empleado.IdRol = Convert.ToInt32(cbRol.SelectedValue);
                empleado.NumeroTelefono = msktxtTelefono.Text;
                empleado.FechaCumpleanios = dtp1.Value;

                if (empleado.ModificarUsuario())
                {
                    Console.WriteLine("Empleado modificado exitosamente.");
                    Console.WriteLine("Llamando al Selector de Empleados");
                    DialogResult resultado = IPES_CDD.Show("Empleado modificado exitosamente.", "Modificacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombreUsuario.Clear();
                    txtNombre.Clear();
                    txtApellido.Clear();
                    txtEmailUNIQUE.Clear();
                    msktxtTelefono.Clear();
                    txtCiudad.Clear();
                    pbPerfil.Image = null;
                    MostrarRecepcionistas();
                    MostrarGerentes();
                    cbRol.SelectedIndex = -1;
                    dtp1.Value = DateTime.Now;
                }
                else
                {
                    DialogResult resultado = IPES_CDD.Show("Error al modificar el empleado. Por favor, inténtalo de nuevo.", "Error de Modificacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                DialogResult resultado = IPES_CDD.Show("Error al modificar el empleado: " + ex.Message, "Error Fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
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
        private void btnEliminarGerente_Click(object sender, EventArgs e)
        {
            if (dgvGerentes.SelectedRows.Count > 0)
            {
                var confirmResult = DialogResult = IPES_CDD.Show("¿Estás seguro de eliminar este gerente?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    var fila = dgvGerentes.SelectedRows[0];
                    var correo = fila.Cells["Correo Electrónico"].Value.ToString();

                    Empleadores gerente = new Empleadores();
                    gerente.CorreoElectronico = correo;

                    if (gerente.EliminarUsuario())
                    {
                        DialogResult = IPES_CDD.Show("Gerente eliminado exitosamente.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MostrarGerentes();
                        txtNombreUsuario.Clear();
                        txtNombre.Clear();
                        txtApellido.Clear();
                        txtEmailUNIQUE.Clear();
                        msktxtTelefono.Clear();
                        txtCiudad.Clear();
                        pbPerfil.Image = null;
                        MostrarGerentes();
                        cbRol.SelectedIndex = -1;
                        dtp1.Value = DateTime.Now;
                    }
                    else
                    {
                        DialogResult = IPES_CDD.Show("Error al eliminar el gerente. Por favor, inténtalo de nuevo.", "Error de Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                DialogResult = IPES_CDD.Show("Por favor, selecciona un gerente para eliminar.", "Selección Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarRecepcionista_Click(object sender, EventArgs e)
        {
            if (dgvRecepcionistas.SelectedRows.Count > 0)
            {
                var confirmResult = IPES_CDD.Show("¿Estás seguro de eliminar este recepcionista?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    var fila = dgvRecepcionistas.SelectedRows[0];
                    var correo = fila.Cells["Correo Electrónico"].Value.ToString();

                    Empleadores recepcionista = new Empleadores();
                    recepcionista.CorreoElectronico = correo;

                    if (recepcionista.EliminarUsuario())
                    {
                        DialogResult = IPES_CDD.Show("Recepcionista eliminado exitosamente.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MostrarRecepcionistas();
                        txtNombreUsuario.Clear();
                        txtNombre.Clear();
                        txtApellido.Clear();
                        txtEmailUNIQUE.Clear();
                        msktxtTelefono.Clear();
                        txtCiudad.Clear();
                        pbPerfil.Image = null;
                        MostrarRecepcionistas();
                        cbRol.SelectedIndex = -1;
                        dtp1.Value = DateTime.Now;
                    }
                    else
                    {
                        DialogResult = IPES_CDD.Show("Error al eliminar el recepcionista. Por favor, inténtalo de nuevo.", "Error de Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else 
            { 
                DialogResult = IPES_CDD.Show("Por favor, selecciona un recepcionista para eliminar.", "Selección Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
