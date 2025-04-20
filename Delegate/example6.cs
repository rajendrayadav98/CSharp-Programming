using System;

namespace DelegateAdvanced
{
    // Define a delegate that returns an int and takes two int parameters
    public delegate int Operation(int a, int b);

    class Program
    {
        // Methods matching the delegate signature
        public static int Add(int a, int b) => a + b;
        public static int Multiply(int a, int b) => a * b;

        // Method that takes a delegate as a parameter
        public static void Calculate(int x, int y, Operation op)
        {
            int result = op(x, y);
            Console.WriteLine($"Result: {result}");
        }

        static void Main(string[] args)
        {
            // Using named methods
            Operation addOp = Add;
            Operation mulOp = Multiply;

            Calculate(5, 3, addOp);  // Output: Result: 8
            Calculate(5, 3, mulOp);  // Output: Result: 15

            // Using inline anonymous method (optional)
            Calculate(10, 2, delegate (int a, int b) { return a - b; });

            // Using lambda expression (clean and modern)
            Calculate(20, 5, (a, b) => a / b);
        }
    }
}
