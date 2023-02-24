<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="WebContact.aspx.cs" Inherits="MasterPageAndContentPage.WebContact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%-- css--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>THIS IS CONTACT PAGE</h1>


    <table>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label></td>
            <td>:</td>
            <td>
                <asp:TextBox ID="tb_name" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Gender"></asp:Label></td>
            <td>:</td>
            <td>
                <asp:RadioButton ID="rb_gender_male" Text="Male" runat="server" />
                <asp:RadioButton ID="rb_gender_Female" Text="Female" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="City"></asp:Label></td>
            <td>:</td>
            <td>
                <asp:DropDownList ID="ddl_city" runat="server">
                    <asp:ListItem Value="1">Mumbai</asp:ListItem>
                    <asp:ListItem Value="2">Pune</asp:ListItem>
                    <asp:ListItem Value="3">Jalna</asp:ListItem>
                    <asp:ListItem Value="4">Sambhajinagar</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Cars"></asp:Label></td>
            <td>:</td>
            <td>
                <asp:CheckBoxList ID="cbl_cars" runat="server">
                    <asp:ListItem Value="1">Ferrari</asp:ListItem>
                    <asp:ListItem Value="2">Porsche</asp:ListItem>
                    <asp:ListItem Value="3">Bentley</asp:ListItem>
                    <asp:ListItem Value="4">Audi</asp:ListItem>
                </asp:CheckBoxList></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="State"></asp:Label></td>
            <td>:</td>
            <td>
                <asp:ListBox ID="lb_state" runat="server">
                    <asp:ListItem Value="1">U.P</asp:ListItem>
                    <asp:ListItem Value="2">M.P</asp:ListItem>
                    <asp:ListItem Value="3">Bihar</asp:ListItem>
                    <asp:ListItem Value="4">Maharashtra</asp:ListItem>
                </asp:ListBox></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Status"></asp:Label></td>
            <td>:</td>
            <td>
                <asp:RadioButtonList ID="rbl_status" runat="server">
                    <asp:ListItem Value="1">Active</asp:ListItem>
                    <asp:ListItem Value="2">Not Active</asp:ListItem>
                    <asp:ListItem Value="3">Not Intrested</asp:ListItem>
                </asp:RadioButtonList></td>
        </tr>

        <tr>
            <td>
                <asp:Label ID="Label7" runat="server" Text="Accept"></asp:Label></td>
            <td>:</td>
            <td>
                <asp:CheckBox ID="cb_accept" runat="server" /></td>
            <td>
                <asp:Label ID="Label8" runat="server" Text="Terms and Conditions"></asp:Label></td>
        </tr>

        <tr>
            <td>
                <asp:Button ID="btn_save" OnClick="btn_save_Click" runat="server" Text="Save" /></td>
            <td></td>
            <td>
                <asp:Button ID="btn_Clear" OnClick="btn_Clear_Click" runat="server" Text="Clear" /></td>
        </tr>





    </table>




    <br />

    <br />

    <br />

    <br />

    <br />

    <br />

    <br />

    <br />

    <br />

    <br />

    <br />



    <br />




</asp:Content>
