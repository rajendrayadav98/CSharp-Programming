using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RajendraConsoleApp.FunctionAndArray
{
    internal class Add2Darray
    {
        public void Add()
        {
            Console.WriteLine("Enter the no of rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the no of col: ");
            int col = int.Parse(Console.ReadLine());

            int[,] result = new int[rows, col];
            Console.WriteLine("Enter the elements for the 2D array:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    result[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    sum += result[i, j];
                }
            }


            Console.WriteLine("The sum of all elements in the 2D array is: " + sum);

        }
        static void Main(string[] args)
        {
        Add2Darray obj= new Add2Darray();
            obj.Add();
            Console.ReadLine();
        }
    }
    
}
