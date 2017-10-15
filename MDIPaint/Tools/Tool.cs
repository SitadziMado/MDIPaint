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
            Color = color;
        }

        public abstract void Draw(
            Graphics graphics, 
            Point start, 
            Point end
        );

        public virtual Color Color
        {
            get => pen.Color;
            set => pen = new Pen(value);     
        }

        protected Pen pen;
    }
}
