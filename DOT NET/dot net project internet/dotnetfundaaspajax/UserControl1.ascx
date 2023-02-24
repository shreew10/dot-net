<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UserControl1.ascx.cs" Inherits="UserControl1" %>
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <table border="1">
            <tr>
                <th>Update Panel 1 </th>
            </tr>
            <tr>
                <td>
                    <asp:DropDownList ID="dropDown1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="FireChangeEvent">
            <asp:ListItem Text="List 1" Value="1"></asp:ListItem>
            <asp:ListItem Text="List 2" Value="2"></asp:ListItem>
            <asp:ListItem Text="List 3" Value="3"></asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label ID="lblDrop" runat="Server" Text="UC 1 -> "></asp:Label>        
                </td>
            </tr>
        </table>
        
    </ContentTemplate>
</asp:UpdatePanel>
