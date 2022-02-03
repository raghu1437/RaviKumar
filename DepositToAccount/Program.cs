


CustomerSignUp.CustomerInput c = new CustomerSignUp.CustomerInput();
List<string> accountInfo = new List<string>();


Console.WriteLine("Hi, Welcome to Bank Account Sign Up");


Console.WriteLine("Enter First Name");
c.FirstName = Console.ReadLine();

Console.WriteLine("Enter Middle Name");
c.MiddleName = Console.ReadLine();

Console.WriteLine("Enter Last Name");
c.LastName = Console.ReadLine();

Console.WriteLine("Enter ADHAAR Number");
c.ADHAARNumber = Convert.ToUInt64(Console.ReadLine());

Console.WriteLine("Enter Contact Number");
c.ContactNumber = Convert.ToUInt64(Console.ReadLine());

Console.WriteLine("Enter Account Type From Below list \n");
string[] E = Enum.GetNames(typeof(DepositToAccount.Enums.AccountType));
foreach (string e in E)
{
    Console.WriteLine(e + "-{0}", (int)Enum.Parse(typeof(DepositToAccount.Enums.AccountType), e));
}
int accType = int.Parse(Console.ReadLine());
DepositToAccount.Enums.AccountType rv = (DepositToAccount.Enums.AccountType)accType;
string customerAccountType = rv.ToString();

Console.WriteLine("Customer Registered Successfully");

depositDetails();
accountBalance();

// Deposit Amount
void depositDetails()
{
    ulong contactNumber = 0;

    Console.WriteLine("\n Do you want to Deposit -  Y / N");
    do
    {
        string input = Console.ReadLine().ToLower();
        if (input.Equals("y"))
        {
            Console.WriteLine("Enter the Customer Contact number");
            contactNumber = Convert.ToUInt64(Console.ReadLine());
            if (c.ContactNumber == contactNumber)
            {
                Console.WriteLine("Enter the Deposit Amount");
                c.Deposit = double.Parse(Console.ReadLine());
                Console.WriteLine("Amount Deposited Successfully");
            }
            else if (c.ContactNumber != contactNumber)
            {
                Console.WriteLine("The Customer with {0} Contact Number doesnot Exist", contactNumber);
                Console.WriteLine("Enter the Customer Contact number");
            }
        }
        else { return; }
    } while (c.ContactNumber != contactNumber);

}

// Account Balance

void accountBalance()
{
    ulong contactNumber = 0;
    do
    {
        Console.WriteLine("Do you want to Check Balance -  Y / N");
        string input = Console.ReadLine().ToLower();
        if (input.Equals("y"))
        {
            Console.WriteLine("Enter the Customer Contact number");
            contactNumber = Convert.ToUInt64(Console.ReadLine());
            if (c.ContactNumber == contactNumber)
            {
                c.Balance = c.Balance + c.Deposit;
                setCustomerDetails();
            }

            else if (c.ContactNumber != contactNumber)
            {
                Console.WriteLine("The Customer with {0} Contact Number doesnot Exist", contactNumber);
            }

        }
        else { return; }
    } while (c.ContactNumber != contactNumber);
}


// Fetchs Customer Detail

List<string> setCustomerDetails()
{

    accountInfo.Add("Customer Name : " + c.FirstName + " " + c.MiddleName + " " + c.LastName);
    //accountInfo.Add(c.MiddleName);
    //accountInfo.Add(c.LastName);
    accountInfo.Add("ADHAAR Number : " + c.ADHAARNumber.ToString());
    accountInfo.Add("Contact Number : " + c.ContactNumber.ToString());
    accountInfo.Add("Type Of Account : " + customerAccountType);
    accountInfo.Add("Amount deposited (Rs) : " + c.Deposit.ToString());
    accountInfo.Add("Balance Available (Rs) : " + c.Balance.ToString());


    Console.WriteLine("\n ****** Customer Details ******");
    foreach (string s in accountInfo)
    {

        Console.WriteLine(s);

    }
    return accountInfo;
}

