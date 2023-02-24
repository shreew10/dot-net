using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPageAndContentPage
{
    public partial class WebContact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_save_Click(object sender, EventArgs e)
        {

        }

        protected void btn_Clear_Click(object sender, EventArgs e)
        {
            try
            {
                tb_name.Text = "";
                cbl_cars.ClearSelection();
                rbl_status.ClearSelection();
                lb_state.ClearSelection();
                rb_gender_Female.Checked = false;
                rb_gender_male.Checked = false;
                cb_accept.Checked = false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}