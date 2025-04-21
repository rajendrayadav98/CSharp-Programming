using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int result = 100 / number;
            Console.WriteLine("Result: " + result);
        }
        catch (Exception ex)
        {
            LogException(ex);  // Log exception to a file
            Console.WriteLine("An error occurred. Please check the error log.");
        }
        finally
        {
            Console.WriteLine("Execution finished.");
        }
    }

    static void LogException(Exception ex)
    {
        string filePath = "error_log.txt";
        using (StreamWriter writer = new StreamWriter(filePath, true)) // true = append mode
        {
            writer.WriteLine("------ Exception at " + DateTime.Now + " ------");
            writer.WriteLine("Message: " + ex.Message);
            writer.WriteLine("StackTrace: " + ex.StackTrace);
            writer.WriteLine();
        }
    }
}
