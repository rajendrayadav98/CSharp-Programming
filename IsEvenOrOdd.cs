using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RajendraConsoleApp.FunctionAndArray
{
    internal class IsEven
    {
        public bool Number(int n)
        {
            return n % 2 == 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("enter any number:");
            int n=Convert.ToInt32(Console.ReadLine());
            IsEven obj = new IsEven();
            if (obj.Number(n))
            {
                Console.WriteLine("It is even number:");
            }
            else
            {
                Console.WriteLine("It is odd number");
            }
        }
    }
}
