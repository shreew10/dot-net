using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ClinicProjectWeb2Jan.PresentationLayer
{
    public partial class frmPatient : System.Web.UI.Page
    {
        clsConnection con = new clsConnection();
        SqlCommand cmd;
        public void FuncAuth()
        {
            try
            {

                if (Session["ID"] == null && Session["Password"] == null)
                {
                    Response.Redirect("../StaffLogin.aspx");
                }
                else
                {
                    ////select where
                    cmd = new SqlCommand("SELECT COUNT(staff_id) FROM staff where staff_id=@staff_id and password=@password", con.funCon());
                    cmd.Connection.Open();
                    cmd.Parameters.AddWithValue("@staff_id", Session["ID"]);
                    cmd.Parameters.AddWithValue("@password", Session["Password"]);
                    cmd.ExecuteScalar();
                    if (Convert.ToInt32(cmd.ExecuteScalar()) == 0)
                    {
                        // message
                    }
                    cmd.Connection.Close();

                }
            }
            catch (Exception ex)
            {

                string a = ex.Message;
            }
        }
        protected void Page_PreInit(object sender, EventArgs e)
        {
            FuncAuth();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FuncGrid();

            }
            tb_pntdob.Attributes.Add("readonly", "true");
            tb_pntRgstDt.Attributes.Add("readonly", "true");
            //tb_allergy_start_date.Attributes.Add("readonly", "true");
            //tb_cronic_dis_date.Attributes.Add("readonly", "true");
        }
        protected void tc_patient_ActiveTabChanged(object sender, EventArgs e)
        {
            if (tc_patient.ActiveTabIndex == 0)
            {
                FunClear();
                FuncGrid();
                tc_patient_additional_data.Visible = false;
            }
        }


        //fill grid functions--------------------------------------------
        void FuncGrid()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT patient_id,patient_name,patient_contact,reg_dt FROM patient", con.funCon());
                cmd.Connection.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                grv_patientList.DataSource = dt;
                grv_patientList.DataBind();
                cmd.Connection.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void GridLoadNew()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT allergy_id, patient_id, allergy, allergy_start_dt FROM allergy_history SELECT cronic_disease_id,patient_id,cronic_disease,cronic_disease_start_dt FROM cronic_disease SELECT patient_med_id,patient_id,medicine,frequency FROM medication_history", con.funCon());
                DataSet ds = new DataSet();
                cmd.Connection.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);
                cmd.Connection.Close();



                if (ds.Tables[0].Rows.Count > 0)
                {
                    gv_allergy.DataSource = ds.Tables[0];
                    gv_allergy.DataBind();
                }
                else
                {
                    //DataTable dt = new DataTable();
                    ds.Tables[0].Rows.Add();
                    gv_allergy.DataSource = ds.Tables[0];
                    gv_allergy.DataBind();
                    gv_allergy.Rows[0].Visible = false;
                }

                if (ds.Tables[1].Rows.Count > 0)
                {
                    gv_cronicDis.DataSource = ds.Tables[1];
                    gv_cronicDis.DataBind();
                }
                else
                {
                    ds.Tables[1].Rows.Add();
                    gv_cronicDis.DataSource = ds.Tables[1];
                    gv_cronicDis.DataBind();
                    gv_cronicDis.Rows[0].Visible = false;
                }

                if (ds.Tables[2].Rows.Count > 0)
                {
                    gv_history.DataSource = ds.Tables[2];
                    gv_history.DataBind();
                }
                else
                {
                    ds.Tables[2].Rows.Add();
                    gv_history.DataSource = ds.Tables[2];
                    gv_history.DataBind();
                    gv_history.Rows[0].Visible = false;
                }



            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //clear function-----------------------------------------------------------------------------
        void FunClear()
        {
            tb_pntName.Text = "";
            tb_pntAddress.Text = "";
            tb_pntArea.Text = "";
            Ddl_pntCity.ClearSelection();
            tb_pntPin.Text = "";
            rbl_pntGender.SelectedValue = "";
            rbl_pntGender.SelectedIndex = -1;
            tb_pntdob.Text = "";
            tb_pntContact.Text = "";
            tb_pntEmail.Text = "";
            tb_pntRef.Text = "";
            ddl_pntBldGrp.ClearSelection();
            rbl_pntGender.ClearSelection();
            tb_pntRgstDt.Text = "";
            Ddl_pntCity.SelectedIndex = -1;
        }

        //--------------------patient events---------------------------------------
        protected void btn_clear_Click(object sender, EventArgs e)
        {
            try
            {
                FunClear();
            }
            catch (Exception)
            {

                throw;
            }
        }
        protected void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (ViewState["patient_id"] == null)
                {
                    //insert ops
                    SqlCommand SqlCom = new SqlCommand("SELECT MAX(patient_id) FROM patient", con.funCon());
                    SqlCom.Connection.Open();
                    //int autoPatId = 1;
                    ViewState["Id"] = 1;
                    if (SqlCom.ExecuteScalar().ToString() != "")
                    {
                        ViewState["Id"] = Convert.ToInt32(SqlCom.ExecuteScalar()) + 1;
                    }

                    SqlCom.Connection.Close();

                    SqlCommand SqlComInsert = new SqlCommand("INSERT INTO patient (patient_id,patient_name,patient_addrs,patient_area,patient_city,patient_pin,patient_gender,patient_dob,patient_contact,patient_email,patient_ref,patient_blood_group,reg_dt) VALUES (@patient_id,@patient_name,@patient_addrs,@patient_area,@patient_city,@patient_pin,@patient_gender,CONVERT(DATE,@patient_dob,103),@patient_contact,@patient_email,@patient_ref,@patient_blood_group,CONVERT(DATE,@reg_dt,103))", con.funCon());
                    SqlComInsert.Connection.Open();
                    //SqlComInsert.Parameters.AddWithValue("@patient_id", autoPatId);
                    SqlComInsert.Parameters.AddWithValue("@patient_id", ViewState["Id"]);

                    if (rbl_pntGender.SelectedValue == "Male")
                    {
                        SqlComInsert.Parameters.AddWithValue("@patient_gender", rbl_pntGender.Text.Trim());
                    }
                    else if (rbl_pntGender.SelectedValue == "Female")
                    {
                        SqlComInsert.Parameters.AddWithValue("@patient_gender", rbl_pntGender.Text.Trim());
                    }
                    else
                    {
                        SqlComInsert.Parameters.AddWithValue("@patient_gender", rbl_pntGender.Text.Trim());
                    }
                    SqlComInsert.Parameters.AddWithValue("@patient_name", tb_pntName.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@patient_addrs", tb_pntAddress.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@patient_area", tb_pntArea.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@patient_city", Convert.ToString(Ddl_pntCity.SelectedValue));
                    SqlComInsert.Parameters.AddWithValue("@patient_pin", tb_pntPin.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@patient_dob", tb_pntdob.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@patient_contact", tb_pntContact.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@patient_email", tb_pntEmail.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@patient_ref", tb_pntRef.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@patient_blood_group", Convert.ToString(ddl_pntBldGrp.SelectedValue));
                    SqlComInsert.Parameters.AddWithValue("@reg_dt", tb_pntRgstDt.Text.Trim());
                    SqlComInsert.ExecuteNonQuery();
                    SqlComInsert.Connection.Close();
                    lbl_msg.Text = "Data Save successfully.....";
                    mpe.Show();
                    pnl_message.Visible = true;
                    //tc_patient_additional_data.Visible = true;

                    GridLoadNew();
                    FunClear();

                }
                else
                {
                    //update ops
                    SqlCommand SqlComInsert = new SqlCommand("UPDATE patient SET patient_name = @patient_name,patient_addrs = @patient_addrs,patient_area = @patient_area,patient_city = @patient_city,patient_pin = @patient_pin,patient_gender = @patient_gender,patient_dob = CONVERT(DATE,@patient_dob,103),patient_contact = @patient_contact,patient_email = @patient_email,patient_ref = @patient_ref,patient_blood_group = @patient_blood_group,reg_dt = CONVERT(DATE,@reg_dt,103) WHERE patient_id='" + ViewState["patient_id"] + "'", con.funCon());
                    SqlComInsert.Connection.Open();
                    //SqlComInsert.Parameters.AddWithValue("@patient_id", autoPatId);
                    if (rbl_pntGender.SelectedValue == "Male")
                    {
                        SqlComInsert.Parameters.AddWithValue("@patient_gender", rbl_pntGender.Text.Trim());
                    }
                    else if (rbl_pntGender.SelectedValue == "Female")
                    {
                        SqlComInsert.Parameters.AddWithValue("@patient_gender", rbl_pntGender.Text.Trim());
                    }
                    else
                    {
                        SqlComInsert.Parameters.AddWithValue("@patient_gender", rbl_pntGender.Text.Trim());
                    }
                    SqlComInsert.Parameters.AddWithValue("@patient_name", tb_pntName.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@patient_addrs", tb_pntAddress.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@patient_area", tb_pntArea.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@patient_city", Convert.ToString(Ddl_pntCity.SelectedValue));
                    SqlComInsert.Parameters.AddWithValue("@patient_pin", tb_pntPin.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@patient_dob", tb_pntdob.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@patient_contact", tb_pntContact.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@patient_email", tb_pntEmail.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@patient_ref", tb_pntRef.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@patient_blood_group", Convert.ToString(ddl_pntBldGrp.SelectedItem));
                    SqlComInsert.Parameters.AddWithValue("@reg_dt", tb_pntRgstDt.Text.Trim());
                    SqlComInsert.ExecuteNonQuery();
                    SqlComInsert.Connection.Close();
                    FuncGrid();
                    FunClear();

                }

            }
            catch (Exception ex)
            {

                mpe.Show();
                pnl_message.Visible = true;
                lbl_msg.Text = ex.Message;
            }
        }
        protected void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;
                //int id = Convert.ToInt32(btn.CommandArgument);

                SqlCommand cmd = new SqlCommand("SELECT patient_id,patient_name[Name],patient_addrs[Address],patient_area[Area],patient_city[City],patient_pin[Pin],patient_gender[Gender],patient_dob[D.O.B],patient_contact[Contact],patient_email[Email Id],patient_ref[Reference],patient_blood_group[Blood Group],reg_dt[Reg Date] FROM patient WHERE patient_id=@patient_id ", con.funCon());
                cmd.Connection.Open();
                cmd.Parameters.AddWithValue("@patient_id", Convert.ToInt32(btn.CommandArgument));
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                cmd.Connection.Close();
                if (dt.Rows.Count > 0)
                {
                    ViewState["patient_id"] = Convert.ToInt32(btn.CommandArgument);
                    tb_pntName.Text = Convert.ToString(dt.Rows[0]["Name"]);
                    tb_pntEmail.Text = Convert.ToString(dt.Rows[0]["Email Id"]);
                    tb_pntdob.Text = Convert.ToString(dt.Rows[0]["D.O.B"]);
                    tb_pntPin.Text = Convert.ToString(dt.Rows[0]["Pin"]);
                    tb_pntContact.Text = Convert.ToString(dt.Rows[0]["Contact"]);
                    tb_pntArea.Text = Convert.ToString(dt.Rows[0]["Area"]);
                    tb_pntRgstDt.Text = Convert.ToString(dt.Rows[0]["Reg Date"]);
                    tb_pntAddress.Text = Convert.ToString(dt.Rows[0]["Address"]);
                    Ddl_pntCity.SelectedValue = Convert.ToString(dt.Rows[0]["City"]);
                    rbl_pntGender.SelectedValue = Convert.ToString(dt.Rows[0]["Gender"]);
                    ddl_pntBldGrp.SelectedValue = Convert.ToString(dt.Rows[0]["Blood Group"]);
                    tb_pntRef.Text = Convert.ToString(dt.Rows[0]["Reference"]);
                }
                tc_patient.ActiveTabIndex = 1;



            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        protected void btn_patient_delete_Click(object sender, EventArgs e)
        {
            try
            {
                Button btnDelete = (Button)sender;
                //int delID = Convert.ToInt32(btnDelete.CommandArgument);
                SqlCommand cmdDeleteAH = new SqlCommand("DELETE FROM allergy_history WHERE patient_id='" + Convert.ToInt32(btnDelete.CommandArgument) + "'", con.funCon());
                cmdDeleteAH.Connection.Open();
                cmdDeleteAH.ExecuteNonQuery();
                cmdDeleteAH.Connection.Close();
                SqlCommand cmdDeleteMH = new SqlCommand("DELETE FROM medication_history WHERE patient_id='" + Convert.ToInt32(btnDelete.CommandArgument) + "'", con.funCon());
                cmdDeleteMH.Connection.Open();
                cmdDeleteMH.ExecuteNonQuery();
                cmdDeleteMH.Connection.Close();
                SqlCommand cmdDeleteCD = new SqlCommand("DELETE FROM cronic_disease WHERE patient_id='" + Convert.ToInt32(btnDelete.CommandArgument) + "'", con.funCon());
                cmdDeleteCD.Connection.Open();
                cmdDeleteCD.ExecuteNonQuery();
                cmdDeleteCD.Connection.Close();
                SqlCommand cmdDeletePatient = new SqlCommand("DELETE FROM patient WHERE patient_id='" + Convert.ToInt32(btnDelete.CommandArgument) + "'", con.funCon());
                cmdDeletePatient.Connection.Open();
                cmdDeletePatient.ExecuteNonQuery();
                cmdDeletePatient.Connection.Close();
                ///*grv_patientList.EditIndex = -1*/;
                FuncGrid();
            }
            catch (Exception ex)
            {
                mpe.Show();
                pnl_message.Visible = true;
                lbl_msg.Text = ex.Message;
            }
        }


        // -------------------ALLERGY EVENTS -----------------------------------------------
        protected void btn_AllergyEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;
                //int id = Convert.ToInt32(btn.CommandArgument);

                GridViewRow gRow = btn.NamingContainer as GridViewRow;
                gv_allergy.EditIndex = gRow.RowIndex;
                GridLoadNew();
                // grv_crud.EditIndex = -1;

            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void btn_Allergydelete_Click(object sender, EventArgs e)
        {
            try
            {
                Button btnDelete = (Button)sender;
                //int delId = Convert.ToInt32(btnDelete.CommandArgument);
                SqlCommand cmd = new SqlCommand("DELETE FROM allergy_history WHERE allergy_id='" + Convert.ToInt32(btnDelete.CommandArgument) + "'", con.funCon());
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                //gv_allergy.EditIndex = -1;
                GridLoadNew();

            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void btn_Allergyupdate_Click(object sender, EventArgs e)
        {
            try
            {
                Button btnUpdate = (Button)sender;
                //int updId = Convert.ToInt32(btnUpdate.CommandArgument);
                GridViewRow GridRow = btnUpdate.NamingContainer as GridViewRow;

                SqlCommand cmd = new SqlCommand("UPDATE allergy_history SET allergy =@allergy,allergy_start_dt =convert(DATE,@allergy_start_dt,103) WHERE allergy_id='" + Convert.ToInt32(btnUpdate.CommandArgument) + "'", con.funCon());
                cmd.Connection.Open();

                TextBox txt_Name = (TextBox)gv_allergy.Rows[GridRow.RowIndex].FindControl("tb_et_allergy");
                TextBox txt_date = (TextBox)gv_allergy.Rows[GridRow.RowIndex].FindControl("tb_et_allergy_start_date");


                cmd.Parameters.AddWithValue("@allergy_id", Convert.ToInt32(btnUpdate.CommandArgument));
                cmd.Parameters.AddWithValue("@allergy", txt_Name.Text.Trim());
                cmd.Parameters.AddWithValue("@allergy_start_dt", (txt_date.Text.Trim()));


                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                gv_allergy.EditIndex = -1;
                GridLoadNew();
            }
            catch (Exception)
            {

                throw;
            }

        }

        protected void btn_Allergycancel_Click(object sender, EventArgs e)
        {
            try
            {
                gv_allergy.EditIndex = -1;
                GridLoadNew();
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void btn_Allergyadd_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand SqlCom = new SqlCommand("SELECT MAX(allergy_id) FROM allergy_history", con.funCon());
                SqlCom.Connection.Open();
                int autoId = 1;
                if (SqlCom.ExecuteScalar().ToString() != "")
                {
                    autoId = Convert.ToInt32(SqlCom.ExecuteScalar()) + 1;
                }

                SqlCom.Connection.Close();

                SqlCommand cmd = new SqlCommand("INSERT INTO allergy_history (allergy_id,patient_id,allergy,allergy_start_dt) VALUES (@allergy_id,@patient_id,@allergy,convert(DATE,@allergy_start_dt,103))", con.funCon());
                cmd.Connection.Open();


                TextBox txt_all_id = (TextBox)gv_allergy.FooterRow.FindControl("tb_ft_allergy_id");
                TextBox txt_pat_id = (TextBox)gv_allergy.FooterRow.FindControl("tb_ft_allergy_patient_id");
                TextBox txt_f_allergy = (TextBox)gv_allergy.FooterRow.FindControl("tb_ft_allergy");
                TextBox txt_f_date = (TextBox)gv_allergy.FooterRow.FindControl("tb_ft_allergy_start_date");


                cmd.Parameters.AddWithValue("@allergy_id", autoId);
                cmd.Parameters.AddWithValue("@patient_id", ViewState["Id"]);
                cmd.Parameters.AddWithValue("@allergy", txt_f_allergy.Text.Trim());
                cmd.Parameters.AddWithValue("@allergy_start_dt", txt_f_date.Text.Trim());

                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                GridLoadNew();
            }
            catch (Exception)
            {

                throw;
            }
        }


        // CRONIC DISEASE EVENTS------------------------------
        protected void btn_CronicEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;
                GridViewRow gRow = btn.NamingContainer as GridViewRow;
                gv_cronicDis.EditIndex = gRow.RowIndex;
                GridLoadNew();
            }
            catch (Exception)
            {

                throw;
            }

        }

        protected void btn_CronicDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Button btnDelete = (Button)sender;
                int A = Convert.ToInt32(btnDelete.CommandArgument);
                SqlCommand cmd = new SqlCommand("DELETE FROM cronic_disease WHERE cronic_disease_id='" + Convert.ToInt32(btnDelete.CommandArgument) + "'", con.funCon());
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                GridLoadNew();
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void btn_Croniccancel_Click(object sender, EventArgs e)
        {
            try
            {
                gv_cronicDis.EditIndex = -1;
                GridLoadNew();

            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void btn_Cronicupdate_Click(object sender, EventArgs e)
        {
            try
            {
                Button btnUpdate = (Button)sender;
                GridViewRow GridRow = btnUpdate.NamingContainer as GridViewRow;

                SqlCommand cmd = new SqlCommand("UPDATE cronic_disease SET cronic_disease = @cronic_disease,cronic_disease_start_dt = convert(DATE,@cronic_disease_start_dt,103) WHERE cronic_disease_id='" + Convert.ToInt32(btnUpdate.CommandArgument) + "'", con.funCon());
                cmd.Connection.Open();

                TextBox txt_Name = (TextBox)gv_cronicDis.Rows[GridRow.RowIndex].FindControl("tb_et_CronicD");
                TextBox txt_date = (TextBox)gv_cronicDis.Rows[GridRow.RowIndex].FindControl("tb_et_CronicD_start_date");

                cmd.Parameters.AddWithValue("@cronic_disease_id", Convert.ToInt32(btnUpdate.CommandArgument));
                cmd.Parameters.AddWithValue("@cronic_disease", txt_Name.Text.Trim());
                cmd.Parameters.AddWithValue("@cronic_disease_start_dt", (txt_date.Text.Trim()));

                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                gv_cronicDis.EditIndex = -1;
                GridLoadNew();
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void btn_Cronicadd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand SqlCom = new SqlCommand("SELECT MAX(cronic_disease_id) FROM cronic_disease", con.funCon());
                SqlCom.Connection.Open();
                int autoId = 1;
                if (SqlCom.ExecuteScalar().ToString() != "")
                {
                    autoId = Convert.ToInt32(SqlCom.ExecuteScalar()) + 1;
                }

                SqlCom.Connection.Close();

                SqlCommand cmd = new SqlCommand("INSERT INTO cronic_disease(cronic_disease_id,patient_id,cronic_disease,cronic_disease_start_dt) VALUES (@cronic_disease_id,@patient_id,@cronic_disease,CONVERT(DATE,@cronic_disease_start_dt,103))", con.funCon());
                cmd.Connection.Open();


                TextBox txt_all_id = (TextBox)gv_cronicDis.FooterRow.FindControl("tb_ft_Cronic_id");
                TextBox txt_pat_id = (TextBox)gv_cronicDis.FooterRow.FindControl("tb_ft_Cronic_patient_id");
                TextBox txt_f_allergy = (TextBox)gv_cronicDis.FooterRow.FindControl("tb_ft_CronicD");
                TextBox txt_f_date = (TextBox)gv_cronicDis.FooterRow.FindControl("tb_ft_CronicD_start_date");


                cmd.Parameters.AddWithValue("@cronic_disease_id", autoId);
                cmd.Parameters.AddWithValue("@patient_id", ViewState["Id"]);
                cmd.Parameters.AddWithValue("@cronic_disease", txt_f_allergy.Text.Trim());
                cmd.Parameters.AddWithValue("@cronic_disease_start_dt", txt_f_date.Text.Trim());

                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                GridLoadNew();
            }
            catch (Exception)
            {

                throw;
            }
        }


        //----------------  MEDICATION HISTORY EVENTS----------------------

        protected void btn_HistoryEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;
                GridViewRow gRow = btn.NamingContainer as GridViewRow;
                gv_history.EditIndex = gRow.RowIndex;
                GridLoadNew();
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void btn_HistoryDelete_Click(object sender, EventArgs e)
        {
            try
            {

                Button btnDelete = (Button)sender;
                SqlCommand cmd = new SqlCommand("DELETE FROM medication_history WHERE patient_med_id='" + Convert.ToInt32(btnDelete.CommandArgument) + "'", con.funCon());
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                gv_history.EditIndex = -1;
                GridLoadNew();
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void btn_Historycancel_Click(object sender, EventArgs e)
        {
            try
            {
                gv_history.EditIndex = -1;
                GridLoadNew();
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void btn_Historyupdate_Click(object sender, EventArgs e)
        {
            try
            {
                Button btnUpdate = (Button)sender;
                GridViewRow GridRow = btnUpdate.NamingContainer as GridViewRow;

                SqlCommand cmd = new SqlCommand("UPDATE medication_history SET medicine =@medicine,frequency =@frequency WHERE patient_med_id='" + Convert.ToInt32(btnUpdate.CommandArgument) + "'", con.funCon());
                cmd.Connection.Open();

                TextBox txt_med = (TextBox)gv_history.Rows[GridRow.RowIndex].FindControl("tb_et_Medicine");
                TextBox txt_freq = (TextBox)gv_history.Rows[GridRow.RowIndex].FindControl("tb_et_Frequency");

                cmd.Parameters.AddWithValue("@patient_med_id", Convert.ToInt32(btnUpdate.CommandArgument));
                cmd.Parameters.AddWithValue("@medicine", txt_med.Text.Trim());
                cmd.Parameters.AddWithValue("@frequency", (txt_freq.Text.Trim()));

                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                gv_history.EditIndex = -1;
                GridLoadNew();
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void btn_Historyadd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand SqlCom = new SqlCommand("SELECT MAX(patient_med_id) FROM medication_history", con.funCon());
                SqlCom.Connection.Open();
                int autoId = 1;
                if (SqlCom.ExecuteScalar().ToString() != "")
                {
                    autoId = Convert.ToInt32(SqlCom.ExecuteScalar()) + 1;
                }

                SqlCom.Connection.Close();

                SqlCommand cmd = new SqlCommand("INSERT INTO medication_history (patient_med_id,patient_id,medicine,frequency) VALUES (@patient_med_id,@patient_id,@medicine,@frequency)", con.funCon());
                cmd.Connection.Open();


                TextBox txt_all_id = (TextBox)gv_history.FooterRow.FindControl("tb_ft_History_id");
                TextBox txt_pat_id = (TextBox)gv_history.FooterRow.FindControl("tb_ft_History_patient_id");
                TextBox txt_f_med = (TextBox)gv_history.FooterRow.FindControl("tb_ft_Medicine");
                TextBox txt_f_freq = (TextBox)gv_history.FooterRow.FindControl("tb_ft_Frequency");


                cmd.Parameters.AddWithValue("@patient_med_id", autoId);
                cmd.Parameters.AddWithValue("@patient_id", ViewState["Id"]);
                cmd.Parameters.AddWithValue("@medicine", txt_f_med.Text.Trim());
                cmd.Parameters.AddWithValue("@frequency", txt_f_freq.Text.Trim());

                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                GridLoadNew();
            }
            catch (Exception)
            {

                throw;
            }
        }


        //popup----------------------------------------------------------------
        protected void btn_ok_Click(object sender, EventArgs e)
        {
            mpe.Hide();
            pnl_message.Visible = false;
            tc_patient_additional_data.Visible = true;

        }
        protected void btn_Yes_Click(object sender, EventArgs e)
        {
            mpe_confi.Hide();
            pnl_confi.Visible = false;

            lbl_msg.Text = "Data Deleted successfully.....";
            mpe.Show();
            pnl_message.Visible = true;
        }
        protected void btn_cancel_Click(object sender, EventArgs e)
        {
            mpe_confi.Hide();
            pnl_confi.Visible = false;
        }
    }
}