using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDIPaint.Tools
{
    public abstract class FilledTool : Tool
    {
        public FilledTool(Color color)
            : base(color)
        {
        }

        public Color FillColor
        {
            get { return brush.Color; }
            set { brush.Color = value; }
        }

        public bool Fill { get; set; }

        protected SolidBrush brush = new SolidBrush(Color.Black);
    }
}
