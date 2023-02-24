using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee;


namespace Employee1
{
    public class child : department
    {
        public void func1()
        {
            Console.WriteLine("hello child");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //employeeDetails objEmp1 = new employeeDetails();
            //objEmp1.getDetails();
            child objch = new child();
            objch.func1();
            objch.departmentDetails();
            Console.ReadKey();
        }
    }
}
