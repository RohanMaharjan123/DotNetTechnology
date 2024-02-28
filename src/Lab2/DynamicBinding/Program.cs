using System;

// Base class
public class Animal
{
    // Virtual method
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a generic sound.");
    }
}

// Derived class overriding the virtual method
public class Dog : Animal
{
    // Override the virtual method
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating instances of Animal and Dog
        Animal animal = new Animal();
        Dog dog = new Dog();

        // Calling the MakeSound method on instances
        animal.MakeSound(); // Output: Animal makes a generic sound.
        dog.MakeSound();    // Output: Dog barks.

        // Using dynamic binding to call the overridden method
        Animal dynamicAnimal = new Dog();
        dynamicAnimal.MakeSound(); // Output: Dog barks.
    }
}
