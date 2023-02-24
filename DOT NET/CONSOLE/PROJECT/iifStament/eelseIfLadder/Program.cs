using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eelseIfLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("enter 2 values ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("a is greater ");
            }
            else if (b > a)
            {
                Console.WriteLine("b is greater than a");
            }
            else if (a == b)
            {
                Console.WriteLine("a and b both are equal");
            }
            else
            {
                Console.WriteLine(" invalid input ");
            }
            Console.ReadKey();

        }
    }
}
