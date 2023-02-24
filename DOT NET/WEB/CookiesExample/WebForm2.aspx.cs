using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CookiesExample
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie objReq = Request.Cookies["objInfo"];
            Label1.Text = objReq["id"];
            Label2.Text = objReq["Name"];
        }
    }
}