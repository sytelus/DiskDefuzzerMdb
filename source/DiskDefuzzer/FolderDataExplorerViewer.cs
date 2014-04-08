using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Astrila.Common;

namespace Astrila.DiskDefuzzer
{
    public partial class FolderDataExplorerViewer : UserControl, IFolderDataViewer
    {
        public FolderDataExplorerViewer()
        {
            InitializeComponent();
        }

        #region IFolderDataViewer Members

        public void SelectAll()
        {
            folderDataGridViewer1.SelectAll();
        }

        public QueryResultFileInfo[] SelectedFilePaths()
        {
            return folderDataGridViewer1.SelectedFilePaths();
        }


        FolderData _lastFolderData;
        bool _lastIsForRightSide;
        string _lastSqlText;
        
        public void RefreshResults(string sqlText, FolderData paramFolderData, bool isForRightSide, bool isFullRefresh)
        {
            _lastFolderData = paramFolderData;
            _lastIsForRightSide = isForRightSide;
            _lastSqlText = sqlText;

            if (isFullRefresh || (treeView1.SelectedNode == null))
            {
                //Fill the treeview
                treeView1.Nodes.Clear();

                //Add the root node
                TreeNode rootNode = treeView1.Nodes.Add(@"", paramFolderData.GetOriginalFolderPathFromSettings(isForRightSide), "CloseFolder");

                treeView1.SelectedNode = rootNode;

                FillChildNodes(treeView1.SelectedNode);
                
                rootNode.Expand();
            }

            RefreshGridViewForSelectedTreeNode();
        }

        private void FillChildNodes(TreeNode nodeToFill)
        {
            nodeToFill.Nodes.Clear();
            DataTable subFoldersDataTable = _lastFolderData.GetQueryResults(@"SELECT f.FolderName, f.FolderPath, (SELECT COUNT(*) FROM %rOrL%Folder WHERE ParentFolderPath = f.FolderPath) AS SubFolderCount
                                            FROM 
                                            %rOrL%Folder AS f
                                            WHERE (((f.[ParentFolderPath])='" + nodeToFill.Name + "'));", _lastIsForRightSide);
            
            for (int rowIndex = 0; rowIndex < subFoldersDataTable.Rows.Count; rowIndex++)
            {
                DataRow folderRow = subFoldersDataTable.Rows[rowIndex];
                TreeNode thisNode = nodeToFill.Nodes.Add(folderRow["FolderPath"].ToString(), folderRow["FolderName"].ToString(), "CloseFolder");
                if (((int) folderRow["SubFolderCount"]) > 0)
                {
                    thisNode.Nodes.Add("*dummy*");
                }
            }
        }

        public void GetFilePathsToCompare(out string filePath1, out string filePath2)
        {
            folderDataGridViewer1.GetFilePathsToCompare(out filePath1, out filePath2);
        }

        public int SelectedObjectsCount
        {
            get
            {
                return folderDataGridViewer1.SelectedObjectsCount;
            }
        }

        public void OpenSelectedFile()
        {
            folderDataGridViewer1.OpenSelectedFile();
        }

        public object GetClipboardContent()
        {
            return folderDataGridViewer1.GetClipboardContent();
        }

        public void OpenContainingFolder()
        {
            if (treeView1.SelectedNode != null)
            {
                string pathToOpen = _lastFolderData.GetOriginalFolderPathFromSettings(_lastIsForRightSide) +
                                    treeView1.SelectedNode.Name;
                    //Stupid Path.Combine doesn't work if second arg starts with \
                    //Path.Combine(_lastFolderData.GetOriginalFolderPathFromSettings(_lastIsForRightSide),
                    //             treeView1.SelectedNode.Name);
                Process.Start(pathToOpen);
            }
            else
                folderDataGridViewer1.OpenContainingFolder();
        }

        public string SelectedFolderPath()
        {
            throw new NotImplementedException();
        }

        public int RowCount()
        {
            return folderDataGridViewer1.RowCount();
        }

        #endregion

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            treeView1.SelectedNode.ImageKey = "OpenFolder";
            RefreshGridViewForSelectedTreeNode();
        }

        private void RefreshGridViewForSelectedTreeNode()
        {
            if (treeView1.SelectedNode != null)
            {
                string sqlWithFolderFilter = UtilityFunctions.ReplaceString(_lastSqlText, @"%ParentFolderPathFilter%", @"AND (%rOrL%.RelativeFolderPath = '" + treeView1.SelectedNode.Name + "')", true);
                folderDataGridViewer1.RefreshResults(sqlWithFolderFilter, _lastFolderData, _lastIsForRightSide, true);
            }
            else
            {
                folderDataGridViewer1.RefreshResults("Select TOP 1 'No selection' FROM [Settings]", _lastFolderData, _lastIsForRightSide, true);
            }
        }
        
        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if ((e.Node.Nodes.Count == 1) && (e.Node.Nodes[0].Text == "*dummy*"))
            {
                this.FillChildNodes(e.Node);
            }
        }

        private void treeView1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void treeView1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void treeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (treeView1.SelectedNode != null)
                treeView1.SelectedNode.ImageKey = "CloseFolder";
        }
    }
}
