<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="timerExam.aspx.cs" Inherits="ajaxExample.timerExam" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div>
            <asp:Timer ID="Timer1" runat="server" OnTick="Timer1_Tick1" Interval="1000"></asp:Timer>

            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <Triggers> 
                    <asp:AsyncPostBackTrigger ControlID="Timer1"/>
                </Triggers>
                <ContentTemplate> 
                    <asp:Label ID="lbl_dt_time" runat="server" Text=""></asp:Label>
                </ContentTemplate> 
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>
