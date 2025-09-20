using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Vistas.Formularios.Carga;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Vistas.Formularios.Visualizador
{
    public partial class frmContenedor : Form
    {
        private const int BORDER_RADIUS = 20;
        private const int BORDER_SIZE = 8;
        private readonly Color BORDER_COLOR = Color.White;
        private Size _tamanoAnterior;
        private Point _posicionAnterior;
        private bool _estaMaximizado = false;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000;// Minimizar Formulario Sin Bordes
                return cp;
            }
        }

        public frmContenedor()
        {
            InitializeComponent();
            InitializeComponentOptimizations();
            InitializeFormSettings();
            InitializeLogin();
            ArrastrarVentana(pnlBarraArriba);
        }

        private void InitializeComponentOptimizations()
        {
            SetDoubleBuffered(pnlContenedor);
            SetDoubleBuffered(pnlBarraArriba);
            SetDoubleBuffered(fplnBotones);
        }

        private void SetDoubleBuffered(Control control)
        {
            typeof(Control).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null, control, new object[] { true });
        }

        private void InitializeFormSettings()
        {
            this.Name = "frmContenedor";
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(BORDER_SIZE);
            this.BackColor = BORDER_COLOR;
            this.pnlBarraArriba.BackColor = BORDER_COLOR;

            _tamanoAnterior = this.Size;
            _posicionAnterior = this.Location;
        }

        private void InitializeLogin()
        {
            var iniciar = new frmLogin
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            pnlContenedor.Visible = true;
            pnlContenedor.Controls.Clear();
            pnlContenedor.Controls.Add(iniciar);
            iniciar.Show();

            AplicarRegionesRedondeadas();
            this.Invalidate();
        }

        private void AplicarRegionesRedondeadas()
        {
            if (!_estaMaximizado && this.IsHandleCreated)
            {
                try
                {
                    // Aplicar región al formulario principal
                    using (var pathForm = GetRoundedPath(this.ClientRectangle, BORDER_RADIUS))
                    {
                        this.Region = new Region(pathForm);
                    }

                    // Aplicar región al panel contenedor
                    if (pnlContenedor != null && !pnlContenedor.IsDisposed)
                    {
                        using (var pathPanel = GetRoundedPath(pnlContenedor.ClientRectangle, BORDER_RADIUS - (BORDER_SIZE / 2)))
                        {
                            pnlContenedor.Region = new Region(pathPanel);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error aplicando regiones redondeadas: " + ex.Message);
                }
            }
        }

        private void AlternarMaximizado()
        {
            if (!_estaMaximizado)
            {
                Screen screen = Screen.FromHandle(this.Handle);
                this.Location = screen.WorkingArea.Location;
                this.Size = screen.WorkingArea.Size;
                _estaMaximizado = true;

                this.Padding = new Padding(0);
                this.Region = null;
                if (pnlContenedor != null && !pnlContenedor.IsDisposed)
                    pnlContenedor.Region = null;
            }
            else
            {
                this.Width = 1280;
                this.Height = 760;
                _estaMaximizado = false;
                this.StartPosition = FormStartPosition.Manual;
                this.Location = new Point(
                    (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                    (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2
                );
                this.Padding = new Padding(BORDER_SIZE);
                AplicarRegionesRedondeadas();
            }

            this.Invalidate();
            VerificarEstado();
        }

        private void VerificarEstado()
        {

        }

        private void pbMaximizar_Click(object sender, EventArgs e)
        {
            AlternarMaximizado();
        }

        #region Métodos para bordes
        private GraphicsPath GetRoundedPath(Rectangle rect, float radius)
        {
            if (_estaMaximizado) return new GraphicsPath();

            var path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();

            return path;
        }

        private void DrawPanelBorder(PaintEventArgs e)
        {
            if (_estaMaximizado) return;
            if (pnlContenedor == null || pnlContenedor.IsDisposed) return;

            try
            {
                using (var path = GetRoundedPath(pnlContenedor.ClientRectangle, BORDER_RADIUS - (BORDER_SIZE / 2)))
                using (var pen = new Pen(BORDER_COLOR, 2))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(pen, path);
                }
            }
            catch
            {
                using (var pen = new Pen(BORDER_COLOR, 2))
                {
                    e.Graphics.DrawRectangle(pen, pnlContenedor.ClientRectangle);
                }
            }
        }

        private void DrawFormBorder(PaintEventArgs e)
        {
            if (_estaMaximizado) return;

            try
            {
                using (var path = GetRoundedPath(this.ClientRectangle, BORDER_RADIUS))
                using (var pen = new Pen(BORDER_COLOR, BORDER_SIZE))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(pen, path);
                }
            }
            catch
            {
                using (var pen = new Pen(BORDER_COLOR, BORDER_SIZE))
                {
                    e.Graphics.DrawRectangle(pen, this.ClientRectangle);
                }
            }
        }
        #endregion

        #region Eventos de pintado
        private void pnlContenedorPrincipal_Paint(object sender, PaintEventArgs e)
        {
            DrawPanelBorder(e);
        }

        private void frmContenedor_Paint(object sender, PaintEventArgs e)
        {
            DrawFormBorder(e);
        }
        #endregion

        #region Eventos de formulario
        private void frmContenedor_Load(object sender, EventArgs e)
        {
            VerificarEstado();
            AplicarRegionesRedondeadas();
        }

        private void frmContenedor_ResizeEnd(object sender, EventArgs e)
        {
            AplicarRegionesRedondeadas();
            this.Invalidate();
        }

        private void frmContenedor_SizeChanged(object sender, EventArgs e)
        {
            if (!_estaMaximizado)
            {
                _tamanoAnterior = this.Size;
                AplicarRegionesRedondeadas();
            }
            this.Invalidate();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (!_estaMaximizado)
            {
                AplicarRegionesRedondeadas();
            }
            this.Invalidate();
        }
        #endregion

        #region Manejo de controles en el panel
        private void pnlContenedorPrincipal_ControlAdded(object sender, ControlEventArgs e)
        {

            if (this.IsHandleCreated)
            {
                BeginInvoke((MethodInvoker)delegate
                {
                    AplicarRegionesRedondeadas();
                    this.Invalidate();
                });
            }
        }

        public void MostrarFormularioEnPanel(Form formulario)
        {
            if (formulario == null) return;
            if (pnlContenedor == null || pnlContenedor.IsDisposed) return;

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            pnlContenedor.Controls.Clear();
            pnlContenedor.Controls.Add(formulario);
            formulario.Show();


            AplicarRegionesRedondeadas();
            this.Invalidate();
        }
        #endregion

        public void CerrarContenedor()
        {
            using (var carga = new frmProgreso())
            {
                carga.Show();
                this.Close();
            }
        }


        public void MostrarVista(UserControl vista)
        {
            if (pnlContenedor == null || pnlContenedor.IsDisposed) return;

            pnlContenedor.Controls.Clear();
            vista.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(vista);


            AplicarRegionesRedondeadas();
            this.Invalidate();
        }

        private void pbMinimiza_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

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