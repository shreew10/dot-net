<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="validationExam.aspx.cs" Inherits="ValidationExample.validationExam" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Name:
            <asp:TextBox ID="txt_name" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" 
                runat="server" 
                ErrorMessage="Name is Mandatory"
                ControlToValidate="txt_name"
                Display="dynamic"
                ValidationGroup="error"
                ForeColor="Red">
            </asp:RequiredFieldValidator>
            <br />
            <br />

            Age:
            <asp:TextBox ID="txt_age" runat="server"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator1" 
                runat="server" 
                ErrorMessage="Invalid Age"
                ControlToValidate="txt_age"
                Display="Dynamic"
                ValidationGroup="error"
                ForeColor="Red"
                Type="Integer"
                MinimumValue="18"
                MaximumValue="100">
            </asp:RangeValidator>
            <br />
            <br />

            Password:
            <asp:TextBox ID="txt_pass" runat="server"></asp:TextBox>
            <br />
            Confirm Password:
            <asp:TextBox ID="txt_conf_pass" runat="server"></asp:TextBox>

            <asp:CompareValidator ID="CompareValidator1"
                runat="server" 
                ErrorMessage="Incorrect Password. Try Again"
                Display="Dynamic"
                ValidationGroup="error"
                ForeColor="Red"
                ControlToValidate="txt_pass"
                ControlToCompare="txt_conf_pass">
            </asp:CompareValidator>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="OK" ValidationGroup="error"/>
        </div>
    </form>
</body>
</html>
