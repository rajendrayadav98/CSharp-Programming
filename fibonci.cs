using System;

class Fibonacci
{
    static void Main()
    {
        Console.WriteLine("Enter the number of terms in the Fibonacci sequence:");
        int n = Convert.ToInt32(Console.ReadLine());
        
        int a = 0, b = 1;
        
        Console.WriteLine("Fibonacci Sequence:");
        
        for (int i = 1; i <= n; i++)
        {
            Console.Write(a + " ");
            int nextTerm = a + b;
            a = b;
            b = nextTerm;
        }
    }
}
