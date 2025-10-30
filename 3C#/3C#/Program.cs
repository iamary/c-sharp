using System;

// Define a class
class Student
{
    // Data members (fields / properties)
    public string Name;
    public int Age;
    public string College;

    // Member method (behavior)
    public void DisplayInfo()
    {
        Console.WriteLine("Student Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("College: " + College);
    }
}

// Main program
class Program
{
    static void Main()
    {
        // Create (instantiate) an object of the Student class
        Student student1 = new Student();

        // Assign values to object fields
        student1.Name = "Aryaman";
        student1.Age = 21;
        student1.College = "Kathmandu BernHardt College";

        // Call the method using object
        student1.DisplayInfo();

        Console.ReadLine();
    }
}
