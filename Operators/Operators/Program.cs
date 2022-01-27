// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int i = 10;
bool Isnumber;
if (i == 11)                                                            // without Ternary Operator
{Isnumber=true;}
else
{ Isnumber=false;}
Console.WriteLine("Interger {0}=11 hence {1}", i, Isnumber);

bool Isnumber1=i==10?true:false;                                        // Ternary Operator
Console.WriteLine("Interger number {0} =10 is {1}",i, Isnumber1);

int ?j=null;
Console.WriteLine(j);

int ? H = null;
int OP = H ?? 0;                                                        // null Colasing Operator
Console.WriteLine("Value available {0}",OP);


