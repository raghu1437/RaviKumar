using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismConcept
{
    public class A
    {
        public virtual void  Call()
        {
            Console.WriteLine("Super class");
        }
    }
    public class B : A
    {
        public override void Call()
        {
            Console.WriteLine("Child class - 1");
        }
    }
    public class C : A
    {
        public override void Call()
        {
            Console.WriteLine("Child class - 2");
        }
    }
}
