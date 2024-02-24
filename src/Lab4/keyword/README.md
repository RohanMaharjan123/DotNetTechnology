## Program to use this keyword

Name: Program to use this keyword

Date: Feb 24th, 2024

## Source Code

```csharp // See https://aka.ms/new-console-template for more information
using System;

namespace keyword
{
    class Test
    {
        int num;
        Test(int num)
        {
            //this.num refers to the instance field
            this.num = num;
        }
        static void Main(string[] args)
        {
            Test t1 =  new Test(4);
            Console.WriteLine("Value of num :" + t1.num);
            Console.ReadLine();
        }
    }
}
```

## Output

![Program to use this keyword](./output.png)
