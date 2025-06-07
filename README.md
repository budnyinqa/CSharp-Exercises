# CSharp - Exercises
This repository contains a collection of beginner level C# exercises. Each file focuses on concept such as arrays, loops, or methods. The purpose is to practice fundamental skills and build fluency in the C# programming language.

## Array

### Array 1 - Create a one-dimensional array of 10 integers and fill it with the values from 1 to 10. Print all elements to the console.

I practiced:
- creating and initializing arrays,
- using a for loop for indexing and iteration,
- basic console output.


### Array 2 - Create a two-dimensional array (NxN, where N=10) and fill it with the multiplication table. Print the contents of the array row by row.

I practiced:
- performing arithmetic operations within array assignments,
- understanding how row/column indexing works in a matrix.

Code Snippet:
```C#
int[,] multiplication_table = new int[10, 10];

// Fill the array with the multiplication table
for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        multiplication_table[i, j] = (i + 1) * (j + 1);
    }
}
```


### Array 3.1 - Create a two-dimensional array (NxN, where N = 10) and fill it with random numbers from the range <1,20>. If the first element of a row is even, swap it with the last element of that row. Print the array before and after the swap.

I practiced:
- generating random integers with Random.Next(),
- using the modulo operator % to check even numbers,
- performing in-place swaps of array elements,
- creating reusable methods (like PrintArray).

Code Snippet:
```C#
static void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j].ToString().PadLeft(4));
        }
        Console.WriteLine();
    }
}
```


### Array 3.2 - In the array from task 3, fill the main diagonal of the array with '1'. Print the array row by row.

I practiced:
- index matching for square matrices,
- modifying in-place array data,
- understanding matrix diagonals.

Code Snippet:
```C#
for (int i = 0; i < 10; i++)
{
    random_numbers[i, i] = 1;
}
```
This loop modifies the main diagonal of a square matrix by assigning the value 1 to every cell where the row and column indices are equal.


### Array 4 - Create a two-dimensional array (NxN, where N = 10). Randomly choose p – a positive integer less than 10. In p cells at random indices, insert values provided by the user. Fill the remaining cells with ones. Print the array row by row.

I practiced:
- generating random integers for coordinates,
- accepting user input in a loop,
- avoiding overwriting fixed-size array elements.

Code Snippet:
```C#
for (int i = 0; i < p; i++)
{
    int row = randomizer.Next(0, N);
    int col = randomizer.Next(0, N);
    Console.WriteLine($"Please enter a value for the position:\nRow: {row + 1}, Column: {col + 1}");
    int user_input = Convert.ToInt32(Console.ReadLine());
    array[row, col] = user_input;
}
```
This part randomly selects p positions within the array, asks the user to input a value for each selected cell and updates the chosen positions while leaving the rest of the array filled with 1.

































