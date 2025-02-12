// Create a one-dimensional array with ten elements and fill it with integers from 1 to 10.
// Print the contents of the array to the console.

using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;
class Program
{
    static void Main(string[] args)
    {
        int[] one_to_ten = new int[10];
        for (int i = 0; i < 10; i++)
        {
            one_to_ten[i] = i + 1;
        }

        for (int i = 0; i < one_to_ten.Length; i++)
        {
            Console.WriteLine("Item[{0}] equals: {1}", i, one_to_ten[i]);
        }

    }
}
