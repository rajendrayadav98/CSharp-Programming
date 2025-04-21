using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter a positive number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 0)
            {
                throw new NegativeNumberException(); // throw custom exception
            }

            Console.WriteLine("You entered: " + number);
        }
        catch (NegativeNumberException ex)
        {
            Console.WriteLine("Custom Error: " + ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid input format.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("General Error: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Custom exception handling demo complete.");
        }
    }
}
