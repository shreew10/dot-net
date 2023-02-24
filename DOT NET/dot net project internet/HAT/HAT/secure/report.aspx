<%@ Page Language="C#" Theme="default" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="report.aspx.cs" Inherits="report" Title="HAT: Reports" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div  class="PlaceHolder">
    <asp:Label ID="lblError" runat="Server" SkinID="skError" EnableViewState="False"></asp:Label>
    <table border="1" cellpadding="2" cellspacing="1" style="border-collapse:collapse;background-color: #cfcfee;" width="500">
        <tr>
            <td colspan="3" style="background-color:#c9c9c9;">
                Reports of Account Head
            </td>
        </tr>
        <tr align="left">
            <td>Reports of </td>
            <td>
                <asp:DropDownList ID="dropHeads" runat="server" DataTextField="HeadsAndType" DataValueField="HeadId">
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr align="left">
            <td>Date between</td>
            <td>
                <asp:TextBox ID="txtFrom" runat="Server" Width="75"></asp:TextBox>
                to 
                <asp:TextBox ID="txtTo" runat="Server" Width="75"></asp:TextBox>
            </td>
            <td>
                <asp:CompareValidator ID="Com1" runat="server" ControlToValidate="txtFrom" Operator="dataTypeCheck" Type="date" Text="From date is invalid." Display="Dynamic"></asp:CompareValidator>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtTo" Operator="dataTypeCheck" Type="date" Text="&nbsp;To date is invalid." Display="Dynamic"></asp:CompareValidator>
            </td>
        </tr>
        <tr align="left">
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnSubmit" runat="server" Text="Search" OnClick="ReportsForHead" />
            </td>
            <td>&nbsp;</td>
        </tr>
        
    </table>
        <br />
        <asp:Label ID="Label1" runat="Server" ForeColor="blue" EnableViewState="False"></asp:Label>
        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#DEDFDE" Width="100%"
            BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical"
             AutoGenerateColumns="False" ShowFooter="True">
            <FooterStyle BackColor="#CCCC99" HorizontalAlign="left" />
            <RowStyle BackColor="#F7F7DE" HorizontalAlign="left" />
            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" HorizontalAlign="left" />
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Head" SortExpression="Head" HeaderText="Head" />
                <asp:BoundField DataField="Date" SortExpression="Date" HeaderText="Date" FooterText="TOTAL" />
                <asp:TemplateField HeaderText="Amount" SortExpression="Amount">
                    <ItemTemplate>
                        <%# WriteAmount(Eval("Amount").ToString(), 1) %>
                    </ItemTemplate>
                    <FooterTemplate>
                        <%# WriteTotal(1) %>
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Mode" SortExpression="Mode" HeaderText="Mode" />
                <asp:BoundField DataField="Description" SortExpression="Description" HeaderText="Description" />
            </Columns>
        </asp:GridView>
        <asp:Label ID="Label2" runat="Server" ForeColor="blue" EnableViewState="False"></asp:Label>
        <asp:GridView ID="GridView2" runat="server" BackColor="White" BorderColor="#DEDFDE" Width="100%"
            BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical"
             AutoGenerateColumns="False" ShowFooter="True">
            <FooterStyle BackColor="#CCCC99" HorizontalAlign="left" />
            <RowStyle BackColor="#F7F7DE" HorizontalAlign="left" />
            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" HorizontalAlign="left" />
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Head" SortExpression="Head" HeaderText="Head" />
                <asp:BoundField DataField="Date" SortExpression="Date" HeaderText="Date" FooterText="TOTAL" />
                <asp:TemplateField HeaderText="Amount" SortExpression="Amount">
                    <ItemTemplate>
                        <%# WriteAmount(Eval("Amount").ToString(), 1) %>
                    </ItemTemplate>
                    <FooterTemplate>
                        <%# WriteTotal(1) %>
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Mode" SortExpression="Mode" HeaderText="Mode" />
                <asp:BoundField DataField="Description" SortExpression="Description" HeaderText="Description" />
            </Columns>
        </asp:GridView>
        <asp:Label ID="Label3" runat="Server" ForeColor="blue" EnableViewState="False"></asp:Label>
        <asp:GridView ID="GridView3" runat="server" BackColor="White" BorderColor="#DEDFDE" Width="100%"
            BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical"
             AutoGenerateColumns="False" ShowFooter="True">
            <FooterStyle BackColor="#CCCC99" HorizontalAlign="left" />
            <RowStyle BackColor="#F7F7DE" HorizontalAlign="left" />
            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" HorizontalAlign="left" />
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Head" SortExpression="Head" HeaderText="Head" />
                <asp:BoundField DataField="Date" SortExpression="Date" HeaderText="Date" FooterText="TOTAL" />
                <asp:TemplateField HeaderText="Amount" SortExpression="Amount">
                    <ItemTemplate>
                        <%# WriteAmount(Eval("Amount").ToString(), 1) %>
                    </ItemTemplate>
                    <FooterTemplate>
                        <%# WriteTotal(1) %>
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Mode" SortExpression="Mode" HeaderText="Mode" />
                <asp:BoundField DataField="Description" SortExpression="Description" HeaderText="Description" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FooterPlaceHolder1" Runat="Server">
</asp:Content>

