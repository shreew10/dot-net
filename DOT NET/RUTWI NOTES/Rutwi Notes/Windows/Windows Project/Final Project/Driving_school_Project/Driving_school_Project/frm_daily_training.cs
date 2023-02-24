using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Driving_school_Project
{
    public partial class frm_daily_training : Form
    {
        int id = 0;
        SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["proCon"].ConnectionString);
        DataTable dtcombo;
        public frm_daily_training()
        {
            InitializeComponent();
            funClear();
            funGridFill();
            
        }

        public void fillComboBox()
        {
            SqlCommand cmd = new SqlCommand("SELECT stud_name, stud_aadhar_card FROM tbl_student_details", sqlCon);
            sqlCon.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            dtcombo = new DataTable();
            sda.Fill(dtcombo);
            sqlCon.Close();

            cmb_student_name.DataSource = dtcombo;
            cmb_student_name.DisplayMember = "stud_name";
            cmb_student_name.ValueMember = "stud_aadhar_card";
        }

        void funClear()
        {
            txt_training_id.Text = "";
            dt_training_date.ResetText();
            txt_daily_km.Text = "";
            txt_stud_aadhar_no.Text = "";
            cmb_student_name.SelectedIndex = -1;
        }
        
        void funGridFill()
        {
            SqlCommand cmd = new SqlCommand("SELECT training_id[Training ID],stud_name[Name],student_daily_km[Daily KM]  FROM tbl_daily_training", sqlCon);
            sqlCon.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            sqlCon.Close();
            dgv_training_details.DataSource = dt;
            dgv_training_details.Columns[2].Visible = false;
        }

        private void btn_clear_training_Click(object sender, EventArgs e)
        {
            funClear();
        }

        private void btn_save_training_Click(object sender, EventArgs e)
        {
            try
            {
                if (id==0)
                {
                    //Insert Operation
                    SqlCommand cmdEx = new SqlCommand("SELECT MAX(training_id) FROM tbl_daily_training", sqlCon);
                    sqlCon.Open();
                    int ID = 1;
                    if (Convert.ToString(cmdEx.ExecuteScalar()) != "")
                    {
                        ID = Convert.ToInt32(cmdEx.ExecuteScalar()) + 1;
                    }

                    SqlCommand cmdInsert = new SqlCommand("INSERT INTO tbl_daily_training(training_id,training_date,student_daily_km,stud_aadhar_card,stud_name) VALUES(@training_id,@training_date,@student_daily_km,@stud_aadhar_card,@stud_name)", sqlCon);
                    sqlCon.Open();
                    cmdInsert.Parameters.AddWithValue("@training_id", ID);
                    cmdInsert.Parameters.AddWithValue("@stud_name", cmb_student_name.Text.Trim());
                    cmdInsert.Parameters.AddWithValue("@stud_aadhar_card", txt_stud_aadhar_no.Text.Trim());
                    cmdInsert.Parameters.AddWithValue("@training_date", dt_training_date.Value);
                    cmdInsert.Parameters.AddWithValue("@student_daily_km", txt_daily_km.Text.Trim());
                    cmdInsert.ExecuteNonQuery();
                    sqlCon.Close();
                    funGridFill();
                }
                else
                {
                    //Update operation
                    SqlCommand cmdUpdate = new SqlCommand("UPDATE tbl_daily_training SET training_id=@training_id,training_date=@training_date,student_daily_km=@student_daily_km,stud_aadhar_card=@stud_aadhar_card,stud_name=@stud_name ", sqlCon);
                    sqlCon.Open();
                    cmdUpdate.Parameters.AddWithValue("@training_id", id);
                    cmdUpdate.Parameters.AddWithValue("@stud_name", cmb_student_name.Text.Trim());
                    cmdUpdate.Parameters.AddWithValue("@stud_aadhar_card", txt_stud_aadhar_no.Text.Trim());
                    cmdUpdate.Parameters.AddWithValue("@training_date", dt_training_date.Value);
                    cmdUpdate.Parameters.AddWithValue("@student_daily_km", txt_daily_km.Text.Trim());
                    cmdUpdate.ExecuteNonQuery();
                    sqlCon.Close();
                    funGridFill();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_training_details_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    //Edit Operation
                    id= Convert.ToInt32(dgv_training_details.Rows[e.RowIndex].Cells["Training ID"].Value);
                    SqlCommand cmdEdit = new SqlCommand("SELECT training_id, training_date, stud_aadhar_card,stud_name,student_daily_km  FROM tbl_daily_training WHERE training_id='" + id + "'", sqlCon);
                    sqlCon.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(cmdEdit);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if(dt.Rows.Count>0)
                    {
                        txt_training_id.Text = Convert.ToString(dt.Rows[0]["training_id"]);
                        txt_daily_km.Text = Convert.ToString(dt.Rows[0]["student_daily_km"]);
                        txt_stud_aadhar_no.Text = Convert.ToString(dt.Rows[0]["stud_aadhar_card"]);
                        dt_training_date.Text = Convert.ToString(dt.Rows[0]["training_date"]);
                        cmb_student_name.Text = Convert.ToString(dt.Rows[0]["stud_name"]);
                    }
                    funGridFill();


                }
                else if (e.ColumnIndex == 1)
                {
                    //Delete Operation
                    DialogResult result = MessageBox.Show("Do You Want To Delete This Result.?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    if (result == DialogResult.Yes)
                    {
                        id = Convert.ToInt32(dgv_training_details.Rows[e.RowIndex].Cells["Training ID"].Value);

                        SqlCommand cmdDelete = new SqlCommand("DELETE FROM tbl_daily_training WHERE training_id='" + id + "'", sqlCon);
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

        private void cmb_student_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_stud_aadhar_no.Text = Convert.ToString(cmb_student_name.SelectedValue);
        }
    }
}
