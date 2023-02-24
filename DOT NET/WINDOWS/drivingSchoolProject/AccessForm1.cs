using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drivingSchoolProject
{
    public partial class AccessForm1 : Form
    {
        public AccessForm1()
        {
            InitializeComponent();
        }



        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            CompanyForm objCf = new CompanyForm();
            objCf.Show();
            objCf.MdiParent = this;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LogInForm objLogIn = new LogInForm();
            objLogIn.Show();
        }

        private void newLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentForm objStuf = new StudentForm();
            objStuf.Show();
            objStuf.MdiParent = this;
        }

        private void paymentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaymentDetailsForm objPdf = new PaymentDetailsForm();
            objPdf.Show();
            objPdf.MdiParent = this;
        }

        private void dailyTrainingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DailiTrainingForm objdailiTrFrm = new DailiTrainingForm();
            objdailiTrFrm.Show();
            objdailiTrFrm.MdiParent = this;
        }

        private void staffToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StaffForm objStForm = new StaffForm();
            objStForm.Show();
            objStForm.MdiParent = this;
        }

        private void masterDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasterDataForm objmstrDtFrm = new MasterDataForm();
            objmstrDtFrm.Show();
            objmstrDtFrm.MdiParent = this;
        }
    }
}
