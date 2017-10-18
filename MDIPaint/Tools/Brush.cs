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

            Rectangle rect = new Rectangle(start, new Size(Thickness, Thickness));

            graphics.FillEllipse(brush, rect);
            // graphics.DrawEllipse(pen, rect);
        }

        public override bool NeedsPreview => false;
    }
}
