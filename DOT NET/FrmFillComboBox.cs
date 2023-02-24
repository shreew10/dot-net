using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using System.Data.SqlClient;
using System.Configuration;
namespace WindowsFormsApplication1
{
    public partial class FrmFillComboBox : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ToString());
        DataTable dtcombo;

        public FrmFillComboBox()
        {
            InitializeComponent();
            funFillComboBox();
            cmb_student.SelectedIndex = -1;
        }

        public void funFillComboBox()
        {
            SqlCommand cmdCombo = new SqlCommand("select emp_id, emp_name from tbl_employee", conn);
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmdCombo);
            dtcombo = new DataTable();
            sda.Fill(dtcombo);
            conn.Close();
            cmb_student.DataSource = dtcombo; //data source props is used to fill data table data into combobox control
            cmb_student.DisplayMember = "emp_name";//consider as student name
            cmb_student.ValueMember = "emp_id";//consider as aadhar number
        }

        private void cmb_student_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (student) combobox text is null then it will return empty value else return selected value
            txt_aadhar_number.Text = Convert.ToString(cmb_student.SelectedValue);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            lbl_student_name.Text = Convert.ToString(cmb_student.Text);
        }
    }
}
