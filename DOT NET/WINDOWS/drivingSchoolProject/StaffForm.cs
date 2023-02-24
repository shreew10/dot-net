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


    public partial class StaffForm : Form
    {
        long aadharNo = 0;
        SqlConnection SqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
        public StaffForm()
        {
            InitializeComponent();
            funStaffFrm();
        }

        void funStaffFrm()
        {
            try
            {
                SqlCommand SqlCom = new SqlCommand("SELECT staff_aadhar_card[Aadhar Card],staff_name[Name],staff_email[Email Id] fROM tbl_staff_details", SqlCon);
                SqlCon.Open();
                SqlDataAdapter SdA = new SqlDataAdapter(SqlCom);
                DataTable dt = new DataTable();
                SdA.Fill(dt);
                SqlCon.Close();
                dgv_staff_data.DataSource = dt;
                //dgv_department.Columns[2].Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        void funClearStaff()
        {
            try
            {
                tb_staff_aadhar_no.Text = "";
                tb_staff_area.Text = "";
                tb_staff_contact.Text = "";
                tb_staff_email.Text = "";
                tb_staff_name.Text = "";
                tb_staff_pan.Text = "";
                tb_staff_password.Text = "";
                cb_staff_city.SelectedIndex = -1;
                rb_female_staff.Checked = false;
                rb_male_staff.Checked = false;
                rtb_staff_address.Text = "";
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btn_staff_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (aadharNo == 0)
                {
                    //===========insert================
                    //SqlCommand SqlCom = new SqlCommand("", SqlCon);
                    //SqlCon.Open();
                    //int count = 1;
                    //if (SqlCom.ExecuteScalar().ToString() != "")
                    //{
                    //    count = Convert.ToInt32(SqlCom.ExecuteScalar()) + 1;
                    //}

                    //SqlCon.Close();

                    SqlCommand SqlComInsert = new SqlCommand("INSERT INTO tbl_staff_details (staff_aadhar_card, staff_name, staff_address, staff_city, staff_area, staff_contact, staff_pan_card, staff_gender, staff_email, staff_password) VALUES (@staff_aadhar_card,@staff_name,@staff_address,@staff_city,@staff_area,@staff_contact,@staff_pan_card,@staff_gender,@staff_email,@staff_password)", SqlCon);
                    SqlCon.Open();
                    SqlComInsert.Parameters.AddWithValue("@staff_aadhar_card", tb_staff_aadhar_no.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@staff_name", tb_staff_name.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@staff_address", rtb_staff_address.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@staff_city", Convert.ToString(cb_staff_city.SelectedItem).Trim());
                    if (rb_female_staff.Checked)
                    {
                        SqlComInsert.Parameters.AddWithValue("@staff_gender", rb_female_staff.Text.Trim());
                    }
                    else
                    {
                        SqlComInsert.Parameters.AddWithValue("@staff_gender", rb_male_staff.Text.Trim());
                    }

                    SqlComInsert.Parameters.AddWithValue("@staff_area", tb_staff_area.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@staff_contact", tb_staff_contact.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@staff_pan_card", tb_staff_pan.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@staff_email", tb_staff_email.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@staff_password", tb_staff_password.Text.Trim());
                    SqlComInsert.ExecuteNonQuery();
                    SqlCon.Close();
                    //clear
                    //grid display
                    MessageBox.Show("Data saved succesfully");
                    funClearStaff();
                    funStaffFrm();

                }
                else
                {
                    //update-----------------
                    long a = aadharNo;
                    SqlCommand SqlCom = new SqlCommand("UPDATE tbl_staff_details SET staff_aadhar_card =@staff_aadhar_card, staff_name =@staff_name, staff_address =@staff_address, staff_city =@staff_city, staff_area =@staff_area, staff_contact =@staff_contact, staff_pan_card =@staff_pan_card, staff_gender =@staff_gender, staff_email =@staff_email, staff_password =@staff_password WHERE staff_aadhar_card = '" + a + "'", SqlCon);
                    SqlCon.Open();
                    SqlCom.Parameters.AddWithValue("@staff_aadhar_card", tb_staff_aadhar_no.Text.Trim());
                    SqlCom.Parameters.AddWithValue("@staff_name", tb_staff_name.Text.Trim());
                    SqlCom.Parameters.AddWithValue("@staff_address", rtb_staff_address.Text.Trim());
                    SqlCom.Parameters.AddWithValue("@staff_city", Convert.ToString(cb_staff_city.SelectedItem).Trim());
                    if (rb_female_staff.Checked)
                    {
                        SqlCom.Parameters.AddWithValue("@staff_gender", rb_female_staff.Text.Trim());
                    }
                    else
                    {
                        SqlCom.Parameters.AddWithValue("@staff_gender", rb_male_staff.Text.Trim());
                    }

                    SqlCom.Parameters.AddWithValue("@staff_area", tb_staff_area.Text.Trim());
                    SqlCom.Parameters.AddWithValue("@staff_contact", tb_staff_contact.Text.Trim());
                    SqlCom.Parameters.AddWithValue("@staff_pan_card", tb_staff_pan.Text.Trim());
                    SqlCom.Parameters.AddWithValue("@staff_email", tb_staff_email.Text.Trim());
                    SqlCom.Parameters.AddWithValue("@staff_password", tb_staff_password.Text.Trim());
                    SqlCom.ExecuteNonQuery();
                    SqlCon.Close();
                    MessageBox.Show("Data updated Successfully");
                    funClearStaff();
                    funStaffFrm();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_staff_clear_Click(object sender, EventArgs e)
        {
            funClearStaff();
        }

        private void dgv_staff_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    //-------edit opration----
                    aadharNo = Convert.ToInt64(dgv_staff_data.Rows[e.RowIndex].Cells["Aadhar Card"].Value);

                    SqlCommand SqlCom = new SqlCommand("SELECT staff_aadhar_card[Aadhar Card], staff_name, staff_address, staff_city, staff_area, staff_contact, staff_pan_card, staff_gender, staff_email, staff_password FROM tbl_staff_details where staff_aadhar_card  = '" + aadharNo + "'", SqlCon);
                    SqlCon.Open();
                    SqlDataAdapter SdA = new SqlDataAdapter(SqlCom);
                    DataTable dt = new DataTable();
                    SdA.Fill(dt);

                    //if (dt.Rows.Count == 0)
                    //{
                    //    dgv_staff_data.Rows[0].Visible = false;
                    //}

                    if (dt.Rows.Count > 0)
                    {
                        tb_staff_name.Text = Convert.ToString(dt.Rows[0]["staff_name"]);
                        tb_staff_aadhar_no.Text = Convert.ToString(dt.Rows[0]["Aadhar Card"]);
                        tb_staff_contact.Text = Convert.ToString(dt.Rows[0]["staff_contact"]);
                        tb_staff_area.Text = Convert.ToString(dt.Rows[0]["staff_area"]);
                        tb_staff_pan.Text = Convert.ToString(dt.Rows[0]["staff_pan_card"]);
                        tb_staff_email.Text = Convert.ToString(dt.Rows[0]["staff_email"]);
                        tb_staff_password.Text = Convert.ToString(dt.Rows[0]["staff_password"]);
                        if (Convert.ToString(dt.Rows[0]["staff_gender"]) == "Male")
                        {
                            rb_male_staff.Checked = true;
                        }
                        else
                        {
                            rb_female_staff.Checked = true;
                        }
                        rtb_staff_address.Text = Convert.ToString(dt.Rows[0]["staff_address"]);

                        cb_staff_city.SelectedItem = Convert.ToString(dt.Rows[0]["staff_city"]);
                        SqlCon.Close();
                    }
                    funStaffFrm();
                }
                else if (e.ColumnIndex == 1)
                {
                    DialogResult result = MessageBox.Show("Do you want to delete this record ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {
                        //------delete opration----
                        aadharNo = Convert.ToInt64(dgv_staff_data.Rows[e.RowIndex].Cells["Aadhar Card"].Value);
                        SqlCommand SqlCom = new SqlCommand("DELETE FROM tbl_staff_details WHERE staff_aadhar_card = '" + aadharNo + "'", SqlCon);
                        SqlCon.Open();
                        SqlCom.ExecuteNonQuery();
                        SqlCon.Close();
                        MessageBox.Show("DELETED SUCCESSFULLY");
                        funStaffFrm();
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




