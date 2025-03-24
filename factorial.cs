using System;

class Factorial
{
    static void Main()
    {
        Console.WriteLine("Enter a number to find its factorial:");
        int num = Convert.ToInt32(Console.ReadLine());
        
        int factorial = 1;
        
        for (int i = 1; i <= num; i++)
        {
            factorial *= i;
        }
        
        Console.WriteLine($"The factorial of {num} is: {factorial}");
    }
}
