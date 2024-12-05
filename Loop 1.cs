// Printing numbers divisible by 3 or 5 in the range of 1 to 100
using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;
class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 || i % 5 == 0) Console.WriteLine(i);
        }
    }
}
