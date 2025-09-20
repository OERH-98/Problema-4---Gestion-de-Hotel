//Este formulario de Mensaje de Dialogo fue realizado por:
//Omar Ernesto Rivera Hernández - 20240600 - Coordinador PTC
//Luis Edgardo Soriano Rivas - 20220011 - Secretario PTC
//Rosemberg Astul Ramos - 20240100 - Tesorero PTC
//Fabiola Nicole Henriques Portillo - 20220157 - Subcoordinadora PTC
//Chelsea Mariana Mejia Martines - 20241012 - Vocal PTC
//Fecha: 02/08/2025
//Este Proyecto fue creado en un solo ordenador por el hecho que no sabemos usar las ramas de GitHub
//IPES: IDEA PUBLICIDAD EL SALVADOR
//Sacamos esto de un tutorial de YOUTUBE
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Formularios.Componentes_Nuevos
{
    public partial class frmMensajedeDialogo : Form
    {
        //<----------------------------------------------------------------------------------->
        public frmMensajedeDialogo()
        {
            InitializeComponent();
            this.MouseDown += lblTitulo_MouseDown;
            this.MouseDown += pnlTitulo_MouseDown;
        }

        // Comento esta parte porque no es necesaria para este formulario, pero la dejo por si acaso
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams handleparam = base.CreateParams;
        //        handleparam.ExStyle |= 0x02000000 | 0x00080000; // Habilita el estilo WS_EX_COMPOSITED para mejorar el rendimiento de redimensionamiento
        //        return handleparam;
        //    }
        //}

        //<----------------------------------------------------------------------------------->

        //Color Primario del formulario
        private Color primaryColor = Color.RoyalBlue;
        // Tamaño del borde del formulario
        private int borderSize = 4;
        // Radio para bordes redondeados
        private int borderRadius = 20;
        //<----------------------------------------------------------------------------------->

        //Propiedades
        public Color PrimaryColor
        {
            get { return primaryColor; }
            set
            {
                primaryColor = value;
                this.BackColor = primaryColor;//Color del Borde del Formulario
                this.pnlTitulo.BackColor = PrimaryColor;//Color de fondo del Panel Titulo
                this.Invalidate(); // Forzar redibujado para actualizar bordes redondeados
            }
        }
        //<----------------------------------------------------------------------------------->

        //Constructores
        public frmMensajedeDialogo(string text)
        {
            InitializeComponent();
            InitializeItems();
            this.PrimaryColor = primaryColor;
            this.lblMensaje.Text = text;
            this.lblTitulo.Text = "";
            SetFormSize();
            SetButtons(MessageBoxButtons.OK, MessageBoxDefaultButton.Button1);//Establecer Botones por Defecto
        }
        //<----------------------------------------------------------------------------------->
        public frmMensajedeDialogo(string text, string caption)
        {
            InitializeComponent();
            InitializeItems();
            this.PrimaryColor = primaryColor;
            this.lblMensaje.Text = text;
            this.lblTitulo.Text = caption;
            SetFormSize();
            SetButtons(MessageBoxButtons.OK, MessageBoxDefaultButton.Button1);//Establecer Botones por Defecto
        }
        //<----------------------------------------------------------------------------------->
        public frmMensajedeDialogo(string text, string caption, MessageBoxButtons buttons)
        {
            InitializeComponent();
            InitializeItems();
            this.PrimaryColor = primaryColor;
            this.lblMensaje.Text = text;
            this.lblTitulo.Text = caption;
            SetFormSize();
            SetButtons(buttons, MessageBoxDefaultButton.Button1);//Establecer Boton 1 por Defecto
        }
        //<----------------------------------------------------------------------------------->
        public frmMensajedeDialogo(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            InitializeComponent();
            InitializeItems();
            this.PrimaryColor = primaryColor;
            this.lblMensaje.Text = text;
            this.lblTitulo.Text = caption;
            SetFormSize();
            SetButtons(buttons, MessageBoxDefaultButton.Button1);//Establecer Boton 1 por Defecto
            SetIcon(icon);
        }
        public frmMensajedeDialogo(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
        {
            InitializeComponent();
            InitializeItems();
            this.PrimaryColor = primaryColor;
            this.lblMensaje.Text = text;
            this.lblTitulo.Text = caption;
            SetFormSize();
            SetButtons(buttons, defaultButton);
            SetIcon(icon);
        }
        //<----------------------------------------------------------------------------------->

        // Inicializador de componentes
        private void InitializeItems()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);//Establecer el tamaño del borde
            this.lblMensaje.MaximumSize = new Size(550, 0);
            this.btn1.DialogResult = DialogResult.OK;
            this.btn1.Visible = false;
            this.btn2.Visible = false;
            this.btn3.Visible = false;

            // Aplicar redondeo personalizado a los paneles
            AplicarRedondeoPaneles();
        }
        //<----------------------------------------------------------------------------------->

        // Tamaño dinamico acorde al tamaño del mensaje y los botones
        private void SetFormSize()
        {
            int widht = this.lblMensaje.Width + this.pbIcono.Width + this.pnlCuerpo.Padding.Left;
            int height = this.pnlTitulo.Height + this.lblMensaje.Height + this.pnlBotones.Height + this.pnlCuerpo.Padding.Top;
            this.Size = new Size(widht, height);
        }
        //<----------------------------------------------------------------------------------->

        // Método para crear path redondeado
        private GraphicsPath GetRoundedPath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        // Método para crear path redondeado solo en la parte superior
        private GraphicsPath GetTopRoundedPath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddLine(rect.Right, rect.Bottom, rect.X, rect.Bottom);
            path.CloseFigure();
            return path;
        }

        // Método para crear path redondeado solo en la parte inferior
        private GraphicsPath GetBottomRoundedPath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddLine(rect.X, rect.Y, rect.Right, rect.Y);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        // Override del método OnPaint para dibujar bordes redondeados
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Rectangle rectForm = this.ClientRectangle;
            using (GraphicsPath pathForm = GetRoundedPath(rectForm, borderRadius))
            using (Pen penBorder = new Pen(this.PrimaryColor, borderSize))
            {
                this.Region = new Region(pathForm);
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(penBorder, pathForm);
            }
        }

        // Método para aplicar redondeo a los paneles
        private void AplicarRedondeoPaneles()
        {
            // Redondear solo la parte superior del pnlCuerpo
            pnlCuerpo.Paint += (sender, e) =>
            {
                using (GraphicsPath path = GetTopRoundedPath(pnlCuerpo.ClientRectangle, borderRadius))
                {
                    pnlCuerpo.Region = new Region(path);
                }
            };

            // Redondear solo la parte inferior del pnlBotones
            pnlBotones.Paint += (sender, e) =>
            {
                using (GraphicsPath path = GetBottomRoundedPath(pnlBotones.ClientRectangle, borderRadius))
                {
                    pnlBotones.Region = new Region(path);
                }
            };
        }

        //<----------------------------------------------------------------------------------->
        // Offsets de los Botones
        private void SetButtons(MessageBoxButtons buttons, MessageBoxDefaultButton defaultButton)
        {
            int xCenter = (this.pnlBotones.Width - btn1.Width) / 2;
            int yCenter = (this.pnlBotones.Height - btn1.Height) / 2;

            switch (buttons)
            {
                case MessageBoxButtons.OK:
                    //Boton OK
                    btn1.Visible = true;
                    btn1.Location = new Point(xCenter, yCenter);
                    btn1.Text = "Ok";
                    btn1.DialogResult = DialogResult.OK;//Establece el DialogResult

                    //Set Default Button
                    SetDefaultButton(defaultButton);
                    break;
                case MessageBoxButtons.OKCancel:
                    //Boton Ok
                    btn1.Visible = true;
                    btn1.Location = new Point(xCenter - (btn1.Width / 2) - 5, yCenter);
                    btn1.Text = "Ok";
                    btn1.DialogResult = DialogResult.OK;//Establece el DialogResult

                    //Boton Cancelar
                    btn2.Visible = true;
                    btn2.Location = new Point(xCenter + (btn2.Width / 2) + 5, yCenter);
                    btn2.Text = "Cancelar";
                    btn2.DialogResult = DialogResult.Cancel;//Establece el DialogResult
                    btn2.BackColor = Color.DimGray;

                    //Establecer Boton por Defecto
                    if (defaultButton != MessageBoxDefaultButton.Button3)//Aqui solo hay 2 botones, por lo que el Boton por Defecto no puede ser Button3
                        SetDefaultButton(defaultButton);
                    else SetDefaultButton(MessageBoxDefaultButton.Button1);
                    break;

                case MessageBoxButtons.RetryCancel:
                    //Boton Reintentar
                    btn1.Visible = true;
                    btn1.Location = new Point(xCenter - (btn1.Width / 2) - 5, yCenter);
                    btn1.Text = "Reintentar";
                    btn1.DialogResult = DialogResult.Retry;//Establece el DialogResult

                    //Boton Cancelar
                    btn2.Visible = true;
                    btn2.Location = new Point(xCenter + (btn2.Width / 2) + 5, yCenter);
                    btn2.Text = "Cancelar";
                    btn2.DialogResult = DialogResult.Cancel;//Establece el DialogResult
                    btn2.BackColor = Color.DimGray;

                    //Boton por Defecto
                    if (defaultButton != MessageBoxDefaultButton.Button3)//Aqui solo hay 2 botones, por lo que el Boton por Defecto no puede ser Button3
                        SetDefaultButton(defaultButton);
                    else SetDefaultButton(MessageBoxDefaultButton.Button1);
                    break;

                case MessageBoxButtons.YesNo:
                    //Boton Si
                    btn1.Visible = true;
                    btn1.Location = new Point(xCenter - (btn1.Width / 2) - 5, yCenter);
                    btn1.Text = "Si";
                    btn1.DialogResult = DialogResult.Yes;//Establece el DialogResult

                    //Boton No
                    btn2.Visible = true;
                    btn2.Location = new Point(xCenter + (btn2.Width / 2) + 5, yCenter);
                    btn2.Text = "No";
                    btn2.DialogResult = DialogResult.No;//Establece el DialogResult
                    btn2.BackColor = Color.IndianRed;

                    //Establecer Boton por Defecto
                    if (defaultButton != MessageBoxDefaultButton.Button3)//Aqui solo hay 2 botones, por lo que el Boton por Defecto no puede ser Button3
                        SetDefaultButton(defaultButton);
                    else SetDefaultButton(MessageBoxDefaultButton.Button1);
                    break;
                case MessageBoxButtons.YesNoCancel:
                    //Boton Si
                    btn1.Visible = true;
                    btn1.Location = new Point(xCenter - btn1.Width - 5, yCenter);
                    btn1.Text = "Si";
                    btn1.DialogResult = DialogResult.Yes;//Establece el DialogResult

                    //Boton No
                    btn2.Visible = true;
                    btn2.Location = new Point(xCenter, yCenter);
                    btn2.Text = "No";
                    btn2.DialogResult = DialogResult.No;//Establece el DialogResult
                    btn2.BackColor = Color.IndianRed;

                    //Boton Cancelar
                    btn3.Visible = true;
                    btn3.Location = new Point(xCenter + btn2.Width + 5, yCenter);
                    btn3.Text = "Cancelar";
                    btn3.DialogResult = DialogResult.Cancel;//Establece el DialogResult
                    btn3.BackColor = Color.DimGray;

                    //Establecer Boton por Defecto
                    SetDefaultButton(defaultButton);
                    break;

                case MessageBoxButtons.AbortRetryIgnore:
                    //Boton Abortar
                    btn1.Visible = true;
                    btn1.Location = new Point(xCenter - btn1.Width - 5, yCenter);
                    btn1.Text = "Abortar";
                    btn1.DialogResult = DialogResult.Abort;//Establece el DialogResult
                    btn1.BackColor = Color.Goldenrod;

                    //Boton Reintentar
                    btn2.Visible = true;
                    btn2.Location = new Point(xCenter, yCenter);
                    btn2.Text = "Reintentar";
                    btn2.DialogResult = DialogResult.Retry;//Establece el DialogResult                 

                    //Boton Ignorar
                    btn3.Visible = true;
                    btn3.Location = new Point(xCenter + btn2.Width + 5, yCenter);
                    btn3.Text = "Ignorar";
                    btn3.DialogResult = DialogResult.Ignore;//Establece el DialogResult
                    btn3.BackColor = Color.IndianRed;

                    //Boton por Defecto
                    SetDefaultButton(defaultButton);
                    break;
            }
        }
        //<----------------------------------------------------------------------------------->

        private void SetDefaultButton(MessageBoxDefaultButton defaultButton)
        {
            switch (defaultButton)
            {
                case MessageBoxDefaultButton.Button1://Concentracion Boton1
                    btn1.Select();
                    btn1.ForeColor = Color.White; // Cambia el color del texto del boton 1 a blanco
                    btn1.Font = new Font(btn1.Font, FontStyle.Bold); // Cambia el estilo de la fuente del boton 1 a subrayado
                    break;
                case MessageBoxDefaultButton.Button2://Concentracion Boton2
                    btn2.Select();
                    btn2.ForeColor = Color.White; // Cambia el color del texto del boton 2 a blanco
                    btn2.Font = new Font(btn2.Font, FontStyle.Bold); // Cambia el estilo de la fuente del boton 2 a subrayado
                    break;
                case MessageBoxDefaultButton.Button3://Concentracion Boton3
                    btn3.Select();
                    btn3.ForeColor = Color.White; // Cambia el color del texto del boton 3 a blanco
                    btn3.Font = new Font(btn3.Font, FontStyle.Bold); // Cambia el estilo de la fuente del boton 3 a subrayado
                    break;
            }
        }
        //<----------------------------------------------------------------------------------->
        private void SetIcon(MessageBoxIcon icon) // Establece el icono del mensaje de dialogo + Sonido, Funcion Personalizada
        {
            switch (icon)
            {
                case MessageBoxIcon.Error: //Error
                    this.pbIcono.Image = Properties.Resources.error; // Icono de Error
                    Random rndError = new Random(); // Un selector que elige un sonido aleatorio entre 1 y 2
                    int sonidoError = rndError.Next(1, 3); // Un selector que elige un sonido aleatorio entre 1 y 2
                    using (var player = new System.Media.SoundPlayer(
                    sonidoError == 1 ? Properties.Resources.Error1 : Properties.Resources.Error2))
                    {
                        player.Play();
                    }
                    PrimaryColor = Color.FromArgb(224, 79, 95); // Color de Error
                    break;
                case MessageBoxIcon.Information: //Informacion
                    this.pbIcono.Image = Properties.Resources.informacion; // Icono de Informacion
                    Random rndInfo = new Random(); // Un selector que elige un sonido aleatorio entre 1 y 2
                    int sonidoInfo = rndInfo.Next(1, 3); // Un selector que elige un sonido aleatorio entre 1 y 2
                    using (var player = new System.Media.SoundPlayer(
                    sonidoInfo == 1 ? Properties.Resources.Informacion1 : Properties.Resources.Informacion2))
                    {
                        player.Play();
                    }
                    PrimaryColor = Color.RoyalBlue; // Color de Informacion
                    break;
                case MessageBoxIcon.Question://Pregunta
                    this.pbIcono.Image = Properties.Resources.pregunta; // Icono de Pregunta
                    Random rndPregunta = new Random(); // Un selector que elige un sonido aleatorio entre 1 y 2
                    int sonidoPregunta = rndPregunta.Next(1, 3); // Un selector que elige un sonido aleatorio entre 1 y 2
                    using (var player = new System.Media.SoundPlayer(
                    sonidoPregunta == 1 ? Properties.Resources.Interrogacion1 : Properties.Resources.Interrogacion2))
                    {
                        player.Play();
                    }
                    PrimaryColor = Color.MediumSlateBlue; // Color de Pregunta
                    break;
                case MessageBoxIcon.Exclamation://Exclamacion
                    this.pbIcono.Image = Properties.Resources.advertencia; // Icono de Advertencia
                    Random rndExclamacion = new Random(); // Un selector que elige un sonido aleatorio entre 1 y 2
                    int sonidoExclamacion = rndExclamacion.Next(1, 3); // Un selector que elige un sonido aleatorio entre 1 y 2
                    using (var player = new System.Media.SoundPlayer(
                    sonidoExclamacion == 1 ? Properties.Resources.Alerta1 : Properties.Resources.Alerta2))
                    {
                        player.Play();
                    }
                    PrimaryColor = Color.FromArgb(255, 140, 0);
                    break;
                case MessageBoxIcon.None: //Ninguno
                    this.pbIcono.Image = Properties.Resources.mensaje; // Icono de Mensaje en blanco
                    PrimaryColor = Color.RoyalBlue; // Color por defecto
                    using (var player = new System.Media.SoundPlayer(Properties.Resources.Mensaje_1)) // Este sonido es el predeterminado no aleatorio
                    {
                        player.Play();
                    }
                    break;
            }
        }
        //<----------------------------------------------------------------------------------->
        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ArrastrarVentana(pnlTitulo); // Con esto cuando invoco el Mouse down si sirve pero en el invocador no funciona que logica más rara
        }
        //<----------------------------------------------------------------------------------->

        private void lblTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ArrastrarVentana(lblTitulo); // Con esto cuando invoco el Mouse down si sirve pero en el invocador no funciona que logica más rara
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