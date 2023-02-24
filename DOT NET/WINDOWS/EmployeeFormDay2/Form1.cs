using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeFormDay2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();





        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //private void panel3_Paint(object sender, PaintEventArgs e)
        //{

        //}

        private void button_save_Click(object sender, EventArgs e)
        {
            pnl_display_data.Visible = true;
            lbl_display_id.Text = lbl_id.Text;
            lbl_display_name.Text = txt_name.Text;
            lbl_display_status.Text = checkBox_status.Checked.ToString();
            //funDetails();

            //string F = rdb_f.Text;
            //string M = rdb_m.Text;
            //bool genderM = rdb_m.Checked;
            //bool genderF = rdb_f.Checked;
            //MessageBox.Show(genderF.ToString());
            //MessageBox.Show(genderM.ToString());
            //MessageBox.Show(F);


            //if (checkBox_status.Checked == true)
            //{
            //    chb_check.Checked = true;
            //}

            //if (rdb_f.Checked == true)
            //{
            //    rd_female.Checked = true;
            //}
            //if (rdb_m.Checked == true)
            //{
            //    rb_male.Checked = true;
            //}

            //-----checked property of radio button return true or false
            //string str = rdb_m.Checked.ToString();
            //string str1 = Convert.ToString(rdb_m.Checked);
            //MessageBox.Show(str);


            // -------Displaying city in label9----------
            // lbl_display_city.Text = Convert.ToString(cmb_city.SelectedItem);
            //lbl_display_city.Text = cmb_city.Text;
            // lbl_display_city.Text = cmb_city.SelectedItem.ToString();

            //int city_index = cmb_city.SelectedIndex;
            //MessageBox.Show(city_index.ToString());

            //if (cmb_city.SelectedIndex == 1)
            //{
            //    MessageBox.Show("Shree");
            //}
            //else if (cmb_city.SelectedIndex == 2)
            //{
            //    MessageBox.Show("Layton");
            //}
            //else if (cmb_city.SelectedIndex == 3)
            //{
            //    MessageBox.Show("Henri");
            //}

            //------get count-------of total cities
            //int city_count = cmb_city.Items.Count;
            //MessageBox.Show(city_count.ToString());


            //=------items and checkedItems property-----
            //int subject_count = chk_list_subject.Items.Count;

            //int subject_checked_count = chk_list_subject.CheckedItems.Count;
            ////MessageBox.Show(Convert.ToString(subject_count));

            //MessageBox.Show(Convert.ToString(subject_checked_count));

            //------accesss-----

            //for (int i = 0; i < chk_list_subject.CheckedItems.Count; i++)
            //{
            //    string subjectCheckedItem = chk_list_subject.CheckedItems[i].ToString();
            //    lbl_display_sub.Text += chk_list_subject.CheckedItems[i].ToString() + ",";
            //    //lbl_display_subject.Text = chk_list_subject.Text[i].ToString();
            //    //MessageBox.Show(subjectCheckedItem.ToString());
            //    //MessageBox.Show(lbl_display_sub.ToString());
            //}


            //string subjectItem = chk_list_subject.Items[1].ToString();
            //MessageBox.Show(subjectItem);

            //-------list box----
            //int stateCount = cmb_state.Items.Count;
            //MessageBox.Show(stateCount.ToString());
            //lbl_display_city.Text = cmb_state.SelectedItem.ToString();
            //lbl_display_city.Text = cmb_state.Text;

            //===data grid view-----
            //void funDetails()
            //{
            //    DataTable dt = new DataTable();
            //    dt.Columns.Add("Id");
            //    dt.Columns.Add("Name");
            //    dt.Rows.Add(1, "shree");
            //    dt.Rows.Add(2, "Irina");
            //    dt.Rows.Add(3, "Jack");
            //    dt.Rows.Add(4, "Henri");
            //    dt.Rows.Add(5, "Moris");
            //    dgv_details.DataSource = dt;
            //}



        }


    }
}
