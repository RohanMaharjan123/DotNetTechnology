## Simpleinterest

Name: Program to calculate simple interest

Date: Feb 24th, 2024

## Source Code

```csharp // See https://aka.ms/new-console-template for more information
using System;

namespace Simpleinterest
{
    internal class Program
    {
        static void Main(string[] args){
            // program to calculate SI
            float p = 100000, t = 10, r = 8, SI;

            SI = (p * t * r)/100;
            Console.WriteLine(SI);
            Console.ReadLine();
        }
    }
}

```

## Output

![Program to Calculate Simple interest](./output.png)