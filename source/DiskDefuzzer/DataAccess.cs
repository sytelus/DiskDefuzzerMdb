using System;
using System.Data;
using System.Data.OleDb;
using System.Configuration;
using System.IO;

using System.Data.Common;

namespace Astrila.Common
{
	/// <summary>
	/// Summary description for AppData.
	/// </summary>
	public class DataAccess
	{
		private string m_ConectionString = null;

		public DataAccess(string connectionString)
		{
			m_ConectionString =	connectionString;
		}

		public static string BuildConnectionStringForAccess(string mdbFilePath)
		{
			return UtilityFunctions.GetConnectionStringForAccess(mdbFilePath);
		}

        

		public DataSet GetTableData(string tableName, string dataSetTableName )
		{
			return GetTableData(tableName, null, null, null, dataSetTableName);
		}
		public DataSet GetTableData(string tableName)
		{
			return GetTableData(tableName, null, null, null,tableName);
		}
		public DataSet GetTableData(string tableName, DataSet dataSetToFill, string dataSetTableName)
		{
			return GetTableData(tableName, dataSetToFill, null, null,dataSetTableName);
		}
		public DataSet GetTableData(string tableName, DataSet dataSetToFill)
		{
			return GetTableData(tableName, dataSetToFill, null, null,tableName);
		}
		public DataSet GetTableData(string tableName, string[] columnNames, object[] columnValues)
		{
			return GetTableData(tableName, null, columnNames, columnValues,tableName);
		}
		public DataSet GetTableData(string tableName, DataSet dataSetToFill, string[] columnNames, object[] columnValues, string dataSetTableName)
		{
			DataSet dataSetToUse = dataSetToFill;
			if (dataSetToUse == null) dataSetToUse = new DataSet();
			DbDataAdapter adapter = GetAdapterForSelect(tableName, columnNames, columnValues);
			adapter.Fill(dataSetToUse, dataSetTableName);

			return dataSetToUse;
		}

        public DbDataReader GetDataReader(string tableName, string[] columnNames, object[] columnValues)
        {
            return GetDataReader(tableName, columnNames, columnValues);
        }

        public DbDataReader GetDataReader(string tableName)
        {
            DbCommand selectCommand = GetCommandForSelect(tableName, null, null, null);
            selectCommand.Connection.Open();
            return selectCommand.ExecuteReader(CommandBehavior.CloseConnection);
        }

		public OleDbConnection GetNewConnection()
		{
			return new OleDbConnection(m_ConectionString);
		}

		public void UpdateTableData(DataSet paramDataSet, string[] tableNames)
		{
			OleDbConnection connection = GetNewConnection();
			OleDbTransaction transaction = null; 
			try
			{
				connection.Open();
				transaction = connection.BeginTransaction();
				foreach(string tableName in tableNames)
				{
					DbDataAdapter adapter = GetAdapterForSelect(tableName, null, null, connection);
					adapter.SelectCommand.Transaction = transaction;
					using (DbCommandBuilder commandBuilder = new OleDbCommandBuilder((OleDbDataAdapter)adapter))
					{
						commandBuilder.QuotePrefix = "[";
						commandBuilder.QuoteSuffix = "]";
						adapter.Update(paramDataSet, tableName);
					}
				}
				transaction.Commit();				
			}
			catch
			{
				transaction.Rollback();
				throw;
			}
			finally
			{
				connection.Close();
				connection.Dispose();
			}
		}

        public void UpdateTableData(DataSet paramDataSet, string tableName, string tableSql)
        {
            DbDataAdapter adapter = GetAdapterForSelect("sql:" + tableSql, null, null);
            using (DbCommandBuilder commandBuilder = new OleDbCommandBuilder((OleDbDataAdapter)adapter))
            {
                adapter.Update(paramDataSet, tableName);
            }
        }

		public void UpdateTableData(DataSet paramDataSet, string tableName)
		{
			DbDataAdapter adapter = GetAdapterForSelect(tableName, null, null);
			using (DbCommandBuilder commandBuilder = new OleDbCommandBuilder((OleDbDataAdapter)adapter))
			{
				adapter.Update(paramDataSet, tableName);
			}
		}

        public int ExecuteSql(string sql, bool useTransaction)
        {
            int affectedRowCount = 0;
            using (OleDbConnection connection = GetNewConnection())
            {
                using (OleDbCommand command = connection.CreateCommand())
                {
                    connection.Open();
                    OleDbTransaction transaction = null;
                    try
                    {
                        if (useTransaction)
                            transaction = connection.BeginTransaction();

                        command.CommandText = sql;
                        command.CommandType = CommandType.Text;

                        affectedRowCount = command.ExecuteNonQuery();


                        if (transaction != null)
                            transaction.Commit();
                    }
                    catch
                    {
                        if (transaction != null)
                            transaction.Rollback();
                        throw;
                    }
                    finally
                    {
                        if (transaction != null)
                            transaction.Dispose();

                        connection.Close();
                    }
                }

                return affectedRowCount;
            }
        }

		public DbDataAdapter GetAdapterForSelect(string tableName, string[] columnNames, object[] columnValues)
		{
			return GetAdapterForSelect(tableName, columnNames, columnValues, null);
		}

        private DbCommand GetCommandForSelect(string tableName, string[] columnNames, object[] columnValues, DbConnection connection)
        {
            OleDbCommand selectCommand = new OleDbCommand();
            string selectCommandText;
            bool isCustomSql;
            if (tableName.StartsWith("sql:"))
            {
                selectCommandText = tableName.Substring(4);
                isCustomSql = true;
            }
            else
            {
                isCustomSql = false;
                selectCommandText = "SELECT * FROM " + tableName;

                if (columnNames != null)
                {
                    //build WHERE clause
                    string whereClause = "";
                    for (int parameterIndex = 0; parameterIndex < columnNames.Length; parameterIndex++)
                    {
                        if (whereClause != "") whereClause += " AND ";
                        whereClause += "(" + columnNames[parameterIndex] + "=" + "@" + columnNames[parameterIndex] + ")";
                    }
                    if (whereClause != "") selectCommandText += " WHERE " + whereClause;
                }
                else { }; //do not add WHERE clause
            }

            if (columnNames != null)
            {
                //Build parameters
                for (int parameterIndex = 0; parameterIndex < columnNames.Length; parameterIndex++)
                {
                    OleDbParameter newParam = selectCommand.Parameters.AddWithValue("@" + columnNames[parameterIndex], null);
                    if (!isCustomSql)
                    {
                        newParam.SourceColumn = columnNames[parameterIndex];
                    }
                    newParam.Value = columnValues[parameterIndex];
                }

            }
            selectCommand.CommandText = selectCommandText;
            if (connection == null)
                selectCommand.Connection = GetNewConnection();
            else
                selectCommand.Connection = (OleDbConnection) connection;

            return selectCommand;
        }

		private DbDataAdapter GetAdapterForSelect(string tableName, string[] columnNames, object[] columnValues, DbConnection connection)
		{
            DbCommand selectCommand = GetCommandForSelect(tableName, columnNames, columnValues, connection);
			return new OleDbDataAdapter((OleDbCommand) selectCommand);
		}
	}
}
