using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

public class LabelTransparente : Label
{
    public LabelTransparente()
    {
        this.SetStyle(ControlStyles.Opaque, true);
        this.SetStyle(ControlStyles.OptimizedDoubleBuffer, false);
        this.SetStyle(ControlStyles.ResizeRedraw, true);
        this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        this.BackColor = Color.Transparent;

    }

    protected override CreateParams CreateParams
    {
        get
        {
            CreateParams cp = base.CreateParams;
            cp.ExStyle |= 0x20; // WS_EX_TRANSPARENT
            return cp;
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        // Dibujar solo el texto, no el fondo
        using (SolidBrush brush = new SolidBrush(this.ForeColor))
        {
            StringFormat format = new StringFormat();
            format.Alignment = GetHorizontalAlignment();
            format.LineAlignment = GetVerticalAlignment();

            e.Graphics.DrawString(this.Text, this.Font, brush,
                                this.ClientRectangle, format);
        }
    }

    private StringAlignment GetHorizontalAlignment()
    {
        switch (this.TextAlign)
        {
            case ContentAlignment.TopLeft:
            case ContentAlignment.MiddleLeft:
            case ContentAlignment.BottomLeft:
                return StringAlignment.Near;
            case ContentAlignment.TopCenter:
            case ContentAlignment.MiddleCenter:
            case ContentAlignment.BottomCenter:
                return StringAlignment.Center;
            case ContentAlignment.TopRight:
            case ContentAlignment.MiddleRight:
            case ContentAlignment.BottomRight:
                return StringAlignment.Far;
            default:
                return StringAlignment.Near;
        }
    }

    private StringAlignment GetVerticalAlignment()
    {
        switch (this.TextAlign)
        {
            case ContentAlignment.TopLeft:
            case ContentAlignment.TopCenter:
            case ContentAlignment.TopRight:
                return StringAlignment.Near;
            case ContentAlignment.MiddleLeft:
            case ContentAlignment.MiddleCenter:
            case ContentAlignment.MiddleRight:
                return StringAlignment.Center;
            case ContentAlignment.BottomLeft:
            case ContentAlignment.BottomCenter:
            case ContentAlignment.BottomRight:
                return StringAlignment.Far;
            default:
                return StringAlignment.Center;
        }
    }

    // Evitar que se pinte el fondo
    protected override void OnPaintBackground(PaintEventArgs e)
    {
        // No pintar el fondo - mantenerlo transparente
    }
}