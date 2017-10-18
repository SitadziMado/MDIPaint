using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            pen.Color = brush.Color = Color.Transparent;
            graphics.CompositingMode = CompositingMode.SourceCopy;
            base.Draw(graphics, start, end);
            graphics.CompositingMode = CompositingMode.SourceOver;
        }
    }
}
