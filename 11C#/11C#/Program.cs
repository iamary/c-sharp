using System;
using System.Collections.Generic;
using System.Linq;

// Step 1: Define Student class
class Student
{
    public string Name { get; set; }
    public int Marks { get; set; }
}

class Program
{
    static void Main()
    {
        // Step 2: Create a list of students
        List<Student> students = new List<Student>
        {
            new Student { Name = "Aryaman", Marks = 75 },
            new Student { Name = "Sita", Marks = 45 },
            new Student { Name = "Ram", Marks = 60 },
            new Student { Name = "Gita", Marks = 40 },
            new Student { Name = "Maya", Marks = 90 }
        };

        // Step 3: LINQ query to get students with marks > 50
        var highScorers = from student in students
                          where student.Marks > 50
                          select student;

        // Step 4: Display the result
        Console.WriteLine("Students who scored more than 50 marks:");
        foreach (var student in highScorers)
        {
            Console.WriteLine($"{student.Name} - {student.Marks}");
        }
    }
}
