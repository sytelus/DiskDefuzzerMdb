using System.Diagnostics;
using System;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Data;
using System.Collections.Generic;
using System.Text;


namespace Astrila.Common
{
	public class RtfUtility
	{
		
		private static RichTextBox m_UtilityRichTextBox;
		public static void InitializeResources ()
		{
			m_UtilityRichTextBox = new RichTextBox();
		}
		public static void DesposeResources ()
		{
			m_UtilityRichTextBox = null;
		}
		public static void SetRtf (string rtf)
		{
			m_UtilityRichTextBox.Rtf = rtf;
		}
		public static void Replace (string oldTextPart, string newTextPart)
		{
			int foundPos = m_UtilityRichTextBox.Find(oldTextPart, RichTextBoxFinds.NoHighlight);
			if (foundPos >= 0)
			{
				m_UtilityRichTextBox.SelectionStart = foundPos;
				m_UtilityRichTextBox.SelectionLength = oldTextPart.Length;
				m_UtilityRichTextBox.SelectedText = newTextPart;
			}
		}
		public static string GetRtf()
		{
			return m_UtilityRichTextBox.Rtf;
		}
		
	}
	
}
