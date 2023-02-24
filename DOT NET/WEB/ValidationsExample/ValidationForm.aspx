<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ValidationForm.aspx.cs" Inherits="ValidationsExample.ValidationForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label></td>
                    <td>:</td>
                    <td>
                        <asp:TextBox ID="tb_name" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator
                            ID="RequiredFieldValidator1"
                            runat="server"
                            ErrorMessage="Please Enter Name"
                            Display="Dynamic"
                            ValidationGroup="error"
                            ForeColor="Red"
                            ControlToValidate="tb_name">
                        </asp:RequiredFieldValidator>
                    </td>

                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Contact No"></asp:Label>
                    </td>
                    <td>:</td>
                    <td>
                        <asp:TextBox ID="tb_contact" runat="server"></asp:TextBox>
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
                        <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
                    </td>
                    <td>:</td>
                    <td>
                        <asp:TextBox ID="tb_password" runat="server"></asp:TextBox>
                        <%-- <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Enter Correct Password"
                            ControlToValidate="tb_password"
                            ControlToCompare="tb_confrmPass"
                            ForeColor="Red"
                            ValidationGroup="error"
                            Display="Dynamic">
                        </asp:CompareValidator>--%>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text=" Confirm Password"></asp:Label>
                    </td>
                    <td>:</td>
                    <td>
                        <asp:TextBox ID="tb_confrmPass" runat="server"></asp:TextBox>
                        <asp:CompareValidator ID="CompareValidator2" runat="server" ErrorMessage="Password does not match"
                            ControlToValidate="tb_password"
                            ControlToCompare="tb_confrmPass"
                            ForeColor="Red"
                            ValidationGroup="error"
                            Display="Dynamic">
                        </asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Age"></asp:Label>
                    </td>
                    <td>:</td>
                    <td>
                        <asp:TextBox ID="tb_age" runat="server"></asp:TextBox>
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="You are less than 18 you are still baby"
                            Type="Integer"
                            ValidationGroup="error"
                            ForeColor="Red"
                            Display="Dynamic"
                            ControlToValidate="tb_age"
                            MinimumValue="18"
                            MaximumValue="75">
                        </asp:RangeValidator>
                    </td>
                </tr>
            </table>
            <asp:Button ID="btn_save" runat="server" Text="Save" ValidationGroup="error" />
            <asp:Button ID="btn_Clear" runat="server" Text="Clear" />
        </div>
    </form>
</body>
</html>
