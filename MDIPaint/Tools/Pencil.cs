using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDIPaint.Tools
{
    public class Pencil : Tool
    {
        public Pencil(Color color)
            : base(color)
        {

        }

        public override void Draw(Graphics graphics, Point start, Point end)
        {
            graphics.DrawLine(pen, start, end);
        }

        public override bool NeedsPreview => false;
    }
}
