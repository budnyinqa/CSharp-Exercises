//Create a two-dimensional array (NxN, where N=10) and fill it with random numbers from the range <1,20>.
//If the first element in a row is even (%), swap it with the last element of the row. 
//Print the array before and after the swap.

using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;
class Program
{
    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j].ToString().PadLeft(4)); 
            }
            Console.WriteLine();
        }
    }
    static void Main(string[] args)
    {
        Random randomizer = new Random();

        int[,] random_numbers = new int[10, 10];

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                random_numbers[i, j] = randomizer.Next(1, 21);            
            }
        }
        Console.WriteLine("Array before swapping:");
        PrintArray(random_numbers);

        for (int i = 0; i < 10; i++)
        {
            if (random_numbers[i, 0] % 2 == 0)
            {
                int temp = random_numbers[i, 0];
                random_numbers[i, 0] = random_numbers[i, 9];
                random_numbers[i, 9] = temp;
            }
        }
        Console.WriteLine("\nArray after swapping:");
        PrintArray(random_numbers);
    }
}
