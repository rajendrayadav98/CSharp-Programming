using System;

class Program
{
    static void Main()
    {
        // Create an array to store the numbers
        int[] numbers = new int[5];
        int sum = 0;
        double average;

        // Ask the user to enter 5 numbers
        Console.WriteLine("Please enter 5 numbers:");

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
            sum += numbers[i];
        }

        // Calculate the average
        average = (double)sum / numbers.Length;

        // Display the results
        Console.WriteLine($"The sum of the numbers is: {sum}");
        Console.WriteLine($"The average of the numbers is: {average}");

        // Wait for the user to press a key before exiting
        Console.ReadLine();
    }
}
