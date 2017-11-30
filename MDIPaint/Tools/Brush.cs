using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDIPaint.Tools
{
    public class BrushTool : FilledTool
    {
        public BrushTool(Color color) : base(color)
        {
        }

        public override void Draw(Graphics graphics, Point start, Point end)
        {
            var halfThickness = Thickness / 2;

            start.X -= halfThickness;
            start.Y -= halfThickness;
            end.X -= halfThickness;
            end.Y -= halfThickness;

            Rectangle rect = new Rectangle(start, new Size(Thickness, Thickness));

            var len = Math.Sqrt(Math.Pow(end.X - start.X, 2) + Math.Pow(end.Y - start.Y, 2));
            var d = 0.25 * Thickness / len;

            for (double i = 0.0; i <= 1.0; i += d)
            {
                var inv = 1.0 - i;
                rect.X = (int)(start.X * inv + end.X * i);
                rect.Y = (int)(start.Y * inv + end.Y * i);
                graphics.FillEllipse(brush, rect);
            }

            // graphics.DrawEllipse(pen, rect);
        }

        public override bool NeedsPreview => false;
    }
}
