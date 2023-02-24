using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace GridOperation
{
    public partial class Form1 : Form
    {

        int deptId = 0;
        SqlConnection SqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
        public Form1()
        {
            InitializeComponent();
            funGridFill();
            //funDataSetEx();
        }

        void funGridFill()
        {
            SqlCommand SqlCom = new SqlCommand("SELECT DEPTNO,DNAME,LOC,CAPSIZE,DEPTSTATE,DEPTSTATUS,COMPANY FROM Dept_table", SqlCon);
            SqlCon.Open();
            SqlDataAdapter SdA = new SqlDataAdapter(SqlCom);
            DataTable dt = new DataTable();
            SdA.Fill(dt);
            SqlCon.Close();
            dgv_department.DataSource = dt;
            dgv_department.Columns[2].Visible = false;
        }
        void funDataSetEx()
        {
            SqlCommand SqlCom = new SqlCommand("SELECT DEPTNO,DNAME,LOC,CAPSIZE,DEPTSTATE,DEPTSTATUS,COMPANY FROM Dept_table", SqlCon);
            SqlCon.Open();
            SqlDataAdapter SdA = new SqlDataAdapter(SqlCom);
            DataSet ds = new DataSet();
            SdA.Fill(ds);
            SqlCon.Close();
            dgv_department.DataSource = ds;
            //dgv_department.Columns[0].Visible = false;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {


        }
        void funClear()
        {
            tb_id.Text = "";
            tb_name.Text = "";
            cb_city.SelectedIndex = -1;
            deptId = 0;
            lb_State.SelectedIndex = -1;
            rb_largeCap.Checked = false;
            rb_midcap.Checked = false;
            for (int i = 0; i < clb_company.Items.Count; i++)
            {
                clb_company.SetItemChecked(i, false);
            }
            cb_active.Checked = false;


        }

        private void btn_save_Click(object sender, EventArgs e)
        {

        }

        private void dgv_department_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    //-------edit opration----
                    deptId = Convert.ToInt32(dgv_department.Rows[e.RowIndex].Cells["DEPTNO"].Value);

                    SqlCommand SqlCom = new SqlCommand("select DEPTNO,DNAME,LOC,CAPSIZE,DEPTSTATE,DEPTSTATUS,COMPANY from Dept_table WHERE DEPTNO='" + deptId + "'", SqlCon);
                    SqlCon.Open();
                    SqlDataAdapter SdA = new SqlDataAdapter(SqlCom);
                    DataTable dt = new DataTable();
                    SdA.Fill(dt);
                    SqlCon.Close();

                    if (dt.Rows.Count > 0)
                    {
                        tb_id.Text = Convert.ToString(dt.Rows[0]["DEPTNO"]);
                        tb_name.Text = Convert.ToString(dt.Rows[0]["DNAME"]);
                        cb_city.Text = Convert.ToString(dt.Rows[0]["LOC"]);
                        if (Convert.ToString(dt.Rows[0]["CAPSIZE"]) == "MidCap")
                        {
                            rb_midcap.Checked = true;
                        }
                        else
                        {
                            rb_largeCap.Checked = true;
                        }
                        lb_State.Text = Convert.ToString(dt.Rows[0]["DEPTSTATE"]);
                        //cb_active.Checked = Convert.ToString(dt.Rows[0]["DEPTSTATUS"]);

                        string db_company = Convert.ToString(dt.Rows[0]["COMPANY"]);
                        string[] arr_db_company = db_company.Split(',');
                        for (int i = 0; i < clb_company.Items.Count; i++)
                        {
                            for (int j = 0; j < arr_db_company.Length; j++)
                            {
                                if (clb_company.Items[i].ToString() == arr_db_company[j].ToString())
                                {
                                    clb_company.SetItemChecked(i, true);
                                }
                            }
                        }

                    }

                    funGridFill();



                }
                else if (e.ColumnIndex == 1)
                {
                    //------delete opration----
                    deptId = Convert.ToInt32(dgv_department.Rows[e.RowIndex].Cells["DEPTNO"].Value);
                    SqlCommand SqlCom = new SqlCommand("DELETE Dept_table WHERE DEPTNO = '" + deptId + "'", SqlCon);
                    SqlCon.Open();
                    SqlCom.ExecuteNonQuery();
                    SqlCon.Close();
                    MessageBox.Show("DELETED SUCCESSFULLY");
                    funGridFill();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void btn_save_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (deptId == 0)
                {
                    //===========insert================
                    SqlCommand SqlCom = new SqlCommand("select MAX(DEPTNO) from Dept_table", SqlCon);
                    SqlCon.Open();
                    int count = 1;
                    if (SqlCom.ExecuteScalar().ToString() != "")
                    {
                        count = Convert.ToInt32(SqlCom.ExecuteScalar()) + 1;
                    }

                    SqlCon.Close();

                    SqlCommand SqlComInsert = new SqlCommand("INSERT INTO Dept_table(DEPTNO,DNAME,LOC,CAPSIZE,DEPTSTATE,DEPTSTATUS,COMPANY) VALUES(@DEPTNO, @DNAME, @LOC,@CAPSIZE,@DEPTSTATE,@DEPTSTATUS,@COMPANY)", SqlCon);
                    SqlCon.Open();
                    SqlComInsert.Parameters.AddWithValue("@DEPTNO", count);
                    SqlComInsert.Parameters.AddWithValue("@DNAME", tb_name.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@LOC", Convert.ToString(cb_city.SelectedItem).Trim());
                    if (rb_largeCap.Checked)
                    {
                        SqlComInsert.Parameters.AddWithValue("@CAPSIZE", rb_largeCap.Text.Trim());
                    }
                    else
                    {
                        SqlComInsert.Parameters.AddWithValue("@CAPSIZE", rb_midcap.Text.Trim());
                    }
                    SqlComInsert.Parameters.AddWithValue("@DEPTSTATE", Convert.ToString(lb_State.SelectedItem).Trim());
                    SqlComInsert.Parameters.AddWithValue("@DEPTSTATUS", cb_active.Checked.ToString().Trim());
                    string companyNames = "";
                    for (int i = 0; i < clb_company.CheckedItems.Count; i++)
                    {
                        companyNames += clb_company.CheckedItems[i].ToString() + ",";
                    }
                    SqlComInsert.Parameters.AddWithValue("@COMPANY", companyNames.Trim());
                    SqlComInsert.ExecuteNonQuery();
                    SqlCon.Close();
                    //clear
                    //grid display
                    MessageBox.Show("Data saved succesfully");
                    funClear();
                    funGridFill();
                }
                else
                {
                    //update-----------------
                    int a = deptId;
                    SqlCommand SqlCom = new SqlCommand("UPDATE  Dept_table SET DNAME=@DNAME  , LOC=@LOC WHERE DEPTNO= '" + a + "'", SqlCon);
                    SqlCon.Open();
                    SqlCom.Parameters.AddWithValue("@DNAME", tb_name.Text);
                    SqlCom.Parameters.AddWithValue("@LOC", cb_city.SelectedItem.ToString());
                    SqlCom.ExecuteNonQuery();
                    SqlCon.Close();
                    MessageBox.Show("Data updated Successfully");
                    funClear();
                    funGridFill();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btn_clear_1_Click(object sender, EventArgs e)
        {
            try
            {
                funClear();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
