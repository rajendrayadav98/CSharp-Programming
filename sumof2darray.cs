using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RajendraConsoleApp.FunctionAndArray
{
    internal class SumOf2DArray
    {
        static void Main()
        {
            
            int[,] a1 = new int[2, 2] {
                { 1, 2 }, { 3, 4 }
        };

            int[,] a2 = new int[2, 2] {
                { 3, 4 }, { 5, 6 }
        };
            int[,] result = new int[2, 2];
            
            for(int i = 0; i < (a1.Length/2); i++)
            {
             for(int j = 0; j < (a2.Length/2); j++)
                {
                    result[i, j] = a1[i,j] + a2[i,j];
                }
             }

                for(int i = 0;i < (a1.Length/2); i++)
            {
                for (int j = 0;j < (a2.Length/2); j++)
                {
                    Console.Write( result[i, j]+"  ");
                }
                Console.WriteLine();
            }
                
            

            Console.ReadLine();
        }
    }
}
