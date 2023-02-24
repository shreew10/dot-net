using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QueryStringExample
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string firstName = Request.QueryString("firstName");
            //string lastName = Request.QueryString("lastName");
            Label1.Text = Request.QueryString["firstName"].ToString();
            Label2.Text = Request.QueryString["lastName"].ToString();
        }
    }
}