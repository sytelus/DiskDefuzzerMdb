using System.Diagnostics;
using System;
using System.IO;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Data;
using System.Collections.Generic;

namespace Astrila.Common
{
	public class DiagnosticsSupport
	{
		
		private bool m_HasErrorOccured = false;
		private bool m_HasNonFatalErrorOccured = false;
		private bool m_IsLogStarted = false;
		public TextWriterTraceListener textListener = new TextWriterTraceListener(new StringWriter());
		public string CurrentTopLevelOperation;
		
		public void BeginLogging (string topLevelOperation, bool participateInExistingLog)
		{
			bool startNewLog = false;
			CurrentTopLevelOperation = topLevelOperation;
			if (m_IsLogStarted == true)
			{
				if (participateInExistingLog == true)
				{
					startNewLog = false;
				}
				else
				{
					startNewLog = true;
				}
			}
			else
			{
				startNewLog = true;
			}
			if (startNewLog == true)
			{
				m_HasErrorOccured = false;
				m_HasNonFatalErrorOccured = false;
				Clear();
				if (Trace.Listeners.Contains(textListener) == false)
				{
					Trace.Listeners.Add(textListener);
				}
			}
		}
		public void LogMessage (string message)
		{
			Trace.WriteLine(message);
		}
		public void LogException (Exception ex)
		{
			Trace.WriteLine(GetExceptionDetailsInString(ex));
		}
		public void LogException (string operation, Exception ex)
		{
			LogException(operation, ex, false);
		}
		public void LogException (string operation, Exception ex, bool nonFatalError)
		{
			m_HasErrorOccured = m_HasErrorOccured ||(! nonFatalError);
			m_HasNonFatalErrorOccured = m_HasNonFatalErrorOccured || nonFatalError;
			Trace.WriteLine("Exception occured during operation " + operation + "\r\n" + GetExceptionDetailsInString(ex));
		}
		public void EndLogging (bool isShowMessageIfExceptionOccured, bool clearLogs)
		{
			try
			{
				if (isShowMessageIfExceptionOccured == true)
				{
					ShowMessageIfExceptionOccured();
				}
			}
			finally
			{
				m_IsLogStarted = false;
				
				if (clearLogs == true)
				{
					Clear();
				}
			}
		}
		
		public void ShowMessageIfExceptionOccured ()
		{
			bool showExceptionDialog = false;
			showExceptionDialog = m_HasErrorOccured;
			if (showExceptionDialog == false)
			{
				if (m_HasNonFatalErrorOccured == true)
				{
                    showExceptionDialog = (MessageBox.Show(CurrentTopLevelOperation + " was completed with few non-criticle errors. Would you like to report it?", "Non Criticle Errors", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes);
				}
			}
			if (showExceptionDialog == true)
			{
				DisplayError("There were errors occured while performing operation " + CurrentTopLevelOperation, GetLogContent());
			}
		}
		public static void DisplayError (Exception ex)
		{
			DisplayError("Unexpected error has occured: " + ex.Message, GetExceptionDetailsInString(ex));
		}
		public static void DisplayError (string errorShortMessage, string errorDetails)
		{
			ErrorDisplay exceptionDialog = null;
			try
			{
				exceptionDialog = new ErrorDisplay();
				exceptionDialog.ShowException(errorShortMessage, errorDetails);
			}
			finally
			{
				exceptionDialog.Dispose();
			}
		}
		public string GetLogContent()
		{
			return ((System.IO.StringWriter) textListener.Writer).GetStringBuilder().ToString();
		}
		
		public void Clear ()
		{
			((System.IO.StringWriter) textListener.Writer).GetStringBuilder().Length = 0;
		}
		
		public bool HasErrorOccured
		{
			get{
				return m_HasErrorOccured;
			}
		}
		
		public bool HasNonFatalErrorOccured
		{
			get{
				return m_HasNonFatalErrorOccured;
			}
		}
		
		public static string GetExceptionDetailsInString(Exception exceptionToCheck)
		{
			string exceptionDetail = "";
			if (!(exceptionToCheck == null))
			{
				exceptionDetail += (exceptionToCheck.Message + "[at " + exceptionToCheck.Source + " of type " + exceptionToCheck.GetType().ToString() + "]");
				exceptionDetail += ("\r\n" + exceptionToCheck.StackTrace);
				
				if (exceptionToCheck.InnerException == null)
				{
					//No more further inner exceptions
				}
				else
				{
					exceptionDetail += ("\r\n" + "\r\n" + "Inner Exception:" + "\r\n" + GetExceptionDetailsInString(exceptionToCheck.InnerException));
				}
			}
			else
			{
				exceptionDetail = string.Empty;
			}
			return exceptionDetail;
		}
		
		public static void HandleUnexpectedValues (string paramName, string paramValue)
		{
			throw (new NotImplementedException("This selection is not supported yet. Please choose other values or contact customer support." + "\r\n" + "Parameter: " + paramName + "\r\n" + "Value: " + paramValue));
		}
	}
	
}
