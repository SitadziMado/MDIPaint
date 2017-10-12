using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIPaint
{
    public partial class ChildForm : Form
    {
        public Bitmap Image => mCurrentBuffer.Value;
        public bool CanUndo => mCurrentBuffer.Previous != null;
        public bool CanRedo => mCurrentBuffer.Next != null;
        public bool IsChanged { get; internal set; }

        private const int RestorationPointMax = 64;
        private const double ScaleIncrease = 0.1;

        private bool mNeedBackup = false;
        private bool mDraw = true;
        private bool mResized = false;
        private LinkedList<Bitmap> mBuffers = new LinkedList<Bitmap>();
        private LinkedListNode<Bitmap> mCurrentBuffer;
        private Graphics mBackBuffer;
        private Point mPrevious;
        private string mFilename = String.Empty;

        private Point mStartPt;
        private Point mFinishPt;
        private double mScaleFactor = 1.0;

        public ChildForm()
        {
            InitializeComponent();
            mBuffers.AddLast(new Bitmap(Width, Height));
            mCurrentBuffer = mBuffers.Last;
            UpdateGraphics();
            MouseWheel += ChildForm_MouseWheel;
        }

        public void Undo()
        {
            if (mCurrentBuffer.Previous != null)
            {
                mCurrentBuffer = mCurrentBuffer.Previous;
                UpdateGraphics();
                Redraw();
            }
        }

        public void Redo()
        {
            if (mCurrentBuffer.Next != null)
            {
                mCurrentBuffer = mCurrentBuffer.Next;
                UpdateGraphics();
                Redraw();
            }
        }

        public DialogResult SaveAs()
        {
            return SaveImageDialog.ShowDialog();
        }

        public DialogResult Save()
        {
            if (mFilename != "")
            {
                Image.Save(mFilename);
                IsChanged = false;
                Text = mFilename;
                return DialogResult.OK;
            }
            else
            {
                return SaveAs();
            }
        }

        public void Zoom(bool expand)
        {
            if (expand)
                mScaleFactor += ScaleIncrease;
            else
                mScaleFactor -= ScaleIncrease;

            FitContents();
            Redraw();
        }

        private void FitContents()
        {
            Canvas.Width = Scale(mCurrentBuffer.Value.Width);
            Canvas.Height = Scale(mCurrentBuffer.Value.Height);
        }

        private void AddRestorationPoint()
        {
            while (mCurrentBuffer.Next != null)
                mBuffers.Remove(mCurrentBuffer.Next);

            var last = mCurrentBuffer;
            mBuffers.AddBefore(last, new Bitmap(last.Value));

            if (mBuffers.Count > RestorationPointMax)
                mBuffers.RemoveFirst();
        }

        private void Redraw()
        {
            Canvas.Invalidate();
        }

        private void ChangeBitmapSize()
        {
            AddRestorationPoint();
            var bmp = new Bitmap(Unscale(Canvas.Width), Unscale(Canvas.Height));
            var grp = Graphics.FromImage(bmp);
            grp.DrawImage(mCurrentBuffer.Value, 0, 0);
            mBuffers.RemoveLast();
            mBuffers.AddLast(bmp);
            
            mCurrentBuffer = mBuffers.Last;
            UpdateGraphics();
        }
        
        private void StrikeTo(Point next)
        {
            if (mNeedBackup)
            {
                AddRestorationPoint();
                mNeedBackup = false;
            }

            IsChanged = true;

            MainForm parent = (MainForm)ParentForm;

            switch (parent.Instrument)
            {
                case InstrumentType.Pencil:
                    mBackBuffer.DrawLine(
                        parent.Pen,
                        Unscale(mPrevious),
                        Unscale(next)
                    );
                    break;

                case InstrumentType.Eraser:
                    break;

                case InstrumentType.Line:
                    break;

                case InstrumentType.Ellipse:
                    break;

                case InstrumentType.Star:
                    break;
                case InstrumentType.ScaleUp:
                    break;

                case InstrumentType.ScaleDown:
                    break;

                default:
                    break;
            }

            mPrevious = next;
        }

        private void UpdateGraphics()
        {
            //Canvas.Image = mCurrentBuffer.Value;
            mBackBuffer = Graphics.FromImage(mCurrentBuffer.Value);

            mBackBuffer.CompositingQuality = CompositingQuality.AssumeLinear;
            mBackBuffer.InterpolationMode = InterpolationMode.Low;
            mBackBuffer.SmoothingMode = SmoothingMode.None;

            FitContents();
        }

        private int Scale(int coordinate)
        {
            return (int)(coordinate * mScaleFactor);
        }

        private int Unscale(int coordinate)
        {
            return (int)(coordinate / mScaleFactor);
        }

        private Point Scale(Point coordinates)
        {
            return new Point(
                (int)(coordinates.X * mScaleFactor), 
                (int)(coordinates.Y * mScaleFactor)
            );
        }

        private Point Unscale(Point coordinates)
        {
            return new Point(
                (int)(coordinates.X / mScaleFactor),
                (int)(coordinates.Y / mScaleFactor)
            );
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mNeedBackup = true;
                mStartPt = e.Location;
            }

            mPrevious = e.Location;
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (mDraw)
                {
                    StrikeTo(e.Location);
                    Redraw();
                }
                else
                {
                    mResized = true;
                    Canvas.Width = Math.Max(7, Canvas.Width + e.X - mPrevious.X);
                    Canvas.Height = Math.Max(7, Canvas.Height + e.Y - mPrevious.Y);
                }
            }
            else if (e.Button == MouseButtons.None)
            {
                if (Canvas.Width - e.X < 7 && Canvas.Height - e.Y < 7)
                {
                    mDraw = false;
                    Canvas.Cursor = Cursors.SizeNWSE;
                }
                else
                {
                    mDraw = true;
                    Canvas.Cursor = Cursors.Default;
                }
            }

            mPrevious = e.Location;
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (mResized)
            {
                ChangeBitmapSize();
                mResized = false;
            }

            mNeedBackup = false;
            mPrevious = e.Location;
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            var bmp = mCurrentBuffer.Value;

            e.Graphics.CompositingQuality = CompositingQuality.AssumeLinear;
            e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
            e.Graphics.SmoothingMode = SmoothingMode.None;
            
            e.Graphics.DrawImage(bmp, 0, 0, Scale(bmp.Width), Scale(bmp.Height));
        }

        private void Canvas_Resize(object sender, EventArgs e)
        {
        }

        private void ChildForm_MouseWheel(object sender, MouseEventArgs e)
        {
            if ((ModifierKeys & Keys.Alt) != 0)
                Zoom(e.Delta >= 0);
        }

        private void ChildForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = DialogResult.No;

            if (IsChanged)
            {
                result = MessageBox.Show(
                    "Изображение было изменено. Сохранить изменения?",
                    "Сохранить изменения?",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Information
                );
            }

            switch (result)
            {
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;

                case DialogResult.Yes:
                    result = SaveAs();
                    if (result == DialogResult.Cancel)
                        e.Cancel = true;
                    break;

                case DialogResult.No:
                    break;

                default:
                    throw new ArgumentOutOfRangeException(
                        "Неверный код возврата от диалогового окна."
                    );
            }
        }

        private void SaveImageDialog_FileOk(object sender, CancelEventArgs e)
        {
            mFilename = SaveImageDialog.FileName;
            Save();
        }
    }
}
