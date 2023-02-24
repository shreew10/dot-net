using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsExampleDay1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblHello.Text = "HELLO SHREE";

        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            lblHello.Text = "Hey There Shree";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            this.Hide();
            LoginForm lF = new LoginForm();
            lF.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lblHello.Text = "Text has been canceled";
        }
    }
}
