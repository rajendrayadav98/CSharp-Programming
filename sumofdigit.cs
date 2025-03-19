using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RajendraConsoleApp.FunctionAndArray
{
    internal class SumOfDigit
    {
        static void Main()
        {
            int sum = 0,r=0;

            Console.WriteLine("Eter the any  number:");
            int n=Convert.ToInt32(Console.ReadLine());
            while(n>0)
            {
                r = n % 10;
                sum += r;
                n = n / 10;
            }
            Console.WriteLine("Sum of digit: "+sum);
            Console.ReadLine();

        }
        

    }
}