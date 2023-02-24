using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            funDisplay();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            pnl_display_details.Visible = true;
            pnl_display_input.Visible = true;

            txt_rollNo_display.Text = txt_rollNo.Text;

            txt_name_display.Text = txt_name.Text;

            rdb_f_display.Checked = rdb_f.Checked;
            rdb_m_display.Checked = rdb_m.Checked;

            txt_city_display.Text = Convert.ToString(cmb_city.SelectedItem);

            txt_state_display.Text = Convert.ToString(lst_states.SelectedItem);
            //string subCheckedItem = "";
            for (int i = 0; i < chk_lst_subjects.CheckedItems.Count; i++)
            {
                //subCheckedItem += chk_lst_subjects.CheckedItems[i].ToString()+",";
                txt_display_subject.Text += chk_lst_subjects.CheckedItems[i].ToString() + ",";
            }

            //for (int i = 0; i < chk_lst_subjects.CheckedItems.Count; i++)
            //{
            //    subCheckedItem += chk_lst_subjects.CheckedItems[i].ToString() + ",";
            //    lbl_display_subjects.Text += chk_lst_subjects.CheckedItems[i].ToString() + ",";
            //}
            //MessageBox.Show(subCheckedItem);



            if (Convert.ToInt32(txt_marks.Text) > 40)
            {
                txt_marks_display.Text = "Pass";
            }
            else
            {
                txt_marks_display.Text = "Fail";
            }


        }
        void funDisplay()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Name");
            dt.Rows.Add(1, "Rutwi");
            dt.Rows.Add(2, "Prachi");

            dgc_details.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
