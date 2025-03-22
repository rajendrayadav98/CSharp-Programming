using System;

class Program
{
    
    static int sum()
    {
        int num1 = 10;
        int num2 = 20;
        return num1 + num2;  
    }

    static void Main()
    {
        
        int result = sum();
        Console.WriteLine("Sum is " + result);  
    }
}
