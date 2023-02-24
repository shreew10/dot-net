using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTableExample
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
            dt.Rows.Add(2, "Vaishanvi",8547320596, "Pune");
            dt.Rows.Add(3, "Rounak", 8526974201, "Sangli");
            dt.Rows.Add(4, "Prachi", 9842156308, "Karad");
            dt.Rows.Add(5, "Neha", 9954216802, "Mumbai");

            int dtRowCount = dt.Rows.Count;
            //Fetch value in particular row
            int Id = Convert.ToInt32(dt.Rows[0]["EmpId"]);
            string Name = dt.Rows[0][1].ToString();
            string Contact = dt.Rows[0][2].ToString();
            string City = dt.Rows[0][3].ToString();

            //Console.WriteLine(dt.Columns[0]);

            //Console.WriteLine(Id);
            //Console.WriteLine(Name);
            //Console.WriteLine(Contact);
            //Console.WriteLine(City);

            //Console.WriteLine(dtRowCount);

            Console.WriteLine("    |    " + dt.Columns[0] + "    |    " + dt.Columns[1] + "    |    " + dt.Columns[2] + "    |    " + dt.Columns[3] + "    |    ");

            for(int i=0;i<dt.Rows.Count;i++)
            {
                Console.WriteLine("    |    " + dt.Rows[i][0].ToString() + "    |    " + dt.Rows[i][1].ToString() + "    |    " + dt.Rows[i][2].ToString() + "    |    " + dt.Rows[i][3].ToString() + "    |    ");
            }

            Console.ReadKey();
        }
    }
}
