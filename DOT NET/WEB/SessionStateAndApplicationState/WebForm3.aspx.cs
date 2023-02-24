using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionStateAndApplicationState
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Text = Convert.ToString(Session["id"]);
            TextBox2.Text = Convert.ToString(Session["name"]);
            TextBox3.Text = Convert.ToString(Application["id"]);
            TextBox4.Text = Convert.ToString(Application["name"]);
        }
    }
}