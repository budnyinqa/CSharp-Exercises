//Solve the previous task by printing only every second value to the console.

using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using static System.Runtime.InteropServices.JavaScript.JSType;
class Program
{
    static void print_array(int[] array, int step =1)
    {
        for (int i = 0; i < array.Lenght; i+=step)
        {
            Console.Write(array[i] + " ");
        }
    }
    static void Main(string[] args)
    {
        int[] random_1_to_100 = new int[20];
        Random randomizer = new Random();

        for (int i = 0; i < 20; i++)
        {
            random_1_to_100[i] = randomizer.Next(0, 101);
        }
        Console.WriteLine("Original Array:");
        print_array(random_1_to_100);

        for (int i = 0; i < 20; i++)
        {
            random_1_to_100[i] = 1;
        }
        Console.WriteLine("\n\nArray after update:");
        print_array(random_1_to_100, 2);
    }
}