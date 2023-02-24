using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exception Handling
            // try catch example
            // using divideByZero class
            try
            {

                Console.WriteLine("enter two numbers");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("the answer is " + a / b);
            }
            catch (DivideByZeroException de)
            {
                Console.WriteLine(de.Message);
                Console.WriteLine("zero cannot be at denominator place");
            }
            finally
            {
                Console.WriteLine("enter two numbers");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("the answer is " + a / b);
            }
            Console.ReadKey();
        }
    }
}
