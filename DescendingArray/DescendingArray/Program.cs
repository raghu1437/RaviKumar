﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello User!");
int size;
int[] Array;
bool b;
do
{
    Console.WriteLine("Please Enter the Array Size");

    b = int.TryParse(Console.ReadLine(), out size);                 // Checking if array size is numerical

    if (b && size > 0)
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

        for (int j = 0; j < size; j++)                        //Sorting Array in Descending
        {
            for (int k = 0; k < size; k++)
                if (Array[j] > Array[k])
                {
                    int temp1 = Array[j];
                    Array[j] = Array[k];
                    Array[k] = temp1;
                }
        }

        Console.WriteLine("\nDescending order of Array Elements");       //Printing Array in Descending

        foreach (int l in Array)
        {
            Console.WriteLine(l);
        }
    }

    else
        Console.WriteLine("Invalid input Please Retry\n");

} while (b == false || size <= 0);
