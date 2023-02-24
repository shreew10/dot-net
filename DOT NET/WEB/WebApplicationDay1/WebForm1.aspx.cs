using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationDay1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lb_state.SelectedIndex = -1;
            rb_gender_female.Checked = false;
            rb_gender_male.Checked = false;
        }

        protected void btn_yes_Click(object sender, EventArgs e)
        {
            lbl_name.Text = txt_name.Text;
            //lbl_city.Text = ddl_city.SelectedValue; // we get values of that item
            lbl_city.Text = Convert.ToString(ddl_city.SelectedItem);
            lbl_state.Text = Convert.ToString(lb_state.SelectedItem);
            lbl_status.Text = cb_status.Text.ToString();

            for (int i = 0; i < cbl_cars.Items.Count; i++)
            {
                if (cbl_cars.Items[i].Selected == true)
                {
                    lbl_cars.Text += cbl_cars.Items[i].Text + ",";
                }
            }

            if (rb_gender_female.Checked == true)
            {
                lbl_gender.Text = rb_gender_female.Text;
            }
            else if (rb_gender_male.Checked == true)
            {
                lbl_gender.Text = rb_gender_male.Text;
            }

            //if (rbl_select.SelectedValue== "1")
            //{
            //    lbl_specialization.Text = rbl_select.SelectedItem.ToString();
            //}
            //else if (rbl_select.SelectedIndex == 0)
            //{
            //    lbl_specialization.Text = rbl_select.SelectedItem.ToString();
            //}
            //else
            //{
            //    lbl_specialization.Text = rbl_select.SelectedItem.ToString();
            //}

            for (int i = 0; i < rbl_select.Items.Count; i++)
            {
                lbl_specialization.Text = rbl_select.SelectedItem.Text;
            }
            lb_state.SelectedIndex = -1;

        }

        protected void btn_no_Click(object sender, EventArgs e)
        {
            txt_name.Text = "";
            rb_gender_female.Checked = false;
            rb_gender_male.Checked = false;
            ddl_city.SelectedIndex = -1;
            lb_state.SelectedIndex = -1;
            cbl_cars.ClearSelection(); // new functiom clear selection


            //for (int i = 0; i < cbl_cars.Items.Count; i++)
            //{
            //    cbl_cars.Items[i].Selected = false;
            //}
            cb_status.Checked = false;
            rbl_select.ClearSelection();
            ddl_city.ClearSelection();
            lb_state.ClearSelection();
        }




    }
}