//Create a method that, for a value of type double provided as a parameter, returns a rounded-up
//value of type int.

using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using static System.Runtime.InteropServices.JavaScript.JSType;
class Program
{
    static int double_round_to_int(double x)
    {
        int y = (int)Math.Ceiling(x);
        return y;
    }
    static void Main(string[] args)
    {
        Console.WriteLine($"Rounded-up value of 4.25 is {double_round_to_int(4.25)}");
    }
}
