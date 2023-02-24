using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionOverriding
{
    class Program
    {
        static void Main(string[] args)
        {
            // base class object
            Base mercB = new Base();
            mercB.Mercedes();

            // derived class object
            Derived mercD = new Derived();
            mercD.Mercedes();
            Console.ReadKey();
        }
    }
}
