using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statickeyword

{
    internal class StaticAndNonStatic
    {            public string s1 = "Kumar";
        public static int b=5;
                public void Nonstaticmethod(double s)
        {
            
                     Console.WriteLine("Non Static Method-{0} {1} ",s,s1);
        }

        public static void Staticmethod(string m)
        {
            Console.WriteLine(b);
                    Console.WriteLine("Static Method - {0}",m);
        }

    }
}
