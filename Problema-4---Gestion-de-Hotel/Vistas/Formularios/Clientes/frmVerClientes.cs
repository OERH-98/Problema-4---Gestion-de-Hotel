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
using Vistas.Formularios.Menu;
using Vistas.Formularios.Visualizador;
using Vistas.Formularios.Componentes_Nuevos;
namespace Vistas.Formularios.Clientes
{
    public partial class frmVerClientes : Form
    {
        public frmVerClientes()
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
            try
            {
                dgvClientes.DataSource = ClientesHotel.CargarClientes();
            }
            catch (Exception ex)
            {
                DialogResult = IPES_CDD.Show("Error al cargar los clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
