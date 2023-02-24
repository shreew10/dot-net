<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ClinicProjectWeb2Jan.WebForm1" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <div>
            <asp:Button ID="btn_save" runat="server" Text="Save" OnClick="btn_save_Click" />
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:ModalPopupExtender ID="mpe" runat="server" CancelControlID="btn_cancel" TargetControlID="btn_next" PopupControlID="pnl_info" Enabled="false" DropShadow="true"></asp:ModalPopupExtender>
            <asp:Panel ID="pnl_info" runat="server" Visible="false">
                <asp:Label ID="Label1" runat="server" Text="Data Save successfully....."></asp:Label>
                <asp:Button ID="btn_next" runat="server" Text="Next" OnClick="btn_next_Click" />
                <asp:Button ID="btn_cancel" runat="server" Text="Cancel" />
            </asp:Panel>
        </div>
    </form>
</body>
</html>
