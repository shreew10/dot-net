using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTableExample;


namespace DataSetExample
{
    class Program
    {
        static void Main(string[] args)
        {
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

            DataTable Demo = new DataTable();
            DataSet ds = new DataSet();
            ds.Tables.Add(Demo);
            ds.Tables.Add(dt);
            dt = new DataTable();
            Console.ReadKey();

        }
    }
}
