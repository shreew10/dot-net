using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncOverExam
{
    class clsBase
    {
        public virtual void fun()
        {
            Console.WriteLine("Base class");
        }
    }
    class clsDerived: clsBase
    {
        public override void fun()
        {
            Console.WriteLine("Derived class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            clsDerived obj = new clsDerived();
            obj.fun();
            Console.ReadKey();
        }
    }
}
