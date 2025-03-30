using System;

class Program
{
    static void Main()
    {
        // Ask for the user's name
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();

        // Ask for the user's age
        Console.WriteLine("Please enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        // Display the message
        Console.WriteLine($"Hello, {name}! You are {age} years old.");

        // End the program
        Console.ReadLine();
    }
}
