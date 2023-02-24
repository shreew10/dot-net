<%@ Page Title="" Language="C#" MasterPageFile="~/frm_mst_page.Master" AutoEventWireup="true" CodeBehind="frm_patient_details.aspx.cs" Inherits="Clinic_WebProject.WebForm4" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/b.js"></script>
    <script src="Scripts/bootstrap.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin-left: 650px">
        <h1 style="font-family: Candara; color: darkblue">Patient Details</h1>
    </div>
    <asp:TabContainer ID="TabContainer1" runat="server">

    </asp:TabContainer>
    <div style="width: 700px; margin-left: 100px">
        <form class="form-inline">
            <div class="form-group form-inline">
                <label for="formGroupExampleInput" style="width: 150px">Name:</label>
                <input type="text" class="form-control" id="txt_patient_name" placeholder="Name" style="width: 350px">
            </div>
            <div class="form-group form-inline">
                <label for="formGroupExampleInput" style="width: 150px">Address:</label>
                <input type="text" class="form-control" id="txt_patient_add" placeholder="Address" style="width: 350px">
            </div>
            <div class="form-group form-inline">
                <label for="formGroupExampleInput" style="width: 150px">Area:</label>
                <input type="text" class="form-control" id="txt_patient_area" placeholder="Area" style="width: 350px">
            </div>
            <div class="form-group form-inline">
                <label for="inputCity" class="form-label" style="width: 150px">City:</label>
                <select id="patient_city" class="form-select form-group form-control" style="width: 350px">
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
                <input type="text" class="form-control" id="txt_patient_pin" placeholder="Pin" style="width: 350px">
            </div>
            <div class="form-group form-inline">
                <label for="formGroupExampleInput" style="width: 150px">Gender:</label>
                <div class="form-check form-check-inline form-inline" style="margin-left: 160px">
                    <input class="form-check-input" type="radio" name="inlineRadioOptions" id="rdb_patient_female" value="option1">
                    <label class="form-check-label" for="rdb_patient_female">Female</label>
                </div>
                <div class="form-check form-check-inline form-inline" style="margin-left: 160px">
                    <input class="form-check-input" type="radio" name="inlineRadioOptions" id="rdb_patient_male" value="option2">
                    <label class="form-check-label" for="rdb_patient_male">Male</label>
                </div>
                <div class="form-check form-check-inline form-inline" style="margin-left: 160px">
                    <input class="form-check-input" type="radio" name="inlineRadioOptions" id="rdb_patient_other" value="option3">
                    <label class="form-check-label" for="rdb_patient_other">Others</label>
                </div>
            </div>
            <div class="form-group form-inline">
                <label for="formGroupExampleInput" style="width: 150px">Date of Birth:</label>
                <input type="date" class="form-control" id="dt_patient_dob" style="width: 350px">
            </div>
            <div class="form-group form-inline">
                <label for="formGroupExampleInput" style="width: 150px">Contact:</label>
                <input type="text" class="form-control" id="txt_patient_contact" placeholder="Contact" style="width: 350px">
            </div>
            <div class="form-group form-inline">
                <label for="formGroupExampleInput" style="width: 150px">Email:</label>
                <input type="text" class="form-control" id="txt_patient_email" placeholder="Email" style="width: 350px">
            </div>
            <div class="form-group form-inline">
                <label for="formGroupExampleInput" style="width: 150px">Reference from:</label>
                <input type="text" class="form-control" id="txt_patient_ref" placeholder="Reference From" style="width: 350px">
            </div>
            <div class="form-group form-inline">
                <label for="inputCity" class="form-label" style="width: 150px">City:</label>
                <select id="patient_bloodgroup" class="form-select form-group form-control" style="width: 350px">
                    <option selected>Choose Blood Group...</option>
                    <option>A+</option>
                    <option>A-</option>
                    <option>B+</option>
                    <option>B-</option>
                    <option>O+</option>
                    <option>O-</option>
                    <option>AB+</option>
                    <option>AB-</option>
                </select>
            </div>
            <div class="form-group form-inline">
                <label for="formGroupExampleInput" style="width: 150px">Registration Date:</label>
                <input type="date" class="form-control" id="dt_patient_registration" style="width: 350px">
            </div>
            <div class="form-group form-inline">
                <button type="submit" id="btn_patient_save" class="btn btn-primary form-control" style="height: 30px; width: 70px; margin-left: 190px">Save</button>
                <button type="reset" id="btn_patient_clear" class="btn btn-primary form-control" style="height: 30px; width: 70px">Clear</button>
            </div>
        </form>
    </div>

</asp:Content>
