using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingConfig
{

    public interface ITask
    {
        public void Cheque();
        
    }
    public class Cashier :ITask
    {        
        public void Cheque()
        {
            //cheques less than 50K
            Console.WriteLine("Handles cheque deposit/withdrawal");
        }
        public virtual void Deposit_withdraw()
        {
            Console.WriteLine("Deposit or withdraws amount from account");
        }

        public void Cash()
        {
            Console.WriteLine("Deposits cash to customer account ");
        }
    }
    public class Manager : ITask
    {
        public void Cheque()
        {
            Console.WriteLine("Handle's cheque signature for large amount");
        }
        public void Loan()
        {
            Console.WriteLine("Manages Loan related task (info & details) for customer");
        }
    }
    public class Clerk : ITask
    {
        public void Cheque()
        {
            Console.WriteLine("Movement of cheques for signature");
        }
        public void Multitasking()
        {
            // Transfer of files
            // Documents photocopy
            Console.WriteLine("document/file transfer within staff");
        }
    }
    //customer
    public class Customer : Cashier
    {
        public override void Deposit_withdraw()
        {
            Console.WriteLine("Deposit or withdraws amount from customer account");
        }
    }
    public class Customer1 : Cashier
    {
        public override void Deposit_withdraw()
        {
            Console.WriteLine("Deposit or withdraws amount from customer1 account");
        }
    }
}
