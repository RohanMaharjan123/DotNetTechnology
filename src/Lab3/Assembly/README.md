## Program to use Assembly in C#

Name: Program to use Assembly in C#

Date: Feb 24th, 2024

## Source Code

```csharp // See https://aka.ms/new-console-template for more information
using System;
namespace Assembly
{
    class Student
    {
        internal string name = "Shreean";
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Student thestudent = new Student();

            Console.WriteLine("Name :" + thestudent.name);
            Console.ReadLine();
        }
    }
}
```

## Output

![Program to use Assembly in C#](./output.png)
