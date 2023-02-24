<%@ Page Title="" Language="C#" MasterPageFile="~/mstExample.Master" AutoEventWireup="true" CodeBehind="frm_student_details.aspx.cs" Inherits="MasterPageExample.frm_student_details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="text-emphasis-color:chocolate">Student Details </h1>
    <table style="border:thick">
        <tr style="border:thick">
            <td>Name:</td>
            <td><asp:TextBox ID="txt_name" runat="server"></asp:TextBox> </td>
        </tr>
        <tr style="border:thick">
            <td>Gender:</td>
            <td><asp:RadioButtonList ID="rdb_gender" runat="server">
                <asp:ListItem>Female </asp:ListItem>
                <asp:ListItem>Male </asp:ListItem>
                </asp:RadioButtonList> </td>
        </tr>
        <tr style="border:thick">
            <td>City:</td>
            <td>><asp:DropDownList ID="ddl_city" runat="server">
                <asp:ListItem>Mumbai </asp:ListItem>
                <asp:ListItem>Pune </asp:ListItem>
                <asp:ListItem>Sangli </asp:ListItem>
                <asp:ListItem>Satara </asp:ListItem>
                <asp:ListItem>Kolhapur </asp:ListItem>
                 </asp:DropDownList> </td>
        </tr>
        <tr style="border:thick">
            <td>State: </td>
            <td><asp:ListBox ID="lb_state" runat="server">
                <asp:ListItem>Maharashtra </asp:ListItem>
                <asp:ListItem>Goa </asp:ListItem>
                <asp:ListItem>Karnataka </asp:ListItem>
                </asp:ListBox> </td>
        </tr>
        <tr style="border:thick">
            <td>Subjects: </td>
            <td><asp:CheckBoxList ID="cbl_subjects" runat="server">
                <asp:ListItem>C </asp:ListItem>
                <asp:ListItem>C++ </asp:ListItem>
                <asp:ListItem>Java </asp:ListItem>
                <asp:ListItem>Python </asp:ListItem>
                </asp:CheckBoxList> </td>
        </tr>
        <tr style="border:thick">
            <td>Terms and Conditions: </td>
            <td><asp:CheckBox ID="cb_tnc" runat="server"  Text="Accept"/> </td>
            
        </tr>
        <tr style="border:thick">
            <td>Status: </td>
            <td><asp:RadioButtonList ID="rdb_status" runat="server">
                <asp:ListItem>Interested </asp:ListItem>
                <asp:ListItem>Not Interested </asp:ListItem>
                </asp:RadioButtonList> </td>
        </tr>

    </table>
</asp:Content>
