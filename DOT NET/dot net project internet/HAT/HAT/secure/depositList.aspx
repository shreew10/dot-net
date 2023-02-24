<%@ Page Language="C#" Theme="default" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="depositList.aspx.cs" Inherits="receiptList" Title="HAT: Deposits List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True"
        AutoGenerateColumns="False" CellPadding="4" DataSourceID="AccessDataSource1"
        ForeColor="#333333" GridLines="None" Width="100%" DataKeyNames="rid"
         AutoGenerateEditButton="true">
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <Columns>
            <asp:BoundField DataField="rid" HeaderText="rid" Visible="false" SortExpression="rid" />
            <asp:TemplateField HeaderText="Head" SortExpression="headid">
                <ItemTemplate>
                    <%# Eval("head") %>
                </ItemTemplate>
                <EditItemTemplate>
                     <asp:DropDownList ID="dropReceipt" DataSourceID="AccessDataSource2" runat="server"
                            DataTextField="head" DataValueField="id" SelectedValue='<%# Bind("headid") %>'>
                        </asp:DropDownList>
                        <asp:AccessDataSource ID="AccessDataSource2" runat="server" DataFile="~/App_Data/household.mdb"
                            SelectCommand="Select * from heads where type = 'Deposits' order by head">
                        </asp:AccessDataSource>
                </EditItemTemplate>
            </asp:TemplateField>            
            <asp:BoundField DataField="rdate" HeaderText="Date" SortExpression="rdate" />
            <asp:TemplateField HeaderText="Mode" SortExpression="rmode">
                <ItemTemplate>
                    <%# Eval("rmode") %>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:DropDownList ID="dropMode" runat="Server" SelectedValue='<%# Bind("rmode") %>'>
                            <asp:ListItem Text="Cash" Value="Cash"></asp:ListItem>
                            <asp:ListItem Text="Credit" Value="Credit"></asp:ListItem>
                            <asp:ListItem Text="Cheque" Value="Cheque"></asp:ListItem>
                            <asp:ListItem Text="Draft" Value="Draft"></asp:ListItem>
                        </asp:DropDownList>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="ramount" HeaderText="Amount" SortExpression="ramount" />
            <asp:BoundField DataField="rdesc" HeaderText="Desciption" SortExpression="rdesc" />
            <asp:TemplateField HeaderText="Delete?">
                <ItemTemplate>
                    <span onclick="return confirm ('Are you sure to Delete?')">
                        <asp:LinkButton runat="Server" ID="hyperDel" CommandName="Delete" Text="Delete"></asp:LinkButton>
                    </span>
                </ItemTemplate>
                <EditItemTemplate>
                    &nbsp;
                </EditItemTemplate>
            </asp:TemplateField>
        </Columns>
        <RowStyle BackColor="#EFF3FB" />
        <EditRowStyle BackColor="#ccddFF" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" HorizontalAlign="left" />
        <AlternatingRowStyle BackColor="White" />
    </asp:GridView>
    <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/household.mdb"
        SelectCommand="select deposits.*, heads.id, heads.head from deposits, heads where deposits.headid = heads.id ORDER BY deposits.rdate DESC" 
        UpdateCommand="UPDATE [deposits] SET [headid] = ?, [rdate] = ?, [ramount] = ?, [rdesc] = ?, [rmode] = ? WHERE [rid] = ?"
        DeleteCommand="DELETE FROM [deposits] WHERE [rid] = ?" >
         <DeleteParameters>
            <asp:Parameter Name="rid" Type="Int32" />
        </DeleteParameters>
        <UpdateParameters>
            <asp:Parameter Name="headid" Type="Int32" />
            <asp:Parameter Name="rdate" Type="DateTime" />
            <asp:Parameter Name="ramount" Type="Int32" />
            <asp:Parameter Name="rdesc" Type="String" />
            <asp:Parameter Name="rmode" Type="String" />
            <asp:Parameter Name="rid" Type="Int32" />
        </UpdateParameters>
    </asp:AccessDataSource>
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FooterPlaceHolder1" Runat="Server">
</asp:Content>

