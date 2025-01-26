//Utwórz tablicę dwuwymiarową (NxN, N = 10). Wylosuj p – dodatnią liczbę całkowitą mniejszą od 
//10. W p polach o losowych indeksach wpisz wartości podane przez użytkownika. Pozostałe pola 
//wypełnij jedynkami. Wypisz tablicę wierszami.

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