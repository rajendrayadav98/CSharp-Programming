using System;

namespace RajendraConsoleApp.Day27_Handling
{
    internal class ExceptionDemo
    {
        static void Main(string[] args)
        {

            try
            {

                Console.Write("Enter 1st number:");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Enter 2nd number:");
                int y = int.Parse(Console.ReadLine());
                int z = x / y;
                Console.WriteLine("The result of division is:" + z);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            }
        }
    }
    

