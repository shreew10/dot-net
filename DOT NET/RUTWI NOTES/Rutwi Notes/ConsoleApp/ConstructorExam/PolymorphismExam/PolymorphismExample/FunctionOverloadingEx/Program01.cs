using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionOverridingEx
{
    class Employee
    {
        int EmpId;
        string EmpName;
        public virtual void FunEmp(int E_id, string E_name)
        {
            Console.WriteLine("Employee Details: ");
            EmpId = E_id;
            EmpName = E_name;
            Console.WriteLine("Employee id: " + EmpId);
            Console.WriteLine("Employee name: " + EmpName);
            Console.ReadKey();
        }
    }

    class EmpDetails : Employee
    {
        int EMP_id;
        string EMP_name;
        public override void FunEmp(int para_id, string para_name)
        {
            Console.WriteLine("In derived class \n");
            Console.WriteLine("Employee Details: ");
            EMP_id = para_id;
            EMP_name = para_name;
            Console.WriteLine("Employee id: " + EMP_id);
            Console.WriteLine("Employee name: " + EMP_name);
            Console.ReadKey();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee obj_Emp = new Employee();
            obj_Emp.FunEmp(101, "Rutwi");
            EmpDetails obj_EmpDet = new EmpDetails();
            obj_EmpDet.FunEmp(102, "ABC");

        }
    }
}
