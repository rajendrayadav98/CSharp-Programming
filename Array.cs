using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Enter array size: ");
        int size = int.Parse(Console.ReadLine());
        
        
        int[] arr = new int[size];
        
        
        Console.WriteLine("Enter " + size + " elements:");
        for (int i = 0; i < size; i++)
        {
            Console.Write("Element " + (i + 1) + ": ");
            arr[i] = int.Parse(Console.ReadLine());
        }
        
        
        Console.Write("Enter search element: ");
        int searchElement = int.Parse(Console.ReadLine());
        
        
        bool found = false;
        int index = -1;
        for (int i = 0; i < size; i++)
        {
            if (arr[i] == searchElement)
            {
                found = true;
                index = i;
                break;
            }
        }
        
        
        if (found)
        {
            Console.WriteLine("Element found at index " + index);
        }
        else
        {
            Console.WriteLine("Element not found.");
        }
    }
}
