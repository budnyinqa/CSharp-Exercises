//In the array from task 3, fill the main diagonal of the array with '1'. Print the array row by row.

using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;
class Program
{
    //Previous Exercise
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

        //Current Exercise
        for (int i = 0; i < 10; i++)
        {
            random_numbers[i, i] = 1;
        }
        Console.WriteLine("\nArray after modifying the diagonal:");
        PrintArray(random_numbers);
    }
}