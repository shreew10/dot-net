using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_assignmentWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            txt_result.Text =(((Convert.ToInt32(txt_num1.Text)) + (Convert.ToInt32(txt_num2.Text))).ToString());
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {

            txt_result.Text = (((Convert.ToInt32(txt_num1.Text)) - (Convert.ToInt32(txt_num2.Text))).ToString());
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {

            txt_result.Text = (((Convert.ToInt32(txt_num1.Text)) * (Convert.ToInt32(txt_num2.Text))).ToString());
        }

        private void btn_div_Click(object sender, EventArgs e)
        {

            txt_result.Text = (((Convert.ToInt32(txt_num1.Text)) / (Convert.ToInt32(txt_num2.Text))).ToString());
        }
    }
}
