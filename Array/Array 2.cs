//Create a two-dimensional array (NxN, where N=10) and fill it with the multiplication table. 
//Print the contents of the array row by row

using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using static System.Runtime.InteropServices.JavaScript.JSType;
class Program
{
    static void Main(string[] args)
    {
        int[,] multiplication_table = new int[10, 10];

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                multiplication_table[i, j] = (i + 1) * (j + 1);
            }
        }

        Console.WriteLine("Multiplication_table:");    
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10;j++)
            {
                Console.Write(multiplication_table[i, j].ToString().PadLeft(4));
            }
            Console.WriteLine();
        }
    }
}