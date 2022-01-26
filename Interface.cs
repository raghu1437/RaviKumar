using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceConcept
{
     interface InterfaceA
    {
         void CallA();
    }
     interface InterfaceB
    {
         void CallB();
    }
    class child : InterfaceA, InterfaceB
    {
        public void CallA()
        {
            Console.WriteLine("Called Interface-A");
        }
        public void CallB()
        {
            Console.WriteLine("Called Interface-B");
        }

    }
}
