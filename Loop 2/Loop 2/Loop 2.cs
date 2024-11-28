// Veryfing if value provided by a user is a positive number.

using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please insert a positive number:");
        string input = Console.ReadLine();

        while ((!int.TryParse(input, out int result) || (result <= 0)))
        {
            Console.WriteLine("Wrong Imput. Try with a positive number");
            input = Console.ReadLine();
        }
        Console.WriteLine("You entered a positive number");
        Convert.ToInt32(input);
    }
}
