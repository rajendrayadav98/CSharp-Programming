using System;

class Program
{
    static void Main()
    {
        int dayNumber;

        // Label for retrying in case of invalid input
        Start:
        Console.WriteLine("Enter a number between 1 and 7 to get the corresponding day of the week:");

        // Taking input from the user
        bool isValidInput = int.TryParse(Console.ReadLine(), out dayNumber);

        // Check if the input is a valid number between 1 and 7
        if (!isValidInput || dayNumber < 1 || dayNumber > 7)
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
            goto Start; // Jump to the Start label to prompt the user again
        }

        // Print the day name based on the number
        switch (dayNumber)
        {
            case 1:
                Console.WriteLine("Sunday");
                break;
            case 2:
                Console.WriteLine("Monday");
                break;
            case 3:
                Console.WriteLine("Tuesday");
                break;
            case 4:
                Console.WriteLine("Wednesday");
                break;
            case 5:
                Console.WriteLine("Thursday");
                break;
            case 6:
                Console.WriteLine("Friday");
                break;
            case 7:
                Console.WriteLine("Saturday");
                break;
        }
    }
}
