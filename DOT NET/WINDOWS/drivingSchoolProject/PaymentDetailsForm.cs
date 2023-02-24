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
    public partial class PaymentDetailsForm : Form
    {
        int rcptNo = 0;
        DataTable dtcombo;
        SqlConnection SqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
        public PaymentDetailsForm()
        {
            InitializeComponent();
            funPayDetails();
            funFillComboBox();
            cb_stuname_paydet.SelectedIndex = -1;

        }
        void funPayDetails()
        {
            try
            {
                SqlCommand SqlCom = new SqlCommand("SELECT reciept_no[Reciept Number],mode_of_payment[Pay Mode],amount[Amount] fROM tbl_payment_details", SqlCon);
                SqlCon.Open();
                SqlDataAdapter SdA = new SqlDataAdapter(SqlCom);
                DataTable dt = new DataTable();
                SdA.Fill(dt);
                SqlCon.Close();
                dgv_payment_data.DataSource = dt;
                //dgv_department.Columns[2].Visible = false;
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
            cb_stuname_paydet.DataSource = dtcombo; //data source props is used to fill data table data into combobox control
            cb_stuname_paydet.DisplayMember = "stud_name";//consider as student name
            cb_stuname_paydet.ValueMember = "stud_aadhar_card";//consider as aadhar number
        }



        void PayClear()
        {
            try
            {
                cb_stuname_paydet.SelectedIndex = -1;
                tb_stud_recpt_no.Text = "";
                tb_stud_cheque_no.Text = "";
                tb_stud_bank_branch.Text = "";
                tb_stud_amount.Text = "";
                rb_cash_pay.Checked = false;
                rb_cheq_pay.Checked = false;
                rb_online_pay.Checked = false;
                dtp_paydate.Text = "";
                dtp_stud_cheq_date.Text = "";
                cb_stud_bank.SelectedIndex = -1;
                tb_payment_aadhar.Text = "";
                cb_stud_fee_type.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        void clear()
        {


            lbl_amount.Visible = false;
            tb_stud_amount.Visible = false;
            lbl_bnkname.Visible = false;
            cb_stud_bank.Visible = false;
            lbl_cheqno.Visible = false;
            tb_stud_cheque_no.Visible = false;
            lbl_branchname.Visible = false;
            tb_stud_bank_branch.Visible = false;
            lbl_cheqdate.Visible = false;
            dtp_stud_cheq_date.Visible = false;

        }

        private void btn_payment_details_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (rcptNo == 0)
                {
                    //=========== insert ================
                    SqlCommand SqlCom = new SqlCommand("SELECT MAX(reciept_no) FROM  tbl_payment_details ", SqlCon);
                    SqlCon.Open();
                    int autoRcptNo = 1;
                    if (SqlCom.ExecuteScalar().ToString() != "")
                    {
                        autoRcptNo = Convert.ToInt32(SqlCom.ExecuteScalar()) + 1;
                    }

                    SqlCon.Close();

                    SqlCommand SqlComInsert = new SqlCommand("INSERT INTO tbl_payment_details (reciept_no,mode_of_payment,amount,cheque_number,cheque_date,bank_name,branch_name,fee_type,stud_aadhar_card,pay_date,student_name) VALUES(@reciept_no,@mode_of_payment,@amount,@cheque_number,CONVERT(DATE,@cheque_date,103),@bank_name,@branch_name,@fee_type,@stud_aadhar_card,CONVERT(DATE,@pay_date,103),@student_name)", SqlCon);
                    SqlCon.Open();
                    SqlComInsert.Parameters.AddWithValue("@reciept_no", autoRcptNo);
                    if (rb_cash_pay.Checked)
                    {
                        SqlComInsert.Parameters.AddWithValue("@mode_of_payment", rb_cash_pay.Text.Trim());
                    }
                    else if (rb_cheq_pay.Checked)
                    {
                        SqlComInsert.Parameters.AddWithValue("@mode_of_payment", rb_cheq_pay.Text.Trim());
                    }
                    else
                    {
                        SqlComInsert.Parameters.AddWithValue("@mode_of_payment", rb_online_pay.Text.Trim());
                    }
                    SqlComInsert.Parameters.AddWithValue("@amount", tb_stud_amount.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@cheque_number", tb_stud_cheque_no.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@cheque_date", dtp_stud_cheq_date.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@bank_name", Convert.ToString(cb_stud_bank.SelectedItem));
                    SqlComInsert.Parameters.AddWithValue("@branch_name", tb_stud_bank_branch.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@fee_type", Convert.ToString(cb_stud_fee_type.SelectedItem));
                    SqlComInsert.Parameters.AddWithValue("@stud_aadhar_card", tb_payment_aadhar.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@pay_date", dtp_paydate.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@student_name", Convert.ToString(cb_stuname_paydet.SelectedItem));



                    SqlComInsert.ExecuteNonQuery();
                    SqlCon.Close();
                    funPayDetails();
                    PayClear();
                    MessageBox.Show("Data saved succesfully");

                }
                else
                {
                    //update-----------------
                    //int a = mstId;
                    SqlCommand SqlComInsert = new SqlCommand("UPDATE tbl_payment_details SET  mode_of_payment = @mode_of_payment ,amount = @amount ,cheque_number = @cheque_number ,cheque_date = @cheque_date ,bank_name = @bank_name ,branch_name = @branch_name ,fee_type = @fee_type ,stud_aadhar_card = @stud_aadhar_card ,pay_date = @pay_date ,student_name = @student_name WHERE reciept_no= '" + rcptNo + "'", SqlCon);
                    SqlCon.Open();
                    //SqlComInsert.Parameters.AddWithValue("@reciept_no", autoRcptNo);
                    if (rb_cash_pay.Checked)
                    {
                        SqlComInsert.Parameters.AddWithValue("@mode_of_payment", rb_cash_pay.Text.Trim());
                    }
                    else if (rb_cheq_pay.Checked)
                    {
                        SqlComInsert.Parameters.AddWithValue("@mode_of_payment", rb_cheq_pay.Text.Trim());
                    }
                    else
                    {
                        SqlComInsert.Parameters.AddWithValue("@mode_of_payment", rb_online_pay.Text.Trim());
                    }
                    SqlComInsert.Parameters.AddWithValue("@amount", tb_stud_amount.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@cheque_number", tb_stud_cheque_no.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@cheque_date", dtp_stud_cheq_date.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@bank_name", Convert.ToString(cb_stud_bank.SelectedItem));
                    SqlComInsert.Parameters.AddWithValue("@branch_name", tb_stud_bank_branch.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@fee_type", Convert.ToString(cb_stud_fee_type.SelectedItem));
                    SqlComInsert.Parameters.AddWithValue("@stud_aadhar_card", tb_payment_aadhar.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@pay_date", dtp_paydate.Text.Trim());
                    SqlComInsert.Parameters.AddWithValue("@student_name", Convert.ToString(cb_stuname_paydet.SelectedItem));
                    SqlComInsert.ExecuteNonQuery();
                    SqlCon.Close();
                    MessageBox.Show("Data updated Successfully");


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rb_cash_pay_CheckedChanged(object sender, EventArgs e)
        {
            //clear();
            //lbl_amount.Visible = true;
            //tb_stud_amount.Visible = true;
            pnl_cash_amount.Visible = true;
            pnl_cheque_data.Visible = false;
            pnl_online_data.Visible = false;
            //abc. top = pnl_cash_amount.Top + pnl_cash_amount.Height
        }

        private void rb_online_pay_CheckedChanged(object sender, EventArgs e)
        {

            //clear();
            //lbl_bnkname.Visible = true;
            //cb_stud_bank.Visible = true;
            //lbl_amount.Visible = true;
            //tb_stud_amount.Visible = true;
            //lbl_cheqno.Visible = true;
            //tb_stud_cheque_no.Visible = true;
            pnl_online_data.Visible = true;
            pnl_cash_amount.Visible = false;
            pnl_cheque_data.Visible = false;
        }

        private void rb_cheq_pay_CheckedChanged(object sender, EventArgs e)
        {
            //clear();
            //lbl_cheqno.Visible = true;
            //tb_stud_cheque_no.Visible = true;
            //lbl_amount.Visible = true;
            //tb_stud_amount.Visible = true;
            //lbl_cheqdate.Visible = true;
            //dtp_stud_cheq_date.Visible = true;
            //lbl_bnkname.Visible = true;
            //cb_stud_bank.Visible = true;
            //lbl_branchname.Visible = true;
            //tb_stud_bank_branch.Visible = true;
            pnl_cheque_data.Visible = true;
            pnl_cash_amount.Visible = false;
            pnl_online_data.Visible = false;

        }

        private void btn_payment_details_clear_Click(object sender, EventArgs e)
        {
            try
            {
                PayClear();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void dgv_payment_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    //-------edit opration----
                    rcptNo = Convert.ToInt32(dgv_payment_data.Rows[e.RowIndex].Cells["Reciept Number"].Value);

                    SqlCommand SqlCom = new SqlCommand("SELECT reciept_no,mode_of_payment,amount,cheque_number,cheque_date,bank_name,branch_name,fee_type,stud_aadhar_card,pay_date,student_name FROM tbl_payment_details WHERE reciept_no='" + rcptNo + "'", SqlCon);
                    SqlCon.Open();
                    SqlDataAdapter SdA = new SqlDataAdapter(SqlCom);
                    DataTable dt = new DataTable();
                    SdA.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        tb_stud_recpt_no.Text = Convert.ToString(dt.Rows[0]["reciept_no"]);
                        tb_stud_amount.Text = Convert.ToString(dt.Rows[0]["amount"]);
                        if (Convert.ToString(dt.Rows[0]["mode_of_payment"]) == "Cash")
                        {
                            rb_cash_pay.Checked = true;
                        }
                        else if (Convert.ToString(dt.Rows[0]["mode_of_payment"]) == "Online")
                        {
                            rb_online_pay.Checked = true;
                        }
                        else
                        {
                            rb_cheq_pay.Checked = true;
                        }

                        tb_stud_cheque_no.Text = Convert.ToString(dt.Rows[0]["cheque_number"]);
                        dtp_stud_cheq_date.Text = Convert.ToString(dt.Rows[0]["cheque_date"]);
                        cb_stud_bank.Text = Convert.ToString(dt.Rows[0]["bank_name"]);
                        tb_stud_bank_branch.Text = Convert.ToString(dt.Rows[0]["branch_name"]);
                        cb_stud_fee_type.Text = Convert.ToString(dt.Rows[0]["fee_type"]);
                        tb_payment_aadhar.Text = Convert.ToString(dt.Rows[0]["stud_aadhar_card"]);
                        dtp_paydate.Text = Convert.ToString(dt.Rows[0]["pay_date"]);
                        cb_stuname_paydet.Text = Convert.ToString(dt.Rows[0]["student_name"]);
                        SqlCon.Close();
                    }
                    funPayDetails();
                }
                else if (e.ColumnIndex == 1)
                {
                    DialogResult result = MessageBox.Show("Do you want to delete this record ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    //------delete opration----
                    if (result == DialogResult.Yes)
                    {
                        rcptNo = Convert.ToInt32(dgv_payment_data.Rows[e.RowIndex].Cells["Reciept Number"].Value);
                        SqlCommand SqlCom = new SqlCommand("DELETE FROM tbl_payment_details WHERE reciept_no='" + rcptNo + "'", SqlCon);
                        SqlCon.Open();
                        SqlCom.ExecuteNonQuery();
                        SqlCon.Close();
                        MessageBox.Show("DELETED SUCCESSFULLY");
                        funPayDetails();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PaymentDetailsForm_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'db_drving_schoolDataSet.tbl_student_details' table. You can move, or remove it, as needed.
            //this.tbl_student_detailsTableAdapter.Fill(this.db_drving_schoolDataSet.tbl_student_details);
            rb_cash_pay.Checked = true;
        }

        private void cb_stuname_paydet_SelectedIndexChanged(object sender, EventArgs e)
        {

            tb_payment_aadhar.Text = Convert.ToString(cb_stuname_paydet.SelectedValue);
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void lbl_bnkname_Click(object sender, EventArgs e)
        {

        }
    }
}
