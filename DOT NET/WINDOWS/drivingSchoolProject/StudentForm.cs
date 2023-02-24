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
    public partial class StudentForm : Form
    {
        long aadharNo = 0;
        SqlConnection SqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
        public StudentForm()
        {
            InitializeComponent();
            funStudentForm();
        }

        void funStudentForm()
        {
            try
            {
                SqlCommand SqlCom = new SqlCommand("SELECT stud_aadhar_card[Aadhar Card],stud_name[Student Name],stud_joining_date[Joining Date] FROM tbl_student_details", SqlCon);
                SqlCon.Open();
                SqlDataAdapter SdA = new SqlDataAdapter(SqlCom);
                DataTable dt = new DataTable();
                SdA.Fill(dt);
                SqlCon.Close();
                dgv_student_data.DataSource = dt;
                //dgv_department.Columns[2].Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void funcClear()
        {
            try
            {
                tb_student_name.Text = "";
                tb_stud_aadhar_no.Text = "";
                tb_stud_area.Text = "";
                rb_female_student.Checked = false;
                rb_male_dtudent.Checked = false;
                dtp_stud_dob.Text = "";
                rtb_student_address.Text = "";
                cb_stud_city.SelectedIndex = -1;
                tb_stud_pan.Text = "";
                tb_stud_pincode.Text = "";
                dtp_stud_join_date.Text = "";
                cb_stud_veh_type.SelectedIndex = -1;
                tb_stud_contact.Text = "";
            }
            catch (Exception)
            {

                throw;
            }
        }


        private void btn_student_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (aadharNo == 0)
                {
                    //===========insert================
                    //SqlCommand SqlCom = new SqlCommand("SELECT MAX(mst_id) FROM  tbl_master ", SqlCon);
                    //SqlCon.Open();
                    //int count = 1;
                    //if (SqlCom.ExecuteScalar().ToString() != "")
                    //{
                    //    count = Convert.ToInt32(SqlCom.ExecuteScalar()) + 1;
                    //}

                    //SqlCon.Close();

                    SqlCommand SqlComInsert = new SqlCommand("INSERT INTO tbl_student_details (stud_aadhar_card, stud_name, stud_gender, stud_dob, stud_address, stud_area, stud_city, stud_pincode, stud_pan_card, stud_joining_date, stud_contact, vehicle_type,stud_admission,stud_ad_amount,stud_pay_type) VALUES(@stud_aadhar_card , @stud_name , @stud_gender , convert(date, @stud_dob,103) , @stud_address , @stud_area , @stud_city , @stud_pincode , @stud_pan_card ,convert(date, @stud_joining_date,103) , @stud_contact , @vehicle_type,@stud_admission,@stud_ad_amount,@stud_pay_type)", SqlCon);
                    SqlCon.Open();
                    SqlComInsert.Parameters.AddWithValue("@stud_aadhar_card", tb_stud_aadhar_no.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@stud_name", tb_student_name.Text.Trim());
                    if (rb_female_student.Checked)
                    {
                        SqlComInsert.Parameters.AddWithValue("@stud_gender", rb_female_student.Text.Trim());
                    }
                    else
                    {
                        SqlComInsert.Parameters.AddWithValue("@stud_gender", rb_male_dtudent.Text.Trim());
                    }

                    if (rb_stu_ad_no.Checked)
                    {
                        SqlComInsert.Parameters.AddWithValue("@stud_admission", rb_stu_ad_no.Text.Trim());
                    }
                    else
                    {
                        SqlComInsert.Parameters.AddWithValue("@stud_admission", rb_stu_ad_yes.Text.Trim());
                    }

                    SqlComInsert.Parameters.AddWithValue("@stud_dob", dtp_stud_dob.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@stud_address", rtb_student_address.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@stud_area", tb_stud_area.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@stud_city", Convert.ToString(cb_stud_city.SelectedItem));
                    SqlComInsert.Parameters.AddWithValue("@stud_pincode", tb_stud_pincode.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@stud_pan_card", tb_stud_pan.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@stud_joining_date", dtp_stud_join_date.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@stud_contact", tb_stud_contact.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@vehicle_type", Convert.ToString(cb_stud_veh_type.SelectedItem));
                    SqlComInsert.Parameters.AddWithValue("@stud_ad_amount", tb_stu_ad.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@stud_pay_type", Convert.ToString(cb_stu_pay.SelectedItem));

                    SqlComInsert.ExecuteNonQuery();
                    SqlCon.Close();
                    funcClear();
                    funStudentForm();
                    MessageBox.Show("Data saved succesfully");
                }
                else
                {
                    //update-----------------
                    //int a = mstId;
                    SqlCommand SqlComInsert = new SqlCommand(" UPDATE tbl_student_details SET stud_aadhar_card = @stud_aadhar_card ,stud_name = @stud_name ,stud_gender = @stud_gender ,stud_dob = convert(date, @stud_dob,103) ,stud_address = @stud_address ,stud_area = @stud_area ,stud_city = @stud_city ,stud_pincode = @stud_pincode ,stud_pan_card = @stud_pan_card ,stud_joining_date = convert(date, @stud_joining_date,103) ,stud_contact = @stud_contact ,vehicle_type = @vehicle_type,stud_admission=@stud_admission,stud_ad_amount=@stud_ad_amount,stud_pay_type=@stud_pay_type WHERE  stud_aadhar_card='" + aadharNo + "'", SqlCon);
                    SqlCon.Open();
                    SqlComInsert.Parameters.AddWithValue("@stud_aadhar_card", tb_stud_aadhar_no.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@stud_name", tb_student_name.Text.Trim());
                    if (rb_female_student.Checked)
                    {
                        SqlComInsert.Parameters.AddWithValue("@stud_gender", rb_female_student.Text.Trim());
                    }
                    else
                    {
                        SqlComInsert.Parameters.AddWithValue("@stud_gender", rb_male_dtudent.Text.Trim());
                    }
                    if (rb_stu_ad_no.Checked)
                    {
                        SqlComInsert.Parameters.AddWithValue("@stud_admission", rb_stu_ad_no.Text.Trim());
                    }
                    else
                    {
                        SqlComInsert.Parameters.AddWithValue("@stud_admission", rb_stu_ad_yes.Text.Trim());
                    }
                    SqlComInsert.Parameters.AddWithValue("@stud_dob", dtp_stud_dob.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@stud_address", rtb_student_address.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@stud_area", tb_stud_area.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@stud_city", Convert.ToString(cb_stud_city.SelectedItem));
                    SqlComInsert.Parameters.AddWithValue("@stud_pincode", tb_stud_pincode.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@stud_pan_card", tb_stud_pan.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@stud_joining_date", dtp_stud_join_date.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@stud_contact", tb_stud_contact.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@vehicle_type", Convert.ToString(cb_stud_veh_type.SelectedItem));
                    SqlComInsert.Parameters.AddWithValue("@stud_ad_amount", tb_stu_ad.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@stud_pay_type", Convert.ToString(cb_stu_pay.SelectedItem));
                    SqlComInsert.ExecuteNonQuery();
                    SqlCon.Close();
                    MessageBox.Show("Data updated Successfully");
                    funcClear();
                    funStudentForm();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_student_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    //-------edit opration----
                    aadharNo = Convert.ToInt64(dgv_student_data.Rows[e.RowIndex].Cells["Aadhar Card"].Value);

                    SqlCommand SqlCom = new SqlCommand("SELECT stud_aadhar_card,stud_name,stud_gender,stud_dob,stud_address,stud_area,stud_city,stud_pincode,stud_pan_card,stud_joining_date,stud_contact,vehicle_type,stud_admission FROM tbl_student_details WHERE  stud_aadhar_card='" + aadharNo + "'", SqlCon);
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
                        tb_stud_aadhar_no.Text = Convert.ToString(dt.Rows[0]["stud_aadhar_card"]);
                        tb_student_name.Text = Convert.ToString(dt.Rows[0]["stud_name"]);
                        if (Convert.ToString(dt.Rows[0]["stud_gender"]) == "Male")
                        {
                            rb_male_dtudent.Checked = true;
                        }
                        else
                        {
                            rb_female_student.Checked = true;
                        }

                        dtp_stud_dob.Text = Convert.ToString(dt.Rows[0]["stud_dob"]);
                        rtb_student_address.Text = Convert.ToString(dt.Rows[0]["stud_address"]);
                        tb_stud_area.Text = Convert.ToString(dt.Rows[0]["stud_area"]);
                        cb_stud_city.Text = Convert.ToString(dt.Rows[0]["stud_city"]);
                        tb_stud_pincode.Text = Convert.ToString(dt.Rows[0]["stud_pincode"]);
                        tb_stud_pan.Text = Convert.ToString(dt.Rows[0]["stud_pan_card"]);
                        dtp_stud_join_date.Text = Convert.ToString(dt.Rows[0]["stud_joining_date"]);
                        tb_stud_contact.Text = Convert.ToString(dt.Rows[0]["stud_contact"]);
                        cb_stud_veh_type.Text = Convert.ToString(dt.Rows[0]["vehicle_type"]);

                        SqlCon.Close();
                    }
                    funStudentForm();
                }
                else if (e.ColumnIndex == 1)
                {
                    DialogResult result = MessageBox.Show("Do you want to delete this record ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    //------delete opration----
                    if (result == DialogResult.Yes)
                    {
                        aadharNo = Convert.ToInt64(dgv_student_data.Rows[e.RowIndex].Cells["Aadhar Card"].Value);
                        SqlCommand SqlCom = new SqlCommand("DELETE FROM tbl_student_details WHERE stud_aadhar_card= '" + aadharNo + "'", SqlCon);
                        SqlCon.Open();
                        SqlCom.ExecuteNonQuery();
                        SqlCon.Close();
                        MessageBox.Show("DELETED SUCCESSFULLY");
                        funStudentForm();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_student_clear_Click(object sender, EventArgs e)
        {
            try
            {
                funcClear();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void rb_stu_ad_no_CheckedChanged(object sender, EventArgs e)
        {
            lbl_stu_amount.Visible = false;
            lbl_payment_type.Visible = false;
            tb_stu_ad.Visible = false;
            cb_stu_pay.Visible = false;
        }

        private void rb_stu_ad_yes_CheckedChanged(object sender, EventArgs e)
        {
            lbl_stu_amount.Visible = true;
            lbl_payment_type.Visible = true;
            tb_stu_ad.Visible = true;
            cb_stu_pay.Visible = true;
            SqlCommand SqlCom = new SqlCommand("SELECT fee_amount From tbl_master WHERE mst_id= 5", SqlCon);
            SqlCon.Open();
            SqlDataAdapter SdA = new SqlDataAdapter(SqlCom);
            DataTable dt = new DataTable();
            SdA.Fill(dt);
            tb_stu_ad.Text = Convert.ToString(dt.Rows[0][0]);
            SqlCon.Close();
        }

        private void tb_student_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
