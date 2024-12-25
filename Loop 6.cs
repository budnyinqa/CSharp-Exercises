// Calculating aritmetical mean of values provided by a user.

using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;
class Program
{
    static void Main(string[] args)
    {
        int count = 0;
        double sum = 0;
        Console.WriteLine("Please enter numers to calculate the aritmetic mean. Type 'end' to finish.");

        while (true)
        {
            Console.WriteLine("Please enter numer:");
            string input = Console.ReadLine();
            if (input.ToLower() == "end")
            {
                break;
            }

            if (double.TryParse(input, out double number))
            {
                count++;
                sum += number;
            }
            else
            {
                Console.WriteLine("You entered invalid numer. Please try again.");
            }
        }

        double mean = sum / count;

        if (count > 0)
        {
            Console.WriteLine($"The aritmetic mean of the provided numbers is: {mean}.");
        }
        else
        {
            Console.WriteLine("You didn't provide any number.");
        }
    }
}

