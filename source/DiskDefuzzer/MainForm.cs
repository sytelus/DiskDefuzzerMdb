using System;
using System.Threading;
using System.Windows.Forms;
using System.IO.IsolatedStorage;

using System.IO;
using Astrila.Common;

namespace Astrila.DiskDefuzzer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


       
        private void buttonStartScan_Click(object sender, EventArgs e)
        {
            WinProgressDialog.ProgressDialog progress = new WinProgressDialog.ProgressDialog();
            progress.Show(this.Handle.ToInt32(), "Scanning folders", "Initializing...");
            try
            {
                progress.MaxValue = 100;    //initial max value

                FolderData foldersData = new FolderData(this.MdbPath);
                foldersData.CreateDataForFolders(true, textBoxRightFolder.Text, textBoxLeftFolder.Text, @"*", progress, new FolderData.ProgressUpdate(this.ProgressUpdate), 0, 18000, 20000, checkBoxUnsafeCompare.Checked);

                InitQueryresultViewers();

                progress.UpdateProgress(20000, 20000, "Finsihing...");
            }
            catch(UserCancelledException ex)
            {
                //User cancelled the operation
                SharedHelpers.DebugHelper.LogException(ex);
            }
            finally
            {
                progress.Dispose();
            }
        }

        private void ProgressUpdate(decimal currentIndex, decimal totalCount, string summaryMessage, string detailMessage, ref object eventArgsCustomParameter, ref bool cancelProcessing)
        {
            WinProgressDialog.ProgressDialog progress = (WinProgressDialog.ProgressDialog) eventArgsCustomParameter;

            progress.DescriptionLine1 = summaryMessage;

            if (progress.UpdateProgress(currentIndex, totalCount, detailMessage))
            {
                if (MessageBox.Show("Do you want to cancel folder compare?", "Cancel Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)== DialogResult.Yes)
                    cancelProcessing = true;
            }
        }

        private string _mdbPath;
        private string MdbPath
        {
            get
            {
                return _mdbPath;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);

            string sourceMdbFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "DiskDefuzzer.AccessMDBTemplate");

            string mdbInTempFolder = Path.Combine(Path.GetTempPath(), "DiskDefuzzer_" + UtilityFunctions.GetMD5Hash(Application.ExecutablePath) + File.GetLastWriteTimeUtc(sourceMdbFile).ToString("yyyy_MM_dd_hh_mm_ss") + ".mdb");
            
            //Create MDB file for this user
            if (!File.Exists(mdbInTempFolder))
            {
                File.Copy(sourceMdbFile, mdbInTempFolder, false);
                File.SetAttributes(mdbInTempFolder, FileAttributes.Normal); //Remove potential readonly flag
            }
            _mdbPath = mdbInTempFolder;

            InitQueryresultViewers();
        }

        private void InitQueryresultViewers()
        {
            FolderData rightFolderData = new FolderData(this.MdbPath);
            textBoxRightFolder.Text = rightFolderData.GetOriginalFolderPathFromSettings(true);
            queryResultViewerRightSide.SetupDataAccess(rightFolderData, true);

            FolderData leftFolderData = new FolderData(this.MdbPath);
            textBoxLeftFolder.Text = leftFolderData.GetOriginalFolderPathFromSettings(false);
            queryResultViewerLeftSide.SetupDataAccess(leftFolderData, false);
        }
        
        private void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            DiagnosticsSupport.DisplayError(e.Exception);
        }

        private void queryResultViewerRightSide_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonBrowseLFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = textBoxLeftFolder.Text;
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxLeftFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void buttonBrowserRFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = textBoxRightFolder.Text;
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxRightFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}