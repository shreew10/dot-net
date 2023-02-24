using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvalidExceptionExam
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                object obj = 10.10f;
                int a = (int)obj;
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
