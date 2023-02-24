<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="web_service_exam.aspx.cs" Inherits="Web_service_exam.web_service_exam" %>

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
            <asp:Label ID="Label1" runat="server" Text="Name:"></asp:Label>
            <asp:TextBox ID="txt_name" runat="server"></asp:TextBox>

            <div id="div_name_list"></div>
            <asp:AutoCompleteExtender
                runat="server"
                ID="AutoCompleteExtender"
                TargetControlID="txt_name"
                ServicePath="~/SmartWebService.asmx"
                ServiceMethod="webUserName"
                MinimumPrefixLength="1"
                CompletionListElementID="div_name_list">

            </asp:AutoCompleteExtender>
        </div>
    </form>
</body>
</html>
