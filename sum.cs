using System;

class Program
{
    // Declare two global variables to hold the input numbers
    static int num1, num2;

    // Function to calculate and print the sum without parameters and return value
    static void Sum()
    {
        int sum = num1 + num2; // Calculate the sum of the numbers
        Console.WriteLine("The sum of " + num1 + " and " + num2 + " is: " + sum);
    }

    static void Main()
    {
        // Prompt the user for input
        Console.Write("Enter the first number: ");
        num1 = int.Parse(Console.ReadLine()); // Read the first number

        Console.Write("Enter the second number: ");
        num2 = int.Parse(Console.ReadLine()); // Read the second number

        // Call the Sum function to calculate and print the sum
        Sum();
    }
}
