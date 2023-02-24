<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebServiceExample.WebForm1" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="tb_name" runat="server"></asp:TextBox>
            <div id="div_name_list">
            </div>
            <asp:AutoCompleteExtender runat="server"
                ID="AutoCompleteExtender"
                TargetControlID="tb_name"
                ServiceMethod="WebUserName"
                ServicePath="~/ShreeWebService.asmx"
                MinimumPrefixLength="1"
                CompletionListElementID="div_name_list">
            </asp:AutoCompleteExtender>
        </div>

    </form>
</body>
</html>
