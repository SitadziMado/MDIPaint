using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIPaint
{
    public partial class ProgressDialog : Form
    {
        public string EffectName
        {
            set
            {
                ProgressLabel.Text =
              $"Выполняется применение эффекта {value}...";
            }
        }

        public long Progress
        {
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException(
                        "Значение прогресса находится вне допустимых пределов."
                    );
                else if (value == 100)


                EffectProgressBar.Value = (int)value;
            }
        }

        public ProgressDialog()
        {
            InitializeComponent();
        }

        public ProgressDialog(string effect)
        {
            InitializeComponent();

        }

        private void ProgressDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
