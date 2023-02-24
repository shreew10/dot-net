using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DbConnectivityYoutube
{
    public partial class Form1 : Form
    {
        DBAccess objDbAccess = new DBAccess();
        HomePage objHmPg = new HomePage();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            string name = tb_fName.Text;
            string lName = tb_lName.Text;
            string email = tb_email.Text;

            if (name.Equals(""))
            {
                MessageBox.Show("please enter name");
            }
            else if (lName.Equals(""))
            {
                MessageBox.Show("please enter last name");
            }
            else if (email.Equals(""))
            {
                MessageBox.Show("please enter email id");
            }
            else
            {
                //---------INSERT------------
                SqlCommand insertCommand = new SqlCommand("insert into Users(FirstName,LastName,Email) values (@name,@lName,@email)");

                insertCommand.Parameters.AddWithValue("@name", name);
                insertCommand.Parameters.AddWithValue("@lName", lName);
                insertCommand.Parameters.AddWithValue("@email", email);

                int row = objDbAccess.executeQuery(insertCommand);

                if (row == 1)
                {
                    MessageBox.Show("Account created Succesfully");

                    this.Hide();
                    objHmPg.Show();
                }
                else
                {
                    MessageBox.Show("Error occured please try again");
                }


            }
        }
    }
}

