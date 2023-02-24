using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_Example
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_registration objRegistration = new frm_registration();
            objRegistration.Show();
            objRegistration.MdiParent = this;
            
        }
        
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_login objLogin = new frm_login();
            objLogin.Show();
            objLogin.MdiParent = this;

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_home objHome = new frm_home();
            objHome.Show();
            objHome.MdiParent = this;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_about objAbout = new frm_about();
            objAbout.Show();
            objAbout.MdiParent = this;

        }
    }
}
