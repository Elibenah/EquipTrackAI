using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Tikshuv.FrontEnd.StorageWindow.StorageManager
{
    public class RoundedPanel : Panel
    {
        public int CornerRadius { get; set; } = 10;

        public RoundedPanel()
        {
            DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (GraphicsPath path = RoundedRectangle(ClientRectangle, CornerRadius))
            {
                Region = new Region(path);
                using (SolidBrush brush = new SolidBrush(BackColor))
                {
                    e.Graphics.FillPath(brush, path);
                }
            }
        }

        private GraphicsPath RoundedRectangle(Rectangle bounds, int cornerRadius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = 2 * cornerRadius;
            Rectangle arc = new Rectangle(bounds.Location, new Size(diameter, diameter));

            // Top-left
            path.AddArc(arc, 180, 90);
            path.AddLine(bounds.Left + cornerRadius, bounds.Top, bounds.Right - cornerRadius, bounds.Top);

            // Top-right
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);
            path.AddLine(bounds.Right, bounds.Top + cornerRadius, bounds.Right, bounds.Bottom - cornerRadius);

            // Bottom-right
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            path.AddLine(bounds.Right - cornerRadius, bounds.Bottom, bounds.Left + cornerRadius, bounds.Bottom);

            // Bottom-left
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);
            path.AddLine(bounds.Left, bounds.Bottom - cornerRadius, bounds.Left, bounds.Top + cornerRadius);

            path.CloseFigure();
            return path;
        }
    }
}
