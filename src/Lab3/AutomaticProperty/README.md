## Program to use automatic property in C#

Name: Program to use automatic property in C#

Date: Feb 28th, 2024

## Source Code

```csharp // See https://aka.ms/new-console-template for more information
using System;

public class Person
{
    // Automatic property for Name, marked as nullable
    public string? Name { get; set; }

    // Automatic property for Age
    public int Age { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of Person class
        Person person = new Person();

        // Setting values using automatic properties
        person.Name = "Rose";
        person.Age = 23;

        // Getting values using automatic properties
        Console.WriteLine("Name: " + person.Name);
        Console.WriteLine("Age: " + person.Age);
    }
}

```

## Output

![Program to use automatic property in C#](./output.png)
