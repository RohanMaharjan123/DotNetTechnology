using System;

class Program
{
    static void Main(string[] args)
    {
        // Input array
        int[] numbers = { 10, 5, 3, 8, 15, 7 };

        // Find minimum and maximum values
        int min = FindMin(numbers);
        int max = FindMax(numbers);

        // Output results
        Console.WriteLine($"Minimum value in the array: {min}");
        Console.WriteLine($"Maximum value in the array: {max}");
    }

    // Method to find the minimum value in an array
    static int FindMin(int[] arr)
    {
        int min = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
        return min;
    }

    // Method to find the maximum value in an array
    static int FindMax(int[] arr)
    {
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        return max;
    }
}
