namespace Astrila.DiskDefuzzer
{
    partial class FolderDataExplorerViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FolderDataExplorerViewer));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.folderDataGridViewer1 = new Astrila.DiskDefuzzer.FolderDataGridViewer();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.folderDataGridViewer1);
            this.splitContainer1.Size = new System.Drawing.Size(820, 518);
            this.splitContainer1.SplitterDistance = 195;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.HideSelection = false;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(195, 518);
            this.treeView1.TabIndex = 0;
            this.treeView1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
            this.treeView1.MouseEnter += new System.EventHandler(this.treeView1_MouseEnter);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.MouseLeave += new System.EventHandler(this.treeView1_MouseLeave);
            this.treeView1.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Fuchsia;
            this.imageList1.Images.SetKeyName(0, "OpenFolder");
            this.imageList1.Images.SetKeyName(1, "CloseFolder");
            // 
            // folderDataGridViewer1
            // 
            this.folderDataGridViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.folderDataGridViewer1.Location = new System.Drawing.Point(0, 0);
            this.folderDataGridViewer1.Name = "folderDataGridViewer1";
            this.folderDataGridViewer1.Size = new System.Drawing.Size(621, 518);
            this.folderDataGridViewer1.TabIndex = 0;
            this.folderDataGridViewer1.MouseEnter += new System.EventHandler(this.treeView1_MouseEnter);
            this.folderDataGridViewer1.MouseLeave += new System.EventHandler(this.treeView1_MouseLeave);
            // 
            // FolderDataExplorerViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "FolderDataExplorerViewer";
            this.Size = new System.Drawing.Size(820, 518);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private FolderDataGridViewer folderDataGridViewer1;
        private System.Windows.Forms.ImageList imageList1;
    }
}
