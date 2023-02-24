using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClinicProjectWeb2Jan.PresentationLayer
{
    public partial class HomePage : System.Web.UI.Page
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

        }
    }
}