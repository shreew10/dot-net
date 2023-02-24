using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClinicProjectWeb2Jan
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_save_Click(object sender, EventArgs e)
        {
            mpe.Show();
            pnl_info.Visible = true;

        }
        protected void btn_next_Click(object sender, EventArgs e)
        {
            mpe.Hide();
            pnl_info.Visible = false;
        }

    }
}