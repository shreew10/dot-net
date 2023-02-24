<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Appointment.aspx.cs" Inherits="ClinicProjectWeb2Jan.Appointment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Multispeciality Hospital</title>
    <link href="Css/Simple.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center">
            <%--<h1 style="margin-left: 350px">Shree Multispeciality Hospital</h1>--%>
            <h1>Shree Multispeciality Hospital</h1>
            <address>
                Malabar Hills Near Mahalaxmi Race Course South Mumbai -411236. Mob.No.-9874563214.
            </address>

            <marquee width="31%" direction="left" height="20px" hspace="10%">
                Always in your service....
            </marquee>
        </div>
        <div>
            <asp:Button CssClass="button" ID="btn_staff" runat="server" Text="Staff Login" OnClick="btn_staff_Click" />
            <asp:Button CssClass="button" ID="btn_appointment" runat="server" Text="Appointment Booking" />
        </div>

    </form>
</body>
</html>
