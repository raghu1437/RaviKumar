// See https://aka.ms/new-console-template for more information


// Program On Inheritance and Polymorphism

Console.WriteLine("enter number of apple mobiles");
int i=int.Parse(Console.ReadLine());

Console.WriteLine("Enter Number of Vivo Mobiles");
int j = int.Parse(Console.ReadLine());

Moblies[] M1=new Apple[i];
for (int g = 0; g < i; g++)
{
    
    Console.WriteLine("Enter Display for Apple mobile {0}",g+1);
    string D = Console.ReadLine();

    Console.WriteLine("Enter Colour for Apple mobile {0}", g + 1);
    string C = Console.ReadLine();

    Console.WriteLine("Enter Battery for Apple mobile {0}", g + 1);
    string B = Console.ReadLine();

    Console.WriteLine("Enter Amount for Apple mobile {0}", g + 1);
    float f = float.Parse(Console.ReadLine());


    M1 [g] = new Apple(D, C, B,f);
    M1[g].Printout1 ();
    
}
Moblies[] M2 = new Vivo[i];
for (int k = 0; k < j; k++)
{

    Console.WriteLine("Enter Display for Vivo mobile {0}", k + 1);
    string D1 = Console.ReadLine();

    Console.WriteLine("Enter Colour for Vivo mobile {0}", k + 1);
    string C1 = Console.ReadLine();

    Console.WriteLine("Enter Battery for Vivo mobile {0}", k + 1);
    string B1 = Console.ReadLine();

    Console.WriteLine("Enter Amount for Vivo mobile {0}", k + 1);
    float f1 = float.Parse(Console.ReadLine());


    M2[k] = new Vivo(D1, C1, B1, f1);
    M2[k].Printout1();


}

for(int a=0;a<i;a++)
{
    M1[a].Printout1();
}
for (int b = 0; b < j; b++)
{
    M2[b].Printout1();
}

public class Moblies
{
    public string _display;
    public string _colour;
    public string _battery;

        public virtual void Printout1()
    {
        Console.WriteLine("This Mobiles have {0} display,{1} battery and is {2} in colour", _display, _battery, _colour);
    }

}

public class Apple : Moblies
{
    float _Amount;
    public Apple(string display, string colour, string battery,float amount)
    {
        this._display = display;
        this._colour = colour;
        this._battery = battery;
        this._Amount = amount;
    }

    public override void Printout1()
    {
        Console.WriteLine("This Mobiles is Apple make have {0} display,{1} battery and is {2} in colour and amount is {3} ", _display, _battery, _colour,_Amount);
    }

}

public class Vivo : Moblies
{
    float _Amount;
    public Vivo(string display, string colour, string battery, float amount)
    {
        this._display = display;
        this._colour = colour;
        this._battery = battery;
        this._Amount = amount;
    }

    public override void Printout1()
    {
        Console.WriteLine("This Mobiles is Vivo make have {0} display,{1} battery and is {2} in colour and amount is {3} ", _display, _battery, _colour, _Amount);
    }

}