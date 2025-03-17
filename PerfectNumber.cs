using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RajendraConsoleApp.FunctionAndArray
{
    internal class PerfectNumber
    {
        public void IsPerfect(int num)
        {

            int sum = 0;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == num)
            {
                Console.WriteLine("Its a perfect number");
            }
            else
            {
                Console.WriteLine("Its not  a perfect number");

            }


        }


        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter any number:");
            num = int.Parse(Console.ReadLine());

            PerfectNumber obj = new PerfectNumber();
            obj.IsPerfect(num);
        }
    }
}
