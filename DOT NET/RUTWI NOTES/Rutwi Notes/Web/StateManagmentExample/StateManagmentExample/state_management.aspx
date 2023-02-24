<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="state_management.aspx.cs" Inherits="StateManagmentExample.state_management" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txt_id" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="txt_name" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btn_display" runat="server" Text="Display" OnClick="btn_display_Click" />
            <asp:Button ID="btn_next" runat="server" Text="Next" OnClick="btn_next_Click" />
        </div>
        <div id="div_info" runat="server" visible="false">
            <asp:Label ID="lbl_id" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="lbl_name" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
