using System;

namespace RajendraConsoleApp.CSharp11
{
    internal class ConstructorSum1
    {
        int x, y;
        public  ConstructorSum1(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int GetSum()
        {
            return x + y;
        }
    
    static void Main(string[] args)
        {
            ConstructorSum1 c = new ConstructorSum1(10, 20);
           int d= c.GetSum();

            Console.WriteLine("Sum of number = " + d);
        }
    }
}