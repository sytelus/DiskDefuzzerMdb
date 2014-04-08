namespace Astrila.DiskDefuzzer
{
    partial class FolderDataGridViewer
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
            this.dataGridViewQueryResult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQueryResult)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewQueryResult
            // 
            this.dataGridViewQueryResult.AllowUserToAddRows = false;
            this.dataGridViewQueryResult.AllowUserToDeleteRows = false;
            this.dataGridViewQueryResult.AllowUserToOrderColumns = true;
            this.dataGridViewQueryResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewQueryResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQueryResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewQueryResult.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewQueryResult.Name = "dataGridViewQueryResult";
            this.dataGridViewQueryResult.ReadOnly = true;
            this.dataGridViewQueryResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewQueryResult.Size = new System.Drawing.Size(519, 497);
            this.dataGridViewQueryResult.TabIndex = 1;
            this.dataGridViewQueryResult.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewQueryResult_CellDoubleClick);
            this.dataGridViewQueryResult.MouseEnter += new System.EventHandler(this.dataGridViewQueryResult_MouseEnter);
            this.dataGridViewQueryResult.MouseLeave += new System.EventHandler(this.dataGridViewQueryResult_MouseLeave);
            // 
            // FolderDataGridViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewQueryResult);
            this.Name = "FolderDataGridViewer";
            this.Size = new System.Drawing.Size(519, 497);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQueryResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewQueryResult;
    }
}
