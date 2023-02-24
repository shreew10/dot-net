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

    public partial class HomePage : Form
    {
        DBAccess objHpAccess = new DBAccess();

        DataTable dt = new DataTable();
        DBAccess dBAccess = new DBAccess();
        public HomePage()
        {

            InitializeComponent();
        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            string userEmail = tb_emailId.Text;

            if (userEmail.Equals(""))
            {
                MessageBox.Show("please enter email id");
            }
            else
            {
                //-------READ DATA FROM DATABASE
                string query = "SELECT * FROM Users WHERE Email = '" + userEmail + "'";
                dBAccess.readDatathroughAdapter(query, dt);

            }
            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("SUCCEFULLY LOGIN");
            }
            else
            {
                MessageBox.Show("error occured");
            }


        }

        private void lbl_signUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 objF1 = new Form1();
            objF1.Show();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string userEmail = tb_emailId.Text;

            if (userEmail.Equals(""))
            {
                MessageBox.Show("please enter user id");
            }
            else
            {

                //-----------UPDATE---------------
                string query = "UPDATE USERS SET EMAIL =@userEmail WHERE ID=1";
                SqlCommand upDateComm = new SqlCommand(query);
                upDateComm.Parameters.AddWithValue("@userEmail", userEmail);
                int row = objHpAccess.executeQuery(upDateComm);

                if (row == 1)
                {
                    MessageBox.Show("updated succesfully");
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string userEmail = tb_emailId.Text;

            //if (userEmail.Equals(""))
            //{
            //    MessageBox.Show("please enter user id");
            //}
            //else
            {
                //------------delete------
                string query = "DELETE FROM USERS WHERE ID =2";
                SqlCommand delComm = new SqlCommand(query);
                int row = objHpAccess.executeQuery(delComm);

                if (row == 1)
                {
                    MessageBox.Show("account deleted succesfuly");
                }
            }
        }
    }
}
