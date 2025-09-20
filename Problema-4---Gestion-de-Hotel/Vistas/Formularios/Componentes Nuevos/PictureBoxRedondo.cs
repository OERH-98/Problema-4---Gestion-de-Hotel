///<summary>

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls.RJControls
{
    class PictureBoxRedondo : PictureBox
    {
        // Propiedades para personalizar el borde y el gradiente
        private int medidaBorde = 2;
        private Color colorBorde1 = Color.RoyalBlue;
        private Color colorBorde2 = Color.HotPink;
        private DashStyle borderLineStyle = DashStyle.Solid;
        private DashCap borderCapStyle = DashCap.Flat;
        private float gradientAngle = 50F;
        private GraphicsPath cachedPath;
        //<----------------------------------------------------------------------------------->
        public PictureBoxRedondo()
        {
            this.Size = new Size(100, 100);
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.BackColor = Color.Transparent;
            this.DoubleBuffered = true;
            UpdateRegion(); // Calcula el área redondeada inicial
        }
        //<----------------------------------------------------------------------------------->
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x00000020; // WS_EX_TRANSPARENT en vez de COMPOSITED eso me ayuda a que no trabe el formulario entero
                return cp;
            }
        }
        //<----------------------------------------------------------------------------------->
        [Category("Idea Publicidad El Salvador")]
        public int BorderSize
        {
            get => medidaBorde;
            set { medidaBorde = value; Invalidate(); }
        }
        //<----------------------------------------------------------------------------------->
        [Category("Idea Publicidad El Salvador")]
        public Color BorderColor
        {
            get => colorBorde1;
            set { colorBorde1 = value; Invalidate(); }
        }
        //<----------------------------------------------------------------------------------->
        [Category("Idea Publicidad El Salvador")]
        public Color BorderColor2
        {
            get => colorBorde2;
            set { colorBorde2 = value; Invalidate(); }
        }
        //<----------------------------------------------------------------------------------->
        [Category("Idea Publicidad El Salvador")]
        public DashStyle BorderLineStyle
        {
            get => borderLineStyle;
            set { borderLineStyle = value; Invalidate(); }
        }
        //<----------------------------------------------------------------------------------->
        [Category("Idea Publicidad El Salvador")]
        public DashCap BorderCapStyle
        {
            get => borderCapStyle;
            set { borderCapStyle = value; Invalidate(); }
        }
        //<----------------------------------------------------------------------------------->
        [Category("Idea Publicidad El Salvador")]
        public float GradientAngle
        {
            get => gradientAngle;
            set { gradientAngle = value; Invalidate(); }
        }
        //<----------------------------------------------------------------------------------->
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Size = new Size(this.Width, this.Width);
            UpdateRegion(); // Solo recalcula la región redondeada si cambia el tamaño
        }
        //<----------------------------------------------------------------------------------->
        private void UpdateRegion()
        {
            cachedPath?.Dispose();
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            cachedPath = new GraphicsPath();
            cachedPath.AddEllipse(rect);
            this.Region = new Region(cachedPath);
        }
        //<----------------------------------------------------------------------------------->
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Graphics graph = pe.Graphics;
            graph.SmoothingMode = SmoothingMode.AntiAlias;

            var rectSmooth = Rectangle.Inflate(this.ClientRectangle, -1, -1);
            var rectBorder = Rectangle.Inflate(rectSmooth, -medidaBorde, -medidaBorde);
            int smoothSize = medidaBorde > 0 ? medidaBorde * 3 : 1;

            using (var borderBrush = new LinearGradientBrush(rectBorder, colorBorde1, colorBorde2, gradientAngle))
            using (var penSmooth = new Pen(this.Parent?.BackColor ?? Color.White, smoothSize))
            using (var penBorder = new Pen(borderBrush, medidaBorde))
            {
                penBorder.DashStyle = borderLineStyle;
                penBorder.DashCap = borderCapStyle;

                graph.DrawEllipse(penSmooth, rectSmooth);

                if (medidaBorde > 0)
                    graph.DrawEllipse(penBorder, rectBorder);
            }
        }
        //<----------------------------------------------------------------------------------->
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                cachedPath?.Dispose();
            }
            base.Dispose(disposing);
        }
        //<----------------------------------------------------------------------------------->
    }
}