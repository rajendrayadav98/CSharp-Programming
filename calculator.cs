using System;

class Calculator
{
    static void Main()
    {
        double num1, num2, result;
        string operation;

        // Ask the user to enter the first number
        Console.WriteLine("Enter the first number:");
        num1 = Convert.ToDouble(Console.ReadLine());

        // Ask the user to enter the second number
        Console.WriteLine("Enter the second number:");
        num2 = Convert.ToDouble(Console.ReadLine());

        // Ask the user to choose an operation
        Console.WriteLine("Enter the operation (+, -, *, /):");
        operation = Console.ReadLine();

        // Perform the operation based on user input
        switch (operation)
        {
            case "+":
                result = num1 + num2;
                Console.WriteLine($"The result of {num1} + {num2} is: {result}");
                break;
            case "-":
                result = num1 - num2;
                Console.WriteLine($"The result of {num1} - {num2} is: {result}");
                break;
            case "*":
                result = num1 * num2;
                Console.WriteLine($"The result of {num1} * {num2} is: {result}");
                break;
            case "/":
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine($"The result of {num1} / {num2} is: {result}");
                }
                else
                {
                    Console.WriteLine("Error: Cannot divide by zero.");
                }
                break;
            default:
                Console.WriteLine("Invalid operation entered.");
                break;
        }

        // Wait for the user to press a key before exiting
        Console.ReadLine();
    }
}
