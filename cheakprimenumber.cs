using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RajendraConsoleApp.FunctionAndArray
{
    internal class CheakPrimeNumber
    {
        
        static void Main()
        {
           int PrimeNumber = 0;
            Console.WriteLine("Enter the any number: ");
            int n=Convert.ToInt32(Console.ReadLine());
            for (int i = 2 ; i <=n/2; i++)
            
                {
                  if(n%i == 0)
                {
                    PrimeNumber++;
                    break;
                }
                }
            if (PrimeNumber == 0)
            {
                Console.WriteLine("it is a prime number");
            }
            else
            {
                Console.WriteLine("it is not a prime number");
            }
        }
    }
}