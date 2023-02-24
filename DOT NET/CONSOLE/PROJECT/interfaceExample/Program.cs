using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceExample
{
    // interface only function declaration
    interface Interface1
    {
        void Interface1Fun1();
        void interface1Fun2();
    }
    interface Interface2
    {
        void func1();
        void func2();
    }

    class clsDerived : Interface1, Interface2
    {
        // all the functions are defined in this class
        // from interface 1 and 2 
        // it is used bec multiple inheritace not supported in c#
        public void Interface1Fun1()
        {
            Console.WriteLine(" hello im complete function ");
        }
        public void interface1Fun2()
        { }
        public void func1()
        { }
        public void func2()
        { }


    }
    class Program
    {
        static void Main(string[] args)
        {
            clsDerived objH = new clsDerived();
            objH.func1();
            Console.ReadKey();
        }
    }
}
