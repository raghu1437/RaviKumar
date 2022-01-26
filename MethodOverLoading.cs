using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoading
{
    class MethodOverLoading
    {
        public void Test()
        {
            Console.WriteLine("No Parameter");
        }
        public void Test(int a)
        {
            int b = a+10;
            Console.WriteLine("int Parameter - {0}",b);
        }
        public void Test(string c)
        {
            Console.WriteLine("String Parameter - {0}",c);

        }

        public void Test(int a,string c)
        {
            Console.WriteLine("integer and String Parameter - {0} + {1}", a,c);

        }
        public void Test(string c,int a)
        {
            Console.WriteLine("String and integer Parameter - {0} + {1}", c,a);

        }
    }
}
