<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebMessageBox.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 33px">
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" placeholder="Enter your name..." runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Click Me!" OnClick="Button1_Click" Height="36px" />
        </div>
    </form>
</body>
</html>
