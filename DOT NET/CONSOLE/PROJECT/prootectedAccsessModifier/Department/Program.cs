using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectWednesday9_11;

namespace Department
{
    class Program:company
    {
        static void Main(string[] args)
        {
            Program newObj = new Program();
            newObj.companyDetails();
            Console.WriteLine(newObj.companyId);
            Console.WriteLine(newObj.companyName);
            Console.ReadKey();
        }
    }
}
