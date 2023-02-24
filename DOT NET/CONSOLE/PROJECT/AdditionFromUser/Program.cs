using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionFromUser
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(" Enter 2 numbers");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(" addition is : " + (a + b));
            double emp = 20.254444;
            decimal d = Convert.ToDecimal(emp);
            Console.WriteLine(emp);
            Console.WriteLine(d);
            int[] a = { 2, 5, 10, 15, 65, 45, 78 };
            for(int i=0;i<a.Length;i++)
            {
                Console.WriteLine(a[i]);
            }
            int z = 100;
            dynamic t = z;
            float q = t;
            Console.WriteLine(q);


            Console.ReadKey();
        }
    }
}


