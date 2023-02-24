<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="multiup.aspx.cs" Inherits="multiup" Title="Multiple Update Panel Demo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <table width="100%">
        <tr>
            <td>
                Outside Update Panel: <asp:TextBox id="txtOutside" runat="server" Text="Outside Panel Text" />
                <p>&nbsp;</p>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                    <contenttemplate>
                        Inside Update Panel:
                        <asp:TextBox id="txtInside" runat="server" Text="Inside Panel Text" />
                    </contenttemplate>
                </asp:UpdatePanel>
            </td>
            <td>
                <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
                    <contenttemplate>
                        Under Update Panel
                        <asp:Calendar id="Calendar1" runat="Server" BorderColor="#FFCC66" Width="220px" BorderWidth="1px" 
                        ShowGridLines="True" Font-Size="8pt" Font-Names="Verdana" BackColor="#FFFFCC" 
                        DayNameFormat="Shortest" Height="200px" ForeColor="#663399"  OnSelectionChanged="ChangeDateTimeInside">
                        <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True"></SelectedDayStyle>

                        <TodayDayStyle BackColor="#FFCC66" ForeColor="White"></TodayDayStyle>

                        <SelectorStyle BackColor="#FFCC66"></SelectorStyle>

                        <OtherMonthDayStyle ForeColor="#CC9966"></OtherMonthDayStyle>

                        <NextPrevStyle ForeColor="#FFFFCC" Font-Size="9pt"></NextPrevStyle>

                        <DayHeaderStyle BackColor="#FFCC66" Height="1px" Font-Bold="True"></DayHeaderStyle>

                        <TitleStyle BackColor="#990000" ForeColor="#FFFFCC" Font-Size="9pt" Font-Bold="True"></TitleStyle>
                        </asp:Calendar> 
                        
                        <asp:Label id="lblInside" runat="server" SkindID="FormMessage" />
                        </contenttemplate>
                </asp:UpdatePanel>
            </td>
            <td>
                Outside Update Panel
                <asp:Calendar ID="Calendar2" runat="Server" BorderColor="#FFCC66" Width="220px" BorderWidth="1px"
                    ShowGridLines="True" Font-Size="8pt" Font-Names="Verdana" BackColor="#FFFFCC"
                    DayNameFormat="Shortest" Height="200px" ForeColor="#663399" OnSelectionChanged="ChangeDataTimeOutside">
                    <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True"></SelectedDayStyle>
                    <TodayDayStyle BackColor="#FFCC66" ForeColor="White"></TodayDayStyle>
                    <SelectorStyle BackColor="#FFCC66"></SelectorStyle>
                    <OtherMonthDayStyle ForeColor="#CC9966"></OtherMonthDayStyle>
                    <NextPrevStyle ForeColor="#FFFFCC" Font-Size="9pt"></NextPrevStyle>
                    <DayHeaderStyle BackColor="#FFCC66" Height="1px" Font-Bold="True"></DayHeaderStyle>
                    <TitleStyle BackColor="#990000" ForeColor="#FFFFCC" Font-Size="9pt" Font-Bold="True">
                    </TitleStyle>
                </asp:Calendar>
                </contenttemplate>
                <asp:Label ID="lblOutside" runat="server" SkindID="FormMessage" />
            </td>
        </tr>
    </table>
</asp:Content>
