namespace Astrila.DiskDefuzzer
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRightFolder = new System.Windows.Forms.TextBox();
            this.textBoxLeftFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonStartScan = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBrowseLFolder = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonBrowserRFolder = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.queryResultViewerLeftSide = new Astrila.DiskDefuzzer.QueryResultViewer();
            this.queryResultViewerRightSide = new Astrila.DiskDefuzzer.QueryResultViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBoxUnsafeCompare = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Left Folder:";
            // 
            // textBoxRightFolder
            // 
            this.textBoxRightFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxRightFolder.Location = new System.Drawing.Point(0, 13);
            this.textBoxRightFolder.Name = "textBoxRightFolder";
            this.textBoxRightFolder.Size = new System.Drawing.Size(436, 20);
            this.textBoxRightFolder.TabIndex = 1;
            this.textBoxRightFolder.Text = "C:\\shital\\temp\\f1";
            // 
            // textBoxLeftFolder
            // 
            this.textBoxLeftFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLeftFolder.Location = new System.Drawing.Point(0, 13);
            this.textBoxLeftFolder.Name = "textBoxLeftFolder";
            this.textBoxLeftFolder.Size = new System.Drawing.Size(466, 20);
            this.textBoxLeftFolder.TabIndex = 4;
            this.textBoxLeftFolder.Text = "C:\\shital\\temp\\f2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Right Folder:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel4);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(958, 108);
            this.splitContainer1.SplitterDistance = 492;
            this.splitContainer1.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.buttonStartScan);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(492, 72);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(-3, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(449, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Results (First select folders above to compare and click Scan Folders button):";
            // 
            // buttonStartScan
            // 
            this.buttonStartScan.Location = new System.Drawing.Point(-1, 7);
            this.buttonStartScan.Name = "buttonStartScan";
            this.buttonStartScan.Size = new System.Drawing.Size(150, 23);
            this.buttonStartScan.TabIndex = 11;
            this.buttonStartScan.Text = "Scan Folders and Compare";
            this.buttonStartScan.UseVisualStyleBackColor = true;
            this.buttonStartScan.Click += new System.EventHandler(this.buttonStartScan_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxLeftFolder);
            this.panel1.Controls.Add(this.buttonBrowseLFolder);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 33);
            this.panel1.TabIndex = 1;
            // 
            // buttonBrowseLFolder
            // 
            this.buttonBrowseLFolder.AutoSize = true;
            this.buttonBrowseLFolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonBrowseLFolder.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonBrowseLFolder.Location = new System.Drawing.Point(466, 13);
            this.buttonBrowseLFolder.Name = "buttonBrowseLFolder";
            this.buttonBrowseLFolder.Size = new System.Drawing.Size(26, 20);
            this.buttonBrowseLFolder.TabIndex = 5;
            this.buttonBrowseLFolder.Text = "...";
            this.buttonBrowseLFolder.UseVisualStyleBackColor = true;
            this.buttonBrowseLFolder.Click += new System.EventHandler(this.buttonBrowseLFolder_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 33);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(462, 72);
            this.panel4.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxRightFolder);
            this.panel2.Controls.Add(this.buttonBrowserRFolder);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(462, 33);
            this.panel2.TabIndex = 2;
            // 
            // buttonBrowserRFolder
            // 
            this.buttonBrowserRFolder.AutoSize = true;
            this.buttonBrowserRFolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonBrowserRFolder.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonBrowserRFolder.Location = new System.Drawing.Point(436, 13);
            this.buttonBrowserRFolder.Name = "buttonBrowserRFolder";
            this.buttonBrowserRFolder.Size = new System.Drawing.Size(26, 20);
            this.buttonBrowserRFolder.TabIndex = 6;
            this.buttonBrowserRFolder.Text = "...";
            this.buttonBrowserRFolder.UseVisualStyleBackColor = true;
            this.buttonBrowserRFolder.Click += new System.EventHandler(this.buttonBrowserRFolder_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageMain);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(972, 716);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPageMain
            // 
            this.tabPageMain.Controls.Add(this.splitContainer2);
            this.tabPageMain.Controls.Add(this.splitContainer1);
            this.tabPageMain.Location = new System.Drawing.Point(4, 22);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(964, 690);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Main";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 111);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.queryResultViewerLeftSide);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.queryResultViewerRightSide);
            this.splitContainer2.Size = new System.Drawing.Size(958, 576);
            this.splitContainer2.SplitterDistance = 285;
            this.splitContainer2.SplitterWidth = 8;
            this.splitContainer2.TabIndex = 10;
            // 
            // queryResultViewerLeftSide
            // 
            this.queryResultViewerLeftSide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.queryResultViewerLeftSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queryResultViewerLeftSide.Location = new System.Drawing.Point(0, 0);
            this.queryResultViewerLeftSide.Name = "queryResultViewerLeftSide";
            this.queryResultViewerLeftSide.Size = new System.Drawing.Size(958, 285);
            this.queryResultViewerLeftSide.TabIndex = 6;
            // 
            // queryResultViewerRightSide
            // 
            this.queryResultViewerRightSide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.queryResultViewerRightSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queryResultViewerRightSide.Location = new System.Drawing.Point(0, 0);
            this.queryResultViewerRightSide.Name = "queryResultViewerRightSide";
            this.queryResultViewerRightSide.Size = new System.Drawing.Size(958, 283);
            this.queryResultViewerRightSide.TabIndex = 5;
            this.queryResultViewerRightSide.Load += new System.EventHandler(this.queryResultViewerRightSide_Load);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBoxUnsafeCompare);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(964, 690);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Options";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBoxUnsafeCompare
            // 
            this.checkBoxUnsafeCompare.AutoSize = true;
            this.checkBoxUnsafeCompare.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkBoxUnsafeCompare.Location = new System.Drawing.Point(8, 6);
            this.checkBoxUnsafeCompare.Name = "checkBoxUnsafeCompare";
            this.checkBoxUnsafeCompare.Size = new System.Drawing.Size(157, 30);
            this.checkBoxUnsafeCompare.TabIndex = 13;
            this.checkBoxUnsafeCompare.Text = "Try avoid hashing large files\r\n(quicker but unsafe)";
            this.checkBoxUnsafeCompare.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkBoxUnsafeCompare.UseVisualStyleBackColor = true;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Locate the folder to scan";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 716);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Disk Defuzzer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRightFolder;
        private System.Windows.Forms.TextBox textBoxLeftFolder;
        private System.Windows.Forms.Label label2;
        private QueryResultViewer queryResultViewerLeftSide;
        private QueryResultViewer queryResultViewerRightSide;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonStartScan;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkBoxUnsafeCompare;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button buttonBrowseLFolder;
        private System.Windows.Forms.Button buttonBrowserRFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label3;
    }
}