<%@ Page Language="C#" Theme="default" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="UpdateProgress.aspx.cs" Inherits="UpdateProgress" Title="Update Progress Bar Demo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
     <asp:UpdateProgress ID="UpdateProgress1" AssociatedUpdatePanelID="UpdatePanel1" DynamicLayout="true" runat="server">
        <ProgressTemplate>
            <div style="bottom:0px;bottom:0%;color:Red;position:absolute;font-size:xx-large;;">Please wait ...</div>
        </ProgressTemplate>
    </asp:UpdateProgress>
    
    <table width="100%">
        <tr>
            <th>
                First Update Panel
            </th>
            <th>
                Second Update Panel
            </th>
        </tr>
        <tr>
            <td>
                <asp:UpdatePanel runat="Server" ID="UpdatePanel1" UpdateMode="Conditional">
                    <ContentTemplate>
                        <table>
                            <tr>
                                <th colspan="2">
                                    Update Progress Bar Demo
                                </th>
                            </tr>
                            <tr>
                                <td>
                                    Your Name</td>
                                <td>
                                    <asp:TextBox ID="txtName" runat="Server"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td>
                                    Your Address</td>
                                <td>
                                    <asp:TextBox ID="txtAddress" runat="Server"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td>
                                    Your Name</td>
                                <td>
                                    <asp:Button ID="btnSubmit" runat="Server" OnClick="SubmitForm" Text="Submit" /></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="lblMessage" runat="Server" SkinID="FormValueMessage"></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
            <td align="Center">
                <asp:UpdatePanel ID="UpdatePanel2" runat="Server" UpdateMode="conditional">
                    <ContentTemplate>
                        <asp:Button ID="btnTime" Font-Bold="True" runat="Server" OnClick="WriteTime" Text="Write Current Time" />
                        <br />
                        <asp:Label ID="lblMessage1" runat="Server" SkinID="FormValueMessage"></asp:Label>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
        </tr>
    </table>
</asp:Content>
