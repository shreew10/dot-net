using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebExample
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_save_Click(object sender, EventArgs e)
        {
            lbl_name.Text = txt_name.Text;
            if(rdb_gender_f.Checked==true)
            {
                lbl_gender.Text = rdb_gender_f.Text;
            }
            else
            {
                lbl_gender.Text = rdb_gender_m.Text;
            }
            lbl_city.Text = ddl_city.Text;
            lbl_state.Text = lb_state.Text;
            for(int i=0;i<clb_subjects.Items.Count;i++)
            {
                lbl_subjects.Text += clb_subjects.Items[i].Value.ToString()+ ",";
            }
            //int a= rdb_status.Items.Count;
            //for(int i=0; i < a; i++)
            //{
                
            //}
        }

        protected void btn_clear_Click(object sender, EventArgs e)
        {
            txt_name.Text = "";
            rdb_gender_f.Checked = false;
            rdb_gender_m.Checked = false;
            ddl_city.SelectedIndex = -1;
            lb_state.SelectedIndex = -1;
            clb_subjects.ClearSelection();
            rdb_status.ClearSelection();

            //for (int i = 0; i < clb_subjects.Items.Count; i++)
            //{
            //    clb_subjects.Items[i].Selected = false;
            //}
        }
    }
}