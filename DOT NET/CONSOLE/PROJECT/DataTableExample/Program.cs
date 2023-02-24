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
            // datatable is a class and creating object
            DataTable dt = new DataTable();
            // adding columns to the dataTable
            dt.Columns.Add("CarId");
            dt.Columns.Add("CarName");
            dt.Columns.Add("CarModel");
            dt.Columns.Add("CarColour");
            //adding rows to the dataTable
            dt.Rows.Add(1, "RollsRoyce", "Phantom", "Black");
            dt.Rows.Add(2, "RollsRoyce", "Wraith", "Blue");
            dt.Rows.Add(3, "RollsRoyce", "Coupe", "White");
            dt.Rows.Add(4, "Bentley", "Mulsane", "ChicWhite");
            dt.Rows.Add(5, "Bentley", "Continental", "DarkBrown");
            dt.Rows.Add(6, "LandRower", "Discovery", "Maroon");

            int dtRowsCount = dt.Rows.Count;
            Console.WriteLine(dtRowsCount);
            //fetch value in a particular row
            int id = Convert.ToInt32(dt.Rows[0]["CarId"]);
            string Name = dt.Rows[0][1].ToString();
            Console.WriteLine(id);
            Console.WriteLine(Name);

            Console.WriteLine("");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Console.WriteLine(dt.Rows[i][0].ToString() + "|" + dt.Rows[i][1].ToString() + "|"
                    + dt.Rows[i][2].ToString() + "|" + dt.Rows[i][3].ToString() + "|");
            }
            Console.ReadKey();
        }
    }
}
