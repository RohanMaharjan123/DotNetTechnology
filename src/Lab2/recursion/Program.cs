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
