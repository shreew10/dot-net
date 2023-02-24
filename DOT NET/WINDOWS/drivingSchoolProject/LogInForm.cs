using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace drivingSchoolProject
{
    public partial class LogInForm : Form
    {
        AccessForm1 objAf = new AccessForm1();
        SqlConnection SqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
        public LogInForm()
        {
            InitializeComponent();
        }

        void funLogIn()
        {
            SqlCommand SqlCom = new SqlCommand("SELECT staff_aadhar_card,staff_name	staff_address,staff_city,staff_area,staff_contact,staff_pan_card,staff_gender,staff_email,staff_password FROM tbl_staff_details", SqlCon);
            SqlCon.Open();
            SqlDataAdapter SdA = new SqlDataAdapter(SqlCom);
            DataTable dt = new DataTable();
            SdA.Fill(dt);
            SqlCon.Close();
            //dgv_department.DataSource = dt;
            //dgv_department.Columns[2].Visible = false;
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_staff_email_id.Text = "";
            tb_staff_password.Text = "";
        }
        private void btn_log_in_Click(object sender, EventArgs e)
        {
            try
            {
                string staffEmail = tb_staff_email_id.Text;
                string staffPass = tb_staff_password.Text;
                if (tb_staff_email_id.Text == "")
                {
                    MessageBox.Show("PLEASE ENTER EMAIL ");
                }
                else if (tb_staff_password.Text == "")
                {
                    MessageBox.Show("PLEASE ENTER PASSWORD");
                }

                else
                {
                    //-----retrieve data from database
                    SqlCommand SqlCom = new SqlCommand("SELECT * FROM tbl_staff_details WHERE staff_email='" + staffEmail + "' AND staff_password='" + staffPass + "'", SqlCon);
                    SqlCon.Open();
                    SqlDataAdapter SdA = new SqlDataAdapter(SqlCom);
                    DataTable dt = new DataTable();
                    SdA.Fill(dt);
                    SqlCon.Close();
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("LOGIN SUCCESFULL");
                        this.Hide();
                        objAf.Show();
                    }
                    else
                    {
                        MessageBox.Show("ERROR OCCURED");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
