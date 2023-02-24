using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overrideExample
{
    class clsBase
    {
        public virtual void fun1()
        {
            Console.WriteLine("Base Class");
        }
        //public override void fun1()
        //{
        //    Console.WriteLine("Base class override");
        //}
    }

    class clsDerived : clsBase
    {
        //public override void fun1()
        //{
        //    Console.WriteLine("Base class override");
        //}

    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
