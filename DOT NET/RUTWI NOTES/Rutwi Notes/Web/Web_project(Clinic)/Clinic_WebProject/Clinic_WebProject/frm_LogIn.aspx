<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frm_LogIn.aspx.cs" Inherits="Clinic_WebProject.frm_LogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div style="width:30%;height:30%;margin-left:550px;margin-top:200px">
            <div class="form-outline mb-4">
                <label class="form-label" for="form2Example1">LogIn ID</label>
                <input type="email" id="form2Example1" class="form-control" />
            </div>

            <!-- Password input -->
            <div class="form-outline mb-4">
                <label class="form-label" for="form2Example2">Password</label>
                <input type="password" id="form2Example2" class="form-control" />
            </div>

            <!-- 2 column grid layout for inline styling -->
            <div class="row mb-4">
                <div class="col">
                    <!-- Simple link -->
                    <a href="#!">Forgot password?</a>
                </div>
            </div>

            <div>
                <asp:Button ID="btn_login" runat="server" Text="LogIn" CssClass="btn btn-primary" OnClick="btn_login_Click" />
                <asp:Button ID="btn_clear" runat="server" Text="Clear" CssClass="btn btn-primary" OnClick="btn_clear_Click"/>
            </div>
        </div>
    </form>
</body>
</html>
