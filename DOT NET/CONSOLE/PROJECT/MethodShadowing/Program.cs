using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodShadowing
{
    class Program
    {
        static void Main(string[] args)
        {
            Derived2 D2 = new Derived2();
            D2.Bentley();

            Base B = new Derived();
            B.Bentley();
            Console.ReadKey();
        }
    }
}
