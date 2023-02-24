<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplicationDay1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SHREE APPLICATION</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label" runat="server" Text="Name"></asp:Label>
            <br />
            <asp:TextBox ID="txt_name" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label1" runat="server" Text="City"></asp:Label>
            <br />
            <asp:DropDownList ID="ddl_city" runat="server">
                <asp:ListItem Value="1">Mumbai</asp:ListItem>
                <asp:ListItem Value="2">Pune</asp:ListItem>
                <asp:ListItem Value="3">Jalna</asp:ListItem>
                <asp:ListItem Value="4">Satara</asp:ListItem>
            </asp:DropDownList>
            <br />

            <%--<asp:TextBox ID="tb_2" runat="server" TextMode="MultiLine" Width="10px" Height="20px"></asp:TextBox>--%>
            <%--<br />--%>
            <asp:Label ID="Label2" runat="server" Text="State"></asp:Label>
            <br />
            <asp:ListBox ID="lb_state" runat="server">
                <asp:ListItem Value="1">Maharashtra</asp:ListItem>
                <asp:ListItem Value="2">Kerala</asp:ListItem>
                <asp:ListItem Value="3">Bihar</asp:ListItem>
                <asp:ListItem Value="4">Uttar Pradesh</asp:ListItem>
            </asp:ListBox>
            <br />

            <br />
            <asp:Label ID="Label4" runat="server" Text="Cars"></asp:Label>
            <br />
            <asp:CheckBoxList ID="cbl_cars" runat="server">
                <asp:ListItem Value="1">Mercedes</asp:ListItem>
                <asp:ListItem Value="2">BMW</asp:ListItem>
                <asp:ListItem Value="3">Audi</asp:ListItem>
                <asp:ListItem Value="4">Ferrari</asp:ListItem>
                <asp:ListItem Value="5">LandRover</asp:ListItem>
            </asp:CheckBoxList>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Status"></asp:Label>
            <br />
            <asp:CheckBox ID="cb_status" runat="server" Text="Active" />
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="Gender"></asp:Label>
            <br />
            <asp:RadioButton ID="rb_gender_male" runat="server" Text="Male" GroupName="gender" />
            <asp:RadioButton ID="rb_gender_female" runat="server" Text="Female" GroupName="gender" />
            <br />
            <%-- <asp:Label ID="lbl_1" runat="server" Text="Hello Shree"></asp:Label>--%>
            <%-- <asp:Panel ID="Panel1" runat="server" Style="margin-top: 17px"></asp:Panel>--%>
            <asp:Label ID="Label7" runat="server" Text="Specialization"></asp:Label>
            <br />
            <asp:RadioButtonList ID="rbl_select" runat="server">
                <asp:ListItem Value="1">Driver</asp:ListItem>
                <asp:ListItem Value="2">Mechanic</asp:ListItem>
                <asp:ListItem Value="3">Painter</asp:ListItem>
            </asp:RadioButtonList>

            <asp:Label ID="Label3" runat="server" Text="Select"></asp:Label>
            <br />
            <asp:Button ID="btn_yes" runat="server" Text="Yes" OnClick="btn_yes_Click" />
            <br />
            <asp:Button ID="btn_no" runat="server" Text="No" OnClick="btn_no_Click" />
        </div>
        <div>
            <asp:Label ID="lbl_name" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="lbl_city" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="lbl_cars" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="lbl_state" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="lbl_status" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="lbl_gender" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="lbl_specialization" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
