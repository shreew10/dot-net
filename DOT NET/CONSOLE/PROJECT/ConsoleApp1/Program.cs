using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatatypeExample
{
    class Program
    {
        static void Main()
        {
            int id = 10;
            string name = "shree";
            double phoneNumber = 9423748659;
            float percentage = 100.23f;
            Console.WriteLine("id", id);
            Console.WriteLine(" hey there " , name);
            Console.WriteLine("contact number " + phoneNumber);
            Console.WriteLine(" percentage " + percentage);
            Console.WriteLine("Fantastic you're a champion");
            int age = 23;           // boxing unboxing of data
            object ob = age;
            int newAge =(int)ob;
           // float var = Convert.ToInt32(3.44f);
            float z = 'y';
            int g = (int)3.5;
            Console.WriteLine(g);
           // Console.WriteLine(var);
            Console.WriteLine(age);
            Console.WriteLine(newAge);
            int b;
            
            Console.ReadLine();
        }
    }
}
