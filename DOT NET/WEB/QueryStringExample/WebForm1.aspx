﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="QueryStringExample.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="tb_name" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Last Name"></asp:Label>
            <asp:TextBox ID="tb_lstname" runat="server"></asp:TextBox>
            <asp:Button ID="Btn_submit" runat="server" Text="Submit" OnClick="Btn_submit_Click" />
        </div>
    </form>
</body>
</html>
