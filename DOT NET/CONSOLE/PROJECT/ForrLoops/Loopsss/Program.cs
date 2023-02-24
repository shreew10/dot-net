using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loopsss
{
    class Program : Shree
    {
        struct Person
        {
            public int j;
            public string n;
        }
        enum month
        {
            jan = 1,
            feb,
            march

        }
        static class Bmw
        {
            public static int i = 15;
            public static int l = 26;

            public static void Func()
            {
                Console.WriteLine(i);
                Console.WriteLine(l);
            }
        }


        static void Main(string[] args)
        {
            //for (int i = 0; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //int i = 0;
            //do
            //{

            //    Console.WriteLine(" jai shree krishna ");
            //    i++;

            //} while (i < 20);

            //int i = 0;
            //while (i<10)
            //{
            //    Console.WriteLine(" I have a millionare mind ");
            //    i++;
            //}


            // its interview practise
            //int i = 10;
            ////Console.WriteLine(i++);
            //Console.WriteLine(++i);
            //int k = 15;
            //object ob = k;
            //int h = (int)ob;
            //Console.WriteLine(ob);
            //Console.WriteLine(h);

            //int[] a = { 1, 516, 1 };
            //int[] k = new int[5];
            //k[0] = 24;
            //k[1] = 14;
            //k[2] = 8;
            //for (int i = 0; i < k.Length; i++)
            //{
            //    Console.WriteLine(k[i]);
            //}


            try
            {
                //Person p1;
                //p1.j = 10;
                //Console.WriteLine(month.jan);
                //Console.WriteLine(month.feb);
                //Shrikant obj = new Shrikant();
                //int q = obj.j;
                //Chiku c = new Chiku();
                //Console.WriteLine(c.j);
                //Program p = new Program();
                //Console.WriteLine(p.b);
                int z = 15;
                int v = 0;
                Console.WriteLine(z / v);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);

            }
            //catch (InvalidCastException)
            //{

            //}
            //catch (Exception)
            //{

            //}
            finally
            {
                Console.WriteLine("hello");
            }

            //catch()
            //{
            //    throw;
            //}
            //catch()
            //{

            //}

            Mercedes mc = new Mercedes();
            Console.WriteLine(mc.c);
            mc.normalFunc();
            //Bmw b = new Bmw();
            Bmw.Func();
            Console.WriteLine(Bmw.i);





            Console.ReadKey();
        }
    }


}
