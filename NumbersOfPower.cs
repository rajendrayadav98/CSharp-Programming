using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RajendraConsoleApp.FunctionAndArray
{
    internal class Power
    {
        static void Main()
        {
            Console.WriteLine("Enter the first number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            double p = Math.Pow(n1, n2);
            Console.WriteLine("First nuber is power of second number:"+p);
        }
    }
}
