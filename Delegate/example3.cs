// Question 1)Define a delegate named AddDelegate that:

// Accepts two integers as parameters.

// Returns an integer result.

// Create a method named Add that:

// Takes two integers.

// Returns their sum.

// In the Main method:

// Assign the Add method to an instance of the delegate.

// Invoke the delegate with two numbers, e.g., 10 and 20.

// Print the result using Console.WriteLine.

using System;

namespace RajendraConsoleApp.Day25_Delegates
{
    public delegate int AddDelegate(int x, int y);
    internal class AddDelegates
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            AddDelegates obj= new AddDelegates();
            AddDelegate ad= obj.Add;
            int c=ad(10, 20);
            Console.WriteLine("Sum of two number: "+c);
        }
    }
}