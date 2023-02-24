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

namespace GridOperation_WF 
{
    public partial class Form1 : Form
    {
        int Id = 0;
        SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["gridCon"].ConnectionString);
        public Form1()
        {
            InitializeComponent();
            funClear();
            funGridFill();
        }
        void funGridFill()
        {
            SqlCommand cmd = new SqlCommand("SELECT emp_id, emp_name, emp_city, emp_contact, emp_job FROM tbl_emp", sqlCon);
            sqlCon.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            sqlCon.Close();
            dgv_emp.DataSource = dt;
            dgv_emp.Columns[2].Visible = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmdEx = new SqlCommand("SELECT MAX(emp_id) FROM tbl_emp", sqlCon);
                sqlCon.Open();
                int empId = 1;
                if (Convert.ToString(cmdEx.ExecuteScalar()) != "")
                {
                    empId = Convert.ToInt32(cmdEx.ExecuteScalar()) + 1;
                }
                sqlCon.Close();

                if (Id == 0)
                {
                    //Insert
                    SqlCommand cmd = new SqlCommand("INSERT INTO tbl_emp(emp_id,emp_name,emp_city,emp_contact,emp_job) VALUES (@emp_id, @emp_name, @emp_city, @emp_contact,@emp_job)", sqlCon);
                    sqlCon.Open();
                    cmd.Parameters.AddWithValue("@emp_id", empId);
                    cmd.Parameters.AddWithValue("@emp_name", txt_name.Text);
                    cmd.Parameters.AddWithValue("@emp_city", Convert.ToString(cmb_city.SelectedItem));
                    cmd.Parameters.AddWithValue("@emp_contact", txt_contact.Text);
                    cmd.Parameters.AddWithValue("@emp_job", txt_job.Text);
                    cmd.ExecuteNonQuery();
                    sqlCon.Close();

                }
                else
                {
                    //update 

                    SqlCommand cmdUpdate = new SqlCommand(" UPDATE tbl_emp SET emp_id=@emp_id,emp_name=@emp_name, emp_city=@emp_city,emp_contact=@emp_contact,emp_job=@emp_job  WHERE  emp_id = '" + empId + "'", sqlCon);
                    sqlCon.Open();
                    cmdUpdate.Parameters.AddWithValue("@emp_id", empId);
                    cmdUpdate.Parameters.AddWithValue("@emp_name", txt_name.Text);
                    cmdUpdate.Parameters.AddWithValue("@emp_city", Convert.ToString(cmb_city.SelectedItem));
                    cmdUpdate.Parameters.AddWithValue("@emp_contact", txt_contact.Text);
                    cmdUpdate.Parameters.AddWithValue("@emp_job", txt_job.Text);
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

        private void btn_clear_Click(object sender, EventArgs e)
        {
            funClear();
        }

        void funClear()
        {
            txt_id.Text = "";
            txt_name.Text = "";
            cmb_city.SelectedIndex = -1;
            txt_contact.Text = "";
            txt_job.Text = "";
        }

        private void dgv_emp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    //edit operation
                     Id = Convert.ToInt32(dgv_emp.Rows[e.RowIndex].Cells["emp_id"].Value);

                    SqlCommand cmd = new SqlCommand("SELECT emp_id, emp_name, emp_city, emp_contact, emp_job FROM tbl_emp WHERE emp_id='" + Id + "'", sqlCon);
                    cmd.Connection.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    cmd.Connection.Close();
                    if (dt.Rows.Count > 0)
                    {
                        txt_id.Text = Convert.ToString(dt.Rows[0]["emp_id"]);
                        txt_name.Text = Convert.ToString(dt.Rows[0]["emp_name"]);
                        cmb_city.Text = Convert.ToString(dt.Rows[0]["emp_city"]);
                        txt_contact.Text = Convert.ToString(dt.Rows[0]["emp_contact"]);
                        txt_job.Text=Convert.ToString(dt.Rows[0]["emp_job"]);
                    }

                    funGridFill();
                }
                else if (e.ColumnIndex == 1)
                {
                    //delete operation
                    int empId = Convert.ToInt32(dgv_emp.Rows[e.RowIndex].Cells["emp_id"].Value);

                    SqlCommand cmd = new SqlCommand("DELETE FROM tbl_emp WHERE emp_id='" + empId + "'", sqlCon);
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
