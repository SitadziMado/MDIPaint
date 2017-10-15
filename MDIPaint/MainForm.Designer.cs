namespace MDIPaint
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Panel panel1;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
            System.Windows.Forms.Label label1;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ScaleOutRadio = new System.Windows.Forms.RadioButton();
            this.ScaleInRadio = new System.Windows.Forms.RadioButton();
            this.EraserRadio = new System.Windows.Forms.RadioButton();
            this.EllipseRadio = new System.Windows.Forms.RadioButton();
            this.StarRadio = new System.Windows.Forms.RadioButton();
            this.LineRadio = new System.Windows.Forms.RadioButton();
            this.BrushRadio = new System.Windows.Forms.RadioButton();
            this.PencilRadio = new System.Windows.Forms.RadioButton();
            this.ThicknessText = new System.Windows.Forms.TextBox();
            this.FillCheck = new System.Windows.Forms.CheckBox();
            this.MainFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.раздToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.параметрыСтраницыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemCut = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.форматToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemLeftToRight = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemTopToBottom = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemArrange = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            panel1 = new System.Windows.Forms.Panel();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            this.MainFormMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(this.tableLayoutPanel1);
            panel1.Dock = System.Windows.Forms.DockStyle.Left;
            panel1.Location = new System.Drawing.Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(142, 538);
            panel1.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ScaleOutRadio, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.ScaleInRadio, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.EraserRadio, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.EllipseRadio, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.StarRadio, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.LineRadio, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BrushRadio, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.PencilRadio, 0, 0);
            this.tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.FillCheck, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(109, 538);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // ScaleOutRadio
            // 
            this.ScaleOutRadio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ScaleOutRadio.Appearance = System.Windows.Forms.Appearance.Button;
            this.ScaleOutRadio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ScaleOutRadio.Font = new System.Drawing.Font("Courier New", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScaleOutRadio.Location = new System.Drawing.Point(57, 165);
            this.ScaleOutRadio.Name = "ScaleOutRadio";
            this.ScaleOutRadio.Size = new System.Drawing.Size(48, 48);
            this.ScaleOutRadio.TabIndex = 7;
            this.ScaleOutRadio.Tag = "ScaleOut";
            this.ScaleOutRadio.Text = "-";
            this.ScaleOutRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ScaleOutRadio.UseVisualStyleBackColor = true;
            this.ScaleOutRadio.CheckedChanged += new System.EventHandler(this.Instruments_Click);
            // 
            // ScaleInRadio
            // 
            this.ScaleInRadio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ScaleInRadio.Appearance = System.Windows.Forms.Appearance.Button;
            this.ScaleInRadio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ScaleInRadio.Font = new System.Drawing.Font("Courier New", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScaleInRadio.Location = new System.Drawing.Point(3, 165);
            this.ScaleInRadio.Name = "ScaleInRadio";
            this.ScaleInRadio.Size = new System.Drawing.Size(48, 48);
            this.ScaleInRadio.TabIndex = 6;
            this.ScaleInRadio.Tag = "ScaleIn";
            this.ScaleInRadio.Text = "+";
            this.ScaleInRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ScaleInRadio.UseVisualStyleBackColor = true;
            this.ScaleInRadio.CheckedChanged += new System.EventHandler(this.Instruments_Click);
            // 
            // EraserRadio
            // 
            this.EraserRadio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EraserRadio.Appearance = System.Windows.Forms.Appearance.Button;
            this.EraserRadio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EraserRadio.Font = new System.Drawing.Font("Wingdings 2", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.EraserRadio.Location = new System.Drawing.Point(57, 111);
            this.EraserRadio.Name = "EraserRadio";
            this.EraserRadio.Size = new System.Drawing.Size(48, 48);
            this.EraserRadio.TabIndex = 5;
            this.EraserRadio.Tag = "Eraser";
            this.EraserRadio.Text = "%";
            this.EraserRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EraserRadio.UseVisualStyleBackColor = true;
            this.EraserRadio.CheckedChanged += new System.EventHandler(this.Instruments_Click);
            // 
            // EllipseRadio
            // 
            this.EllipseRadio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EllipseRadio.Appearance = System.Windows.Forms.Appearance.Button;
            this.EllipseRadio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EllipseRadio.Font = new System.Drawing.Font("Wingdings 2", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.EllipseRadio.Location = new System.Drawing.Point(3, 111);
            this.EllipseRadio.Name = "EllipseRadio";
            this.EllipseRadio.Size = new System.Drawing.Size(48, 48);
            this.EllipseRadio.TabIndex = 4;
            this.EllipseRadio.Tag = "Ellipse";
            this.EllipseRadio.Text = "";
            this.EllipseRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EllipseRadio.UseVisualStyleBackColor = true;
            this.EllipseRadio.CheckedChanged += new System.EventHandler(this.Instruments_Click);
            // 
            // StarRadio
            // 
            this.StarRadio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.StarRadio.Appearance = System.Windows.Forms.Appearance.Button;
            this.StarRadio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StarRadio.Font = new System.Drawing.Font("Wingdings", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.StarRadio.Location = new System.Drawing.Point(57, 57);
            this.StarRadio.Name = "StarRadio";
            this.StarRadio.Size = new System.Drawing.Size(48, 48);
            this.StarRadio.TabIndex = 3;
            this.StarRadio.Tag = "Star";
            this.StarRadio.Text = "«";
            this.StarRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StarRadio.UseVisualStyleBackColor = true;
            this.StarRadio.CheckedChanged += new System.EventHandler(this.Instruments_Click);
            // 
            // LineRadio
            // 
            this.LineRadio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LineRadio.Appearance = System.Windows.Forms.Appearance.Button;
            this.LineRadio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LineRadio.Font = new System.Drawing.Font("Wingdings 3", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.LineRadio.Location = new System.Drawing.Point(3, 57);
            this.LineRadio.Name = "LineRadio";
            this.LineRadio.Size = new System.Drawing.Size(48, 48);
            this.LineRadio.TabIndex = 2;
            this.LineRadio.Tag = "Line";
            this.LineRadio.Text = "k";
            this.LineRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LineRadio.UseVisualStyleBackColor = true;
            this.LineRadio.CheckedChanged += new System.EventHandler(this.Instruments_Click);
            // 
            // BrushRadio
            // 
            this.BrushRadio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BrushRadio.Appearance = System.Windows.Forms.Appearance.Button;
            this.BrushRadio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BrushRadio.Font = new System.Drawing.Font("Wingdings 2", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.BrushRadio.Location = new System.Drawing.Point(57, 3);
            this.BrushRadio.Name = "BrushRadio";
            this.BrushRadio.Size = new System.Drawing.Size(48, 48);
            this.BrushRadio.TabIndex = 1;
            this.BrushRadio.Tag = "Brush";
            this.BrushRadio.Text = "#";
            this.BrushRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BrushRadio.UseVisualStyleBackColor = true;
            this.BrushRadio.CheckedChanged += new System.EventHandler(this.Instruments_Click);
            // 
            // PencilRadio
            // 
            this.PencilRadio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PencilRadio.Appearance = System.Windows.Forms.Appearance.Button;
            this.PencilRadio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PencilRadio.Checked = true;
            this.PencilRadio.Font = new System.Drawing.Font("Wingdings", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.PencilRadio.Location = new System.Drawing.Point(3, 3);
            this.PencilRadio.Name = "PencilRadio";
            this.PencilRadio.Size = new System.Drawing.Size(48, 48);
            this.PencilRadio.TabIndex = 0;
            this.PencilRadio.TabStop = true;
            this.PencilRadio.Tag = "Pencil";
            this.PencilRadio.Text = "!";
            this.PencilRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PencilRadio.UseVisualStyleBackColor = true;
            this.PencilRadio.CheckedChanged += new System.EventHandler(this.Instruments_Click);
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(tableLayoutPanel2, 2);
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(this.ThicknessText, 1, 0);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            tableLayoutPanel2.Location = new System.Drawing.Point(3, 219);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new System.Drawing.Size(103, 29);
            tableLayoutPanel2.TabIndex = 11;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(3, 7);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(62, 15);
            label1.TabIndex = 8;
            label1.Text = "Толщина:";
            // 
            // ThicknessText
            // 
            this.ThicknessText.Dock = System.Windows.Forms.DockStyle.Right;
            this.ThicknessText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThicknessText.Location = new System.Drawing.Point(71, 3);
            this.ThicknessText.MaxLength = 3;
            this.ThicknessText.Name = "ThicknessText";
            this.ThicknessText.Size = new System.Drawing.Size(40, 23);
            this.ThicknessText.TabIndex = 9;
            this.ThicknessText.TabStop = false;
            this.ThicknessText.Text = "1";
            this.ThicknessText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ThicknessText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ThicknessText_KeyPress);
            // 
            // FillCheck
            // 
            this.FillCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tableLayoutPanel1.SetColumnSpan(this.FillCheck, 2);
            this.FillCheck.Dock = System.Windows.Forms.DockStyle.Top;
            this.FillCheck.Enabled = false;
            this.FillCheck.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FillCheck.Location = new System.Drawing.Point(3, 254);
            this.FillCheck.Name = "FillCheck";
            this.FillCheck.Size = new System.Drawing.Size(103, 23);
            this.FillCheck.TabIndex = 12;
            this.FillCheck.TabStop = false;
            this.FillCheck.Text = "&Заливка";
            this.FillCheck.UseVisualStyleBackColor = true;
            // 
            // MainFormMenuStrip
            // 
            this.MainFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.MenuEdit,
            this.форматToolStripMenuItem,
            this.видToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.MenuWindows,
            this.помощьToolStripMenuItem});
            this.MainFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainFormMenuStrip.MdiWindowListItem = this.MenuWindows;
            this.MainFormMenuStrip.Name = "MainFormMenuStrip";
            this.MainFormMenuStrip.Size = new System.Drawing.Size(784, 24);
            this.MainFormMenuStrip.TabIndex = 1;
            this.MainFormMenuStrip.Text = "File";
            // 
            // MenuFile
            // 
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuNew,
            this.открытьToolStripMenuItem,
            this.toolStripSeparator4,
            this.MenuItemClose,
            this.MenuItemCloseAll,
            this.toolStripSeparator5,
            this.MenuItemSave,
            this.MenuItemSaveAs,
            this.раздToolStripMenuItem,
            this.параметрыСтраницыToolStripMenuItem,
            this.печатьToolStripMenuItem,
            this.toolStripSeparator1,
            this.MenuItemExit});
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(48, 20);
            this.MenuFile.Text = "&Файл";
            this.MenuFile.DropDownOpening += new System.EventHandler(this.MenuFile_DropDownOpening);
            // 
            // MenuNew
            // 
            this.MenuNew.Name = "MenuNew";
            this.MenuNew.Size = new System.Drawing.Size(204, 22);
            this.MenuNew.Text = "&Новый";
            this.MenuNew.Click += new System.EventHandler(this.MenuNew_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.открытьToolStripMenuItem.Text = "&Открыть...";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(201, 6);
            // 
            // MenuItemClose
            // 
            this.MenuItemClose.Name = "MenuItemClose";
            this.MenuItemClose.Size = new System.Drawing.Size(204, 22);
            this.MenuItemClose.Text = "&Закрыть";
            this.MenuItemClose.Click += new System.EventHandler(this.MenuItemClose_Click);
            // 
            // MenuItemCloseAll
            // 
            this.MenuItemCloseAll.Name = "MenuItemCloseAll";
            this.MenuItemCloseAll.Size = new System.Drawing.Size(204, 22);
            this.MenuItemCloseAll.Text = "З&акрыть все";
            this.MenuItemCloseAll.Click += new System.EventHandler(this.MenuItemCloseAll_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(201, 6);
            // 
            // MenuItemSave
            // 
            this.MenuItemSave.Name = "MenuItemSave";
            this.MenuItemSave.Size = new System.Drawing.Size(204, 22);
            this.MenuItemSave.Text = "&Сохранить";
            this.MenuItemSave.Click += new System.EventHandler(this.MenuItemSave_Click);
            // 
            // MenuItemSaveAs
            // 
            this.MenuItemSaveAs.Name = "MenuItemSaveAs";
            this.MenuItemSaveAs.Size = new System.Drawing.Size(204, 22);
            this.MenuItemSaveAs.Text = "Со&хранить как...";
            this.MenuItemSaveAs.Click += new System.EventHandler(this.MenuItemSaveAs_Click);
            // 
            // раздToolStripMenuItem
            // 
            this.раздToolStripMenuItem.Name = "раздToolStripMenuItem";
            this.раздToolStripMenuItem.Size = new System.Drawing.Size(201, 6);
            // 
            // параметрыСтраницыToolStripMenuItem
            // 
            this.параметрыСтраницыToolStripMenuItem.Name = "параметрыСтраницыToolStripMenuItem";
            this.параметрыСтраницыToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.параметрыСтраницыToolStripMenuItem.Text = "Па&раметры страницы...";
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.печатьToolStripMenuItem.Text = "&Печать";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(201, 6);
            // 
            // MenuItemExit
            // 
            this.MenuItemExit.Name = "MenuItemExit";
            this.MenuItemExit.Size = new System.Drawing.Size(204, 22);
            this.MenuItemExit.Text = "&Выход";
            this.MenuItemExit.Click += new System.EventHandler(this.MenuItemExit_Click);
            // 
            // MenuEdit
            // 
            this.MenuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemUndo,
            this.MenuItemRedo,
            this.toolStripSeparator2,
            this.MenuItemCut,
            this.MenuItemCopy,
            this.MenuItemPaste,
            this.toolStripSeparator3,
            this.MenuItemSelectAll});
            this.MenuEdit.Name = "MenuEdit";
            this.MenuEdit.Size = new System.Drawing.Size(59, 20);
            this.MenuEdit.Text = "&Правка";
            this.MenuEdit.DropDownOpening += new System.EventHandler(this.MenuEdit_DropDownOpening);
            // 
            // MenuItemUndo
            // 
            this.MenuItemUndo.Name = "MenuItemUndo";
            this.MenuItemUndo.Size = new System.Drawing.Size(148, 22);
            this.MenuItemUndo.Text = "&Отменить";
            this.MenuItemUndo.Click += new System.EventHandler(this.MenuItemUndo_Click);
            // 
            // MenuItemRedo
            // 
            this.MenuItemRedo.Name = "MenuItemRedo";
            this.MenuItemRedo.Size = new System.Drawing.Size(148, 22);
            this.MenuItemRedo.Text = "В&ернуть";
            this.MenuItemRedo.Click += new System.EventHandler(this.MenuItemRedo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(145, 6);
            // 
            // MenuItemCut
            // 
            this.MenuItemCut.Name = "MenuItemCut";
            this.MenuItemCut.Size = new System.Drawing.Size(148, 22);
            this.MenuItemCut.Text = "&Вырезать...";
            // 
            // MenuItemCopy
            // 
            this.MenuItemCopy.Name = "MenuItemCopy";
            this.MenuItemCopy.Size = new System.Drawing.Size(148, 22);
            this.MenuItemCopy.Text = "&Копировать";
            // 
            // MenuItemPaste
            // 
            this.MenuItemPaste.Name = "MenuItemPaste";
            this.MenuItemPaste.Size = new System.Drawing.Size(148, 22);
            this.MenuItemPaste.Text = "В&ставить";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(145, 6);
            // 
            // MenuItemSelectAll
            // 
            this.MenuItemSelectAll.Name = "MenuItemSelectAll";
            this.MenuItemSelectAll.Size = new System.Drawing.Size(148, 22);
            this.MenuItemSelectAll.Text = "В&ыделить все";
            // 
            // форматToolStripMenuItem
            // 
            this.форматToolStripMenuItem.Name = "форматToolStripMenuItem";
            this.форматToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.форматToolStripMenuItem.Text = "&Формат";
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.видToolStripMenuItem.Text = "&Вид";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.справкаToolStripMenuItem.Text = "&Опции";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.настройкиToolStripMenuItem.Text = "&Настройки";
            // 
            // MenuWindows
            // 
            this.MenuWindows.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemCascade,
            this.MenuItemLeftToRight,
            this.MenuItemTopToBottom,
            this.MenuItemArrange});
            this.MenuWindows.Name = "MenuWindows";
            this.MenuWindows.Size = new System.Drawing.Size(48, 20);
            this.MenuWindows.Text = "О&кно";
            // 
            // MenuItemCascade
            // 
            this.MenuItemCascade.Name = "MenuItemCascade";
            this.MenuItemCascade.Size = new System.Drawing.Size(187, 22);
            this.MenuItemCascade.Text = "&Каскадом";
            // 
            // MenuItemLeftToRight
            // 
            this.MenuItemLeftToRight.Name = "MenuItemLeftToRight";
            this.MenuItemLeftToRight.Size = new System.Drawing.Size(187, 22);
            this.MenuItemLeftToRight.Text = "&Слева направо";
            // 
            // MenuItemTopToBottom
            // 
            this.MenuItemTopToBottom.Name = "MenuItemTopToBottom";
            this.MenuItemTopToBottom.Size = new System.Drawing.Size(187, 22);
            this.MenuItemTopToBottom.Text = "С&верху вниз";
            // 
            // MenuItemArrange
            // 
            this.MenuItemArrange.Name = "MenuItemArrange";
            this.MenuItemArrange.Size = new System.Drawing.Size(187, 22);
            this.MenuItemArrange.Text = "&Упорядочить значки";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(24, 20);
            this.помощьToolStripMenuItem.Text = "&?";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(panel1);
            this.Controls.Add(this.MainFormMenuStrip);
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "MainForm";
            this.Text = "Рисовалка";
            this.Load += new System.EventHandler(this.MainForm_Load);
            panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            this.MainFormMenuStrip.ResumeLayout(false);
            this.MainFormMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuFile;
        private System.Windows.Forms.ToolStripMenuItem MenuEdit;
        private System.Windows.Forms.ToolStripMenuItem форматToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuNew;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSave;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSaveAs;
        private System.Windows.Forms.ToolStripSeparator раздToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem параметрыСтраницыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem MenuItemUndo;
        private System.Windows.Forms.ToolStripMenuItem MenuItemRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCut;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCopy;
        private System.Windows.Forms.ToolStripMenuItem MenuItemPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSelectAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem MenuItemClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem MenuWindows;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCloseAll;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCascade;
        private System.Windows.Forms.ToolStripMenuItem MenuItemLeftToRight;
        private System.Windows.Forms.ToolStripMenuItem MenuItemTopToBottom;
        private System.Windows.Forms.ToolStripMenuItem MenuItemArrange;
        private System.Windows.Forms.RadioButton PencilRadio;
        private System.Windows.Forms.RadioButton BrushRadio;
        private System.Windows.Forms.RadioButton LineRadio;
        private System.Windows.Forms.RadioButton StarRadio;
        private System.Windows.Forms.RadioButton EllipseRadio;
        private System.Windows.Forms.RadioButton EraserRadio;
        private System.Windows.Forms.RadioButton ScaleInRadio;
        private System.Windows.Forms.RadioButton ScaleOutRadio;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox ThicknessText;
        private System.Windows.Forms.CheckBox FillCheck;
    }
}

