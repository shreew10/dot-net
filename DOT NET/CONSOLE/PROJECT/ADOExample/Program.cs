using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ADOExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // fetching data from the database stockmarketdata
            SqlConnection SqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
            SqlCommand SqlCom = new SqlCommand("select Employee_id,emp_name,emp_address,emp_pin,emp_gender from tble_emp", SqlCon);
            SqlCon.Open();
            SqlDataAdapter SdA = new SqlDataAdapter(SqlCom);
            DataTable dt = new DataTable();
            SdA.Fill(dt);
            SqlCon.Close();

            Console.WriteLine(dt.Columns[0] + "|" + dt.Columns[1] + "|" + dt.Columns[2]);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Console.WriteLine(dt.Rows[i][0] + "|" + dt.Rows[i][1] + "|" + dt.Rows[i][2]);
            }

            //Console.WriteLine("enter empID");
            //var empId = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter empName");
            //var empName = Console.ReadLine();
            //Console.WriteLine("enter address");
            //var empAdd = Console.ReadLine();
            //Console.WriteLine("enter pin");
            //var empPin = Console.ReadLine();
            //Console.WriteLine("enter gender");
            //var empGender = Console.ReadLine();

            //INSERTED COMMAND WITH HARDCODED VALUE
            //SqlCommand CmdInsert = new SqlCommand("insert into tble_emp(Employee_id,emp_name,emp_address,emp_pin,emp_mobile,emp_email,emp_gender,emp_doj,emp_adharcard) " +
            //    "values(9, 'Hanna', '302 Berlin', 1055, 4, 'hanna@gmail.com', 'female', '1998-02-26', NULL)", SqlCon);
            // CmdInsert.ExecuteNonQuery();

            //INSERT USER INPUT IN THE DATABASE 

            SqlCon.Open();
            SqlCon.Close();


            Console.ReadKey();
        }
    }
}
