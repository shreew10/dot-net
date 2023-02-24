using System;

namespace SealedClassExample
{
    sealed class Employee
    {
        int EmpId = 101;

        public void EmpDetails()
        {
            Console.WriteLine("Employee id : " + EmpId);
            Console.ReadKey();
        }
    }
    // Sealed class can't be inherit
    class Program
    {
        static void Main(string[] args)
        { 
            //object of sealed class can be created to access the members of that class
            Employee objEmp = new Employee();
            objEmp.EmpDetails();
            Console.ReadKey();
        }
    }
}
