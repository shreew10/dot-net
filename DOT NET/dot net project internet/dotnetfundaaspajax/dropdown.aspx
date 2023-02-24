<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="dropdown.aspx.cs" Inherits="dropdown" Title="Populate DropDown" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <asp:Label ID="lblError" runat="Server" SkinID="ErrorMessage"></asp:Label>
    <asp:UpdatePanel ID="UpdatePanel1" runat="Server" UpdateMode="conditional">
        <ContentTemplate>
            <table>
                <tr>
                    <td>
                    Parent Category: 
                        <asp:DropDownList ID="dropParentCategory" runat="Server" DataTextField="StringName"
                            DataValueField="AutoID" OnSelectedIndexChanged="PopulateChildDropDown" AutoPostBack="True">
                        </asp:DropDownList>
                        <br /><br />
                    </td>
                </tr>
                <tr>
                    <td>
                    Child Category:
                        <asp:DropDownList ID="dropChildCategory" runat="Server" DataTextField="StringName"
                            DataValueField="AutoID">
                            <asp:ListItem Text="Select Parent Category ..." Value="0"></asp:ListItem>
                        </asp:DropDownList>
                        <br /><br />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnSubmit" runat="Server" Text="Submit" OnClick="SubmitForm" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblMessage" runat="Server" SkinID="FormValueMessage"></asp:Label>
                    </td>
                </tr>
            </table>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
