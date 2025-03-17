using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RajendraConsoleApp.FunctionAndArray
{
    internal class VoteEligibility
    {
        public void Vote(int age) 
        {
           
            if (age > 18)
            {
                Console.WriteLine("eligible for vote");
            }
            else
            {
                Console.WriteLine("not for eligible to vote");
            }
            
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter your age: ");
            n = int.Parse(Console.ReadLine());
            VoteEligibility obj = new VoteEligibility();
            obj.Vote(n);
            Console.ReadLine();

        }
    }
}
