using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    public delegate void delName(string name);
    class DelegateEg
    {
        public void Bmw(string para)
        {
            Console.WriteLine(para);
        }
        public void Mercedes(string model)
        {
            Console.WriteLine(model);
        }
    }
}
