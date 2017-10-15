using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MDIPaint.Tools;

namespace MDIPaint
{
    public partial class MainForm : Form
    {
        // public InstrumentType Instrument { get; set; }
        // public Pen Pen { get; set; }
        public Tool Tool { get; internal set; }

        private int mChildrenSoFar = 0;
        private LinkedList<ChildForm> mChildren = new LinkedList<ChildForm>();
        private RadioButton mPreviouslySelected;

        private Dictionary<string, Tool> mToolbox = new Dictionary<string, Tool>
        {
            { "Pencil", new Pencil(Color.Black) },
            { "Brush", new Tools.BrushTool(Color.Black) },
            // { "Line", new Line(Color.Black) },
            // { "Star", new Star(Color.Black) },
            // { "Ellipse", new Ellipse(Color.Black) },
            // { "Eraser", new Eraser(Color.Black) },
            // { "ScaleIn", new ScaleIn(Color.Black) },
            // { "ScaleOut", new ScaleOut(Color.Black) },
        };

        public MainForm()
        {
            InitializeComponent();
            mPreviouslySelected = PencilRadio;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Tool = mToolbox["Pencil"];
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
            Tool = mToolbox[(string)((Control)sender).Tag];
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

        private void ThicknessText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
                e.Handled = true;
        }
    }
}
