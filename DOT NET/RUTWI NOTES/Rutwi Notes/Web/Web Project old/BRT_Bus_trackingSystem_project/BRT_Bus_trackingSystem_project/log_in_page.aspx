
<%@ Page Title="" Language="C#" MasterPageFile="~/mst_main.Master" AutoEventWireup="true" CodeBehind="log_in_page.aspx.cs" Inherits="BRT_Bus_trackingSystem_project.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="margin-left:150px; margin-top:30px">LogIn</h1>
    <div style="margin-left:100px; margin-top:50px" >
        <asp:Table runat="server" Width="300px"  >
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="Label1" runat="server" Text="Log In ID"></asp:Label>
                <asp:Label ID="Label3" runat="server" Text=":"></asp:Label>
                <asp:TextBox ID="txt_login_id" runat="server"></asp:TextBox>  
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                <asp:Label ID="Label4" runat="server" Text=":"></asp:Label>
                <asp:TextBox ID="txt_password" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
            <asp:TableRow >
                <asp:TableCell>
                    <asp:Button ID="btn_save" runat="server" Text="Save"/>
                    <asp:Button ID="btn_clear" runat="server" Text="Clear"  />
                </asp:TableCell>
            </asp:TableRow>
    </asp:Table>

    </div>
    





</asp:Content>
