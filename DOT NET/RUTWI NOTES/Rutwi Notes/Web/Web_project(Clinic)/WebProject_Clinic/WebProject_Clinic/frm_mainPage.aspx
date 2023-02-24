<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frm_mainPage.aspx.cs" Inherits="WebProject_Clinic.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style=" margin-top: 50px; font-size: xx-large; font-family: Candara;background-color:lightsteelblue" >
            <div style="margin-left:550px">
                Global Health Hospitals
            </div>
            <%--Global Health Hospitals--%>
            <%--<asp:Label ID="Label1" runat="server" Text="Global Health Hospitals" ></asp:Label>--%>
        </div>
        <div style="margin-left: 70px; margin-top: 70px">
            <asp:Button ID="btn_login" runat="server" Text="LogIn" Font-Bold="true" Height="50px" Width="100px" Font-Size="Larger" BackColor="#ccccff" />
            <asp:Button ID="btn_appointment" runat="server" Text="Book Appointment" Font-Bold="true" Height="50px" Width="200px" Font-Size="Larger" BackColor="#ccccff" />
        </div>
    </form>
</body>
</html>
