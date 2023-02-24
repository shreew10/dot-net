using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_drriving_school
{
    public partial class frm_home_page : Form
    {
        public frm_home_page()
        {
            InitializeComponent();
        }

        private void comapnyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_company objComp = new frm_company();
            objComp.Show();
            objComp.MdiParent = this;
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_staff_details objStaff = new frm_staff_details();
            objStaff.Show();
            objStaff.MdiParent = this;
        }

        private void admissionToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void frm_home_page_Load(object sender, EventArgs e)
        {

        }
    }
}
