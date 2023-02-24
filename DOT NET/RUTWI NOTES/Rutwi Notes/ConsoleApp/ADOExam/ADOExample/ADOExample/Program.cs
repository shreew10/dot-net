using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace ADOExample
{
    class Program
    {


        static void Main(string[] args)
        {
            SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["conEmp"].ConnectionString);

            //Alternate option for close sql connection -> cmd.Coonection.Close();

            Console.WriteLine("Enter Employee Id");
            var ENo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            var EmpName = Console.ReadLine();
            Console.WriteLine("Enter Employee job");
            var EmpJob = Console.ReadLine();
            Console.WriteLine("Enter Employee Hire date");
            var EmpHireDate = Console.ReadLine();

            SqlCommand cmdInsert = new SqlCommand("INSERT INTO EMP (EmpNo, EName, Job,HireDate) VALUES (@EmpNo,@EName,@Job,CONVERT(DATE,@HireDate,103))",sqlCon);
            sqlCon.Open();
            cmdInsert.Parameters.AddWithValue("@EmpNo", Convert.ToInt32(ENo));
            cmdInsert.Parameters.AddWithValue("@EName", EmpName);
            cmdInsert.Parameters.AddWithValue("@Job", EmpJob);
            cmdInsert.Parameters.AddWithValue("@HireDate", Convert.ToDateTime(EmpHireDate));

            cmdInsert.ExecuteNonQuery();
            sqlCon.Close();
            SqlCommand cmd = new SqlCommand("SELECT EmpNo, EName, Job,HireDate FROM EMP", sqlCon);
            sqlCon.Open();
            //Alternate option for open sql connection -> cmd.Coonection.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            sqlCon.Close();
            Console.WriteLine(dt.Columns[0] + "    |    " + dt.Columns[1] + "    |    " + dt.Columns[2] + "    |    " + dt.Columns[3]);

            for(int i=0;i<dt.Rows.Count;i++)
            {
                Console.WriteLine(dt.Rows[i][0].ToString() + "    |    " + dt.Rows[i][1].ToString() + "    |    " + dt.Rows[i][2].ToString() + "    |    " + dt.Rows[i][3].ToString());
            }
            Console.ReadKey();
        }
        
    }
}
