// See https://aka.ms/new-console-template for more information

// nth element in unsorted array

Console.WriteLine("Hello User!");
int size;
int[] Array;
bool b;
do
{
    Console.WriteLine("Please Enter the Array Size");

    b = int.TryParse(Console.ReadLine(), out size);                 // Checking if array size is numerical

    if (b && size != 0)
    {
        Array = new int[size];
        for (int i = 0; i < size; i++)
        {
            bool c;
            int temp;
            do                                                         //Checking if array Element is numerical & Logging
            {
                Console.WriteLine("Please Enter the Array Element {0}", i + 1);
                c = int.TryParse(Console.ReadLine(), out temp);
                if (c)
                { Array[i] = temp; }
                else { Console.WriteLine("Invalid input Please Retry again\n"); }

            } while (c == false);
        }

        int l;
        bool d;
        do
        {
            Console.WriteLine("\nEnter the 'n' number to find nth smallest Elements in UnsortedArray");
            d = int.TryParse(Console.ReadLine(), out l);
            if (d && l > 0 && l <= size)
            { Console.WriteLine("{0}th element in UnSorted array is {1}", l, Array[l - 1]); }
            else { Console.WriteLine("Invalid input Please Retry\n"); }

        } while (d == false || l == 0 || l > size);
    }
    else
        Console.WriteLine("Invalid input Please Retry\n");

} while (b == false || size <= 0);
