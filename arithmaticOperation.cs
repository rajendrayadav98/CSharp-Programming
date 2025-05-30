using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        double num1 = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Enter second number:");
        double num2 = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Choose an operation (+, -, *, /):");
        string operation = Console.ReadLine();
        
        double result = 0;
        
        switch (operation)
        {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                if (num2 != 0)
                    result = num1 / num2;
                else
                    Console.WriteLine("Error! Division by zero.");
                break;
            default:
                Console.WriteLine("Invalid operation.");
                return;
        }
        
        Console.WriteLine("Result: " + result);
    }
}
