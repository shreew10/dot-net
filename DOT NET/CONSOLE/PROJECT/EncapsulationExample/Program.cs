using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExample
{
    public class demo
    {
        //private string name;
        //private int number;

        //// property
        //public string test
        //{
        //    // get and set private data of the class
        //    // getters and setters
        //    set
        //    {
        //        name = value;
        //    }
        //    get
        //    {
        //        return name;
        //    }
        //}
        //public int testInt
        //{
        //    set
        //    {
        //        number = value;
        //    }
        //    get
        //    {
        //        return number;
        //    }

        //}
        int z = 10;
        public int k = 15;
        protected int h = 55;
        private int l = 17;
    }
    public class a : demo
    {

    }
    public class b : a
    {

    }
    class Program : b
    {
        static void Main(string[] args)
        {
            //demo d = new demo();
            //d.test = "shree";
            //d.testInt = 111;
            //Console.WriteLine(d.testInt);
            //Console.WriteLine(d.test);
            a obja = new a();
            int g = obja.k;
            int f = obja.h;    //protected ??

            b objb = new b();
            int l = objb.k;
            int g = objb.z;
            Program pobj = new Program();
            int v = pobj.h;

            Console.ReadKey();
        }
    }
}
