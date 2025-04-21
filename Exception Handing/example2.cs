using System;

namespace RajendraConsoleApp.Day27_Handling
{
    internal class FormatExp
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the first number:");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number:");
                int y = int.Parse(Console.ReadLine());
                int z = x / y;
                Console.WriteLine("Result: " + z);
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception error");

            }
            Console.ReadLine();
        }
            
    }
}
