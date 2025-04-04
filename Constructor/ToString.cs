using System;

namespace RajendraConsoleApp.Day19
{
    internal class DOB
    {
        int d, m, y;
        public void GetDob()
        {
            Console.WriteLine("Enter the date/month/year: ");
            d = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
        }
        public override string ToString()
        {
            return $"date {d} month {m} year {y}";
        }
        static void Main(string[] args)
        {
            DOB d = new DOB();
            d.GetDob();
            Console.WriteLine(d);
            Console.ReadLine();
        }
    }
}