using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSample
{
    class Constructor
    {
       public Constructor()
        {
            Console.WriteLine("Default Constructor");  

        }
       public  Constructor(int a)
        {
            Console.WriteLine("Interger Paramterised Constructor - {0}",a);

        }
        public Constructor(string s)
        {
            Console.WriteLine("String Paramterised Constructor - {0}", s);

        }
        public Constructor(double d)
        {
            Console.WriteLine("Double Paramterised Constructor - {0}", d);

        }
        public Constructor(string s1,int b)
        {
            Console.WriteLine("Two Paramterised Constructor - {0}-{1}",s1,b);

        }

    }

    public class ConstructorwithCalling
    {
        public ConstructorwithCalling() :this(50)
        {
            Console.WriteLine("Default Constructor");

        }
        public ConstructorwithCalling(int a)
        {
            Console.WriteLine("Interger Paramterised Constructor - {0}", a);

        }
        public ConstructorwithCalling(string s) : this()
        {
            
            Console.WriteLine("String Paramterised Constructor - {0}", s);

        }
       
    }
}
