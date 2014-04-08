using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Astrila.DiskDefuzzer
{
    public partial class FolderDataGridViewer : UserControl, IFolderDataViewer
    {
        public FolderDataGridViewer()
        {
            InitializeComponent();
        }

        private void dataGridViewQueryResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewQueryResult.DataSource != null)
            {
                if (dataGridViewQueryResult.Columns.Contains("LaunchFilePath"))
                {
                    string fileName = dataGridViewQueryResult.SelectedRows[0].Cells["LaunchFilePath"].Value.ToString();
                    if (fileName.Length > 0)
                    {
                        System.Diagnostics.Process.Start(fileName);
                    }
                    //else ignore because file name is not available
                }
                //else ignore because we don't know file path
            }
            //else ignore double click
        }


        public void SelectAll()
        {
            dataGridViewQueryResult.SelectAll();
        }

        public QueryResultFileInfo[] SelectedFilePaths()
        {
            if (dataGridViewQueryResult.Columns.Contains("LaunchFilePath"))
            {
                DataGridViewSelectedRowCollection selectedRows = dataGridViewQueryResult.SelectedRows;

                QueryResultFileInfo[] selectedFileInfos = new QueryResultFileInfo[selectedRows.Count];
                for (int selectedRowIndex = 0; selectedRowIndex < selectedRows.Count; selectedRowIndex++)
                {
                    selectedFileInfos[selectedRowIndex].FilePath = selectedRows[selectedRowIndex].Cells["LaunchFilePath"].Value.ToString();
                    selectedFileInfos[selectedRowIndex].ID = (int) selectedRows[selectedRowIndex].Cells["ID"].Value;
                }

                return selectedFileInfos;
            }
            else return null;
        }

        public void RefreshResults(string sqlText, FolderData paramFolderData, bool isForRightSide, bool isFullRefresh)
        {
            dataGridViewQueryResult.DataSource = null;
            if (sqlText.Length > 0)
            {
                dataGridViewQueryResult.DataSource = paramFolderData.GetQueryResults(sqlText, isForRightSide);
                if (dataGridViewQueryResult.Columns.Contains("LaunchFilePath"))
                {
                    dataGridViewQueryResult.Columns["LaunchFilePath"].Visible = false;
                }
                //else no need to make LaunchFilePath invisible

                if (dataGridViewQueryResult.Columns.Contains("CompareToFilePath"))
                {
                    dataGridViewQueryResult.Columns["CompareToFilePath"].Visible = false;
                }
                //else no need to make LaunchFilePath invisible

                if (dataGridViewQueryResult.Columns.Contains("ID"))
                {
                    dataGridViewQueryResult.Columns["ID"].Visible = false;
                }
                //else no need to make ID invisible                
            }
        }

        public int SelectedObjectsCount
        {
            get
            {
                return dataGridViewQueryResult.SelectedRows.Count;
            }
        }

        public void OpenSelectedFile()
        {
            dataGridViewQueryResult_CellDoubleClick(null, null);
        }

        public object GetClipboardContent()
        {
            return dataGridViewQueryResult.GetClipboardContent();
        }

        public void GetFilePathsToCompare(out string filePath1, out string filePath2)
        {
            if (dataGridViewQueryResult.Columns.Contains("LaunchFilePath") && dataGridViewQueryResult.Columns.Contains("CompareToFilePath"))
            {
                if (dataGridViewQueryResult.SelectedRows.Count == 1)
                {
                    filePath1 = dataGridViewQueryResult.SelectedRows[0].Cells["LaunchFilePath"].Value.ToString();
                    filePath2 = dataGridViewQueryResult.SelectedRows[0].Cells["CompareToFilePath"].Value.ToString();
                }
                else
                {
                    filePath1 = null;
                    filePath2 = null;
                }
            }
            else
            {
                filePath1 = null;
                filePath2 = null;
            }
        }

        private void dataGridViewQueryResult_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void dataGridViewQueryResult_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        public void OpenContainingFolder()
        {
            if (dataGridViewQueryResult.DataSource != null)
            {
                if (dataGridViewQueryResult.Columns.Contains("LaunchFilePath"))
                {
                    string fileName = dataGridViewQueryResult.SelectedRows[0].Cells["LaunchFilePath"].Value.ToString();
                    if (fileName.Length > 0)
                    {
                        System.Diagnostics.Process.Start(Path.GetDirectoryName(fileName));
                    }
                    //else ignore because file name is not available
                }
                //else ignore because we don't know file path
            }
            //else ignore double click
        }

        public string SelectedFolderPath()
        {
            return "";
        }

        public int RowCount()
        {
            return dataGridViewQueryResult.RowCount;
        }
    }
}
