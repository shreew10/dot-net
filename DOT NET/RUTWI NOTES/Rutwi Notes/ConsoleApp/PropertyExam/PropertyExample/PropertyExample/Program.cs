
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyExample
{
    class Employee
    {
        private string empName;
        private int empId;


        public string propertyEname //Property of employee name
        {
            set
            {
                empName = value;
            }
            get
            {
                return empName;
            }
        }
        public int propertyId  //Property of employee id
        {
            set
            {
                empId = value;
            }
            get
            {
                return empId;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine();
            Employee Emp = new Employee();
            Emp.propertyEname = "ABC";
            Emp.propertyId = 101;
            Console.WriteLine("Employee name : " + Emp.propertyEname);
            Console.WriteLine("ID : " + Emp.propertyId);
            Console.ReadKey();

        }
    }
}
