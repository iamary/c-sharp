using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        // If string has less than 2 characters, swapping isn't necessary
        if (input.Length < 2)
        {
            Console.WriteLine("Result: " + input);
            return;
        }

        // Convert string to char array for easy swapping
        char[] chars = input.ToCharArray();

        // Swap first and last characters
        char temp = chars[0];
        chars[0] = chars[chars.Length - 1];
        chars[chars.Length - 1] = temp;

        // Convert back to string
        string result = new string(chars);

        Console.WriteLine("Result: " + result);
    }
}
