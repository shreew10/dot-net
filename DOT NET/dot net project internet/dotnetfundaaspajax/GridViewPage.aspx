<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="GridViewPage.aspx.cs" Inherits="GridViewPage" Title="GridView Demo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <asp:UpdatePanel runat="Server" ID="UpdatePanel1" UpdateMode="Conditional">
        <contenttemplate>
                <asp:GridView ID="GridView1" runat="Server" AllowPaging="True" AllowSorting="True"
                DataSourceID="AccessDataSource1" PageSize="4">
    </asp:GridView>
        
        </contenttemplate>
    </asp:UpdatePanel>
    <asp:AccessDataSource ID="AccessDataSource1" runat="Server" DataFile="E:\Nothing\Dream\Learning\Ajax\App_Data\AjaxTutorials.mdb"
        DataSourceMode="DataSet" SelectCommand="Select * from SimpleData"></asp:AccessDataSource>
</asp:Content>
