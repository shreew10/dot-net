using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericFunctionExample
{
    class Program
    {
        public void ComapnyDetails<N>(N C_id)
        {
            Console.WriteLine("Company number : " + C_id);
            Console.ReadKey();
        }
        public void EmpDetails<E>(E [] para)
        {
            int i;
            for (i = 0; i < para.Length; i++)
            {
                Console.WriteLine(para[i]);
                Console.ReadKey();
            }
        }
        static void Main(string[] args)
        {
            Program ObjP = new Program();

            ObjP.ComapnyDetails(101);

            Console.WriteLine("Employee numbers: ");
            int[] EmpNo = { 1, 2, 3, 4, 5 };
            ObjP.EmpDetails<int>(EmpNo);

            Console.WriteLine("Department numbers: ");
            char[] DeptNo = { 'A', 'B', 'C', 'D', 'E' };
            ObjP.EmpDetails<char>(DeptNo);

            Console.WriteLine("Employee names: ");
            string[] EmpName = { "ABC", "LMN", "PQR", "DEF", "RST" };
            ObjP.EmpDetails<string>(EmpName);

            
            Console.ReadKey();
        }
    }
}
