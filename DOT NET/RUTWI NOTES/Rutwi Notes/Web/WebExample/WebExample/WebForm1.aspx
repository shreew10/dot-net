<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebExample.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Name:"></asp:Label>
            <asp:TextBox ID="txt_name" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Gender:"></asp:Label>
            <asp:RadioButton ID="rdb_gender_f" runat="server" GroupName="gender"/>Female
            <asp:RadioButton ID="rdb_gender_m" runat="server"  GroupName="gender" />Male
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="City:"></asp:Label>
            <asp:DropDownList ID="ddl_city" runat="server">
                <asp:ListItem>Mumbai </asp:ListItem>
                <asp:ListItem>Pune </asp:ListItem>
                <asp:ListItem>Sangli </asp:ListItem>
                <asp:ListItem>Satara </asp:ListItem>
                <asp:ListItem>Kolhapur </asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="State:"></asp:Label>
            <asp:ListBox ID="lb_state" runat="server">
                <asp:ListItem>Maharshtra </asp:ListItem>
                <asp:ListItem>Goa </asp:ListItem>
                <asp:ListItem>Karnataka </asp:ListItem>
                <asp:ListItem>Kerala </asp:ListItem>
            </asp:ListBox>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Subjects:"></asp:Label>
            <asp:CheckBoxList ID="clb_subjects" runat="server">
                <asp:ListItem>C </asp:ListItem>
                <asp:ListItem>C++ </asp:ListItem>
                <asp:ListItem>Python </asp:ListItem>
                <asp:ListItem>Java </asp:ListItem>
                <asp:ListItem>Dot Net</asp:ListItem>
            </asp:CheckBoxList>
            <br />
            <br />
            <asp:Label ID="Label7" runat="server" Text="Status:"></asp:Label>
            <asp:RadioButtonList ID="rdb_status" runat="server">
                <asp:ListItem>Active </asp:ListItem>
                 <asp:ListItem>In Process </asp:ListItem>
                 <asp:ListItem>Close </asp:ListItem>
                 <asp:ListItem>Not Interested </asp:ListItem>
            </asp:RadioButtonList>
            <asp:Button ID="btn_save" runat="server" Text="Save" OnClick="btn_save_Click" />
            <asp:Button ID="btn_clear" runat="server" Text="Clear" OnClick="btn_clear_Click" />
        </div>
        <br />
        <br />

        <div>
            <asp:Label ID="lbl_name" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="lbl_gender" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="lbl_city" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="lbl_state" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="lbl_subjects" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="lbl_status" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
