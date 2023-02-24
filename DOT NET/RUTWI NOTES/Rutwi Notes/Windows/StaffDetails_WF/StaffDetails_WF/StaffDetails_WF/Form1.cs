using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace StaffDetails_WF
{
    public partial class Form1 : Form
    {
        int staffId = 0;
        
        SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["staffCon"].ConnectionString);
        public Form1()
        {
            InitializeComponent();
            funClearStaff();
            funGridStaffFill();
            funGridDeptFill();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            //for staff table
            funClearStaff();
        }

        void funClearStaff()
        {
            txt_id.Text = "";
            txt_name.Text = "";
            rdb_gender_f.Checked = false;
            rdb_gender_m.Checked = false;
            txt_contact.Text = "";
            cmb_qualification.SelectedIndex = -1;
            for (int i = 0; i < chk_lst_subjects.Items.Count; i++)
            {
                chk_lst_subjects.SetItemChecked(i, false);
            }
            txt_deptNo.Text = "";
        }

        void funGridStaffFill()
        {
            //For staff table
            SqlCommand cmd = new SqlCommand("SELECT staff_id[Id], staff_name[Name], staff_gender[Gender],staff_contact[Contact],staff_qualification[Qualification], staff_subjects[Subjects], dept_no[Department No] FROM tbl_staff", sqlCon);
            sqlCon.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dtStaff = new DataTable();
            sda.Fill(dtStaff);
            sqlCon.Close();
            dgv_staff.DataSource = dtStaff;
            dgv_staff.Columns[2].Visible = false;
        }

        void funGridDeptFill()
        {
            //For department table
            SqlCommand cmd = new SqlCommand("SELECT dept_no[Department No], department_name[Department Name] FROM tbl_dept", sqlCon);
            sqlCon.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dtDept = new DataTable();
            sda.Fill(dtDept);
            sqlCon.Close();
            dgv_dept.DataSource = dtDept;

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if(staffId==0)
                {
                    //Insert operation for Staff table
                    SqlCommand cmdEx = new SqlCommand("SELECT MAX(staff_id) FROM tbl_staff", sqlCon);
                    sqlCon.Open();
                    int Id_Staff = 1;
                    if (Convert.ToString(cmdEx.ExecuteScalar()) != "")
                    {
                        Id_Staff = Convert.ToInt32(cmdEx.ExecuteScalar()) + 1;
                    }
                    sqlCon.Close();

                    SqlCommand cmdInsert = new SqlCommand("INSERT INTO tbl_staff(staff_id, staff_name, staff_gender,staff_contact,staff_qualification, staff_subjects, dept_no) VALUES(@staff_id, @staff_name, @staff_gender,@staff_contact,@staff_qualification, @staff_subjects, @dept_no) ", sqlCon);
                    sqlCon.Open();
                    cmdInsert.Parameters.AddWithValue("@staff_id", Id_Staff);
                    cmdInsert.Parameters.AddWithValue("@staff_name", txt_name.Text.Trim());
                    if (rdb_gender_f.Checked == true)
                    {
                        cmdInsert.Parameters.AddWithValue("@staff_gender", rdb_gender_f.Text.Trim());
                    }
                    else if (rdb_gender_m.Checked == true)
                    {
                        cmdInsert.Parameters.AddWithValue("@stud_gender", rdb_gender_m.Text.Trim());
                    }
                    cmdInsert.Parameters.AddWithValue("@staff_contact", txt_contact.Text.Trim());
                    cmdInsert.Parameters.AddWithValue("@staff_qualification", cmb_qualification.SelectedItem);
                    string sub = "";
                    for (int i = 0; i < chk_lst_subjects.CheckedItems.Count; i++)
                    {
                        sub += chk_lst_subjects.CheckedItems[i].ToString() + ",";
                    }
                    cmdInsert.Parameters.AddWithValue("@staff_subjects", sub);
                    cmdInsert.Parameters.AddWithValue("@dept_no", txt_deptNo.Text.Trim());
                    cmdInsert.ExecuteNonQuery();
                    sqlCon.Close();

                }
                else
                {
                    //Update operation for staff table
                    SqlCommand cmdUpdate = new SqlCommand("UPDATE tbl_staff SET staff_id=@staff_id, staff_name=@staff_name, staff_gender=@staff_gender,staff_contact=@staff_contact,staff_qualification=@staff_qualification, staff_subjects=@staff_subjects, dept_no=@dept_no  WHERE  staff_id = '" + staffId + "'", sqlCon);
                    sqlCon.Open();
                    cmdUpdate.Parameters.AddWithValue("@staff_id", staffId);
                    cmdUpdate.Parameters.AddWithValue("@staff_name", txt_name.Text.Trim());
                    if (rdb_gender_f.Checked == true)
                    {
                        cmdUpdate.Parameters.AddWithValue("@staff_gender", rdb_gender_f.Text.Trim());
                    }
                    else if (rdb_gender_m.Checked == true)
                    {
                        cmdUpdate.Parameters.AddWithValue("@stud_gender", rdb_gender_m.Text.Trim());
                    }
                    cmdUpdate.Parameters.AddWithValue("@staff_contact", txt_contact.Text.Trim());
                    cmdUpdate.Parameters.AddWithValue("@staff_qualification", cmb_qualification.SelectedItem);
                    string sub = "";
                    for (int i = 0; i < chk_lst_subjects.CheckedItems.Count; i++)
                    {
                        sub += chk_lst_subjects.CheckedItems[i].ToString() + ",";
                    }
                    cmdUpdate.Parameters.AddWithValue("@stud_subject", sub);
                    cmdUpdate.Parameters.AddWithValue("@dept_no", txt_deptNo.Text.Trim());
                    cmdUpdate.ExecuteNonQuery();
                    sqlCon.Close();
                }
                funGridStaffFill();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_staff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.ColumnIndex==0)
                {
                    //Edit operation
                    staffId = Convert.ToInt32(dgv_staff.Rows[e.RowIndex].Cells["staff_id"].Value);

                    SqlCommand cmdEdit = new SqlCommand("SELECT staff_id, staff_name, staff_gender,staff_contact,staff_qualification, staff_subjects, dept_no FROM tbl_staff WHERE staff_id='" + staffId + "'", sqlCon);
                    cmdEdit.Connection.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(cmdEdit);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    cmdEdit.Connection.Close();
                    if(dt.Rows.Count>0)
                    {
                        txt_id.Text = Convert.ToString(dt.Rows[0]["staff_id"]);
                        txt_name.Text = Convert.ToString(dt.Rows[0]["staff_name"]);
                        if (Convert.ToString(dt.Rows[0]["staff_gender"]) == "F")
                        {
                            rdb_gender_f.Checked = true;
                        }
                        else
                        {
                            rdb_gender_m.Checked = true;
                        }
                        txt_contact.Text = Convert.ToString(dt.Rows[0]["staff_contact"]);
                        cmb_qualification.Text = Convert.ToString(dt.Rows[0]["staff_qualification"]);
                        string db_sub = Convert.ToString(dt.Rows[0]["staff_subjects"]);
                        string[] arr_db_sub = db_sub.Split(',');
                        for (int i = 0; i < chk_lst_subjects.Items.Count; i++)
                        {
                            for (int j = 0; j < arr_db_sub.Length; j++)
                            {
                                if (chk_lst_subjects.Items[i].ToString() == arr_db_sub[j].ToString())
                                {
                                    chk_lst_subjects.SetItemChecked(i, true);
                                }
                            }
                        }
                        txt_deptNo.Text = Convert.ToString(dt.Rows[0]["dept_no"]);

                    }
                }
                else if(e.ColumnIndex==1)
                {
                    //Delete operation
                    staffId = Convert.ToInt32(dgv_staff.Rows[e.RowIndex].Cells["staff_id"].Value);

                    SqlCommand cmdDelete = new SqlCommand("DELETE FROM tbl_staff WHERE staff_id='" + staffId + "'", sqlCon);
                    cmdDelete.Connection.Open();
                    cmdDelete.ExecuteNonQuery();
                    cmdDelete.Connection.Close();
                    funGridStaffFill();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }      
    }
}
