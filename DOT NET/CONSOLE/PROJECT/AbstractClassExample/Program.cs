using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample
{
    abstract class demo1
    {
        // complete func inside abstract class
        public void func1()
        {
            Console.WriteLine(" complete func inside abstract class ");
        }
        // abstract function only declared
        public abstract void func2();

    }

    class hello : demo1
    {
        // complete function defined func2 inherited from demo1
        public override void func2()
        {
            Console.WriteLine("hello there");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //demo1 objd = new demo1(); // cannot create object of abstract class
            hello obj2 = new hello();
            obj2.func1();
            obj2.func2();
            Console.ReadKey();
        }
    }
}
