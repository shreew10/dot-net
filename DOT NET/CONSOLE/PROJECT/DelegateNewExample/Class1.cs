using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateNewExample
{
    class Class1
    {
        public delegate float DelInside(float a, float b);

        public static float multiply(float x, float y)
        {

            Console.WriteLine(x * y);
            return x * y;
        }
    }
}
