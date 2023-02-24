using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class employeeDetails
    {

        public int empId = 10;
        public string empName = "shree";
        public float salary = 100000.00f;

        public void getDetails()
        {
            Console.WriteLine(empId);
            Console.WriteLine(empName);
            Console.WriteLine(salary);
        }

    }
    public class department
    {
        int deptNumber = 100;
        int mangrNumber = 10;

        public void departmentDetails()
        {
            Console.WriteLine(deptNumber);
            Console.WriteLine(mangrNumber);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            employeeDetails objEmp = new employeeDetails();
            int z = objEmp.empId;
            objEmp.empId = 100;
            int x = objEmp.empId;
            objEmp.getDetails();
            //Console.WriteLine(objEmp.empId);
            //Console.WriteLine(objEmp.empName);
            //Console.WriteLine(objEmp.salary);
            department objdept = new department();
            objdept.departmentDetails();
            Console.ReadKey();
           
            
            
        }
    }

}
