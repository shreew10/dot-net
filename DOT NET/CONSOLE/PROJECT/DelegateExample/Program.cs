using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // object of class
            DelegateEg objP = new DelegateEg();

            //object of delegate
            delName objDel = new delName(objP.Bmw);
            objDel("720D");
            objDel.Invoke("320D");

            //new delegate object
            delName objDel2 = new delName(objP.Mercedes);
            objDel2("S-class");
            Console.ReadKey();
        }
    }
}
