using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSetExample
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("EmpId");
            dt.Columns.Add("EmpName");
            dt.Columns.Add("EmpContact");
            dt.Columns.Add("EmpCity");
            dt.Rows.Add(1, "Rutwi", 9873456230, "Sangli");
            dt.Rows.Add(2, "Vaishanvi", 8547320596, "Pune");
            dt.Rows.Add(3, "Rounak", 8526974201, "Sangli");
            dt.Rows.Add(4, "Prachi", 9842156308, "Karad");
            dt.Rows.Add(5, "Neha", 9954216802, "Mumbai");

            int dtRowCount = dt.Rows.Count;
            //Fetch value in particular row
            int Id = Convert.ToInt32(dt.Rows[0]["EmpId"]);
            string Name = dt.Rows[0][1].ToString();
            string Contact = dt.Rows[0][2].ToString();
            string City = dt.Rows[0][3].ToString();

            DataTable dtDept = new DataTable();
            dtDept.Columns.Add("DeptName");
            dtDept.Columns.Add("DeptNo");
            dtDept.Rows.Add("Development", 101);
            dtDept.Rows.Add("Accounts", 102);
            dtDept.Rows.Add("Production", 103);



            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            ds.Tables.Add(dtDept);
            int ds0Count = ds.Tables[0].Rows.Count;
            int dst1Count = ds.Tables[1].Rows.Count;
  

            int EmpID = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            string EmpName = ds.Tables[0].Rows[0][1].ToString();

            Console.WriteLine(EmpID);
            Console.WriteLine(EmpName);

            Console.WriteLine(ds.Tables[0].Columns[0]);


            Console.ReadKey();
        }
    }
}
