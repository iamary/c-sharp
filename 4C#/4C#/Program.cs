using System;

// Base class
class Vehicle
{
    public string Brand;
    public int Speed;

    // Constructor 1 (no parameters)
    public Vehicle()
    {
        Brand = "Unknown";
        Speed = 0;
    }

    // Constructor 2 (with parameters) → Constructor Overloading
    public Vehicle(string brand, int speed)
    {
        Brand = brand;
        Speed = speed;
    }

    // Virtual method (can be overridden)
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Vehicle Brand: {Brand}");
        Console.WriteLine($"Speed: {Speed} km/h");
    }
}

// Derived class: Car
class Car : Vehicle
{
    public int NumberOfDoors;

    // Constructor calling base class constructor
    public Car(string brand, int speed, int doors) : base(brand, speed)
    {
        NumberOfDoors = doors;
    }

    // Method overriding
    public override void DisplayInfo()
    {
        Console.WriteLine("=== Car Details ===");
        base.DisplayInfo(); // Call base method
        Console.WriteLine($"Doors: {NumberOfDoors}");
    }
}

// Derived class: Bike
class Bike : Vehicle
{
    public string Type;

    // Constructor calling base class constructor
    public Bike(string brand, int speed, string type) : base(brand, speed)
    {
        Type = type;
    }

    // Method overriding
    public override void DisplayInfo()
    {
        Console.WriteLine("=== Bike Details ===");
        base.DisplayInfo();
        Console.WriteLine($"Type: {Type}");
    }
}

// Main program
class Program
{
    static void Main()
    {
        // Using overloaded constructors
        Vehicle v1 = new Vehicle();
        Vehicle v2 = new Vehicle("Toyota", 120);

        // Display base class objects
        Console.WriteLine("=== Base Vehicles ===");
        v1.DisplayInfo();
        Console.WriteLine();
        v2.DisplayInfo();

        Console.WriteLine("\n");

        // Derived class objects
        Car car1 = new Car("Tesla", 200, 4);
        Bike bike1 = new Bike("Yamaha", 150, "Sports");

        // Display derived class info
        car1.DisplayInfo();
        Console.WriteLine();
        bike1.DisplayInfo();

        Console.ReadLine();
    }
}
