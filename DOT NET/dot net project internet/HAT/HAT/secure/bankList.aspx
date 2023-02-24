<%@ Page Language="C#" Theme="default" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="bankList.aspx.cs" Inherits="paymentList" Title="HAT: Payments List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True"
        AutoGenerateColumns="False" AutoGenerateEditButton="True" CellPadding="3" DataKeyNames="b_id"
        DataSourceID="AccessDataSource1" GridLines="Horizontal" Width="100%" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px">
        <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
        <Columns>
            <asp:BoundField DataField="pid" HeaderText="pid" SortExpression="pid" Visible="False" />
            <asp:TemplateField HeaderText="Head" SortExpression="b_no">
                <EditItemTemplate>
                    <asp:DropDownList ID="dropAccount" runat="server" SelectedValue='<%# Bind("b_no") %>'>
                            <asp:ListItem Value="010192456048" Text="010192456048 -> SBI Bank, Hyderabad"></asp:ListItem>
                            <asp:ListItem Value="030012776204" Text="030012776204 -> CHAND - SBI Bank, Ranchi"></asp:ListItem>
                            <asp:ListItem Value="10192484189" Text="10192484189 -&gt; SBI Bank - PPF, Ranchi"></asp:ListItem>
                            <asp:ListItem Value="5049306557" Text="5049306557 -> Citi Bank, Hyderabad"></asp:ListItem>
                            <asp:ListItem Value="007601522254" Selected="true" Text="007601522254 -> ICICI Bank, Hyderabad"></asp:ListItem>
                            <asp:ListItem Value="027010100407854" Text="027010100407854 -> UTI Bank, Hyderabad"></asp:ListItem>
                         </asp:DropDownList>
                </EditItemTemplate>
                <ItemTemplate>
                    <%# Eval("b_no") %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Type" SortExpression="b_type">
                <EditItemTemplate>
                   <asp:DropDownList ID="dropType" runat="server" SelectedValue='<%# Bind("b_type") %>'>
                            <asp:ListItem Text="Deposit" Value="Deposit"></asp:ListItem>
                            <asp:ListItem Text="Withdrawal" Value="Withdrawal"></asp:ListItem>
                        </asp:DropDownList>
                </EditItemTemplate>
                <ItemTemplate>
                    <%# Eval("b_type") %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="b_date" HeaderText="Date" SortExpression="b_date" />
            <asp:TemplateField HeaderText="Mode" SortExpression="b_mode">
                <EditItemTemplate>
                    <asp:DropDownList ID="dropMode" runat="Server" SelectedValue='<%# Bind("b_mode") %>'>
                        <asp:ListItem Text="Cash" Value="Cash"></asp:ListItem>
                        <asp:ListItem Text="Credit" Value="Credit"></asp:ListItem>
                        <asp:ListItem Text="Cheque" Value="Cheque"></asp:ListItem>
                        <asp:ListItem Text="Draft" Value="Draft"></asp:ListItem>
                    </asp:DropDownList>
                </EditItemTemplate>
                <ItemTemplate>
                    <%# Eval("b_mode") %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="b_amount" HeaderText="Amount" SortExpression="b_amount" />
            <asp:BoundField DataField="b_desc" HeaderText="Desciption" SortExpression="b_desc" />
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
        <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
        <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" HorizontalAlign="Left" />
        <AlternatingRowStyle BackColor="#F7F7F7" />
    </asp:GridView>
    <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/household.mdb"
        DeleteCommand="DELETE FROM [tblBank] WHERE [b_id] = ?" 
        SelectCommand="select * from tblBank order by b_date desc, b_no, b_type"
        UpdateCommand="UPDATE [tblBank] SET [b_no] = ?, [b_type] = ?, [b_date] = ?, [b_amount] = ?, [b_desc] = ?, [b_mode] = ? WHERE [b_id] = ?">
        <DeleteParameters>
            <asp:Parameter Name="b_id" Type="Int32" />
        </DeleteParameters>
        <UpdateParameters>
            <asp:Parameter Name="b_no" Type="String" />
            <asp:Parameter Name="b_type" Type="String" />
            <asp:Parameter Name="b_date" Type="DateTime" />
            <asp:Parameter Name="b_amount" Type="Int32" />
            <asp:Parameter Name="b_desc" Type="String" />
            <asp:Parameter Name="b_mode" Type="String" />
            <asp:Parameter Name="b_id" Type="Int32" />
        </UpdateParameters>
    </asp:AccessDataSource>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FooterPlaceHolder1" Runat="Server">
</asp:Content>

