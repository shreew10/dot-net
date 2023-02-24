<%@ Page Title="" Language="C#" MasterPageFile="~/frm_mst_page.Master" AutoEventWireup="true" CodeBehind="frm_clinicDetails.aspx.cs" Inherits="Clinic_WebProject.WebForm2" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/b.js"></script>
    <script src="Scripts/bootstrap.js"></script>
    <script src="Scripts/bootstrap.min.js"></script> 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div style="margin-left: 650px">
        <h1 style="font-family: Candara; color: darkblue">Clinic Details</h1>
    </div>
    <%-- <ul class="nav nav-tabs">
        <li class="active"><a href="WebForm5.aspx">Add</a></li>
        <li><a href="WebForm5.aspx">List</a></li>
    </ul>--%>

    <div>
        <div style="width: 700px; margin-left: 100px">
            <form class="form-control form-group form-inline">
                <div class="form-group form-inline">
                    <label for="formGroupExampleInput" style="width: 150px">Name:</label>
                    <input type="text" class="form-control" id="txt_clinic_name" placeholder="Name" style="width: 350px">
                </div>
                <div class="form-group form-inline">
                    <label for="inputAddress" class="form-label" style="width: 150px">Address:</label>
                    <input type="text" class="form-control" id="txt_clinic_add" placeholder="Address" style="width: 350px">
                </div>
                <div class="form-group form-inline">
                    <label for="formGroupExampleInput" style="width: 150px">Area:</label>
                    <input type="text" class="form-control" id="txt_clinic_area" placeholder="Area" style="width: 350px">
                </div>
                <div class="form-group form-inline">
                    <label for="inputCity" class="form-label" style="width: 150px">City:</label>
                    <select id="clinic_city" class="form-select form-group form-control" style="width: 350px">
                        <option selected>Choose city...</option>
                        <option>Sangli</option>
                        <option>Pune</option>
                        <option>Mumbai</option>
                        <option>Ratnagiri</option>
                        <option>Aurangabad</option>
                        <option>Jalna</option>
                        <option>Kolhapur</option>
                        <option>Sindhudurg</option>
                        <option>Raigad</option>
                        <option>Satara</option>
                        <option>Nashik</option>
                        <option>Nagpur</option>
                        <option>Latur</option>
                    </select>
                </div>
                <div class="form-group form-inline">
                    <label for="formGroupExampleInput" style="width: 150px">Pin:</label>
                    <input type="text" class="form-control" id="txt_clinic_pin" placeholder="Pin" style="width: 350px">
                </div>
                <div class="form-group form-inline">
                    <label for="formGroupExampleInput" style="width: 150px">Contact:</label>
                    <input type="text" class="form-control" id="txt_clinic_contact" placeholder="Contact" style="width: 350px">
                </div>
                <div class="form-group form-inline">
                    <label for="formGroupExampleInput" style="width: 150px">Website:</label>
                    <input type="text" class="form-control" id="txt_clinic_website" placeholder="Website" style="width: 350px">
                </div>
                <div class="form-group form-inline">
                    <label for="formGroupExampleInput" style="width: 150px">Start Time:</label>
                    <input type="time" class="form-control" id="txt_clinic_startTime" style="width: 350px">
                </div>
                <div class="form-group form-inline">
                    <label for="formGroupExampleInput" style="width: 150px">End Time:</label>
                    <input type="time" class="form-control" id="txt_clinic_endTime" style="width: 350px">
                </div>
                <div class="form-group form-inline">
                    <button type="submit" id="btn_clinic_save" class="btn btn-primary form-control" style="height: 30px; width: 70px; margin-left: 190px">Save</button>
                    <button type="reset" id="btn_clinic_clear" class="btn btn-primary form-control" style="height: 30px; width: 70px">Clear</button>
                </div>
            </form>
        </div>
    </div>
</asp:Content>
