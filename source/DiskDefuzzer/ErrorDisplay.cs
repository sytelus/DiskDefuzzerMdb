using System.Diagnostics;
using System;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Data;
using System.Collections.Generic;

namespace Astrila.Common
{
	public class ErrorDisplay : System.Windows.Forms.Form
	{
		
		private bool m_bIsDetailShown;
		private string m_ErrorShortMessage;
		private string m_ErrorDetails;
		
		#region " Windows Form Designer generated code "
		
		public ErrorDisplay() {
			
			//This call is required by the Windows Form Designer.
			InitializeComponent();
			
			//Add any initialization after the InitializeComponent() call
			
		}
		
		//Form overrides dispose to clean up the component list.
		protected override void Dispose (bool disposing)
		{
			if (disposing)
			{
				if (!(components == null))
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		//Required by the Windows Form Designer
		private System.ComponentModel.Container components = null;
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.PictureBox PictureBox1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.TextBox txtErrorMessage;
		internal System.Windows.Forms.GroupBox GroupBox2;
		internal System.Windows.Forms.Button cmdDetails;
		internal System.Windows.Forms.Button cmdCancel;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.TextBox txtErrorTrace;
		internal System.Windows.Forms.LinkLabel LinkLabel1;
		internal System.Windows.Forms.ToolTip ToolTip1;
		internal System.Windows.Forms.PictureBox PictureBox2;
		internal System.Windows.Forms.GroupBox GroupBox3;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent ()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ErrorDisplay));
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.PictureBox1 = new System.Windows.Forms.PictureBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.txtErrorMessage = new System.Windows.Forms.TextBox();
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this.cmdDetails = new System.Windows.Forms.Button();
			this.cmdDetails.Click += new System.EventHandler(cmdDetails_Click);
			this.cmdCancel = new System.Windows.Forms.Button();
			this.cmdCancel.Click += new System.EventHandler(cmdCancel_Click);
			this.Label5 = new System.Windows.Forms.Label();
			this.txtErrorTrace = new System.Windows.Forms.TextBox();
			this.LinkLabel1 = new System.Windows.Forms.LinkLabel();
			this.LinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(LinkLabel1_LinkClicked_1);
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.PictureBox2 = new System.Windows.Forms.PictureBox();
			this.GroupBox3 = new System.Windows.Forms.GroupBox();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			//
			//GroupBox1
			//
			this.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.GroupBox1.Controls.Add(this.PictureBox1);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Location = new System.Drawing.Point(0, - 4);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(444, 65);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			//
			//PictureBox1
			//
			this.PictureBox1.Image = ((System.Drawing.Image) resources.GetObject("PictureBox1.Image"));
			this.PictureBox1.Location = new System.Drawing.Point(8, 16);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new System.Drawing.Size(40, 40);
			this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureBox1.TabIndex = 1;
			this.PictureBox1.TabStop = false;
			//
			//Label1
			//
			this.Label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Label1.Location = new System.Drawing.Point(59, 16);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(341, 40);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "We have encountered an unexpected problem. Please try again or create an error re" + "port.";
			//
			//Label2
			//
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.Label2.Location = new System.Drawing.Point(4, 68);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(201, 20);
			this.Label2.TabIndex = 1;
			this.Label2.Text = "Following error has occured :";
			//
			//txtErrorMessage
			//
			this.txtErrorMessage.BackColor = System.Drawing.SystemColors.Control;
			this.txtErrorMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtErrorMessage.Location = new System.Drawing.Point(4, 92);
			this.txtErrorMessage.Multiline = true;
			this.txtErrorMessage.Name = "txtErrorMessage";
			this.txtErrorMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtErrorMessage.Size = new System.Drawing.Size(440, 32);
			this.txtErrorMessage.TabIndex = 2;
			this.txtErrorMessage.Text = "";
			//
			//GroupBox2
			//
			this.GroupBox2.Location = new System.Drawing.Point(4, 168);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new System.Drawing.Size(468, 4);
			this.GroupBox2.TabIndex = 5;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "GroupBox2";
			//
			//cmdDetails
			//
			this.cmdDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdDetails.Location = new System.Drawing.Point(212, 67);
			this.cmdDetails.Name = "cmdDetails";
			this.cmdDetails.Size = new System.Drawing.Size(20, 20);
			this.cmdDetails.TabIndex = 6;
			this.cmdDetails.Text = "...";
			//
			//cmdCancel
			//
			this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdCancel.Location = new System.Drawing.Point(360, 138);
			this.cmdCancel.Name = "cmdCancel";
			this.cmdCancel.Size = new System.Drawing.Size(84, 24);
			this.cmdCancel.TabIndex = 8;
			this.cmdCancel.Text = "Close";
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.Location = new System.Drawing.Point(8, 180);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(73, 16);
			this.Label5.TabIndex = 11;
			this.Label5.Text = "Error Details :";
			//
			//txtErrorTrace
			//
			this.txtErrorTrace.BackColor = System.Drawing.SystemColors.Control;
			this.txtErrorTrace.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtErrorTrace.Location = new System.Drawing.Point(8, 200);
			this.txtErrorTrace.Multiline = true;
			this.txtErrorTrace.Name = "txtErrorTrace";
			this.txtErrorTrace.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtErrorTrace.Size = new System.Drawing.Size(428, 80);
			this.txtErrorTrace.TabIndex = 13;
			this.txtErrorTrace.Text = "";
			this.txtErrorTrace.WordWrap = false;
			//
			//LinkLabel1
			//
			this.LinkLabel1.AutoSize = true;
			this.LinkLabel1.Location = new System.Drawing.Point(1, 140);
			this.LinkLabel1.Name = "LinkLabel1";
			this.LinkLabel1.Size = new System.Drawing.Size(98, 16);
			this.LinkLabel1.TabIndex = 14;
			this.LinkLabel1.TabStop = true;
			this.LinkLabel1.Text = "Create error report";
			this.ToolTip1.SetToolTip(this.LinkLabel1, "Create an automatic error report in Microsoft Word along with screen shot and inf" + "ormation about how to sent it");
			//
			//PictureBox2
			//
			this.PictureBox2.Location = new System.Drawing.Point(156, 124);
			this.PictureBox2.Name = "PictureBox2";
			this.PictureBox2.TabIndex = 15;
			this.PictureBox2.TabStop = false;
			this.PictureBox2.Visible = false;
			//
			//GroupBox3
			//
			this.GroupBox3.Location = new System.Drawing.Point(- 9, 128);
			this.GroupBox3.Name = "GroupBox3";
			this.GroupBox3.Size = new System.Drawing.Size(468, 4);
			this.GroupBox3.TabIndex = 16;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "GroupBox3";
			//
			//ErrorDisplay
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(450, 282);
			this.Controls.Add(this.GroupBox3);
			this.Controls.Add(this.PictureBox2);
			this.Controls.Add(this.LinkLabel1);
			this.Controls.Add(this.txtErrorTrace);
			this.Controls.Add(this.txtErrorMessage);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.cmdCancel);
			this.Controls.Add(this.cmdDetails);
			this.Controls.Add(this.GroupBox2);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.GroupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "ErrorDisplay";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Application Error";
			this.GroupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		
		#endregion
		
		private void cmdDetails_Click (System.Object sender, System.EventArgs e)
		{
			m_bIsDetailShown = ! m_bIsDetailShown;
			UpdateFormLayoutForDetailLevel();
		}
		
		private void UpdateFormLayoutForDetailLevel ()
		{
			if (m_bIsDetailShown == false)
			{
				this.Height = 188;
				cmdDetails.Text = ">";
			}
			else
			{
				this.Height = 312;
				cmdDetails.Text = "<";
			}
		}
		
		private void cmdCancel_Click (System.Object sender, System.EventArgs e)
		{
			this.Close();
		}
		
		public void ShowException (string errorShortMessage, string errorDetails)
		{
			// set the text of txtErrorMessage with the error message
			m_ErrorShortMessage = errorShortMessage;
			m_ErrorDetails = errorDetails;
			txtErrorMessage.Text = m_ErrorShortMessage;
			txtErrorTrace.Text = m_ErrorDetails;
			m_bIsDetailShown = false;
			UpdateFormLayoutForDetailLevel();
			
			this.ShowDialog();
		}
		
		private void LinkLabel1_LinkClicked_1 (System.Object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			// create error report in word
			try
			{
				this.Visible = false;
				ErrorReportCreator.CreateErrorReport(m_ErrorShortMessage, m_ErrorDetails);
			}
			finally
			{
				this.Visible = true;
			}
		}
	}
	
}
