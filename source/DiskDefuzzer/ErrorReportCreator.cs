using System.Diagnostics;
using System;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Data;
using System.Collections.Generic;
using System.Reflection;
using System.IO;


namespace Astrila.Common
{
	public class ErrorReportCreator
	{
		
		public static void CreateErrorReport (string errorShortMessage, string errorDetails)
		{
			try
			{
				RtfUtility.InitializeResources();
				
				//Read template in to richtext box
				StreamReader errorReportTemplateStream = new StreamReader(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "ErrorReportTemplate.rtf"));
				string errorReportTemplate = errorReportTemplateStream.ReadToEnd();
				errorReportTemplateStream.Close();
				
				RtfUtility.SetRtf(errorReportTemplate);
				
				RtfUtility.Replace("[DateTime.Now]", DateTime.UtcNow.ToString("r"));
				
				RtfUtility.Replace("[SystemInfo]", GetSystemInfo());
				
				RtfUtility.Replace("[ExceptionShortInfo]", errorShortMessage);
				
				RtfUtility.Replace("[ExceptionLongInfo]", errorDetails);
				
				RtfUtility.Replace("[SupportEmail]", "shitals@microsoft.com");
				
				string errorReportFilePath = Path.Combine(Application.UserAppDataPath, Path.GetTempFileName() + ".rtf");
				SaveStringToFile(RtfUtility.GetRtf(), errorReportFilePath);
				
				Process.Start(errorReportFilePath);
			}
			catch (System.Exception ex)
			{
				MessageBox.Show("Error occured while generating report:  - " + ex.Message);
			}
			finally
			{
				RtfUtility.DesposeResources();
			}
		}
		
		private static void SaveStringToFile (string content, string filePath)
		{
			StreamWriter contentStream = File.CreateText(filePath);
			contentStream.Write(content);
			contentStream.Close();
		}
		
		public static string GetSystemInfo()
		{
			string systemInfo = "";
			systemInfo += "Current Directory:" + Environment.CurrentDirectory;
			systemInfo += "\r\n" + "OS Version:" + Environment.OSVersion.ToString();
			systemInfo += "\r\n" + "System Directory:" + Environment.SystemDirectory;
			systemInfo += "\r\n" + "CLR:" + Environment.Version.ToString();
			systemInfo += "\r\n" + "WorkingSet:" + Environment.WorkingSet.ToString();
			systemInfo += "\r\n" + "App Company:" + Application.CompanyName;
			systemInfo += "\r\n" + "App Culture:" + Application.CurrentCulture.ToString();
			systemInfo += "\r\n" + "App Input Language:" + Application.CurrentInputLanguage.Culture.ToString();
			systemInfo += "\r\n" + "App Exe:" + Application.ExecutablePath;
			systemInfo += "\r\n" + "App User Data Path:" + Application.LocalUserAppDataPath;
			systemInfo += "\r\n" + "App Product Name:" + Application.ProductName;
			systemInfo += "\r\n" + "App Product Version:" + Application.ProductVersion;
			systemInfo += "\r\n" + "App Top Level Caption:" + Application.SafeTopLevelCaptionFormat;
			systemInfo += "\r\n" + "App Startup Path:" + Application.StartupPath;
			systemInfo += "\r\n" + "Calling Assembly:" + @Assembly.GetCallingAssembly().FullName;
			systemInfo += "\r\n" + "Calling Assembly Version:" + @Assembly.GetCallingAssembly().GetName().Version.ToString();
			return systemInfo;
		}
		
	}
	
}
