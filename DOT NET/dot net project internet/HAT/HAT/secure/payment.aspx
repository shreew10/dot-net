<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="payment.aspx.cs" Inherits="payment" Title="HAT: Payment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="PlaceHolder">
    <asp:Label ID="lblError" runat="Server" SkinID="skError" EnableViewState="False"></asp:Label>
    <asp:FormView ID="FormView1" runat="server" AllowPaging="True" CellPadding="4" DataKeyNames="rid"
        DataSourceID="AccessDataSource1" DefaultMode="Insert" ForeColor="#333333" GridLines="Vertical"
        OnItemCommand="FormView1_ItemCommand" OnItemInserted="FormView1_ItemInserted">
        <ItemTemplate>
        </ItemTemplate>
        <InsertItemTemplate>
            <table width="100%">
                <tr align="left">
                    <td align="center" colspan="3" style="background-color: #990000; color: #ffffff;
                        font-weight: bold;">
                        Add Payment Details</td>
                </tr>
                <tr align="left">
                    <td>
                        Payment Head</td>
                    <td>
                        <asp:DropDownList ID="dropReceipt" runat="server" DataSourceID="AccessDataSource2"
                            DataTextField="head" DataValueField="id" SelectedValue='<%# Bind("id") %>'>
                        </asp:DropDownList>
                        <asp:AccessDataSource ID="AccessDataSource2" runat="server" DataFile="~/App_Data/household.mdb"
                            SelectCommand="Select * from heads where type = 'Expenditure' order by head"></asp:AccessDataSource>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr align="left">
                    <td>
                        Date:
                    </td>
                    <td>
                        <asp:TextBox ID="rdateTextBox" runat="server" Text='<%# Bind("pdate") %>'>
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
                        <asp:TextBox ID="ramountTextBox" runat="server" Text='<%# Bind("pamount") %>'>
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
                        <asp:DropDownList ID="dropMode" runat="Server" SelectedValue='<%# Bind("pmode") %>'>
                            <asp:ListItem Text="Cash" Value="Cash"></asp:ListItem>
                            <asp:ListItem Text="Credit" Value="Credit"></asp:ListItem>
                            <asp:ListItem Text="Cheque" Value="Cheque"></asp:ListItem>
                            <asp:ListItem Text="Draft" Value="Draft"></asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr valign="Top">
                    <td>
                        Description:
                    </td>
                    <td>
                        <asp:TextBox ID="rdescTextBox" runat="server" Columns="30" Rows="5" Text='<%# Bind("pdesc") %>'
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
    </asp:FormView>
    </div>
    <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/household.mdb"
        InsertCommand="INSERT INTO [payments] (headid, pdate, pamount, pmode, pdesc) VALUES (@headid, @pdate, @pamount, @pmode, @pdesc)"
        SelectCommand="SELECT * FROM [payments]"></asp:AccessDataSource>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FooterPlaceHolder1" Runat="Server">
</asp:Content>

