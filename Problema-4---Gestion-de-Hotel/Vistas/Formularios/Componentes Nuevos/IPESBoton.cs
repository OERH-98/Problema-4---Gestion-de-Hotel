///<summary>
///Este componente fue sacado de Internet
///Realizado por el equipo PTC
///</summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
namespace Vistas.Formularios.Componentes_Improvisados
{

    public class IPESBotonRedondeado : Button
    {
        // Campos
        private int borderSize = 0;
        private int borderRadius = 0;
        private Color borderColor = Color.FromArgb(1, 236, 108);
        //<----------------------------------------------------------------------------------->
        // Propiedades
        [Category("Idea Publicidad El Salvador")]
        public int BorderSize
        {
            get => borderSize;
            set { borderSize = value; this.Invalidate(); }
        }
        //<----------------------------------------------------------------------------------->
        [Category("Idea Publicidad El Salvador")]
        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                borderRadius = value;
                if (borderRadius > this.Height) borderRadius = this.Height;
                UpdateRegion(); // actualiza la región solo si cambia
                this.Invalidate();
            }
        }
        //<----------------------------------------------------------------------------------->
        [Category("Idea Publicidad El Salvador")]
        public Color BorderColor
        {
            get => borderColor;
            set { borderColor = value; this.Invalidate(); }
        }
        //<----------------------------------------------------------------------------------->
        [Category("Idea Publicidad El Salvador")]
        public Color BackgroundColor
        {
            get => this.BackColor;
            set { this.BackColor = value; }
        }
        //<----------------------------------------------------------------------------------->
        [Category("Idea Publicidad El Salvador")]
        public Color TextColor
        {
            get => this.ForeColor;
            set { this.ForeColor = value; }
        }
        //<----------------------------------------------------------------------------------->
        // Constructor
        public IPESBotonRedondeado()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;

            this.Resize += (s, e) => UpdateRegion(); // región solo en Resize

            this.SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
        }
        //<----------------------------------------------------------------------------------->
        private void UpdateRegion()
        {
            if (borderRadius > 2)
            {
                using (GraphicsPath path = GetFigurePath(this.ClientRectangle, borderRadius))
                {
                    this.Region = new Region(path);
                }
            }
            else
            {
                this.Region = null;
            }
        }
        //<----------------------------------------------------------------------------------->
        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
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
        //<----------------------------------------------------------------------------------->
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
            int smoothSize = borderSize > 0 ? borderSize : 2;

            if (borderRadius > 2)
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penSurface = new Pen(this.Parent?.BackColor ?? Color.White, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    pevent.Graphics.DrawPath(penSurface, pathSurface);
                    if (borderSize >= 1)
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else
            {
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    if (borderSize >= 1)
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                }
            }
        }
        //<----------------------------------------------------------------------------------->
        protected override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);
            if (this.Parent != null)
                this.Parent.BackColorChanged += (s, args) => this.Invalidate();
        }
        //<----------------------------------------------------------------------------------->
    }
}