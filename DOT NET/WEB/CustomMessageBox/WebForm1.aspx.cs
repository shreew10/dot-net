using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CustomMessageBox
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }

        }

        protected void btn_save_Click(object sender, EventArgs e)
        {
            //mpe_comman.Show();
            //pnl_comman.Visible = true;
            //lbl_message.Text = "Data saved....";

            mpe_common.Show();
            pnl_common.Visible = true;
            lbl_message.Text = "Data saved....";
        }

        protected void btn_delete_Click(object sender, EventArgs e)
        {
            //mpe_conf.Show();
            //pnl_conf.Visible = true;

            mpe_conf.Show();
            pnl_conf.Visible = true;
        }

        protected void btn_ok_Click(object sender, EventArgs e)
        {
            //mpe_comman.Hide();
            //pnl_comman.Visible = false;
            mpe_common.Hide();
            pnl_common.Visible = false;
        }

        protected void btn_yes_Click(object sender, EventArgs e)
        {
            //mpe_conf.Hide();
            //pnl_conf.Visible = false;
            //mpe_comman.Show();
            //pnl_comman.Visible = true;
            //lbl_message.Text = "Data deleted....";

            mpe_conf.Hide();
            pnl_conf.Visible = false;
            mpe_common.Show();
            pnl_common.Visible = true;
            lbl_message.Text = "Data deleted....";
        }

        protected void btn_no_Click(object sender, EventArgs e)
        {
            //mpe_conf.Hide();
            //pnl_conf.Visible = false;
            mpe_conf.Hide();
            pnl_conf.Visible = false;
        }
    }
}