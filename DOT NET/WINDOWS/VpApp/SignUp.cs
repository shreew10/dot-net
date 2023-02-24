using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace VpApp
{
    public partial class SignUp : Form
    {
        public static string fname;
        public static string lname;
        public static string emailAddress;

        public static Boolean sms;
        public static Boolean reports;
        public static Boolean transactions;

        Confirmation c = new Confirmation();
        public SignUp()
        {
            InitializeComponent();
        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            fname = tb_firstName.Text;
            lname = tb_lastName.Text;
            emailAddress = tb_email.Text;

            this.Hide();
            c.Show();


        }

        private void chk_sms_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_sms.Checked)
            {
                sms = true;
                lbl_sms_message.Text = "Services Charges May Apply for SMS";
            }
            else
            {
                sms = false;
                lbl_sms_message.Text = "......";
            }
        }

        private void chk_reports_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_reports.Checked)
            {
                reports = true;

            }
            else
            {
                reports = false;

            }
        }

        private void chk_transactions_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_transactions.Checked)
            {
                transactions = true;
                lbl_trans_meesage.Text = "Services Charges May Apply for Transactions";
            }
            else
            {
                transactions = false;
                lbl_trans_meesage.Text = "......";
            }
        }
    }
}
