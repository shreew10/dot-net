using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace StudentDetails_WF
{
    public partial class Form1 : Form
    {
        int rollNo = 0;
        SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["gridCon"].ConnectionString);
        public Form1()
        {
            InitializeComponent();
            funClear();
            funGridFill();
        }
        void funGridFill()
        {
            SqlCommand cmd = new SqlCommand(" SELECT stud_id, stud_name, stud_city,stud_state, stud_gender, stud_subject FROM tbl_student", sqlCon);
            sqlCon.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            sqlCon.Close();
            dgv_studentDetails.DataSource = dt;
            dgv_studentDetails.Columns[2].Visible = false;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            funClear();
        }

        void funClear()
        {
            txt_rollNo.Text = "";
            txt_name.Text = "";
            cmb_city.SelectedIndex = -1;
            lst_state.SelectedIndex = -1;
            rdb_f.Checked = false;
            rdb_m.Checked = false;
            //chb_subject.ClearSelected();
            for (int i = 0; i < chb_subject.Items.Count; i++)
            {
                chb_subject.SetItemChecked(i, false);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (rollNo == 0)
                {
                    SqlCommand cmdEx = new SqlCommand("SELECT MAX(stud_id) FROM tbl_student", sqlCon);
                    sqlCon.Open();
                    int studRollNo = 1;
                    if (Convert.ToString(cmdEx.ExecuteScalar()) != "")
                    {
                        studRollNo = Convert.ToInt32(cmdEx.ExecuteScalar()) + 1;
                    }
                    sqlCon.Close();

                    //Insert operation
                    SqlCommand cmd = new SqlCommand("INSERT INTO tbl_student(stud_id, stud_name, stud_city,stud_state, stud_gender, stud_subject) VALUES (@stud_id, @stud_name, @stud_city,@stud_state, @stud_gender, @stud_subject)", sqlCon);
                    sqlCon.Open();
                    cmd.Parameters.AddWithValue("@stud_id", studRollNo);
                    cmd.Parameters.AddWithValue("@stud_name", txt_name.Text.Trim());
                    cmd.Parameters.AddWithValue("@stud_city", cmb_city.SelectedItem);
                    cmd.Parameters.AddWithValue("@stud_state", lst_state.SelectedItem);
                    if (rdb_f.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@stud_gender", rdb_f.Text.Trim());
                    }
                    else if (rdb_m.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@stud_gender", rdb_m.Text.Trim());
                    }

                    string sub = "";
                    for (int i = 0; i < chb_subject.CheckedItems.Count; i++)
                    {
                        sub += chb_subject.CheckedItems[i].ToString() + ",";
                    }
                    cmd.Parameters.AddWithValue("@stud_subject", sub);
                    cmd.ExecuteNonQuery();
                    sqlCon.Close();
                }
                else
                {
                    //update operation
                    SqlCommand cmdUpdate = new SqlCommand("UPDATE tbl_student SET stud_id=@stud_id, stud_name=@stud_name, stud_city=@stud_city,stud_state=@stud_state, stud_gender=@stud_gender, stud_subject=@stud_subject  WHERE  stud_id = '" + rollNo + "'", sqlCon);
                    sqlCon.Open();
                    cmdUpdate.Parameters.AddWithValue("@stud_id", rollNo);
                    cmdUpdate.Parameters.AddWithValue("@stud_name", txt_name.Text.Trim());
                    cmdUpdate.Parameters.AddWithValue("@stud_city", cmb_city.SelectedItem);
                    cmdUpdate.Parameters.AddWithValue("@stud_state", lst_state.SelectedItem);
                    if (rdb_f.Checked == true)
                    {
                        cmdUpdate.Parameters.AddWithValue("@stud_gender", rdb_f.Text.Trim());
                    }
                    else if (rdb_m.Checked == true)
                    {
                        cmdUpdate.Parameters.AddWithValue("@stud_gender", rdb_m.Text.Trim());
                    }

                    string sub = "";
                    for (int i = 0; i < chb_subject.CheckedItems.Count; i++)
                    {
                        sub += chb_subject.CheckedItems[i].ToString() + ",";
                    }
                    cmdUpdate.Parameters.AddWithValue("@stud_subject", sub);
                    cmdUpdate.ExecuteNonQuery();
                    sqlCon.Close();
                }

                funGridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_studentDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    //Edit operation
                    rollNo = Convert.ToInt32(dgv_studentDetails.Rows[e.RowIndex].Cells["stud_id"].Value);
                    SqlCommand cmd = new SqlCommand("SELECT stud_id, stud_name, stud_city,stud_state, stud_gender, stud_subject FROM tbl_student WHERE stud_id='" + rollNo + "'", sqlCon);
                    cmd.Connection.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    cmd.Connection.Close();
                    if (dt.Rows.Count > 0)
                    {
                        txt_rollNo.Text = Convert.ToString(dt.Rows[0]["stud_id"]);
                        txt_name.Text = Convert.ToString(dt.Rows[0]["stud_name"]);
                        cmb_city.Text = Convert.ToString(dt.Rows[0]["stud_city"]);
                        lst_state.SelectedItem = Convert.ToString(dt.Rows[0]["stud_state"]);
                        if (Convert.ToString(dt.Rows[0]["stud_gender"]) == "F")
                        {
                            rdb_f.Checked = true;
                        }
                        else
                        {
                            rdb_m.Checked = true;
                        }

                        string db_sub = Convert.ToString(dt.Rows[0]["stud_subject"]);
                        string[] arr_db_sub = db_sub.Split(',');
                        for (int i = 0; i < chb_subject.Items.Count; i++)
                        {
                            for (int j = 0; j < arr_db_sub.Length; j++)
                            {
                                if (chb_subject.Items[i].ToString() == arr_db_sub[j].ToString())
                                {
                                    chb_subject.SetItemChecked(i, true);
                                }
                            }
                        }
                    }
                }
                else if (e.ColumnIndex == 1)
                {
                    //delete operation
                    rollNo = Convert.ToInt32(dgv_studentDetails.Rows[e.RowIndex].Cells["stud_id"].Value);

                    SqlCommand cmd = new SqlCommand("DELETE FROM tbl_student WHERE stud_id='" + rollNo + "'", sqlCon);
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                    funGridFill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
