<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UserControl2.ascx.cs" Inherits="UserControl2" %>
<asp:UpdatePanel ID="UpdatePanel2" runat="server">
    <ContentTemplate>
        <table  border="1">
            <tr>
                <th>Update Panel 2</th>
            </tr>
            <tr>
                <td><asp:Label ID="lblMessage" runat="server" Text="2nd User Control"></asp:Label></td>
            </tr>
        </table>
        
    </ContentTemplate>
</asp:UpdatePanel>
