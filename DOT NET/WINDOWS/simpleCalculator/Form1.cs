using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double sum = Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text);

            textBox3.Text = sum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double txt1 = Convert.ToDouble(textBox1.Text);
            double txt2 = Convert.ToDouble(textBox2.Text);

            double sub = txt1 - txt2;

            textBox3.Text = sub.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double txt1 = Convert.ToDouble(textBox1.Text);
            double txt2 = Convert.ToDouble(textBox2.Text);

            double mul = txt1 * txt2;

            textBox3.Text = mul.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double txt1 = Convert.ToDouble(textBox1.Text);
            double txt2 = Convert.ToDouble(textBox2.Text);

            double div = txt1 / txt2;

            textBox3.Text = div.ToString();
        }


        //-----------EVENTS OF DIFFERENT CONTOLLERS--------//
        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("KEY CODE KEY DOWN");
            }
            else if (e.KeyData == Keys.Enter)
            {
                MessageBox.Show("KEY DATA KEY DOWN");
            }
            else if (e.KeyValue == 13)
            {
                MessageBox.Show("KEY VALUE KEY DOWN");
            }
        }

        private void richTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("KEY CODE KEY UP");
            }
            else if (e.KeyData == Keys.Enter)
            {
                MessageBox.Show("KEY DATA KEY UP");
            }
            else if (e.KeyValue == 81)
            {
                MessageBox.Show("KEY VALUE KEY UP");
            }
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) ;
            {
                MessageBox.Show("ENTER BUTTON PRESSED");
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SINGLE CLICK");
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("DOUBLE CLICK");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("form3_form closed");
        }
    }
}
