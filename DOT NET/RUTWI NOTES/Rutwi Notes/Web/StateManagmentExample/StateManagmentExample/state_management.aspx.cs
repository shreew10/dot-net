using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagmentExample
{
    public partial class state_management : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ViewState["ID"] = 10;
            ViewState["user_id"] = "1";
            ViewState["user_name"] = "Rutwi";

            txt_id.Text = Convert.ToString(ViewState["ID"]);
            txt_name.Text = ViewState["user_name"].ToString();
        }

        protected void btn_display_Click(object sender, EventArgs e)
        {
            //ViewState["user_id"] = "1";
            //ViewState["user_name"] = "Rutwi";

            //txt_id.Text = ViewState["user_id"].ToString();
            //txt_name.Text = ViewState["user_name"].ToString();
        }

        protected void btn_next_Click(object sender, EventArgs e)
        {
            //ViewState["user_id"] = null;
            //ViewState["user_name"] = "";
            //div_info.Visible = true;
            lbl_id.Text = Convert.ToString(ViewState["user_id"]);
            //lbl_name.Text =Convert.ToString( ViewState["user_name"]);
            Response.Redirect("state_ex.aspx");
        }
    }
}