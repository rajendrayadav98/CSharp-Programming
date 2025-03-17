using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RajendraConsoleApp.FunctionAndArray
{
    public class AddTwoNumber
    {
        public void Add()
        {
            int num1, num2, sum;
            Console.WriteLine("Enter two number:");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            sum = num1 + num2;
            Console.WriteLine("Sum is " + sum);

        }
        static void Main(string[] args)
        {
            AddTwoNumber obj=new AddTwoNumber();
            obj.Add();
            Console.ReadLine();
        }
    }
   
}
