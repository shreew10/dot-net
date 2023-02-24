<%@ Page Language="C#" Theme="default" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="receipt.aspx.cs" Inherits="receipt" Title="HAT: Receipts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="PlaceHolder">
    <asp:Label ID="lblError" runat="Server" SkinID="skError" EnableViewState="False"></asp:Label>
    <asp:FormView ID="FormView1" runat="server" CellPadding="4" ForeColor="#333333" DataSourceID="AccessDataSource1"
        GridLines="Vertical" AllowPaging="True" DataKeyNames="rid" DefaultMode="insert" OnItemInserted="FormView1_ItemInserted" OnItemCommand="FormView1_ItemCommand">
        <ItemTemplate>
            rid:
            <asp:Label ID="ridLabel" runat="server" Text='<%# Eval("rid") %>'></asp:Label><br />
            headid:
            <asp:Label ID="headidLabel" runat="server" Text='<%# Bind("headid") %>'></asp:Label><br />
            rdate:
            <asp:Label ID="rdateLabel" runat="server" Text='<%# Bind("rdate") %>'></asp:Label><br />
            ramount:
            <asp:Label ID="ramountLabel" runat="server" Text='<%# Bind("ramount") %>'></asp:Label><br />
            rdesc:
            <asp:Label ID="rdescLabel" runat="server" Text='<%# Bind("rdesc") %>'></asp:Label><br />
            rmode:
            <asp:Label ID="rmodeLabel" runat="server" Text='<%# Bind("rmode") %>'></asp:Label><br />
            rLoan:
            <asp:CheckBox ID="rLoanCheckBox" runat="server" Checked='<%# Bind("rLoan") %>' Enabled="false" /><br />
            rPaidAmount:
            <asp:Label ID="rPaidAmountLabel" runat="server" Text='<%# Bind("rPaidAmount") %>'>
            </asp:Label><br />
            rPaidDate:
            <asp:Label ID="rPaidDateLabel" runat="server" Text='<%# Bind("rPaidDate") %>'></asp:Label><br />
        </ItemTemplate>
        <InsertItemTemplate>
            <table width="100%">
                <tr align="left" style="background-color:#336666;color:#ffffff;font-weight:bold;">
                    <td align="center" colspan="3">Add Receipt Details</td>
                </tr>
                <tr align="left">
                    <td>
                        Receipt Head</td>
                    <td>
                        <asp:DropDownList ID="dropReceipt" DataSourceID="AccessDataSource2" runat="server"
                            DataTextField="head" DataValueField="id" SelectedValue='<%# Bind("id") %>'>
                        </asp:DropDownList>
                        <asp:AccessDataSource ID="AccessDataSource2" runat="server" DataFile="~/App_Data/household.mdb"
                            SelectCommand="Select * from heads where type = 'Receipts' and id <> 12 order by head">
                        </asp:AccessDataSource>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr align="left">
                    <td>
                        Date:
                    </td>
                    <td>
                        <asp:TextBox ID="rdateTextBox" runat="server" Text='<%# Bind("rdate") %>'>
                        </asp:TextBox></td>
                    <td>&nbsp;
                        <asp:RequiredFieldValidator ID="Req1" runat="Server" ControlToValidate="rdateTextBox" Text="*" Display="Dynamic"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr align="left">
                    <td>
                        Amount:
                    </td>
                    <td>
                        <asp:TextBox ID="ramountTextBox" runat="server" Text='<%# Bind("ramount") %>'>
                        </asp:TextBox>
                    </td>
                    <td>&nbsp;
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="Server" ControlToValidate="ramountTextBox" Text="*" Display="Dynamic"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                
                <tr align="left">
                    <td>
                        Mode:
                    </td>
                    <td>
                        <asp:DropDownList ID="dropMode" runat="Server" SelectedValue='<%# Bind("rmode") %>'>
                            <asp:ListItem Text="Cash" Value="Cash"></asp:ListItem>
                            <asp:ListItem Text="Credit" Value="Credit"></asp:ListItem>
                            <asp:ListItem Text="Cheque" Value="Cheque"></asp:ListItem>
                            <asp:ListItem Text="Draft" Value="Draft"></asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr valign="Top">
                    <td>
                        Description:
                    </td>
                    <td>
                        <asp:TextBox ID="rdescTextBox" TextMode="multiLine" Rows="5" Columns="30" runat="server" Text='<%# Bind("rdesc") %>'>
                        </asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
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
                    <td>&nbsp;</td>
                </tr>
            </table>
        </InsertItemTemplate>
        <EditItemTemplate>
            <table width="100%">
                <tr align="left">
                    <td align="center" class="EntryTableTitle" colspan="3">Add Receipt Details</td>
                </tr>
                <tr align="left">
                    <td>
                        Receipt Head</td>
                    <td>
                        <asp:DropDownList ID="dropReceipt" DataSourceID="AccessDataSource2" runat="server"
                            DataTextField="head" DataValueField="id" SelectedValue='<%# Bind("id") %>'>
                        </asp:DropDownList>
                        <asp:AccessDataSource ID="AccessDataSource2" runat="server" DataFile="~/App_Data/household.mdb"
                            SelectCommand="Select * from heads where type = 'Receipts' and id <> 12 order by head">
                        </asp:AccessDataSource>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr align="left">
                    <td>
                        Date:
                    </td>
                    <td>
                        <asp:TextBox ID="rdateTextBox" runat="server" Text='<%# Bind("rdate") %>'>
                        </asp:TextBox></td>
                    <td>&nbsp;
                        <asp:RequiredFieldValidator ID="Req1" runat="Server" ControlToValidate="rdateTextBox" Text="*" Display="Dynamic"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr align="left">
                    <td>
                        Amount:
                    </td>
                    <td>
                        <asp:TextBox ID="ramountTextBox" runat="server" Text='<%# Bind("ramount") %>'>
                        </asp:TextBox>
                    </td>
                    <td>&nbsp;
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="Server" ControlToValidate="ramountTextBox" Text="*" Display="Dynamic"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                
                <tr align="left">
                    <td>
                        Mode:
                    </td>
                    <td>
                        <asp:DropDownList ID="dropMode" runat="Server" SelectedValue='<%# Bind("rmode") %>'>
                            <asp:ListItem Text="Cash" Value="Cash"></asp:ListItem>
                            <asp:ListItem Text="Credit" Value="Credit"></asp:ListItem>
                            <asp:ListItem Text="Cheque" Value="Cheque"></asp:ListItem>
                            <asp:ListItem Text="Draft" Value="Draft"></asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr valign="Top">
                    <td>
                        Description:
                    </td>
                    <td>
                        <asp:TextBox ID="rdescTextBox" TextMode="multiLine" Rows="5" Columns="30" runat="server" Text='<%# Bind("rdesc") %>'>
                        </asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr align="left">
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update"
                            Text="Update">
                        </asp:LinkButton>
                        <asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel"
                            Text="Cancel">
                        </asp:LinkButton>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </EditItemTemplate>
    </asp:FormView>
    </div>
    <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/household.mdb"
        SelectCommand="SELECT * FROM [receipts]"
         InsertCommand="INSERT INTO [receipts] (headid, rdate, ramount, rmode, rdesc) VALUES (@headid, @rdate, @ramount, @rmode, @rdesc)"></asp:AccessDataSource>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FooterPlaceHolder1" runat="Server">
</asp:Content>
