//Declare two variables of type int and assign them values 10 and 20. Create a method that swaps 
//the values of the two variables. Print the values of the variables before and after calling the method.
//a) Pass the parameters by value,
//b) Pass the parameters by reference.

using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using static System.Runtime.InteropServices.JavaScript.JSType;
class Program
{
    static void Swap_by_value(int x, int y)
    {
        int temp = x;
        x = y;
        y = temp;
        Console.WriteLine($"Values after calling the 'Swap_by_value' method: x={x}, y={y}");
    }

    static void Swap_by_reference(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }

    static void Main(string[] args)
    {
        int x = 10, y = 20;
        Console.WriteLine($"a)\nOriginal Values: x={x}, y={y}");
        Swap_by_value(x, y);
        Console.WriteLine($"\n\nb)\nOriginal Values: x={x}, y={y}");
        Swap_by_reference(ref x, ref y);
        Console.WriteLine($"Values after calling the 'Swap_by_reference' method: x={x}, y={y}");
    }
}