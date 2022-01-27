// See https://aka.ms/new-console-template for more information
/*SAMPLE VENDOR MACHINE
 WITH OUT LOOP METHOD */

int  TotalAmount = 0;

Console.WriteLine("HI User");
jump1:
Console.WriteLine("Please select the Product: 1- Pepsi, 2-Coke, 3-Sprite, 4-Mountain Dew 5-Water");
int Selection;
bool valid = int.TryParse(Console.ReadLine(), out Selection);           // validating Numerical input
if (valid)
{
    switch (Selection)
    {
        case 1:
            TotalAmount += 25;
            break;
        case 2:
            TotalAmount += 26;
            break;
        case 3:
            TotalAmount += 27;
            break;
        case 4:
            TotalAmount += 28;
            break;
        case 5:
            TotalAmount += 20;
            break;

        default:

            Console.WriteLine("Your Input is invalid.Please enter the Selection again\n");
            goto jump1;

    }
}
else
{
    Console.WriteLine("Your Input is invalid.Please enter the Selection again\n");
    goto jump1;
}

jump2:
Console.WriteLine("Do you want to continue with Purchasing.Type Yes Or No\n");
string input1= Console.ReadLine();                                                  

    bool test= String.IsNullOrWhiteSpace( input1);                                          // validating Alpahbetic input
if (test)
{
    Console.WriteLine("Input invalid\n");
    goto jump2;

}
else
{
    string lowerinput=input1.ToLower();
    if (lowerinput == "yes" || lowerinput == "no")
    {
        switch (lowerinput)
        {
            case "yes":
                goto jump1;
            case "no":
                break;

        }
    }
else
        {
            Console.WriteLine("Input invalid\n");
            goto jump2;
        }
}
Console.WriteLine("\nThank you for Purchasing\nYour total payable Amount is Rupees {0}", TotalAmount);
Console.WriteLine("Great Day Visit Again");


