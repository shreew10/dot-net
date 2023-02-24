using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassExample
{
    class Details<T1, T2>
    {
        T1 i;
        T2 j;

        public Details (T1 no1, T2 no2)
        {
            i = no1;
            j = no2;
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.ReadKey();
        }
    }
    class Program01
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Comapny Details: ");
            Details<string, char> objComp = new Details<string, char>("DGX", 'a');

            Console.WriteLine("Employee Details: ");
            Details<int, string> objEmp = new Details<int, string>(1, "Rutwi");

            Console.ReadKey();
        }
    }
}
