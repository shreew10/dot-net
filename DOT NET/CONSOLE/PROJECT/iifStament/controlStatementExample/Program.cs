using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlStatementExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine(" enter 2 values ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if (a>b)
            {
                Console.WriteLine(" a is greater ");
            }
            else
            {
                Console.WriteLine(" b is greater ");
            }
            Console.ReadKey();
        }
    }
}
