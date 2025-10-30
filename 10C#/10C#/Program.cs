using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // List of integers
        List<int> numbers = new List<int> { 5, 2, 9, 1, 7 };

        // Sort using LINQ method syntax
        var sortedNumbers = numbers.OrderBy(n => n);

        // Display the result
        Console.WriteLine("Sorted Numbers (Ascending):");
        foreach (var num in sortedNumbers)
        {
            Console.Write(num + " ");
        }
    }
}
