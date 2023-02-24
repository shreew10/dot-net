using System;
using ProjectWednesday9_11;

namespace StaticExample
{

    class Program : company
    {
        static int var = 10;
        static string name = " shree ";

        void func()
        {
            Console.WriteLine("hello im static ");
        }
        static void Main(string[] args)
        {
            Console.WriteLine(var);
            Console.WriteLine(name);
            Program pp = new Program();
            pp.func();
            Console.ReadKey();
        }
    }
}
