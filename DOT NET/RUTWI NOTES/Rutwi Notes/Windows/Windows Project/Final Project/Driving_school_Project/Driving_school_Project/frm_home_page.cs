using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_school_Project
{
    public partial class frm_home_page : Form
    {
        public frm_home_page()
        {
            InitializeComponent();
        }

        private void staffDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_staff_details objStaff = new frm_staff_details();
            objStaff.Show();
            objStaff.MdiParent = this;
        }

        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_company_details objCompany = new frm_company_details();
            objCompany.Show();
            objCompany.MdiParent = this;
        }

        private void admissionDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_student_details objStudent = new frm_student_details();
            objStudent.Show();
            objStudent.MdiParent = this;
        }

        private void paymentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_payment_details objPayment = new frm_payment_details();
            objPayment.Show();
            objPayment.MdiParent = this;
        }

        private void dailyTrainingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_daily_training objTraining = new frm_daily_training();
            objTraining.Show();
            objTraining.MdiParent = this;
        }

        private void feeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_fee_details objFee = new frm_fee_details();
            objFee.Show();
            objFee.MdiParent = this;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            frm_login objLogin = new frm_login();
            objLogin.Show();
        }

        private void ms_home_Click(object sender, EventArgs e)
        {
            frm_home objHome = new frm_home();
            objHome.Show();
            objHome.MdiParent = this;
        }

    }
}
