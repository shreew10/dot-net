using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchExample2
{
    class Program
    {
        static void Main(string[] args)
        {

        ineligible:
            try
            {
                Console.WriteLine("please enter employee id");
                int id = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

            }
            goto ineligible;
            Console.ReadKey();
        }
    }
}
