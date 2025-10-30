using System;
using System.Threading.Tasks;

class Program
{
    // Async method that waits 3 seconds
    static async Task DelayedMessage()
    {
        Console.WriteLine("Waiting for 3 seconds...");
        await Task.Delay(3000); // Wait asynchronously for 3 seconds
        Console.WriteLine("3 seconds have passed! Hello!");
    }

    static async Task Main(string[] args)
    {
        // Call the async method
        await DelayedMessage();

        Console.WriteLine("Program finished.");
    }
}
