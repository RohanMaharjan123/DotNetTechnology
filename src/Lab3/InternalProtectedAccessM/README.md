## Program to illustrate internal protected access modifier

Name: Program to illustrate internal protected access modifier

Date: Feb 28th, 2024

## Source Code

```csharp // See https://aka.ms/new-console-template for more information
using System;

// Define a base class
internal class MyBaseClass
{
    // Define a method with internal protected access modifier
    internal protected void InternalProtectedMethod()
    {
        Console.WriteLine("This method can be accessed within the same assembly and by derived classes.");
    }
}

// Define a derived class in the same assembly
internal class MyDerivedClass : MyBaseClass
{
    public void CallInternalProtectedMethod()
    {
        // Access the internal protected method from the base class
        InternalProtectedMethod();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the derived class
        MyDerivedClass derivedObj = new MyDerivedClass();

        // Call the method from the derived class
        derivedObj.CallInternalProtectedMethod();
    }
}

```

## Output

![Program to illustrate internal protected access modifier](./output.png)
