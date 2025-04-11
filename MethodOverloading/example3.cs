using System;

namespace MethodOverloadingExample
{
    public class AdditionCalculator
    {
        // Adds two integers
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Adds three integers
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        // Adds two doubles
        public double Add(double a, double b)
        {
            return a + b;
        }

        // Adds an integer and a double
        public double Add(int a, double b)
        {
            return a + b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AdditionCalculator calc = new AdditionCalculator();

            Console.WriteLine($"Add(10, 20): {calc.Add(10, 20)}");
            Console.WriteLine($"Add(5, 15, 25): {calc.Add(5, 15, 25)}");
            Console.WriteLine($"Add(2.5, 3.5): {calc.Add(2.5, 3.5)}");
            Console.WriteLine($"Add(10, 4.5): {calc.Add(10, 4.5)}");

            Console.ReadLine();
        }
    }
}
