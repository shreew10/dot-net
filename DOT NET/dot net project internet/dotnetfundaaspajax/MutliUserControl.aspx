<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="MutliUserControl.aspx.cs" Inherits="MultiUserControl" Title="Update Panel inside Mutliple user controls" %>
<%@ Register Src="UserControl1.ascx" TagName="UserControl1" TagPrefix="uc1" %>
<%@ Register Src="UserControl2.ascx" TagName="UserControl2" TagPrefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:UserControl1 ID="UserControl11" runat="server" UpdateMode="Conditional" OnSelectedIndexChanged="UserControl11_ChangeTheContents" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <p>&nbsp;</p>
    <uc2:UserControl2 ID="UserControl22" runat="server" UpdateMode="Conditional" />
</asp:Content>

