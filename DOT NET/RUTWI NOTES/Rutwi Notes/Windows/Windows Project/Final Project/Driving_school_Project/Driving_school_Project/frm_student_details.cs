using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Driving_school_Project
{
    public partial class frm_student_details : Form
    {
        double adharCard = 0;
        SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["proCon"].ConnectionString);
        public frm_student_details()
        {
            InitializeComponent();
            //funClear();
            funGridFill();
            pnl_cash_details.Visible = false;
            pnl_cheque_details.Visible = false;
            pnl_online_details.Visible = false;
          
        }


        void funClear()
        {
            txt_aadharno_stud.Text = "";
            txt_name_stud.Text = "";
            rtb_add_stud.Text = "";
            txt_area_stud.Text = "";
            cmb_city_stud.SelectedIndex = -1;
            txt_pin_stud.Text = "";
            txt_pancard_stud.Text = "";
            rdb_gender_f_stud.Checked = false;
            rdb_gender_m_stud.Checked = false;
            dt_dob_stud.ResetText();
            txt_contact_stud.Text = "";
            dt_joiningdate_stud.ResetText();
            cmb_vehicle_type_stud.SelectedIndex = -1;
            rdb_adm_yes.Checked = false;
            rdb_adm_no.Checked = false;
            adharCard = 0;

        }

        void funGridFill()
        {
            SqlCommand cmd = new SqlCommand("SELECT stud_aadhar_card[Aadhar Card No], stud_name[Name],stud_city[City], stud_contact[Contact], vehicle_type[Vehicle] FROM tbl_student_details", sqlCon);
            sqlCon.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            sqlCon.Close();
            dgv_details_stud.DataSource = dt;
            dgv_details_stud.Columns[2].Visible = false;
        }

        private void btn_stud_clear_Click(object sender, EventArgs e)
        {
            funClear();
        }

        private void btn_stud_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (adharCard == 0)
                {
                    //Insert Operation
                    SqlCommand cmdInsert = new SqlCommand("INSERT INTO tbl_student_details(stud_aadhar_card,stud_name,stud_gender,stud_dob,stud_address,stud_area,stud_city,stud_pincode,stud_pan_card,stud_joining_date,stud_contact,vehicle_type,stud_payment_mode,stud_registration_fee,stud_fee_paydate,stud_cheque_no,stud_cheque_date,stud_bank,stud_bank_branch) VALUES(@stud_aadhar_card,@stud_name,@stud_gender,CONVERT(DATE,@stud_dob,103),@stud_address,@stud_area,@stud_city,@stud_pincode,@stud_pan_card,CONVERT(DATE,@stud_joining_date,103),@stud_contact,@vehicle_type,@stud_payment_mode,@stud_registration_fee,CONVERT(DATE,@stud_fee_paydate,103),@stud_cheque_no,CONVERT(DATE,@stud_cheque_date,103),@stud_bank,@stud_bank_branch)", sqlCon);
                    sqlCon.Open();
                    cmdInsert.Parameters.AddWithValue("@stud_aadhar_card", txt_aadharno_stud.Text.Trim());
                    cmdInsert.Parameters.AddWithValue("@stud_name", txt_name_stud.Text.Trim());
                    cmdInsert.Parameters.AddWithValue("@stud_address", rtb_add_stud.Text.Trim());
                    cmdInsert.Parameters.AddWithValue("@stud_area", txt_area_stud.Text.Trim());
                    cmdInsert.Parameters.AddWithValue("@stud_city", cmb_city_stud.SelectedItem);
                    cmdInsert.Parameters.AddWithValue("@stud_pincode", txt_pin_stud.Text.Trim());
                    cmdInsert.Parameters.AddWithValue("@stud_pan_card", txt_pancard_stud.Text.Trim());
                    if (rdb_gender_f_stud.Checked == true)
                    {
                        cmdInsert.Parameters.AddWithValue("@stud_gender", rdb_gender_f_stud.Text.Trim());
                    }
                    else if (rdb_gender_m_stud.Checked == true)
                    {
                        cmdInsert.Parameters.AddWithValue("@stud_gender", rdb_gender_m_stud.Text.Trim());
                    }
                    cmdInsert.Parameters.AddWithValue("@stud_dob",Convert.ToDateTime(dt_dob_stud.Value));
                    cmdInsert.Parameters.AddWithValue("@stud_contact", txt_contact_stud.Text.Trim());
                    cmdInsert.Parameters.AddWithValue("@stud_joining_date",  Convert.ToDateTime(dt_joiningdate_stud.Value));
                    cmdInsert.Parameters.AddWithValue("@vehicle_type", cmb_vehicle_type_stud.SelectedItem);
                    if (rdb_cash_paymode.Checked == true)
                    {
                        cmdInsert.Parameters.AddWithValue("@stud_payment_mode", rdb_cash_paymode.Text.Trim());
                        cmdInsert.Parameters.AddWithValue("@stud_fee_paydate",  Convert.ToDateTime(dt_paydate_cash.Value));
                        cmdInsert.Parameters.AddWithValue("@stud_registration_fee", txt_amount_adm_cash.Text.Trim());
                        cmdInsert.Parameters.AddWithValue("@stud_cheque_no", "null");
                        cmdInsert.Parameters.AddWithValue("@stud_cheque_date", "null");
                        cmdInsert.Parameters.AddWithValue("@stud_bank", "null");
                        cmdInsert.Parameters.AddWithValue("@stud_bank_branch", "null");
                    }
                    else if (rdb_cheque_paymode.Checked == true)
                    {
                        cmdInsert.Parameters.AddWithValue("@stud_payment_mode", rdb_cheque_paymode.Text.Trim());
                        cmdInsert.Parameters.AddWithValue("@stud_fee_paydate",  Convert.ToDateTime(dt_paydate_cheque.Value));
                        cmdInsert.Parameters.AddWithValue("@stud_registration_fee", txt_amount_adm_cheque.Text.Trim());
                        cmdInsert.Parameters.AddWithValue("@stud_cheque_no", txt_cheque_no.Text.Trim());
                        cmdInsert.Parameters.AddWithValue("@stud_cheque_date",  Convert.ToDateTime(dt_date_cheque.Value));
                        cmdInsert.Parameters.AddWithValue("@stud_bank", cmb_bank_cheque.SelectedItem);
                        cmdInsert.Parameters.AddWithValue("@stud_bank_branch", txt_branch_cheque.Text.Trim());
                    }
                    else if (rdb_online_paymode.Checked == true)
                    {
                        cmdInsert.Parameters.AddWithValue("@stud_payment_mode", rdb_online_paymode.Text.Trim());
                        cmdInsert.Parameters.AddWithValue("@stud_fee_paydate",Convert.ToDateTime(dt_paydate_online.Value));
                        cmdInsert.Parameters.AddWithValue("@stud_registration_fee", txt_amount_adm_online.Text.Trim());
                        cmdInsert.Parameters.AddWithValue("@stud_cheque_no", txt_id_online.Text.Trim());
                        cmdInsert.Parameters.AddWithValue("@stud_bank", cmb_bank_online.SelectedItem);
                        cmdInsert.Parameters.AddWithValue("@stud_cheque_date", Convert.ToDateTime(dt_paydate_online.Value));
                        cmdInsert.Parameters.AddWithValue("@stud_bank_branch", "null");
                    }
                    cmdInsert.ExecuteNonQuery();
                    sqlCon.Close();
                    funGridFill();
                    funClear();    
                }

                else
                {
                    //Update operation
                    //double a = adharCard;
                    SqlCommand cmdUpdate = new SqlCommand("UPDATE tbl_student_details SET stud_aadhar_card=@stud_aadhar_card,stud_name=@stud_name,stud_gender=@stud_gender,stud_dob=@stud_dob,stud_address=@stud_address,stud_area=@stud_area,stud_city=@stud_city,stud_pincode=@stud_pincode,stud_pan_card=@stud_pan_card,stud_joining_date=@stud_joining_date,stud_contact=@stud_contact,vehicle_type=@vehicle_type ,stud_payment_mode=@stud_payment_mode,stud_fee_paydate=@stud_fee_paydate,stud_cheque_no=@stud_cheque_no,stud_cheque_date=@stud_cheque_date,stud_bank=@stud_bank,stud_bank_branch=@stud_bank_branch WHERE  stud_aadhar_card = '" + adharCard + "'", sqlCon);
                    sqlCon.Open();
                    cmdUpdate.Parameters.AddWithValue("@stud_aadhar_card", txt_aadharno_stud.Text.Trim());
                    cmdUpdate.Parameters.AddWithValue("@stud_name", txt_name_stud.Text.Trim());
                    cmdUpdate.Parameters.AddWithValue("@stud_address", rtb_add_stud.Text.Trim());
                    cmdUpdate.Parameters.AddWithValue("@stud_area", txt_area_stud.Text.Trim());
                    cmdUpdate.Parameters.AddWithValue("@stud_city", cmb_city_stud.SelectedItem);
                    cmdUpdate.Parameters.AddWithValue("@stud_pincode", txt_pin_stud.Text.Trim());
                    cmdUpdate.Parameters.AddWithValue("@stud_pan_card", txt_pancard_stud.Text.Trim());
                    if (rdb_gender_f_stud.Checked == true)
                    {
                        cmdUpdate.Parameters.AddWithValue("@stud_gender", rdb_gender_f_stud.Text.Trim());
                    }
                    else if (rdb_gender_m_stud.Checked == true)
                    {
                        cmdUpdate.Parameters.AddWithValue("@stud_gender", rdb_gender_m_stud.Text.Trim());
                    }
                    cmdUpdate.Parameters.AddWithValue("@stud_dob", dt_dob_stud.Value);
                    cmdUpdate.Parameters.AddWithValue("@stud_contact", txt_contact_stud.Text.Trim());
                    cmdUpdate.Parameters.AddWithValue("@stud_joining_date", dt_joiningdate_stud.Value);
                    cmdUpdate.Parameters.AddWithValue("@vehicle_type", cmb_vehicle_type_stud.SelectedItem);
                    if (rdb_cash_paymode.Checked == true)
                    {
                        cmdUpdate.Parameters.AddWithValue("@stud_payment_mode", rdb_cash_paymode.Text.Trim());
                        cmdUpdate.Parameters.AddWithValue("@stud_fee_paydate", dt_paydate_cash.Value);
                        cmdUpdate.Parameters.AddWithValue("@stud_registration_fee", txt_amount_adm_cash.Text.Trim());
                    }
                    else if (rdb_cheque_paymode.Checked == true)
                    {
                        cmdUpdate.Parameters.AddWithValue("@stud_payment_mode", rdb_cheque_paymode.Text.Trim());
                        cmdUpdate.Parameters.AddWithValue("@stud_fee_paydate", dt_paydate_cheque.Value);
                        cmdUpdate.Parameters.AddWithValue("@stud_registration_fee", txt_amount_adm_cheque.Text.Trim());
                        cmdUpdate.Parameters.AddWithValue("@stud_cheque_no", txt_cheque_no.Text.Trim());
                        cmdUpdate.Parameters.AddWithValue("@stud_cheque_date", dt_date_cheque.Value);
                        cmdUpdate.Parameters.AddWithValue("@stud_bank", cmb_bank_cheque.SelectedItem);
                        cmdUpdate.Parameters.AddWithValue("@stud_bank_branch", txt_branch_cheque.Text.Trim());
                    }
                    else if (rdb_online_paymode.Checked == true)
                    {
                        cmdUpdate.Parameters.AddWithValue("@stud_payment_mode", rdb_online_paymode.Text.Trim());
                        cmdUpdate.Parameters.AddWithValue("@stud_fee_paydate", dt_paydate_online.Value);
                        cmdUpdate.Parameters.AddWithValue("@stud_registration_fee", txt_amount_adm_online.Text.Trim());
                        cmdUpdate.Parameters.AddWithValue("@stud_cheque_no", txt_id_online.Text.Trim());
                        cmdUpdate.Parameters.AddWithValue("@stud_bank", cmb_bank_online.SelectedItem);
                    }
                    cmdUpdate.ExecuteNonQuery();
                    sqlCon.Close();
                }
     
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_details_stud_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    //Edit Operation
                    adharCard = Convert.ToDouble(dgv_student_details.Rows[e.RowIndex].Cells["Aadhar Card No"].Value);
                    SqlCommand cmdEdit = new SqlCommand(" SELECT stud_aadhar_card,stud_name,stud_gender,stud_dob,stud_address,stud_area,stud_city,stud_pincode,stud_pan_card,stud_joining_date,stud_contact,vehicle_type, stud_registration_fee FROM tbl_student_details WHERE stud_aadhar_card ='" + adharCard + "'", sqlCon);
                    cmdEdit.Connection.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(cmdEdit);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    cmdEdit.Connection.Close();
                    if (dt.Rows.Count > 0)
                    {
                        txt_aadharno_stud.Text = Convert.ToString(dt.Rows[0]["stud_aadhar_card"]);
                        txt_name_stud.Text = Convert.ToString(dt.Rows[0]["stud_name"]);
                        rtb_add_stud.Text = Convert.ToString(dt.Rows[0]["stud_address"]);
                        txt_area_stud.Text = Convert.ToString(dt.Rows[0]["stud_area"]);
                        cmb_city_stud.Text = Convert.ToString(dt.Rows[0]["stud_city"]);
                        txt_pin_stud.Text = Convert.ToString(dt.Rows[0]["stud_pincode"]);
                        if (Convert.ToString(dt.Rows[0]["stud_gender"]) == "Female")
                        {
                            rdb_gender_f_stud.Checked = true;
                        }
                        else
                        {
                            rdb_gender_m_stud.Checked = true;
                        }
                        dt_dob_stud.Text = Convert.ToString(dt.Rows[0]["stud_dob"]);
                        txt_contact_stud.Text = Convert.ToString(dt.Rows[0]["stud_contact"]);
                        dt_joiningdate_stud.Text = Convert.ToString(dt.Rows[0]["stud_joining_date"]);
                        cmb_vehicle_type_stud.Text = Convert.ToString(dt.Rows[0]["vehicle_type"]);
                    }
                    funGridFill();
                }
                else if (e.ColumnIndex == 1)
                {
                    //Delete Operation
                    DialogResult result = MessageBox.Show("Do You Want To Delete This Record.?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    if (result == DialogResult.Yes)
                    {
                        adharCard = Convert.ToDouble(dgv_student_details.Rows[e.RowIndex].Cells["Aadhar Card No"].Value);

                        SqlCommand cmdDelete = new SqlCommand("DELETE FROM tbl_student_details WHERE stud_aadhar_card='" + adharCard + "'", sqlCon);
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

        private void rdb_cheque_paymode_CheckedChanged(object sender, EventArgs e)
        {
            pnl_cheque_details.Visible = true;
            pnl_cash_details.Visible = false;
            pnl_online_details.Visible = false;
            pnl_cheque_details.Top = 350;
            pnl_cheque_details.Left = 500;
        }

        private void rdb_cash_paymode_CheckedChanged(object sender, EventArgs e)
        {
            pnl_cash_details.Visible = true;
            pnl_online_details.Visible = false;
            pnl_cheque_details.Visible = false;
            pnl_cash_details.Top = 350;
            pnl_cash_details.Left = 500;
        }

        private void rdb_online_paymode_CheckedChanged(object sender, EventArgs e)
        {
            pnl_online_details.Visible = true;
            pnl_cheque_details.Visible = false;
            pnl_cash_details.Visible = false;
            pnl_online_details.Top = 350;
            pnl_online_details.Left = 500;
        }

        private void rdb_adm_yes_CheckedChanged(object sender, EventArgs e)
        {
            lbl_modepayment.Visible = true;
            pnl_mode_payment.Visible = true;
        }

        private void rdb_adm_no_CheckedChanged(object sender, EventArgs e)
        {
            lbl_modepayment.Visible = false;
            pnl_mode_payment.Visible = false;
        }
    }
}
