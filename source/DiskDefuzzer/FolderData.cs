using System;
using System.Collections.Generic;
using System.Text;

using Astrila.Common;
using System.Data;
using System.Data.Common;
using System.IO;

namespace Astrila.DiskDefuzzer
{
    public class FolderData
    {
        private DataAccess _dataAccess = null;
        private DataSet _filesDataSet = null;
        DataTable _leftSideFilesDataTable;
        DataTable _rightSideFilesDataTable;
        DataTable _leftSideFoldersDataTable;
        DataTable _rightSideFoldersDataTable;
        DataTable _settingsDataTable;

        private string _mdbFilePath;
        
        public FolderData(string mdbFilePath)
        {
            _mdbFilePath = mdbFilePath;
            _dataAccess = new DataAccess(Astrila.Common.UtilityFunctions.GetConnectionStringForAccess(mdbFilePath));
            _filesDataSet = new DataSet();
            _settingsDataTable = _dataAccess.GetTableData("Settings", _filesDataSet, "Settings").Tables["Settings"];
        }

        private const string RightSideFilesTableName = "RWorkTable";
        private const string LeftSideFilesTableName = "LWorkTable";
        private const string RightSideFoldersTableName = "RFolder";
        private const string LeftSideFoldersTableName = "LFolder";

        public delegate void ProgressUpdate(decimal currentIndex, decimal totalCount, string summaryMessage, string detailMessage, ref object eventArgsCustomParameter, ref bool cancelProcessing);

        public string DatabaseFilePath
        {
            get 
            {
                return _mdbFilePath;
            }
        }

        public string GetOriginalFolderPathFromSettings(bool isForRightSide)
        {
            string columnName = GetOriginalFolderPathColumnNameForSettings(isForRightSide);
            return _settingsDataTable.Rows[0][columnName].ToString();
        }
        
        private string GetOriginalFolderPathColumnNameForSettings(bool isForRightSide)
        {
            return (isForRightSide) ? "ROriginalFolderPath" : "LOriginalFolderPath";
        }
        
        private void InitializeEmptyDataSet()
        {
            if (_filesDataSet == null)
            {
                _filesDataSet = new DataSet();
            }

            _rightSideFilesDataTable = CreateOrCleanDataTable(true, true);
            _leftSideFilesDataTable = CreateOrCleanDataTable(false, true);
            _leftSideFoldersDataTable = CreateOrCleanDataTable(false, false);
            _rightSideFoldersDataTable = CreateOrCleanDataTable(true, false);
        }

        public void DeleteFileEntriesInDatabase(QueryResultFileInfo[] selectedFiles, bool isForRightSide)
        {
            StringBuilder idListBuilder = new StringBuilder(200);

            for (int fileIndex = 0; fileIndex < selectedFiles.Length; fileIndex++)
            {
                idListBuilder.Append(selectedFiles[fileIndex].ID.ToString());

                if (fileIndex < selectedFiles.Length - 1)
                    idListBuilder.Append(",");
                
                if ((idListBuilder.Length > 200) || (fileIndex == selectedFiles.Length-1))
                {
                    _dataAccess.ExecuteSql(
                        string.Format("Delete FROM {0} WHERE ID IN ({1})", this.GetTableName(isForRightSide, true), idListBuilder.ToString()), false);

                    idListBuilder.Length = 0;
                }
            }
        }
        
        private DataTable CreateOrCleanDataTable(bool isForRightSide, bool isFilesOrFolders)
        {
            string tableName = this.GetTableName(isForRightSide, isFilesOrFolders);
            DataTable folderTable;

            if (_filesDataSet.Tables.Contains(tableName))
            {
                folderTable = _filesDataSet.Tables[tableName];
                folderTable.Rows.Clear();
            }
            else
            {
                _dataAccess.GetTableData(string.Format(@"sql:select * from {0} WHERE 1=2", tableName), _filesDataSet, tableName);
                folderTable = _filesDataSet.Tables[tableName];
            }

            return folderTable;
        }


        public DataTable GetPresetQueryDataTable()
        {
            return _dataAccess.GetTableData(@"sql:select * from PresetQueries ORDER BY DisplayOrder", "PresetQueries").Tables["PresetQueries"];
        }

        public DataTable GetQueryResults(string sqlText, bool isForRightSide)
        {
            return GetQueryResults(sqlText, isForRightSide, null, "QueryResults");
        }

        private DataTable GetQueryResults(string sqlText, bool isForRightSide, DataSet dataSetToFill, string tableName)
        {
            if (sqlText.Length > 0)
            {
                sqlText = SqlTextWithTokenReplaced(sqlText, isForRightSide);
                SharedHelpers.DebugHelper.LogMessage(sqlText);
                
                return _dataAccess.GetTableData(@"sql:" + sqlText, dataSetToFill, tableName).Tables[tableName];
            }
            else return null;
        }

        private int _queryResultMaxRows = 2000;
        public int QueryResultMaxRows
        {
            get { return _queryResultMaxRows;}
            set { _queryResultMaxRows = value; }
        }
        
        private string SqlTextWithTokenReplaced(string sqlText, bool isForRightSide)
        {
            sqlText = UtilityFunctions.ReplaceString(sqlText, @"%IsRightSide%", isForRightSide ? "true" : "false", true);
            sqlText = UtilityFunctions.ReplaceString(sqlText, @"%rOrL%", isForRightSide ? "r" : "l", true);
            sqlText = UtilityFunctions.ReplaceString(sqlText, @"%lOrR%", isForRightSide ? "l" : "r", true);
            sqlText = UtilityFunctions.ReplaceString(sqlText, @"%MaxRows%", _queryResultMaxRows.ToString(), true);
            sqlText = UtilityFunctions.ReplaceString(sqlText, @"%ParentFolderPathFilter%", @"", true);  //By default do not filter results by folder - display all results from all folders

            return sqlText;
        }

        public void CleanData()
        {
            _dataAccess.ExecuteSql("delete from " + RightSideFilesTableName, false);
            _dataAccess.ExecuteSql("delete from " + LeftSideFilesTableName, false);
            _dataAccess.ExecuteSql("delete from " + RightSideFoldersTableName, false);
            _dataAccess.ExecuteSql("delete from " + LeftSideFoldersTableName, false);
        }

        public void CreateDataForFolders(bool cleanPreviousData, string rightFolderPath, string leftFolderPath, string fileWildCardFilter, object eventArgsCustomParameter, ProgressUpdate progressUpdateCallBack, decimal progressRangeStart, decimal progressRangeEnd, decimal progressRangeEndForAllFolders, bool isAvoidHashingForLargeFiles)
        {
            //Remove trailing \
            if (rightFolderPath.Trim().EndsWith(Path.DirectorySeparatorChar.ToString()) && !rightFolderPath.Trim().EndsWith(Path.VolumeSeparatorChar.ToString() + Path.DirectorySeparatorChar.ToString()))
                rightFolderPath = rightFolderPath.Trim().Substring(0, rightFolderPath.Trim().Length - 1);

            if (leftFolderPath.Trim().EndsWith(Path.DirectorySeparatorChar.ToString())  && !leftFolderPath.Trim().EndsWith(Path.VolumeSeparatorChar.ToString() + Path.DirectorySeparatorChar.ToString()))
                leftFolderPath = leftFolderPath.Trim().Substring(0, leftFolderPath.Trim().Length - 1);

            _settingsDataTable.Rows[0][GetOriginalFolderPathColumnNameForSettings(true)] = rightFolderPath;
            _settingsDataTable.Rows[0][GetOriginalFolderPathColumnNameForSettings(false)] = leftFolderPath;
            _dataAccess.UpdateTableData(_filesDataSet, "Settings");
            
            UpdateProgress(progressUpdateCallBack, progressRangeStart, progressRangeEndForAllFolders, "Initializing data for folder", "Cleaning previous data...", ref eventArgsCustomParameter);

            if (cleanPreviousData)
                CleanData();
            
            InitializeEmptyDataSet();

            if (rightFolderPath != null)
                CreateDataForFolderPrivate(rightFolderPath, _rightSideFilesDataTable, _rightSideFoldersDataTable, fileWildCardFilter, true, rightFolderPath, eventArgsCustomParameter, progressUpdateCallBack, GetProgressRangeStart(progressRangeStart, progressRangeEnd, 0m), GetProgressRangeStart(progressRangeStart, progressRangeEnd, 0.25m), progressRangeEndForAllFolders);

            if (leftFolderPath != null)
                CreateDataForFolderPrivate(leftFolderPath, _leftSideFilesDataTable, _leftSideFoldersDataTable, fileWildCardFilter, true, leftFolderPath, eventArgsCustomParameter, progressUpdateCallBack, GetProgressRangeStart(progressRangeStart, progressRangeEnd, 0.25m), GetProgressRangeStart(progressRangeStart, progressRangeEnd, 0.5m), progressRangeEndForAllFolders);

            //Do partial content hash
            UpdateHashValuesForFiles(false, isAvoidHashingForLargeFiles, eventArgsCustomParameter, progressUpdateCallBack, GetProgressRangeStart(progressRangeStart, progressRangeEnd, 0.5m), GetProgressRangeStart(progressRangeStart, progressRangeEnd, 0.75m), progressRangeEndForAllFolders);

            //Do full content hash
            UpdateHashValuesForFiles(true, isAvoidHashingForLargeFiles, eventArgsCustomParameter, progressUpdateCallBack, GetProgressRangeStart(progressRangeStart, progressRangeEnd, 0.75m), GetProgressRangeStart(progressRangeStart, progressRangeEnd, 1m), progressRangeEndForAllFolders);
        }


        private decimal GetProgressRangeStart(decimal originalProgressRangeStart, decimal originalProgressRangeEnd, decimal thisRangeBeginsAt)
        {
            return originalProgressRangeStart + ((originalProgressRangeEnd - originalProgressRangeStart) * thisRangeBeginsAt);
        }

        private const int ByteCountForPartialContentHash = 10000;
        private const int MaxBatchUpdateRowCount = 2000;
        
        private void UpdateHashValuesForFiles(bool isFullContentHash, bool isAvoidHashingForLargeFiles, object eventArgsCustomParameter, ProgressUpdate progressUpdateCallBack, decimal progressRangeStart, decimal progressRangeEnd, decimal progressRangeEndForAllFolders)
        {
            //Get files which are of same size in current folder or in other folder
            string sqlText;
            int minfileSize;
            string avoidLargeFilesFilter;
            string joinColumnName;

            sqlText = @"sql:
                    SELECT DISTINCT t1.ID, t1.FilePath, t1.FileName, t1.FileSize, t1.FileContentHash, t1.AccessError, -1 AS [IsRightSide]
                    FROM %rOrL%WorkTable t1
                    INNER JOIN %rOrL%WorkTable t2
                    ON t1.{1} = t2.{1}
                    WHERE (t1.FileSize > {0})
                        AND (t2.ID <> t1.ID)
                        {2}

                    UNION

                    SELECT DISTINCT t1.ID, t1.FilePath, t1.FileName, t1.FileSize, t1.FileContentHash, t1.AccessError, -1 AS [IsRightSide]
                    FROM %rOrL%WorkTable t1
                    INNER JOIN %lOrR%WorkTable t2
                    ON t1.{1} = t2.{1}
                    WHERE (t1.FileSize > {0})
                        AND (t2.ID <> t1.ID)
                        {2}

                    UNION

                    SELECT DISTINCT t2.ID, t2.FilePath, t2.FileName, t2.FileSize, t2.FileContentHash, t2.AccessError, 0 AS [IsRightSide]
                    FROM %rOrL%WorkTable t1
                    INNER JOIN %lOrR%WorkTable t2
                    ON t1.{1} = t2.{1}
                    WHERE (t1.FileSize > {0})
                        AND (t2.ID <> t1.ID)
                        {2}
                    
                    UNION
                    
                    SELECT DISTINCT t2.ID, t2.FilePath, t2.FileName, t2.FileSize, t2.FileContentHash, t2.AccessError, 0 AS [IsRightSide]
                    FROM %lOrR%WorkTable t1
                    INNER JOIN %lOrR%WorkTable t2
                    ON t1.{1} = t2.{1}
                    WHERE (t1.FileSize > {0})
                        AND (t2.ID <> t1.ID)
                        {2}
                    ";

            if (isFullContentHash)
            {
                if (isAvoidHashingForLargeFiles)
                {
                    avoidLargeFilesFilter = "AND (t1.FileSize < 100000 OR t1.FileName <> t2.FileName OR t1.FileModifyDateTime <> t2.FileModifyDateTime OR t1.FileCreateDateTime <> t2.FileCreateDateTime)";
                }
                else avoidLargeFilesFilter = "";

                joinColumnName = "FileContentHash";
                minfileSize = ByteCountForPartialContentHash;
            }
            else
            {
                avoidLargeFilesFilter = "";
                joinColumnName = "FileSize";
                minfileSize = 0;
            }

            DataSet dataSetForUpdates = new DataSet();
            DataTable updatesForRWorkTable = _dataAccess.GetTableData("sql: SELECT ID, FilePath, FileSize, FileContentHash, AccessError FROM RWorkTable Where 1=2", dataSetForUpdates, "RWorkTable").Tables["RWorkTable"];
            DataTable updatesForLWorkTable = _dataAccess.GetTableData("sql: SELECT ID, FilePath, FileSize, FileContentHash, AccessError FROM LWorkTable Where 1=2", dataSetForUpdates, "LWorkTable").Tables["LWorkTable"];

            sqlText = string.Format(sqlText, minfileSize, joinColumnName, avoidLargeFilesFilter);
            sqlText = this.SqlTextWithTokenReplaced(sqlText, true); //second param doesn't matter for this query

            using (DbDataReader reader = _dataAccess.GetDataReader(sqlText))
            {
                UpdateProgress(progressUpdateCallBack, progressRangeEnd - 1, progressRangeEndForAllFolders, "Calculating initial hash", "Getting list of files...", ref eventArgsCustomParameter);

                bool readerEndNotReached = reader.Read();
                while (readerEndNotReached)
                {
                    DataRow fileDataRow;
                    if (reader.GetInt32(reader.GetOrdinal("IsRightSide")) != 0)
                    {
                        fileDataRow = updatesForRWorkTable.NewRow();
                        updatesForRWorkTable.Rows.Add(fileDataRow);
                    }
                    else
                    {
                        fileDataRow = updatesForLWorkTable.NewRow();
                        updatesForLWorkTable.Rows.Add(fileDataRow);
                    }

                    fileDataRow.ItemArray = new object[] {reader["ID"], reader["FilePath"], reader["FileSize"], reader["FileContentHash"], reader["AccessError"]};
                    fileDataRow.AcceptChanges();

                    UpdateProgress(progressUpdateCallBack, GetProgressRangeStart(progressRangeStart, progressRangeEnd, 0.5m), progressRangeEndForAllFolders, "Calculating " + (isFullContentHash?"full hashes":"initial hashes"), "Calculating hash for " + reader["FileName"].ToString() + "...", ref eventArgsCustomParameter);

                    //Update the hash for this file
                    this.UpdateHashAndSizeInFileRow(fileDataRow, isFullContentHash);

                    readerEndNotReached = reader.Read();

                    //Flush the updates if we have too many rows in memory
                    if ((!readerEndNotReached) || ((updatesForRWorkTable.Rows.Count + updatesForLWorkTable.Rows.Count) > MaxBatchUpdateRowCount))
                    {
                        UpdateProgress(progressUpdateCallBack, progressRangeEnd, progressRangeEndForAllFolders, "Calculating initial hash", "Updating data on file hash values...", ref eventArgsCustomParameter);
                        
                        if (updatesForRWorkTable.Rows.Count > 0)
                        {
                            _dataAccess.UpdateTableData(dataSetForUpdates, "RWorkTable", "SELECT ID, FilePath, FileSize, FileContentHash FROM RWorkTable");
                            updatesForRWorkTable.Clear();
                        }

                        if (updatesForLWorkTable.Rows.Count > 0)
                        {
                            _dataAccess.UpdateTableData(dataSetForUpdates, "LWorkTable", "SELECT ID, FilePath, FileSize, FileContentHash FROM LWorkTable");
                            updatesForLWorkTable.Clear();
                        }
                    }
                }
            }
        }

        private string GetTableName(bool isForRightSide, bool isFilesOrFolders)
        {
            if (isFilesOrFolders) return isForRightSide ? RightSideFilesTableName : LeftSideFilesTableName;
            else return isForRightSide ? RightSideFoldersTableName : LeftSideFoldersTableName;
        }


        byte[] _reusableFileContent = new byte[ByteCountForPartialContentHash];
        private void UpdateHashAndSizeInFileRow(DataRow rowToUpdate, bool isFullContentHash)
        {
            string filePath = rowToUpdate["FilePath"].ToString();

            try
            {
                using (FileStream fileToReadStream = File.OpenRead(filePath))
                {
                    if (isFullContentHash)
                    {
                        rowToUpdate["FileContentHash"] = rowToUpdate["FileSize"].ToString() + ":" + UtilityFunctions.GetMD5Hash(fileToReadStream);
                    }
                    else
                    {
                        int bytesRead = fileToReadStream.Read(_reusableFileContent, 0, ByteCountForPartialContentHash);

                        if (bytesRead > 0)
                        {
                            rowToUpdate["FileContentHash"] = rowToUpdate["FileSize"].ToString() + ":" + UtilityFunctions.GetMD5Hash(_reusableFileContent, bytesRead);
                        }
                        else
                        {
                            rowToUpdate["FileSize"] = 0;
                            rowToUpdate["FileContentHash"] = rowToUpdate["FileName"];
                        }
                    }
                    fileToReadStream.Close();
                }
            }
            catch (Exception ex)
            {
                //Set hash to NULL
                rowToUpdate["FileContentHash"] = DBNull.Value;
                rowToUpdate["AccessError"] = ex.ToString();
            }
        }

        private void UpdateProgress(ProgressUpdate progressUpdateCallBack, decimal currentIndex, decimal totalCount, string summaryMessage, string detailMessage, ref object eventArgsCustomParameter)
        {
            if (progressUpdateCallBack != null)
            {
                bool cancelProcessing = false;
                progressUpdateCallBack(currentIndex, totalCount, summaryMessage + string.Format(" ({0:P} done)", currentIndex/totalCount), detailMessage, ref eventArgsCustomParameter, ref cancelProcessing);
                if (cancelProcessing == true)
                {
                    throw new UserCancelledException("");
                }
            }
        }
        
        private void CreateEntryForFolder(string originalFolderPath, string parentFolderPath, string folderName, string folderPath, DataTable foldersDataTable)
        {
            DataRow thisFolderRow = foldersDataTable.NewRow();
            thisFolderRow["FolderName"] = folderName;
            thisFolderRow["FolderPath"] = folderPath.Substring(originalFolderPath.Length);
            thisFolderRow["ParentFolderPath"] = parentFolderPath.Substring(originalFolderPath.Length);
            foldersDataTable.Rows.Add(thisFolderRow);
        }
        
        private void CreateDataForFolderPrivate(string folderPath, DataTable filesDataTable, DataTable foldersDataTable, string fileWildCardFilter, bool endRecursion, string originalFolderPath, object eventArgsCustomParameter, ProgressUpdate progressUpdateCallBack, decimal progressRangeStart, decimal progressRangeEnd, decimal progressRangeEndForAllFolders)
        {
            string fileNameForErrorTracking = null;
            try
            {
                DirectoryInfo folderToScan = new DirectoryInfo(folderPath);

                //First go deeper so we don't have too many arrays in-scope for GC
                DirectoryInfo[] subFolders = folderToScan.GetDirectories();
                for (int folderIndex = 0; folderIndex < subFolders.Length; folderIndex++)
                {
                    decimal progressRangeStartForChild = progressRangeStart + (folderIndex * ((progressRangeEnd - progressRangeStart) / (subFolders.Length + 1)));
                    decimal progressRangeEndForChild = progressRangeStartForChild + ((progressRangeEnd - progressRangeStart) / (subFolders.Length + 1));

                    CreateEntryForFolder(originalFolderPath, subFolders[folderIndex].Parent.FullName, subFolders[folderIndex].Name, subFolders[folderIndex].FullName, foldersDataTable);
                        
                    CreateDataForFolderPrivate(subFolders[folderIndex].FullName, filesDataTable, foldersDataTable, fileWildCardFilter, false, originalFolderPath, eventArgsCustomParameter, progressUpdateCallBack, progressRangeStartForChild, progressRangeEndForChild, progressRangeEndForAllFolders);
                }


                UpdateProgress(progressUpdateCallBack, progressRangeEnd - 1, progressRangeEndForAllFolders, "Scanning folders", "Scanning files in " + folderPath, ref eventArgsCustomParameter);

                FileInfo[] filesToScan = folderToScan.GetFiles(fileWildCardFilter);
                for (int fileIndex = 0; fileIndex < filesToScan.Length; fileIndex++)
                {
                    fileNameForErrorTracking = filesToScan[fileIndex].FullName;
                    CreateDataForFile(filesToScan[fileIndex], filesDataTable, originalFolderPath);
                }

                //At each child folder interation or at the end of recurison
                if (endRecursion || ((filesDataTable.Rows.Count + foldersDataTable.Rows.Count) > MaxBatchUpdateRowCount))
                {
                    UpdateProgress(progressUpdateCallBack, progressRangeEnd - 1, progressRangeEndForAllFolders, "Scanning folders", "Updating stats for files in " + folderPath, ref eventArgsCustomParameter);

                    //Lets flush this data in MDB so we don't have huge dataset in memory
                    _dataAccess.UpdateTableData(_filesDataSet, filesDataTable.TableName);
                    _dataAccess.UpdateTableData(_filesDataSet, foldersDataTable.TableName);
                    InitializeEmptyDataSet();   //Release memory hold by DataTable
                }
            }
            catch (Exception ex)
            {
                if (ex is UserCancelledException)
                    throw;
                else
                    CreateErrorEntry(folderPath, fileNameForErrorTracking, ex.ToString(), originalFolderPath, filesDataTable, foldersDataTable);
            }
        }

        private void CreateErrorEntry(string folderPath, string filePath, string errorMessage, string originalFolderPath, DataTable dataTableToUse, DataTable foldersDataTable)
        {
            if (filePath != null)
            {
                DataRow rowForFile = dataTableToUse.NewRow();

                rowForFile["FilePath"] = filePath;
                rowForFile["FileName"] = Path.GetFileName(filePath);
                rowForFile["RelativeFolderPath"] = folderPath.Substring(originalFolderPath.Length);
                rowForFile["FileModifyDateTime"] = DBNull.Value;
                rowForFile["FileCreateDateTime"] = DBNull.Value;
                rowForFile["FileSize"] = DBNull.Value;
                rowForFile["FileContentHash"] = DBNull.Value;
                rowForFile["AccessError"] = errorMessage;

                dataTableToUse.Rows.Add(rowForFile);
            }
            else
            {
                DataRow thisFolderRow = foldersDataTable.NewRow();
                thisFolderRow["FolderName"] = Path.GetDirectoryName(folderPath);
                string parentFolderPath =
                    folderPath.Substring(0, folderPath.Length - Path.GetDirectoryName(folderPath).Length);
                thisFolderRow["ParentFolderPath"] = parentFolderPath.Substring(originalFolderPath.Length);
                thisFolderRow["FolderPath"] = folderPath.Substring(originalFolderPath.Length);
                foldersDataTable.Rows.Add(thisFolderRow);
            }
        }

        //static int _alwaysIncreasingInt = 0;
        private void CreateDataForFile(FileInfo fileToScan, DataTable filesDataTable, string originalFolderPath)
        {
            DataRow rowForFile = filesDataTable.NewRow();

            rowForFile["FilePath"] = fileToScan.FullName;
            rowForFile["FileName"] = fileToScan.Name;
            rowForFile["RelativeFolderPath"] = fileToScan.DirectoryName.Substring(originalFolderPath.Length);
            rowForFile["FileModifyDateTime"] = fileToScan.LastWriteTimeUtc;
            rowForFile["FileCreateDateTime"] = fileToScan.CreationTimeUtc; ;
            rowForFile["FileSize"] = fileToScan.Length;

            if (fileToScan.Length > 0)
            {
                rowForFile["FileContentHash"] = fileToScan.Length.ToString();
            }
            else
            {
                //For zero length files, name is the hash so they match up in dup and similar searches
                rowForFile["FileContentHash"] = fileToScan.Name;
            }

            filesDataTable.Rows.Add(rowForFile);
        }
    }

    [global::System.Serializable]
    public class UserCancelledException : Exception
    {
        public UserCancelledException() { }
        public UserCancelledException(string message) : base(message) { }
        public UserCancelledException(string message, Exception inner) : base(message, inner) { }
        protected UserCancelledException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }

}


                //try
                //{
                //    using (Stream streamForFileToScan = fileToScan.OpenRead())
                //    {
                //        rowForFile["FileContentHash"] = UtilityFunctions.GetMD5Hash(streamForFileToScan);
                //    }
                //}
                //catch(Exception ex)
                //{
                //    //Set hash to NULL
                //    rowForFile["FileContentHash"] = DBNull.Value;
                //    rowForFile["AccessError"] = ex.ToString();
                //}
