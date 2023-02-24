using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventsExampleWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_num1_TextChanged(object sender, EventArgs e)
        {
            lbl_ans.Text = txt_num1.Text;
           
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void richTextBox2_MouseUp(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void txt_num2_TextChanged(object sender, EventArgs e)
        {
            lbl_ans.Text = txt_num2.Text;

            lbl_ans.Text = ((Convert.ToInt32(txt_num1.Text)) + (Convert.ToInt32((txt_num2.Text)))).ToString();
        }
    }
}
