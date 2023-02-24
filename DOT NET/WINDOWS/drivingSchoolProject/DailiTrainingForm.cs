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
    public partial class DailiTrainingForm : Form
    {
        int trnId = 0;
        DataTable dtcombo;
        SqlConnection SqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
        public DailiTrainingForm()
        {
            InitializeComponent();
            funDlyTrn();
            funFillComboBox();
            cb_training_aadhar.SelectedIndex = -1;
            //dtp_stud_Training_date.
        }
        void funDlyTrn()
        {
            try
            {
                SqlCommand SqlCom = new SqlCommand("SELECT training_id[Training Id],training_date[Training Date],student_daily_km[Daily Kms] FROM tbl_daily_training", SqlCon);
                SqlCon.Open();
                SqlDataAdapter SdA = new SqlDataAdapter(SqlCom);
                DataTable dt = new DataTable();
                SdA.Fill(dt);
                SqlCon.Close();
                dgv_training_data.DataSource = dt;
                //dgv_department.Columns[2].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void funClearTrn()
        {
            try
            {
                tb_stud_training_id.Text = "";
                //dtp_stud_Training_date.Value = "";
                tb_stud_daily_kms.Text = "";
                cb_training_aadhar.SelectedIndex = -1;
                //dtp_stud_Training_date.CustomFormat = "dd/MM/yyyy";
                dtp_stud_Training_date.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void funFillComboBox()
        {
            SqlCommand SqlCom = new SqlCommand("SELECT stud_name,stud_aadhar_card FROM tbl_student_details", SqlCon);
            SqlCon.Open();
            SqlDataAdapter sda = new SqlDataAdapter(SqlCom);
            dtcombo = new DataTable();
            sda.Fill(dtcombo);
            SqlCon.Close();
            cb_training_aadhar.DataSource = dtcombo; //data source props is used to fill data table data into combobox control
            //cb_training_aadhar.DisplayMember = "";//consider as student name
            cb_training_aadhar.ValueMember = "stud_aadhar_card";//consider as aadhar number
        }



        private void btn_training_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (trnId == 0)
                {
                    //===========insert================
                    SqlCommand SqlCom = new SqlCommand("SELECT max(training_id) FROM tbl_daily_training", SqlCon);
                    SqlCon.Open();
                    int value = 1;
                    if (SqlCom.ExecuteScalar().ToString() != "")
                    {
                        value = Convert.ToInt32(SqlCom.ExecuteScalar()) + 1;
                    }

                    SqlCon.Close();

                    SqlCommand SqlComInsert = new SqlCommand("INSERT INTO tbl_daily_training (training_id, training_date, student_daily_km, stud_aadhar_card) VALUES(@training_id, convert(date,@training_date,103),@student_daily_km,@stud_aadhar_card)", SqlCon);
                    SqlCon.Open();
                    SqlComInsert.Parameters.AddWithValue("@training_id", value);
                    SqlComInsert.Parameters.AddWithValue("@student_daily_km", Convert.ToInt32(tb_stud_daily_kms.Text.Trim()));
                    SqlComInsert.Parameters.AddWithValue("@stud_aadhar_card", cb_training_aadhar.SelectedValue);
                    SqlComInsert.Parameters.AddWithValue("@training_date", dtp_stud_Training_date.Text);
                    //SqlComInsert.Parameters.AddWithValue("@training_date", "05/12/2022");
                    SqlComInsert.ExecuteNonQuery();
                    SqlCon.Close();
                    //clear
                    //grid display
                    funDlyTrn();
                    MessageBox.Show("Data saved succesfully");
                    funClearTrn();
                }
                else
                {
                    //update-----------------
                    int a = trnId;
                    SqlCommand SqlCom = new SqlCommand("UPDATE tbl_daily_training SET training_date =convert(date,@training_date,103) ,student_daily_km =@student_daily_km ,stud_aadhar_card =@stud_aadhar_card  WHERE training_id= '" + a + "'", SqlCon);
                    SqlCon.Open();
                    //SqlCom.Parameters.AddWithValue("@training_id", value);
                    SqlCom.Parameters.AddWithValue("@student_daily_km", (tb_stud_daily_kms.Text.Trim()));
                    SqlCom.Parameters.AddWithValue("@stud_aadhar_card", (cb_training_aadhar.SelectedValue));
                    SqlCom.Parameters.AddWithValue("@training_date", dtp_stud_Training_date.Text.Trim());
                    SqlCom.ExecuteNonQuery();
                    SqlCon.Close();
                    MessageBox.Show("Data updated Successfully");
                    funClearTrn();
                    funDlyTrn();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_training_clear_Click(object sender, EventArgs e)
        {
            try
            {
                funClearTrn();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_training_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    //-------edit opration----
                    trnId = Convert.ToInt32(dgv_training_data.Rows[e.RowIndex].Cells["Training Id"].Value);

                    SqlCommand SqlCom = new SqlCommand("SELECT training_id,training_date,student_daily_km,stud_aadhar_card FROM tbl_daily_training where training_id='" + trnId + "'", SqlCon);
                    SqlCon.Open();
                    SqlDataAdapter SdA = new SqlDataAdapter(SqlCom);
                    DataTable dt = new DataTable();
                    SdA.Fill(dt);



                    if (dt.Rows.Count > 0)
                    {
                        tb_stud_training_id.Text = Convert.ToString(dt.Rows[0]["training_id"]);
                        tb_stud_daily_kms.Text = Convert.ToString(dt.Rows[0]["student_daily_km"]);
                        cb_training_aadhar.Text = Convert.ToString(dt.Rows[0]["stud_aadhar_card"]);
                        dtp_stud_Training_date.Text = Convert.ToString(dt.Rows[0]["training_date"]);
                        SqlCon.Close();
                        funDlyTrn();
                    }
                }
                else if (e.ColumnIndex == 1)
                {
                    DialogResult result = MessageBox.Show("Do you want to delete this record ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {
                        //------delete opration----
                        trnId = Convert.ToInt32(dgv_training_data.Rows[e.RowIndex].Cells["Training Id"].Value);
                        SqlCommand SqlCom = new SqlCommand("DELETE FROM tbl_daily_training WHERE training_id='" + trnId + "'", SqlCon);
                        SqlCon.Open();
                        SqlCom.ExecuteNonQuery();
                        SqlCon.Close();
                        MessageBox.Show("DELETED SUCCESSFULLY");
                        funDlyTrn();
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void DailiTrainingForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_drving_schoolDataSet3.tbl_student_details' table. You can move, or remove it, as needed.
            this.tbl_student_detailsTableAdapter2.Fill(this.db_drving_schoolDataSet3.tbl_student_details);

        }

        private void cb_training_aadhar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
