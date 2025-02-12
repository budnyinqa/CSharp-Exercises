//Create a two-dimensional array (NxN, where N = 10). Randomly choose p – a positive integer less than 10. In p cells at random indices, insert values provided by the user. 
//Fill the remaining cells with ones. Print the array row by row.

using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;
class Program
{
    
    static void Main(string[] args)
    {
        int N = 10;
        int[,] array = new int[N, N];

        Random randomizer = new Random();
        int p = randomizer.Next(0, N);

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                array[i, j] = 1;
            }
        }

        for (int i = 0; i < p; i++)
        {
            int row = randomizer.Next(0, N);
            int col = randomizer.Next(0, N);
            Console.WriteLine($"Pleate enter a value for the posiotion:\nRow: {row+1}, Column: {col+1}");
            int user_input = Convert.ToInt32( Console.ReadLine() );
            array[row, col] = user_input;
        }

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(array[i, j].ToString().PadLeft(4));
            }
            Console.WriteLine();
        }
    }
}