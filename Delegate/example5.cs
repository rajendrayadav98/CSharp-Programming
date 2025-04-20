// Define a delegate named NumberCheck that accepts an int parameter and returns a bool.

// Create a method named IsEven that:-

// Takes an integer as input.

// Returns true if the number is even, otherwise returns false.

// In the Main method:

// Create an array of integers from 1 to 10.

// Assign the IsEven method to an instance of the NumberCheck delegate.

// Loop through the array and use the delegate to filter and print only the even numbers.

using System;

namespace RajendraConsoleApp.Day25_Delegates
{
    public delegate bool NumberChecks(int x);
    internal class NumberCheck
    {
        public bool IsEven(int x)
        {
            return x % 2 == 0;
        }
        static void Main(string[] args)
        {
            int [] x = { 1, 2, 3,4,5,6,7,8,9,10 };
            NumberCheck check = new NumberCheck();
            NumberChecks n = check.IsEven;
            foreach (int a in x)
            {
                if (n(a) == true)
                {
                    Console.WriteLine(a+" ");
                }
            }
        }
    }
}