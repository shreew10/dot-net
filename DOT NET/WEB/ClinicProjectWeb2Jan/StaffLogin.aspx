<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffLogin.aspx.cs" Inherits="ClinicProjectWeb2Jan.StaffLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Css/Simple.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div style="text-align: center">
            <%--<h1 style="margin-left: 350px">Shree Multispeciality Hospital</h1>--%>
            <h1>Shree Multispeciality Hospital</h1>
            <address>
                Malabar Hills Near Mahalaxmi Race Course South Mumbai -411236. Mob.No.-9874563214.
            </address>
            <marquee width="31%" direction="left" height="100px" hspace="10%">
                Always in your service....
            </marquee>
        </div>

        <div style="margin-left: 350px">
            <table>
                <tr>
                    <td>
                        <span class="cls_Mandatory"></span>
                        <asp:Label ID="Label2" runat="server" Text="ID"></asp:Label>
                    </td>
                    <td>
                        <%--<asp:Label ID="Label3" runat="server" Text="*"></asp:Label>--%>
                        <asp:TextBox ID="tb_id" placeholder="Enter Your ID" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Mandatory" ControlToValidate="tb_id" Display="Dynamic" ForeColor="Red" ValidationGroup="error"></asp:RequiredFieldValidator>
                    </td>

                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="*"></asp:Label>
                        <span class="cls_Mandatory"></span>
                        <asp:Label ID="Label4" runat="server" Text="Password"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="tb_password" placeholder="Enter Password" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Mandatory" ControlToValidate="tb_password" Display="Dynamic" ForeColor="Red" ValidationGroup="error"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btn_login" CssClass="button" runat="server" Text="Login" ValidationGroup="error" OnClick="btn_login_Click" />
                        <asp:Button ID="btn_clear" CssClass="button" runat="server" Text="Clear" ValidationGroup="error" OnClick="btn_clear_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
