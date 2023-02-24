<%@ Page Language="C#" Theme="default" AutoEventWireup="true" CodeFile="headRecords.aspx.cs" Inherits="headRecord" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Details of a Particular Head</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p style="text-align:center;">
            <asp:Label ID="lblTitle" runat="Server" ForeColor="brown"></asp:Label>
        </p>
        <asp:GridView ID="GridView1" runat="server" DataSourceID="AccessDataSource1" BackColor="White" 
        BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" GridLines="Vertical"
         Width="100%" ForeColor="Black">
            <FooterStyle BackColor="#CCCCCC" />
            <RowStyle Font-Size="X-Small" Font-Names="Verdana,Arial" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <HeaderStyle Font-Size="X-Small" BackColor="Black" Font-Bold="True" ForeColor="White" HorizontalAlign="Left" />
            <AlternatingRowStyle BackColor="#CCCCCC" />
        </asp:GridView>
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/household.mdb">
        </asp:AccessDataSource>
    </div>
    </form>
    <p style="text-align:right;"><a href="javascript:window.close();">Close</a></p>
</body>
</html>
