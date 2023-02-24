using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionOverriding
{
    class Base
    {
        public virtual void Mercedes()
        {
            Console.WriteLine(" s class");
        }
    }
    class Derived : Base
    {
        public override void Mercedes()
        {
            Console.WriteLine(" I am Benz  ");
        }
    }
}
