using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExample
{
    class Demo
    {
        private int i, j;

        public Demo() //Demo(this)
        {
            Console.WriteLine("Inside Default Constructor");
            i = 10;
            j = 10;
            Console.ReadKey();
        }
        public Demo(int x, int y) //Demo(this,x,y)
        {
            Console.WriteLine("Inside Parametarized Constructor");
            i = x;
            j = y;
            Console.ReadKey();
        }
        public Demo(Demo copy) //Demo (this,x,y)
        {
            Console.WriteLine("Inside Copy Constructor");
            i = copy.i;
            j = copy.j;
            Console.ReadLine();
        }
        ~Demo()
        {
            Console.WriteLine("Inside Destructor");
            Console.ReadKey();
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Demo obj1 = new Demo(); //Demo(obj1)

            Demo obj2 = new Demo(30, 30); //Demo(obj2,30,30)

            Demo obj3 = new Demo(obj2);

            Console.ReadKey();
        }
    }
}
