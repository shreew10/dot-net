<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TabContainer.aspx.cs" Inherits="TabContainerAjaxContoller.TabContainer" %>

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
            <asp:TabContainer ID="tabcontainer1" runat="server" ActiveTabIndex="1" AutoPostBack="true" OnActiveTabChanged="tabcontainer1_ActiveTabChanged">
                <asp:TabPanel runat="server" TabIndex="0">
                    <HeaderTemplate>List</HeaderTemplate>
                    <ContentTemplate>
                        <asp:Label ID="Label1" runat="server" Text="Employee List"></asp:Label>
                        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                    </ContentTemplate>
                </asp:TabPanel>
                <asp:TabPanel runat="server" TabIndex="1">
                    <HeaderTemplate>Add</HeaderTemplate>
                    <ContentTemplate>
                        <asp:Label ID="Label2" runat="server" Text="Employee Details"></asp:Label>
                        <asp:Label ID="Label3" runat="server" Text="Employee Name"></asp:Label>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </ContentTemplate>
                </asp:TabPanel>
            </asp:TabContainer>
        </div>
    </form>
</body>
</html>
