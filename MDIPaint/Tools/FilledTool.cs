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

        public override Color Color
        {
            get => base.Color;
            set
            {
                base.Color = value;
                brush = new SolidBrush(value);
            }
        }

        public bool Fill { get; set; }

        protected Brush brush;
    }
}
