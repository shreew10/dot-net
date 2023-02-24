using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismFuncOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 car = new Class1();
            car.Ford();
            car.Ford(111);
            car.Ford(3421, 10);
            Console.ReadKey();
        }
    }
}
