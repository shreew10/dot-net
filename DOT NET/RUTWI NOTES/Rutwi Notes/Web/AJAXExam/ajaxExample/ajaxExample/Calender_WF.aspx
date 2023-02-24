<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calender_WF.aspx.cs" Inherits="ajaxExample.Calender_WF" %>

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
            <asp:TextBox ID="txt_dt_time" runat="server"></asp:TextBox>
            <asp:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="txt_dt_time" Format="dd/MM/yyyy"></asp:CalendarExtender>
            
        </div>
    </form>
</body>
</html>
