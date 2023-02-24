using System;

namespace DelegateExample
{
    //access modifier - 'delegate'-return type- delegate name-(parameter)
    public delegate void EmpName(string name);
    class Program
    {
        delegate int DeptNo(int number);

        public void Ename(string E_name)
        {
            Console.WriteLine("Employee Name : " + E_name);
            Console.ReadKey();
        }

        static int D_num(int num)
        {
            return num;
        }
        static void Main(string[] args)
        {
            Program objProg = new Program();
            //Object of Delegate
            EmpName objEmp = new EmpName(objProg.Ename);
            objEmp.Invoke("Rutwi");

            DeptNo objDept = new DeptNo(Program.D_num);
            Console.WriteLine("Department number : " + objDept(101));
            Console.ReadKey();
        }
    }
}
