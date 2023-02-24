using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateNewExample
{
    class Program : Class1
    {
        static void Main(string[] args)
        {
            Program objPro = new Program();

            DelInside objD = new DelInside(multiply);
            objD(23.54f, 12.36f);
            Console.ReadKey();
        }
    }
}
