using System;

class Calculator
{
    // Method to add two integers
    public int Add(int a, int b)
    {
        return a + b;
    }

    // Overloaded method to add three integers
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    // Overloaded method to add two doubles
    public double Add(double a, double b)
    {
        return a + b;
    }

    static void Main()
    {
        Calculator calc = new Calculator();

        Console.WriteLine("Sum of 2 and 3: " + calc.Add(2, 3));
        Console.WriteLine("Sum of 1, 2, and 3: " + calc.Add(1, 2, 3));
        Console.WriteLine("Sum of 2.5 and 3.5: " + calc.Add(2.5, 3.5));
    }
}
