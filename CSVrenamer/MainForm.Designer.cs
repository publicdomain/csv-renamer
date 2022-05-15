
namespace CSVrenamer
{
    partial class MainForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
        	this.components = new System.ComponentModel.Container();
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        	this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
        	this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        	this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
        	this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
        	this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        	this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.rememberEditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.freeReleasesPublicDomainisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.originalThreadDonationCodercomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.sourceCodeGithubcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
        	this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
        	this.itemsToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        	this.itemsCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        	this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
        	this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
        	this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
        	this.itemsListView = new System.Windows.Forms.ListView();
        	this.itemsColumnHeader = new System.Windows.Forms.ColumnHeader();
        	this.constantLabel = new System.Windows.Forms.Label();
        	this.separatorLabel = new System.Windows.Forms.Label();
        	this.vairableLabel = new System.Windows.Forms.Label();
        	this.droppedItemsLabel = new System.Windows.Forms.Label();
        	this.renameButton = new System.Windows.Forms.Button();
        	this.constantComboBox = new System.Windows.Forms.ComboBox();
        	this.spacedCheckBox = new System.Windows.Forms.CheckBox();
        	this.subtractCheckBox = new System.Windows.Forms.CheckBox();
        	this.variableNumericUpDown = new System.Windows.Forms.NumericUpDown();
        	this.separatorTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
        	this.hyphenButton = new System.Windows.Forms.Button();
        	this.underscoreButton = new System.Windows.Forms.Button();
        	this.separatorComboBox = new System.Windows.Forms.ComboBox();
        	this.itemsListViewContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
        	this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.mainMenuStrip.SuspendLayout();
        	this.mainStatusStrip.SuspendLayout();
        	this.mainTableLayoutPanel.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.variableNumericUpDown)).BeginInit();
        	this.separatorTableLayoutPanel.SuspendLayout();
        	this.itemsListViewContextMenuStrip.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// mainMenuStrip
        	// 
        	this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.fileToolStripMenuItem1,
        	        	        	this.optionsToolStripMenuItem,
        	        	        	this.helpToolStripMenuItem});
        	this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
        	this.mainMenuStrip.Name = "mainMenuStrip";
        	this.mainMenuStrip.Size = new System.Drawing.Size(284, 24);
        	this.mainMenuStrip.TabIndex = 51;
        	// 
        	// fileToolStripMenuItem1
        	// 
        	this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.newToolStripMenuItem1,
        	        	        	this.toolStripSeparator3,
        	        	        	this.resetToolStripMenuItem,
        	        	        	this.toolStripSeparator1,
        	        	        	this.exitToolStripMenuItem1});
        	this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
        	this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
        	this.fileToolStripMenuItem1.Text = "&File";
        	// 
        	// newToolStripMenuItem1
        	// 
        	this.newToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem1.Image")));
        	this.newToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
        	this.newToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
        	this.newToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
        	this.newToolStripMenuItem1.Text = "&New";
        	this.newToolStripMenuItem1.Click += new System.EventHandler(this.OnNewToolStripMenuItem1Click);
        	// 
        	// toolStripSeparator3
        	// 
        	this.toolStripSeparator3.Name = "toolStripSeparator3";
        	this.toolStripSeparator3.Size = new System.Drawing.Size(138, 6);
        	// 
        	// resetToolStripMenuItem
        	// 
        	this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
        	this.resetToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
        	this.resetToolStripMenuItem.Text = "&Reset";
        	this.resetToolStripMenuItem.Click += new System.EventHandler(this.OnResetToolStripMenuItemClick);
        	// 
        	// toolStripSeparator1
        	// 
        	this.toolStripSeparator1.Name = "toolStripSeparator1";
        	this.toolStripSeparator1.Size = new System.Drawing.Size(138, 6);
        	// 
        	// exitToolStripMenuItem1
        	// 
        	this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
        	this.exitToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
        	this.exitToolStripMenuItem1.Text = "E&xit";
        	this.exitToolStripMenuItem1.Click += new System.EventHandler(this.OnExitToolStripMenuItemClick);
        	// 
        	// optionsToolStripMenuItem
        	// 
        	this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.alwaysOnTopToolStripMenuItem,
        	        	        	this.rememberEditsToolStripMenuItem});
        	this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
        	this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
        	this.optionsToolStripMenuItem.Text = "&Options";
        	this.optionsToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.OnOptionsToolStripMenuItemDropDownItemClicked);
        	// 
        	// alwaysOnTopToolStripMenuItem
        	// 
        	this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
        	this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
        	this.alwaysOnTopToolStripMenuItem.Text = "&Always on top";
        	// 
        	// rememberEditsToolStripMenuItem
        	// 
        	this.rememberEditsToolStripMenuItem.Name = "rememberEditsToolStripMenuItem";
        	this.rememberEditsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
        	this.rememberEditsToolStripMenuItem.Text = "&Remember edits";
        	// 
        	// helpToolStripMenuItem
        	// 
        	this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.freeReleasesPublicDomainisToolStripMenuItem,
        	        	        	this.originalThreadDonationCodercomToolStripMenuItem,
        	        	        	this.sourceCodeGithubcomToolStripMenuItem,
        	        	        	this.toolStripSeparator2,
        	        	        	this.aboutToolStripMenuItem});
        	this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
        	this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
        	this.helpToolStripMenuItem.Text = "&Help";
        	// 
        	// freeReleasesPublicDomainisToolStripMenuItem
        	// 
        	this.freeReleasesPublicDomainisToolStripMenuItem.Name = "freeReleasesPublicDomainisToolStripMenuItem";
        	this.freeReleasesPublicDomainisToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
        	this.freeReleasesPublicDomainisToolStripMenuItem.Text = "&Free Releases @ PublicDomain.is";
        	this.freeReleasesPublicDomainisToolStripMenuItem.Click += new System.EventHandler(this.OnFreeReleasesPublicDomainisToolStripMenuItemClick);
        	// 
        	// originalThreadDonationCodercomToolStripMenuItem
        	// 
        	this.originalThreadDonationCodercomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("originalThreadDonationCodercomToolStripMenuItem.Image")));
        	this.originalThreadDonationCodercomToolStripMenuItem.Name = "originalThreadDonationCodercomToolStripMenuItem";
        	this.originalThreadDonationCodercomToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
        	this.originalThreadDonationCodercomToolStripMenuItem.Text = "&Original thread @ DonationCoder.com";
        	this.originalThreadDonationCodercomToolStripMenuItem.Click += new System.EventHandler(this.OnOriginalThreadDonationCodercomToolStripMenuItemClick);
        	// 
        	// sourceCodeGithubcomToolStripMenuItem
        	// 
        	this.sourceCodeGithubcomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sourceCodeGithubcomToolStripMenuItem.Image")));
        	this.sourceCodeGithubcomToolStripMenuItem.Name = "sourceCodeGithubcomToolStripMenuItem";
        	this.sourceCodeGithubcomToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
        	this.sourceCodeGithubcomToolStripMenuItem.Text = "&Source code @ Github.com";
        	this.sourceCodeGithubcomToolStripMenuItem.Click += new System.EventHandler(this.OnSourceCodeGithubcomToolStripMenuItemClick);
        	// 
        	// toolStripSeparator2
        	// 
        	this.toolStripSeparator2.Name = "toolStripSeparator2";
        	this.toolStripSeparator2.Size = new System.Drawing.Size(275, 6);
        	// 
        	// aboutToolStripMenuItem
        	// 
        	this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
        	this.aboutToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
        	this.aboutToolStripMenuItem.Text = "&About...";
        	this.aboutToolStripMenuItem.Click += new System.EventHandler(this.OnAboutToolStripMenuItemClick);
        	// 
        	// mainStatusStrip
        	// 
        	this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.itemsToolStripStatusLabel,
        	        	        	this.itemsCountToolStripStatusLabel,
        	        	        	this.toolStripStatusLabel1,
        	        	        	this.toolStripStatusLabel2});
        	this.mainStatusStrip.Location = new System.Drawing.Point(0, 421);
        	this.mainStatusStrip.Name = "mainStatusStrip";
        	this.mainStatusStrip.Size = new System.Drawing.Size(284, 22);
        	this.mainStatusStrip.SizingGrip = false;
        	this.mainStatusStrip.TabIndex = 50;
        	// 
        	// itemsToolStripStatusLabel
        	// 
        	this.itemsToolStripStatusLabel.Name = "itemsToolStripStatusLabel";
        	this.itemsToolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
        	this.itemsToolStripStatusLabel.Text = "Items:";
        	// 
        	// itemsCountToolStripStatusLabel
        	// 
        	this.itemsCountToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        	this.itemsCountToolStripStatusLabel.Name = "itemsCountToolStripStatusLabel";
        	this.itemsCountToolStripStatusLabel.Size = new System.Drawing.Size(14, 17);
        	this.itemsCountToolStripStatusLabel.Text = "0";
        	// 
        	// toolStripStatusLabel1
        	// 
        	this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
        	this.toolStripStatusLabel1.Size = new System.Drawing.Size(60, 17);
        	this.toolStripStatusLabel1.Text = "Separator:";
        	// 
        	// toolStripStatusLabel2
        	// 
        	this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        	this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
        	this.toolStripStatusLabel2.Size = new System.Drawing.Size(12, 17);
        	this.toolStripStatusLabel2.Text = "-";
        	// 
        	// mainTableLayoutPanel
        	// 
        	this.mainTableLayoutPanel.ColumnCount = 2;
        	this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
        	this.mainTableLayoutPanel.Controls.Add(this.itemsListView, 0, 7);
        	this.mainTableLayoutPanel.Controls.Add(this.constantLabel, 0, 0);
        	this.mainTableLayoutPanel.Controls.Add(this.separatorLabel, 0, 2);
        	this.mainTableLayoutPanel.Controls.Add(this.vairableLabel, 0, 4);
        	this.mainTableLayoutPanel.Controls.Add(this.droppedItemsLabel, 0, 6);
        	this.mainTableLayoutPanel.Controls.Add(this.renameButton, 0, 8);
        	this.mainTableLayoutPanel.Controls.Add(this.constantComboBox, 0, 1);
        	this.mainTableLayoutPanel.Controls.Add(this.spacedCheckBox, 1, 3);
        	this.mainTableLayoutPanel.Controls.Add(this.subtractCheckBox, 1, 5);
        	this.mainTableLayoutPanel.Controls.Add(this.variableNumericUpDown, 0, 5);
        	this.mainTableLayoutPanel.Controls.Add(this.separatorTableLayoutPanel, 0, 3);
        	this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 24);
        	this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
        	this.mainTableLayoutPanel.RowCount = 9;
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
        	this.mainTableLayoutPanel.Size = new System.Drawing.Size(284, 397);
        	this.mainTableLayoutPanel.TabIndex = 52;
        	// 
        	// itemsListView
        	// 
        	this.itemsListView.AllowDrop = true;
        	this.itemsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
        	        	        	this.itemsColumnHeader});
        	this.mainTableLayoutPanel.SetColumnSpan(this.itemsListView, 2);
        	this.itemsListView.ContextMenuStrip = this.itemsListViewContextMenuStrip;
        	this.itemsListView.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.itemsListView.Location = new System.Drawing.Point(3, 193);
        	this.itemsListView.Name = "itemsListView";
        	this.itemsListView.Size = new System.Drawing.Size(278, 166);
        	this.itemsListView.TabIndex = 13;
        	this.itemsListView.UseCompatibleStateImageBehavior = false;
        	this.itemsListView.View = System.Windows.Forms.View.Details;
        	this.itemsListView.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnItemsListViewDragDrop);
        	this.itemsListView.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnItemsListViewDragEnter);
        	this.itemsListView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnItemsListViewMouseDown);
        	this.itemsListView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnItemsListViewMouseMove);
        	this.itemsListView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnItemsListViewMouseUp);
        	// 
        	// itemsColumnHeader
        	// 
        	this.itemsColumnHeader.Text = "Items";
        	this.itemsColumnHeader.Width = 250;
        	// 
        	// constantLabel
        	// 
        	this.mainTableLayoutPanel.SetColumnSpan(this.constantLabel, 2);
        	this.constantLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.constantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.constantLabel.Location = new System.Drawing.Point(3, 0);
        	this.constantLabel.Name = "constantLabel";
        	this.constantLabel.Size = new System.Drawing.Size(278, 25);
        	this.constantLabel.TabIndex = 0;
        	this.constantLabel.Text = "&Constant:";
        	this.constantLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// separatorLabel
        	// 
        	this.mainTableLayoutPanel.SetColumnSpan(this.separatorLabel, 2);
        	this.separatorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.separatorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.separatorLabel.Location = new System.Drawing.Point(3, 55);
        	this.separatorLabel.Name = "separatorLabel";
        	this.separatorLabel.Size = new System.Drawing.Size(278, 25);
        	this.separatorLabel.TabIndex = 2;
        	this.separatorLabel.Text = "&Separator:";
        	this.separatorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// vairableLabel
        	// 
        	this.mainTableLayoutPanel.SetColumnSpan(this.vairableLabel, 2);
        	this.vairableLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.vairableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.vairableLabel.Location = new System.Drawing.Point(3, 110);
        	this.vairableLabel.Name = "vairableLabel";
        	this.vairableLabel.Size = new System.Drawing.Size(278, 25);
        	this.vairableLabel.TabIndex = 7;
        	this.vairableLabel.Text = "&Variable:";
        	this.vairableLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// droppedItemsLabel
        	// 
        	this.mainTableLayoutPanel.SetColumnSpan(this.droppedItemsLabel, 2);
        	this.droppedItemsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.droppedItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.droppedItemsLabel.Location = new System.Drawing.Point(3, 165);
        	this.droppedItemsLabel.Name = "droppedItemsLabel";
        	this.droppedItemsLabel.Size = new System.Drawing.Size(278, 25);
        	this.droppedItemsLabel.TabIndex = 10;
        	this.droppedItemsLabel.Text = "&Dropped items:";
        	this.droppedItemsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// renameButton
        	// 
        	this.mainTableLayoutPanel.SetColumnSpan(this.renameButton, 2);
        	this.renameButton.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.renameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.renameButton.ForeColor = System.Drawing.Color.DarkGreen;
        	this.renameButton.Location = new System.Drawing.Point(3, 365);
        	this.renameButton.Name = "renameButton";
        	this.renameButton.Size = new System.Drawing.Size(278, 29);
        	this.renameButton.TabIndex = 12;
        	this.renameButton.TabStop = false;
        	this.renameButton.Text = "&Rename";
        	this.renameButton.UseVisualStyleBackColor = true;
        	this.renameButton.Click += new System.EventHandler(this.OnRenameButtonClick);
        	// 
        	// constantComboBox
        	// 
        	this.mainTableLayoutPanel.SetColumnSpan(this.constantComboBox, 2);
        	this.constantComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.constantComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.constantComboBox.FormattingEnabled = true;
        	this.constantComboBox.Location = new System.Drawing.Point(3, 28);
        	this.constantComboBox.Name = "constantComboBox";
        	this.constantComboBox.Size = new System.Drawing.Size(278, 24);
        	this.constantComboBox.TabIndex = 1;
        	// 
        	// spacedCheckBox
        	// 
        	this.spacedCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.spacedCheckBox.Location = new System.Drawing.Point(207, 83);
        	this.spacedCheckBox.Name = "spacedCheckBox";
        	this.spacedCheckBox.Size = new System.Drawing.Size(74, 24);
        	this.spacedCheckBox.TabIndex = 6;
        	this.spacedCheckBox.Text = "&Spaced";
        	this.spacedCheckBox.UseVisualStyleBackColor = true;
        	this.spacedCheckBox.CheckedChanged += new System.EventHandler(this.OnSpacedCheckBoxCheckedChanged);
        	// 
        	// subtractCheckBox
        	// 
        	this.subtractCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.subtractCheckBox.Location = new System.Drawing.Point(207, 138);
        	this.subtractCheckBox.Name = "subtractCheckBox";
        	this.subtractCheckBox.Size = new System.Drawing.Size(74, 24);
        	this.subtractCheckBox.TabIndex = 9;
        	this.subtractCheckBox.Text = "&Subtract";
        	this.subtractCheckBox.UseVisualStyleBackColor = true;
        	// 
        	// variableNumericUpDown
        	// 
        	this.variableNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.variableNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
        	this.variableNumericUpDown.Location = new System.Drawing.Point(3, 138);
        	this.variableNumericUpDown.Maximum = new decimal(new int[] {
        	        	        	1410065407,
        	        	        	2,
        	        	        	0,
        	        	        	0});
        	this.variableNumericUpDown.Minimum = new decimal(new int[] {
        	        	        	1,
        	        	        	0,
        	        	        	0,
        	        	        	0});
        	this.variableNumericUpDown.Name = "variableNumericUpDown";
        	this.variableNumericUpDown.Size = new System.Drawing.Size(198, 22);
        	this.variableNumericUpDown.TabIndex = 8;
        	this.variableNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        	this.variableNumericUpDown.Value = new decimal(new int[] {
        	        	        	1,
        	        	        	0,
        	        	        	0,
        	        	        	0});
        	// 
        	// separatorTableLayoutPanel
        	// 
        	this.separatorTableLayoutPanel.ColumnCount = 3;
        	this.separatorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        	this.separatorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        	this.separatorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        	this.separatorTableLayoutPanel.Controls.Add(this.hyphenButton, 0, 0);
        	this.separatorTableLayoutPanel.Controls.Add(this.underscoreButton, 1, 0);
        	this.separatorTableLayoutPanel.Controls.Add(this.separatorComboBox, 2, 0);
        	this.separatorTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.separatorTableLayoutPanel.Location = new System.Drawing.Point(0, 80);
        	this.separatorTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
        	this.separatorTableLayoutPanel.Name = "separatorTableLayoutPanel";
        	this.separatorTableLayoutPanel.RowCount = 1;
        	this.separatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.separatorTableLayoutPanel.Size = new System.Drawing.Size(204, 30);
        	this.separatorTableLayoutPanel.TabIndex = 9;
        	// 
        	// hyphenButton
        	// 
        	this.hyphenButton.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.hyphenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.hyphenButton.Location = new System.Drawing.Point(3, 3);
        	this.hyphenButton.Name = "hyphenButton";
        	this.hyphenButton.Size = new System.Drawing.Size(45, 24);
        	this.hyphenButton.TabIndex = 3;
        	this.hyphenButton.Text = "-";
        	this.hyphenButton.UseVisualStyleBackColor = true;
        	this.hyphenButton.Click += new System.EventHandler(this.OnHyphenButtonClick);
        	// 
        	// underscoreButton
        	// 
        	this.underscoreButton.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.underscoreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.underscoreButton.Location = new System.Drawing.Point(54, 3);
        	this.underscoreButton.Name = "underscoreButton";
        	this.underscoreButton.Size = new System.Drawing.Size(45, 24);
        	this.underscoreButton.TabIndex = 4;
        	this.underscoreButton.Text = "_";
        	this.underscoreButton.UseVisualStyleBackColor = true;
        	this.underscoreButton.Click += new System.EventHandler(this.OnUnderscoreButtonClick);
        	// 
        	// separatorComboBox
        	// 
        	this.separatorComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.separatorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
        	this.separatorComboBox.FormattingEnabled = true;
        	this.separatorComboBox.Location = new System.Drawing.Point(105, 3);
        	this.separatorComboBox.Name = "separatorComboBox";
        	this.separatorComboBox.Size = new System.Drawing.Size(96, 24);
        	this.separatorComboBox.TabIndex = 5;
        	this.separatorComboBox.TextChanged += new System.EventHandler(this.OnSeparatorComboBoxTextChanged);
        	// 
        	// itemsListViewContextMenuStrip
        	// 
        	this.itemsListViewContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.removeToolStripMenuItem});
        	this.itemsListViewContextMenuStrip.Name = "itemsListViewContextMenuStrip";
        	this.itemsListViewContextMenuStrip.Size = new System.Drawing.Size(118, 26);
        	// 
        	// removeToolStripMenuItem
        	// 
        	this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
        	this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
        	this.removeToolStripMenuItem.Text = "&Remove";
        	this.removeToolStripMenuItem.Click += new System.EventHandler(this.OnRemoveToolStripMenuItemClick);
        	// 
        	// MainForm
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(284, 443);
        	this.Controls.Add(this.mainTableLayoutPanel);
        	this.Controls.Add(this.mainMenuStrip);
        	this.Controls.Add(this.mainStatusStrip);
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.Name = "MainForm";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "CSV renamer";
        	this.mainMenuStrip.ResumeLayout(false);
        	this.mainMenuStrip.PerformLayout();
        	this.mainStatusStrip.ResumeLayout(false);
        	this.mainStatusStrip.PerformLayout();
        	this.mainTableLayoutPanel.ResumeLayout(false);
        	((System.ComponentModel.ISupportInitialize)(this.variableNumericUpDown)).EndInit();
        	this.separatorTableLayoutPanel.ResumeLayout(false);
        	this.itemsListViewContextMenuStrip.ResumeLayout(false);
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip itemsListViewContextMenuStrip;
        private System.Windows.Forms.ColumnHeader itemsColumnHeader;
        private System.Windows.Forms.ListView itemsListView;
        private System.Windows.Forms.ComboBox separatorComboBox;
        private System.Windows.Forms.Button underscoreButton;
        private System.Windows.Forms.Button hyphenButton;
        private System.Windows.Forms.TableLayoutPanel separatorTableLayoutPanel;
        private System.Windows.Forms.NumericUpDown variableNumericUpDown;
        private System.Windows.Forms.CheckBox subtractCheckBox;
        private System.Windows.Forms.CheckBox spacedCheckBox;
        private System.Windows.Forms.ComboBox constantComboBox;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rememberEditsToolStripMenuItem;
        private System.Windows.Forms.Button renameButton;
        private System.Windows.Forms.Label droppedItemsLabel;
        private System.Windows.Forms.Label vairableLabel;
        private System.Windows.Forms.Label separatorLabel;
        private System.Windows.Forms.Label constantLabel;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.ToolStripStatusLabel itemsCountToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel itemsToolStripStatusLabel;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem sourceCodeGithubcomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem originalThreadDonationCodercomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem freeReleasesPublicDomainisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
    }
}
