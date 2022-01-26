using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingConcept
{
    public class MethodOverriding
    {
         int a = 1;
         int b = 2;
        
        public void Add()
        {
            int c = a + b;
            Console.WriteLine(c);
        }        
    }
    public class MethodOverriding1 : MethodOverriding
    {
        int a = 1;
        int b = 2;
        public new void Add()
        {
            int c = a + b+2;
            Console.WriteLine(c);
        }
    }


    // Retain super and sub class implementation.
    public class MethodOverriding2 : MethodOverriding1
    {
        int a = 1;
        int b = 2;
        public new void Add()
        {
            base.Add();
            int c = a + b + 4;
            Console.WriteLine(c);
        }
    }

}
