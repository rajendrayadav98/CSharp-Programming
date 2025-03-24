using System;

class NestedLoopsExample
{
    static void Main()
    {
        Console.WriteLine("Multiplication Table (1 to 5):");

        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= 5; j++)
            {
                Console.Write(i * j + "\t");
            }
            Console.WriteLine();
        }
    }
}
