using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConcept

{
   public class InheritanceSingleLevel
    {
       public void call1()
        {
            Console.WriteLine("Superclass-1");
        }
    }
    public class InheritanceSingleLevel1 : InheritanceSingleLevel
    {
        public void call2()
        {
            Console.WriteLine("Childclass-1");
        }
    }

    // Multilevel inheritance 
    public class InheritanceMultileLevel : InheritanceSingleLevel1
    {
        public void call3()
        {
            Console.WriteLine("Childclass-2");
        }
    }

    // Hybrid inheritance

    public class InheritanceHybridLevel : InheritanceSingleLevel
    {
        public void call4()
        {
            Console.WriteLine("Hybridsubclass-1");
        }
    }
    public class InheritanceHybridLevel1 : InheritanceSingleLevel
    {
        public void call5()
        {
            Console.WriteLine("Hybridsubclass-2");
        }
    }
}
