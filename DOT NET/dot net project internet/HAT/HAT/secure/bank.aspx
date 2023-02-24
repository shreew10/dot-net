<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="bank.aspx.cs" Inherits="payment" Title="HAT: Payment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="PlaceHolder" >
    <asp:Label ID="lblError" runat="Server" SkinID="skError" EnableViewState="False"></asp:Label>
    <asp:FormView ID="FormView1" runat="server" AllowPaging="True" CellPadding="4" DataKeyNames="rid"
        DataSourceID="AccessDataSource1" DefaultMode="Insert" ForeColor="#333333"
        OnItemCommand="FormView1_ItemCommand" OnItemInserted="FormView1_ItemInserted">
        <ItemTemplate>
        </ItemTemplate>
        <InsertItemTemplate>
            <table width="100%">
                <tr align="left">
                    <td align="center" colspan="3" style="background-color: #4A3C8C; color: #ffffff;
                        font-weight: bold;">
                        Add Bank A/c Details</td>
                </tr>
                <tr align="left">
                    <td>
                        Account Number</td>
                    <td>
                        <asp:DropDownList ID="dropAccount" runat="server" SelectedValue='<%# Bind("b_no") %>'>
                            <asp:ListItem Value="123" Text="123 -> SBI Bank, Hyderabad"></asp:ListItem>
                            <asp:ListItem Value="485" Text="485 -> SBI Bank, Ranchi"></asp:ListItem>
                         </asp:DropDownList>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr align="left">
                    <td>Type of transaction</td>
                    <td>
                        <asp:DropDownList ID="dropType" runat="server" SelectedValue='<%# Bind("b_type") %>'>
                            <asp:ListItem Text="Deposit" Value="Deposit"></asp:ListItem>
                            <asp:ListItem Text="Withdrawal" Value="Withdrawal"></asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr align="left">
                    <td>
                        Date:
                    </td>
                    <td>
                        <asp:TextBox ID="rdateTextBox" runat="server" Text='<%# Bind("b_date") %>'>
                        </asp:TextBox></td>
                    <td>
                        &nbsp;
                        <asp:RequiredFieldValidator ID="Req1" runat="Server" ControlToValidate="rdateTextBox"
                            Display="Dynamic" Text="*"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr align="left">
                    <td>
                        Amount:
                    </td>
                    <td>
                        <asp:TextBox ID="ramountTextBox" runat="server" Text='<%# Bind("b_amount") %>'>
                        </asp:TextBox>
                    </td>
                    <td>
                        &nbsp;
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="Server" ControlToValidate="ramountTextBox"
                            Display="Dynamic" Text="*"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr align="left">
                    <td>
                        Mode:
                    </td>
                    <td>
                        <asp:DropDownList ID="dropMode" runat="Server" SelectedValue='<%# Bind("b_mode") %>'>
                            <asp:ListItem Text="Cash" Value="Cash"></asp:ListItem>
                            <asp:ListItem Text="Credit" Value="Credit"></asp:ListItem>
                            <asp:ListItem Text="Cheque" Value="Cheque"></asp:ListItem>
                            <asp:ListItem Text="Draft" Value="Draft"></asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr valign="Top" align="left">
                    <td>
                        Description:
                    </td>
                    <td>
                        <asp:TextBox ID="rdescTextBox" runat="server" Columns="30" Rows="5" Text='<%# Bind("b_desc") %>'
                            TextMode="multiLine">
                        </asp:TextBox>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr align="left">
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert"
                            Text="Insert">
                        </asp:LinkButton>
                        <asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel"
                            Text="Cancel">
                        </asp:LinkButton>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </InsertItemTemplate>
        <EditItemTemplate>
        </EditItemTemplate>
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <RowStyle BackColor="#E7E7FF" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="White" />
    </asp:FormView>
    </div>
    <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/household.mdb"
        InsertCommand="INSERT INTO [tblBank] (b_no, b_type, b_date, b_amount, b_mode, b_desc) VALUES (@b_no, @b_type, @b_date, @b_amount, @b_mode, @b_desc)"
        SelectCommand="SELECT * FROM [tblBank]"></asp:AccessDataSource>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FooterPlaceHolder1" Runat="Server">
</asp:Content>

