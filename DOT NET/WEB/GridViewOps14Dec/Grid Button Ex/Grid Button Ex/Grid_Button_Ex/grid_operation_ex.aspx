<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="grid_operation_ex.aspx.cs" Inherits="Grid_Button_Ex.grid_operation_ex" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="grv_crud" runat="server"></asp:GridView>
        </div>
        <h1></h1>
        <div>
            <asp:GridView ID="grv_stud_details" runat="server" AutoGenerateColumns="false" ShowHeaderWhenEmpty="true">
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btn_edit" runat="server" Text="Edit"
                                CommandArgument='<%#Bind("studRollno")%>' OnClick="btn_edit_Click" />

                            <asp:Button ID="btn_delete" runat="server" Text="Delete" />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:Button ID="btn_update" runat="server" Text="Update" OnClick="btn_update_Click" CommandArgument='<%#Eval("studRollno")%>' />
                            <asp:Button ID="btn_cancel" runat="server" Text="Cancel" OnClick="btn_cancel_Click" />
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="ID">
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_StudRollNo" runat="server" Text='<%#Eval("studRollno")%>' Visible="false"></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:Label ID="lbl_edit_StudRollNo" runat="server" Text='<%#Eval("studRollno")%>' Visible="false"></asp:Label>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Name">
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_StudName" runat="server" Text='<%#Eval("studName")%>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txt_edit_name" runat="server" Text='<%#Eval("studName")%>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Gender">
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_StudGender" runat="server" Text='<%#Eval("studGender")%>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:RadioButtonList ID="rbl_edit_gender" runat="server" Text='<%#Eval("studGender")%>'>
                                <asp:ListItem>Male</asp:ListItem>
                                <asp:ListItem>Female</asp:ListItem>
                            </asp:RadioButtonList>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Subject">
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_StudSubject" runat="server" Text='<%#Eval("studSubject")%>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:DropDownList ID="ddl_edit_subject" runat="server" Text='<%#Eval("studSubject")%>'>
                                <asp:ListItem>Java</asp:ListItem>
                                <asp:ListItem>Dotnet</asp:ListItem>
                                <asp:ListItem>C++</asp:ListItem>
                            </asp:DropDownList>
                        </EditItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>

        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
