using System;

// Step 1: Define a custom exception class
public class MyCustomException : Exception
{
    public MyCustomException(string message) : base(message)
    {
    }
}

class Program
{
    // Step 2: A method that throws the custom exception
    static void CheckAge(int age)
    {
        if (age < 18)
        {
            throw new MyCustomException("Age must be 18 or older to register.");
        }
        else
        {
            Console.WriteLine("Registration successful!");
        }
    }

    // Step 3: Main method to handle the exception
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            CheckAge(age);
        }
        catch (MyCustomException ex)
        {
            Console.WriteLine("Custom Exception Caught: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("General Exception: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Program ended.");
        }
    }
}
