using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ClinicProjectWeb2Jan
{
    public partial class StaffLogin : System.Web.UI.Page
    {
        clsConnection con = new clsConnection();
        SqlCommand cmd;
        SqlDataAdapter sda;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            //auth check// login user is valid or not //ADO
            try
            {
                cmd = new SqlCommand("SELECT COUNT(staff_id) FROM staff where staff_id=@staff_id and password=@password", con.funCon());
                cmd.Connection.Open();
                cmd.Parameters.AddWithValue("@staff_id", tb_id.Text);
                cmd.Parameters.AddWithValue("@password", tb_password.Text);
                cmd.ExecuteScalar();
                if (Convert.ToInt32(cmd.ExecuteScalar()) == 0)
                {
                    //message22
                }
                else
                {
                    Session["ID"] = tb_id.Text;
                    Session["Password"] = tb_password.Text;
                    Response.Redirect("PresentationLayer/HomePage.aspx");
                }
                cmd.Connection.Close();
            }
            catch (Exception)
            {

                throw;
            }


        }

        protected void btn_clear_Click(object sender, EventArgs e)
        {
            //clear
            tb_id.Text = "";
            tb_password.Text = "";

        }
    }
}