// Calculating the volume of a rectangle based on the dimensions provided by a user.

using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter first value:");
        string a = Console.ReadLine();
        while ((!int.TryParse(a, out int result) || (result <= 0)))
        {
            Console.WriteLine("You enetred invalid number. Please remember that the value has to be positive.");
            a = Console.ReadLine();
        }
        int int_a = Convert.ToInt32(a);

        Console.WriteLine("Please enter second value:");
        string b = Console.ReadLine();
        while ((!int.TryParse(b, out int result) || (result <= 0)))
        {
            Console.WriteLine("You enetred invalid number. Please remember that the value has to be positive.");
            b = Console.ReadLine();
        }
        int int_b = Convert.ToInt32(b);

        Console.WriteLine("Please enter third value:");
        string c = Console.ReadLine();
        while ((!int.TryParse(c, out int result) || (result <= 0)))
        {
            Console.WriteLine("You enetred invalid number. Please remember that the value has to be positive.");
            c = Console.ReadLine();
        }
        int int_c = Convert.ToInt32(c);

        Console.WriteLine($"The volume of a rectangle based on the provided dimensions: {int_a * int_b * int_c}");
    }
}
