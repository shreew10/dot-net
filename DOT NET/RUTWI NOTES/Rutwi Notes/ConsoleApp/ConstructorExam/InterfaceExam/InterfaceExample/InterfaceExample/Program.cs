
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    interface Interface1
    {
        //interface contains function declearation only
        //by default all functions are public and abstract
        void Inter1Fun1();
        void Inter1Fun2();
    }
    interface Interface2
    {
        //interface-> can't inherit multiple class
        //interface-> can't inherit class
        //interface-> can inherit multiple interfaces
        void FunctionInte1();
        void FunctionInte2();
    }
    class classDerived: Interface1, Interface2 
    {
        //class-> can inherit multiple interface
        public void Inter1Fun1()
        {
            Console.WriteLine("Function 1 in Interface 1");
            Console.ReadKey();
        }
        public void Inter1Fun2()
        {
            Console.WriteLine("Function 2 in Interface 1");
            Console.ReadKey();
        }
        public void FunctionInte1()
        {
            Console.WriteLine("Function 1 in Interface 2");
            Console.ReadKey();
        }
        public void FunctionInte2()
        {
            Console.WriteLine("Function 2 in Interface 2");
            Console.ReadKey();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Interface interfaceObj =new Interface1();
            //Interface interfaceObj =new Interface2();
            //above two sentences-> can't create an object of interface
            classDerived devObj = new classDerived();
            devObj.Inter1Fun1();
            devObj.Inter1Fun2();
            devObj.FunctionInte1();
            devObj.FunctionInte2();
            Console.ReadKey();
        }
    }
}
