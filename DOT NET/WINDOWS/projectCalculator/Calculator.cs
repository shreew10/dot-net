using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectCalculator
{
    public partial class Calculator : Form
    {

        public Calculator()
        {
            InitializeComponent();
        }

        float num1, value;
        int no;
        string op;



        public void calculator(int no)
        {
            try
            {

                switch (no)
                {
                    case 1:
                        value = num1 / float.Parse(tb_display.Text);
                        tb_display.Text = value.ToString();

                        break;
                    case 2:
                        value = num1 + float.Parse(tb_display.Text);
                        tb_display.Text = value.ToString();

                        break;
                    case 3:
                        value = num1 - float.Parse(tb_display.Text);
                        tb_display.Text = value.ToString();

                        break;
                    case 4:
                        value = num1 * float.Parse(tb_display.Text);
                        tb_display.Text = value.ToString();

                        break;
                    default:
                        break;
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void btn_seven_click_Click(object sender, EventArgs e)
        {
            try
            {
                tb_display.Text = tb_display.Text + 7;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_eight_click_Click(object sender, EventArgs e)
        {
            try
            {
                tb_display.Text = tb_display.Text + 8;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_nine_click_Click(object sender, EventArgs e)
        {
            try
            {
                tb_display.Text = tb_display.Text + 9;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_four_click_Click(object sender, EventArgs e)
        {
            try
            {
                tb_display.Text = tb_display.Text + 4;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_five_click_Click(object sender, EventArgs e)
        {
            try
            {
                tb_display.Text = tb_display.Text + 5;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_six_click_Click(object sender, EventArgs e)
        {
            try
            {
                tb_display.Text = tb_display.Text + 6;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_one_click_Click(object sender, EventArgs e)
        {
            try
            {
                tb_display.Text = tb_display.Text + 1;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_two_click_Click(object sender, EventArgs e)
        {
            try
            {
                tb_display.Text = tb_display.Text + 2;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_three_click_Click(object sender, EventArgs e)
        {
            try
            {
                tb_display.Text = tb_display.Text + 3;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_zero_click_Click(object sender, EventArgs e)
        {
            try
            {
                tb_display.Text = tb_display.Text + 0;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_clear_click_Click(object sender, EventArgs e)
        {
            try
            {
                tb_display.Clear();
                no = 0;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_addition_Click(object sender, EventArgs e)
        {
            try
            {
                //double num1 = Convert.ToDouble(tb_display.Text);
                //double num2 = Convert.ToDouble(tb_display.Text);
                //tb_display.Text = Convert.ToString(num1 + num2);
                num1 = float.Parse(tb_display.Text);
                tb_display.Clear();
                tb_display.Focus();
                //btn_equal_to.PerformClick();

                no = 2;
                op = "+";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_substraction_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = float.Parse(tb_display.Text);
                tb_display.Clear();
                tb_display.Focus();
                no = 3;
                op = "-";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_multiplication_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = float.Parse(tb_display.Text);
                tb_display.Clear();
                tb_display.Focus();
                no = 4;
                op = "*";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_division_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = float.Parse(tb_display.Text);
                tb_display.Clear();
                tb_display.Focus();
                no = 1;
                op = "/";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btn_equal_to_Click(object sender, EventArgs e)
        {
            try
            {
                calculator(no);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void btn_dot_click_Click(object sender, EventArgs e)
        {
            try
            {
                tb_display.Text = tb_display.Text + ".";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_equal_to_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode.Equals(Keys.Enter))
                {
                    calculator(no);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show(e.KeyChar.ToString());
            switch (e.KeyChar.ToString())
            {
                case "*":
                    btn_multiplication.PerformClick();
                    break;
                case "/":
                    btn_division.PerformClick();
                    break;
                case "+":
                    btn_addition.PerformClick();
                    break;
                case "-":
                    btn_substraction.PerformClick();
                    break;

                case "1":
                    if (e.KeyChar == (int)Keys.D1)
                    {

                    }
                    break;
                case "2":
                    if (e.KeyChar == (int)Keys.D2)
                    {

                    }
                    break;
                case "3":
                    if (e.KeyChar == (int)Keys.D3)
                    {

                    }
                    break;
                case "4":
                    if (e.KeyChar == (int)Keys.D4)
                    {

                    }
                    break;
                case "5":
                    if (e.KeyChar == (int)Keys.D5)
                    {

                    }
                    break;
                case "6":
                    if (e.KeyChar == (int)Keys.D6)
                    {

                    }
                    break;
                case "7":
                    if (e.KeyChar == (int)Keys.D7)
                    {

                    }
                    break;
                case "8":
                    if (e.KeyChar == (int)Keys.D8)
                    {

                    }
                    break;
                case "9":
                    if (e.KeyChar == (int)Keys.D9)
                    {

                    }
                    break;


                default:
                    break;
            }



        }

        private void btn_equal_to_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                //calculator(count);
            }
        }


    }
}





