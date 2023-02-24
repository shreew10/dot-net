<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="frmClinic.aspx.cs" Inherits="ClinicProjectWeb2Jan.PresentationLayer.frmClinic" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Css/Simple.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    <table style="column-span: all">
        <tr>
            <td>
                <%-- <span class="cls_Mandatory">*</span>--%>
                <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>

            </td>
            <td>
                <asp:Label ID="Label3" runat="server" Text=":"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tb_name" runat="server" Width="162px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Mandatory" ControlToValidate="tb_name" Display="Dynamic" ForeColor="Red" ValidationGroup="error"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Address"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label6" runat="server" Text=":"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tb_address" runat="server" TextMode="MultiLine" Rows="3" MaxLength="500" Style="width: 164px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Area"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label7" runat="server" Text=":"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tb_area" runat="server" Width="162px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label8" runat="server" Text="City"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label9" runat="server" Text=":"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddl_city" runat="server" Width="170px">
                    <asp:ListItem Value="City">Select City</asp:ListItem>
                    <asp:ListItem Value="Mumbai">Mumbai</asp:ListItem>
                    <asp:ListItem Value="Delhi">Delhi</asp:ListItem>
                    <asp:ListItem Value="Jalna">Jalna</asp:ListItem>
                    <asp:ListItem Value="Sambhajinagar">Sambhajinagar</asp:ListItem>
                    <asp:ListItem Value="Nagpur">Nagpur</asp:ListItem>
                    <asp:ListItem Value="Pune">Pune</asp:ListItem>
                </asp:DropDownList>
                <asp:CompareValidator ID="Shree" runat="server" ErrorMessage=" Please Select City" ControlToValidate="ddl_city" ValueToCompare="City" ValidationGroup="error" ForeColor="Tomato" Display="Dynamic" Operator="NotEqual"> </asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label10" runat="server" Text="Pin"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label11" runat="server" Text=":"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tb_pin" runat="server" Width="162px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <%--   <span class="cls_Mandatory">*</span>--%>
                <asp:Label ID="Label12" runat="server" Text="Contact"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label13" runat="server" Text=":"></asp:Label>
            </td>
            <td>

                <asp:TextBox ID="tb_contact" runat="server" Width="162px"></asp:TextBox>
                <asp:RequiredFieldValidator
                    ID="RequiredFieldValidator2"
                    runat="server"
                    ErrorMessage="Enter Contact Number"
                    Display="Dynamic"
                    ValidationGroup="error"
                    ForeColor="Red"
                    ControlToValidate="tb_contact">
                </asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator
                    ID="RegularExpressionValidator1"
                    runat="server"
                    ErrorMessage="Enter Correct Contact Number"
                    ValidationExpression="^[0-9]{10}"
                    ControlToValidate="tb_contact"
                    Display="Dynamic"
                    ValidationGroup="error"
                    ForeColor="Red">
                </asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label14" runat="server" Text="Website"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label15" runat="server" Text=":"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tb_website" runat="server" Width="162px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label16" runat="server" Text="Email"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label17" runat="server" Text=":"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tb_email" runat="server" Width="162px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label18" runat="server" Text="Timmings"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label19" runat="server" Text=":"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tb_time1" placeholder="Enter Time in HH:MM:SS " runat="server" Width="162px"></asp:TextBox>
                <%--<asp:Label ID="Label22" runat="server" Text="AM"></asp:Label>--%>
                <asp:DropDownList ID="ddl_am_pm_1" runat="server">
                    <asp:ListItem Value="AM">AM</asp:ListItem>
                    <asp:ListItem Value="PM">PM</asp:ListItem>
                </asp:DropDownList>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label20" runat="server" Text="Timmings"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label21" runat="server" Text=":"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tb_time2" placeholder="Enter Time in HH:MM:SS " runat="server" Width="162px"></asp:TextBox>
                <asp:Timer ID="Timer1" runat="server"></asp:Timer>
                <%--<asp:Label ID="Label23" runat="server" Text="PM"></asp:Label>--%>
                <asp:DropDownList ID="ddl_am_pm_2" runat="server">
                    <asp:ListItem Value="AM">AM</asp:ListItem>
                    <asp:ListItem Value="PM">PM</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td>
                <asp:Button ID="btn_update" runat="server" Text="Update" CssClass="button" ValidationGroup="error" OnClick="btn_update_Click" />
                <asp:Button ID="btn_clear" runat="server" Text="Clear" CssClass="button" OnClick="btn_clear_Click" />
            </td>
            <td></td>
        </tr>
    </table>
</asp:Content>
