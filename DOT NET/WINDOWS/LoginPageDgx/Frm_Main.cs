using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPageDgx
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form2 objFrm2 = new Form2();
            objFrm2.Show();
            objFrm2.MdiParent = this;
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form1 objFrm1 = new Form1();
            objFrm1.Show();

            objFrm1.MdiParent = this;
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form3 objFrm3 = new Form3();
            objFrm3.Show();
            objFrm3.MdiParent = this;
        }
    }
}
