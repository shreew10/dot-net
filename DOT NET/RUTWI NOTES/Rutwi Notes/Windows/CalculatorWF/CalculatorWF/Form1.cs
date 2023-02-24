using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWF
{
    public partial class frm_calculator : Form
    {
        double val;
        string operation;
        public frm_calculator()
        {
            InitializeComponent();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_result.Text = "";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //Addition operation            
            try
            {
                val = (Convert.ToDouble(txt_result.Text));
                txt_result.Text = "";
                operation = "+";
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            //Substraction operation
            try
            {
                val = (Convert.ToDouble(txt_result.Text));
                txt_result.Text = "";
                operation = "-";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            //Multiplication operation
            try
            {
                val = (Convert.ToDouble(txt_result.Text));
                txt_result.Text = "";
                operation = "*";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            //Division operation
            try
            {
                val = (Convert.ToDouble(txt_result.Text));
                txt_result.Text = "";
                operation = "/";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_equals_Click(object sender, EventArgs e)
        {
            //EqualsTo operation
            try
            {
                switch(operation)
                {
                    case "+":
                        string add = (val + (Convert.ToDouble(txt_result.Text))).ToString();
                        txt_result.Text = add;
                        break;

                    case "-":
                        string sub= (val - (Convert.ToDouble(txt_result.Text))).ToString();
                        txt_result.Text = sub;
                        break;

                    case "*":
                        string mul = (val * (Convert.ToDouble(txt_result.Text))).ToString();
                        txt_result.Text = mul;
                        break;

                    case "/":
                        string div = (val / (Convert.ToDouble(txt_result.Text))).ToString();
                        txt_result.Text = div;
                        break;

                    default: MessageBox.Show("Invalid Operation");
                        break;
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_one_Click(object sender, EventArgs e)
        {
            txt_result.Text = txt_result.Text + 1;
        }

        private void btn_two_Click(object sender, EventArgs e)
        {
            txt_result.Text = txt_result.Text + 2;
        }

        private void btn_three_Click(object sender, EventArgs e)
        {
            txt_result.Text = txt_result.Text + 3;
        }

        private void btn_four_Click(object sender, EventArgs e)
        {
            txt_result.Text = txt_result.Text + 4;
        }

        private void btn_five_Click(object sender, EventArgs e)
        {
            txt_result.Text = txt_result.Text + 5;
        }

        private void btn_six_Click(object sender, EventArgs e)
        {
            txt_result.Text = txt_result.Text + 6;
        }

        private void btn_seven_Click(object sender, EventArgs e)
        {
            txt_result.Text = txt_result.Text + 7;
        }

        private void btn_eight_Click(object sender, EventArgs e)
        {
            txt_result.Text = txt_result.Text + 8;
        }

        private void btn_nine_Click(object sender, EventArgs e)
        {
            txt_result.Text = txt_result.Text + 9;
        }

        private void btn_zero_Click(object sender, EventArgs e)
        {
            txt_result.Text = txt_result.Text + 0;
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            txt_result.Text = txt_result.Text + ".";
        }
    }
}






