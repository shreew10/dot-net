using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSCONCEPT
{
    class classexample
    {
        int id;
        string name;
        float weight;
        static void Main(string[] args)
        {
            classexample ex = new classexample();
            ex.id = 111;
            ex.name="shree";
            ex.weight = 55;
            Console.WriteLine(ex.id);
            Console.WriteLine(ex.name);
            Console.WriteLine(ex.weight);
            Console.ReadKey();
        }
    }
}
