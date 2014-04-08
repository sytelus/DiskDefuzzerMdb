namespace Astrila.DiskDefuzzer
{
    partial class QueryResultViewer
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryResultViewer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSwitchView = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonCompareFiles = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSelectAllFiles = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonResync = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButtonCopyOrMove = new System.Windows.Forms.ToolStripDropDownButton();
            this.copyToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxCopyTarget = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonViewQuery = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAddNewQuery = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOpenMdb = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonHelp = new System.Windows.Forms.ToolStripButton();
            this.toolStripProgressBarFillProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.comboBoxQuerySelector = new System.Windows.Forms.ComboBox();
            this.labelCriteria = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.folderDataGridViewer1 = new Astrila.DiskDefuzzer.FolderDataGridViewer();
            this.contextMenuStripForGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemOpenFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllRowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copySelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.compareFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.viewQueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewQueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.helpAndAboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderDataExplorerViewer1 = new Astrila.DiskDefuzzer.FolderDataExplorerViewer();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelRowCount = new System.Windows.Forms.Label();
            this.timerMakeToolbarInvisible = new System.Windows.Forms.Timer(this.components);
            this.toolStripMain.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStripForGrid.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(442, 445);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(27, 33);
            this.panel1.TabIndex = 0;
            this.panel1.MouseEnter += new System.EventHandler(this.QueryResultViewer_MouseEnter);
            // 
            // toolStripMain
            // 
            this.toolStripMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSwitchView,
            this.toolStripSeparator1,
            this.toolStripButtonCompareFiles,
            this.toolStripButtonSelectAllFiles,
            this.toolStripButtonDelete,
            this.toolStripButtonResync,
            this.toolStripSeparator2,
            this.toolStripDropDownButtonCopyOrMove,
            this.toolStripTextBoxCopyTarget,
            this.toolStripSeparator3,
            this.toolStripButtonViewQuery,
            this.toolStripButtonAddNewQuery,
            this.toolStripButtonOpenMdb,
            this.toolStripSeparator4,
            this.toolStripButtonHelp,
            this.toolStripProgressBarFillProgress});
            this.toolStripMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripMain.Size = new System.Drawing.Size(30, 436);
            this.toolStripMain.TabIndex = 0;
            this.toolStripMain.Text = "toolStrip1";
            this.toolStripMain.MouseEnter += new System.EventHandler(this.QueryResultViewer_MouseEnter);
            this.toolStripMain.MouseLeave += new System.EventHandler(this.QueryResultViewer_MouseLeave);
            // 
            // toolStripButtonSwitchView
            // 
            this.toolStripButtonSwitchView.CheckOnClick = true;
            this.toolStripButtonSwitchView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSwitchView.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSwitchView.Image")));
            this.toolStripButtonSwitchView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSwitchView.Name = "toolStripButtonSwitchView";
            this.toolStripButtonSwitchView.Size = new System.Drawing.Size(28, 20);
            this.toolStripButtonSwitchView.Text = "toolStripButton1";
            this.toolStripButtonSwitchView.ToolTipText = "Switch to Grid View/Explorer view";
            this.toolStripButtonSwitchView.Click += new System.EventHandler(this.toolStripButtonSwitchView_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(28, 6);
            this.toolStripSeparator1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // toolStripButtonCompareFiles
            // 
            this.toolStripButtonCompareFiles.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCompareFiles.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCompareFiles.Image")));
            this.toolStripButtonCompareFiles.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCompareFiles.Name = "toolStripButtonCompareFiles";
            this.toolStripButtonCompareFiles.Size = new System.Drawing.Size(28, 20);
            this.toolStripButtonCompareFiles.Text = "Compare files";
            this.toolStripButtonCompareFiles.Click += new System.EventHandler(this.toolStripButtonCompareFiles_Click);
            // 
            // toolStripButtonSelectAllFiles
            // 
            this.toolStripButtonSelectAllFiles.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSelectAllFiles.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSelectAllFiles.Image")));
            this.toolStripButtonSelectAllFiles.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSelectAllFiles.Name = "toolStripButtonSelectAllFiles";
            this.toolStripButtonSelectAllFiles.Size = new System.Drawing.Size(28, 20);
            this.toolStripButtonSelectAllFiles.Text = "Select all rows";
            this.toolStripButtonSelectAllFiles.Click += new System.EventHandler(this.toolStripButtonSelectAllFiles_Click);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelete.Image")));
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(28, 20);
            this.toolStripButtonDelete.Text = "toolStripButtonDeleteFiles";
            this.toolStripButtonDelete.ToolTipText = "Delete selected files";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // toolStripButtonResync
            // 
            this.toolStripButtonResync.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonResync.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonResync.Image")));
            this.toolStripButtonResync.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonResync.Name = "toolStripButtonResync";
            this.toolStripButtonResync.Size = new System.Drawing.Size(28, 20);
            this.toolStripButtonResync.Text = "Resync data for selected folder";
            this.toolStripButtonResync.Visible = false;
            this.toolStripButtonResync.Click += new System.EventHandler(this.toolStripButtonResync_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(28, 6);
            this.toolStripSeparator2.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // toolStripDropDownButtonCopyOrMove
            // 
            this.toolStripDropDownButtonCopyOrMove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButtonCopyOrMove.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToToolStripMenuItem,
            this.moveToToolStripMenuItem});
            this.toolStripDropDownButtonCopyOrMove.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonCopyOrMove.Image")));
            this.toolStripDropDownButtonCopyOrMove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonCopyOrMove.Name = "toolStripDropDownButtonCopyOrMove";
            this.toolStripDropDownButtonCopyOrMove.Size = new System.Drawing.Size(28, 20);
            this.toolStripDropDownButtonCopyOrMove.Text = "Copy / Move to";
            // 
            // copyToToolStripMenuItem
            // 
            this.copyToToolStripMenuItem.Name = "copyToToolStripMenuItem";
            this.copyToToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.copyToToolStripMenuItem.Text = "Copy selected files to";
            this.copyToToolStripMenuItem.Click += new System.EventHandler(this.copyToToolStripMenuItem_Click);
            // 
            // moveToToolStripMenuItem
            // 
            this.moveToToolStripMenuItem.Name = "moveToToolStripMenuItem";
            this.moveToToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.moveToToolStripMenuItem.Text = "Move selected files to";
            this.moveToToolStripMenuItem.Click += new System.EventHandler(this.moveToToolStripMenuItem_Click);
            // 
            // toolStripTextBoxCopyTarget
            // 
            this.toolStripTextBoxCopyTarget.Name = "toolStripTextBoxCopyTarget";
            this.toolStripTextBoxCopyTarget.Size = new System.Drawing.Size(26, 21);
            this.toolStripTextBoxCopyTarget.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(28, 6);
            this.toolStripSeparator3.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // toolStripButtonViewQuery
            // 
            this.toolStripButtonViewQuery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonViewQuery.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonViewQuery.Image")));
            this.toolStripButtonViewQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonViewQuery.Name = "toolStripButtonViewQuery";
            this.toolStripButtonViewQuery.Size = new System.Drawing.Size(28, 20);
            this.toolStripButtonViewQuery.Text = "View current Query";
            this.toolStripButtonViewQuery.Click += new System.EventHandler(this.toolStripButtonViewQuery_Click);
            // 
            // toolStripButtonAddNewQuery
            // 
            this.toolStripButtonAddNewQuery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddNewQuery.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddNewQuery.Image")));
            this.toolStripButtonAddNewQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddNewQuery.Name = "toolStripButtonAddNewQuery";
            this.toolStripButtonAddNewQuery.Size = new System.Drawing.Size(28, 20);
            this.toolStripButtonAddNewQuery.Text = "Add new query";
            this.toolStripButtonAddNewQuery.Visible = false;
            this.toolStripButtonAddNewQuery.Click += new System.EventHandler(this.toolStripButtonAddNewQuery_Click);
            // 
            // toolStripButtonOpenMdb
            // 
            this.toolStripButtonOpenMdb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpenMdb.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpenMdb.Image")));
            this.toolStripButtonOpenMdb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpenMdb.Name = "toolStripButtonOpenMdb";
            this.toolStripButtonOpenMdb.Size = new System.Drawing.Size(28, 20);
            this.toolStripButtonOpenMdb.Text = "toolStripButton1";
            this.toolStripButtonOpenMdb.ToolTipText = "Open the database file in MS Access";
            this.toolStripButtonOpenMdb.Click += new System.EventHandler(this.toolStripButtonOpenMdb_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(28, 6);
            this.toolStripSeparator4.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // toolStripButtonHelp
            // 
            this.toolStripButtonHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonHelp.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonHelp.Image")));
            this.toolStripButtonHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonHelp.Name = "toolStripButtonHelp";
            this.toolStripButtonHelp.Size = new System.Drawing.Size(28, 20);
            this.toolStripButtonHelp.Text = "Help and about";
            this.toolStripButtonHelp.Click += new System.EventHandler(this.toolStripButtonHelp_Click);
            // 
            // toolStripProgressBarFillProgress
            // 
            this.toolStripProgressBarFillProgress.Name = "toolStripProgressBarFillProgress";
            this.toolStripProgressBarFillProgress.Size = new System.Drawing.Size(26, 22);
            this.toolStripProgressBarFillProgress.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            this.toolStripProgressBarFillProgress.Visible = false;
            // 
            // comboBoxQuerySelector
            // 
            this.comboBoxQuerySelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxQuerySelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQuerySelector.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxQuerySelector.FormattingEnabled = true;
            this.comboBoxQuerySelector.Location = new System.Drawing.Point(156, 0);
            this.comboBoxQuerySelector.Name = "comboBoxQuerySelector";
            this.comboBoxQuerySelector.Size = new System.Drawing.Size(319, 21);
            this.comboBoxQuerySelector.TabIndex = 1;
            this.comboBoxQuerySelector.SelectedIndexChanged += new System.EventHandler(this.comboBoxQuerySelector_SelectedIndexChanged);
            this.comboBoxQuerySelector.MouseEnter += new System.EventHandler(this.QueryResultViewer_MouseEnter);
            this.comboBoxQuerySelector.MouseLeave += new System.EventHandler(this.QueryResultViewer_MouseLeave);
            // 
            // labelCriteria
            // 
            this.labelCriteria.AutoSize = true;
            this.labelCriteria.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelCriteria.Location = new System.Drawing.Point(0, 0);
            this.labelCriteria.Name = "labelCriteria";
            this.labelCriteria.Size = new System.Drawing.Size(156, 13);
            this.labelCriteria.TabIndex = 0;
            this.labelCriteria.Text = "Criteria to filter files in this folder:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.folderDataGridViewer1);
            this.panel2.Controls.Add(this.folderDataExplorerViewer1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(475, 478);
            this.panel2.TabIndex = 1;
            // 
            // folderDataGridViewer1
            // 
            this.folderDataGridViewer1.ContextMenuStrip = this.contextMenuStripForGrid;
            this.folderDataGridViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.folderDataGridViewer1.Location = new System.Drawing.Point(0, 42);
            this.folderDataGridViewer1.Name = "folderDataGridViewer1";
            this.folderDataGridViewer1.Size = new System.Drawing.Size(445, 436);
            this.folderDataGridViewer1.TabIndex = 2;
            this.folderDataGridViewer1.Visible = false;
            // 
            // contextMenuStripForGrid
            // 
            this.contextMenuStripForGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemOpenFolder,
            this.toolStripSeparator5,
            this.openToolStripMenuItem,
            this.selectAllRowsToolStripMenuItem,
            this.copySelectionToolStripMenuItem,
            this.toolStripMenuItem1,
            this.compareFilesToolStripMenuItem,
            this.deleteFilesToolStripMenuItem,
            this.toolStripMenuItem2,
            this.viewQueryToolStripMenuItem,
            this.addNewQueryToolStripMenuItem,
            this.toolStripMenuItem3,
            this.helpAndAboutToolStripMenuItem});
            this.contextMenuStripForGrid.Name = "contextMenuStripForGrid";
            this.contextMenuStripForGrid.Size = new System.Drawing.Size(231, 226);
            // 
            // toolStripMenuItemOpenFolder
            // 
            this.toolStripMenuItemOpenFolder.Name = "toolStripMenuItemOpenFolder";
            this.toolStripMenuItemOpenFolder.Size = new System.Drawing.Size(230, 22);
            this.toolStripMenuItemOpenFolder.Text = "Open &Folder";
            this.toolStripMenuItemOpenFolder.Click += new System.EventHandler(this.toolStripMenuItemOpenFolder_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(227, 6);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.openToolStripMenuItem.Text = "&Open selected file";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // selectAllRowsToolStripMenuItem
            // 
            this.selectAllRowsToolStripMenuItem.Name = "selectAllRowsToolStripMenuItem";
            this.selectAllRowsToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.selectAllRowsToolStripMenuItem.Text = "Select &all rows";
            this.selectAllRowsToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonSelectAllFiles_Click);
            // 
            // copySelectionToolStripMenuItem
            // 
            this.copySelectionToolStripMenuItem.Name = "copySelectionToolStripMenuItem";
            this.copySelectionToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.copySelectionToolStripMenuItem.Text = "&Copy selection";
            this.copySelectionToolStripMenuItem.Click += new System.EventHandler(this.copySelectionToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(227, 6);
            // 
            // compareFilesToolStripMenuItem
            // 
            this.compareFilesToolStripMenuItem.Name = "compareFilesToolStripMenuItem";
            this.compareFilesToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.compareFilesToolStripMenuItem.Text = "Compare files in two folders...";
            this.compareFilesToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonCompareFiles_Click);
            // 
            // deleteFilesToolStripMenuItem
            // 
            this.deleteFilesToolStripMenuItem.Name = "deleteFilesToolStripMenuItem";
            this.deleteFilesToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.deleteFilesToolStripMenuItem.Text = "Delete selected files...";
            this.deleteFilesToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(227, 6);
            // 
            // viewQueryToolStripMenuItem
            // 
            this.viewQueryToolStripMenuItem.Name = "viewQueryToolStripMenuItem";
            this.viewQueryToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.viewQueryToolStripMenuItem.Text = "View query...";
            this.viewQueryToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonViewQuery_Click);
            // 
            // addNewQueryToolStripMenuItem
            // 
            this.addNewQueryToolStripMenuItem.Name = "addNewQueryToolStripMenuItem";
            this.addNewQueryToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.addNewQueryToolStripMenuItem.Text = "Add new query...";
            this.addNewQueryToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonAddNewQuery_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(227, 6);
            // 
            // helpAndAboutToolStripMenuItem
            // 
            this.helpAndAboutToolStripMenuItem.Name = "helpAndAboutToolStripMenuItem";
            this.helpAndAboutToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.helpAndAboutToolStripMenuItem.Text = "Help and About...";
            this.helpAndAboutToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonHelp_Click);
            // 
            // folderDataExplorerViewer1
            // 
            this.folderDataExplorerViewer1.ContextMenuStrip = this.contextMenuStripForGrid;
            this.folderDataExplorerViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.folderDataExplorerViewer1.Location = new System.Drawing.Point(0, 42);
            this.folderDataExplorerViewer1.Name = "folderDataExplorerViewer1";
            this.folderDataExplorerViewer1.Size = new System.Drawing.Size(445, 436);
            this.folderDataExplorerViewer1.TabIndex = 4;
            this.folderDataExplorerViewer1.Visible = false;
            this.folderDataExplorerViewer1.Load += new System.EventHandler(this.folderDataExplorerViewer1_Load);
            this.folderDataExplorerViewer1.MouseEnter += new System.EventHandler(this.QueryResultViewer_MouseEnter);
            this.folderDataExplorerViewer1.MouseLeave += new System.EventHandler(this.QueryResultViewer_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Controls.Add(this.toolStripMain);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(445, 42);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(30, 436);
            this.panel4.TabIndex = 5;
            this.panel4.MouseLeave += new System.EventHandler(this.QueryResultViewer_MouseLeave);
            this.panel4.MouseEnter += new System.EventHandler(this.QueryResultViewer_MouseEnter);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelRowCount);
            this.panel3.Controls.Add(this.comboBoxQuerySelector);
            this.panel3.Controls.Add(this.labelCriteria);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(475, 42);
            this.panel3.TabIndex = 1;
            this.panel3.MouseLeave += new System.EventHandler(this.QueryResultViewer_MouseLeave);
            this.panel3.MouseEnter += new System.EventHandler(this.QueryResultViewer_MouseEnter);
            // 
            // labelRowCount
            // 
            this.labelRowCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelRowCount.Location = new System.Drawing.Point(156, 22);
            this.labelRowCount.Name = "labelRowCount";
            this.labelRowCount.Size = new System.Drawing.Size(319, 20);
            this.labelRowCount.TabIndex = 2;
            this.labelRowCount.Text = "0 files";
            // 
            // timerMakeToolbarInvisible
            // 
            this.timerMakeToolbarInvisible.Interval = 400;
            this.timerMakeToolbarInvisible.Tick += new System.EventHandler(this.timerMakeToolbarInvisible_Tick);
            // 
            // QueryResultViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "QueryResultViewer";
            this.Size = new System.Drawing.Size(475, 478);
            this.MouseEnter += new System.EventHandler(this.QueryResultViewer_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.QueryResultViewer_MouseLeave);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.contextMenuStripForGrid.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxQuerySelector;
        private System.Windows.Forms.Label labelCriteria;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxCopyTarget;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddNewQuery;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBarFillProgress;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonViewQuery;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButtonHelp;
        private System.Windows.Forms.ToolStripButton toolStripButtonSelectAllFiles;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonCopyOrMove;
        private System.Windows.Forms.ToolStripMenuItem copyToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveToToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonCompareFiles;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripForGrid;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllRowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem compareFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem helpAndAboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewQueryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewQueryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem copySelectionToolStripMenuItem;
        private FolderDataGridViewer folderDataGridViewer1;
        private FolderDataExplorerViewer folderDataExplorerViewer1;
        private System.Windows.Forms.Timer timerMakeToolbarInvisible;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolStripButton toolStripButtonSwitchView;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpenMdb;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpenFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButtonResync;
        private System.Windows.Forms.Label labelRowCount;
    }
}
