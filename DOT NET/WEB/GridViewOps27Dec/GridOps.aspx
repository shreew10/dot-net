<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridOps.aspx.cs" Inherits="GridViewOps27Dec.GridOps" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <%-- <asp:GridView ID="GridView1" runat="server">
    <columns>
        <asp:TemplateField HeaderText="ID">         col name
            <ItemTemplate></ItemTemplate>           display mode which can contain lables 
            <EditItemTemplate></EditItemTemplate>   edit mode which can contain textboxes
        </asp:TemplateField>    
    </columns>
    </asp:GridView>--%>



        <div>
            <asp:GridView ID="grv_crud" runat="server" AutoGenerateColumns="false" ShowHeaderWhenEmpty="true"
                EmptyDataText="No Data" ShowFooter="true" OnSelectedIndexChanged="grv_crud_SelectedIndexChanged">
                <Columns>
                    <asp:TemplateField HeaderText="Action">
                        <ItemTemplate>
                            <asp:Button ID="btn_edit" runat="server" Text="Edit" OnClick="btn_edit_Click" CommandArgument='<%#Bind("studRollno")%>' Visible="true" />
                            <asp:Button ID="btn_delete" runat="server" Text="Delete" OnClick="btn_delete_Click" CommandArgument='<%#Bind("studRollno")%>' />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:Button ID="btn_update" runat="server" Text="Update" OnClick="btn_update_Click" CommandArgument='<%#Bind("studRollno")%>' />
                            <asp:Button ID="btn_cancel" runat="server" Text="Cancel" OnClick="btn_cancel_Click" CommandArgument='<%#Bind("studRollno")%>' />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:Button ID="btn_add" runat="server" Text="Add" OnClick="btn_add_Click" />
                        </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="ID">
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_studRollno" runat="server" Text='<%#Eval("studRollno")%>' Visible="false"></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtno" runat="server" Text='<%#Eval("studRollno")%>' Visible="false"></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txt_f_stud_roll_no" runat="server" Visible="false"></asp:TextBox>
                        </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Name">
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_name" runat="server" Text='<%#Eval("studName")%>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txt_edit_name" runat="server" Text='<%#Eval("studName")%>'></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txt_f_name" runat="server"></asp:TextBox>
                        </FooterTemplate>

                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Gender">
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_Gender" runat="server" Text='<%#Eval("studGender")%>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:RadioButtonList ID="rbl_edit" runat="server" Text='<%#Eval("studGender")%>'>
                                <asp:ListItem>Female</asp:ListItem>
                                <asp:ListItem>Male</asp:ListItem>
                            </asp:RadioButtonList>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:RadioButtonList ID="rbl_f" runat="server">
                                <asp:ListItem>Female</asp:ListItem>
                                <asp:ListItem>Male</asp:ListItem>
                            </asp:RadioButtonList>
                        </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Subject">
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_sub" runat="server" Text='<%#Eval("studSubject")%>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:DropDownList ID="ddl_edit" runat="server" Text='<%#Eval("studSubject")%>'>
                                <asp:ListItem>java</asp:ListItem>
                                <asp:ListItem>C</asp:ListItem>
                                <asp:ListItem>php</asp:ListItem>
                            </asp:DropDownList>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:DropDownList ID="ddl_f" runat="server">
                                <asp:ListItem>java</asp:ListItem>
                                <asp:ListItem>C</asp:ListItem>
                                <asp:ListItem>php</asp:ListItem>
                            </asp:DropDownList>
                        </FooterTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>

        <br />
        <br />
        <br />

        <div>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
