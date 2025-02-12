// Calculating the arithmetic mean of 'n' numbers provided by the user:

using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter the number of elements (n):");
        string n = Console.ReadLine();

        while (!int.TryParse(n, out int result) || (result <= 0))
        {
            Console.WriteLine("You enetred invalid number. Please remember that the value has to be positive.");
            n = Console.ReadLine();
        }
        int int_n = Convert.ToInt32(n);
        double sum = 0;
        int i = 1;

        while (i <= int_n)
        {
            Console.WriteLine($"Enter numer {i}:");
            string input = Console.ReadLine();
            if (double.TryParse(input, out double number))
            {
                i++;
                sum += number;
            }
            else
            {
                Console.WriteLine("You enetred invalid number. Please try again");
            }
        }
        double mean = sum / int_n;
        Console.WriteLine($"The aritmetical mean of the provided numbers: {mean}");
    }
}
