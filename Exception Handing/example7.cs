using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        try
        {
            await DoSomethingAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Caught exception: " + ex.Message);
        }
    }

    static async Task DoSomethingAsync()
    {
        await Task.Delay(1000); // Simulate some work
        throw new InvalidOperationException("Something went wrong asynchronously!");
    }
}
