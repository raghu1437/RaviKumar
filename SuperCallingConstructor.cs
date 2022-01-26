using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCallingConstructorSample
{
    public class SuperConstructor
    {
        public SuperConstructor()
        {
            Console.WriteLine("Constructor-Super");
        }
    }
    public class SubConstructor1 : SuperConstructor
    {
        public SubConstructor1():base() 
        {
            Console.WriteLine("Constructor-Sub-1");
        }
    }
    public class SubConstructor2 : SubConstructor1
    {
        public SubConstructor2() : base()
        {
            Console.WriteLine("Constructor-Sub-2");
        }
    }
    public class SubConstructor3 : SubConstructor2
    {
       public  SubConstructor3() : base()
        {
            Console.WriteLine("Constructor-Sub-3");
        }
    }
}
