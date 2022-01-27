// See https://aka.ms/new-console-template for more information

// Median of Unsorted Array

Console.WriteLine("Hello, World!");
Console.WriteLine("Enter the Array Length");
int Len=int.Parse(Console.ReadLine());

int[] Array = new int[Len];
for (int i = 0; i < Len; i++) 
{
    Console.WriteLine("Enter the Array Elements {0}", i + 1);
    Array[i] = int.Parse(Console.ReadLine());
}


int Value = Len % 2;
if (Value == 1)
{
    int a = (Len / 2);
    Console.WriteLine("Median Value of the array is {0}", Array[a]);
}
else 
{
        int b = Len / 2;
        int c = b - 1;
        float d = (Array[b] + Array[c]);
    float e= d / 2;
          Console.WriteLine("Median Value of the array is{0}", e);

}
