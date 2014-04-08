using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using Astrila.Common;
using System.IO;

namespace Astrila.DiskDefuzzer
{
    public partial class QueryResultViewer : UserControl
    {
        public QueryResultViewer()
        {
            InitializeComponent();
        }


        private FolderData _folderData;
        private bool _isForRightSide;

        private IFolderDataViewer _currentFolderDataViewer = null;

        private bool _hardRefreshRequired = false;
        
        public void SetupDataAccess(FolderData folderData, bool isForRightSide)
        {
            _folderData = folderData;
            _isForRightSide = isForRightSide;
            _hardRefreshRequired = true;
                
            labelCriteria.Text = "Query for " + ((_isForRightSide) ? "right" : "left") + " folder:";

            //enable viewer
            _currentFolderDataViewer = folderDataExplorerViewer1; // folderDataGridViewer1;
            ((Control) _currentFolderDataViewer).Visible = true;
            
            //Get list of queries
            DataTable queriesDataTable = folderData.GetPresetQueryDataTable();

            //Show it in combo
            comboBoxQuerySelector.DisplayMember = "DisplayName";
            comboBoxQuerySelector.ValueMember = "SqlText";
            comboBoxQuerySelector.SelectedItem = null;
            comboBoxQuerySelector.DataSource = queriesDataTable;
        }

        private void comboBoxQuerySelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshResults(_hardRefreshRequired);
            _hardRefreshRequired = false;   //Only the first time
        }

        public string SelectedSqlText
        {
            get
            {
                string sqlText = "";

                if (comboBoxQuerySelector.SelectedValue != null)
                {
                    sqlText = comboBoxQuerySelector.SelectedValue.ToString();
                }
                //else leave it blank

                return sqlText;
            }
        }

        public void RefreshResults(bool isFullRefresh)
        {
            labelRowCount.Text = "Retrieving results...";
            
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                _currentFolderDataViewer.RefreshResults(this.SelectedSqlText, _folderData, _isForRightSide, isFullRefresh);    
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
            
            if (_folderData.QueryResultMaxRows == _currentFolderDataViewer.RowCount())
            {
                labelRowCount.Text = "First " + _currentFolderDataViewer.RowCount().ToString() + " files in result are displayed";
            }
            else 
            {
                labelRowCount.Text = _currentFolderDataViewer.RowCount().ToString() + " files in result";
            }
        }


        private void toolStripButtonSelectAllFiles_Click(object sender, EventArgs e)
        {
            _currentFolderDataViewer.SelectAll();
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            QueryResultFileInfo[] selectedFileInfos = _currentFolderDataViewer.SelectedFilePaths();

            if (selectedFileInfos != null)
            {
                if (selectedFileInfos.Length > 0)
                {
                    if (MessageBox.Show(String.Format("Delete {0} selected files?", selectedFileInfos.Length), "Delete Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        for (int selectedFileIndex = 0; selectedFileIndex < selectedFileInfos.Length; selectedFileIndex++)
                        {
                            string filePath = selectedFileInfos[selectedFileIndex].FilePath;
                            File.Delete(filePath);
                        }
                        _folderData.DeleteFileEntriesInDatabase(selectedFileInfos, _isForRightSide);
                        this.RefreshResults(true);
                    }
                    // else abort delete
                }
                else MessageBox.Show("No files are selected");
            }
            else MessageBox.Show("Selected query does not support the delete function");
        }

        private void copyToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QueryResultFileInfo[] selectedFileInfos = _currentFolderDataViewer.SelectedFilePaths();

            if (selectedFileInfos != null)
            {
                if (selectedFileInfos.Length > 0)
                {
                    if (MessageBox.Show(String.Format("Copy {0} selected files?", selectedFileInfos.Length), "Copy Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        for (int selectedFileIndex = 0; selectedFileIndex < selectedFileInfos.Length; selectedFileIndex++)
                        {
                            string filePath = selectedFileInfos[selectedFileIndex].FilePath;
                            File.Copy(filePath, Path.Combine(toolStripTextBoxCopyTarget.Text, Path.GetFileName(filePath)));
                        }
                    }
                    // else no need to copy
                }
                else MessageBox.Show("No files are selected");
            }
            else MessageBox.Show("Selected query does not support the copy function");
        }


        private void moveToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QueryResultFileInfo[] selectedFileInfos = _currentFolderDataViewer.SelectedFilePaths();

            if (selectedFileInfos != null)
            {
                if (selectedFileInfos.Length > 0)
                {
                    if (MessageBox.Show(String.Format("Move {0} selected files?", selectedFileInfos.Length), "Move Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        for (int selectedFileIndex = 0; selectedFileIndex < selectedFileInfos.Length; selectedFileIndex++)
                        {
                            string filePath = selectedFileInfos[selectedFileIndex].FilePath;
                            File.Move(filePath, Path.Combine(toolStripTextBoxCopyTarget.Text, Path.GetFileName(filePath)));
                        }
                    }
                    // else no need to move
                }
                else MessageBox.Show("No files are selected");
            }
            else MessageBox.Show("Selected query does not support the move function");
        }


        private void toolStripButtonAddNewQuery_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not implemented yet");
        }

        private void toolStripButtonViewQuery_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.SelectedSqlText);
        }

        private void toolStripButtonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Disk Defuzzer
An utility to compare folder contents with customizable queries.

By Shital Shah

(C) Microsoft Corporation, 2006");
        }

        private void QueryResultViewer_MouseEnter(object sender, EventArgs e)
        {
            //timerMakeToolbarInvisible.Enabled = false;
            //toolStripMain.Visible = true;
        }

        private void QueryResultViewer_MouseLeave(object sender, EventArgs e)
        {
            //Enable the timer 
            //timerMakeToolbarInvisible.Enabled = true;
        }

        private void toolStripButtonCompareFiles_Click(object sender, EventArgs e)
        {
            if (_currentFolderDataViewer.SelectedObjectsCount == 1)
            {

                string filePath1;
                string filePath2;

                _currentFolderDataViewer.GetFilePathsToCompare(out filePath1, out filePath2);

                if (filePath1==null || filePath2==null)
                {
                    MessageBox.Show("This query does not support file comparison");
                }
                else
                {
                    System.Diagnostics.Process.Start("windiff.exe", string.Format(@"""{0}"" ""{1}""", filePath1, filePath2));
                }
            }
            else MessageBox.Show("Please select one item");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _currentFolderDataViewer.OpenSelectedFile();
        }

        private void copySelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetDataObject(_currentFolderDataViewer.GetClipboardContent());
        }

        private void timerMakeToolbarInvisible_Tick(object sender, EventArgs e)
        {
            timerMakeToolbarInvisible.Enabled = false;
            toolStripMain.Visible = false;
        }

        private void folderDataExplorerViewer1_Load(object sender, EventArgs e)
        {
   
        }

        private void toolStripButtonSwitchView_Click(object sender, EventArgs e)
        {
            if (_currentFolderDataViewer != null)
            {
                ((Control)_currentFolderDataViewer).Visible = false;
            }
            
            if (toolStripButtonSwitchView.Checked)
                _currentFolderDataViewer = folderDataGridViewer1;
            else
                _currentFolderDataViewer = folderDataExplorerViewer1; // folderDataGridViewer1;

            ((Control)_currentFolderDataViewer).Visible = true;

            this.RefreshResults(true);
        }

        private void toolStripButtonOpenMdb_Click(object sender, EventArgs e)
        {
            Process.Start(_folderData.DatabaseFilePath);
        }

        private void toolStripMenuItemOpenFolder_Click(object sender, EventArgs e)
        {
            _currentFolderDataViewer.OpenContainingFolder();
        }

        private void toolStripButtonResync_Click(object sender, EventArgs e)
        {

        }
    }

    public interface IFolderDataViewer
    {
        void SelectAll();
        QueryResultFileInfo[] SelectedFilePaths();
        void RefreshResults(string sqlText, FolderData paramFolderData, bool isForRightSide, bool isFullRefresh);
        void GetFilePathsToCompare(out string filePath1, out string filePath2);
        int SelectedObjectsCount { get; }
        void OpenSelectedFile();
        object GetClipboardContent();
        void OpenContainingFolder();
        string SelectedFolderPath();
        int RowCount();
    }
    
    public struct QueryResultFileInfo
    {
        public string FilePath;
        public int ID;
    }
}
