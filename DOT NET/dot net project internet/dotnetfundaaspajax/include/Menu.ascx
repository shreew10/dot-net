<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Menu.ascx.cs" Inherits="include_Menu" %>
<asp:Menu ID="Menu1" runat="server" BackColor="#FFFBD6" DynamicHorizontalOffset="2"
    Font-Names="Verdana" Font-Size="0.8em" ForeColor="#990000" Orientation="Horizontal"
    StaticSubMenuIndent="10px">
    <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
    <DynamicHoverStyle BackColor="#990000" ForeColor="White" />
    <DynamicMenuStyle BackColor="#FFFBD6" />
    <StaticSelectedStyle BackColor="#FFCC66" />
    <DynamicSelectedStyle BackColor="#FFCC66" />
    <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
    <Items>
        <asp:MenuItem NavigateUrl="~/dropdown.aspx" Text="DropDownExample" Value="DropDownExample">
        </asp:MenuItem>
        <asp:MenuItem NavigateUrl="~/timerPage.aspx" Text="Timer" Value="Timer"></asp:MenuItem>
        <asp:MenuItem NavigateUrl="~/updateprogress.aspx" Text="Update Progress Bar" Value="Update Progress Bar" />
        <asp:MenuItem NavigateUrl="~/gridviewpage.aspx" Text="GridView Page" Value="GridView Demo" />
        <asp:MenuItem NavigateUrl="~/MutliUserControl.aspx" Text="Multiple User Control Demo" Value="Multiple UserControl Demo" />
        <asp:MenuItem NavigateUrl="~/multiUp.aspx" Text="Multiple UpdatePanel" Value="Multiple UpdatePanel">
        </asp:MenuItem>
    </Items>
    <StaticHoverStyle BackColor="#990000" ForeColor="White" />
</asp:Menu>
