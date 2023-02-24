using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventsExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cb_sub_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_sub.Text == "c".ToLower())
            {
                MessageBox.Show("Developed by Dennis Ritchie");
            }
            else if (cb_sub.Text == "c++".ToLower())
            {
                MessageBox.Show("Developed by Dennis Ritchie in future");
            }
            else if (cb_sub.Text == "java".ToLower())
            {
                MessageBox.Show("Developed by Oracle");
            }
            else if (cb_sub.Text == "react".ToLower())
            {
                MessageBox.Show("React is a JavaScript library for building user interfaces.");
            }
            else if (cb_sub.Text == "python".ToLower())
            {
                MessageBox.Show("Python can be used on a server to create web applications.");
            }
        }

        private void tb2_value_TextChanged(object sender, EventArgs e)
        {
            lbl_display.Text = tb2_value.Text;

            //lbl_display.Text = ((Convert.ToInt32(tb1_value.Text)) + (Convert.ToInt32(tb2_value.Text))).ToString();

        }

        private void tb1_value_TextChanged(object sender, EventArgs e)
        {
            lbl_display.Text = tb1_value.Text;
        }
    }
}
