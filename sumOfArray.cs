using System;

class ArraySum
{
    static void Main()
    {
        Console.WriteLine("Enter the number of elements in the array:");
        int n = Convert.ToInt32(Console.ReadLine());
        
        int[] arr = new int[n];
        int sum = 0;
        
        Console.WriteLine("Enter the elements of the array:");
        
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
            sum += arr[i];
        }
        
        Console.WriteLine("The sum of the array elements is: " + sum);
    }
}
