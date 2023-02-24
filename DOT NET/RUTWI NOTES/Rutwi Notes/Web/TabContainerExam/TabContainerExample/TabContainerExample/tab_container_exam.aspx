<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tab_container_exam.aspx.cs" Inherits="TabContainerExample.tab_container_exam" %>

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
            <asp:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0" OnActiveTabChanged="TabContainer1_ActiveTabChanged" AutoPostBack="true" >
                <asp:TabPanel TabIndex="0" runat="server">
                    <HeaderTemplate>Home </HeaderTemplate>
                    <ContentTemplate>
                        <asp:Label ID="Label1" runat="server" Text="Home Page"></asp:Label>
                    </ContentTemplate>
                </asp:TabPanel>

                <asp:TabPanel TabIndex="1" runat="server">
                    <HeaderTemplate>About </HeaderTemplate>
                    <ContentTemplate>
                        <asp:Label ID="Label2" runat="server" Text="Company"></asp:Label>
                    </ContentTemplate>
                </asp:TabPanel>

                <asp:TabPanel TabIndex="2" runat="server">
                    <HeaderTemplate>StudentDetails </HeaderTemplate>
                    <ContentTemplate>
                        <asp:Label ID="Label3" runat="server" Text="Student Name:"></asp:Label>
                        <asp:TextBox ID="txt_stud_name" runat="server"></asp:TextBox>
                        <asp:Label ID="Label4" runat="server" Text="Student city:"></asp:Label>
                        <asp:TextBox ID="txt_stud_city" runat="server"></asp:TextBox>
                    </ContentTemplate>
                </asp:TabPanel>



            </asp:TabContainer>
        </div>
    </form>
</body>
</html>
