using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodShadowing
{
    class Base
    {
        public void Bentley()
        {
            Console.WriteLine(" Bentley Mulsane");
        }
    }
    class Derived : Base
    {
        public new void Bentley()
        {
            Console.WriteLine("  Bentley Continental ");
        }
    }
    class Derived2 : Derived
    {
        public new void Bentley()
        {
            Console.WriteLine(" Bentley Coupe  ");
        }
    }
}
