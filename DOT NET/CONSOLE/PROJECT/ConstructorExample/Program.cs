using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExample
{
    class demo
    {
        private int i, j;
        public demo()
        {
            Console.WriteLine(" hi im constructor");
            i = 10;
            j = 20;
        }
        public demo(int x, int y)
        {
            Console.WriteLine("inside parameterised const");
            i = x;
            j = y;
        }
        public demo(demo copyConst)
        {
            Console.WriteLine("inside a copy const");
            i = copyConst.i;
            j = copyConst.j;
        }
        ~demo()
        {
            Console.WriteLine(" hello im a destructor");
            Console.ReadKey();

        }

        static void Main(string[] args)
        {
            demo obj1 = new demo();
            demo obj2 = new demo(100, 200);
            demo obj3 = new demo(obj2);
            Console.ReadKey();

        }
    }
}
