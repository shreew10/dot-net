<%@ Page Language="C#" Theme="default" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="currentstatus.aspx.cs" Inherits="paymentList" Title="HAT: Payments List" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table width="100%" border="1" cellpadding="2" cellspacing="1" style="border-collapse:collapse;background-color: #cfcfee;">
        <tr>
            <td colspan="2" align="Center">
                <table style="background-color: #cfcfee;" cellpadding="2" cellspacing="4" width="100%">
                    <tr>
                        <td align="left">
                            Month
                            <asp:DropDownList ID="dropMonth" runat="server">
                                <asp:ListItem Value="1" Text="January"></asp:ListItem>
                                <asp:ListItem Value="2" Text="February"></asp:ListItem>
                                <asp:ListItem Value="3" Text="March"></asp:ListItem>
                                <asp:ListItem Value="4" Text="April"></asp:ListItem>
                                <asp:ListItem Value="5" Text="May"></asp:ListItem>
                                <asp:ListItem Value="6" Text="June"></asp:ListItem>
                                <asp:ListItem Value="7" Text="July"></asp:ListItem>
                                <asp:ListItem Value="8" Text="August"></asp:ListItem>
                                <asp:ListItem Value="9" Text="September"></asp:ListItem>
                                <asp:ListItem Value="10" Text="October"></asp:ListItem>
                                <asp:ListItem Value="11" Text="November"></asp:ListItem>
                                <asp:ListItem Value="12" Text="December"></asp:ListItem>
                            </asp:DropDownList>
                            Year
                            <asp:TextBox ID="txtYear" runat="Server" MaxLength="4" Width="50"></asp:TextBox>
                            <asp:CompareValidator ID="C1" runat="Server" ControlToValidate="txtYear" Text="&nbsp;Numeric Only"
                                Display="Dynamic" Operator="DataTypeCheck" Type="integer"></asp:CompareValidator>
                            <asp:Button ID="btnGo" runat="Server" Text="&nbsp;&nbsp;Go&nbsp;&nbsp;" />
                        </td>
                        <td align="Center">
                            <asp:Label ID="lblStatusTiming" runat="server" ForeColor="Brown" Font-Bold="true"></asp:Label>                            
                        </td>
                        <td align="right">
                            <asp:HyperLink ID="hyperPrevious" runat="Server" Text="<< Previous Month"></asp:HyperLink>
                            |
                            <asp:HyperLink ID="hyperThis" runat="Server" Text="Current Month"></asp:HyperLink>
                            |
                            <asp:HyperLink ID="hyperNext" runat="Server" Text="Next Month >>"></asp:HyperLink>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        </table>
        <table cellpadding="2" cellspacing="1" width="100%">
        <tr>
            <td>
                RECEIPTS</td>
            <td>
                PAYMENTS</td>
        </tr>
        <tr valign="top">
            <td style="width: 50%;">
                <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None"
                    DataSourceID="AccessDataSource1" AutoGenerateColumns="False" Width="100%" ShowFooter="True"
                    EmptyDataText="No receipt records found.">
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <RowStyle BackColor="#E3EAEB" />
                    <EditRowStyle BackColor="#7C6F57" />
                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" HorizontalAlign="left" />
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:TemplateField HeaderText="Receipts Head" SortExpression="head">
                            <ItemTemplate>
                                <a href='javascript:openWindow("headRecords.aspx?what=rec&head=<%# Eval("head") %>&month=<%= thisMonth %>&year=<%= thisYear %>")'>
                                    <%# Eval("head") %>
                                </a>
                            </ItemTemplate>
                            <FooterTemplate>
                                TOTAL
                            </FooterTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Amount" SortExpression="ramount">
                            <ItemTemplate>
                                <%# WriteAmount(Eval("ramount").ToString(), 1) %>
                            </ItemTemplate>
                            <FooterTemplate>
                                <%# WriteTotal(1) %>
                            </FooterTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/household.mdb"
                    SelectCommand="SELECT heads.head ,  sum(receipts.ramount) as ramount FROM receipts, heads  where receipts.headid = heads.id AND head.type = 'Receipts' group by heads.head">
                </asp:AccessDataSource>
            </td>
            <td style="width: 50%;">
                <asp:GridView ID="GridView2" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None"
                    DataSourceID="AccessDataSource2" AutoGenerateColumns="false" Width="100%" ShowFooter="True"
                    EmptyDataText="No payment records found.">
                    <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                    <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" HorizontalAlign="left" />
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:TemplateField HeaderText="Payments Head" SortExpression="head">
                            <ItemTemplate>
                                <a href='javascript:openWindow("headRecords.aspx?what=pay&head=<%# Eval("head") %>&month=<%= thisMonth %>&year=<%= thisYear %>")'>
                                    <%# Eval("head") %>
                                </a>
                            </ItemTemplate>
                            <FooterTemplate>
                                TOTAL
                            </FooterTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Amount" SortExpression="pamount">
                            <ItemTemplate>
                                <%# WriteAmount(Eval("pamount").ToString(), 0) %>
                            </ItemTemplate>
                            <FooterTemplate>
                                <%# WriteTotal(0) %>
                            </FooterTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <asp:AccessDataSource ID="AccessDataSource2" runat="server" DataFile="~/App_Data/household.mdb"
                    SelectCommand="SELECT heads.head ,  sum(payments.pamount) as pamount FROM payments, heads  where payments.headid = heads.id AND head.type = 'Expenditure' group by heads.head">
                </asp:AccessDataSource>
            </td>
        </tr>
        <tr>
            <td colspan="2"><br />
                <asp:GridView ID="GridView3" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None"
                    DataSourceID="AccessDataSource3" AutoGenerateColumns="False" Width="100%" ShowFooter="True"
                    EmptyDataText="No Deposit records found.">
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" HorizontalAlign="Left" />
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:TemplateField HeaderText="Deposits Head" SortExpression="head">
                            <ItemTemplate>
                                <a href='javascript:openWindow("headRecords.aspx?what=dep&head=<%# Eval("head") %>&month=<%= thisMonth %>&year=<%= thisYear %>")'>
                                    <%# Eval("head") %>
                                </a>
                            </ItemTemplate>
                            <FooterTemplate>
                                TOTAL
                            </FooterTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Amount" SortExpression="ramount">
                            <ItemTemplate>
                                <%# WriteAmount(Eval("ramount").ToString(), 3) %>
                            </ItemTemplate>
                            <FooterTemplate>
                                <%# WriteTotal(3) %>
                            </FooterTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <EditRowStyle BackColor="#2461BF" />
                </asp:GridView>
                <asp:AccessDataSource ID="AccessDataSource3" runat="server" DataFile="~/App_Data/household.mdb"
                    SelectCommand="SELECT heads.head ,  sum(deposits.ramount) as ramount FROM deposits, heads  where deposits.headid = heads.id AND heads.type = 'Deposits' group by heads.head">
                </asp:AccessDataSource>
            </td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FooterPlaceHolder1" runat="Server">
</asp:Content>

