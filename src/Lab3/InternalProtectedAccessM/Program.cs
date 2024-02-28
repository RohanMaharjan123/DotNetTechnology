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
