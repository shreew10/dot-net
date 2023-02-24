<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="frmStaff.aspx.cs" Inherits="ClinicProjectWeb2Jan.PresentationLayer.frmStaff" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Css/Simple.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager" runat="server"></asp:ScriptManager>
    <div>


        <asp:TabContainer ID="tc_1" runat="server" ActiveTabIndex="0" OnActiveTabChanged="TabContainer1_ActiveTabChanged" AutoPostBack="true">
            <asp:TabPanel runat="server" ID="panel1" TabIndex="0">
                <HeaderTemplate>List</HeaderTemplate>
                <ContentTemplate>
                    <asp:Label ID="Label1" runat="server" Text="Staff Details"></asp:Label>
                    <asp:GridView ID="gv_staff" runat="server" ShowHeaderWhenEmpty="true" AutoGenerateColumns="false">
                        <Columns>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Button ID="btn_edit" runat="server" Text="Edit" OnClick="btn_edit_Click" CssClass="button" CommandArgument='<%#Bind("staff_id")%>' />
                                    <asp:Button ID="btn_delete" runat="server" Text="Delete" OnClick="btn_delete_Click" CssClass="button" CommandArgument='<%#Bind("staff_id")%>' />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Name">
                                <ItemTemplate>
                                    <asp:Label ID="lbl_name" runat="server" Text='<%#Eval("staff_name")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Contact">
                                <ItemTemplate>
                                    <asp:Label ID="lbl_Contact" runat="server" Text='<%#Eval("staff_contact")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Aadhar No">
                                <ItemTemplate>
                                    <asp:Label ID="lbl_Aadhar" runat="server" Text='<%#Eval("staff_aadhar")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Staff Type">
                                <ItemTemplate>
                                    <asp:Label ID="lbl_Staff" runat="server" Text='<%#Eval("staff_work_type")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <EmptyDataTemplate>
                            NO RECORDS FOUND!!!
                        </EmptyDataTemplate>
                    </asp:GridView>
                </ContentTemplate>
            </asp:TabPanel>
            <asp:TabPanel runat="server" ID="panel2" TabIndex="1">
                <HeaderTemplate>Add</HeaderTemplate>
                <ContentTemplate>
                    <table>
                        <tr>
                            <%-- <td>
                            <asp:Label ID="Label2" runat="server" Text="Id"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label3" runat="server" Text=":"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="tb_id" runat="server" Text="" Width="162px"></asp:TextBox>
                        </td>--%>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label4" runat="server" Text="Name"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label5" runat="server" Text=":"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="tb_name" runat="server" Text="" Width="162px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage=" Name Mandatory" ControlToValidate="tb_name" Display="Dynamic" ForeColor="Red" ValidationGroup="error"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label6" runat="server" Text="Address"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label7" runat="server" Text=":"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="tb_address" runat="server" TextMode="MultiLine" Rows="3" MaxLength="500" Style="width: 164px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label8" runat="server" Text="Area"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label9" runat="server" Text=":"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="tb_staffArea" runat="server" Width="162px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label10" runat="server" Text="City"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label11" runat="server" Text=":"></asp:Label>
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
                                <asp:CompareValidator ID="Shree" runat="server" ErrorMessage=" Please Select City" ControlToValidate="ddl_city" ValueToCompare="City" ValidationGroup="error" ForeColor="Tomato" Display="Dynamic" Operator="NotEqual">

                                </asp:CompareValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label12" runat="server" Text="Pincode"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label13" runat="server" Text=":"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="tb_pin" runat="server" Text="" Width="162px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label14" runat="server" Text="Contact"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label15" runat="server" Text=":"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="tb_stfContact" runat="server" Text="" Width="162px"></asp:TextBox>
                                <asp:RequiredFieldValidator
                                    ID="RequiredFieldValidator4"
                                    runat="server"
                                    ErrorMessage="Enter Contact Number"
                                    Display="Dynamic"
                                    ValidationGroup="error"
                                    ForeColor="Red"
                                    ControlToValidate="tb_stfContact">
                                </asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator
                                    ID="RegularExpressionValidator1"
                                    runat="server"
                                    ErrorMessage="Enter Correct Contact Number"
                                    ValidationExpression="^[0-9]{10}"
                                    ControlToValidate="tb_stfContact"
                                    Display="Dynamic"
                                    ValidationGroup="error"
                                    ForeColor="Red">
                                </asp:RegularExpressionValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label16" runat="server" Text="Gender"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label17" runat="server" Text=":"></asp:Label>
                            </td>
                            <td>
                                <asp:RadioButtonList ID="rbl_gender" runat="server">
                                    <asp:ListItem Value="Male">Male</asp:ListItem>
                                    <asp:ListItem Value="Female">Female</asp:ListItem>
                                    <asp:ListItem Value="Other">Other</asp:ListItem>
                                </asp:RadioButtonList>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label18" runat="server" Text="Aadhar No"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label19" runat="server" Text=":"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="tb_stfAdhar" runat="server" Text="" Width="162px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage=" Aadhar No Mandatory" ControlToValidate="tb_stfAdhar" Display="Dynamic" ForeColor="Red" ValidationGroup="error"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator
                                    ID="RegularExpressionValidator2"
                                    runat="server"
                                    ErrorMessage="Enter Correct Aadhar Number"
                                    ValidationExpression="^[0-9]{12}"
                                    ControlToValidate="tb_stfAdhar"
                                    Display="Dynamic"
                                    ValidationGroup="error"
                                    ForeColor="Red">
                                </asp:RegularExpressionValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label20" runat="server" Text="Email Id"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label21" runat="server" Text=":"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="tb_emailId" runat="server" Text="" Width="162px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label22" runat="server" Text="D.O.B"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label23" runat="server" Text=":"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="tb_stfdob" runat="server" Width="162px"></asp:TextBox>
                                <asp:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="tb_stfdob" Format="dd/MM/yyyy"></asp:CalendarExtender>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage=" Date Mandatory" ControlToValidate="tb_stfdob" Display="Dynamic" ForeColor="Red" ValidationGroup="error"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label24" runat="server" Text="D.O.J"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label25" runat="server" Text=":"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="tb_staffdoj" runat="server" Width="162px"></asp:TextBox>
                                <asp:CalendarExtender ID="CalendarExtender2" runat="server" TargetControlID="tb_staffdoj" Format="dd/MM/yyyy"></asp:CalendarExtender>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage=" Date Mandatory" ControlToValidate="tb_staffdoj" Display="Dynamic" ForeColor="Red" ValidationGroup="error"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label26" runat="server" Text="Qualification"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label27" runat="server" Text=":"></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="ddl_qualification" runat="server" Width="170px">
                                    <asp:ListItem Selected="True" Value="Qualification">Select Qualification</asp:ListItem>
                                    <asp:ListItem Value="MBBS">MBBS</asp:ListItem>
                                    <asp:ListItem Value="BDS">BDS</asp:ListItem>
                                    <asp:ListItem Value="BAMS">BAMS</asp:ListItem>
                                    <asp:ListItem Value="BHMS">BHMS</asp:ListItem>
                                    <asp:ListItem Value="B-PHARM">B-PHARM</asp:ListItem>
                                    <asp:ListItem Value="D-PHARM">D-PHARM</asp:ListItem>
                                    <asp:ListItem Value="M-PHARM">M-PHARM</asp:ListItem>
                                </asp:DropDownList>
                                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage=" Please Select Qualification" ControlToValidate="ddl_qualification" ValueToCompare="Qualification" ValidationGroup="error" ForeColor="Tomato" Display="Dynamic" Operator="NotEqual">

                                </asp:CompareValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label28" runat="server" Text="Experience"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label29" runat="server" Text=":"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="tb_experience" runat="server" Text="" Width="162px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label30" runat="server" Text="Work Type"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label31" runat="server" Text=":"></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="ddl_stfWrk" runat="server" Width="170px">
                                    <asp:ListItem Value="Work">Select Work Type</asp:ListItem>
                                    <asp:ListItem Value="Doctor">Doctor</asp:ListItem>
                                    <asp:ListItem Value="Nurse">Nurse</asp:ListItem>
                                    <asp:ListItem Value="Wardboy">Wardboy</asp:ListItem>
                                    <asp:ListItem Value="Receptionist">Receptionist</asp:ListItem>
                                    <asp:ListItem Value="Intern">Intern</asp:ListItem>
                                    <asp:ListItem Value="Cleaner">Cleaner</asp:ListItem>
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Mandatory" ControlToValidate="ddl_stfWrk" Display="Dynamic" ForeColor="Red" ValidationGroup="error"></asp:RequiredFieldValidator>
                                <asp:CompareValidator ID="CompareValidator2" runat="server" ErrorMessage=" Please Select Work Type" ControlToValidate="ddl_stfWrk" ValueToCompare="Work" ValidationGroup="error" ForeColor="Red" Display="Dynamic" Operator="NotEqual">

                                </asp:CompareValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label32" runat="server" Text="Password"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label33" runat="server" Text=":"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="tb_stfPass" runat="server" Text="" Width="162px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage=" Password Mandatory" ControlToValidate="tb_stfPass" Display="Dynamic" ForeColor="Red" ValidationGroup="error"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td></td>
                            <td></td>
                            <td>
                                <asp:Button ID="btn_save" runat="server" Text="Save" CssClass="button" ValidationGroup="error" OnClick="btn_save_Click" />
                                <asp:Button ID="btn_clear" runat="server" Text="Clear" CssClass="button" OnClick="btn_clear_Click" />

                                <asp:Button ID="btn_save_test" runat="server" Text="Save" OnClick="btn_save_test_Click" />

                                <asp:Button ID="btn_delete_test" runat="server" Text="delete" OnClick="btn_delete_test_Click" />
                            </td>
                            <td></td>
                        </tr>
                    </table>
                </ContentTemplate>
            </asp:TabPanel>
        </asp:TabContainer>

        <asp:ModalPopupExtender ID="mpe_comman" runat="server" TargetControlID="btn_ok" PopupControlID="pnl_comman" Enabled="false"></asp:ModalPopupExtender>
        <asp:Panel ID="pnl_comman" runat="server" Visible="false" BackColor="LightBlue" Height="90px" Width="250px">
            <asp:Label ID="lbl_message" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="btn_ok" runat="server" Text="Ok" OnClick="btn_ok_Click" />
        </asp:Panel>

        <asp:ModalPopupExtender ID="mpe_conf" runat="server" CancelControlID="btn_no" TargetControlID="btn_yes" PopupControlID="pnl_conf" Enabled="false"></asp:ModalPopupExtender>
        <asp:Panel ID="pnl_conf" runat="server" Visible="false" BackColor="LightBlue" Height="90px" Width="350px">
            <asp:Label ID="lbl" runat="server" Text="Are you sure do you want to delete this record"></asp:Label>
            <br />
            <asp:Button ID="btn_yes" runat="server" Text="Yes" OnClick="btn_yes_Click" />
            <asp:Button ID="btn_no" runat="server" Text="No" OnClick="btn_no_Click" />
        </asp:Panel>
    </div>
</asp:Content>
