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
    public partial class ChildForm : Form
    {
        private const int RestorationPointMax = 64;

        private bool mIsModified;
        private bool mNeedBackup = false;
        private bool mDraw = true;
        private LinkedList<Bitmap> mBuffers = new LinkedList<Bitmap>();
        private LinkedListNode<Bitmap> mCurrentBuffer;
        private Graphics mBackBuffer;
        private Point mPrevious;

        public ChildForm()
        {
            InitializeComponent();
            mBuffers.AddLast(new Bitmap(Width, Height));
            mCurrentBuffer = mBuffers.Last;
            UpdateGraphics();
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
            mBuffers.AddLast(new Bitmap(mCurrentBuffer.Value, Width, Height));
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

            mIsModified = true;
            mBackBuffer.DrawLine(Pens.Black, mPrevious, next);
            mPrevious = next;
        }

        private void UpdateGraphics()
        {
            mBackBuffer = Graphics.FromImage(mCurrentBuffer.Value);
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mNeedBackup = true;
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
                    Canvas.Width += e.X - mPrevious.X;
                    Canvas.Height += e.Y - mPrevious.Y;
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
            mNeedBackup = false;
            mPrevious = e.Location;
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(mCurrentBuffer.Value, 0, 0);
        }
        
        private void Canvas_Resize(object sender, EventArgs e)
        {
        }
    }
}
