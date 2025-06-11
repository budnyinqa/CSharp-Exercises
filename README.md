# CSharp - Exercises
This repository contains a collection of beginner level C# exercises. Each file focuses on concepts such as arrays, loops and methods. The purpose is to practice fundamental skills and build fluency in the C# programming language.

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



## Loop

### Loop 1 - Printing numbers divisible by 3 or 5 in the range of 1 to 100

I practiced:
- writing concise control flow for targeted output,
- efficient filtering of values using conditions.

Code Snippet:
```C#
for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 || i % 5 == 0)
        Console.WriteLine(i);
}
```
The condition i % 3 == 0 || i % 5 == 0 evaluates to true for values divisible by either number.


### Loop 2 - Verifying if value provided by a user is a positive number

I practiced:
- implementing a while loop for repeated input,
- guarding against invalid or unexpected data.

Code Snippet:
```C#
while ((!int.TryParse(input, out int result) || (result <= 0)))
{
    Console.WriteLine("Wrong input. Try with a positive number");
    input = Console.ReadLine();
}
```
The combined condition (!TryParse || result <= 0) filters out both non-numeric and negative/zero inputs.


### Loop 3 - Calculating the volume of a rectangle based on the dimensions provided by a user

I practiced:
- sequential user input with validation,
- reuse of input validation logic for multiple fields,
- output formatting with interpolated strings.

Code Snippet:
```C#
Console.WriteLine($"The volume of a rectangle based on the provided dimensions: {int_a * int_b * int_c}");
```
Volume is calculated as length × width × height and displayed in a readable message.


### Loop 4 - Sum of the first 'n' even numbers, where 'n' value is provided by a user

I practiced:
- Combining input validation with multiple conditions (positivity + parity),
- generating and summing a specific numeric pattern.

Code Snippet:
```C#
for (int i = 0; i < int_n; i++)
{
    sum += 2 * i;
}
```
The program validates the input to ensure it's both positive and even before proceeding.


### Loop 5 - Calculating the arithmetic mean of 'n' numbers provided by the user

I practiced:
- input validation for both integer (n) and floating-point values,
- handling incorrect input gracefully inside a loop.

Code Snippet:
```C#
while (i <= int_n)
{
    Console.WriteLine($"Enter number {i}:");
    string input = Console.ReadLine();
    if (double.TryParse(input, out double number))
    {
        i++;
        sum += number;
    }
    else
    {
        Console.WriteLine("You entered invalid number. Please try again");
    }
}
```
Input collection uses a while loop with a counter to ensure exactly n valid numbers are entered.


### Loop 6 - Calculating arithmetical mean of values provided by a user

I practiced:
- infinite loop with user-defined exit condition,
- dynamic accumulation (sum and count) without knowing input size beforehand,
- handling edge cases (e.g., zero valid inputs),
- case-insensitive string comparison.

Code Snippet:
```C#
if (input.ToLower() == "end")
{
    break;
}
```
Program does not require the user to know how many numbers they want to enter in advance. Keyword "end" stops input and triggers calculation.



## Methods


