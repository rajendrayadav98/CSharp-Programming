using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RajendraConsoleApp.FunctionAndArray
{
    internal class SubTwoNumber
    {
        public void Sub()
        {
            int num1,num2,sub;
            Console.WriteLine("Enter number1:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number2:");
            num2 =int.Parse(Console.ReadLine());
            
            sub = num1 - num2;
            Console.WriteLine("Subtraction of num1 and num2 is: "+sub);
        }
        static void Main(string[] args)
        {
            SubTwoNumber obj= new SubTwoNumber();
            obj.Sub();
            Console.ReadLine();
        }
    }
}
