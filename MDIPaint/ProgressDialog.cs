using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIPaint
{
    public partial class ProgressDialog : Form
    {
        public delegate void ProgressEffectAction(Bitmap src, ref long progress);

        private Bitmap mBitmap;
        private ProgressEffectAction mAction;
        private string mName;
        private long mProgress;

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

                EffectProgressBar.Value = (int)value;
            }
        }

        public ProgressDialog(Bitmap bitmap, ProgressEffectAction action, string name)
        {
            InitializeComponent();

            mBitmap = bitmap;
            mAction = action;
            mName = name;
        }
        
        private void ProgressDialog_Load(object sender, EventArgs e)
        {
            DoEffect.RunWorkerAsync();
        }

        private void DoEffect_DoWork(object sender, DoWorkEventArgs e)
        {
            mProgress = 0L;

            // var buffer = ;

            var task = Task.Factory.StartNew(
                () => mAction(mBitmap, ref mProgress)
            );

            while (!task.IsCompleted)
            {
                DoEffect.ReportProgress((int)mProgress);
                Thread.Sleep(100);
            }
        }

        private void DoEffect_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Progress = mProgress;
        }

        private void DoEffect_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Close();
        }
    }
}
