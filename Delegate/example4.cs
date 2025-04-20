using System;

namespace DelegateExample
{
    // Step 1: Define a delegate
    public delegate void GreetDelegate(string name);

    class Program
    {
        // Step 2: Define methods that match the delegate signature
        public static void SayHello(string name)
        {
            Console.WriteLine("Hello, " + name + "!");
        }

        public static void SayGoodbye(string name)
        {
            Console.WriteLine("Goodbye, " + name + "!");
        }

        static void Main(string[] args)
        {
            // Step 3: Instantiate delegate and assign method
            GreetDelegate greet = SayHello;

            // Step 4: Invoke delegate
            greet("Raj");

            // Reassign to another method
            greet = SayGoodbye;
            greet("Raj");

            // Optional: Multicast delegate
            greet += SayHello;
            Console.WriteLine("\nMulticast Delegate Output:");
            greet("Raj");
        }
    }
}
