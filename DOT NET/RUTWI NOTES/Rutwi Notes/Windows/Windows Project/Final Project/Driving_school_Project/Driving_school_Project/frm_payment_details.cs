using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Driving_school_Project
{
    public partial class frm_payment_details : Form
    {
        int no = 0;
        SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["proCon"].ConnectionString);
        DataTable dtcombo;
        public frm_payment_details()
        {
            InitializeComponent();
            pnl_cash_details_payment.Visible = false;
            pnl_cheque_details_payment.Visible = false;
            pnl_online_details_payment.Visible = false;
            funGridFill();
            fillComboBox();

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

        void funGridFill()
        {
            SqlCommand cmd = new SqlCommand("SELECT reciept_no[Reciept No], stud_name[Name],amount[Amount],mode_of_payment[Payment Mode] FROM tbl_payment_details", sqlCon);
            sqlCon.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            sqlCon.Close();
            dgv_payment_details.DataSource = dt;
            dgv_payment_details.Columns[2].Visible = false;
        }

        void funClear()
        {
            cmb_student_name.SelectedIndex = -1;
            txt_stud_aadhar_no.Text = "";
            txt_receipt_no.Text = "";
            cmb_fee_type.SelectedIndex = -1;
            rdb_mode_of_payment_cash.Checked = false;
            rdb_mode_of_payment_cheque.Checked = false;
            rdb_mode_of_payment_online.Checked = false;
            txt_amount_adm_cash.Text = "";
            dt_paydate_cash.ResetText();
            txt_amount_adm_cheque.Text = "";
            dt_paydate_cheque.ResetText();
            txt_cheque_no.Text = "";
            dt_date_cheque.ResetText();
            cmb_bank_cheque.SelectedIndex = -1;
            txt_branch_cheque.Text = "";
            txt_amount_adm_online.Text = "";
            dt_paydate_online.ResetText();
            txt_id_online.Text = "";
            cmb_bank_online.SelectedIndex = -1;
        }

        private void btn_clear_payment_Click(object sender, EventArgs e)
        {
            funClear();
        }

        private void btn_save_payment_Click(object sender, EventArgs e)
        {
            try
            {
                if (no == 0)
                {
                    SqlCommand cmdEx = new SqlCommand("SELECT MAX(reciept_no) FROM tbl_payment_details", sqlCon);
                    sqlCon.Open();
                    int No = 1;
                    if (Convert.ToString(cmdEx.ExecuteScalar()) != "")
                    {
                        No = Convert.ToInt32(cmdEx.ExecuteScalar()) + 1;
                    }
                    //Insert operation
                    SqlCommand cmdInsert = new SqlCommand("INSERT INTO tbl_payment_details (reciept_no,mode_of_payment,amount, cheque_number, cheque_date, bank_name,branch_name, fee_type, stud_aadhar_card, stud_name,paydate) VALUES(@reciept_no,@mode_of_payment,@amount, @cheque_number, @cheque_date, @bank_name,@branch_name, @fee_type, @stud_aadhar_card, @stud_name,@paydate)", sqlCon);
                    sqlCon.Open();
                    cmdInsert.Parameters.AddWithValue("@stud_name", cmb_student_name.SelectedItem);
                    cmdInsert.Parameters.AddWithValue("@stud_aadhar_card", txt_stud_aadhar_no.Text.Trim());
                    cmdInsert.Parameters.AddWithValue("@reciept_no", No);
                    cmdInsert.Parameters.AddWithValue("@fee_type", cmb_fee_type.Text.Trim());
                    if (rdb_mode_of_payment_cash.Checked == true)
                    {
                        cmdInsert.Parameters.AddWithValue("@mode_of_payment", rdb_mode_of_payment_cash.Text.Trim());
                        cmdInsert.Parameters.AddWithValue("@paydate", dt_paydate_cash.Value);
                        cmdInsert.Parameters.AddWithValue("@amount", txt_amount_adm_cash.Text.Trim());
                    }
                    else if (rdb_mode_of_payment_cheque.Checked == true)
                    {
                        cmdInsert.Parameters.AddWithValue("@amount", txt_amount_adm_cheque.Text.Trim());
                        cmdInsert.Parameters.AddWithValue("@paydate", dt_paydate_cheque.Value);
                        cmdInsert.Parameters.AddWithValue("@cheque_number", txt_cheque_no.Text.Trim());
                        cmdInsert.Parameters.AddWithValue("@cheque_date", dt_date_cheque.Value);
                        cmdInsert.Parameters.AddWithValue("@bank_name", cmb_bank_cheque.SelectedItem);
                        cmdInsert.Parameters.AddWithValue("@branch_name", txt_branch_cheque.Text.Trim());
                    }
                    else if (rdb_mode_of_payment_online.Checked == true)
                    {
                        cmdInsert.Parameters.AddWithValue("@amount", txt_amount_adm_online.Text.Trim());
                        cmdInsert.Parameters.AddWithValue("@paydate", dt_paydate_online.Value);
                        cmdInsert.Parameters.AddWithValue("@cheque_number", txt_id_online.Text.Trim());
                        cmdInsert.Parameters.AddWithValue("@bank_name", cmb_bank_online.SelectedItem);
                    }
                    cmdInsert.ExecuteNonQuery();
                    sqlCon.Close();
                }
                else
                {
                    //update operation
                    SqlCommand cmdUpdate = new SqlCommand("UPDATE tbl_payment_details SET reciept_no=@reciept_no,mode_of_payment=@mode_of_payment,amount=@amount, cheque_number=@cheque_number, cheque_date=@cheque_date, bank_name=@bank_name,branch_name=@branch_name, fee_type=@fee_type, stud_aadhar_card=@stud_aadhar_card, stud_name=@stud_name,paydate=@paydate ", sqlCon);
                    sqlCon.Open();
                    cmdUpdate.Parameters.AddWithValue("@stud_name", cmb_student_name.SelectedItem);
                    cmdUpdate.Parameters.AddWithValue("@stud_aadhar_card", txt_stud_aadhar_no.Text.Trim());
                    cmdUpdate.Parameters.AddWithValue("@reciept_no", no);
                    cmdUpdate.Parameters.AddWithValue("@fee_type", cmb_fee_type.Text.Trim());
                    if (rdb_mode_of_payment_cash.Checked == true)
                    {
                        cmdUpdate.Parameters.AddWithValue("@mode_of_payment", rdb_mode_of_payment_cash.Text.Trim());
                        cmdUpdate.Parameters.AddWithValue("@paydate", dt_paydate_cash.Value);
                        cmdUpdate.Parameters.AddWithValue("@amount", txt_amount_adm_cash.Text.Trim());
                    }
                    else if (rdb_mode_of_payment_cheque.Checked == true)
                    {
                        cmdUpdate.Parameters.AddWithValue("@amount", txt_amount_adm_cheque.Text.Trim());
                        cmdUpdate.Parameters.AddWithValue("@paydate", dt_paydate_cheque.Value);
                        cmdUpdate.Parameters.AddWithValue("@cheque_number", txt_cheque_no.Text.Trim());
                        cmdUpdate.Parameters.AddWithValue("@cheque_date", dt_date_cheque.Value);
                        cmdUpdate.Parameters.AddWithValue("@bank_name", cmb_bank_cheque.SelectedItem);
                        cmdUpdate.Parameters.AddWithValue("@branch_name", txt_branch_cheque.Text.Trim());
                    }
                    else if (rdb_mode_of_payment_online.Checked == true)
                    {
                        cmdUpdate.Parameters.AddWithValue("@amount", txt_amount_adm_online.Text.Trim());
                        cmdUpdate.Parameters.AddWithValue("@paydate", dt_paydate_online.Value);
                        cmdUpdate.Parameters.AddWithValue("@cheque_number", txt_id_online.Text.Trim());
                        cmdUpdate.Parameters.AddWithValue("@bank_name", cmb_bank_online.SelectedItem);
                    }
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

        private void rdb_mode_of_payment_cash_CheckedChanged(object sender, EventArgs e)
        {
            pnl_cash_details_payment.Visible = true;
            pnl_cheque_details_payment.Visible = false;
            pnl_online_details_payment.Visible = false;
            pnl_cash_details_payment.Top = 300;
            pnl_cash_details_payment.Left = 20;

        }

        private void rdb_mode_of_payment_cheque_CheckedChanged(object sender, EventArgs e)
        {
            pnl_cheque_details_payment.Visible = true;
            pnl_cash_details_payment.Visible = false;
            pnl_online_details_payment.Visible = false;
            pnl_cheque_details_payment.Top = 300;
            pnl_cheque_details_payment.Left = 20;
        }

        private void rdb_mode_of_payment_online_CheckedChanged(object sender, EventArgs e)
        {
            pnl_online_details_payment.Visible = true;
            pnl_cash_details_payment.Visible = false;
            pnl_cheque_details_payment.Visible = false;
            pnl_online_details_payment.Top = 300;
            pnl_online_details_payment.Left = 20;
        }

        private void dgv_payment_details_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    //Edit Operation
                    no = Convert.ToInt32(dgv_payment_details.Rows[e.RowIndex].Cells["Reciept No"].Value);
                    SqlCommand cmdEdit = new SqlCommand("SELECT reciept_no,mode_of_payment,amount,cheque_number,cheque_date,bank_name,branch_name,fee_type,stud_aadhar_card,stud_name,paydate FROM tbl_payment_details FROM tbl_payment_details WHERE reciept_no = '" + no + "'", sqlCon);
                    sqlCon.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(cmdEdit);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        txt_receipt_no.Text = Convert.ToString(dt.Rows[0]["reciept_no"]);
                        if(Convert.ToString(dt.Rows[0]["mode_of_payment"])=="Cash")
                        {
                            rdb_mode_of_payment_cash.Checked = true;
                        }
                        else if(Convert.ToString(dt.Rows[0]["mode_of_payment"]) == "Cheque")
                        {
                            rdb_mode_of_payment_cheque.Checked = true;
                        }
                        else if(Convert.ToString(dt.Rows[0]["mode_of_payment"]) == "Online")
                        {
                            rdb_mode_of_payment_online.Checked = true;
                        }
                        txt_amount_adm_cash.Text = Convert.ToString(dt.Rows[0]["amount"]);
                        txt_amount_adm_cheque.Text = Convert.ToString(dt.Rows[0]["amount"]);
                        txt_amount_adm_online.Text = Convert.ToString(dt.Rows[0]["amount"]);
                        cmb_bank_cheque.Text = Convert.ToString(dt.Rows[0]["bank_name"]);
                        cmb_bank_online.Text = Convert.ToString(dt.Rows[0]["bank_name"]);
                        txt_branch_cheque.Text = Convert.ToString(dt.Rows[0]["branch_name"]);
                        txt_cheque_no.Text = Convert.ToString(dt.Rows[0]["cheque_number"]);
                        txt_id_online.Text = Convert.ToString(dt.Rows[0]["cheque_number"]);
                        dt_paydate_cash.Text = Convert.ToString(dt.Rows[0]["paydate"]);
                        dt_paydate_cheque.Text = Convert.ToString(dt.Rows[0]["paydate"]);
                        dt_paydate_online.Text = Convert.ToString(dt.Rows[0]["paydate"]);
                        dt_date_cheque.Text = Convert.ToString(dt.Rows[0]["cheque_date"]);
                        txt_stud_aadhar_no.Text = Convert.ToString(dt.Rows[0]["stud_aadhar_card"]);
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
                        no = Convert.ToInt32(dgv_payment_details.Rows[e.RowIndex].Cells["Reciept No"].Value);

                        SqlCommand cmdDelete = new SqlCommand("DELETE FROM tbl_payment_details WHERE reciept_no='" + no + "'", sqlCon);
                        cmdDelete.Connection.Open();
                        cmdDelete.ExecuteNonQuery();
                        cmdDelete.Connection.Close();
                        funGridFill();
                    }
                }
            }
            catch (Exception ex)
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
