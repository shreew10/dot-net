using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureAndEnum
{
    public struct Person
    {
        public string name;
        public int age;
        public int weight;
    };

    class Program
    {

        static void Main(string[] args)
        {
            Person p1;

            p1.name = " jack ";
            p1.age = 25;
            p1.weight = 67;

            Console.WriteLine(" data stored in p1 is \n" + p1.name
                + p1.age + "and weight is " + p1.weight);
            Console.ReadKey();
        }
    }
}
