## Program to find out factorial of a number

Name: Program to find out factorial of a number

Date: Feb 28th, 2024

## Source Code

```csharp // See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        // Input number
        Console.Write("Enter a number to find its factorial: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Calculate factorial
        long factorial = CalculateFactorial(number);

        // Output result
        Console.WriteLine($"Factorial of {number} is: {factorial}");
    }

    // Method to calculate factorial recursively
    static long CalculateFactorial(int n)
    {
        if (n == 0)
        {
            return 1; // Base case: factorial of 0 is 1
        }
        else
        {
            return n * CalculateFactorial(n - 1); // Recursive case: n! = n * (n-1)!
        }
    }
}

```

## Output

![Program to find out factorial of a number](./output.png)
