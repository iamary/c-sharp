using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string result = "";

        foreach (char c in input)
        {
            if (char.IsLower(c))
                result += char.ToUpper(c);
            else if (char.IsUpper(c))
                result += char.ToLower(c);
            else
                result += c;  // keep digits, spaces, symbols same
        }

        Console.WriteLine("Converted string: " + result);
    }
}
