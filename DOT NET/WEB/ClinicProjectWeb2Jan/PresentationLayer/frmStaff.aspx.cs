using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ClinicProjectWeb2Jan.PresentationLayer
{

    public partial class frmStaff : System.Web.UI.Page
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
                    cmd = new SqlCommand("Sp_checkLoginDetails", con.funCon());
                    cmd.CommandType = CommandType.StoredProcedure;
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
            tb_stfdob.Attributes.Add("readonly", "true");
            tb_staffdoj.Attributes.Add("readonly", "true");
        }

        void FuncGrid()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT staff_id, staff_name,staff_contact,staff_aadhar,staff_work_type FROM staff", con.funCon());
                cmd.Connection.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                gv_staff.DataSource = dt;
                gv_staff.DataBind();
                cmd.Connection.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        void FunClear()
        {
            try
            {
                //tb_id.Text = "";
                tb_name.Text = "";
                tb_staffArea.Text = "";
                ddl_city.ClearSelection();
                ddl_city.SelectedIndex = -1;
                tb_pin.Text = "";
                tb_stfContact.Text = "";
                rbl_gender.ClearSelection();
                tb_stfAdhar.Text = "";
                tb_emailId.Text = "";
                tb_stfdob.Text = "";
                tb_staffdoj.Text = "";
                ddl_qualification.Text = "";
                tb_experience.Text = "";
                ddl_stfWrk.ClearSelection();
                tb_stfPass.Text = "";
                tb_address.Text = "";
            }
            catch (Exception)
            {

                throw;
            }
        }


        protected void TabContainer1_ActiveTabChanged(object sender, EventArgs e)
        {
            if (tc_1.ActiveTabIndex == 0)
            {
                FunClear();
            }

        }

        protected void btn_edit_Click(object sender, EventArgs e)
        {

            try
            {
                Button btn = (Button)sender;
                //int id = Convert.ToInt32(btn.CommandArgument);

                SqlCommand cmd = new SqlCommand("SELECT staff_id,staff_name,staff_addrs,staff_area,staff_city,staff_pin,staff_contact,staff_gender,staff_aadhar,staff_email,staff_dob,staff_doj,staff_qualification,staff_experience,staff_work_type,password FROM staff WHERE staff_id=@staff_id", con.funCon());
                cmd.Connection.Open();
                cmd.Parameters.AddWithValue("@staff_id", Convert.ToInt32(btn.CommandArgument));
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                cmd.Connection.Close();
                if (dt.Rows.Count > 0)
                {
                    ViewState["staff_id"] = Convert.ToInt32(btn.CommandArgument);
                    tb_name.Text = Convert.ToString(dt.Rows[0]["staff_name"]);
                    tb_address.Text = Convert.ToString(dt.Rows[0]["staff_addrs"]);
                    tb_staffArea.Text = Convert.ToString(dt.Rows[0]["staff_area"]);
                    ddl_city.SelectedValue = Convert.ToString(dt.Rows[0]["staff_city"]);
                    tb_pin.Text = Convert.ToString(dt.Rows[0]["staff_pin"]);
                    tb_stfContact.Text = Convert.ToString(dt.Rows[0]["staff_contact"]);
                    rbl_gender.SelectedValue = Convert.ToString(dt.Rows[0]["staff_gender"]);
                    tb_stfAdhar.Text = Convert.ToString(dt.Rows[0]["staff_aadhar"]);
                    tb_emailId.Text = Convert.ToString(dt.Rows[0]["staff_email"]);
                    tb_stfdob.Text = Convert.ToString(dt.Rows[0]["staff_dob"]);
                    tb_staffdoj.Text = Convert.ToString(dt.Rows[0]["staff_doj"]);
                    ddl_qualification.SelectedValue = Convert.ToString(dt.Rows[0]["staff_qualification"]);
                    tb_experience.Text = Convert.ToString(dt.Rows[0]["staff_experience"]);
                    ddl_stfWrk.SelectedValue = Convert.ToString(dt.Rows[0]["staff_work_type"]);
                    tb_stfPass.Text = Convert.ToString(dt.Rows[0]["password"]);
                }

                tc_1.ActiveTabIndex = 1;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        protected void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;
                SqlCommand SqlCom = new SqlCommand("DELETE FROM staff WHERE staff_id= '" + Convert.ToInt32(btn.CommandArgument) + "'", con.funCon());
                SqlCom.Connection.Open();
                SqlCom.ExecuteNonQuery();
                SqlCom.Connection.Close();

                FuncGrid();
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
                if (ViewState["staff_id"] == null)
                {

                    //Insert Ops
                    SqlCommand SqlCom = new SqlCommand("SELECT MAX(staff_id) FROM staff ", con.funCon());
                    SqlCom.Connection.Open();
                    int autoStaffNo = 1;
                    if (SqlCom.ExecuteScalar().ToString() != "")
                    {
                        autoStaffNo = Convert.ToInt32(SqlCom.ExecuteScalar()) + 1;
                    }

                    SqlCom.Connection.Close();

                    SqlCommand SqlComInsert = new SqlCommand("INSERT INTO staff (staff_id,staff_name,staff_addrs,staff_area,staff_city,staff_pin,staff_contact,staff_gender,staff_aadhar,staff_email,staff_dob,staff_doj,staff_qualification,staff_experience,staff_work_type,password) VALUES (@staff_id,@staff_name,@staff_addrs,@staff_area,@staff_city,@staff_pin,@staff_contact,@staff_gender,@staff_aadhar,@staff_email,convert(date, @staff_dob,103),convert(date, @staff_doj,103),@staff_qualification,@staff_experience,@staff_work_type,@password)", con.funCon());
                    SqlComInsert.Connection.Open();
                    SqlComInsert.Parameters.AddWithValue("@staff_id", autoStaffNo);
                    if (rbl_gender.SelectedValue == "Male")
                    {
                        SqlComInsert.Parameters.AddWithValue("@staff_gender", rbl_gender.Text.Trim());
                    }
                    else if (rbl_gender.SelectedValue == "Female")
                    {
                        SqlComInsert.Parameters.AddWithValue("@staff_gender", rbl_gender.Text.Trim());
                    }
                    else
                    {
                        SqlComInsert.Parameters.AddWithValue("@staff_gender", rbl_gender.Text.Trim());
                    }
                    SqlComInsert.Parameters.AddWithValue("@staff_name", tb_name.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@staff_addrs", tb_address.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@staff_area", tb_staffArea.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@staff_city", Convert.ToString(ddl_city.SelectedItem));
                    SqlComInsert.Parameters.AddWithValue("@staff_pin", tb_pin.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@staff_contact", tb_stfContact.Text.Trim());
                    //SqlComInsert.Parameters.AddWithValue("@staff_gender", tb_payment_aadhar.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@staff_aadhar", tb_stfAdhar.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@staff_email", tb_emailId.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@staff_dob", tb_stfdob.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@staff_doj", tb_staffdoj.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@staff_qualification", Convert.ToString(ddl_qualification.SelectedItem));
                    SqlComInsert.Parameters.AddWithValue("@staff_experience", tb_experience.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@staff_work_type", Convert.ToString(ddl_stfWrk.SelectedItem));
                    SqlComInsert.Parameters.AddWithValue("@password", tb_stfPass.Text.Trim());
                    SqlComInsert.ExecuteNonQuery();
                    SqlComInsert.Connection.Close();
                    FuncGrid();
                    FunClear();

                }
                else
                {
                    //Update Operation
                    SqlCommand SqlComInsert = new SqlCommand("UPDATE staff SET staff_name = @staff_name,staff_addrs = @staff_addrs,staff_area = @staff_area,staff_city = @staff_city,staff_pin = @staff_pin,staff_contact = @staff_contact,staff_gender = @staff_gender,staff_aadhar = @staff_aadhar,staff_email = @staff_email,staff_dob = convert(date, @staff_dob,103),staff_doj = convert(date, @staff_doj,103),staff_qualification = @staff_qualification,staff_experience = @staff_experience,staff_work_type = @staff_work_type,password = @password WHERE staff_id='" + ViewState["staff_id"] + "'", con.funCon());
                    SqlComInsert.Connection.Open();
                    //SqlComInsert.Parameters.AddWithValue("@staff_id", autoStaffNo);
                    if (rbl_gender.SelectedValue == "Male")
                    {
                        SqlComInsert.Parameters.AddWithValue("@staff_gender", rbl_gender.Text.Trim());
                    }
                    else if (rbl_gender.SelectedValue == "Female")
                    {
                        SqlComInsert.Parameters.AddWithValue("@staff_gender", rbl_gender.Text.Trim());
                    }
                    else
                    {
                        SqlComInsert.Parameters.AddWithValue("@staff_gender", rbl_gender.Text.Trim());
                    }
                    SqlComInsert.Parameters.AddWithValue("@staff_name", tb_name.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@staff_addrs", tb_address.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@staff_area", tb_staffArea.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@staff_city", Convert.ToString(ddl_city.SelectedItem));
                    SqlComInsert.Parameters.AddWithValue("@staff_pin", tb_pin.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@staff_contact", tb_stfContact.Text.Trim());
                    //SqlComInsert.Parameters.AddWithValue("@staff_gender", tb_payment_aadhar.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@staff_aadhar", tb_stfAdhar.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@staff_email", tb_emailId.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@staff_dob", tb_stfdob.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@staff_doj", tb_staffdoj.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@staff_qualification", Convert.ToString(ddl_qualification.SelectedItem));
                    SqlComInsert.Parameters.AddWithValue("@staff_experience", tb_experience.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@staff_work_type", Convert.ToString(ddl_stfWrk.SelectedItem));
                    SqlComInsert.Parameters.AddWithValue("@password", tb_stfPass.Text.Trim());
                    SqlComInsert.ExecuteNonQuery();
                    SqlComInsert.Connection.Close();
                    FuncGrid();
                    FunClear();
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

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

        protected void btn_save_test_Click(object sender, EventArgs e)
        {
            mpe_comman.Show();
            pnl_comman.Visible = true;
            lbl_message.Text = "Data saved....";
        }

        protected void btn_delete_test_Click(object sender, EventArgs e)
        {
            mpe_conf.Show();
            pnl_conf.Visible = true;

        }

        protected void btn_yes_Click(object sender, EventArgs e)
        {
            mpe_conf.Hide();
            pnl_conf.Visible = false;
            mpe_comman.Show();
            pnl_comman.Visible = true;
            lbl_message.Text = "Data deleted....";
        }

        protected void btn_no_Click(object sender, EventArgs e)
        {
            mpe_conf.Hide();
            pnl_conf.Visible = false;
        }

        protected void btn_ok_Click(object sender, EventArgs e)
        {
            mpe_comman.Hide();
            pnl_comman.Visible = false;
        }
    }
}