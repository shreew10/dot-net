<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frm_MainPage.aspx.cs" Inherits="Clinic_WebProject.frm_MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-top: 10px; font-size: xx-large; font-family: Candara; background-color: lightsteelblue" >
            <p class="h1" style="margin-left:550px">Global Health Hospitals</p>
                
        </div>

        <div class="navbar navbar-inverse navbar-fixed">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button> 
                </div>
                <div class="navbar-collapse collapse">
                    <ul class="nav navbar-nav">
                        <li ><a runat="server" href="~/frm_LogIn.aspx">LogIn</a></li>
                        <li><a runat="server" href="~/">Book Appointment</a></li> 
                    </ul>
                </div>
            </div>
        </div>

    </form>
</body>
</html>
