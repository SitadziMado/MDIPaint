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
        public InstrumentType Instrument { get; set; }
        public Pen Pen { get; set; }

        private int mChildrenSoFar = 0;
        private LinkedList<ChildForm> mChildren = new LinkedList<ChildForm>();
        private ToolStripButton mPreviouslySelected;

        public MainForm()
        {
            InitializeComponent();
            mPreviouslySelected = InstrumentPencil;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Pen = Pens.Black;
        }

        private void MenuNew_Click(object sender, EventArgs e)
        {
            var child = new ChildForm
            {
                MdiParent = this,
                Text = string.Format("Рисунок {0}", ++mChildrenSoFar),
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
            (ActiveMdiChild as ChildForm)?.Undo();
        }

        private void MenuItemRedo_Click(object sender, EventArgs e)
        {
            (ActiveMdiChild as ChildForm)?.Redo();
        }

        private void MenuEdit_DropDownOpening(object sender, EventArgs e)
        {
            var active = ActiveMdiChild;

            if (active != null)
            {
                var child = (ChildForm)active;
                MenuItemUndo.Enabled = child.CanUndo;
                MenuItemRedo.Enabled = child.CanRedo;
            }
            else
            {
                MenuItemUndo.Enabled = false;
                MenuItemRedo.Enabled = false;
            }

        }

        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuItemSave_Click(object sender, EventArgs e)
        {
            (ActiveMdiChild as ChildForm)?.Save();
        }

        private void MenuItemSaveAs_Click(object sender, EventArgs e)
        {
            (ActiveMdiChild as ChildForm)?.SaveAs();
        }

        private void MenuFile_DropDownOpening(object sender, EventArgs e)
        {
            if (mChildren.Count >= 1)
            {
                MenuItemClose.Enabled = true;
                MenuItemCloseAll.Enabled = true;
                MenuItemSaveAs.Enabled = true;
            }
            else
            {
                MenuItemClose.Enabled = false;
                MenuItemCloseAll.Enabled = false;
                MenuItemSaveAs.Enabled = false;

            }

            var active = ActiveMdiChild;

            if (active != null)
            {
                var child = (ChildForm)active;

                if (child.IsChanged)
                {
                    MenuItemSave.Enabled = true;
                    return;
                }
            }

            MenuItemSave.Enabled = false;
        }

        private void MenuItemClose_Click(object sender, EventArgs e)
        {
            ActiveMdiChild?.Close();
        }
    }
}
