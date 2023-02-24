using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Driving_school_Project
{
    public partial class frm_fee_details : Form
    {
        int ID = 0;
        SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["proCon"].ConnectionString);
        public frm_fee_details()
        {
            InitializeComponent();
            funClear();
            funGridFill();
        }
        void funClear()
        {
            txt_id.Text = "";
            txt_category.Text = "";
            cmb_vehicle_type.SelectedIndex = -1;
            txt_fee_amount.Text = "";
        }

        void funGridFill()
        {
            SqlCommand cmd = new SqlCommand("SELECT mst_id[ID], category[Category], vehicle_type[Vehicle Type],fee_amount[Amount] FROM tbl_master", sqlCon);
            sqlCon.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            sqlCon.Close();
            dgv_fee_details.DataSource = dt;
            dgv_fee_details.Columns[2].Visible = false;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            funClear();
        }

        private void btn_save_fee_Click(object sender, EventArgs e)
        {
            try
            {
                if(ID==0)
                {
                    //Insert operation
                    SqlCommand cmdEx = new SqlCommand("SELECT MAX(mst_id) FROM tbl_master", sqlCon);
                    sqlCon.Open();
                    int id = 1;
                    if (Convert.ToString(cmdEx.ExecuteScalar()) != "")
                    {
                        id = Convert.ToInt32(cmdEx.ExecuteScalar()) + 1;
                    }

                    SqlCommand cmdInsert = new SqlCommand("INSERT INTO tbl_master(mst_id, category,vehicle_type,fee_amount) VALUES(@mst_id, @category,@vehicle_type,@fee_amount)", sqlCon);
                    sqlCon.Open();
                    cmdInsert.Parameters.AddWithValue("@mst_id", id);
                    cmdInsert.Parameters.AddWithValue("@category", txt_category.Text.Trim());
                    cmdInsert.Parameters.AddWithValue("@vehicle_type", cmb_vehicle_type.SelectedItem);
                    cmdInsert.Parameters.AddWithValue("@fee_amount", txt_fee_amount.Text.Trim());
                    cmdInsert.ExecuteNonQuery();
                    sqlCon.Close();


                }
                else
                {
                    //Update operation
                    SqlCommand cmdUpdate = new SqlCommand("UPDATE tbl_master SET mst_id=@mst_id, category=@category,vehicle_type=@vehicle_type,fee_amount=@fee_amount  WHERE  mst_id = '" + ID + "'", sqlCon);
                    sqlCon.Open();
                    cmdUpdate.Parameters.AddWithValue("@mst_id", ID);
                    cmdUpdate.Parameters.AddWithValue("@category", txt_category.Text.Trim());
                    cmdUpdate.Parameters.AddWithValue("@vehicle_type", cmb_vehicle_type.SelectedItem);
                    cmdUpdate.Parameters.AddWithValue("@fee_amount", txt_fee_amount.Text.Trim());
                    cmdUpdate.ExecuteNonQuery();
                    sqlCon.Close();


                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_fee_details_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.ColumnIndex==0)
                {
                    //Edit operation
                    ID = Convert.ToInt32(dgv_fee_details.Rows[e.RowIndex].Cells["ID"].Value);

                    SqlCommand cmdEdit = new SqlCommand("SELECT mst_id, category, vehicle_type ,fee_amount FROM tbl_master WHERE mst_id='" + ID + "'", sqlCon);
                    cmdEdit.Connection.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(cmdEdit);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    cmdEdit.Connection.Close();
                    if(dt.Rows.Count>0)
                    {
                        txt_id.Text = Convert.ToString(dt.Rows[0]["mst_id"]);
                        txt_category.Text = Convert.ToString(dt.Rows[0]["category"]);
                        cmb_vehicle_type.Text = Convert.ToString(dt.Rows[0]["vehicle_type"]);
                        txt_fee_amount.Text = Convert.ToString(dt.Rows[0]["fee_amount"]);
                    }

                }
                else if(e.ColumnIndex==1)
                {
                    //Delete operation
                    DialogResult result = MessageBox.Show("Do You Want To Delete This Record.?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    if (result == DialogResult.Yes)
                    {
                        ID = Convert.ToInt32(dgv_fee_details.Rows[e.RowIndex].Cells["ID"].Value);
                        SqlCommand cmdDelete = new SqlCommand("DELETE FROM tbl_master WHERE mst_id='" + ID + "'", sqlCon);
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
