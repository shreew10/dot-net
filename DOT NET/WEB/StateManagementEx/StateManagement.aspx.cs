using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementEx
{
    public partial class StateManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_display_Click(object sender, EventArgs e)
        {
            ViewState["user_id"] = "10";
            ViewState["user_name"] = "Shree";
            ViewState["Vs"] = "Abhi";
            txt_id.Text = Convert.ToString(ViewState["user_id"]);
            txt_name.Text = Convert.ToString(ViewState["Vs"]);
            //Response.Redirect("NewWebForm1.aspx");
            hf_data.Value = Convert.ToString(txt_name.Text);
        }

        protected void btn_next_Click(object sender, EventArgs e)
        {
            div_info.Visible = true;
            lbl_id.Text = Convert.ToString(ViewState["user_id"]);
            //lbl_name.Text = Convert.ToString(ViewState["user_name"]);
            lbl_name.Text = Convert.ToString(hf_data.Value);

            //lbl_id.Text = hf_data.Value;
            //hf_data.Value = "";
            //hf_data.Value = null;
        }
    }
}