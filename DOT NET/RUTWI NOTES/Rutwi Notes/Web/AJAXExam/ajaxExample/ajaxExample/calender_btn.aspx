<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="calender_btn.aspx.cs" Inherits="ajaxExample.calender_btn" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div>
            <asp:TextBox ID="txt_dt" runat="server"></asp:TextBox>
            <asp:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="txt_dt" PopupButtonID="Button1" Format="dd/MM//yyyy"></asp:CalendarExtender>
            <asp:Button ID="Button1" runat="server" Text="Calender" />

        </div>
    </form>
</body>
</html>
