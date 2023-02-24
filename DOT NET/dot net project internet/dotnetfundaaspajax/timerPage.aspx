<%@ Page Language="C#" Theme="default" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="timerPage.aspx.cs" Inherits="timerPage" Title="Timer Control Example" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    
    <asp:UpdatePanel runat="server" ID="UpdatePanel1" UpdateMode="Conditional">
        <ContentTemplate>
            <asp:Label runat="Server" ID="lblMessage1" Text="Please wait ..." SkinID="FormValueMessage" />
            <asp:Timer runat="Server" ID="Timer1" OnTick="Timer1_Tick" Interval="3000" />
        </ContentTemplate>    
    </asp:UpdatePanel>
    
    <asp:UpdatePanel runat="server" ID="UpdatePanel2" UpdateMode="Conditional">
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
        </Triggers>
        <ContentTemplate>
            <asp:Label runat="Server" ID="lblMessage2" SkinID="FormValueMessage" />
        </ContentTemplate>    
    </asp:UpdatePanel>
</asp:Content>

