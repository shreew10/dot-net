<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="SessionStateAndApplicationState.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server" Text=""></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server" Text=""></asp:TextBox>
            <asp:TextBox ID="TextBox3" runat="server" Text=""></asp:TextBox>
            <asp:TextBox ID="TextBox4" runat="server" Text=""></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="NextPage" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
