

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
    public partial class frmClinic : System.Web.UI.Page
    {

        clsConnection con = new clsConnection();
        SqlCommand cmd;
        SqlDataAdapter sda;

        public void FunClear()
        {
            try
            {
                tb_name.Text = "";
                tb_address.Text = "";
                tb_area.Text = "";
                ddl_city.ClearSelection();
                tb_pin.Text = "";
                tb_contact.Text = "";
                tb_website.Text = "";
                tb_email.Text = "";
                tb_time1.Text = "";
                tb_time2.Text = "";
            }
            catch (Exception)
            {

                throw;
            }
        }

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

            //TabContainer1.ActiveTabIndex = 0;


            if (!IsPostBack)
            {


                FuncGrid();

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

        void FuncGrid()
        {
            try
            {
                SqlCommand cmd = new SqlCommand(" SELECT clinic_name,clinic_addrs,clinic_area,clinic_city,clinic_pin,clinic_contact,clinic_website,clinic_email,start_time,end_time,am_pm_start,am_pm_end,clinic_id FROM clinic_detail", con.funCon());
                cmd.Connection.Open();
                DataTable dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                cmd.Connection.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        protected void btn_update_Click(object sender, EventArgs e)
        {
            try
            {

                if (ViewState["clinic_id"] == null)
                {
                    // insert ops
                    SqlCommand SqlCom = new SqlCommand("SELECT MAX(clinic_id) FROM clinic_detail", con.funCon());
                    SqlCom.Connection.Open();
                    ViewState["clinic_id"] = 1;
                    if (SqlCom.ExecuteScalar().ToString() != "")
                    {
                        ViewState["clinic_id"] = Convert.ToInt32(SqlCom.ExecuteScalar()) + 1;
                    }

                    SqlCom.Connection.Close();

                    SqlCommand SqlComInsert = new SqlCommand("INSERT INTO clinic_detail (clinic_name,clinic_addrs,clinic_area,clinic_city,clinic_pin,clinic_contact,clinic_website,clinic_email,start_time,end_time,am_pm_start,am_pm_end,clinic_id) VALUES (@clinic_name,@clinic_addrs,@clinic_area,@clinic_city,@clinic_pin,@clinic_contact,@clinic_website,@clinic_email,@start_time,@end_time,@am_pm_start,@am_pm_end,@clinic_id)", con.funCon());
                    SqlComInsert.Connection.Open();
                    SqlComInsert.Parameters.AddWithValue("@clinic_id", ViewState["clinic_id"]);
                    SqlComInsert.Parameters.AddWithValue("@clinic_name", tb_name.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@clinic_addrs", tb_address.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@clinic_area", tb_area.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@clinic_city", Convert.ToString(ddl_city.SelectedValue));
                    SqlComInsert.Parameters.AddWithValue("@clinic_pin", tb_pin.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@clinic_contact", tb_contact.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@clinic_website", tb_website.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@clinic_email", tb_email.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@start_time", tb_time1.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@end_time", tb_time2.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@am_pm_start", Convert.ToString(ddl_am_pm_1.SelectedValue));
                    SqlComInsert.Parameters.AddWithValue("@am_pm_end", Convert.ToString(ddl_am_pm_2.SelectedValue));
                    SqlComInsert.ExecuteNonQuery();
                    SqlComInsert.Connection.Close();
                    FuncGrid();
                    FunClear();
                }
                else
                {
                    // update ops
                    //Update Operation
                    SqlCommand SqlComInsert = new SqlCommand("UPDATE clinic_detail SET clinic_name = @clinic_name,clinic_addrs = @clinic_addrs,clinic_area = @clinic_area,clinic_city = @clinic_city,clinic_pin = @clinic_pin,clinic_contact = @clinic_contact,clinic_website = @clinic_website,clinic_email = @clinic_emai ,start_time = @start_time,end_time = @end_time,am_pm_start = @am_pm_start,am_pm_end = @am_pm_end WHERE clinic_id='" + ViewState["clinic_id"] + "'", con.funCon());
                    SqlComInsert.Connection.Open();
                    SqlComInsert.Parameters.AddWithValue("@clinic_id", ViewState["clinic_id"]);
                    SqlComInsert.Parameters.AddWithValue("@clinic_name", tb_name.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@clinic_addrs", tb_address.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@clinic_area", tb_area.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@clinic_city", Convert.ToString(ddl_city.SelectedValue));
                    SqlComInsert.Parameters.AddWithValue("@clinic_pin", tb_pin.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@clinic_contact", tb_contact.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@clinic_website", tb_website.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@clinic_email", tb_email.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@start_time", tb_time1.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@end_time", tb_time2.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@am_pm_start", Convert.ToString(ddl_am_pm_1.SelectedValue));
                    SqlComInsert.Parameters.AddWithValue("@am_pm_end", Convert.ToString(ddl_am_pm_2.SelectedValue));
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
    }
}