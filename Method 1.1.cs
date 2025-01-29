//Create a one-dimensional array with 20 elements. Fill it with random int values ranging from 0 to 100.
//Print the contents of the array to the console. Then, fill the array with ones. Print it again.
//Use a method that prints the contents of the array.


using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using static System.Runtime.InteropServices.JavaScript.JSType;
class Program
{
    static void print_array(int[] array)
    {
        for (int i = 0; i < 20; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
    static void Main(string[] args)
    {
        int[] random_1_to_100 = new int[20];
        Random ranodmizer = new Random();

        for (int i = 0; i < 20; i++)
        {
            random_1_to_100[i] = ranodmizer.Next(0, 101);
        }
        Console.WriteLine("Original Array:");
        print_array(random_1_to_100);

        for (int i = 0; i < 20; i++)
        {
            random_1_to_100[i] = 1;
        }
        Console.WriteLine("\n\nArray after update:");
        print_array(random_1_to_100);
    }
}
