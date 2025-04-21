using System;

namespace RajendraConsoleApp.Day27_Handling
{
    internal class IndexOutOfRange
    {
        static void Main(string[] args)
        {
            try
            {
                int[] a1 = new int[5];
                int i;
                Console.WriteLine("Enter 5 elements:");
                for ( i = 0; i < a1.Length + 1; i++) 
                {
                    a1[i]=Convert.ToInt32(Console.ReadLine());
                   
                }
                
            }
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("This is out of range input");
            }
            
        }
    }
}
