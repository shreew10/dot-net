<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="reportMonth.aspx.cs" Inherits="reportMonth" Title="HAT: Monthly Report" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div  class="PlaceHolder">
    <asp:Label ID="lblError" runat="Server" SkinID="skError" EnableViewState="False"></asp:Label>
    <table cellpadding="2" cellspacing="2" border="1" style="border-collapse:collapse;background-color: #cfcfee;" width="300">
        <tr align="left">
            <td>Monthly Report for the Year</td>
            <td><asp:TextBox ID="txtYear" runat="Server" Width="50" MaxLength="4"></asp:TextBox></td>
            <td>
                <asp:CompareValidator ID="com1" runat="Server" ControlToValidate="txtYear" Text="Numeric only" Display="Dynamic" Operator="dataTypeCheck" Type="integer"></asp:CompareValidator>
            </td>
        </tr>
        <tr align="left">
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnSubmit" runat="Server" Text="Submit" OnClick="MonthlyReport" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    </div>
    <table width="100%">
        <tr>
            <td>RECEIPTS</td>
            <td>EXPENDITURE</td>
        </tr>
        <tr valign="top">
            <td>
    <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#DEDFDE"
        BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical"
         Width="100%" ShowFooter="True" AutoGenerateColumns="false">
        <FooterStyle BackColor="#CCCC99" />
        <RowStyle BackColor="#F7F7DE" />
        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" HorizontalAlign="left" />
        <AlternatingRowStyle BackColor="White" />
        <Columns>
                <asp:TemplateField HeaderText="Month Name" >
                    <ItemTemplate>
                        <%# System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(Int32.Parse(Eval("ThisMonth").ToString())) %>
                    </ItemTemplate>
                    <FooterTemplate>
                        TOTAL
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Amount" SortExpression="MonthTotal">
                    <ItemTemplate>
                        <%# WriteAmount(Eval("MonthTotal").ToString(), 0)%>
                    </ItemTemplate>
                    <FooterTemplate>
                        <%# WriteTotal(0) %>
                    </FooterTemplate>
                </asp:TemplateField>
        </Columns>
    </asp:GridView>        
            </td>
            <td>
    <asp:GridView ID="GridView2" runat="server" BackColor="White" BorderColor="#DEDFDE"
        BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical"
         Width="100%" ShowFooter="True" AutoGenerateColumns="false">
        <FooterStyle BackColor="#CCCC99" />
        <RowStyle BackColor="#F7F7DE" />
        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" HorizontalAlign="left" />
        <AlternatingRowStyle BackColor="White" />
        <Columns>
                <asp:TemplateField HeaderText="Month Name" >
                    <ItemTemplate>
                        <%# System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(Int32.Parse(Eval("ThisMonth").ToString())) %>
                    </ItemTemplate>
                    <FooterTemplate>
                        TOTAL
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Amount" SortExpression="MonthTotal">
                    <ItemTemplate>
                        <%# WriteAmount(Eval("MonthTotal").ToString(), 1)%>
                    </ItemTemplate>
                    <FooterTemplate>
                        <%# WriteTotal(1) %>
                    </FooterTemplate>
                </asp:TemplateField>
        </Columns>
    </asp:GridView>         
            </td>
        </tr>
    </table>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FooterPlaceHolder1" Runat="Server">
</asp:Content>

