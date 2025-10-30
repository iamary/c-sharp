using System;

// Step 1: Define first interface
interface IPrinter
{
    void Print();
}

// Step 2: Define second interface
interface IScanner
{
    void Scan();
}

// Step 3: Implement both interfaces in a single class
class MultiFunctionDevice : IPrinter, IScanner
{
    public void Print()
    {
        Console.WriteLine("Printing document...");
    }

    public void Scan()
    {
        Console.WriteLine("Scanning document...");
    }
}

// Step 4: Main method to demonstrate
class Program
{
    static void Main(string[] args)
    {
        MultiFunctionDevice device = new MultiFunctionDevice();

        // Using methods from both interfaces
        device.Print();
        device.Scan();
    }
}
