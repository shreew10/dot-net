using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionClassEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            Array.Reverse(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Stack<char> s = new Stack<char>();
            s.Push('A');
            s.Push('B');
            s.Push('C');
            s.Push('D');
            s.Push('E');
            foreach (var item in s)
            {
                Console.WriteLine(item + ',');
            }
            Console.WriteLine("\n");

            List<string> d = new List<string>();
            d.Add("Rutwi");
            d.Add("Rounak");
            d.Add("Vishal");
            d.Add("Prachi");
            d.Add("Neha");
            for (int p = 0; p < d.Count; p++)
            {
                Console.WriteLine(d[p]);
            }
            Console.ReadKey();
        }
    }
}
