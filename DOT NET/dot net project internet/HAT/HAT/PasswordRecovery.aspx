<%@ Page Language="C#" Theme="default" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="PasswordRecovery.aspx.cs" Inherits="PasswordRecovery" Title="DotNetFunda: HAT > Password Recovery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="lblError" runat="Server" SkinID="skError"></asp:Label>
    <asp:PasswordRecovery ID="PasswordRecovery1" runat="server" BackColor="#F7F7DE" BorderColor="#CCCC99"
        BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="10pt" 
        >
        <TitleTextStyle BackColor="#6B696B" Font-Bold="True" ForeColor="#FFFFFF" />
    </asp:PasswordRecovery>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FooterPlaceHolder1" Runat="Server">
</asp:Content>

