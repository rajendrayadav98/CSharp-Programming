using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RajendraConsoleApp.FunctionAndArray
{
    internal class IsPrimeNumber
    {
        int c = 0;
        public bool Prime(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            for (int i = 2; i < n / 2; i++)
            {
                if (n % i == 0)

                {
                    c++;
                    return false;  
                }

            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number:");
            int n = Convert.ToInt32(Console.ReadLine());

            IsPrimeNumber obj = new IsPrimeNumber();

            if (obj.Prime(n))
            {
                Console.WriteLine("Its prime  number:");
            }
            else
            {
                Console.WriteLine("Its not a prime number:");
            }
            Console.ReadLine();
        }
    } 
}
