using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loopsss
{
    public class Shrikant
    {
        int g = 25;
        public int j = 56;
        protected int b = 21;
        private int T = 47;
    }
    public class Chiku : Shrikant
    {

    }
    public class Shree : Chiku
    {

    }
    class Mercedes
    {
        public static int var = 10;
        public int c = 25;

        public void normalFunc()
        {
            Console.WriteLine(var);
            Console.WriteLine(c);
        }
    }

    abstract class Audi
    {
        public void fun1()
        {
            Console.WriteLine("Hello there");
        }
        public abstract void fun2();
        public abstract int fun3();
    }

    class AudiQ3 : Audi
    {
        public override void fun2()
        {
            Console.WriteLine("Hello Q3");
        }
        public override int fun3()
        {
            return 5;
        }
    }


}
