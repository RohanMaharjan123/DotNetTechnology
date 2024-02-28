using System;

class Car
{
    public string Model { get; set; }
    public double Mileage { get; set; }

    // Parameterized constructor
    public Car(string model, double mileage)
    {
        Model = model;
        Mileage = mileage;
    }

    // Method to display the mileage of the car
    public void DisplayMileage()
    {
        Console.WriteLine($"Mileage of {Model}: {Mileage} km/l");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create instances of Car class for three different car models
        Car car1 = new Car("Toyota", 15.5);
        Car car2 = new Car("Honda", 14.8);
        Car car3 = new Car("Ford", 12.3);

        // Display mileage of each car
        car1.DisplayMileage();
        car2.DisplayMileage();
        car3.DisplayMileage();
    }
}
