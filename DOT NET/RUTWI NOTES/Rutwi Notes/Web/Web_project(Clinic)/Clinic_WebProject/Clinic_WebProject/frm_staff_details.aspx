<%@ Page Title="" Language="C#" MasterPageFile="~/frm_mst_page.Master" AutoEventWireup="true" CodeBehind="frm_staff_details.aspx.cs" Inherits="Clinic_WebProject.WebForm3" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1 style="font-family: Candara; color: darkblue; margin-left: 650px">Staff Details</h1>
    </div>
    <div style="width: 700px; margin-left: 100px">
        <form class="form-control form-group form-inline">
            <div class="form-group form-inline">
            <label for="formGroupExampleInput"  style="width: 150px">Name:</label>
            <input type="text" class="form-control" id="txt_staff_name" placeholder="Name" style="width: 350px">
        </div>
        <div class="form-group form-inline">
            <label for="formGroupExampleInput" style="width: 150px">Address:</label>
            <input type="text" class="form-control" id="txt_staff_add" placeholder="Address" style="width: 350px">
        </div>
        <div class="form-group form-inline">
            <label for="formGroupExampleInput" style="width: 150px">Area:</label>
            <input type="text" class="form-control" id="txt_staff_area" placeholder="Area" style="width: 350px">
        </div>
        <div class="form-group form-inline">
            <label for="inputCity" class="form-label" style="width: 150px">City:</label>
            <select id="staff_city" class="form-select form-group form-control" style="width: 350px">
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
            <input type="text" class="form-control" id="txt_staff_pin" placeholder="Pin" style="width: 350px">
        </div>
        <div class="form-group form-inline">
            <label for="formGroupExampleInput" style="width: 150px">Contact:</label>
            <input type="text" class="form-control" id="txt_staff_contact" placeholder="Contact" style="width: 350px">
        </div>
        <div class="form-group form-inline">
            <label for="formGroupExampleInput" style="width: 150px">Gender:</label>
            <div class="form-check form-check-inline" style="margin-left:160px">
                <input class="form-check-input" type="radio" name="inlineRadioOptions" id="rdb_staff_female" value="option1" >
                <label class="form-check-label" for="rdb_staff_female">Female</label>
            </div>
            <div class="form-check form-check-inline" style="margin-left:160px">
                <input class="form-check-input" type="radio" name="inlineRadioOptions" id="rdb_staff_male" value="option2" >
                <label class="form-check-label" for="rdb_staff_male">Male</label>
            </div>
            <div class="form-check form-check-inline" style="margin-left:160px">
                <input class="form-check-input" type="radio" name="inlineRadioOptions" id="rdb_staff_other" value="option3" >
                <label class="form-check-label" for="rdb_staff_other">Others</label>
            </div>
        </div>
        <div class="form-group form-inline">
            <label for="formGroupExampleInput" style="width: 150px">Aadhar Card No.:</label>
            <input type="text" class="form-control" id="txt_staff_aadhar" placeholder="Aadhar Card"style="width: 350px">
        </div>
        <div class="form-group form-inline">
            <label for="formGroupExampleInput" style="width: 150px">Date of Birth:</label>
            <input type="date" class="form-control" id="dt_staff_dob" style="width: 350px">
        </div>
        <div class="form-group form-inline">
            <label for="formGroupExampleInput" style="width: 150px">Date of Joining:</label>
            <input type="date" class="form-control" id="dt_staff_doj" style="width: 350px">
        </div>
        <div class="form-group form-inline">
            <label for="formGroupExampleInput" style="width: 150px">Qualification:</label>
            <input type="text" class="form-control" id="txt_staff_qualification" placeholder="Qualification" style="width: 350px">
        </div>
        <div class="form-group form-inline">
            <label for="formGroupExampleInput" style="width: 150px">Experience:</label>
            <input type="text" class="form-control" id="txt_staff_experience" placeholder="Experience" style="width: 350px">
        </div>
        <div class="form-group form-inline">
            <label for="formGroupExampleInput" style="width: 150px">Work Type:</label>
            <input type="text" class="form-control" id="txt_staff_workType" placeholder="Work Type" style="width: 350px">
        </div>
        <div class="form-group form-inline">
            <label for="formGroupExampleInput" style="width: 150px">Email:</label>
            <input type="text" class="form-control" id="txt_staff_email" placeholder="Email" style="width: 350px">
        </div>
        <div class="form-group form-inline">
            <label for="formGroupExampleInput" style="width: 150px">Password:</label>
            <input type="text" class="form-control" id="txt_staff_password" placeholder="Password" style="width: 350px">
        </div>
        <div class="form-group form-inline">
            <button type="submit" id="btn_staff_save" class="btn btn-primary form-control" style="height: 30px; width: 70px; margin-left: 190px">Save</button>
            <button type="reset" id="btn_staff_clear" class="btn btn-primary form-control" style="height: 30px; width: 70px">Clear</button>
        </div>
        </form>
        
    </div>

</asp:Content>
