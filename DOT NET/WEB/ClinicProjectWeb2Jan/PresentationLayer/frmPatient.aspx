<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="frmPatient.aspx.cs" Inherits="ClinicProjectWeb2Jan.PresentationLayer.frmPatient" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Css/Simple.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div>
        <asp:TabContainer ID="tc_patient" runat="server" ActiveTabIndex="0" OnActiveTabChanged="tc_patient_ActiveTabChanged" AutoPostBack="true">
            <asp:TabPanel runat="server" ID="panel1" TabIndex="0">
                <HeaderTemplate>List</HeaderTemplate>
                <ContentTemplate>
                    <asp:Label ID="Label19" runat="server" Text="Patient Details"></asp:Label>
                    <asp:GridView ID="grv_patientList" runat="server" ShowHeaderWhenEmpty="true" AutoGenerateColumns="false">
                        <Columns>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Button ID="btn_edit" runat="server" Text="Edit" OnClick="btn_edit_Click" CssClass="button" CommandArgument='<%#Bind("patient_id")%>' />
                                    <asp:Button ID="btn_patient_delete" runat="server" Text="Delete" OnClick="btn_patient_delete_Click" CssClass="button" CommandArgument='<%#Bind("patient_id")%>' />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Name">
                                <ItemTemplate>
                                    <asp:Label ID="lbl_name" runat="server" Text='<%#Eval("patient_name")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Contact">
                                <ItemTemplate>
                                    <asp:Label ID="lbl_Contact" runat="server" Text='<%#Eval("patient_contact")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Registration Date">
                                <ItemTemplate>
                                    <asp:Label ID="lbl_Date" runat="server" Text='<%#Eval("reg_dt")%>'></asp:Label>
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
                            <td>
                                <asp:Label ID="Label4" runat="server" Text="Name"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label5" runat="server" Text=":"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="tb_pntName" runat="server" Text="" Width="162px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage=" Name Mandatory" ControlToValidate="tb_pntName" Display="Dynamic" ForeColor="Red" ValidationGroup="error"></asp:RequiredFieldValidator>
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
                                <asp:TextBox ID="tb_pntAddress" runat="server" TextMode="MultiLine" Rows="3" MaxLength="500" Style="width: 164px"></asp:TextBox>
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
                                <asp:TextBox ID="tb_pntArea" runat="server" Width="162px"></asp:TextBox>
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
                                <asp:DropDownList ID="Ddl_pntCity" runat="server" Width="170px">
                                    <asp:ListItem Value="City">SELECT CITY</asp:ListItem>
                                    <asp:ListItem Value="Mumbai">Mumbai</asp:ListItem>
                                    <asp:ListItem Value="Delhi">Delhi</asp:ListItem>
                                    <asp:ListItem Value="Jalna">Jalna</asp:ListItem>
                                    <asp:ListItem Value="Sambhajinagar">Sambhajinagar</asp:ListItem>
                                    <asp:ListItem Value="Nagpur">Nagpur</asp:ListItem>
                                    <asp:ListItem Value="Pune">Pune</asp:ListItem>
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage=" Name Mandatory" ControlToValidate="Ddl_pntCity" Display="Dynamic" ForeColor="Red" ValidationGroup="error"></asp:RequiredFieldValidator>
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
                                <asp:TextBox ID="tb_pntPin" runat="server" Text="" Width="162px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="cls_vt">
                                <asp:Label ID="Label16" runat="server" Text="Gender" CssClass="cls_Gender_margin"></asp:Label>
                            </td>
                            <td class="cls_vt">
                                <asp:Label ID="Label17" runat="server" Text=":" CssClass="cls_Gender_margin"></asp:Label>
                            </td>
                            <td>
                                <asp:RadioButtonList ID="rbl_pntGender" runat="server">
                                    <asp:ListItem Value="Male">Male</asp:ListItem>
                                    <asp:ListItem Value="Female">Female</asp:ListItem>
                                    <asp:ListItem Value="Other">Other</asp:ListItem>
                                </asp:RadioButtonList>
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
                                <asp:TextBox ID="tb_pntdob" runat="server" Width="162px"></asp:TextBox>
                                <asp:Button ID="Button2" runat="server" Text=" " CssClass="button" />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage=" D.O.B Mandatory" ControlToValidate="tb_pntdob" Display="Dynamic" ForeColor="Red" ValidationGroup="error"></asp:RequiredFieldValidator>
                                <asp:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="tb_pntdob" Format="dd/MM/yyyy" PopupButtonID="Button2"></asp:CalendarExtender>
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
                                <asp:TextBox ID="tb_pntContact" runat="server" Text="" Width="162px"></asp:TextBox>
                                <asp:RequiredFieldValidator
                                    ID="RequiredFieldValidator4"
                                    runat="server"
                                    ErrorMessage="Enter Contact Number"
                                    Display="Dynamic"
                                    ValidationGroup="error"
                                    ForeColor="Red"
                                    ControlToValidate="tb_pntContact">
                                </asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator
                                    ID="RegularExpressionValidator1"
                                    runat="server"
                                    ErrorMessage="Enter Correct Contact Number"
                                    ValidationExpression="^[0-9]{10}"
                                    ControlToValidate="tb_pntContact"
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
                                <asp:TextBox ID="tb_pntEmail" runat="server" Text="" Width="162px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label1" runat="server" Text="Reference"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label18" runat="server" Text=":"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="tb_pntRef" runat="server" Text="" Width="162px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label24" runat="server" Text="Blood Group"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label25" runat="server" Text=":"></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="ddl_pntBldGrp" runat="server" Width="170px">
                                    <asp:ListItem Value="GROUP">SELECT BLOOD GROUP</asp:ListItem>
                                    <asp:ListItem Value="O+">O+</asp:ListItem>
                                    <asp:ListItem Value="AB-">AB-</asp:ListItem>
                                    <asp:ListItem Value="O-">O-</asp:ListItem>
                                    <asp:ListItem Value="AB+">AB+</asp:ListItem>
                                    <asp:ListItem Value="A-">A-</asp:ListItem>
                                    <asp:ListItem Value="B-">B-</asp:ListItem>
                                    <asp:ListItem Value="A+">A+</asp:ListItem>
                                    <asp:ListItem Value="B+">B+</asp:ListItem>
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage=" Blood Group Mandatory" ControlToValidate="ddl_pntBldGrp" Display="Dynamic" ForeColor="Red" ValidationGroup="error"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label26" runat="server" Text="Registration Date"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label27" runat="server" Text=":"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="tb_pntRgstDt" runat="server" Width="162px"></asp:TextBox>
                                <asp:CalendarExtender ID="CalendarExtender2" runat="server" TargetControlID="tb_pntRgstDt" Format="dd/MM/yyyy"></asp:CalendarExtender>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage=" Date Mandatory" ControlToValidate="tb_pntRgstDt" Display="Dynamic" ForeColor="Red" ValidationGroup="error"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td></td>
                            <td></td>
                            <td>
                                <asp:Button ID="btn_save" runat="server" Text="Save" CssClass="button" OnClick="btn_save_Click" />
                                <asp:Button ID="btn_clear" runat="server" Text="Clear" CssClass="button" OnClick="btn_clear_Click" />
                                <%--<asp:Button ID="btn_delete" runat="server" Text="Delete" CssClass="button" OnClick="btn_delete_Click" />--%>
                            </td>
                            <td></td>
                        </tr>
                    </table>
                </ContentTemplate>
            </asp:TabPanel>
        </asp:TabContainer>

        <asp:ModalPopupExtender ID="mpe_confi" runat="server" CancelControlID="btn_cancel" TargetControlID="btn_Yes" PopupControlID="pnl_confi" Enabled="false" DropShadow="true"></asp:ModalPopupExtender>
        <asp:Panel ID="pnl_confi" runat="server" Visible="false" BackColor="#ffffcc">
            <asp:Label ID="Label28" runat="server" Text="Do you want to delete this record?"></asp:Label>
            <asp:Button ID="btn_Yes" runat="server" Text="Yes" OnClick="btn_Yes_Click" />
            <asp:Button ID="btn_cancel" runat="server" Text="Cancel" OnClick="btn_cancel_Click" />
        </asp:Panel>

        <asp:ModalPopupExtender ID="mpe" runat="server" TargetControlID="btn_ok" PopupControlID="pnl_info" Enabled="false" DropShadow="true"></asp:ModalPopupExtender>
        <asp:Panel ID="pnl_message" runat="server" Visible="false" BackColor="#ffffcc">
            <asp:Label ID="lbl_msg" runat="server" Text=""></asp:Label>
            <asp:Button ID="btn_ok" runat="server" Text="Ok" OnClick="btn_ok_Click" />
        </asp:Panel>
    </div>
    <div>
        <asp:TabContainer ID="tc_patient_additional_data" runat="server" Visible="false" AutoPostBack="true">
            <asp:TabPanel runat="server">
                <HeaderTemplate>Allergy </HeaderTemplate>
                <ContentTemplate>

                    <asp:GridView ID="gv_allergy" runat="server" ShowFooter="true" ShowHeaderWhenEmpty="true" AutoGenerateColumns="false">
                        <Columns>
                            <asp:TemplateField HeaderText="Action">
                                <ItemTemplate>
                                    <asp:Button ID="btn_AllergyEdit" runat="server" Text="Edit" OnClick="btn_AllergyEdit_Click" CommandArgument='<%#Bind("allergy_id")%>' />
                                    <asp:Button ID="btn_Allergydelete" runat="server" Text="Delete" OnClick="btn_Allergydelete_Click" CommandArgument='<%#Bind("allergy_id")%>' />
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:Button ID="btn_Allergyupdate" runat="server" Text="Update" OnClick="btn_Allergyupdate_Click" CommandArgument='<%#Bind("allergy_id")%>' />
                                    <asp:Button ID="btn_Allergycancel" runat="server" Text="Cancel" OnClick="btn_Allergycancel_Click" CommandArgument='<%#Bind("allergy_id")%>' />
                                </EditItemTemplate>
                                <FooterTemplate>
                                    <asp:Button ID="btn_Allergyadd" runat="server" Text="Add" OnClick="btn_Allergyadd_Click" />
                                </FooterTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="ID" Visible="false">
                                <ItemTemplate>
                                    <asp:Label ID="lbl_it_allergy_id" runat="server" Text='<%#Eval("allergy_id")%>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox ID="tb_et_allergy_id" runat="server" Text='<%#Eval("allergy_id")%>' Visible="false"></asp:TextBox>
                                </EditItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox ID="tb_ft_allergy_id" runat="server" Visible="false"></asp:TextBox>
                                </FooterTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="Patient ID" Visible="false">
                                <ItemTemplate>
                                    <asp:Label ID="lbl_it_allergy_patient_id" runat="server" Text='<%#Eval("patient_id")%>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox ID="tb_et_allergy_patient_id" runat="server" Text='<%#Eval("patient_id")%>' Visible="false"></asp:TextBox>
                                </EditItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox ID="tb_ft_allergy_patient_id" runat="server" Visible="false" Text='<%#Eval("patient_id")%>'></asp:TextBox>
                                </FooterTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="Allergy">
                                <ItemTemplate>
                                    <asp:Label ID="lbl_it_allergy" runat="server" Text='<%#Eval("allergy")%>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox ID="tb_et_allergy" runat="server" Text='<%#Eval("allergy")%>'></asp:TextBox>
                                </EditItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox ID="tb_ft_allergy" runat="server"></asp:TextBox>
                                </FooterTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="Allergy Start Date">
                                <ItemTemplate>
                                    <asp:Label ID="lbl_it_allergy_start_date" runat="server" Text='<%#Eval("allergy_start_dt")%>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox ID="tb_et_allergy_start_date" runat="server" Text='<%#Eval("allergy_start_dt")%>'></asp:TextBox>
                                    <asp:CalendarExtender ID="CalendarExtender3" runat="server" TargetControlID="tb_et_allergy_start_date" Format="dd-MM-yyyy"></asp:CalendarExtender>
                                </EditItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox ID="tb_ft_allergy_start_date" runat="server"></asp:TextBox>
                                    <asp:CalendarExtender ID="CalendarExtender5" runat="server" TargetControlID="tb_ft_allergy_start_date" Format="dd-MM-yyyy"></asp:CalendarExtender>
                                </FooterTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </ContentTemplate>
            </asp:TabPanel>

            <asp:TabPanel runat="server">
                <HeaderTemplate>Cronic Diseases </HeaderTemplate>
                <ContentTemplate>

                    <asp:GridView ID="gv_cronicDis" runat="server" AutoGenerateColumns="false" ShowFooter="true" ShowHeaderWhenEmpty="true">
                        <Columns>
                            <asp:TemplateField HeaderText="Action">
                                <ItemTemplate>
                                    <asp:Button ID="btn_CronicEdit" runat="server" Text="Edit" OnClick="btn_CronicEdit_Click" CommandArgument='<%#Bind("cronic_disease_id")%>' />
                                    <asp:Button ID="btn_CronicDelete" runat="server" Text="Delete" OnClick="btn_CronicDelete_Click" CommandArgument='<%#Bind("cronic_disease_id")%>' />
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:Button ID="btn_Cronicupdate" runat="server" Text="Update" OnClick="btn_Cronicupdate_Click" CommandArgument='<%#Bind("cronic_disease_id")%>' />
                                    <asp:Button ID="btn_Croniccancel" runat="server" Text="Cancel" OnClick="btn_Croniccancel_Click" CommandArgument='<%#Bind("cronic_disease_id")%>' />
                                </EditItemTemplate>
                                <FooterTemplate>
                                    <asp:Button ID="btn_Cronicadd" runat="server" Text="Add" OnClick="btn_Cronicadd_Click" />
                                </FooterTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="ID" Visible="false">
                                <ItemTemplate>
                                    <asp:Label ID="lbl_it_Cronic_id" runat="server" Text='<%#Eval("cronic_disease_id")%>' Visible="false"></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox ID="tb_et_Cronic_id" runat="server" Text='<%#Eval("cronic_disease_id")%>' Visible="false"></asp:TextBox>
                                </EditItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox ID="tb_ft_Cronic_id" runat="server" Visible="false"></asp:TextBox>
                                </FooterTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="Patient ID" Visible="false">
                                <ItemTemplate>
                                    <asp:Label ID="lbl_it_Cronic_patient_id" runat="server" Text='<%#Eval("patient_id")%>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox ID="tb_et_Cronic_patient_id" runat="server" Text='<%#Eval("patient_id")%>' Visible="false"></asp:TextBox>
                                </EditItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox ID="tb_ft_Cronic_patient_id" runat="server" Visible="false"></asp:TextBox>
                                </FooterTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="Disease">
                                <ItemTemplate>
                                    <asp:Label ID="lbl_it_CronicD" runat="server" Text='<%#Eval("cronic_disease")%>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox ID="tb_et_CronicD" runat="server" Text='<%#Eval("cronic_disease")%>'></asp:TextBox>
                                </EditItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox ID="tb_ft_CronicD" runat="server"></asp:TextBox>
                                </FooterTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="Disease Start Date">
                                <ItemTemplate>
                                    <asp:Label ID="lbl_it_CronicD_start_date" runat="server" Text='<%#Eval("cronic_disease_start_dt")%>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox ID="tb_et_CronicD_start_date" runat="server" Text='<%#Eval("cronic_disease_start_dt")%>'></asp:TextBox>
                                    <asp:CalendarExtender ID="CalendarExtender3" runat="server" TargetControlID="tb_et_CronicD_start_date" Format="dd-MM-yyyy"></asp:CalendarExtender>
                                </EditItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox ID="tb_ft_CronicD_start_date" runat="server"></asp:TextBox>
                                    <asp:CalendarExtender ID="CalendarExtender5" runat="server" TargetControlID="tb_ft_CronicD_start_date" Format="dd-MM-yyyy"></asp:CalendarExtender>
                                </FooterTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </ContentTemplate>
            </asp:TabPanel>

            <asp:TabPanel runat="server">
                <HeaderTemplate>History </HeaderTemplate>
                <ContentTemplate>


                    <asp:GridView ID="gv_history" runat="server" AutoGenerateColumns="false" ShowFooter="true" ShowHeaderWhenEmpty="true">
                        <Columns>
                            <asp:TemplateField HeaderText="Action">
                                <ItemTemplate>
                                    <asp:Button ID="btn_HistoryEdit" runat="server" Text="Edit" OnClick="btn_HistoryEdit_Click" CommandArgument='<%#Bind("patient_med_id")%>' />
                                    <asp:Button ID="btn_HistoryDelete" runat="server" Text="Delete" OnClick="btn_HistoryDelete_Click" CommandArgument='<%#Bind("patient_med_id")%>' />
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:Button ID="btn_Historyupdate" runat="server" Text="Update" OnClick="btn_Historyupdate_Click" CommandArgument='<%#Bind("patient_med_id")%>' />
                                    <asp:Button ID="btn_Historycancel" runat="server" Text="Cancel" OnClick="btn_Historycancel_Click" CommandArgument='<%#Bind("patient_med_id")%>' />
                                </EditItemTemplate>
                                <FooterTemplate>
                                    <asp:Button ID="btn_Historyadd" runat="server" Text="Add" OnClick="btn_Historyadd_Click" />
                                </FooterTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="ID" Visible="false">
                                <ItemTemplate>
                                    <asp:Label ID="lbl_it_History_id" runat="server" Text='<%#Eval("patient_med_id")%>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox ID="tb_et_History_id" runat="server" Text='<%#Eval("patient_med_id")%>' Visible="false"></asp:TextBox>
                                </EditItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox ID="tb_ft_History_id" runat="server" Visible="false"></asp:TextBox>
                                </FooterTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="Patient ID" Visible="false">
                                <ItemTemplate>
                                    <asp:Label ID="lbl_it_History_patient_id" runat="server" Text='<%#Eval("patient_id")%>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox ID="tb_et_History_patient_id" runat="server" Text='<%#Eval("patient_id")%>' Visible="false"></asp:TextBox>
                                </EditItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox ID="tb_ft_History_patient_id" runat="server" Visible="false"></asp:TextBox>
                                </FooterTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="Medicine">
                                <ItemTemplate>
                                    <asp:Label ID="lbl_it_Medicine" runat="server" Text='<%#Eval("medicine")%>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox ID="tb_et_Medicine" runat="server" Text='<%#Eval("medicine")%>'></asp:TextBox>
                                </EditItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox ID="tb_ft_Medicine" runat="server"></asp:TextBox>
                                </FooterTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="Frequency">
                                <ItemTemplate>
                                    <asp:Label ID="lbl_it_Frequency" runat="server" Text='<%#Eval("frequency")%>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox ID="tb_et_Frequency" runat="server" Text='<%#Eval("frequency")%>'></asp:TextBox>
                                </EditItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox ID="tb_ft_Frequency" runat="server"></asp:TextBox>
                                </FooterTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </ContentTemplate>
            </asp:TabPanel>
        </asp:TabContainer>
    </div>
</asp:Content>
