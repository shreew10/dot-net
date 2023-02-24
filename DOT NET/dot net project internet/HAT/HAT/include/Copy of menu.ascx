<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Copy of menu.ascx.cs" Inherits="include_menu" %>
<asp:Menu ID="Menu1" runat="server" Orientation="Horizontal" Width="100%" BackColor="#FFFBD6" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#990000" StaticSubMenuIndent="10px">
    <Items>
        <asp:MenuItem NavigateUrl="~/default.aspx" Text="Home" Value="Home"></asp:MenuItem>
        <asp:MenuItem NavigateUrl="~/receipt.aspx" Text="Receipt" Value="Receipt">
            <asp:MenuItem NavigateUrl="~/receipt.aspx" Text="Add" Value="Insert"></asp:MenuItem>
            <asp:MenuItem NavigateUrl="~/receiptList.aspx" Text="List" Value="List"></asp:MenuItem>
        </asp:MenuItem>
        <asp:MenuItem NavigateUrl="~/deposit.aspx" Text="Deposit" Value="Deposit">
            <asp:MenuItem NavigateUrl="~/deposit.aspx" Text="Add" Value="Insert"></asp:MenuItem>
            <asp:MenuItem NavigateUrl="~/depositList.aspx" Text="List" Value="List"></asp:MenuItem>
        </asp:MenuItem>
        <asp:MenuItem NavigateUrl="~/payment.aspx" Text="Payment" Value="Payment">
            <asp:MenuItem NavigateUrl="~/payment.aspx" Text="Add" Value="Add"></asp:MenuItem>
            <asp:MenuItem NavigateUrl="~/paymentList.aspx" Text="List" Value="List"></asp:MenuItem>
        </asp:MenuItem>
        <asp:MenuItem NavigateUrl="~/bank.aspx" Text="Bank" Value="Bank">
            <asp:MenuItem NavigateUrl="~/bank.aspx" Text="Add" Value="Add"></asp:MenuItem>
            <asp:MenuItem NavigateUrl="~/bankList.aspx" Text="List" Value="List"></asp:MenuItem>
        </asp:MenuItem>
        <asp:MenuItem NavigateUrl="~/currentstatus.aspx" Text="Current Status" Value="Current Status">
        </asp:MenuItem>
        <asp:MenuItem NavigateUrl="~/report.aspx" Text="Report" Value="Report"></asp:MenuItem>
        <asp:MenuItem NavigateUrl="~/notes.aspx" Text="Notes" Value="Notes"></asp:MenuItem>
    </Items>
    <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
    <DynamicHoverStyle BackColor="#990000" ForeColor="White" />
    <DynamicMenuStyle BackColor="#FFFBD6" BorderColor="#400000" BorderWidth="1px" />
    <StaticSelectedStyle BackColor="#FFCC66" />
    <DynamicSelectedStyle BackColor="#FFCC66" />
    <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" Width="150px" />
    <StaticHoverStyle BackColor="#990000" ForeColor="White" />
</asp:Menu>
