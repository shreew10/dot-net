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
    public partial class CompanyForm : Form
    {
        DataTable dt = new DataTable();
        int a;
        SqlConnection SqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
        public CompanyForm()
        {
            InitializeComponent();
            funCompInfo();
        }


        void funcRead()
        {
            try
            {
                tb_comp_name.Enabled = false; tb_comp_name.ReadOnly = true;
                rtb_comp_add.Enabled = false; rtb_comp_add.ReadOnly = true;
                tb_comp_contact.Enabled = false; tb_comp_contact.ReadOnly = true;
                tb_email_id.Enabled = false; tb_email_id.ReadOnly = true;
                tb_comp_website.Enabled = false; tb_comp_website.ReadOnly = true;
            }
            catch (Exception)
            {

                throw;
            }
        }
        void funcUpdate()
        {
            try
            {
                tb_comp_name.Enabled = true; tb_comp_name.ReadOnly = false;
                rtb_comp_add.Enabled = true; rtb_comp_add.ReadOnly = false;
                tb_comp_contact.Enabled = true; tb_comp_contact.ReadOnly = false;
                tb_email_id.Enabled = true; tb_email_id.ReadOnly = false;
                tb_comp_website.Enabled = true; tb_comp_website.ReadOnly = false;
            }
            catch (Exception)
            {

                throw;
            }
        }
        void funcClear()
        {
            tb_comp_name.Text = "";
            tb_comp_contact.Text = "";
            tb_comp_website.Text = "";
            tb_email_id.Text = "";
            rtb_comp_add.Text = "";

        }

        void funCompInfo()
        {
            try
            {
                SqlCommand SqlCom = new SqlCommand("SELECT comp_name,comp_address,comp_contact,comp_email,comp_website FROM tbl_company", SqlCon);
                SqlCon.Open();
                SqlDataAdapter SdA = new SqlDataAdapter(SqlCom);
                DataTable dt = new DataTable();
                SdA.Fill(dt);
                a = dt.Rows.Count;
                //for (int i = 0; i < dt.Rows.Count; i++)
                //{
                //    tb_comp_name.Text = dt.Rows[i][0].ToString();
                //    rtb_comp_add.Text = dt.Rows[i][1].ToString();
                //    tb_comp_contact.Text = dt.Rows[i][2].ToString();
                //    tb_email_id.Text = dt.Rows[i][3].ToString();
                //    tb_comp_website.Text = dt.Rows[i][4].ToString();
                //}
                if (dt.Rows.Count > 0)
                {
                    tb_comp_name.Text = Convert.ToString(dt.Rows[0]["comp_name"]);
                    tb_comp_contact.Text = Convert.ToString(dt.Rows[0]["comp_contact"]);
                    tb_comp_website.Text = Convert.ToString(dt.Rows[0]["comp_website"]);
                    tb_email_id.Text = Convert.ToString(dt.Rows[0]["comp_email"]);
                    rtb_comp_add.Text = Convert.ToString(dt.Rows[0]["comp_address"]);

                }
                SqlCon.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }


        private void btn_save_company_Click(object sender, EventArgs e)
        {
            try
            {
                //if (tb_comp_name.Text == "")
                //{
                //    MessageBox.Show("Please enter Company name");
                //}
                //else if (rtb_comp_add.Text == "")
                //{
                //    MessageBox.Show("Please enter Company address");
                //}
                //else if (tb_comp_contact.Text == "")
                //{
                //    MessageBox.Show("Please enter contact number");
                //}
                //else if (tb_email_id.Text == "")
                //{
                //    MessageBox.Show("Please enter Email Id");
                //}
                //else if (tb_comp_website.Text == "")
                //{
                //    MessageBox.Show("Please enter website");
                //}

                if (a == 0)
                {
                    SqlCommand SqlComInsert = new SqlCommand("INSERT INTO tbl_company (comp_name , comp_address , comp_contact , comp_email , comp_website) VALUES(@comp_name,@comp_address,@comp_contact,@comp_email,@comp_website)", SqlCon);
                    SqlCon.Open();
                    //SqlDataAdapter SdA = new SqlDataAdapter(SqlComInsert);
                    //DataTable dt = new DataTable();
                    //SdA.Fill(dt);
                    SqlComInsert.Parameters.AddWithValue("@comp_name", tb_comp_name.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@comp_address", rtb_comp_add.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@comp_contact", tb_comp_contact.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@comp_email", tb_email_id.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@comp_website", tb_comp_website.Text.Trim());
                    SqlComInsert.ExecuteNonQuery();
                    SqlCon.Close();
                    MessageBox.Show("Data saved succesfully");
                    //funcRead();
                    funCompInfo();
                }
                else
                {
                    ////funcUpdate();
                    //SqlCommand SqlCom = new SqlCommand("truncate table tbl_company", SqlCon);
                    //SqlCon.Open();
                    //SqlCom.ExecuteNonQuery();
                    //SqlCon.Close();
                    //funcClear();
                    //MessageBox.Show("Enter new Data");

                    //funcUpdate();

                    SqlCommand SqlComInsert = new SqlCommand("UPDATE tbl_company SET comp_name = @comp_name ,comp_address = @comp_address ,comp_contact = @comp_contact ,comp_email = @comp_email ,comp_website = @comp_website", SqlCon);
                    SqlCon.Open();
                    //SqlDataAdapter SdA = new SqlDataAdapter(SqlComInsert);
                    //DataTable dt = new DataTable();
                    //SdA.Fill(dt);
                    SqlComInsert.Parameters.AddWithValue("@comp_name", tb_comp_name.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@comp_address", rtb_comp_add.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@comp_contact", tb_comp_contact.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@comp_email", tb_email_id.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@comp_website", tb_comp_website.Text.Trim());
                    SqlComInsert.ExecuteNonQuery();
                    SqlCon.Close();
                    MessageBox.Show("Data Updated succesfully");



                    //funcRead();
                    //funCompInfo();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CompanyForm_Load(object sender, EventArgs e)
        {
            //funcRead();
        }
    }
}
