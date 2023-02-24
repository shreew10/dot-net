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
    public partial class MasterDataForm : Form
    {
        int mstId = 0;
        SqlConnection SqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
        public MasterDataForm()
        {
            InitializeComponent();
            funMstrDta();
        }
        void funMstrDta()
        {
            try
            {
                SqlCommand SqlCom = new SqlCommand("SELECT mst_id[Master Id],category[Category],vehicle_type[Vehicle Type],fee_amount[fees Amount] FROM tbl_master", SqlCon);

                SqlCon.Open();
                SqlDataAdapter SdA = new SqlDataAdapter(SqlCom);
                DataTable dt = new DataTable();
                SdA.Fill(dt);
                SqlCon.Close();
                dgv_master_data.DataSource = dt;
                //dgv_department.Columns[2].Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        void funMstrClear()
        {
            tb_master_id.Text = "";
            tb_mst_fee.Text = "";
            cb_mst_category.SelectedIndex = -1;
            cb_mst_veh.SelectedIndex = -1;
            mstId = 0;

        }

        private void btn_master_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (mstId == 0)
                {
                    //===========insert================
                    SqlCommand SqlCom = new SqlCommand("SELECT MAX(mst_id) FROM  tbl_master ", SqlCon);
                    SqlCon.Open();
                    int count = 1;
                    if (SqlCom.ExecuteScalar().ToString() != "")
                    {
                        count = Convert.ToInt32(SqlCom.ExecuteScalar()) + 1;
                    }
                    SqlCon.Close();
                    SqlCommand SqlComInsert = new SqlCommand("INSERT INTO tbl_master (mst_id, category, vehicle_type, fee_amount) VALUES(@mst_id,@category,@vehicle_type,@fee_amount)", SqlCon);
                    SqlCon.Open();
                    SqlComInsert.Parameters.AddWithValue("@mst_id", count);
                    SqlComInsert.Parameters.AddWithValue("@category", Convert.ToString(cb_mst_category.SelectedItem).Trim());
                    SqlComInsert.Parameters.AddWithValue("@vehicle_type", Convert.ToString(cb_mst_veh.SelectedItem).Trim());
                    SqlComInsert.Parameters.AddWithValue("@fee_amount", tb_mst_fee.Text.Trim());
                    SqlComInsert.ExecuteNonQuery();
                    SqlCon.Close();
                    MessageBox.Show("Data saved succesfully");
                    funMstrClear();
                    funMstrDta();
                }
                else
                {
                    //update-----------------
                    //int a = mstId;
                    SqlCommand SqlCom = new SqlCommand("UPDATE tbl_master SET mst_id =@mst_id, category =@category, vehicle_type =@vehicle_type, fee_amount =@fee_amount WHERE mst_id = '" + mstId + "'", SqlCon);
                    SqlCon.Open();
                    SqlCom.Parameters.AddWithValue("@mst_id", mstId);
                    SqlCom.Parameters.AddWithValue("@category", Convert.ToString(cb_mst_category.SelectedItem).Trim());
                    SqlCom.Parameters.AddWithValue("@vehicle_type", Convert.ToString(cb_mst_veh.SelectedItem).Trim());
                    SqlCom.Parameters.AddWithValue("@fee_amount", tb_mst_fee.Text.Trim());
                    SqlCom.ExecuteNonQuery();
                    SqlCon.Close();
                    MessageBox.Show("Data updated Successfully");
                    funMstrClear();
                    funMstrDta();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_master_clear_Click(object sender, EventArgs e)
        {
            try
            {
                funMstrClear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_master_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            {
                try
                {
                    if (e.ColumnIndex == 0)
                    {
                        //-------edit opration----
                        mstId = Convert.ToInt32(dgv_master_data.Rows[e.RowIndex].Cells["Master Id"].Value);

                        SqlCommand SqlCom = new SqlCommand("SELECT mst_id,category,vehicle_type,fee_amount FROM tbl_master WHERE  mst_id='" + mstId + "'", SqlCon);
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
                            tb_master_id.Text = Convert.ToString(dt.Rows[0]["mst_id"]);
                            cb_mst_category.Text = Convert.ToString(dt.Rows[0]["category"]);
                            cb_mst_veh.Text = Convert.ToString(dt.Rows[0]["vehicle_type"]);
                            tb_mst_fee.Text = Convert.ToString(dt.Rows[0]["fee_amount"]);

                            SqlCon.Close();
                        }
                        funMstrDta();
                    }
                    else if (e.ColumnIndex == 1)
                    {
                        DialogResult result = MessageBox.Show("Do you want to delete this record ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                        //------delete opration----
                        if (result == DialogResult.Yes)
                        {
                            mstId = Convert.ToInt32(dgv_master_data.Rows[e.RowIndex].Cells["Master Id"].Value);
                            SqlCommand SqlCom = new SqlCommand("DELETE FROM tbl_master WHERE mst_id= '" + mstId + "'", SqlCon);
                            SqlCon.Open();
                            SqlCom.ExecuteNonQuery();
                            SqlCon.Close();
                            MessageBox.Show("DELETED SUCCESSFULLY");
                            funMstrDta();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
