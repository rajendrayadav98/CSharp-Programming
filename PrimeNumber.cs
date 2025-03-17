using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RajendraConsoleApp.FunctionAndArray
{
    internal class PrimeNumber
    { 
        public void IsPrime(int n)
        { int prime = 0;
            for( int i=2;i<n/2;i++)
            {
                if(n%i==0)
                {
                    prime++;
                    break;
                }
               
            }
            if (prime == 0)
            {
                Console.WriteLine("its prime no:");
            }
            else
            {
                Console.WriteLine("not prime number");
            }
        }
        static void Main(string[] args)
        {
            int j=Convert.ToInt32(Console.ReadLine());
            PrimeNumber obj
                = new PrimeNumber();
            obj.IsPrime(j);
            Console.ReadLine();
        }
    }
}
