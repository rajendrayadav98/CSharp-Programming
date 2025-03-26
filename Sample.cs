using System;

namespace RajendraConsoleApp.CSharp11
{
    internal class Sample
    {
        public static int x = 10;
        public static int y = 20;
        public static void Display()
        {
            int sum = x + y;
            Console.WriteLine("Sum of x and y = "+sum);
        }
    }
    class Example
    {
        static void Main(string[] args)
        {
            Sample.Display();
        }
    }
}
