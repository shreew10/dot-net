using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionClassExample
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


            Stack<int> s = new Stack<int>();
            s.Push(10);
            s.Push(20);
            s.Push(30);
            s.Push(40);
            s.Push(50);

            foreach (var item in s)
                Console.WriteLine(item + ',');
            Console.WriteLine("\n");

            List<int> d = new List<int>();
            d.Add(20);
            d.Add(30);
            d.Add(40);
            for (int p = 0; p < d.Count; p++)
            {
                Console.WriteLine(d[p]);
            }
            Console.ReadKey();
        }
    }
}
