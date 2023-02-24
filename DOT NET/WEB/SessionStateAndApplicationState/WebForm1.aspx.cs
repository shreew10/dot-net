using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionStateAndApplicationState
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["id"] = "100";
            Session["name"] = "shrikant";
            Application["id"] = "25";
            Application["name"] = "Abhilasha";
            Response.Redirect("WebForm2.aspx");

            //session and datatable

        }
    }
}