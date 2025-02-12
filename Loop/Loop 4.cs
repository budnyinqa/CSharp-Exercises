// Sum of the first 'n' even numbers, where 'n' value is provided by a user.

using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a positive even number:");
        string n = Console.ReadLine();

        while (!int.TryParse(n, out int result) || (result <= 0) || (result % 2 != 0))
        {
            Console.WriteLine("You enetred invalid number. Please remember that the value has to be positive and even.");
            n = Console.ReadLine();
        }
        int int_n = Convert.ToInt32(n);
        int sum = 0;

        for (int i = 0; i < int_n; i++)
        {
            sum += 2 * i;
        }
        Console.WriteLine($"Sum of the first {n} even numbers: {sum}");
    }
}