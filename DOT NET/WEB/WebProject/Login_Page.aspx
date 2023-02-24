<%@ Page Title="" Language="C#" MasterPageFile="~/Form_Main.Master" AutoEventWireup="true" CodeBehind="Login_Page.aspx.cs" Inherits="WebProject.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>PMPL BUS ALWAYS IN YOUR SERVICE</h1>
    <asp:Table ID="Table1" runat="server">
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>:</asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txt_username" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>:</asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txt_password" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Button ID="btn_save" runat="server" Text="Save" />
                <asp:Button ID="btn_clear" runat="server" Text="Clear" OnClick="btn_clear_Click" />
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>
