using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample
{
    abstract class Employee 
    {
        //Abstract class have zero or more methods 
        public void empName()
        {
            Console.WriteLine("Normal Function");
            Console.ReadKey();
        }
        public abstract void empContact();
    }
    class EmpDetails : Employee
    {
        public override void empContact()
        {
            Console.WriteLine("Function abstract");
            Console.ReadKey();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
                //Employee empObj = new Employee;
                // for above -> can't create an object of abstract class
                EmpDetails obj2 = new EmpDetails();
                obj2.empName();
                obj2.empContact();
                Console.ReadKey();
        }
    }
}
