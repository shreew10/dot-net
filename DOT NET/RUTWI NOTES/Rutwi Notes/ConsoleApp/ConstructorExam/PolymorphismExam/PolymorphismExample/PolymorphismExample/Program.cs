
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample
{
    class Employee
    {
        int EmpId;
        string EmpName;
        int EmpDeptNo;

        public void EmpDetails()
        {
            Console.WriteLine("Employee details: ");
            Console.ReadKey();
        }
        public void EmpDetails(int id)
        {
            EmpId = id;
            Console.WriteLine("Employee id: "+ EmpId);
            Console.ReadKey();
        }
        public void EmpDetails(int D_id, string Ename)
        {
            EmpDeptNo = D_id;
            EmpName = Ename;
            Console.WriteLine("Employee Department: "+ EmpDeptNo);
            Console.WriteLine("Employee Name: "+ EmpName);
            Console.ReadKey();
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee Emp = new Employee();
            Emp.EmpDetails();
            Emp.EmpDetails(101);
            Emp.EmpDetails(01, "ABC");
            Console.ReadKey();
        }
    }
}
