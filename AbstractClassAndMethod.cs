using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractCAM
{
  public abstract class Ab
    {
        public abstract void Pout();
    }
    
    public class AbstractClassAndMethod : Ab
    {
        public override void Pout()
            {
            Console.WriteLine("Child Class");
        }
    }
}
