using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDIPaint.Tools
{
    class Ellipse : FilledTool
    {
        public Ellipse(Color color) : base(color)
        {
        }
        
        public override void Draw(Graphics graphics, Point start, Point end)
        {
            if (start.X > end.X || start.Y > end.Y)
            {
                var t = start;
                start = end;
                end = t;
            }

            var size = new Size(
                end.X - start.X, 
                end.Y - start.Y
            );

            Rectangle rect = new Rectangle(start, size);

            pen.Width = Thickness;
            graphics.FillEllipse(brush, rect);
            graphics.DrawEllipse(pen, rect);
        }

        public override void NextStroke(Graphics graphics, Point previous, Point next)
        {
            throw new NotImplementedException();
        }

        public override bool NeedsPreview => true;
    }
}
