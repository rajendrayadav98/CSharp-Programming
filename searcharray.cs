using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RajendraConsoleApp.CSharp11
{
    internal class SearchElement
    {
        static void Main(string[] args)
        {
            int i = 5;
            int[] arr = { 1, 2, 3, 4, 5 };
            //int[] arr1 = new int[5];

            Console.WriteLine("Enter the serached Element");
            int k=int.Parse(Console.ReadLine());
            for(int j=1; j<arr.Length; j++)
            {

                if (arr[j] == k)
                {

                    Console.WriteLine($"Entered element:{k} is found");
                    break;
                }
                else
                {
                    Console.WriteLine("not found");
                    break;
                }

            }
            
            
            Console.ReadLine();
        }
    }
}
