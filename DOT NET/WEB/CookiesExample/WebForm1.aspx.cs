﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CookiesExample
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie objInfo = new HttpCookie("objInfo");
            objInfo["id"] = "111";
            objInfo["Name"] = "Shree";
            Response.Cookies.Add(objInfo);
            Response.Redirect("WebForm2.aspx");
        }
    }
}