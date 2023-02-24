using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample
{

    public enum month
    {
        jan = 1, feb, march, april

    };

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("the values of jan is " + (int)month.jan);
            Console.WriteLine("the values of feb is " + (int)month.feb);
            Console.WriteLine("the values of march is " + (int)month.march);
            Console.WriteLine("the values of april is " + (int)month.april);
            string a = Enum.GetName(typeof(month),1);
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
