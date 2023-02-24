using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseKeyword
{
    class Base
    {
        public int a = 10;
        public void Audi()
        {
            Console.WriteLine("audi base class");
        }
    }
    class Derived : Base
    {
        public int a = 20;
        public void Bmw()
        {
            Console.WriteLine(a);
            Console.WriteLine(base.a);
        }
    }
}
