using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismFuncOverloading
{
    class Class1
    {
        public void Ford()
        {
            Console.WriteLine(" im a car");
        }
        public void Ford(int no)
        {
            Console.WriteLine(" im a ford  car" + "  " + no);
        }
        public void Ford(int id, int modelNO)
        {
            Console.WriteLine(" im a ford car with id and modelno " + "  " + id + "  " + modelNO);
        }
    }
}
