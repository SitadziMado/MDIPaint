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
            { "Line", new Line(Color.Black) },
            { "Star", new Star(Color.Black) },
            { "Ellipse", new Ellipse(Color.Black) },
            { "Eraser", new Eraser(Color.Black) },
            // { "ScaleIn", new ScaleIn(Color.Black) },
            // { "ScaleOut", new ScaleOut(Color.Black) },
        };

        public MainForm()
        {
            InitializeComponent();
            mPreviouslySelected = PencilRadio;
        }

        private void UpdateTool()
        {
            var borderColor = Color.FromArgb(
                AlphaBar.Value, BorderColorButton.BackColor
            );

            var fillColor = Color.FromArgb(
                AlphaBar.Value, FillColorButton.BackColor
            );

            Tool.Thickness = int.Parse(ThicknessText.Text);
            Tool.BorderColor = borderColor;

            if (Tool is FilledTool)
                (Tool as FilledTool).FillColor = fillColor;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Tool = mToolbox["Pencil"];
        }

        private void MenuItemNew_Click(object sender, EventArgs e)
        {
            var child = new ChildForm
            {
                MdiParent = this,
                Text = string.Format("Рисунок {0}", ++mChildrenSoFar),
            };

            child.Show();
            mChildren.AddLast(child);
        }

        private void MenuItemOpen_Click(object sender, EventArgs e)
        {
            var result = OpenImageDialog.ShowDialog();
        }

        private void OpenImageDialog_FileOk(object sender, CancelEventArgs e)
        {
            var child = new ChildForm(OpenImageDialog.FileName)
            {
                MdiParent = this,
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

        private void Tools_Click(object sender, EventArgs e)
        {
            Tool = mToolbox[(string)((Control)sender).Tag];
            UpdateTool();
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

        private void ThicknessText_TextChanged(object sender, EventArgs e)
        {
            UpdateTool();
        }

        private void BorderColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog.Color = BorderColorButton.BackColor;

            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                BorderColorButton.BackColor = ColorDialog.Color;
                UpdateTool();
            }
        }

        private void FillColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog.Color = FillColorButton.BackColor;

            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                FillColorButton.BackColor = ColorDialog.Color;
                UpdateTool();
            }
        }

        private void AlphaBar_ValueChanged(object sender, EventArgs e)
        {
            AlphaLabel.Text = String.Format(
                "Непрозрачность: {0}", 
                AlphaBar.Value
            );

            UpdateTool();
        }

        private void XchgButton_Click(object sender, EventArgs e)
        {
            var color = BorderColorButton.BackColor;
            BorderColorButton.BackColor = FillColorButton.BackColor;
            FillColorButton.BackColor = color;
            UpdateTool();
        }

        private void MenuItemCascade_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void MenuItemLeftToRight_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void MenuItemTopToBottom_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void MenuItemArrange_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void MenuImage_DropDownOpening(object sender, EventArgs e)
        {
            var active = ActiveMdiChild;

            if (active != null)
            {
                var child = (ChildForm)active;
                MenuItemEmboss.Enabled = true;
                MenuItemSharpen.Enabled = true;
                MenuItemSmooth.Enabled = true;
                MenuItemDiffuse.Enabled = true;
                MenuItemRotateCCW.Enabled = true;
                MenuItemRotateCW.Enabled = true;
                MenuItemFlipHorz.Enabled = true;
                MenuItemFlipVert.Enabled = true;
            }
            else
            {
                MenuItemEmboss.Enabled = false;
                MenuItemSharpen.Enabled = false;
                MenuItemSmooth.Enabled = false;
                MenuItemDiffuse.Enabled = false;
                MenuItemRotateCCW.Enabled = false;
                MenuItemRotateCW.Enabled = false;
                MenuItemFlipHorz.Enabled = false;
                MenuItemFlipVert.Enabled = false;
            }
        }

        private void MenuItemEmboss_Click(object sender, EventArgs e) => (ActiveMdiChild as ChildForm).Emboss();

        private void MenuItemSharpen_Click(object sender, EventArgs e) => (ActiveMdiChild as ChildForm).Sharpen();

        private void MenuItemSmooth_Click(object sender, EventArgs e) => (ActiveMdiChild as ChildForm).Smooth();

        private void MenuItemDiffuse_Click(object sender, EventArgs e) => (ActiveMdiChild as ChildForm).Diffuse();

        private void MenuItemRotateCCW_Click(object sender, EventArgs e) => (ActiveMdiChild as ChildForm).RotateCCW();

        private void MenuItemRotateCW_Click(object sender, EventArgs e) => (ActiveMdiChild as ChildForm).RotateCW();

        private void MenuItemFlipHorz_Click(object sender, EventArgs e) => (ActiveMdiChild as ChildForm).FlipHorizontal();

        private void MenuItemFlipVert_Click(object sender, EventArgs e) => (ActiveMdiChild as ChildForm).FlipVertical();
    }
}
