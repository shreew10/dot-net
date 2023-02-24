<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CustomMessageBox.WebForm1" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div>
            <asp:Button ID="btn_save" runat="server" Text="Save" OnClick="btn_save_Click" BackColor="LightBlue" />
            <asp:Button ID="btn_delete" runat="server" Text="Delete" OnClick="btn_delete_Click" BackColor="LightBlue" />



            <asp:ModalPopupExtender ID="mpe_common" runat="server" TargetControlID="btn_ok" PopupControlID="pnl_common" Enabled="false"></asp:ModalPopupExtender>
            <asp:Panel ID="pnl_common" runat="server" Visible="false" BackColor="LightBlue" Height="90px" Width="250px">
                <asp:Label ID="lbl_message" runat="server" Text=""></asp:Label>
                <br />
                <asp:Button ID="btn_ok" runat="server" Text="Ok" OnClick="btn_ok_Click" />
            </asp:Panel>

            <asp:ModalPopupExtender ID="mpe_conf" runat="server" CancelControlID="btn_no" TargetControlID="btn_yes" PopupControlID="pnl_conf" Enabled="false"></asp:ModalPopupExtender>
            <asp:Panel ID="pnl_conf" runat="server" Visible="false" BackColor="LightBlue" Height="90px" Width="250px">
                <asp:Label ID="lbl" runat="server" Text="Are you sure you want to delete"></asp:Label>
                <br />
                <asp:Button ID="btn_yes" runat="server" Text="Yes" OnClick="btn_yes_Click" />
                <asp:Button ID="btn_no" runat="server" Text="No" OnClick="btn_no_Click" />
            </asp:Panel>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="studRollno" DataSourceID="SqlDataSource2">
                <Columns>
                    <asp:BoundField DataField="studRollno" HeaderText="studRollno" InsertVisible="False" ReadOnly="True" SortExpression="studRollno" />
                    <asp:BoundField DataField="studName" HeaderText="studName" SortExpression="studName" />
                    <asp:BoundField DataField="studGender" HeaderText="studGender" SortExpression="studGender" />
                </Columns>
            </asp:GridView>

            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:tempdb_TruptiConnectionString %>" SelectCommand="SELECT [studRollno], [studName], [studGender] FROM [tbl_student_details]"></asp:SqlDataSource>

            <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SHRIKANT %>" SelectCommand="SELECT [emp_name], [emp_address], [emp_pin] FROM [tble_emp]"></asp:SqlDataSource>

            <br />
            <br />
            <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:tempdb_TruptiConnectionString %>" SelectCommand="SELECT [studRollno], [studName], [studGender], [studSubject] FROM [tbl_student_details] WHERE ([studRollno] = @studRollno)">
                <SelectParameters>
                    <asp:Parameter DefaultValue="39" Name="studRollno" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>
            <br />
            <br />
            <br />
            <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:tempdb_TruptiConnectionString %>" SelectCommand="SELECT [studRollno], [studName], [studGender] FROM [tbl_student_details] WHERE ([studRollno] = @studRollno)">
                <SelectParameters>
                    <asp:Parameter DefaultValue="42" Name="studRollno" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>

        </div>
    </form>
</body>
</html>
