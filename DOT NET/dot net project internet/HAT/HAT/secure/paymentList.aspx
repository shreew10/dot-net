<%@ Page Language="C#" Theme="default" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="paymentList.aspx.cs" Inherits="paymentList" Title="HAT: Payments List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True"
        AutoGenerateColumns="False" AutoGenerateEditButton="True" CellPadding="4" DataKeyNames="pid"
        DataSourceID="AccessDataSource1" ForeColor="#333333" GridLines="None" Width="100%">
        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <Columns>
            <asp:BoundField DataField="pid" HeaderText="pid" SortExpression="pid" Visible="False" />
            <asp:TemplateField HeaderText="Head" SortExpression="headid">
                <EditItemTemplate>
                    <asp:DropDownList ID="dropPayment" runat="server" DataSourceID="AccessDataSource2"
                        DataTextField="head" DataValueField="id" SelectedValue='<%# Bind("headid") %>'>
                    </asp:DropDownList>
                    <asp:AccessDataSource ID="AccessDataSource2" runat="server" DataFile="~/App_Data/household.mdb"
                        SelectCommand="Select * from heads where type = 'Expenditure' order by head"></asp:AccessDataSource>
                </EditItemTemplate>
                <ItemTemplate>
                    <%# Eval("head") %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="pdate" HeaderText="Date" SortExpression="pdate" />
            <asp:TemplateField HeaderText="Mode" SortExpression="pmode">
                <EditItemTemplate>
                    <asp:DropDownList ID="dropMode" runat="Server" SelectedValue='<%# Bind("pmode") %>'>
                        <asp:ListItem Text="Cash" Value="Cash"></asp:ListItem>
                        <asp:ListItem Text="Credit" Value="Credit"></asp:ListItem>
                        <asp:ListItem Text="Cheque" Value="Cheque"></asp:ListItem>
                        <asp:ListItem Text="Draft" Value="Draft"></asp:ListItem>
                    </asp:DropDownList>
                </EditItemTemplate>
                <ItemTemplate>
                    <%# Eval("pmode") %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="pamount" HeaderText="Amount" SortExpression="pamount" />
            <asp:BoundField DataField="pdesc" HeaderText="Desciption" SortExpression="pdesc" />
            <asp:TemplateField HeaderText="Delete?">
                <EditItemTemplate>
                    &nbsp;
                </EditItemTemplate>
                <ItemTemplate>
                    <span onclick="return confirm ('Are you sure to Delete?')">
                        <asp:LinkButton ID="hyperDel" runat="Server" CommandName="Delete" Text="Delete"></asp:LinkButton>
                    </span>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" HorizontalAlign="Left" />
        <AlternatingRowStyle BackColor="White" />
        <EditRowStyle BackColor="#F5A6A6" />
    </asp:GridView>
    <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/household.mdb"
        DeleteCommand="DELETE FROM [payments] WHERE [pid] = ?" SelectCommand="select payments.*, heads.id, heads.head from payments, heads where payments.headid = heads.id ORDER BY payments.pdate DESC"
        UpdateCommand="UPDATE [payments] SET [headid] = ?, [pdate] = ?, [pamount] = ?, [pdesc] = ?, [pmode] = ? WHERE [pid] = ?">
        <DeleteParameters>
            <asp:Parameter Name="pid" Type="Int32" />
        </DeleteParameters>
        <UpdateParameters>
            <asp:Parameter Name="headid" Type="Int32" />
            <asp:Parameter Name="pdate" Type="DateTime" />
            <asp:Parameter Name="pamount" Type="Int32" />
            <asp:Parameter Name="pdesc" Type="String" />
            <asp:Parameter Name="pmode" Type="String" />
            <asp:Parameter Name="pid" Type="Int32" />
        </UpdateParameters>
    </asp:AccessDataSource>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FooterPlaceHolder1" Runat="Server">
</asp:Content>

