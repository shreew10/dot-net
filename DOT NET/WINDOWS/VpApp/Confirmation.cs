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
    public partial class Confirmation : Form
    {
        public Confirmation()
        {
            InitializeComponent();
        }

        private void Confirmation_Load(object sender, EventArgs e)
        {
            lbl_first_name.Text = SignUp.fname;
            lbl_last_name.Text = SignUp.lname;
            lbl_email.Text = SignUp.emailAddress;

            if (SignUp.sms)
            {
                lbl_sms.Text = "✓";
            }

            if (SignUp.reports)
            {
                lbl_reports.Text = "✓";
            }

            if (SignUp.transactions)
            {
                lbl_transactions.Text = "✓";
            }
        }
    }
}
