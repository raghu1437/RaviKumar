using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerSignUp
{
    public class CustomerList : CustomerInput { };
    public class CustomerInput
    {
        public string FirstName { get; set; }

        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string ID { get; set; }
        public string EmailID { get; set; }
        public ulong ContactNumber { get; set; }
              
        public ulong ADHAARNumber { get; set; }  
        //public string NomineeName { get; set; }
        //public string PANNumber { get; set; }

        public double Deposit { get;set;}
        public double Balance { get; set; }

                       
    }
    



}
