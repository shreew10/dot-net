<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Clinic_WebProject.WebForm1" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div>
            <asp:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0" Enabled="true">
				<asp:TabPanel runat="server" ID="List" HeaderText="List" TabIndex="0">
					<HeaderTemplate>List</HeaderTemplate>
					<ContentTemplate></ContentTemplate>
				</asp:TabPanel>
				<asp:TabPanel runat="server" ID="Add" HeaderText="Add" TabIndex="1">
					<HeaderTemplate>Add</HeaderTemplate>
					<ContentTemplate></ContentTemplate>
				</asp:TabPanel>
            </asp:TabContainer>
        </div>
    </form>
</body>
</html>


<%--<!DOCTYPE html>
<html lang="en">

<head runat="server">
	<meta charset="utf-8">

	<link href=
"https://code.jquery.com/ui/1.10.4/themes/ui-lightness/jquery-ui.css"
		rel="stylesheet">
		
	<script src=
		"https://code.jquery.com/jquery-1.10.2.js">
	</script>
	
	<script src=
		"https://code.jquery.com/ui/1.10.4/jquery-ui.js">
	</script>

	<script>
		$(function () {
			$("#gfg").tabs({
				active: false
			});
		});
    </script>
</head>

<body>
	<h1>GeeksforGeeks</h1>
	<h3>jQuery UI tabs active option</h3>

	<div id="gfg">
		<ul>
			<li><a href="#gfg1">Tab 1</a></li>
			<li><a href="#gfg2">Tab 2</a></li>
			<li><a href="#gfg3">Tab 3</a></li>
		</ul>

		<div id="gfg1">
			<p>tab Number -1</p>
		</div>

		<div id="gfg2">
			<p>tab Number -2</p>
		</div>

		<div id="gfg3">
			<p>tab Number -3</p>
		</div>
	</div>
</body>

</html>--%>




