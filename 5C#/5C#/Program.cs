using System;

class Person
{
    // Properties
    public string Name { get; set; }
    public int Age { get; set; }

    // Indexer to access characters of Name property
    public char this[int index]
    {
        get
        {
            if (Name != null && index >= 0 && index < Name.Length)
                return Name[index];
            else
                throw new IndexOutOfRangeException("Invalid index for Name");
        }
    }

    // Method to display basic info
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Program
{
    static void Main()
    {
        // Create object
        Person p1 = new Person();
        p1.Name = "Aryaman";
        p1.Age = 21;

        // Display info
        p1.DisplayInfo();

        // Access characters of the name using indexer
        Console.WriteLine("Characters in name:");
        for (int i = 0; i < p1.Name.Length; i++)
        {
            Console.WriteLine($"Character at index {i}: {p1[i]}");
        }

        Console.ReadLine();
    }
}
