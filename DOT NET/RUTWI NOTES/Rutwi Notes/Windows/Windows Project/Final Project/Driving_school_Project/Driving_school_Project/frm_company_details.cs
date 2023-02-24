using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Driving_school_Project
{
    public partial class frm_company_details : Form
    {
        DataTable dtCompany = new DataTable();
        SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["proCon"].ConnectionString);

        public frm_company_details()
        {
            InitializeComponent();
            funFillData();
        }
        void funClear()
        {
            txt_company_name.Text = "";
            rtb_company_add.Text = "";
            txt_company_contact.Text = "";
            txt_company_email.Text = "";
        }


        void funFillData()
        {
            SqlCommand cmd = new SqlCommand("SELECT comp_name, comp_address,comp_contact,comp_email,comp_website FROM tbl_company", sqlCon);
            cmd.Connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmd.Connection.Close();
            if (dt.Rows.Count > 0)
            {
                txt_company_name.Text = Convert.ToString(dt.Rows[0]["comp_name"]);
                rtb_company_add.Text = Convert.ToString(dt.Rows[0]["comp_address"]);
                txt_company_contact.Text = Convert.ToString(dt.Rows[0]["comp_contact"]);
                txt_company_email.Text = Convert.ToString(dt.Rows[0]["comp_email"]);
                txt_company_website.Text = Convert.ToString(dt.Rows[0]["comp_website"]);
            }
        }

        private void btn_save_company_Click(object sender, EventArgs e)
        {

            try
            {
                //funFill();
                SqlCommand cmd = new SqlCommand("SELECT comp_name, comp_address,comp_contact,comp_email,comp_website FROM tbl_company", sqlCon);
                sqlCon.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dtCompany);
                sqlCon.Close();
                if (dtCompany.Rows.Count == 0)
                {
                    //Insert Operation
                    SqlCommand cmdInsert = new SqlCommand("INSERT INTO tbl_company(comp_name,comp_address,comp_contact,comp_email,comp_website) VALUES(@comp_name,@comp_address,@comp_contact,@comp_email,@comp_website)", sqlCon);
                    sqlCon.Open();
                    cmdInsert.Parameters.AddWithValue("@comp_name", txt_company_name.Text.Trim());
                    cmdInsert.Parameters.AddWithValue("@comp_address", rtb_company_add.Text.Trim());
                    cmdInsert.Parameters.AddWithValue("@comp_contact", txt_company_contact.Text.Trim());
                    cmdInsert.Parameters.AddWithValue("@comp_email", txt_company_email.Text.Trim());
                    cmdInsert.Parameters.AddWithValue("@comp_website", txt_company_website.Text.Trim());
                    cmdInsert.ExecuteNonQuery();
                    sqlCon.Close();
                }
                else
                {
                    //Update Operation
                    SqlCommand cmdUpdate = new SqlCommand("UPDATE tbl_company SET comp_name=@comp_name,comp_address=@comp_address,comp_contact=@comp_contact,comp_email=@comp_email,comp_website=@comp_website", sqlCon);
                    sqlCon.Open();
                    cmdUpdate.Parameters.AddWithValue("@comp_name", txt_company_name.Text.Trim());
                    cmdUpdate.Parameters.AddWithValue("@comp_address", rtb_company_add.Text.Trim());
                    cmdUpdate.Parameters.AddWithValue("@comp_contact", txt_company_contact.Text.Trim());
                    cmdUpdate.Parameters.AddWithValue("@comp_email", txt_company_email.Text.Trim());
                    cmdUpdate.Parameters.AddWithValue("@comp_website", txt_company_website.Text.Trim());
                    cmdUpdate.ExecuteNonQuery();
                    sqlCon.Close();
                }
                funFillData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_clear_company_Click(object sender, EventArgs e)
        {
            funClear();
        }
    }
}
