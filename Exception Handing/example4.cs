using System;

class Program
{
    static void Main()
    {
        try
        {
            // Try block: Code that might cause an exception
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int result = 100 / number;  // Might throw DivideByZeroException
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException ex)
        {
            // Catch block: Handles division by zero
            Console.WriteLine("Error: Cannot divide by zero.");
        }
        catch (FormatException ex)
        {
            // Catch block: Handles invalid input format
            Console.WriteLine("Error: Please enter a valid number.");
        }
        catch (Exception ex)
        {
            // General catch block: Catches other exceptions
            Console.WriteLine("An error occurred: " + ex.Message);
        }
        finally
        {
            // Finally block: Runs regardless of an exception
            Console.WriteLine("Program execution finished.");
        }
    }
}
