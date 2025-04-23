// Write a C# program that:

// Creates a non-generic ArrayList using the System.Collections namespace.

// Adds mixed-type items to the ArrayList, including:

// A string: "Hello"

// An integer: 100

// A double: 3.14

// A boolean: true

// A character: 'A'

// Displays all elements in the ArrayList using a foreach loop.

// Displays the total number of elements in the ArrayList using the Count property

// Output:-

// Elements in the ArrayList:
// Hello
// 100
// 3.14
// True
// A

// Total number of elements in the ArrayList: 5

using System;
using System.Collections;
using System.Linq.Expressions;
using System.Runtime.Remoting.Channels;
using System.Threading;
namespace RajendraConsoleApp.Day28_Collection
{
    internal class Class5
    {
        static void Main(string[] args)
        {
            int Count = 0;
            ArrayList mixedList = new ArrayList();
            mixedList.Add("Hello");
            mixedList.Add(100);
            mixedList.Add(34.52);
            mixedList.Add('A');
            mixedList.Add(true);
            Console.WriteLine("Element in the array list: ");
            foreach(object i in mixedList)
            {
                Console.WriteLine(i);
                Count++;
            }
            Console.WriteLine($"Total number in the arraylist: {Count}");
            Console.ReadLine();
        }
    }
}