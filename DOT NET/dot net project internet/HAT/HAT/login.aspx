<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="login.aspx.cs" Inherits="login" Title="DotNetFunda: HAT > Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div style="text-align: center">
        <asp:Label ID="lblMessage" runat="server" SkinID="skError"></asp:Label>
        <asp:Login ID="Login1" runat="server" BackColor="#F7F7DE" BorderColor="#CCCC99" BorderStyle="Solid"
            BorderWidth="1px" Font-Names="Verdana" Font-Size="10pt" OnAuthenticate="Login1_Authenticate"
             InstructionText = "Please login" OnLoginError="Login1_LoginError"
              PasswordRecoveryText="Forget Password?" PasswordRecoveryUrl="~/passwordrecovery.aspx"
                >
            <TitleTextStyle BackColor="#6B696B" Font-Bold="True" ForeColor="#FFFFFF" />
        </asp:Login>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FooterPlaceHolder1" runat="Server">
</asp:Content>
