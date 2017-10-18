using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDIPaint.Tools
{
    public abstract class Tool
    {
        public Tool(Color color)
        {
            BorderColor = color;
            Thickness = 1;
        }

        public abstract void Draw(
            Graphics graphics,
            Point start,
            Point end
        );

        public Color BorderColor
        {
            get => pen.Color;
            set => pen.Color = value;     
        }

        public abstract bool NeedsPreview { get; }

        public int Thickness { get; set; }

        protected Pen pen = new Pen(Color.Black);
    }
}
