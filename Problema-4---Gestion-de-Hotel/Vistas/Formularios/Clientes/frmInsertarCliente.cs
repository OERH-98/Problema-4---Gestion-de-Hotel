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

namespace Vistas.Formularios.Clientes
{
    public partial class frmInsertarCliente : Form
    {
        public frmInsertarCliente()
        {
            InitializeComponent();
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
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000; // Habilita el estilo WS_EX_COMPOSITED para mejorar el rendimiento de redimensionamiento
                return handleparam;
            }
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(msktxtDui.Text) ||
                string.IsNullOrWhiteSpace(txtCiudad.Text) ||
                string.IsNullOrWhiteSpace(msktxtTelefono.Text) ||
                (!rbtnHombre.Checked && !rbtnMujer.Checked))
            {
                DialogResult = IPES_CDD.Show("Por favor, complete todos los campos obligatorios.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtNombre.Text.Any(char.IsDigit))
            {
                DialogResult = IPES_CDD.Show("El nombre no puede contener números.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtApellido.Text.Any(char.IsDigit))
            {
                DialogResult = IPES_CDD.Show("El apellido no puede contener números.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!msktxtDui.MaskFull)
            {
                DialogResult = IPES_CDD.Show("El DUI está incompleto.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!msktxtTelefono.MaskFull)
            {
                DialogResult = IPES_CDD.Show("El número de teléfono está incompleto.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtp1.Value > DateTime.Now)
            {
                DialogResult = IPES_CDD.Show("La fecha de cumpleaños no puede ser en el futuro.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtp1.Value < DateTime.Now.AddYears(-120))
            {
                DialogResult = IPES_CDD.Show("La fecha de cumpleaños no puede ser hace más de 120 años.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtp1.Value > DateTime.Now.AddYears(-18))
            {
                DialogResult = IPES_CDD.Show("El cliente debe ser mayor de 18 años.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ClientesHotel clientes = new ClientesHotel();
                clientes.NombreCliente = txtNombre.Text;
                clientes.ApellidoCliente = txtApellido.Text;
                clientes.DUI = msktxtDui.Text;
                clientes.DireccionCliente = txtCiudad.Text;
                clientes.FechaCumpleanios = dtp1.Value;
                clientes.Genero = ObtenerGeneroSeleccionado();
                clientes.NumeroTelefono = msktxtTelefono.Text;
                if (clientes.InsertarCliente())
                {
                    DialogResult = IPES_CDD.Show("Cliente registrado con éxito", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    DialogResult = IPES_CDD.Show("No se pudo registrar el cliente, intente de nuevo", "Error Fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                DialogResult = IPES_CDD.Show("Error al registrar el cliente: " + ex.Message, "Error Fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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
