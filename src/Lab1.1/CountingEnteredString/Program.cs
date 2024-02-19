using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        int characterCount = CountCharacters(input);

        Console.WriteLine($"Number of characters entered: {characterCount}");
    }

    static int CountCharacters(string input)
    {
        // Use the Length property of the string to get the number of characters
        return input.Length;
    }
}
