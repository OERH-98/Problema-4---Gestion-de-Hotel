///<summary>


using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vistas.Formularios.Componentes_Improvisados;
using Vistas.Formularios.Carga;
using Vistas.Properties;

namespace Vistas.Formularios.Componentes_Improvisados
{
    public class barra_de_carga_redondeada : ProgressBar
    {
        private int _radio_esquina = 10;
        private Color _color_borde = Color.FromArgb(150, 0, 0, 0); // Color por defecto semi-transparente
        private float _grosor_borde = 1f;
        private DashStyle _estilo_borde = DashStyle.Solid;
        //<----------------------------------------------------------------------------------->
        // Propiedad para establecer el radio de las esquinas redondeadas
        public int Radio_Esquina
        {
            get => _radio_esquina;
            set { _radio_esquina = value; Invalidate(); }
        }
        //<----------------------------------------------------------------------------------->
        // Propiedad para establecer el color del borde
        public Color ColorBorde
        {
            get => _color_borde;
            set { _color_borde = value; Invalidate(); }
        }
        //<----------------------------------------------------------------------------------->
        // Propiedad para establecer el grosor del borde
        public float GrosorBorde
        {
            get => _grosor_borde;
            set { _grosor_borde = value; Invalidate(); }
        }
        //<----------------------------------------------------------------------------------->
        // Propiedad para establecer el estilo del borde
        public DashStyle EstiloBorde
        {
            get => _estilo_borde;
            set { _estilo_borde = value; Invalidate(); }
        }
        //<----------------------------------------------------------------------------------->
        public barra_de_carga_redondeada()
        {
            // Configura el estilo de control para permitir el dibujo personalizado
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
                    ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;
        }
        //<----------------------------------------------------------------------------------->
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // Dibuja el fondo del control padre primero
            if (Parent != null)
            {
                Rectangle rect = new Rectangle(Left, Top, Width, Height);
                e.Graphics.TranslateTransform(-Left, -Top);
                InvokePaintBackground(Parent, e);
                InvokePaint(Parent, e);
                e.Graphics.TranslateTransform(Left, Top);
            }
            else
            {
                // Pinta el fondo
                base.OnPaintBackground(e);
            }
        }
        //<----------------------------------------------------------------------------------->
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias; // Un Anti aliasing?
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality; // Alta calidad?

            // 1. Dibuja el fondo completo (elimina esquinas negras) para que no se vea mal
            using (var directorio = GetRoundedRectPath(ClientRectangle, Radio_Esquina))
            using (var pincel = new SolidBrush(Parent?.BackColor ?? BackColor))
            {
                e.Graphics.FillPath(pincel, directorio);
            }

            // 2. Dibuja el fondo de la barra para que tenga algo solido y tenga consistencia visual
            using (var directorio = GetRoundedRectPath(ClientRectangle, Radio_Esquina))
            using (var pincelSolido = new SolidBrush(BackColor))
            {
                e.Graphics.FillPath(pincelSolido, directorio);
            }

            // 3. Dibuja el progreso
            if (Value > 0)
            {
                int anchoProgreso = (int)((double)Value / Maximum * Width);
                var progresoRecto = new Rectangle(0, 0, anchoProgreso, Height);

                // Asegurar que el progreso también tenga bordes redondeados
                if (anchoProgreso >= Radio_Esquina)
                {
                    using (var directorio_progreso = GetRoundedRectPath(progresoRecto, Radio_Esquina))
                    //Variable de Pintura (brush)
                    using (var pincel = new SolidBrush(ForeColor))
                    {
                        //Llena la barra con otra barra podria decirse para simular un progreso
                        e.Graphics.FillPath(pincel, directorio_progreso);
                    }
                }
                //Si no se cumple lo redondeado....
                else
                {
                    // Para valores muy pequeños, dibujar rectángulo normal
                    using (var pincel = new SolidBrush(ForeColor))
                    {
                        //Progreso Recto con palabra reservada (e)
                        e.Graphics.FillRectangle(pincel, progresoRecto);
                    }
                }
            }
            //<----------------------------------------------------------------------------------->
            // 4. Dibuja el borde personalizable
            using (var ruta = GetRoundedRectPath(ClientRectangle, Radio_Esquina))
            using (var lapicero = new Pen(ColorBorde, GrosorBorde))
            {
                lapicero.DashStyle = EstiloBorde;
                e.Graphics.DrawPath(lapicero, ruta);
            }
        }
        //<----------------------------------------------------------------------------------->
        //Funcion Privada que se puede personalizar los radios que tienen los bordes
        private GraphicsPath GetRoundedRectPath(Rectangle limites, int radio)
        {
            GraphicsPath ruta = new GraphicsPath();

            if (radio <= 0)
            {
                //Si no es redondeada la barra regresara a los bordes sin redondeo (progreso cuadrado)
                ruta.AddRectangle(limites);
                return ruta;
            }

            int diametro = radio * 2;
            Size size = new Size(diametro, diametro);
            Rectangle arc = new Rectangle(limites.Location, size);

            // Esquina superior izquierda
            ruta.AddArc(arc, 180, 90);

            // Esquina superior derecha
            arc.X = limites.Right - diametro;
            ruta.AddArc(arc, 270, 90);

            // Esquina inferior derecha
            arc.Y = limites.Bottom - diametro;
            ruta.AddArc(arc, 0, 90);

            // Esquina inferior izquierda
            arc.X = limites.Left;
            ruta.AddArc(arc, 90, 90);

            // Cierra el camino para completar el rectángulo redondeado
            ruta.CloseFigure();
            return ruta;
        }
        //<----------------------------------------------------------------------------------->
    }
}