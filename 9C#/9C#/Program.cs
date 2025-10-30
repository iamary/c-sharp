using System;

// Step 1: Define a delegate for the event
public delegate void TaskCompletedEventHandler(string message);

// Step 2: Create a class that raises the event
class Task
{
    // Step 3: Define the event based on the delegate
    public event TaskCompletedEventHandler TaskCompleted;

    public void DoWork()
    {
        Console.WriteLine("Task started...");

        // Simulate some work
        System.Threading.Thread.Sleep(2000);

        Console.WriteLine("Task finished!");

        // Step 4: Raise the event
        OnTaskCompleted("Task has been successfully completed!");
    }

    // Method to invoke the event safely
    protected virtual void OnTaskCompleted(string message)
    {
        if (TaskCompleted != null)
        {
            TaskCompleted(message);
        }
    }
}

// Step 5: Main method to handle the event
class Program
{
    static void Main()
    {
        Task myTask = new Task();

        // Subscribe to the event
        myTask.TaskCompleted += TaskFinishedHandler;

        // Start the task
        myTask.DoWork();
    }

    // Event handler method
    static void TaskFinishedHandler(string message)
    {
        Console.WriteLine("Event Handler: " + message);
    }
}
