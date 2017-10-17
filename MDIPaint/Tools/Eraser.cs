using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDIPaint.Tools
{
    class Eraser : BrushTool
    {
        public Eraser(Color color) : base(color)
        {
        }

        public override void Draw(Graphics graphics, Point start, Point end)
        {
            NextStroke(graphics, start, end);
        }

        public override void NextStroke(Graphics graphics, Point start, Point end)
        {
            pen.Color = brush.Color;
            base.NextStroke(graphics, start, end);
        }
    }
}
