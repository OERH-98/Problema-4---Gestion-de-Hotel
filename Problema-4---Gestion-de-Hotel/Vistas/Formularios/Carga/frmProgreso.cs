

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Vistas.Formularios.Visualizador;
using System.Runtime.InteropServices;

namespace Vistas.Formularios.Carga
{
    public partial class frmProgreso : Form
    {
        //<----------------------------------------------------------------------------------->
        public frmProgreso()
        {
            InitializeComponent();
            this.BackColor = Color.Yellow;
            this.TransparencyKey = Color.Yellow;
            ArrastrarVentana(pbFondo);
            ArrastrarVentana(pgbProgreso);
            ArrastrarVentana(pbLogo);
            ArrastrarVentana(lblPorcentaje);
            ArrastrarVentana(this);
            ArrastrarVentana(pnlBarradeCarga);
            ArrastrarVentana(pgbProgreso);
        }
        //<----------------------------------------------------------------------------------->

        private void frmProgreso_Load(object sender, EventArgs e)
        {
            this.Opacity = 0; // Opacidad en 0
            tmrAnimacion.Start();//Inicia la animación
            Console.WriteLine("Iniciando Carga...");//Mensaje en consola
        }
        //Clase para Cerrar La ventana de carga con botones personalizados
        //<----------------------------------------------------------------------------------->

        private void tmrOcultarAnimacion_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.05;
            if (this.Opacity == 0)
            {
                tmrOcultarAnimacion.Stop();
                frmContenedor Main = new frmContenedor();
                Main.Show();
                Main.FormClosed += (s, args) => this.Close();
                Console.WriteLine("Cerrando Carga...");
                this.Hide();
            }
        }
        //<----------------------------------------------------------------------------------->

        private void tmrAnimacion_Tick_1(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05; // Si la opcacidad es menor a 1, aumenta la opacidad en 0.05
            pgbProgreso.Value += 1; // Aumentamos el valor de 1 en 1 en la barra de progreso personalizada
            lblPorcentaje.Text = $"{pgbProgreso.Value.ToString()}%"; // Actualiza el porcentaje en el label
            if (pgbProgreso.Value == 100) // Si el progreso llega a 100
            {
                tmrAnimacion.Stop(); // Para la animación de carga
                Console.WriteLine("Carga Completa"); // Mensaje en consola
                tmrOcultarAnimacion.Start(); // Inicia la animacion de ocultamiento
            }
        }
        //<----------------------------------------------------------------------------------->
        // Funciones para Arrastrar Ventana
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;
        public void ArrastrarVentana(Control control)
        {
            Console.WriteLine("Arrastrando Elemento Invocado");
            control.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
                }
            };
        }
    }
}
