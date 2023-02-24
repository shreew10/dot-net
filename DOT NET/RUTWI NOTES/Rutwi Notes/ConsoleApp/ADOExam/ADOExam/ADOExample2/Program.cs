using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace ADOExample2
{
    class Program
    {
        static int EmpID;
        static string EmpName;
        static string EmpSalary;
        static string EmpContactNo;


        static void TryCRUD()
        {
            SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["conEmpl"].ConnectionString);
            //For Update data
            inputEmpDetails();
            SqlCommand cmdUpdate = new SqlCommand("UPDATE tbl_employee SET EmpName =@EmpName, EmpSal = @EmpSal WHERE EmpId = '" + EmpID + "'", sqlCon);
            sqlCon.Open();
            cmdUpdate.Parameters.AddWithValue("@EmpName", EmpName);
            cmdUpdate.Parameters.AddWithValue("@EmpSal", Convert.ToDecimal(EmpSalary));
            cmdUpdate.ExecuteNonQuery();
            sqlCon.Close();
            displayEmpDetails();

            //For Delete data
            inputEmpDetails();
            SqlCommand cmdDelete = new SqlCommand("DELETE FROM tbl_employee WHERE EmpId='" + EmpID + "'", sqlCon);
            sqlCon.Open();
            cmdDelete.ExecuteNonQuery();
            sqlCon.Close();
            displayEmpDetails();

            //For Execute scalar
            SqlCommand cmdEx = new SqlCommand("SELECT MAX(EmpId) FROM tbl_employee", sqlCon);
            sqlCon.Open();
            int ID = Convert.ToInt32(cmdEx.ExecuteScalar());
            sqlCon.Close();
            //used for generate emp id
            //cmdInsert.Parameters.AddWithValue("@EmpId", ID + 1);

            SqlCommand cmdRdr = new SqlCommand("SELECT EmpId, EmpName,EmpSal, EmpContact FROM tbl_employee", sqlCon);
            sqlCon.Open();
            SqlDataReader dr = cmdRdr.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sqlCon.Close();

        }
        static void inputEmpDetails()
        {
            try
            {
                Console.WriteLine("Enter Employee Id");
                EmpID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Employee Name");
                EmpName = Console.ReadLine();
                Console.WriteLine("Enter Employee Salary");
                EmpSalary = Console.ReadLine();
                Console.WriteLine("Enter Employee Contact No");
                EmpContactNo = Console.ReadLine();


                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        static void displayEmpDetails()
        {
            try
            {

                SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["conEmpl"].ConnectionString);
                SqlCommand cmd = new SqlCommand("SELECT EmpId,  EmpName, EmpSal,EmpContact FROM tbl_employee ", sqlCon);
                sqlCon.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                sqlCon.Close();


                Console.WriteLine(dt.Columns[0].ToString() + "   | " + dt.Columns[1].ToString() + "   | " + dt.Columns[2].ToString() + "   | " + dt.Columns[3].ToString());
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Console.WriteLine(dt.Rows[i][0].ToString() + "     |  " + dt.Rows[i][1].ToString() + "     |  " + dt.Rows[i][2].ToString() + "     |  " + dt.Rows[i][3].ToString());
                }

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


        static void insertDetails()
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["conEmpl"].ConnectionString);
                SqlCommand cmdInsert = new SqlCommand("INSERT INTO tbl_employee (EmpId,EmpName, EmpSal,EmpContact) VALUES (@EmpId,@EmpName,@EmpSal, @EmpContact )", sqlCon);
                sqlCon.Open();
                cmdInsert.Parameters.AddWithValue("@EmpId", Convert.ToInt32(EmpID));
                cmdInsert.Parameters.AddWithValue("@EmpName", EmpName);
                cmdInsert.Parameters.AddWithValue("@EmpSal", Convert.ToDecimal(EmpSalary));
                cmdInsert.Parameters.AddWithValue("@EmpContact", EmpContactNo);
                cmdInsert.ExecuteNonQuery();
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }
        static void Main(string[] args)
        {
            try
            {

                //For insert data
                inputEmpDetails();
                insertDetails();
                displayEmpDetails();

                a:
                Console.WriteLine("If you want to insert data,the press Y. If you don't want to insert data, then press N ");
                string alph = Console.ReadLine();
                if (alph.ToLower() == "Y".ToLower())
                {
                    inputEmpDetails();
                    insertDetails();
                    displayEmpDetails();
                    goto a;
                }
                else
                {
                    Console.WriteLine("Exit");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
