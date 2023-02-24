using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseExample
{
    class Employee
    {
         public int Deptno = 101;

        public void EmpDept()
        {
            Console.WriteLine("In base class");
            Console.WriteLine("Department no: "+ Deptno);
            Console.ReadKey();
        }
    }

    class Department : Employee
    {
        int Deptno = 102;

        public void DeptDetails()
        {
            Console.WriteLine("In derived class");
            Console.WriteLine("Department no: " + Deptno);
            Console.WriteLine("Department no: " + base.Deptno);
            Console.ReadKey();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Department objDept = new Department();
            objDept.DeptDetails();
            Employee objEmp = new Employee();
            objEmp.EmpDept();
            Console.ReadKey();
        }
    }
}
