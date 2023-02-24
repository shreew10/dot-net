<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmGrdTF.aspx.cs" Inherits="GridViewTF.frmGrdTF" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            <br />
            <br />
            <br />

            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem>Pune</asp:ListItem>
                <asp:ListItem>Sangli</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <br />
            <br />

            <asp:GridView ID="grdDetails" runat="server" AutoGenerateColumns="false" ShowFooter="true">
                <Columns>
                    <asp:TemplateField HeaderText="Action">
                        <ItemTemplate>
                            <asp:Button runat="server" Text="Edit" ID="btnEdit" OnClick="btnEdit_Click" CommandArgument='<%#Bind("stud_id")%>' />
                            <asp:Button runat="server" Text="Delete" ID="btnDelete" />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:Button runat="server" Text="Update" ID="btnUpdate" OnClick="btnUpdate_Click" CommandArgument='<%#Bind("stud_id")%>' />
                            <asp:Button runat="server" Text="Cancel" ID="btnCancel" OnClick="btnCancel_Click" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:Button runat="server" Text="Add" ID="btnAdd" OnClick="btnAdd_Click" />
                            <asp:Button runat="server" Text="Clear" ID="btnClear" />
                        </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="ID" Visible="false">
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_id" runat="server" Text='<%#Eval("stud_id")%>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txt_stud_id" runat="server" Text='<%#Eval("stud_id")%>'></asp:TextBox>
                        </EditItemTemplate>

                    </asp:TemplateField>


                    <asp:TemplateField HeaderText="Name">
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_name" runat="server" Text='<%#Eval("stud_name")%>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txt_stud_name" runat="server" Text='<%#Eval("stud_name")%>'></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="stud_ft_name" runat="server"></asp:TextBox>
                        </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="City">
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_city" runat="server" Text='<%#Eval("stud_city")%>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:RadioButtonList ID="rbl_city" runat="server" Text='<%#Eval("stud_city")%>'>
                                <asp:ListItem>Pune</asp:ListItem>
                                <asp:ListItem>Sangli</asp:ListItem>
                            </asp:RadioButtonList>
                        </EditItemTemplate>
                        <FooterTemplate>
                             <asp:RadioButtonList ID="rbl_ft_city" runat="server">
                                <asp:ListItem>Pune</asp:ListItem>
                                <asp:ListItem>Sangli</asp:ListItem>
                            </asp:RadioButtonList>
                        </FooterTemplate>
                    </asp:TemplateField>

                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
