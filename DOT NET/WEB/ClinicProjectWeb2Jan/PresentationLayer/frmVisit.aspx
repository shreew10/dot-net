<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmVisit.aspx.cs" Inherits="ClinicProjectWeb2Jan.PresentationLayer.frmVisit" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div>
            <asp:TabContainer ID="tc_visit" runat="server" ActiveTabIndex="0" AutoPostBack="true" OnActiveTabChanged="tc_visit_ActiveTabChanged">
                <asp:TabPanel runat="server" ID="panel1" TabIndex="0">
                    <HeaderTemplate>LIST</HeaderTemplate>
                    <ContentTemplate>
                        <asp:Label ID="Label1" runat="server" Text="VISIT DETAILS"></asp:Label>
                        <asp:GridView ID="grv_visitDetails" runat="server" ShowHeaderWhenEmpty="true" AutoGenerateColumns="false">
                            <Columns>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:Button ID="btn_edit" runat="server" Text="Edit" />
                                        <asp:Button ID="btn_delete" runat="server" Text="Delete" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Name">
                                    <ItemTemplate>
                                        <asp:Label ID="Label2" runat="server" Text="xyz"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Symtomns">
                                    <ItemTemplate>
                                        <asp:Label ID="Label2" runat="server" Text="abc"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Diagnosis">
                                    <ItemTemplate>
                                        <asp:Label ID="Label2" runat="server" Text="mno"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                            <EmptyDataTemplate>
                                NO RECORDS FOUND!
                            </EmptyDataTemplate>
                        </asp:GridView>
                    </ContentTemplate>
                </asp:TabPanel>

                <asp:TabPanel runat="server" TabIndex="1" ID="panel2">
                    <HeaderTemplate>ADD</HeaderTemplate>
                    <ContentTemplate>
                        <table>
                            <tr>
                                <td>
                                    <asp:Label ID="Label3" runat="server" Text="Patient"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label4" runat="server" Text=":"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="tb_patient" runat="server" Text="" Width="162px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label5" runat="server" Text="Patient Name"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label6" runat="server" Text=":"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="tb_pntName" runat="server" Text="" Width="162px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage=" Name Mandatory" ControlToValidate="tb_pntName" Display="Dynamic" ForeColor="Red" ValidationGroup="error"></asp:RequiredFieldValidator>
                                    <div id="div_name_list"></div>
                                    <asp:AutoCompleteExtender ID="AutoCompleteExtender1" runat="server" TargetControlID="tb_pntName" ServiceMethod="webUserName" ServicePath="~/PatientWebService1.asmx" MinimumPrefixLength="1" CompletionListElementID="div_name_list">
                                    </asp:AutoCompleteExtender>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label7" runat="server" Text="Symptomns"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label8" runat="server" Text=":"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="tb_symp" TextMode="MultiLine" runat="server" Text="" Rows="3" MaxLength="500" Style="width: 164px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage=" Add Patient Symptomns" ControlToValidate="tb_symp" Display="Dynamic" ForeColor="Red" ValidationGroup="error"></asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label9" runat="server" Text="Diagnosis"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label10" runat="server" Text=":"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="tb_diag" TextMode="MultiLine" runat="server" Text="" Rows="3" MaxLength="500" Style="width: 164px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage=" Add Patient Diagnosis" ControlToValidate="tb_diag" Display="Dynamic" ForeColor="Red" ValidationGroup="error"></asp:RequiredFieldValidator>
                                </td>
                            </tr>
                        </table>
                        <asp:TabContainer ID="tc_inside" runat="server" ActiveTabIndex="0" AutoPostBack="true" OnActiveTabChanged="tc_inside_ActiveTabChanged">
                            <asp:TabPanel runat="server" ID="panel3" TabIndex="0">
                                <HeaderTemplate>MEDICATION</HeaderTemplate>
                                <ContentTemplate>
                                    <table>
                                        <tr>
                                            <td>
                                                <asp:Label ID="Label11" runat="server" Text="A"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label12" runat="server" Text=":"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="TextBox1" TextMode="MultiLine" runat="server" Text="" Rows="3" MaxLength="500" Style="width: 164px"></asp:TextBox>
                                                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage=" Add Patient Diagnosis" ControlToValidate="tb_diag" Display="Dynamic" ForeColor="Red" ValidationGroup="error"></asp:RequiredFieldValidator>--%>
                                            </td>
                                            <td>
                                                <asp:GridView ID="grv_medication" runat="server" ShowHeaderWhenEmpty="true" AutoGenerateColumns="false">
                                                    <Columns>
                                                        <asp:TemplateField>
                                                            <ItemTemplate>
                                                                <asp:Button ID="btn_edit" runat="server" Text="Edit" />
                                                                <asp:Button ID="btn_delete" runat="server" Text="Delete" />
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:TemplateField HeaderText="Name">
                                                            <ItemTemplate>
                                                                <asp:Label ID="Label23" runat="server" Text='<%#Eval("Name")%>'></asp:Label>
                                                            </ItemTemplate>

                                                        </asp:TemplateField>
                                                        <asp:TemplateField HeaderText="Abc">
                                                            <ItemTemplate>
                                                                <asp:Label ID="Label23" runat="server" Text='<%#Eval("Abc")%>'></asp:Label>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                    </Columns>
                                                </asp:GridView>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Label ID="Label13" runat="server" Text="B"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label14" runat="server" Text=":"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="TextBox2" TextMode="MultiLine" runat="server" Text="" Rows="3" MaxLength="500" Style="width: 164px"></asp:TextBox>
                                                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage=" Add Patient Diagnosis" ControlToValidate="tb_diag" Display="Dynamic" ForeColor="Red" ValidationGroup="error"></asp:RequiredFieldValidator>--%>
                                            </td>
                                        </tr>
                                        <tr>
                                            <asp:Button ID="btn_addMed" runat="server" Text="Add" />
                                            <asp:Button ID="btn_resetMed" runat="server" Text="Reset" />
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Label ID="Label15" runat="server" Text="C"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label16" runat="server" Text=":"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="TextBox3" TextMode="MultiLine" runat="server" Text="" Rows="3" MaxLength="500" Style="width: 164px"></asp:TextBox>
                                                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage=" Add Patient Diagnosis" ControlToValidate="tb_diag" Display="Dynamic" ForeColor="Red" ValidationGroup="error"></asp:RequiredFieldValidator>--%>
                                            </td>
                                        </tr>

                                    </table>
                                </ContentTemplate>
                            </asp:TabPanel>
                            <asp:TabPanel runat="server" ID="TabPanel4" TabIndex="1">
                                <HeaderTemplate>INVESTIGATION</HeaderTemplate>
                                <ContentTemplate>
                                    <table>
                                        <tr>
                                            <td>
                                                <asp:Label ID="Label17" runat="server" Text="A"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label18" runat="server" Text=":"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="TextBox4" TextMode="MultiLine" runat="server" Text="" Rows="3" MaxLength="500" Style="width: 164px"></asp:TextBox>
                                                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage=" Add Patient Diagnosis" ControlToValidate="tb_diag" Display="Dynamic" ForeColor="Red" ValidationGroup="error"></asp:RequiredFieldValidator>--%>
                                            </td>
                                            <td>
                                                <asp:GridView ID="grv_investigation" runat="server" ShowHeaderWhenEmpty="true" AutoGenerateColumns="false">
                                                    <Columns>
                                                        <asp:TemplateField>
                                                            <ItemTemplate>
                                                                <asp:Button ID="btn_edit" runat="server" Text="Edit" />
                                                                <asp:Button ID="btn_delete" runat="server" Text="Delete" />
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:TemplateField HeaderText="Name">
                                                            <ItemTemplate>
                                                                <asp:Label ID="Label23" runat="server" Text="Z"></asp:Label>
                                                            </ItemTemplate>

                                                        </asp:TemplateField>
                                                        <asp:TemplateField HeaderText="Abc">
                                                            <ItemTemplate>
                                                                <asp:Label ID="Label23" runat="server" Text="Y"></asp:Label>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                    </Columns>
                                                </asp:GridView>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Label ID="Label19" runat="server" Text="B"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label20" runat="server" Text=":"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="TextBox5" TextMode="MultiLine" runat="server" Text="" Rows="3" MaxLength="500" Style="width: 164px"></asp:TextBox>
                                                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage=" Add Patient Diagnosis" ControlToValidate="tb_diag" Display="Dynamic" ForeColor="Red" ValidationGroup="error"></asp:RequiredFieldValidator>--%>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Label ID="Label21" runat="server" Text="C"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label22" runat="server" Text=":"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="TextBox6" TextMode="MultiLine" runat="server" Text="" Rows="3" MaxLength="500" Style="width: 164px"></asp:TextBox>
                                                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage=" Add Patient Diagnosis" ControlToValidate="tb_diag" Display="Dynamic" ForeColor="Red" ValidationGroup="error"></asp:RequiredFieldValidator>--%>
                                            </td>
                                        </tr>
                                    </table>
                                </ContentTemplate>
                            </asp:TabPanel>
                        </asp:TabContainer>
                        <br />
                        <br />
                        <br />
                        <asp:Button ID="btn_save" runat="server" Text="Save" />
                        <asp:Button ID="btn_clear" runat="server" Text="Clear" />

















                    </ContentTemplate>
                </asp:TabPanel>
            </asp:TabContainer>
        </div>
    </form>
</body>
</html>
