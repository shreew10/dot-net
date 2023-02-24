using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Driving_school_Project
{
    public partial class frm_staff_details : Form
    {
        double aadharCard = 0;
        SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["proCon"].ConnectionString);
        public frm_staff_details()
        {
            InitializeComponent();
            funClear();
            funGridFill();
        }

        void funGridFill()
        {
            SqlCommand cmd = new SqlCommand("SELECT staff_aadhar_card[Aadhar Card], staff_name[Name],staff_city[City],staff_contact[Contact], staff_gender[Gender] FROM tbl_staff_details", sqlCon);
            sqlCon.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            sqlCon.Close();
            dgv_staff_details.DataSource = dt;
            dgv_staff_details.Columns[2].Visible = false;
        }

        void funClear()
        {
            txt_staff_name.Text = "";
            rtb_staff_add.Text = "";
            txt_staff_area.Text = "";
            cmb_staff_city.SelectedIndex = -1;
            rdb_staff_gender_f.Checked = false;
            rdb_staff_gender_m.Checked = false;
            txt_staff_contact.Text = "";
            txt_staff_aadhar_no.Text = "";
            txt_staff_pan_no.Text = "";
            txt_staff_email.Text = "";
            txt_staff_password.Text = "";
        }

        private void btn_clear_clear_Click(object sender, EventArgs e)
        {
            funClear();
        }

        private void btn_save_staff_Click(object sender, EventArgs e)
        {
            try
            {
                if(aadharCard==0)
                {
                    //Insert operation
                    SqlCommand cmdInsert = new SqlCommand("INSERT INTO tbl_staff_details( staff_aadhar_card,staff_name,staff_address, staff_city,staff_area,staff_contact,staff_pan_card,staff_gender,staff_email,staff_password) Values(@staff_aadhar_card,@staff_name,@staff_address, @staff_city,@staff_area,@staff_contact,@staff_pan_card,@staff_gender,@staff_email,@staff_password)", sqlCon);
                    sqlCon.Open();
                    cmdInsert.Parameters.AddWithValue("@staff_aadhar_card", txt_staff_aadhar_no.Text.Trim());
                    cmdInsert.Parameters.AddWithValue("@staff_name", txt_staff_name.Text.Trim());
                    cmdInsert.Parameters.AddWithValue("@staff_address", rtb_staff_add.Text.Trim());
                    cmdInsert.Parameters.AddWithValue("@staff_city", cmb_staff_city.SelectedItem);
                    cmdInsert.Parameters.AddWithValue("@staff_area",txt_staff_area.Text.Trim());
                    cmdInsert.Parameters.AddWithValue("@staff_contact",txt_staff_contact.Text.Trim());
                    cmdInsert.Parameters.AddWithValue("@staff_pan_card",txt_staff_pan_no.Text.Trim());
                    if (rdb_staff_gender_f.Checked == true)
                    {
                        cmdInsert.Parameters.AddWithValue("@staff_gender", rdb_staff_gender_f.Text.Trim());
                    }
                    else if (rdb_staff_gender_m.Checked == true)
                    {
                        cmdInsert.Parameters.AddWithValue("@staff_gender", rdb_staff_gender_m.Text.Trim());
                    }
                    cmdInsert.Parameters.AddWithValue("@staff_email", txt_staff_email.Text.Trim());
                    cmdInsert.Parameters.AddWithValue("@staff_password", txt_staff_password.Text.Trim());
                    cmdInsert.ExecuteNonQuery();
                    sqlCon.Close();

                }
                else
                {
                    //Update operation
                    double a = aadharCard;
                    SqlCommand cmdUpdate = new SqlCommand("UPDATE tbl_staff_details SET staff_aadhar_card=@staff_aadhar_card, staff_name=@staff_name ,staff_address=@staff_address, staff_city=@staff_city,staff_area=@staff_area,staff_contact=@staff_contact,staff_pan_card=@staff_pan_card,staff_gender=@staff_gender,staff_email=@staff_email,staff_password=@staff_password  WHERE  staff_aadhar_card = '" + a + "'",sqlCon);
                    sqlCon.Open();
                    cmdUpdate.Parameters.AddWithValue("@staff_aadhar_card", txt_staff_aadhar_no.Text.Trim());
                    cmdUpdate.Parameters.AddWithValue("@staff_name", txt_staff_name.Text.Trim());
                    cmdUpdate.Parameters.AddWithValue("@staff_address", rtb_staff_add.Text.Trim());
                    cmdUpdate.Parameters.AddWithValue("@staff_city", cmb_staff_city.SelectedItem);
                    cmdUpdate.Parameters.AddWithValue("@staff_area", txt_staff_area.Text.Trim());
                    cmdUpdate.Parameters.AddWithValue("@staff_contact", txt_staff_contact.Text.Trim());
                    cmdUpdate.Parameters.AddWithValue("@staff_pan_card", txt_staff_pan_no.Text.Trim());
                    if (rdb_staff_gender_f.Checked == true)
                    {
                        cmdUpdate.Parameters.AddWithValue("@stud_gender", rdb_staff_gender_f.Text.Trim());
                    }
                    else if (rdb_staff_gender_m.Checked == true)
                    {
                        cmdUpdate.Parameters.AddWithValue("@stud_gender", rdb_staff_gender_m.Text.Trim());
                    }
                    cmdUpdate.Parameters.AddWithValue("@staff_email", txt_staff_email.Text.Trim());
                    cmdUpdate.Parameters.AddWithValue("@staff_password", txt_staff_password.Text.Trim());
                    cmdUpdate.ExecuteNonQuery();
                    sqlCon.Close();
                }
                funGridFill();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_staff_details_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {

                    //Edit Operation
                    aadharCard = Convert.ToDouble(dgv_staff_details.Rows[e.RowIndex].Cells["Aadhar Card"].Value);
                    SqlCommand cmdEdit = new SqlCommand("SELECT staff_aadhar_card, staff_name,staff_address,staff_city,staff_area,staff_contact,staff_pan_card, staff_gender,staff_email,staff_password FROM tbl_staff_details WHERE staff_aadhar_card='" + aadharCard + "'", sqlCon);
                    cmdEdit.Connection.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(cmdEdit);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    cmdEdit.Connection.Close();
                    if(dt.Rows.Count>0)
                    {
                        txt_staff_name.Text = Convert.ToString(dt.Rows[0]["staff_name"]);
                        rtb_staff_add.Text = Convert.ToString(dt.Rows[0]["staff_address"]);
                        txt_staff_area.Text = Convert.ToString(dt.Rows[0]["staff_area"]);
                        cmb_staff_city.Text = Convert.ToString(dt.Rows[0]["staff_city"]);
                        if (Convert.ToString(dt.Rows[0]["staff_gender"]) == "F")
                        {
                            rdb_staff_gender_f.Checked = true;
                        }
                        else
                        {
                            rdb_staff_gender_m.Checked = true;
                        }
                        txt_staff_contact.Text = Convert.ToString(dt.Rows[0]["staff_contact"]);
                        txt_staff_aadhar_no.Text = Convert.ToString(dt.Rows[0]["staff_aadhar_card"]);
                        txt_staff_pan_no.Text = Convert.ToString(dt.Rows[0]["staff_pan_card"]);
                        txt_staff_email.Text = Convert.ToString(dt.Rows[0]["staff_email"]);
                        txt_staff_password.Text = Convert.ToString(dt.Rows[0]["staff_password"]);

                    }

                }
                else if (e.ColumnIndex == 1)
                {
                    //Delete Operation
                    DialogResult result = MessageBox.Show("Do You Want To Delete This Record.?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    if (result == DialogResult.Yes)
                    {
                        aadharCard = Convert.ToDouble(dgv_staff_details.Rows[e.RowIndex].Cells["Aadhar Card"].Value);

                        SqlCommand cmdDelete = new SqlCommand("DELETE FROM tbl_staff_details WHERE staff_aadhar_card='" + aadharCard + "'", sqlCon);
                        cmdDelete.Connection.Open();
                        cmdDelete.ExecuteNonQuery();
                        cmdDelete.Connection.Close();
                        funGridFill();
                    }
                   
                   
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
