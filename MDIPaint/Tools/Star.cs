using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDIPaint.Tools
{
    class Star : FilledTool
    {
        public Star(Color color) : base(color)
        {
        }

        public override void Draw(Graphics graphics, Point start, Point end)
        {
            const int NumCorners = 5;
            const double AngleIncrease = Math.PI / NumCorners;

            var dx = end.X - start.X;
            var dy = end.Y - start.Y;

            var angle = Math.Atan2(dy, dx);
            var length = Math.Sqrt(dx * dx + dy * dy);

            Point[] pts = new Point[NumCorners * 2 + 2];

            for (int i = 0; i < NumCorners; ++i)
            {
                var index = i * 2;

                pts[index] = new Point(
                    (int)(Math.Cos(angle) * length) + start.X,
                    (int)(Math.Sin(angle) * length) + start.Y
                );

                angle += AngleIncrease;

                pts[++index] = new Point(
                    (int)(Math.Cos(angle) * length * 0.5) + start.X,
                    (int)(Math.Sin(angle) * length * 0.5) + start.Y
                );

                angle += AngleIncrease;
            }


            pts[NumCorners * 2] = pts[0];
            pts[NumCorners * 2 + 1] = pts[1];


            GraphicsPath gp = new GraphicsPath();
            gp.AddLines(pts);

            pen.Width = Thickness;
            graphics.FillPath(brush, gp);
            graphics.DrawLines(pen, pts);
        }

        public override bool NeedsPreview => true;
    }
}
