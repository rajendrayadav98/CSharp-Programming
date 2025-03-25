using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RajendraConsoleApp.CSharp11
{
    internal class ReverseArray
    {
        static void Main(string[] args)
        {
            int[] OriginalArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i =OriginalArray.Length-1; i >= 0; i--)
            {
                Console.Write(OriginalArray[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
