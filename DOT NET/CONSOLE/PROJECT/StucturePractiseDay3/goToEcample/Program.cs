using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goToExample
{
    class Program
    {
        static void Main(string[] args)
        {
        ineligible:
            Console.WriteLine(" enter your age \n");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age <= 18)
            {
                Console.WriteLine("you are not eligible to vote ");
                goto ineligible;
            }
            else
            {
                Console.WriteLine(" you are eligible to vote ");
            }
            Console.ReadKey();
        }
    }
}
