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
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
            
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            frm_home_page obj_frmHome = new frm_home_page();
            obj_frmHome.Show();
            //obj_frmHome.MdiParent = this;
            
        }

        private void tn_clear_Click(object sender, EventArgs e)
        {
            txt_login_id.Text = "";
            txt_password.Text = "";
        }
    }
}
