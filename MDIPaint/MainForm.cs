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
    public partial class MainForm : Form
    {
        private int mChildrenSoFar = 0;
        private LinkedList<ChildForm> mChildren = new LinkedList<ChildForm>();
        private ToolStripButton mPreviouslySelected;

        public MainForm()
        {
            InitializeComponent();
            mPreviouslySelected = InstrumentPencil;
        }

        private void MenuNew_Click(object sender, EventArgs e)
        {
            var child = new ChildForm
            {
                MdiParent = this,
                Text = String.Format("Рисунок {0}", ++mChildrenSoFar),
            };

            child.Show();
            mChildren.AddLast(child);
        }

        private void MenuItemCloseAll_Click(object sender, EventArgs e)
        {
            foreach (var v in mChildren)
                v.Close();

            mChildren.Clear();
        }

        private void Instruments_Click(object sender, EventArgs e)
        {
            mPreviouslySelected.Checked = false;
            mPreviouslySelected = (ToolStripButton)sender;
            mPreviouslySelected.Checked = true;
        }

        private void MenuItemUndo_Click(object sender, EventArgs e)
        {
            var active = ActiveMdiChild;

            if (active != null)
            {
                ((ChildForm)active).Undo();
            }
        }

        private void MenuItemRedo_Click(object sender, EventArgs e)
        {
            var active = ActiveMdiChild;

            if (active != null)
            {
                ((ChildForm)active).Redo();
            }
        }

        private void MainFormMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var active = ActiveMdiChild;
            
            if (active != null)
            {
                var child = (ChildForm)active;

            }
        }
    }
}
