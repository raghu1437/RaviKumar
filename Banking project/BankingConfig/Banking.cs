using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingConfig
{

    public class Bank
    { /*
	    Branch ID
	    Branch Address
	    IFSC Code
	    Total Customer Account
	    Number of Savings Bank accounts
	    Number of current accounts
	    Number of Fixed Depost accounts
	    Number of Recurring Deposit accounts
        Cash available in Branch - to be made abstraction
        
        */

    }


    public class Employees
    {
        /*

        Employee Name
        Employee ID_Number
        Employee Email_ID
        Employee Contact Number
        Employee USer ID
        Employee password
        Employee Blood group
        Employee Date of Joining
        Employee Login Time****
        Employee Loout time**** 
        Employee salary **** 

        */

    }

    public class Customer
    {
        /*
         
        Customer First name
        Customer Middle name
        Customer last name
        Customer ID_number
        Customer Email_ID
        Customer Contact Number
        Customer PAN detail
        Customer ADHAAR detail
        Customer Nominee Detail
        Customer Internet Banking_ID****
        Customer Internet Banking_Password****
        Customer UPI_ID   ****
        Customer UPI_Password ****
        Customer Multiple accounts

        */
    }


    public class Account
    {
        /*

		Account_ID
		Account Number
		Account Type
		Account Balance
		Account started On
		Account last transacation****

		*/
    }
    public class SavingsAccount : Account
    {
        /*
	     
        Savings Account_ID
	    Savings Account Number
	    Savings Account Type[salaried / single user / student / minor]
	    Savings Account Balance
	    Savings Account started On
	    Interest rate
	    Statement of account
	:   Transcaction
    :   Account last transacation****
	
	    */

    }
    public class CurrentAccount : Account
    {

        /* 
        Current Account_ID
        Current Account Number
        Current Account Type[cash - credit / current / OD]
        Current Account Balance
        Current Account started On
        Interest rate
        statement of account
        Transcaction
        Over draft facility
        Account last transacation ****
        */

    }


    public class FixedDepositAccount : Account
    {

        /*
        Fixed Deposit Account_ID
    :   Fixed DepositAccount Number
        Fixed Deposit Account Type[Senior citizen / Non senior citizen]
        Fixed Deposit Account Balance
        Fixed Deposit Account started On
        Fixed Deposit Amount 
        Interest rate
        Total Tenure
        Tenure remaining
        Maturity date
        Maturity amount
        statement of account
        */
    }

    public class RecurringDepositAccount : Account
    {
        /*
          Recurring Deposit Account_ID
          Recurring DepositAccount Number
          Recurring Deposit Account Type[Senior citizen / Non senior citizen]
          Recurring Deposit Account Balance
          Recurring Deposit Account started On
          Recurring Deposit Amount 
          Recurring deposit amount
          Interest rate
          Total Tenure
          Tenure remaining
          Next RD Payment Due Date
          Date of Completion
          Total Amount on Completion
          Statement of account

          */
    }

    public class LoanAccount : Account
    {
        /*
           Loan Account_ID
           Loan Account Number
           Loan Type[Home / Vehicle / Construction / Mortage]
           Loan Sanctioned Amount
           Loan Account started On
           Interest rate
           Total Loan Duration
           Remaining Load duration
           EMI amount
           Next EMI Payment Due Date
           Balance Principle amount
           Collatral Details
           Insurance of Borrower
           Insurance for collatral
           Date of Completion
           statement of account
        */
    }

    public class Transaction
    {
        /*
            Cash Deposit
            Cash Withdrawal
            Cheque deposit
            Cheque withdrawal
            UPI Transaction
            RTGS Transaction
            NEFT Transaction
            Letter of Credit
            DD Generatiom
            DD deposit
            Tranaction number
            Tranaction date / time
            Employee ID
            Balance update
        */

    }
    public class Cashier : Employees
    {
        /*
            Generate DD
            Deposit amount
            Withdraw amount
            Cheque clearance
        */
    }

    public class LoanOfficer : Employees
    {
        /*
            Loan documnet Verification
            Loan approval formalities
            Loan rejection formalities
            Loan Recovery
            Loan account termination
        */
    }

    public class BranchManager : Employees
    {
        /*
            Staff management
            Home Branch communication
            Arragement of cash from RBI
            Employee benifits
            Loan pproval
            Loan rejection
        */
    }

    public class MultitaskingStaff : Employees
    {

        /*
        Movement of files
        New cheques Issue
        basic info to new customers
        Pass book printing
        Statement of account
        */
    }
}
