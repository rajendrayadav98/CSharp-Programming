using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RajendraConsoleApp.FunctionAndArray
{
    internal class CheakAge
    {
        public void Age()
        {
            Console.WriteLine("Enter the  age of person: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age == 0)
            {
                Console.WriteLine("It is  not minor not major,");
            }
            else if (age>18)
            {
                Console.WriteLine("It is major.");
            }
            else
            {
                Console.WriteLine("It is minor.");
            }

            }
        static void Main(string[] args)
        {
            CheakAge obj = new CheakAge();
            obj.Age();
        }
    }
}
