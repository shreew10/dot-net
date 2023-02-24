using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClinicProjectWeb2Jan
{
    public partial class Appointment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_staff_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("StaffLogin.aspx");
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
    }
}