using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RajendraConsoleApp.CSharp11
{
    internal class Method1
    {
        public void Math1(int a, int b, out int c, out int d)
        {
            c = a - b;
            d = a + b;
            Console.WriteLine("Sub="+c);
            Console.WriteLine("Sum="+d);
        }
        public int Math2(int a, int b)
        {
            return a * b;
        }
        static void Main()
        {
            int c, d;
            Method1 obj = new Method1();
            obj.Math1(10, 5, out c, out d);
            int n = obj.Math2(10, 10);
            Console.WriteLine("Multipliction "+n);
            Console.ReadLine();
        }
    }
}
