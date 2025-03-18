using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RajendraConsoleApp.FunctionAndArray
{
    internal class PrintElement
    {
        static void Main()
        {
            int[,] arr1 = new int [2, 2]; 

            for (int i = 0; i < (arr1.Length/2); i++)
            {
                for (int j = 0; j < (arr1.Length/2); j++)
                {
                    Console.WriteLine("Enter the row" +(i+1)+","+(j+1)+"th any element:");
                    arr1 [i,j]  = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0;i < (arr1.Length/2);i++)
            {
                for(int j = 0;j < (arr1.Length/2);j++)
                {
                    Console.Write(arr1 [i,j]+"  ");
                }
                
            }
        }
    }
}
