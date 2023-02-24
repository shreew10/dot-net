using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionShadowingEx
{
    class Employee
    {
        int EmpId;
        string EmpName;

        public void EmpDetails(int E_id, string E_name)
        {
            Console.WriteLine("Employee Details: ");
            EmpId = E_id;
            EmpName = E_name;
            Console.WriteLine("Employee id: "+ EmpId);
            Console.WriteLine("Employee name: "+ EmpName);
            Console.ReadKey();
        }
    }

    class EmployeeDetails : Employee
    {
        int Emp_Id;
        string Emp_Name;

        public new void EmpDetails(int E_id, string E_name)
        {
            Console.WriteLine("Employee Details: ");
            Emp_Id = E_id;
            Emp_Name = E_name;
            Console.WriteLine("Employee id: " + Emp_Id);
            Console.WriteLine("Employee name: " + Emp_Name);
            Console.ReadKey();
        }
    }
    class Program02
    {
        static void Main(string[] args)
        {
            Employee Emp = new Employee();
            Emp.EmpDetails(101, "Rutwi");
            EmployeeDetails ObjEmp = new EmployeeDetails();
            ObjEmp.EmpDetails(102,"ABC");
            Console.ReadKey();
        }
    }
}
