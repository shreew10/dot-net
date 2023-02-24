<%@ Control Language="C#" AutoEventWireup="true" CodeFile="menu.ascx.cs" Inherits="include_menu" %>
<asp:Menu ID="Menu1" runat="server" Orientation="Horizontal" Width="100%" BackColor="#FFFBD6" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#990000" StaticSubMenuIndent="10px" DataSourceID="SiteMapDataSource1" StaticDisplayLevels="2">
    <Items>
        <asp:MenuItem NavigateUrl="~/secure/default.aspx" Text="Home" Value="Home"></asp:MenuItem>
        <asp:MenuItem NavigateUrl="~/secure/receipt.aspx" Text="Receipt" Value="Receipt">
            <asp:MenuItem NavigateUrl="~/secure/receipt.aspx" Text="Add" Value="Insert"></asp:MenuItem>
            <asp:MenuItem NavigateUrl="~/secure/receiptList.aspx" Text="List" Value="List"></asp:MenuItem>
        </asp:MenuItem>
        <asp:MenuItem NavigateUrl="~/secure/deposit.aspx" Text="Deposit" Value="Deposit">
            <asp:MenuItem NavigateUrl="~/secure/deposit.aspx" Text="Add" Value="Insert"></asp:MenuItem>
            <asp:MenuItem NavigateUrl="~/secure/depositList.aspx" Text="List" Value="List"></asp:MenuItem>
        </asp:MenuItem>
        <asp:MenuItem NavigateUrl="~/secure/payment.aspx" Text="Payment" Value="Payment">
            <asp:MenuItem NavigateUrl="~/secure/payment.aspx" Text="Add" Value="Add"></asp:MenuItem>
            <asp:MenuItem NavigateUrl="~/secure/paymentList.aspx" Text="List" Value="List"></asp:MenuItem>
        </asp:MenuItem>
        <asp:MenuItem NavigateUrl="~/secure/bank.aspx" Text="Bank" Value="Bank">
            <asp:MenuItem NavigateUrl="~/secure/bank.aspx" Text="Add" Value="Add"></asp:MenuItem>
            <asp:MenuItem NavigateUrl="~/secure/bankList.aspx" Text="List" Value="List"></asp:MenuItem>
        </asp:MenuItem>
        <asp:MenuItem NavigateUrl="~/secure/currentstatus.aspx" Text="Current Status" Value="Current Status">
        </asp:MenuItem>
        <asp:MenuItem NavigateUrl="~/secure/report.aspx" Text="Report" Value="Report"></asp:MenuItem>
    </Items>
    <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
    <DynamicHoverStyle BackColor="#990000" ForeColor="White" />
    <DynamicMenuStyle BackColor="#FFFBD6" BorderColor="#400000" BorderWidth="0px" />
    <StaticSelectedStyle BackColor="#FFCC66" />
    <DynamicSelectedStyle BackColor="#FFCC66" />
    <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" Width="150px" />
    <StaticHoverStyle BackColor="#990000" ForeColor="White" />
</asp:Menu>
<asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
