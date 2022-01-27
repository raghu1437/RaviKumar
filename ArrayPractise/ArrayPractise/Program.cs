// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


int[] Number=new int[5];
Number[0]=10;
Number[1]=11;
Number[2]=12;   
Number[3]=13;
Number[4]=14;
Console.WriteLine("There is an array of 5 Numbers");
Console.WriteLine("Do you want to know the Array Element-Enter any number b/W 1 and 5");
int i = int.Parse(Console.ReadLine());
Console.WriteLine("{0}", Number[i - 1]);