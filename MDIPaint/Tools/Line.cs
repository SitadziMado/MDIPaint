using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDIPaint.Tools
{
    class Line : Tool
    {
        public Line(Color color) : base(color)
        {
        }

        public override void Draw(Graphics graphics, Point start, Point end)
        {
            pen.Width = Thickness;
            graphics.DrawLine(pen, start, end);
        }

        public override void NextStroke(Graphics graphics, Point previous, Point next)
        {
            Draw(graphics, previous, next);
        }

        public override bool NeedsPreview => true;
    }
}
